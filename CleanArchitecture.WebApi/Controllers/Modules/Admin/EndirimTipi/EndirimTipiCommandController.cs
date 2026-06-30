using CleanArchitecture.Application.Modules.Admin.EndirimTipis;
using Mapster;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.WebApi.Controllers.Modules.Admin.EndirimTipi
{
    [Route("api/endirimTipi/[action]")]
    [ApiController]
    public class EndirimTipiCommandController(ISender sender) : ControllerBase
    {
        [HttpPost]
        public async Task<IResult> Create(EndirimTipiCreateCommand request, CancellationToken cancellationToken)
        {
            var response = await sender.Send(request, cancellationToken);
            return response.IsSuccessful ? Results.Ok(response) : Results.InternalServerError(response);
        }

        [HttpPut("{id:int}")]
        public async Task<IResult> Update(int id, EndirimTipiUpdateCommand request, CancellationToken cancellationToken)
        {
            var command = request.Adapt<EndirimTipiUpdateCommand>() with { Id = id };
            var response = await sender.Send(command, cancellationToken);
            return response.IsSuccessful ? Results.Ok(response) : Results.InternalServerError(response);
        }
    }
}
