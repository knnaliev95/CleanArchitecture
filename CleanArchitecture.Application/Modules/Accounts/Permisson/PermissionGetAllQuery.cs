using MediatR;
using Microsoft.AspNetCore.Identity;

namespace CleanArchitecture.Application.Modules.Accounts.Permisson
{
    public sealed class PermissionGetAllQuery() : IRequest<IQueryable<IdentityRole<int>>>;


    internal sealed class PermissionGetAllQueryHandler
        (RoleManager<IdentityRole<int>> roleManager) : IRequestHandler<PermissionGetAllQuery, IQueryable<IdentityRole<int>>>
    {
        public Task<IQueryable<IdentityRole<int>>> Handle(PermissionGetAllQuery request, CancellationToken cancellationToken)
        {
            var response = roleManager.Roles;

            return Task.FromResult(response);
        }
    }
}
