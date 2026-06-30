using CleanArchitecture.Application.Modules.Admin.XidmetQrupus;
using Mapster;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.WebApi.Controllers.Modules.Admin.XidmetQrupu
{
    [Route("api/xidmetQrupu/[action]")]
    [ApiController]
    public class XidmetQrupuCommandController(ISender sender) : ControllerBase
    {
        [HttpPost]
        public async Task<IResult> Create(XidmetQrupuCreateCommand request, CancellationToken cancellationToken)
        {
            var response = await sender.Send(request, cancellationToken);
            return response.IsSuccessful ? Results.Ok(response) : Results.InternalServerError(response);
        }

        [HttpPut("{id:int}")]
        public async Task<IResult> Update(int id, XidmetQrupuUpdateCommand request, CancellationToken cancellationToken)
        {
            var command = request.Adapt<XidmetQrupuUpdateCommand>() with { Id = id };
            var response = await sender.Send(command, cancellationToken);
            return response.IsSuccessful ? Results.Ok(response) : Results.InternalServerError(response);
        }
    }
}
