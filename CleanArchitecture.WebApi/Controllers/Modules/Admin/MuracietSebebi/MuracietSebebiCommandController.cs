using CleanArchitecture.Application.Modules.Admin.MuracietSebebis;
using Mapster;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.WebApi.Controllers.Modules.Admin.MuracietSebebi
{
    [Route("api/muracietSebebi/[action]")]
    [ApiController]
    public class MuracietSebebiCommandController(ISender sender) : ControllerBase
    {
        [HttpPost]
        public async Task<IResult> Create(MuracietSebebiCreateCommand request, CancellationToken cancellationToken)
        {
            var response = await sender.Send(request, cancellationToken);
            return response.IsSuccessful ? Results.Ok(response) : Results.InternalServerError(response);
        }

        [HttpPut("{id:int}")]
        public async Task<IResult> Update(int id, MuracietSebebiUpdateCommand request, CancellationToken cancellationToken)
        {
            var command = request.Adapt<MuracietSebebiUpdateCommand>() with { Id = id };
            var response = await sender.Send(command, cancellationToken);
            return response.IsSuccessful ? Results.Ok(response) : Results.InternalServerError(response);
        }
    }
}
