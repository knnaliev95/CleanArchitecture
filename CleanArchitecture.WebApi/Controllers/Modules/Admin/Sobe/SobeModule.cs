using CleanArchitecture.Application.Modules.Admin.Ixtisases;
using CleanArchitecture.Application.Modules.Admin.Sobeler;
using Mapster;
using MediatR;
using TS.Result;

namespace CleanArchitecture.WebApi.Controllers.Modules.Admin.Sobe
{
    public static class SobeModule
    {
        public static void RegisterSobeRoute(this IEndpointRouteBuilder app)
        {
            RouteGroupBuilder group = app.MapGroup("/sobe").WithTags("Sobe");

            group.MapPost(string.Empty,
                async (ISender sender, SobeCreateCommand request, CancellationToken cancellationToken) =>
                {
                    var response = await sender.Send(request, cancellationToken);
                    return response.IsSuccessful ? Results.Ok(response) : Results.InternalServerError(response);
                }).Produces<Result<string>>();

            group.MapPut("{id:int}",
                async (int id, ISender sender, SobeUpdateRequest request, CancellationToken cancellationToken) =>
                {
                    var command = request.Adapt<SobeUpdateCommand>() with { Id = id};
                    var response = await sender.Send(command, cancellationToken);

                    return response.IsSuccessful
                        ? Results.Ok(response)
                        : Results.InternalServerError(response);
                }).Produces<Result<string>>();
        }
    }
}
