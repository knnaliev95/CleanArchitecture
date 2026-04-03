using CleanArchitecture.Application.Modules.Admin.Ixtisases;
using CleanArchitecture.Application.Modules.Admin.Sobeler;
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

            return builder.GetEdmModel();
        }
    }
}
