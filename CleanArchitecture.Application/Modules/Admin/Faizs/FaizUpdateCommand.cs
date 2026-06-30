using CleanArchitecture.Domain.Modules.Admin.Faizs;
using FluentValidation;
using GenericRepository;
using Mapster;
using MediatR;
using TS.Result;

namespace CleanArchitecture.Application.Modules.Admin.Faizs
{
    public sealed record FaizUpdateCommand(
        int Id,
        int? HekimId,
        int? TeskilatId, 
        int? XidmetQrupuId, 
        int? XidmetId, 
        double? Mebleg, 
        double? Faizi) : IRequest<Result<FaizGetAllQueryResponse>>;

    public sealed class FaizUpdateCommandValidator : AbstractValidator<FaizUpdateCommand>
    {
        public FaizUpdateCommandValidator() => RuleFor(x => x.Id).GreaterThan(0);
    }

    internal sealed class FaizUpdateCommandHandler
        (IFaizRepository repository, IUnitOfWork unitOfWork) : IRequestHandler<FaizUpdateCommand, Result<FaizGetAllQueryResponse>>
    {
        public async Task<Result<FaizGetAllQueryResponse>> Handle(FaizUpdateCommand request, CancellationToken cancellationToken)
        {
            var entity = await repository.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
            if (entity is null) return Result<FaizGetAllQueryResponse>.Failure("Tapılmadı");

            request.Adapt(entity);

            await unitOfWork.SaveChangesAsync(cancellationToken);

            var response = new FaizGetAllQueryResponse
            {
                Id = entity.Id,
                HekimId = entity.HekimId,
                HekimAdi = entity.Hekim != null ? entity.Hekim.Ad : null,
                TeskilatId = entity.TeskilatId,
                TeskilatAdi = entity.Teskilat != null ? entity.Teskilat.Ad : null,
                XidmetQrupuId = entity.XidmetQrupuId,
                XidmetQrupuAdi = entity.XidmetQrupu != null ? entity.XidmetQrupu.Ad : null,
                XidmetId = entity.XidmetId,
                XidmetAdi = entity.Xidmet != null ? entity.Xidmet.Ad : null,
                Mebleg = entity.Mebleg,
                Faizi = entity.Faizi,
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
