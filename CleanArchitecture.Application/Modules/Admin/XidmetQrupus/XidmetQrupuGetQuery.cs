using CleanArchitecture.Domain.Modules.Admin.XidmetQrupus;
using MediatR;
using TS.Result;

namespace CleanArchitecture.Application.Modules.Admin.XidmetQrupus
{
    public sealed record XidmetQrupuGetQuery(int Id) : IRequest<Result<XidmetQrupu>>;

    internal sealed class XidmetQrupuGetQueryHandler
        (IXidmetQrupuRepository repository) : IRequestHandler<XidmetQrupuGetQuery, Result<XidmetQrupu>>
    {
        public async Task<Result<XidmetQrupu>> Handle(XidmetQrupuGetQuery request, CancellationToken cancellationToken)
        {
            var entity = await repository.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
            if (entity is null) return Result<XidmetQrupu>.Failure("Tapılmadı");
            return entity;
        }
    }
}
