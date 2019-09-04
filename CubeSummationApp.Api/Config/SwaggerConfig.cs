using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.IO;

namespace CubeSummationApp.Api.Config
{
    public static class SwaggerConfig
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddRegistration(IServiceCollection services)
        {
            string basePath = System.AppDomain.CurrentDomain.BaseDirectory;
            string xmlPath = Path.Combine(basePath, "CubeSummation.Api.xml");

            services.AddSwaggerGen(s =>
            {
                s.SwaggerDoc("v1", new Swashbuckle.AspNetCore.Swagger.Info { Title = "CubeSummation API V1", Version = "v1" });
                s.IncludeXmlComments(xmlPath);
            }
            );

            return services;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="app"></param>
        /// <returns></returns>
        public static IApplicationBuilder AddRegistration(IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "CubeSummation API V1"));
            return app;
        }
    }
}
