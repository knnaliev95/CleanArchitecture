using CleanArchitecture.Domain.Modules.Admin.XidmetNovus;
using MediatR;
using TS.Result;

namespace CleanArchitecture.Application.Modules.Admin.XidmetNovus
{
    public sealed record XidmetNovuGetQuery(int Id) : IRequest<Result<XidmetNovu>>;

    internal sealed class XidmetNovuGetQueryHandler
        (IXidmetNovuRepository repository) : IRequestHandler<XidmetNovuGetQuery, Result<XidmetNovu>>
    {
        public async Task<Result<XidmetNovu>> Handle(XidmetNovuGetQuery request, CancellationToken cancellationToken)
        {
            var entity = await repository.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
            if (entity is null) return Result<XidmetNovu>.Failure("Tapılmadı");
            return entity;
        }
    }
}
