using CleanArchitecture.Application.Modules.Admin.Faizs;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;

namespace CleanArchitecture.WebApi.Controllers.Modules.Admin.Faiz
{
    [Route("odata")]
    [ApiController]
    [EnableQuery]
    public class FaizQueryController(ISender sender) : ODataController
    {
        [HttpGet("faiz")]
        public async Task<IActionResult> Faiz(CancellationToken cancellationToken)
        {
            var response = await sender.Send(new FaizGetAllQuery(), cancellationToken);

            return Ok(response);
        }
    }
}
