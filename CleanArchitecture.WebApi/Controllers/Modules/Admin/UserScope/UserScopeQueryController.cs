using CleanArchitecture.Application.Modules.Admin.UserScopes;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;

namespace CleanArchitecture.WebApi.Controllers.Modules.Admin.UserScope
{
    [Route("odata")]
    [ApiController]
    [EnableQuery]
    public class UserScopeQueryController(ISender sender) : ODataController
    {
        [HttpGet("userScope")]
        public async Task<IActionResult> UserScope(CancellationToken cancellationToken)
        {
            var response = await sender.Send(new UserScopeGetAllQuery(), cancellationToken);

            return Ok(response);
        }
    }
}
