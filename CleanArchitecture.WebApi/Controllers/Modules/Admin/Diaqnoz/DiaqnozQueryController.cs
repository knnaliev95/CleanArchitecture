using CleanArchitecture.Application.Modules.Admin.Diaqnozs;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;

namespace CleanArchitecture.WebApi.Controllers.Modules.Admin.Diaqnoz
{
    [Route("odata")]
    [ApiController]
    [EnableQuery]
    public class DiaqnozQueryController(ISender sender) : ODataController
    {
        [HttpGet("diaqnoz")]
        public async Task<IActionResult> Diaqnoz(CancellationToken cancellationToken)
        {
            var response = await sender.Send(new DiaqnozGetAllQuery(), cancellationToken);

            return Ok(response);
        }
    }
}
