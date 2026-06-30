using CleanArchitecture.Domain.Modules.Admin.Xidmets;
using FluentValidation;
using GenericRepository;
using Mapster;
using MediatR;
using TS.Result;

namespace CleanArchitecture.Application.Modules.Admin.Xidmets
{
    public sealed record XidmetCreateCommand(
        string Ad, 
        string Kod, 
        double Qiymet, 
        double? ITSQiymeti,
        int XidmetNovuId, 
        int? XidmetQrupuId,
        bool IsDeleted) : IRequest<Result<XidmetGetAllQueryResponse>>;

    public sealed class XidmetCreateCommandValidator : AbstractValidator<XidmetCreateCommand>
    {
        public XidmetCreateCommandValidator()
        {
            RuleFor(x => x.Ad).NotEmpty();
            RuleFor(x => x.Kod).NotEmpty();
            RuleFor(x => x.Qiymet).GreaterThanOrEqualTo(0);
        }
    }

    public sealed class XidmetCreateCommandHandler
        (IXidmetRepository repository, IUnitOfWork unitOfWork) : IRequestHandler<XidmetCreateCommand, Result<XidmetGetAllQueryResponse>>
    {
        public async Task<Result<XidmetGetAllQueryResponse>> Handle(XidmetCreateCommand request, CancellationToken cancellationToken)
        {
            var exists = await repository.AnyAsync(x => x.Kod == request.Kod, cancellationToken);
            if (exists) return Result<XidmetGetAllQueryResponse>.Failure("Bu kodla xidmət mövcuddur");

            var entity = request.Adapt<Xidmet>();
            entity.IsDeleted = request.IsDeleted;
            repository.Add(entity);
            await unitOfWork.SaveChangesAsync(cancellationToken);

            var response = new XidmetGetAllQueryResponse
            {
                Id = entity.Id,
                Ad = entity.Ad,
                Kod = entity.Kod,
                Qiymet = entity.Qiymet,
                ITSQiymeti = entity.ITSQiymeti,
                XidmetNovuId = entity.XidmetNovuId,
                XidmetNovuAdi = entity.XidmetNovu != null ? entity.XidmetNovu.Ad : "",
                XidmetQrupuId = entity.XidmetQrupuId,
                XidmetQrupuAdi = entity.XidmetQrupu != null ? entity.XidmetQrupu.Ad : "",
                IsDeleted = entity.IsDeleted,
                CreateUserName = entity.CreateUser != null ? entity.CreateUser.UserName : "none",
                CreatedDate = entity.CreatedDate,
                UpdateUserName = entity.UpdateUser != null ? entity.UpdateUser.UserName : "none",
                UpdatedDate = entity.UpdatedDate,
                DeletedUserName = entity.DeleteUser != null ? entity.DeleteUser.UserName : "none",
                DeletedDate = entity.DeletedDate
            };

            return response;
        }
    }
}
