using CubeSummationApp.Application.Contracts.Services;
using CubeSummationApp.Application.Services;
using CubeSummationApp.DataAccess.Context;
using CubeSummationApp.DataAccess.Contracts.Context;
using CubeSummationApp.DataAccess.Contracts.Repositories;
using CubeSummationApp.DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CubeSummation.CrossCutting.Register
{
    public static class IoCRegister
    {
        public static IServiceCollection AddRegistration(this IServiceCollection services, string connectionString)
        {
            AddRegisterDataContext(services, connectionString);
            AddRegisterRepositories(services);
            AddRegisterServices(services);
            return services;
        }

        private static IServiceCollection AddRegisterRepositories(IServiceCollection services)
        {
            services.AddTransient<ICoordinateRepository, CoordinateRepository>();
            services.AddTransient<ICubeRepository, CubeRepository>();
            services.AddTransient<IUserRepository, UserRepository>();     
            return services;
        }

        private static IServiceCollection AddRegisterServices(IServiceCollection services)
        {
            services.AddTransient<ICubeService, CubeService>();
            return services;
        }

        private static IServiceCollection AddRegisterDataContext(IServiceCollection services, string connectionString)
        {
            services.AddTransient<ICubeSummationDbContext, CubeSummationDbContext>();
            services.AddDbContext<CubeSummationDbContext>(options => options.UseSqlServer(connectionString));
            return services;
        }
    }
}
