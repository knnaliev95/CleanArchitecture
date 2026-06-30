using CleanArchitecture.Application.Modules.Accounts.Permisson;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;

namespace CleanArchitecture.WebApi.Controllers.Modules.Auth.Role
{
    [Route("odata")]
    [ApiController]
    [EnableQuery]
    public class RoleQueryController(ISender sender) : ODataController
    {
        [HttpGet("roles")]
        public async Task<IActionResult> Role(CancellationToken cancellationToken)
        {
            var response = await sender.Send(new PermissionGetAllQuery(), cancellationToken);

            return Ok(response);
        }
    }
}
