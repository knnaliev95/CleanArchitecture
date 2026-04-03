using CleanArchitecture.Domain.Modules.Admin.Sobeler;
using MediatR;
using TS.Result;

namespace CleanArchitecture.Application.Modules.Admin.Sobeler
{
    public sealed record SobeGetQuery(int Id) : IRequest<Result<Sobe>>;

    internal sealed class SobeGetQueryHandler(ISobeRepository SobeRepository) : IRequestHandler<SobeGetQuery, Result<Sobe>>
    {
        public async Task<Result<Sobe>> Handle(SobeGetQuery request, CancellationToken cancellationToken)
        {
            var Sobe = await SobeRepository.FirstOrDefaultAsync(p => p.Id == request.Id, cancellationToken);
            if (Sobe is null)
            {
                return Result<Sobe>.Failure("Sobe tapılmadı");
            }

            return Sobe;
        }
    }
}
