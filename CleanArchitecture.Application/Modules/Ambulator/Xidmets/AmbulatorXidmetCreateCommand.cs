using CleanArchitecture.Domain.Modules.Admin.Hekims;
using CleanArchitecture.Domain.Modules.Admin.Xidmets;
using CleanArchitecture.Domain.Modules.Ambulator.AmbulatorMuraciets;
using CleanArchitecture.Domain.Modules.Ambulator.AmbulatorXidmets;
using CleanArchitecture.Domain.Modules.Common.Kassas;
using FluentValidation;
using GenericRepository;
using Mapster;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TS.Result;

namespace CleanArchitecture.Application.Modules.Ambulator.Xidmets
{
    public sealed record AXidmetDto(
        int XidmetId,
        int? GonderenId,
        int HekimId,
        DateOnly Tarix,
        TimeOnly Saat,
        int? AnestezioloqId,
        string? AnesteziyaNovu
        );

    public sealed record AmbulatorXidmetCreateCommand(
        int PasientId,
        int TeskilatId,
        List<AXidmetDto> AXidmetler
        ) : IRequest<Result<List<XidmetResponse>>>;

    public sealed class AXidmetDtoValidator : AbstractValidator<AXidmetDto>
    {
        public AXidmetDtoValidator()
        {
            RuleFor(x => x.XidmetId)
                .GreaterThan(0)
                .WithMessage("Əlavə ediləcək xidmət mütləq seçilməlidir");

            RuleFor(x => x.HekimId)
                .GreaterThan(0)
                .WithMessage("Xidməti icra edəcək həkim mütləq seçilməlidir");

            RuleFor(x => x.Tarix)
                .NotEmpty()
                .WithMessage("Xidmət tarixi mütləq qeyd edilməlidir");

            RuleFor(x => x.Saat)
                .NotEmpty()
                .WithMessage("Xidmət saatı mütləq qeyd edilməlidir");
        }
    }

    public sealed class AmbulatorXidmetCreateCommandValidator : AbstractValidator<AmbulatorXidmetCreateCommand>
    {
        public AmbulatorXidmetCreateCommandValidator() {
            RuleFor(x => x.AXidmetler)
                .NotEmpty()
                .NotNull();

            RuleFor(x => x.PasientId)
                .GreaterThan(0)
                .WithMessage("Pasient mütləq seçilməlidir");

            RuleFor(x => x.TeskilatId)
                .GreaterThan(0)
                .WithMessage("Təşkilat mütləq seçilməlidir");

            RuleForEach(x => x.AXidmetler)
                .SetValidator(new AXidmetDtoValidator());
        }
    }

