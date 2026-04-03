using CleanArchitecture.WebApi.Controllers.Modules.Admin.Ixtisas;
using CleanArchitecture.WebApi.Controllers.Modules.Admin.Sobe;

namespace CleanArchitecture.WebApi.Controllers
{
    public static class RouteRegistrar
    {
        public static void RegisterRoutes(this IEndpointRouteBuilder app)
        {
            app.RegisterIxtisasRoute();
            app.RegisterSobeRoute();
        }
    }
}
