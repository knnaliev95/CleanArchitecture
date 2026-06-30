using CleanArchitecture.Domain.Core;
using CleanArchitecture.Domain.Modules.Admin.UserScopes;
using MediatR;

namespace CleanArchitecture.Application.Modules.Admin.UserScopes
{
    public sealed record UserScopeGetAllQuery() : IRequest<IQueryable<UserScopeGetAllQueryResponse>>;

    public sealed class UserScopeGetAllQueryResponse : BaseEntityDto
    {
        public int UserId { get; set; }
        public string ScopeType { get; set; } = string.Empty;
        public int ScopeId { get; set; }
        public string ScopeName { get; set; } = string.Empty;
    }

    internal sealed class UserScopeGetAllQueryHandler
        (IUserScopeRepository repository) : IRequestHandler<UserScopeGetAllQuery, IQueryable<UserScopeGetAllQueryResponse>>
    {
        public Task<IQueryable<UserScopeGetAllQueryResponse>> Handle(UserScopeGetAllQuery request, CancellationToken cancellationToken)
        {
            var response = (from u in repository.GetAll()
                            select new UserScopeGetAllQueryResponse
                            {
                                Id = u.Id,
                                UserId = u.UserId,
                                ScopeType = u.ScopeType,
                                ScopeId = u.ScopeId,
                                ScopeName = u.ScopeName,
                                IsDeleted = u.IsDeleted,
                                CreateUserName = u.CreateUser != null ? u.CreateUser.UserName : "none",
                                CreatedDate = u.CreatedDate,
                                UpdateUserName = u.UpdateUser != null ? u.UpdateUser.UserName : "none",
                                UpdatedDate = u.UpdatedDate,
                                DeletedUserName = u.DeleteUser != null ? u.DeleteUser.UserName : "none",
                                DeletedDate = u.DeletedDate
                            });

            return Task.FromResult(response);
        }
    }
}