    internal sealed class AmbulatorXidmetCreateCommandHandler
        (IAmbulatorXidmetRepository repository,
        IAmbulatorMuracietRepository muracietRepository,
        IXidmetRepository xidmetRepository,
        IHekimRepository hekimRepository,
        IKassaRepository kassaRepository,
        IUnitOfWork unitOfWork) : IRequestHandler<AmbulatorXidmetCreateCommand, Result<List<XidmetResponse>>>
    {
        public async Task<Result<List<XidmetResponse>>> Handle(AmbulatorXidmetCreateCommand request, CancellationToken cancellationToken)
        {
            int muracietId;
            var muraciet = await muracietRepository
                .FirstOrDefaultAsync(x => x.Tarix == request.AXidmetler[0].Tarix && x.PasientId == request.PasientId, cancellationToken);

            if(muraciet is null)
            {
                AmbulatorMuraciet aMuraciet = new()
                {
                    PasientId = request.PasientId,
                    TeskilatId = request.TeskilatId,
                    Tarix = request.AXidmetler[0].Tarix
                };

                muracietRepository.Add(aMuraciet);

                await unitOfWork.SaveChangesAsync(cancellationToken);

                muracietId = aMuraciet.Id;
            }
            else
            {
                muracietId = muraciet.Id;
            }

            List<int> xidmetIds = request.AXidmetler.Select(x => x.XidmetId).ToList();
            List<int> hekimIds = request.AXidmetler.Select(x => x.HekimId).ToList();

            var xidmetler = await xidmetRepository
                .Where(x => xidmetIds.Contains(x.Id)).ToListAsync(cancellationToken);

            var hekimler = await hekimRepository
                .Where(x => hekimIds.Contains(x.Id)).ToListAsync(cancellationToken);

            var hekimSonSiralar = await repository
            .Where(x => hekimIds.Contains(x.HekimId))
            .GroupBy(x => new { x.HekimId, x.Xidmet.XidmetQrupuId }) // Əgər modeldə varsa qrupa görə qruplaşdırırıq
            .Select(g => new
            {
                HekimId = g.Key.HekimId,
                QrupId = g.Key.XidmetQrupuId,
                SonSira = g.Max(x => x.Sira)
            })
            .ToListAsync(cancellationToken);

            var siraTracker = new Dictionary<string, int>();
            int? laboratoriyaSira = null;

            List<AmbulatorXidmet> newXidmets = [];
            List<Kassa> kassas = [];

            foreach(var item in request.AXidmetler)
            {
                AmbulatorXidmet newXidmet = item.Adapt<AmbulatorXidmet>();
                newXidmet.MuracietId = muracietId;

                Xidmet itemXidmet = xidmetler.First(x => x.Id == item.XidmetId);

                string nov = itemXidmet.XidmetNovu!.Ad; // Məs: "Laboratoriya", "Radiologiya", "Ambulator"
                string qrup = itemXidmet.XidmetQrupu?.Ad ?? "Standart";

                if (nov == "Laboratoriya")
                {
                    // Laboratoriyada eyni müraciətdə neçə xidmət olur-olsun sıra dəyişmir
                    if (!laboratoriyaSira.HasValue)
                    {
                        // DB-dən həmin həkim üçün ən son sıranı tapırıq
                        int dbSonSira = hekimSonSiralar
                            .FirstOrDefault(x => x.HekimId == item.HekimId)?.SonSira ?? 0;
                        laboratoriyaSira = dbSonSira + 1;
                    }
                    newXidmet.Sira = laboratoriyaSira.Value;
                }
                else if (nov == "Radiologiya")
                {
                    // Hər qrupa (mrt, kt) və həkimə görə unikal açar yaradırıq
                    string key = $"Radio_{item.HekimId}_{qrup}";

                    if (!siraTracker.ContainsKey(key))
                    {
                        int dbSonSira = hekimSonSiralar
                            .FirstOrDefault(x => x.HekimId == item.HekimId && x.QrupId == itemXidmet.XidmetQrupuId)?.SonSira ?? 0;
                        siraTracker[key] = dbSonSira + 1;
                    }
                    else
                    {
                        siraTracker[key]++;
                    }
                    newXidmet.Sira = siraTracker[key];
                }
                else
                {
                    // Digər xidmətlər üçün normal həkim bazlı sıra
                    string key = $"Normal_{item.HekimId}";

                    if (!siraTracker.ContainsKey(key))
                    {
                        int dbSonSira = hekimSonSiralar
                            .Where(x => x.HekimId == item.HekimId)
                            .Select(x => x.SonSira)
                            .DefaultIfEmpty(0)
                            .Max() ?? 0;
                        siraTracker[key] = dbSonSira + 1;
                    }
                    else
                    {
                        siraTracker[key]++;
                    }
                    newXidmet.Sira = siraTracker[key];
                }
                newXidmet.Qiymet = itemXidmet.Qiymet;

                if(request.TeskilatId == 2)
                {
                    newXidmet.Mebleg = itemXidmet.ITSQiymeti ?? 0;
                    Kassa kassa = new()
                    {
                        PasientId = request.PasientId,
                        XidmetId = item.XidmetId,
                        Mebleg = itemXidmet.ITSQiymeti ?? 0
                    };
                    kassas.Add(kassa);
                }else if(request.TeskilatId == 1)
                {
                    newXidmet.Mebleg = itemXidmet.Qiymet;
                    Kassa kassa = new()
                    {
                        PasientId = request.PasientId,
                        XidmetId = item.XidmetId,
                        Mebleg = itemXidmet.Qiymet
                    };
                    kassas.Add(kassa);
                }
                else
                {
                    newXidmet.Mebleg = 0;
                    Kassa kassa = new()
                    {
                        PasientId = request.PasientId,
                        XidmetId = item.XidmetId,
                        Mebleg = 0,
                        OdenisTarixi = item.Tarix,
                        Status = true,
                        OdenisNovu = "Müqavilə"
                    };
                    kassas.Add(kassa);
                }

                newXidmets.Add(newXidmet);
            }

            repository.AddRange(newXidmets);
            kassaRepository.AddRange(kassas);

            await unitOfWork.SaveChangesAsync(cancellationToken);

            var response = newXidmets.Select(x => new XidmetResponse
            {
                Id = x.Id,
                MuracietId = x.MuracietId,
                XidmetId = x.XidmetId,
                XidmetAdi = x.Xidmet != null ? x.Xidmet.Ad : string.Empty,
                GonderenId = x.GonderenId,
                GonderenAdi = x.Gonderen != null ? x.Gonderen.Ad : string.Empty,
                HekimId = x.HekimId,
                HekimAdi = x.Hekim != null ? x.Hekim.Ad : string.Empty,
                Qiymet = x.Qiymet,
                Mebleg = x.Mebleg,
                Tarix = x.Tarix,
                Saat = x.Saat,
                AnestezioloqId = x.AnestezioloqId,
                AnesteziyaNovu = x.AnesteziyaNovu,
                IsDeleted = x.IsDeleted,
                CreateUserName = x.CreateUser != null ? x.CreateUser.UserName : "none",
                CreatedDate = x.CreatedDate,
                UpdateUserName = x.UpdateUser != null ? x.UpdateUser.UserName : "none",
                UpdatedDate = x.UpdatedDate,
                DeletedUserName = x.DeleteUser != null ? x.DeleteUser.UserName : "none",
                DeletedDate = x.DeletedDate
            }).ToList();

            return response;
        }
    }
}
