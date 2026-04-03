using CleanArchitecture.Domain.Core;
using CleanArchitecture.Domain.Modules.Admin.Ixtisases;
using MediatR;

namespace CleanArchitecture.Application.Modules.Admin.Ixtisases
{
    public sealed record IxtisasGetAllQuery() : IRequest<IQueryable<IxtisasGetAllQueryResponse>>;

    public sealed class IxtisasGetAllQueryResponse : BaseEntityDto
    {
        public string Name { get; set; } = default!;
    }

    internal sealed class IxtisasGetAllQueryHandler(IIxtisasRepository ixtisasRepository) : IRequestHandler<IxtisasGetAllQuery, IQueryable<IxtisasGetAllQueryResponse>>
    {
        public Task<IQueryable<IxtisasGetAllQueryResponse>> Handle(IxtisasGetAllQuery request, CancellationToken cancellationToken)
        {
            var response = (from ixtisas in ixtisasRepository.GetAll()
                            select new IxtisasGetAllQueryResponse
                            {
                                Id = ixtisas.Id,
                                Name = ixtisas.Name,
                                IsDeleted = ixtisas.IsDeleted,
                            });

            return Task.FromResult(response);
        }
    }
}
