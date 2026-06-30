using CleanArchitecture.Application.Modules.Admin.XidmetQrupus;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;

namespace CleanArchitecture.WebApi.Controllers.Modules.Admin.XidmetQrupu
{
    [Route("odata")]
    [ApiController]
    [EnableQuery]
    public class XidmetQrupuQueryController(ISender sender) : ODataController
    {
        [HttpGet("xidmetQrupu")]
        public async Task<IActionResult> XidmetQrupu(CancellationToken cancellationToken)
        {
            var response = await sender.Send(new XidmetQrupuGetAllQuery(), cancellationToken);

            return Ok(response);
        }
    }
}
