using CleanArchitecture.Domain.Core;
using CleanArchitecture.Domain.Modules.Admin.XidmetQrupus;
using MediatR;

namespace CleanArchitecture.Application.Modules.Admin.XidmetQrupus
{
    public sealed record XidmetQrupuGetAllQuery() : IRequest<IQueryable<XidmetQrupuGetAllQueryResponse>>;

    public sealed class XidmetQrupuGetAllQueryResponse : BaseEntityDto
    {
        public string Ad { get; set; } = string.Empty;
    }

    internal sealed class XidmetQrupuGetAllQueryHandler
        (IXidmetQrupuRepository repository) : IRequestHandler<XidmetQrupuGetAllQuery, IQueryable<XidmetQrupuGetAllQueryResponse>>
    {
        public Task<IQueryable<XidmetQrupuGetAllQueryResponse>> Handle(XidmetQrupuGetAllQuery request, CancellationToken cancellationToken)
        {
            var response = (from x in repository.GetAll()
                            select new XidmetQrupuGetAllQueryResponse
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
