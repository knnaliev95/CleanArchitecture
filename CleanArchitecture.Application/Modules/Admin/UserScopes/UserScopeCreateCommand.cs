using CleanArchitecture.Domain.Modules.Admin.UserScopes;
using FluentValidation;
using GenericRepository;
using Mapster;
using MediatR;
using TS.Result;

namespace CleanArchitecture.Application.Modules.Admin.UserScopes
{
    public sealed record UserScopeCreateCommand(int UserId, string ScopeType, int ScopeId, string ScopeName, bool IsDeleted) : IRequest<Result<UserScopeGetAllQueryResponse>>;

    public sealed class UserScopeCreateCommandValidator : AbstractValidator<UserScopeCreateCommand>
    {
        public UserScopeCreateCommandValidator()
        {
            RuleFor(x => x.UserId).GreaterThan(0);
            RuleFor(x => x.ScopeType).NotEmpty();
        }
    }

    public sealed class UserScopeCreateCommandHandler
        (IUserScopeRepository repository, IUnitOfWork unitOfWork) : IRequestHandler<UserScopeCreateCommand, Result<UserScopeGetAllQueryResponse>>
    {
        public async Task<Result<UserScopeGetAllQueryResponse>> Handle(UserScopeCreateCommand request, CancellationToken cancellationToken)
        {
            var entity = request.Adapt<UserScope>();
            entity.IsDeleted = request.IsDeleted;
            repository.Add(entity);
            await unitOfWork.SaveChangesAsync(cancellationToken);

            var response = new UserScopeGetAllQueryResponse
            {
                Id = entity.Id,
                UserId = entity.UserId,
                ScopeType = entity.ScopeType,
                ScopeId = entity.ScopeId,
                ScopeName = entity.ScopeName,
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
