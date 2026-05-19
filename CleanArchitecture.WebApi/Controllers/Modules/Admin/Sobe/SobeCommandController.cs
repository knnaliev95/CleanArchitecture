using CleanArchitecture.Application.Modules.Admin.Sobeler;
using Mapster;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.WebApi.Controllers.Modules.Admin.Sobe
{
    [Route("api/sobe/[action]")]
    [ApiController]
    public class SobeCommandController(ISender sender) : ControllerBase
    {
        [HttpPost]
        public async Task<IResult> Create(SobeCreateCommand request, CancellationToken cancellationToken)
        {
            var response = await sender.Send(request, cancellationToken);

            return response.IsSuccessful ? Results.Ok(response) : Results.InternalServerError(response);
        }

        [HttpPut("{id:int}")]
        public async Task<IResult> Update(int id, SobeUpdateCommand request, CancellationToken cancellationToken)
        {
            var command = request.Adapt<SobeUpdateCommand>() with { Id = id };
            var response = await sender.Send(command, cancellationToken);

            return response.IsSuccessful
                ? Results.Ok(response)
                : Results.InternalServerError(response);
        }
    }
}
