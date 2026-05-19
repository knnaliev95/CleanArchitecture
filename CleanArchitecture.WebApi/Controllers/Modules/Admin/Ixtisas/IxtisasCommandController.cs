using CleanArchitecture.Application.Modules.Admin.Ixtisases;
using Mapster;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.WebApi.Controllers.Modules.Admin.Ixtisas
{
    [Route("api/ixtisas/[action]")]
    [ApiController]
    public class IxtisasCommandController(ISender sender) : ControllerBase
    {
        [HttpPost]
        public async Task<IResult> Create(IxtisasCreateCommand request, CancellationToken cancellationToken)
        {
            var response = await sender.Send(request, cancellationToken);
            return response.IsSuccessful ? Results.Ok(response) : Results.InternalServerError(response);
        }

        [HttpPut("{id:int}")]
        public async Task<IResult> Update(int id, IxtisasUpdateCommand request, CancellationToken cancellationToken)
        {
            var command = request.Adapt<IxtisasUpdateCommand>() with { Id = id };
            var response = await sender.Send(command, cancellationToken);

            return response.IsSuccessful
                ? Results.Ok(response)
                : Results.InternalServerError(response);
        }
    }
}
