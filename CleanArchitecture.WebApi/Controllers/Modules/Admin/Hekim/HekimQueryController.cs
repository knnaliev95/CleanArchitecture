using CleanArchitecture.Application.Modules.Admin.Hekims;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;

namespace CleanArchitecture.WebApi.Controllers.Modules.Admin.Hekim
{
    [Route("odata")]
    [ApiController]
    [EnableQuery]
    public class HekimQueryController(ISender sender) : ODataController
    {
        [HttpGet("hekim")]
        public async Task<IActionResult> Hekimler(CancellationToken cancellationToken)
        {
            var response = await sender.Send(new HekimGetAllQuery(), cancellationToken);

            return Ok(response);
        }
    }
}
