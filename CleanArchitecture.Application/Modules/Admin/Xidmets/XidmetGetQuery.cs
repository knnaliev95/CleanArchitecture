using CleanArchitecture.Domain.Modules.Admin.Xidmets;
using MediatR;
using TS.Result;

namespace CleanArchitecture.Application.Modules.Admin.Xidmets
{
    public sealed record XidmetGetQuery(int Id) : IRequest<Result<Xidmet>>;

    internal sealed class XidmetGetQueryHandler
        (IXidmetRepository repository) : IRequestHandler<XidmetGetQuery, Result<Xidmet>>
    {
        public async Task<Result<Xidmet>> Handle(XidmetGetQuery request, CancellationToken cancellationToken)
        {
            var entity = await repository.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
            if (entity is null) return Result<Xidmet>.Failure("Tapılmadı");
            return entity;
        }
    }
}
