using CleanArchitecture.Application.Modules.Admin.Hekims;
using CleanArchitecture.Application.Modules.Admin.Ixtisases;
using CleanArchitecture.Application.Modules.Admin.Sobeler;
using CleanArchitecture.Application.Modules.Admin.Teskilats;
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

            return builder.GetEdmModel();
        }
    }
}
