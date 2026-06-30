using CleanArchitecture.Application.Modules.Admin.Xidmets;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;

namespace CleanArchitecture.WebApi.Controllers.Modules.Admin.Xidmet
{
    [Route("odata")]
    [ApiController]
    [EnableQuery]
    public class XidmetQueryController(ISender sender) : ODataController
    {
        [HttpGet("xidmet")]
        public async Task<IActionResult> Xidmet(CancellationToken cancellationToken)
        {
            var response = await sender.Send(new XidmetGetAllQuery(), cancellationToken);

            return Ok(response);
        }
    }
}
