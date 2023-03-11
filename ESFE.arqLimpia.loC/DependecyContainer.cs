using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ESFE.arqLimpia.DAL;
using ESFE.arqLimpia.BL;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;


namespace ESFE.arqLimpia.loC
{
    public static class DependecyContainer
    {
        public static IServiceCollection AddESFEDependecies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDALDependecies(configuration);
            services.AddBLDependecies();
            return services;
        }
    }
}
