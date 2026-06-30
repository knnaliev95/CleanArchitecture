using CleanArchitecture.Domain.Core;
using CleanArchitecture.Domain.Modules.Admin.Sablons;
using MediatR;

namespace CleanArchitecture.Application.Modules.Admin.Sablons
{
    public sealed record SablonGetAllQuery() : IRequest<IQueryable<SablonGetAllQueryResponse>>;

    public sealed class SablonGetAllQueryResponse : BaseEntityDto
    {
        public string Ad { get; set; } = string.Empty;
        public int HekimId { get; set; }
        public string HekimAdi { get; set; } = string.Empty;
        public int XidmetQrupuId { get; set; }
        public string XidmetQrupuAdi { get; set; } = string.Empty;
        public string Data { get; set; } = string.Empty;
    }

    internal sealed class SablonGetAllQueryHandler
        (ISablonRepository repository) : IRequestHandler<SablonGetAllQuery, IQueryable<SablonGetAllQueryResponse>>
    {
        public Task<IQueryable<SablonGetAllQueryResponse>> Handle(SablonGetAllQuery request, CancellationToken cancellationToken)
        {
            var response = (from s in repository.GetAll()
                            select new SablonGetAllQueryResponse
                            {
                                Id = s.Id,
                                Ad = s.Ad,
                                HekimId = s.HekimId,
                                HekimAdi = s.Hekim != null ? s.Hekim.Ad : string.Empty,
                                XidmetQrupuId = s.XidmetQrupuId,
                                XidmetQrupuAdi = s.XidmetQrupu != null ? s.XidmetQrupu.Ad : string.Empty,
                                Data = s.Data,
                                IsDeleted = s.IsDeleted,
                                CreateUserName = s.CreateUser != null ? s.CreateUser.UserName : "none",
                                CreatedDate = s.CreatedDate,
                                UpdateUserName = s.UpdateUser != null ? s.UpdateUser.UserName : "none",
                                UpdatedDate = s.UpdatedDate,
                                DeletedUserName = s.DeleteUser != null ? s.DeleteUser.UserName : "none",
                                DeletedDate = s.DeletedDate
                            });

            return Task.FromResult(response);
        }
    }
}
