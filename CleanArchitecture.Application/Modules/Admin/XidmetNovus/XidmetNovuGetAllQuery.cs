using CleanArchitecture.Domain.Core;
using CleanArchitecture.Domain.Modules.Admin.XidmetNovus;
using MediatR;

namespace CleanArchitecture.Application.Modules.Admin.XidmetNovus
{
    public sealed record XidmetNovuGetAllQuery() : IRequest<IQueryable<XidmetNovuGetAllQueryResponse>>;

    public sealed class XidmetNovuGetAllQueryResponse : BaseEntityDto
    {
        public string Ad { get; set; } = string.Empty;
    }

    internal sealed class XidmetNovuGetAllQueryHandler
        (IXidmetNovuRepository repository) : IRequestHandler<XidmetNovuGetAllQuery, IQueryable<XidmetNovuGetAllQueryResponse>>
    {
        public Task<IQueryable<XidmetNovuGetAllQueryResponse>> Handle(XidmetNovuGetAllQuery request, CancellationToken cancellationToken)
        {
            var response = (from x in repository.GetAll()
                            select new XidmetNovuGetAllQueryResponse
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
