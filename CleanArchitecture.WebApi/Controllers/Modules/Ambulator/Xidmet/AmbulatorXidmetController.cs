using CleanArchitecture.Application.Modules.Ambulator.Xidmets;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.WebApi.Controllers.Modules.Ambulator.Xidmet
{
    [Route("api/axidmet/[action]")]
    [ApiController]
    public class AmbulatorXidmetController(ISender sender) : ControllerBase
    {
        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id, CancellationToken cancellationToken)
        {
            var result = await sender.Send(new AmbulatorXidmetGetAllQuery(id), cancellationToken);

            return Ok(result);
        }
    }
}
