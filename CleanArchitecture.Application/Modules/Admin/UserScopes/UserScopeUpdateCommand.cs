using CleanArchitecture.Domain.Modules.Admin.UserScopes;
using FluentValidation;
using GenericRepository;
using Mapster;
using MediatR;
using TS.Result;

namespace CleanArchitecture.Application.Modules.Admin.UserScopes
{
    public sealed record UserScopeUpdateCommand(int Id, int UserId, string ScopeType, int ScopeId, string ScopeName) : IRequest<Result<UserScopeGetAllQueryResponse>>;

    public sealed class UserScopeUpdateCommandValidator : AbstractValidator<UserScopeUpdateCommand>
    {
        public UserScopeUpdateCommandValidator() => RuleFor(x => x.Id).GreaterThan(0);
    }

    internal sealed class UserScopeUpdateCommandHandler
        (IUserScopeRepository repository, IUnitOfWork unitOfWork) : IRequestHandler<UserScopeUpdateCommand, Result<UserScopeGetAllQueryResponse>>
    {
        public async Task<Result<UserScopeGetAllQueryResponse>> Handle(UserScopeUpdateCommand request, CancellationToken cancellationToken)
        {
            var entity = await repository.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
            if (entity is null) return Result<UserScopeGetAllQueryResponse>.Failure("Tapılmadı");

            request.Adapt(entity);

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
