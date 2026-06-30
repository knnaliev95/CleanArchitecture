using CleanArchitecture.Application.Modules.Accounts.Permisson;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.WebApi.Controllers.Modules.Auth.Role
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class RoleCommandController(ISender sender) : ControllerBase
    {
        [Authorize(Roles ="Admin,Terifler")]
        [HttpPost]
        public async Task<IResult> Create(PermissionCreateCommand request, CancellationToken cancellationToken)
        {
            var response = await sender.Send(request, cancellationToken);

            return response.IsSuccessful ? Results.Ok(response) : Results.InternalServerError(response);
        }

        [Authorize(Roles ="Admin,Terifler")]
        [HttpPost]
        public async Task<IResult> Delete(PermissionRemoveCommand request, CancellationToken cancellationToken)
        {
            var response = await sender.Send(request, cancellationToken);

            return response.IsSuccessful ? Results.Ok(response) : Results.InternalServerError(response);
        }
    }
}
