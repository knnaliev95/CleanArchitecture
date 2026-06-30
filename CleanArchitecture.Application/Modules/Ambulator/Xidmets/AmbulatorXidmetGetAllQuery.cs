using CleanArchitecture.Domain.Core;
using CleanArchitecture.Domain.Modules.Ambulator.AmbulatorXidmets;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TS.Result;

namespace CleanArchitecture.Application.Modules.Ambulator.Xidmets
{
    public sealed record AmbulatorXidmetGetAllQuery(
        int MuracietId
        ) : IRequest<Result<XidmetResponse>>;

    public sealed class XidmetResponse : BaseEntityDto
    {
        public int MuracietId { get; set; }
        public int XidmetId { get; set; }
        public string XidmetAdi {  get; set; } = string.Empty;
        public int? GonderenId { get; set; }
        public string? GonderenAdi { get; set; }
        public int HekimId { get; set; }
        public string HekimAdi {  get; set; } = string.Empty;
        public double Qiymet {  get; set; }
        public double Mebleg {  get; set; }
        public DateOnly Tarix { get; set; }
        public TimeOnly Saat { get; set; }
        public int? AnestezioloqId { get; set; }
        public string? AnestezioloqAdi { get; set; }
        public string? AnesteziyaNovu { get; set; }
    }

    internal sealed class AmbulatorXidmetGetAllQueryHandler
        (IAmbulatorXidmetRepository repository) : IRequestHandler<AmbulatorXidmetGetAllQuery, Result<XidmetResponse>>
    {
        public async Task<Result<XidmetResponse>> Handle(AmbulatorXidmetGetAllQuery request, CancellationToken cancellationToken)
        {
            var response = await repository.GetAll()
                .Where(x => x.MuracietId == request.MuracietId)
                .Select(x => new XidmetResponse
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
                }).FirstOrDefaultAsync(cancellationToken);

            if (response is null) return Result<XidmetResponse>.Failure("Müraciətə uyğun xidmət tapılmadı");

            return response;
        } 
    }
}
