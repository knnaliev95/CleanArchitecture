using CleanArchitecture.Application.Modules.Admin.Xidmets;
using Mapster;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.WebApi.Controllers.Modules.Admin.Xidmet
{
    [Route("api/xidmet/[action]")]
    [ApiController]
    public class XidmetCommandController(ISender sender) : ControllerBase
    {
        [HttpPost]
        public async Task<IResult> Create(XidmetCreateCommand request, CancellationToken cancellationToken)
        {
            var response = await sender.Send(request, cancellationToken);
            return response.IsSuccessful ? Results.Ok(response) : Results.InternalServerError(response);
        }

        [HttpPut("{id:int}")]
        public async Task<IResult> Update(int id, XidmetUpdateCommand request, CancellationToken cancellationToken)
        {
            var command = request.Adapt<XidmetUpdateCommand>() with { Id = id };
            var response = await sender.Send(command, cancellationToken);
            return response.IsSuccessful ? Results.Ok(response) : Results.InternalServerError(response);
        }
    }
}
