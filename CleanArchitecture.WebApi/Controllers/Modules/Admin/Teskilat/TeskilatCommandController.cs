using CleanArchitecture.Application.Modules.Admin.Teskilats;
using Mapster;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.WebApi.Controllers.Modules.Admin.Teskilat
{
    [Route("api/teskilat/[action]")]
    [ApiController]
    public class TeskilatCommandController(ISender sender) : ControllerBase
    {
        [HttpPost]
        public async Task<IResult> Create(TeskilatCreateCommand request, CancellationToken cancellationToken)
        {
            var response = await sender.Send(request, cancellationToken);

            return response.IsSuccessful ? Results.Ok(response) : Results.InternalServerError(response);
        }

        [HttpPut("{id:int}")]
        public async Task<IResult> Update(int id, TeskilatUpdateCommand request, CancellationToken cancellationToken)
        {
            var command = request.Adapt<TeskilatUpdateCommand>() with { Id = id };
            var response = await sender.Send(command, cancellationToken);

            return response.IsSuccessful ? Results.Ok(response) : Results.InternalServerError(response);
        }
    }
}
