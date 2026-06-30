using CleanArchitecture.Domain.Core;
using CleanArchitecture.Domain.Modules.Admin.Xidmets;
using MediatR;

namespace CleanArchitecture.Application.Modules.Admin.Xidmets
{
    public sealed record XidmetGetAllQuery() : IRequest<IQueryable<XidmetGetAllQueryResponse>>;

    public sealed class XidmetGetAllQueryResponse : BaseEntityDto
    {
        public string Ad { get; set; } = string.Empty;
        public string Kod { get; set; } = string.Empty;
        public double Qiymet { get; set; }
        public double? ITSQiymeti { get; set; }
        public int XidmetNovuId { get; set; }
        public string XidmetNovuAdi { get; set; } = string.Empty;
        public int? XidmetQrupuId { get; set; }
        public string XidmetQrupuAdi { get; set;} = string.Empty;
    }

    internal sealed class XidmetGetAllQueryHandler
        (IXidmetRepository repository) : IRequestHandler<XidmetGetAllQuery, IQueryable<XidmetGetAllQueryResponse>>
    {
        public Task<IQueryable<XidmetGetAllQueryResponse>> Handle(XidmetGetAllQuery request, CancellationToken cancellationToken)
        {
            var response = (from x in repository.GetAll()
                            select new XidmetGetAllQueryResponse
                            {
                                Id = x.Id,
                                Ad = x.Ad,
                                Kod = x.Kod,
                                Qiymet = x.Qiymet,
                                ITSQiymeti = x.ITSQiymeti,
                                XidmetNovuId = x.XidmetNovuId,
                                XidmetNovuAdi = x.XidmetNovu != null ? x.XidmetNovu.Ad : "",
                                XidmetQrupuId = x.XidmetQrupuId,
                                XidmetQrupuAdi = x.XidmetQrupu != null ? x.XidmetQrupu.Ad : "",
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
