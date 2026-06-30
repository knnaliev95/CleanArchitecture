using CleanArchitecture.Application.Modules.Accounts.Permisson;
using CleanArchitecture.Application.Modules.Admin.Diaqnozs;
using CleanArchitecture.Application.Modules.Admin.EndirimTipis;
using CleanArchitecture.Application.Modules.Admin.Faizs;
using CleanArchitecture.Application.Modules.Admin.Hekims;
using CleanArchitecture.Application.Modules.Admin.Ixtisases;
using CleanArchitecture.Application.Modules.Admin.MuracietSebebis;
using CleanArchitecture.Application.Modules.Admin.Sablons;
using CleanArchitecture.Application.Modules.Admin.Sobeler;
using CleanArchitecture.Application.Modules.Admin.Teskilats;
using CleanArchitecture.Application.Modules.Admin.UserScopes;
using CleanArchitecture.Application.Modules.Admin.XidmetNovus;
using CleanArchitecture.Application.Modules.Admin.XidmetQrupus;
using CleanArchitecture.Application.Modules.Admin.Xidmets;
using CleanArchitecture.Application.Modules.Common.Pasients;
using Microsoft.AspNetCore.Identity;
using Microsoft.OData.Edm;
using Microsoft.OData.ModelBuilder;

namespace CleanArchitecture.WebApi.Controllers
{
    public class ODataModelBuilderExtension
    {
        public static IEdmModel GetEdmModel()
        {
            var builder = new ODataConventionModelBuilder();

            builder.EnableLowerCamelCase();

            // 🔥 bütün entity-lər burada
            builder.EntitySet<IxtisasGetAllQueryResponse>("ixtisas");
            builder.EntitySet<SobeGetAllQueryResponse>("sobe");
            builder.EntitySet<HekimGetAllQueryResponse>("hekim");
            builder.EntitySet<TeskilatGetAllQueryResponse>("teskilat");
            builder.EntitySet<DiaqnozGetAllQueryResponse>("diaqnoz");
            builder.EntitySet<EndirimTipiGetAllQueryResponse>("endirimTipi");
            builder.EntitySet<FaizGetAllQueryResponse>("faiz");
            builder.EntitySet<MuracietSebebiGetAllQueryResponse>("muracietSebebi");
            builder.EntitySet<SablonGetAllQueryResponse>("sablon");
            builder.EntitySet<UserScopeGetAllQueryResponse>("userScope");
            builder.EntitySet<XidmetNovuGetAllQueryResponse>("xidmetNovu");
            builder.EntitySet<XidmetQrupuGetAllQueryResponse>("xidmetQrupu");
            builder.EntitySet<XidmetGetAllQueryResponse>("xidmet");
            builder.EntitySet<IdentityRole<int>>("roles");
            builder.EntitySet<PasientResponse>("pasient");

            return builder.GetEdmModel();
        }
    }
}
