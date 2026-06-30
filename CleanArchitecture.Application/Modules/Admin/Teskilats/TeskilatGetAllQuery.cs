using CleanArchitecture.Domain.Core;
using CleanArchitecture.Domain.Modules.Admin.Teskilats;
using MediatR;

namespace CleanArchitecture.Application.Modules.Admin.Teskilats
{
    public sealed record TeskilatGetAllQuery() : IRequest<IQueryable<TeskilatGetAllQueryResponse>>;

    public sealed class TeskilatGetAllQueryResponse : BaseEntityDto
    {
        public string Ad {  get; set; } = string.Empty;
    }

    internal sealed class TeskilatGetAllQueryHandler
        (ITeskilatRepository teskilatRepository) : IRequestHandler<TeskilatGetAllQuery, IQueryable<TeskilatGetAllQueryResponse>>
    {
        public Task<IQueryable<TeskilatGetAllQueryResponse>> Handle(TeskilatGetAllQuery request, CancellationToken cancellationToken)
        {
            var response = (from x in teskilatRepository.GetAll()
                            select new TeskilatGetAllQueryResponse
                            {
                                Id = x.Id,
                                Ad = x.Ad,
                                IsDeleted = x.IsDeleted,
                                CreateUserName = x.CreateUser != null ? x.CreateUser.UserName : "none",
                                CreatedDate = x.CreatedDate,
                                UpdateUserName = x.UpdateUser != null ? x.UpdateUser.UserName : "none",
                                UpdatedDate = x.UpdatedDate,
                                DeletedUserName = x.DeleteUser != null ? x.DeleteUser.UserName : "none",
                                DeletedDate = x.DeletedDate
                            });

            return Task.FromResult(response);
        }
    }
}
