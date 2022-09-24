using LALHData.Repository;
using LALHDomain.Interfaces;
using LHLAApplication.Interfaces;
using LHLAApplication.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfraIOC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Application Layer
            services.AddScoped<IEmployeeService, EmployeeService>();

            //Infra Data
            services.AddScoped<IMasterEmployeeRepository, MasterEmployeeRepository>();
        }
    }
}
