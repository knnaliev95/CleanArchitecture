using CleanArchitecture.Application.Modules.Admin.Sobeler;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;

namespace CleanArchitecture.WebApi.Controllers.Modules.Admin.Sobe
{
    [Route("odata")]
    [ApiController]
    [EnableQuery]
    public class SobeController(ISender sender) : ODataController
    {

        [HttpGet("sobe")]
        public async Task<IActionResult> Sobeler(CancellationToken cancellationToken)
        {
            var response = await sender.Send(new SobeGetAllQuery(), cancellationToken);

            return Ok(response);
        }
    }
}
