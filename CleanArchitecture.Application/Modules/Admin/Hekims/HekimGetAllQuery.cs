using CleanArchitecture.Domain.Core;
using CleanArchitecture.Domain.Modules.Admin.Hekims;
using MediatR;

namespace CleanArchitecture.Application.Modules.Admin.Hekims
{
    public sealed record HekimGetAllQuery() : IRequest<IQueryable<HekimGetAllQueryResponse>>;
    
    public sealed class HekimGetAllQueryResponse : BaseEntityDto
    {
        public string Fin { get; set; } = string.Empty;
        public string Ad { get; set; } = string.Empty;
        public int IxtisasId { get; set; }
        public string IxtisasAdi { get; set; } = string.Empty;
        public int SobeId { get; set; }
        public string SobeAdi { get; set; } = string.Empty;
        public int? OtaqNomresi { get; set; }
        public double? Qiymet {  get; set; }
    }

    internal sealed class HekimGetAllQueryHandler
        (IHekimRepository hekimRepository): IRequestHandler<HekimGetAllQuery, IQueryable<HekimGetAllQueryResponse>>
    {
        public Task<IQueryable<HekimGetAllQueryResponse>> Handle(HekimGetAllQuery request, CancellationToken cancellationToken)
        {
            var response = (from hekim in hekimRepository.GetAll()
                            select new HekimGetAllQueryResponse
                            {
                                Id = hekim.Id,
                                Fin = hekim.Fin,
                                Ad = hekim.Ad,
                                IxtisasId = hekim.IxtisasId,
                                IxtisasAdi = hekim.Ixtisas != null ? hekim.Ixtisas.Ad ?? string.Empty : string.Empty,
                                SobeId = hekim.SobeId,
                                SobeAdi = hekim.Sobe != null ? hekim.Sobe.Ad ?? string.Empty : string.Empty,
                                OtaqNomresi = hekim.OtaqNomresi,
                                Qiymet = hekim.Qiymet,
                                IsDeleted = hekim.IsDeleted,
                                CreateUserName = hekim.CreateUser != null ? hekim.CreateUser.UserName : "none",
                                CreatedDate = hekim.CreatedDate,
                                UpdateUserName = hekim.UpdateUser != null ? hekim.UpdateUser.UserName : "none",
                                UpdatedDate = hekim.UpdatedDate,
                                DeletedUserName = hekim.DeleteUser != null ? hekim.DeleteUser.UserName : "none",
                                DeletedDate = hekim.DeletedDate
                            });

            return Task.FromResult(response);
        }
    }
}
