using CleanArchitecture.Domain.Modules.Admin.EndirimTipis;
using MediatR;
using TS.Result;

namespace CleanArchitecture.Application.Modules.Admin.EndirimTipis
{
    public sealed record EndirimTipiGetQuery(int Id) : IRequest<Result<EndirimTipi>>;

    internal sealed class EndirimTipiGetQueryHandler
        (IEndirinTipiRepository repository) : IRequestHandler<EndirimTipiGetQuery, Result<EndirimTipi>>
    {
        public async Task<Result<EndirimTipi>> Handle(EndirimTipiGetQuery request, CancellationToken cancellationToken)
        {
            var entity = await repository.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
            if (entity is null) return Result<EndirimTipi>.Failure("Endirim tipi tapılmadı");
            return entity;
        }
    }
}
