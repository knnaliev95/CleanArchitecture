using CleanArchitecture.Domain.Modules.Admin.Faizs;
using FluentValidation;
using GenericRepository;
using Mapster;
using MediatR;
using TS.Result;

namespace CleanArchitecture.Application.Modules.Admin.Faizs
{
    public sealed record FaizCreateCommand(
        int? HekimId,
        int? TeskilatId,
        int? XidmetQrupuId,
        int? XidmetId,
        double? Mebleg,
        double? Faizi
    , bool IsDeleted
    ) : IRequest<Result<FaizGetAllQueryResponse>>;

    public sealed class FaizCreateCommandValidator : AbstractValidator<FaizCreateCommand>
    {
        public FaizCreateCommandValidator()
        {
            // No required fields in domain, but validate numeric ranges if present
        }
    }

    internal sealed class FaizCreateCommandHandler
        (IFaizRepository repository, IUnitOfWork unitOfWork) : IRequestHandler<FaizCreateCommand, Result<FaizGetAllQueryResponse>>
    {
        public async Task<Result<FaizGetAllQueryResponse>> Handle(FaizCreateCommand request, CancellationToken cancellationToken)
        {
            var entity = request.Adapt<Faiz>();
            entity.IsDeleted = request.IsDeleted;
            repository.Add(entity);
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
