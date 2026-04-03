using CleanArchitecture.Application.Modules.Admin.Ixtisases;
using Mapster;
using MediatR;
using TS.Result;

namespace CleanArchitecture.WebApi.Controllers.Modules.Admin.Ixtisas
{
    public static class IxtisasModule
    {
        public static void RegisterIxtisasRoute(this IEndpointRouteBuilder app)
        {
            RouteGroupBuilder group = app.MapGroup("/ixtisas").WithTags("Ixtisas");

            group.MapPost(string.Empty,
                async (ISender sender, IxtisasCreateCommand request, CancellationToken cancellationToken) =>
                {
                    var response = await sender.Send(request, cancellationToken);
                    return response.IsSuccessful ? Results.Ok(response) : Results.InternalServerError(response);
                }).Produces<Result<string>>();

            group.MapPut("{id:int}",
                async (int id, ISender sender, IxtisasUpdateRequest request, CancellationToken cancellationToken) =>
                {
                    var command = request.Adapt<IxtisasUpdateCommand>() with { Id = id };
                    var response = await sender.Send(command, cancellationToken);

                    return response.IsSuccessful
                        ? Results.Ok(response)
                        : Results.InternalServerError(response);
                }).Produces<Result<string>>();
        }
    }
}
