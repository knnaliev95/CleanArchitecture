using CleanArchitecture.Domain.Modules.Admin.Hekims;
using MediatR;
using TS.Result;

namespace CleanArchitecture.Application.Modules.Admin.Hekims
{
    public sealed record HekimGetQuery(int Id) : IRequest<Result<Hekim>>;

    internal sealed class HekimGetQueryHandler
        (IHekimRepository hekimRepository) : IRequestHandler<HekimGetQuery, Result<Hekim>>
    {
        public async Task<Result<Hekim>> Handle(HekimGetQuery request, CancellationToken cancellationToken)
        {
            var hekim = await hekimRepository.FirstOrDefaultAsync(h => h.Id == request.Id, cancellationToken);

            if(hekim is null)
            {
                return Result<Hekim>.Failure("Həkim tapılmadı");
            }

            return hekim;
        }
    }
}
