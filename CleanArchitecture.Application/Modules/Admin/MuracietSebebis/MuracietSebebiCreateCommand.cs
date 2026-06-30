using CleanArchitecture.Domain.Modules.Admin.MuracietSebebis;
using FluentValidation;
using GenericRepository;
using Mapster;
using MediatR;
using TS.Result;

namespace CleanArchitecture.Application.Modules.Admin.MuracietSebebis
{
    public sealed record MuracietSebebiCreateCommand(string Ad, bool IsDeleted) : IRequest<Result<MuracietSebebiGetAllQueryResponse>>;

    public sealed class MuracietSebebiCreateCommandValidator : AbstractValidator<MuracietSebebiCreateCommand>
    {
        public MuracietSebebiCreateCommandValidator() => RuleFor(x => x.Ad).NotEmpty();
    }

    public sealed class MuracietSebebiCreateCommandHandler
        (IMuracietSebebiRepository repository, IUnitOfWork unitOfWork) : IRequestHandler<MuracietSebebiCreateCommand, Result<MuracietSebebiGetAllQueryResponse>>
    {
        public async Task<Result<MuracietSebebiGetAllQueryResponse>> Handle(MuracietSebebiCreateCommand request, CancellationToken cancellationToken)
        {
            var exists = await repository.AnyAsync(x => x.Ad == request.Ad, cancellationToken);
            if (exists) return Result<MuracietSebebiGetAllQueryResponse>.Failure("Bu adda səbəb mövcuddur");

            var entity = request.Adapt<MuracietSebebi>();
            entity.IsDeleted = request.IsDeleted;
            repository.Add(entity);
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
