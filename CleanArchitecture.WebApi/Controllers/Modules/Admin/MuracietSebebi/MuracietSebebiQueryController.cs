using CleanArchitecture.Application.Modules.Admin.MuracietSebebis;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;

namespace CleanArchitecture.WebApi.Controllers.Modules.Admin.MuracietSebebi
{
    [Route("odata")]
    [ApiController]
    [EnableQuery]
    public class MuracietSebebiQueryController(ISender sender) : ODataController
    {
        [HttpGet("muracietSebebi")]
        public async Task<IActionResult> MuracietSebebi(CancellationToken cancellationToken)
        {
            var response = await sender.Send(new MuracietSebebiGetAllQuery(), cancellationToken);

            return Ok(response);
        }
    }
}
