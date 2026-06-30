using CleanArchitecture.Application.Modules.Admin.Hekims;
using Mapster;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.WebApi.Controllers.Modules.Admin.Hekim
{
    [Route("api/hekim/[action]")]
    [ApiController]
    public class HekimCommandController(ISender sender) : ControllerBase
    {
        [HttpPost]
        public async Task<IResult> Create(HekimCreateCommand request, CancellationToken cancellationToken)
        {
            var response = await sender.Send(request, cancellationToken);

            return response.IsSuccessful ? Results.Ok(response) : Results.InternalServerError(response);
        }

        [HttpPut("{id:int}")]
        public async Task<IResult> Update(int id, HekimUpdateCommand request, CancellationToken cancellationToken)
        {
            var command = request.Adapt<HekimUpdateCommand>() with { Id = id };
            var response = await sender.Send(command, cancellationToken);

            return response.IsSuccessful ? Results.Ok(response) : Results.InternalServerError(response);
        }
    }
}
