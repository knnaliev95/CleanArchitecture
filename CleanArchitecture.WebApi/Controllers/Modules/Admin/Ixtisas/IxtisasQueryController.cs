using CleanArchitecture.Application.Modules.Admin.Ixtisases;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;

namespace CleanArchitecture.WebApi.Controllers.Modules.Admin.Ixtisas
{
    [Route("odata")]
    [ApiController]
    [EnableQuery]
    public class IxtisasQueryController(ISender sender) : ODataController
    {

        [HttpGet("ixtisas")]
        public async Task<IActionResult> Ixtisases(CancellationToken cancellation)
        {
            var response = await sender.Send(new IxtisasGetAllQuery(), cancellation);

            return Ok(response);
        }
    }
}
