using CleanArchitecture.Application.Modules.Admin.Sablons;
using CleanArchitecture.Domain.Modules.Admin.Sablons;
using FluentValidation;
using GenericRepository;
using Mapster;
using MediatR;
using TS.Result;

namespace CleanArchitecture.Application.Moduleentity.Admin.Sablons
{
    public sealed record SablonCreateCommand(string Ad, int HekimId, int XidmetQrupuId, string Data, bool IsDeleted) : IRequest<Result<SablonGetAllQueryResponse>>;

    public sealed class SablonCreateCommandValidator : AbstractValidator<SablonCreateCommand>
    {
        public SablonCreateCommandValidator()
        {
            RuleFor(x => x.Ad).NotEmpty();
            RuleFor(x => x.HekimId).GreaterThan(0);
            RuleFor(x => x.XidmetQrupuId).GreaterThan(0);
        }
    }

    public sealed class SablonCreateCommandHandler
        (ISablonRepository repository, IUnitOfWork unitOfWork) : IRequestHandler<SablonCreateCommand, Result<SablonGetAllQueryResponse>>
    {
        public async Task<Result<SablonGetAllQueryResponse>> Handle(SablonCreateCommand request, CancellationToken cancellationToken)
        {
            var entity = request.Adapt<Sablon>();
            entity.IsDeleted = request.IsDeleted;
            repository.Add(entity);
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
