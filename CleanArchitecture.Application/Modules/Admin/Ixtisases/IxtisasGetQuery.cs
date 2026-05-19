using CleanArchitecture.Domain.Modules.Admin.Ixtisases;
using MediatR;
using TS.Result;

namespace CleanArchitecture.Application.Modules.Admin.Ixtisases
{
    public sealed record IxtisasGetQuery(int Id) : IRequest<Result<Ixtisas>>;

    internal sealed class IxtisasGetQueryHandler
        (IIxtisasRepository ixtisasRepository) : IRequestHandler<IxtisasGetQuery, Result<Ixtisas>>
    {
        public async Task<Result<Ixtisas>> Handle(IxtisasGetQuery request, CancellationToken cancellationToken)
        {
            var ixtisas = await ixtisasRepository.FirstOrDefaultAsync(p => p.Id == request.Id, cancellationToken);
            if(ixtisas is null)
            {
                return Result<Ixtisas>.Failure("Ixtisas tapılmadı");
            }

            return ixtisas;
        }
    }
}
