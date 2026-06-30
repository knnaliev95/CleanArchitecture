using CleanArchitecture.Domain.Modules.Admin.Xidmets;
using FluentValidation;
using GenericRepository;
using Mapster;
using MediatR;
using TS.Result;

namespace CleanArchitecture.Application.Modules.Admin.Xidmets
{
    public sealed record XidmetUpdateCommand(int Id, string Ad, string Kod, double Qiymet, int XidmetNovuId, int? XidmetQrupuId) : IRequest<Result<XidmetGetAllQueryResponse>>;

    public sealed class XidmetUpdateCommandValidator : AbstractValidator<XidmetUpdateCommand>
    {
        public XidmetUpdateCommandValidator()
        {
            RuleFor(x => x.Id).GreaterThan(0);
            RuleFor(x => x.Ad).NotEmpty();
        }
    }

    internal sealed class XidmetUpdateCommandHandler
        (IXidmetRepository repository, IUnitOfWork unitOfWork) : IRequestHandler<XidmetUpdateCommand, Result<XidmetGetAllQueryResponse>>
    {
        public async Task<Result<XidmetGetAllQueryResponse>> Handle(XidmetUpdateCommand request, CancellationToken cancellationToken)
        {
            var entity = await repository.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
            if (entity is null) return Result<XidmetGetAllQueryResponse>.Failure("Tapılmadı");

            var exists = await repository.AnyAsync(x => x.Kod == request.Kod && x.Id != request.Id, cancellationToken);
            if (exists) return Result<XidmetGetAllQueryResponse>.Failure("Bu kodla başqa xidmət mövcuddur");

            request.Adapt(entity);

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
