using CleanArchitecture.Domain.Modules.Admin.Sablons;
using MediatR;
using TS.Result;

namespace CleanArchitecture.Application.Modules.Admin.Sablons
{
    public sealed record SablonGetQuery(int Id) : IRequest<Result<Sablon>>;

    internal sealed class SablonGetQueryHandler
        (ISablonRepository repository) : IRequestHandler<SablonGetQuery, Result<Sablon>>
    {
        public async Task<Result<Sablon>> Handle(SablonGetQuery request, CancellationToken cancellationToken)
        {
            var entity = await repository.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
            if (entity is null) return Result<Sablon>.Failure("Tapılmadı");
            return entity;
        }
    }
}
