using CleanArchitecture.Domain.Modules.Admin.Teskilats;
using MediatR;
using TS.Result;

namespace CleanArchitecture.Application.Modules.Admin.Teskilats
{
    public sealed record TeskilatGetQuery(int Id) : IRequest<Result<Teskilat>>;

    internal sealed class TeskilatGetQueryHandler
        (ITeskilatRepository teskilatRepository) : IRequestHandler<TeskilatGetQuery, Result<Teskilat>>
    {
        public async Task<Result<Teskilat>> Handle(TeskilatGetQuery request, CancellationToken cancellationToken)
        {
            var teskilat = await teskilatRepository.FirstOrDefaultAsync(t => t.Id == request.Id, cancellationToken);

            if(teskilat is null)
            {
                return Result<Teskilat>.Failure("Təşkilat tapılmadı");
            }

            return teskilat;
        }
    }
}
