using CleanArchitecture.Application.Modules.Admin.XidmetNovus;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;

namespace CleanArchitecture.WebApi.Controllers.Modules.Admin.XidmetNovu
{
    [Route("odata")]
    [ApiController]
    [EnableQuery]
    public class XidmetNovuQueryController(ISender sender) : ODataController
    {
        [HttpGet("xidmetNovu")]
        public async Task<IActionResult> XidmetNovu(CancellationToken cancellationToken)
        {
            var response = await sender.Send(new XidmetNovuGetAllQuery(), cancellationToken);

            return Ok(response);
        }
    }
}
