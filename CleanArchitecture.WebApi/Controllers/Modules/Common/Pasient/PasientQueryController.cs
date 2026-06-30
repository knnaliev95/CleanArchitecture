using CleanArchitecture.Application.Modules.Common.Pasients;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;

namespace CleanArchitecture.WebApi.Controllers.Modules.Common.Pasient
{
    [Route("odata")]
    [ApiController]
    [EnableQuery]
    public class PasientQueryController(ISender sender) : ODataController
    {
        [HttpGet("pasient")]
        public async Task<IActionResult> Pasients(CancellationToken cancellationToken)
        {
            var respone = await sender.Send(new PasientSearchQuery(), cancellationToken);

            return Ok(respone);
        }
    }
}
