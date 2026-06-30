using CleanArchitecture.Application.Modules.Admin.Faizs;
using Mapster;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.WebApi.Controllers.Modules.Admin.Faiz
{
    [Route("api/faiz/[action]")]
    [ApiController]
    public class FaizCommandController(ISender sender) : ControllerBase
    {
        [HttpPost]
        public async Task<IResult> Create(FaizCreateCommand request, CancellationToken cancellationToken)
        {
            var response = await sender.Send(request, cancellationToken);
            return response.IsSuccessful ? Results.Ok(response) : Results.InternalServerError(response);
        }

        [HttpPut("{id:int}")]
        public async Task<IResult> Update(int id, FaizUpdateCommand request, CancellationToken cancellationToken)
        {
            var command = request.Adapt<FaizUpdateCommand>() with { Id = id };
            var response = await sender.Send(command, cancellationToken);
            return response.IsSuccessful ? Results.Ok(response) : Results.InternalServerError(response);
        }
    }
}
