using CleanArchitecture.Domain.Modules.Admin.Diaqnozs;
using MediatR;
using TS.Result;

namespace CleanArchitecture.Application.Modules.Admin.Diaqnozs
{
    public sealed record DiaqnozGetQuery(int Id) : IRequest<Result<Diaqnoz>>;

    internal sealed class DiaqnozGetQueryHandler
        (IDiaqnozRepository repository) : IRequestHandler<DiaqnozGetQuery, Result<Diaqnoz>>
    {
        public async Task<Result<Diaqnoz>> Handle(DiaqnozGetQuery request, CancellationToken cancellationToken)
        {
            var entity = await repository.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
            if (entity is null) return Result<Diaqnoz>.Failure("Diaqnoz tapılmadı");
            return entity;
        }
    }
}
