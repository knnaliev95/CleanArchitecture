using CleanArchitecture.Domain.Core;
using CleanArchitecture.Domain.Modules.Admin.Ixtisases;
using MediatR;

namespace CleanArchitecture.Application.Modules.Admin.Ixtisases
{
    public sealed record IxtisasGetAllQuery() : IRequest<IQueryable<IxtisasGetAllQueryResponse>>;

    public sealed class IxtisasGetAllQueryResponse : BaseEntityDto
    {
        public string Ad { get; set; } = default!;
    }

    internal sealed class IxtisasGetAllQueryHandler
        (IIxtisasRepository ixtisasRepository) : IRequestHandler<IxtisasGetAllQuery, IQueryable<IxtisasGetAllQueryResponse>>
    {
        public Task<IQueryable<IxtisasGetAllQueryResponse>> Handle(IxtisasGetAllQuery request, CancellationToken cancellationToken)
        {
            var response = (from ixtisas in ixtisasRepository.GetAll()
                            select new IxtisasGetAllQueryResponse
                            {
                                Id = ixtisas.Id,
                                Ad = ixtisas.Ad,
                                IsDeleted = ixtisas.IsDeleted,
                                CreateUserName = ixtisas.CreateUser != null ? ixtisas.CreateUser.UserName : "none",
                                CreatedDate = ixtisas.CreatedDate,
                                UpdateUserName = ixtisas.UpdateUser != null ? ixtisas.UpdateUser.UserName : "none",
                                UpdatedDate = ixtisas.UpdatedDate,
                                DeletedUserName = ixtisas.DeleteUser != null ? ixtisas.DeleteUser.UserName : "none",
                                DeletedDate = ixtisas.DeletedDate
                            });

            return Task.FromResult(response);
        }
    }
}
