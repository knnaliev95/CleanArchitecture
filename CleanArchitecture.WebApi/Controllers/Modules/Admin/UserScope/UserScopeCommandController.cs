using CleanArchitecture.Application.Modules.Admin.UserScopes;
using Mapster;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.WebApi.Controllers.Modules.Admin.UserScope
{
    [Route("api/userScope/[action]")]
    [ApiController]
    public class UserScopeCommandController(ISender sender) : ControllerBase
    {
        [HttpPost]
        public async Task<IResult> Create(UserScopeCreateCommand request, CancellationToken cancellationToken)
        {
            var response = await sender.Send(request, cancellationToken);
            return response.IsSuccessful ? Results.Ok(response) : Results.InternalServerError(response);
        }

        [HttpPut("{id:int}")]
        public async Task<IResult> Update(int id, UserScopeUpdateCommand request, CancellationToken cancellationToken)
        {
            var command = request.Adapt<UserScopeUpdateCommand>() with { Id = id };
            var response = await sender.Send(command, cancellationToken);
            return response.IsSuccessful ? Results.Ok(response) : Results.InternalServerError(response);
        }
    }
}
