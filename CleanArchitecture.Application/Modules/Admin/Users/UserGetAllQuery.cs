using CleanArchitecture.Domain.Core;
using CleanArchitecture.Domain.Modules.Accounts.Users;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace CleanArchitecture.Application.Modules.Admin.Users
{
    public class UserGetAllQuery() : IRequest<IQueryable<UserGetAllQueryResponse>>;

    public sealed class UserGetAllQueryResponse : BaseEntityDto
    {
        public string Ad { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
    }

    internal sealed class UserGetAllQueryHandler
        (UserManager<AppUser> userManager) : IRequestHandler<UserGetAllQuery, IQueryable<UserGetAllQueryResponse>>
    {
        public Task<IQueryable<UserGetAllQueryResponse>> Handle(UserGetAllQuery request, CancellationToken cancellationToken)
        {
            var response = userManager.Users.Select(x => new UserGetAllQueryResponse
            {
                Id = x.Id,
                Ad = x.Ad,
                Username = x.UserName ?? string.Empty,
                IsDeleted = x.IsDeleted,
                CreateUserName = x.CreateUser != null ? x.CreateUser.UserName : "none",
                CreatedDate = x.CreatedDate,
                UpdateUserName = x.UpdateUser != null ? x.UpdateUser.UserName : "none",
                UpdatedDate = x.UpdatedDate,
                DeletedUserName = x.DeleteUser != null ? x.DeleteUser.UserName : "none",
                DeletedDate = x.DeletedDate
            });

            return Task.FromResult(response);
        }
    }
}
