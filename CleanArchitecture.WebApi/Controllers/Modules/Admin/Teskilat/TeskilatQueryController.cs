using CleanArchitecture.Application.Modules.Admin.Teskilats;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;

namespace CleanArchitecture.WebApi.Controllers.Modules.Admin.Teskilat
{
    [Route("odata")]
    [ApiController]
    [EnableQuery]
    public class TeskilatQueryController(ISender sender) : ODataController
    {
        [HttpGet("teskilat")]
        public async Task<IActionResult> Teskilat(CancellationToken cancellationToken)
        {
            var response = await sender.Send(new TeskilatGetAllQuery(), cancellationToken);

            return Ok(response);
        }
    }
}
