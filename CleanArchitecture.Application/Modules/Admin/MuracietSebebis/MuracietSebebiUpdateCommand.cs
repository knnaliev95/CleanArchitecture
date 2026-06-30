using CleanArchitecture.Domain.Modules.Admin.MuracietSebebis;
using FluentValidation;
using GenericRepository;
using Mapster;
using MediatR;
using TS.Result;

namespace CleanArchitecture.Application.Modules.Admin.MuracietSebebis
{
    public sealed record MuracietSebebiUpdateCommand(int Id, string Ad) : IRequest<Result<MuracietSebebiGetAllQueryResponse>>;

    public sealed class MuracietSebebiUpdateCommandValidator : AbstractValidator<MuracietSebebiUpdateCommand>
    {
        public MuracietSebebiUpdateCommandValidator()
        {
            RuleFor(x => x.Id).GreaterThan(0);
            RuleFor(x => x.Ad).NotEmpty();
        }
    }

    internal sealed class MuracietSebebiUpdateCommandHandler
        (IMuracietSebebiRepository repository, IUnitOfWork unitOfWork) : IRequestHandler<MuracietSebebiUpdateCommand, Result<MuracietSebebiGetAllQueryResponse>>
    {
        public async Task<Result<MuracietSebebiGetAllQueryResponse>> Handle(MuracietSebebiUpdateCommand request, CancellationToken cancellationToken)
        {
            var entity = await repository.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
            if (entity is null) return Result<MuracietSebebiGetAllQueryResponse>.Failure("Tapılmadı");

            var exists = await repository.AnyAsync(x => x.Ad == request.Ad && x.Id != request.Id, cancellationToken);
            if (exists) return Result<MuracietSebebiGetAllQueryResponse>.Failure("Bu adda başqa səbəb mövcuddur");

            request.Adapt(entity);

            await unitOfWork.SaveChangesAsync(cancellationToken);

            var response = new MuracietSebebiGetAllQueryResponse
            {
                Id = entity.Id,
                Ad = entity.Ad,
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
