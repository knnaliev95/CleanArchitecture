using CleanArchitecture.Domain.Modules.Admin.Sablons;
using FluentValidation;
using GenericRepository;
using Mapster;
using MediatR;
using TS.Result;

namespace CleanArchitecture.Application.Modules.Admin.Sablons
{
    public sealed record SablonUpdateCommand(int Id, string Ad, int HekimId, int XidmetQrupuId, string Data) : IRequest<Result<SablonGetAllQueryResponse>>;

    public sealed class SablonUpdateCommandValidator : AbstractValidator<SablonUpdateCommand>
    {
        public SablonUpdateCommandValidator()
        {
            RuleFor(x => x.Id).GreaterThan(0);
            RuleFor(x => x.Ad).NotEmpty();
        }
    }

    internal sealed class SablonUpdateCommandHandler
        (ISablonRepository repository, IUnitOfWork unitOfWork) : IRequestHandler<SablonUpdateCommand, Result<SablonGetAllQueryResponse>>
    {
        public async Task<Result<SablonGetAllQueryResponse>> Handle(SablonUpdateCommand request, CancellationToken cancellationToken)
        {
            var entity = await repository.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
            if (entity is null) return Result<SablonGetAllQueryResponse>.Failure("Tapılmadı");

            request.Adapt(entity);

            await unitOfWork.SaveChangesAsync(cancellationToken);

            var response = new SablonGetAllQueryResponse
            {
                Id = entity.Id,
                Ad = entity.Ad,
                HekimId = entity.HekimId,
                HekimAdi = entity.Hekim != null ? entity.Hekim.Ad : string.Empty,
                XidmetQrupuId = entity.XidmetQrupuId,
                XidmetQrupuAdi = entity.XidmetQrupu != null ? entity.XidmetQrupu.Ad : string.Empty,
                Data = entity.Data,
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
