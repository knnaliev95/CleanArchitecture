using CleanArchitecture.Application.Modules.Common.Pasients;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.WebApi.Controllers.Modules.Common.Pasient
{
    [Route("api/pasient/[action]")]
    [ApiController]
    public class PasientCommandController(ISender sender) : ControllerBase
    {
        [HttpPost]
        public async Task<IResult> Create(PasientCreateCommand request, CancellationToken cancellationToken)
        {
            var response = await sender.Send(request, cancellationToken);

            return response.IsSuccessful ? Results.Ok(response) : Results.InternalServerError(response);
        }

        [HttpPut]
        public async Task<IResult> Update(PasientUpdateCommand request, CancellationToken cancellationToken)
        {
            var response = await sender.Send(request, cancellationToken);

            return response.IsSuccessful ? Results.Ok(response) : Results.InternalServerError(response);
        }
    }
}
