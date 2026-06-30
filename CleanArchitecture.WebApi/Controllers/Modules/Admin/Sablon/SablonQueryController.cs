using CleanArchitecture.Application.Modules.Admin.Sablons;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;

namespace CleanArchitecture.WebApi.Controllers.Modules.Admin.Sablon
{
    [Route("odata")]
    [ApiController]
    [EnableQuery]
    public class SablonQueryController(ISender sender) : ODataController
    {
        [HttpGet("sablon")]
        public async Task<IActionResult> Sablon(CancellationToken cancellationToken)
        {
            var response = await sender.Send(new SablonGetAllQuery(), cancellationToken);

            return Ok(response);
        }
    }
}
