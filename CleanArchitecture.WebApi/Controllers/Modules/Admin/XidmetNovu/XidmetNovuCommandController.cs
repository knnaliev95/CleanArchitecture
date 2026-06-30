using CleanArchitecture.Application.Modules.Admin.XidmetNovus;
using Mapster;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.WebApi.Controllers.Modules.Admin.XidmetNovu
{
    [Route("api/xidmetNovu/[action]")]
    [ApiController]
    public class XidmetNovuCommandController(ISender sender) : ControllerBase
    {
        [Authorize]
        [HttpPost]
        public async Task<IResult> Create(XidmetNovuCreateCommand request, CancellationToken cancellationToken)
        {
            var response = await sender.Send(request, cancellationToken);
            return response.IsSuccessful ? Results.Ok(response) : Results.InternalServerError(response);
        }

        [HttpPut("{id:int}")]
        public async Task<IResult> Update(int id, XidmetNovuUpdateCommand request, CancellationToken cancellationToken)
        {
            var command = request.Adapt<XidmetNovuUpdateCommand>() with { Id = id };
            var response = await sender.Send(command, cancellationToken);
            return response.IsSuccessful ? Results.Ok(response) : Results.InternalServerError(response);
        }
    }
}
