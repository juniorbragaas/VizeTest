using System.Web.Http;
using WebActivatorEx;
using WebApplication1;
using Swashbuckle.Application;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace WebApplication1
{
    public class SwaggerConfig
    {

        [assembly: PreApplicationStartMethod(typeof(MinhaApiSwagger.App_Start.SwaggerConfig), "Register")]
        public static void Register()
        {
            GlobalConfiguration.Configuration
                .EnableSwagger(c =>
                {
                    c.SingleApiVersion("v1", "API para Teste Vize");
                })
                .EnableSwaggerUi(); // Interface web do Swagger
        }
    
    }
}
