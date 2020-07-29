using Microsoft.Extensions.DependencyInjection;
using ReleaseManagement.Application.Interfaces;
using ReleaseManagement.Application.Services;
using ReleaseManagement.Domain.Interfaces;
using ReleaseManagement.Infra.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReleaseManagement.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services) 
        {
            // Application Layer
            services.AddScoped<IClientService, ClientService>();

            // Infra.Data Layer
            services.AddScoped<IClientRepository, ClientRepository>();
        }
    }
}
