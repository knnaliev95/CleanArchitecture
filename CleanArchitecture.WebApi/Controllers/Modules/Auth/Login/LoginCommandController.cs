using CleanArchitecture.Application.Modules.Accounts.Login;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.WebApi.Controllers.Modules.Auth.Login
{
    [Route("api/authback")]
    [ApiController]
    public class LoginCommandController(ISender sender) : ControllerBase
    {
        [HttpPost("login")]
        public async Task<IResult> Login(LoginCommand request, CancellationToken cancellationToken)
        {
            var response = await sender.Send(request, cancellationToken);

            return response.IsSuccessful ? Results.Ok(response) : Results.InternalServerError(response);
        }
    }
}
