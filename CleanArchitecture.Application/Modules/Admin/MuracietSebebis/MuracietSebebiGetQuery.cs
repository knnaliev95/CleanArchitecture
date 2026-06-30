using CleanArchitecture.Domain.Modules.Admin.MuracietSebebis;
using MediatR;
using TS.Result;

namespace CleanArchitecture.Application.Modules.Admin.MuracietSebebis
{
    public sealed record MuracietSebebiGetQuery(int Id) : IRequest<Result<MuracietSebebi>>;

    internal sealed class MuracietSebebiGetQueryHandler
        (IMuracietSebebiRepository repository) : IRequestHandler<MuracietSebebiGetQuery, Result<MuracietSebebi>>
    {
        public async Task<Result<MuracietSebebi>> Handle(MuracietSebebiGetQuery request, CancellationToken cancellationToken)
        {
            var entity = await repository.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
            if (entity is null) return Result<MuracietSebebi>.Failure("Tapılmadı");
            return entity;
        }
    }
}
