using HMS.DAL.Interfaces.Repository;
using HMS.DAL.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace HMS.WebApi.Helper.Extension
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            if (services==null)
            {
                throw new ArgumentNullException(nameof(services));
            }
            services.AddScoped<IHospitalTypeRepository, HospitalTypeRepository>();
            return services;
        }
    }
}
