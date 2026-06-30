using CleanArchitecture.Domain.Core;
using CleanArchitecture.Domain.Modules.Admin.Faizs;
using MediatR;

namespace CleanArchitecture.Application.Modules.Admin.Faizs
{
    public sealed record FaizGetAllQuery() : IRequest<IQueryable<FaizGetAllQueryResponse>>;

    public sealed class FaizGetAllQueryResponse : BaseEntityDto
    {
        public int? HekimId { get; set; }
        public string? HekimAdi {  get; set; }
        public int? TeskilatId { get; set; }
        public string? TeskilatAdi { get; set; }
        public int? XidmetQrupuId { get; set; }
        public string? XidmetQrupuAdi { get; set; }
        public int? XidmetId { get; set; }
        public string? XidmetAdi { get; set; }
        public double? Mebleg { get; set; }
        public double? Faizi { get; set; }
    }

    internal sealed class FaizGetAllQueryHandler
        (IFaizRepository repository) : IRequestHandler<FaizGetAllQuery, IQueryable<FaizGetAllQueryResponse>>
    {
        public Task<IQueryable<FaizGetAllQueryResponse>> Handle(FaizGetAllQuery request, CancellationToken cancellationToken)
        {
            var response = (from f in repository.GetAll()
                            select new FaizGetAllQueryResponse
                            {
                                Id = f.Id,
                                HekimId = f.HekimId,
                                HekimAdi = f.Hekim != null ? f.Hekim.Ad : null,
                                TeskilatId = f.TeskilatId,
                                TeskilatAdi = f.Teskilat != null ? f.Teskilat.Ad : null,
                                XidmetQrupuId = f.XidmetQrupuId,
                                XidmetQrupuAdi = f.XidmetQrupu != null ? f.XidmetQrupu.Ad : null,
                                XidmetId = f.XidmetId,
                                XidmetAdi = f.Xidmet != null ? f.Xidmet.Ad : null,
                                Mebleg = f.Mebleg,
                                Faizi = f.Faizi,
                                IsDeleted = f.IsDeleted,
                                CreateUserName = f.CreateUser != null ? f.CreateUser.UserName : "none",
                                CreatedDate = f.CreatedDate,
                                UpdateUserName = f.UpdateUser != null ? f.UpdateUser.UserName : "none",
                                UpdatedDate = f.UpdatedDate,
                                DeletedUserName = f.DeleteUser != null ? f.DeleteUser.UserName : "none",
                                DeletedDate = f.DeletedDate
                            });

            return Task.FromResult(response);
        }
    }
}
