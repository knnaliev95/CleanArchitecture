using CleanArchitecture.Domain.Core;
using CleanArchitecture.Domain.Modules.Admin.EndirimTipis;
using MediatR;

namespace CleanArchitecture.Application.Modules.Admin.EndirimTipis
{
    public sealed record EndirimTipiGetAllQuery() : IRequest<IQueryable<EndirimTipiGetAllQueryResponse>>;

    public sealed class EndirimTipiGetAllQueryResponse : BaseEntityDto
    {
        public string Ad { get; set; } = string.Empty;
    }

    internal sealed class EndirimTipiGetAllQueryHandler
        (IEndirinTipiRepository repository) : IRequestHandler<EndirimTipiGetAllQuery, IQueryable<EndirimTipiGetAllQueryResponse>>
    {
        public Task<IQueryable<EndirimTipiGetAllQueryResponse>> Handle(EndirimTipiGetAllQuery request, CancellationToken cancellationToken)
        {
            var response = (from e in repository.GetAll()
                            select new EndirimTipiGetAllQueryResponse
                            {
                                Id = e.Id,
                                Ad = e.Ad,
                                IsDeleted = e.IsDeleted,
                                CreateUserName = e.CreateUser != null ? e.CreateUser.UserName : "none",
                                CreatedDate = e.CreatedDate,
                                UpdateUserName = e.UpdateUser != null ? e.UpdateUser.UserName : "none",
                                UpdatedDate = e.UpdatedDate,
                                DeletedUserName = e.DeleteUser != null ? e.DeleteUser.UserName : "none",
                                DeletedDate = e.DeletedDate
                            });

            return Task.FromResult(response);
        }
    }
}
