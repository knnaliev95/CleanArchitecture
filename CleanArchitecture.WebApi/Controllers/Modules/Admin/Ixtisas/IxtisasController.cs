using CleanArchitecture.Application.Modules.Admin.Ixtisases;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using Microsoft.OData.Edm;
using Microsoft.OData.ModelBuilder;

namespace CleanArchitecture.WebApi.Controllers.Modules.Admin.Ixtisas
{
    [Route("odata")]
    [ApiController]
    [EnableQuery]
    public class IxtisasController(ISender sender) : ODataController
    {

        [HttpGet("ixtisas")]
        public async Task<IActionResult> Ixtisases(CancellationToken cancellation)
        {
            var response = await sender.Send(new IxtisasGetAllQuery(), cancellation);

            return Ok(response);
        }
    }
}
