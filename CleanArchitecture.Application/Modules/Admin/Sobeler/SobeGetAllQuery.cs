using CleanArchitecture.Domain.Core;
using CleanArchitecture.Domain.Modules.Admin.Sobeler;
using MediatR;

namespace CleanArchitecture.Application.Modules.Admin.Sobeler
{
    public sealed record SobeGetAllQuery() : IRequest<IQueryable<SobeGetAllQueryResponse>>;

    public sealed class SobeGetAllQueryResponse : BaseEntityDto
    {
        public string Ad { get; set; } = default!;
    }

    internal sealed class SobeGetAllQueryHandler(ISobeRepository SobeRepository) : IRequestHandler<SobeGetAllQuery, IQueryable<SobeGetAllQueryResponse>>
    {
        public Task<IQueryable<SobeGetAllQueryResponse>> Handle(SobeGetAllQuery request, CancellationToken cancellationToken)
        {
            var response = (from Sobe in SobeRepository.GetAll()
                            select new SobeGetAllQueryResponse
                            {
                                Id = Sobe.Id,
                                Ad = Sobe.Ad,
                                IsDeleted = Sobe.IsDeleted,
                            });

            return Task.FromResult(response);
        }
    }
}
