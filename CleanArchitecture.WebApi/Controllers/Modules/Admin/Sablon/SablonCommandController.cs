using CleanArchitecture.Application.Moduleentity.Admin.Sablons;
using CleanArchitecture.Application.Modules.Admin.Sablons;
using Mapster;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.WebApi.Controllers.Modules.Admin.Sablon
{
    [Route("api/sablon/[action]")]
    [ApiController]
    public class SablonCommandController(ISender sender) : ControllerBase
    {
        [HttpPost]
        public async Task<IResult> Create(SablonCreateCommand request, CancellationToken cancellationToken)
        {
            var response = await sender.Send(request, cancellationToken);
            return response.IsSuccessful ? Results.Ok(response) : Results.InternalServerError(response);
        }

        [HttpPut("{id:int}")]
        public async Task<IResult> Update(int id, SablonUpdateCommand request, CancellationToken cancellationToken)
        {
            var command = request.Adapt<SablonUpdateCommand>() with { Id = id };
            var response = await sender.Send(command, cancellationToken);
            return response.IsSuccessful ? Results.Ok(response) : Results.InternalServerError(response);
        }
    }
}
