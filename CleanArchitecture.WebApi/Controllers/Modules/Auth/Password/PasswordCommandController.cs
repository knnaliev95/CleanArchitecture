using CleanArchitecture.Application.Modules.Accounts.Passwords;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.WebApi.Controllers.Modules.Auth.Password
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PasswordCommandController(ISender sender) : ControllerBase
    {
        [Authorize(Roles = "Admin,Terifler")]
        [HttpPost]
        public async Task<IResult> Reset(ResetPasswordCommand request, CancellationToken cancellationToken)
        {
            var response = await sender.Send(request, cancellationToken);

            return response.IsSuccessful ? Results.Ok(response) : Results.InternalServerError(response);
        }

        [Authorize]
        [HttpPost]
        public async Task<IResult> Reset(ChangePasswordCommand request, CancellationToken cancellationToken)
        {
            var response = await sender.Send(request, cancellationToken);

            return response.IsSuccessful ? Results.Ok(response) : Results.InternalServerError(response);
        }
    }
}
