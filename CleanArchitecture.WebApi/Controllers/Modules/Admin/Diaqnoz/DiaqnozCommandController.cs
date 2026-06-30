using CleanArchitecture.Application.Modules.Admin.Diaqnozs;
using Mapster;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.WebApi.Controllers.Modules.Admin.Diaqnoz
{
    [Route("api/diaqnoz/[action]")]
    [ApiController]
    public class DiaqnozCommandController(ISender sender) : ControllerBase
    {
        [HttpPost]
        public async Task<IResult> Create(DiaqnozCreateCommand request, CancellationToken cancellationToken)
        {
            var response = await sender.Send(request, cancellationToken);
            return response.IsSuccessful ? Results.Ok(response) : Results.InternalServerError(response);
        }

        [HttpPut("{id:int}")]
        public async Task<IResult> Update(int id, DiaqnozUpdateCommand request, CancellationToken cancellationToken)
        {
            var command = request.Adapt<DiaqnozUpdateCommand>() with { Id = id };
            var response = await sender.Send(command, cancellationToken);
            return response.IsSuccessful ? Results.Ok(response) : Results.InternalServerError(response);
        }
    }
}
