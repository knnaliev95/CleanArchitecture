using CleanArchitecture.Application.Modules.Admin.EndirimTipis;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;

namespace CleanArchitecture.WebApi.Controllers.Modules.Admin.EndirimTipi
{
    [Route("odata")]
    [ApiController]
    [EnableQuery]
    public class EndirimTipiQueryController(ISender sender) : ODataController
    {
        [HttpGet("endirimTipi")]
        public async Task<IActionResult> EndirimTipi(CancellationToken cancellationToken)
        {
            var response = await sender.Send(new EndirimTipiGetAllQuery(), cancellationToken);

            return Ok(response);
        }
    }
}
