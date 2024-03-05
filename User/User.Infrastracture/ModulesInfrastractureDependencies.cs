using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.Infrastracture.Reposatories;

namespace User.Infrastracture
{
    public static class ModulesInfrastractureDependencies
    {
        public static IServiceCollection AddInfrastractureDependencies(this IServiceCollection service)
        {
            //service.AddTransient<IManger<User>, UserReposatory>();
            service.AddTransient(typeof(UserReposatory));
            //service.AddTransient<IManger<Department>, DepartmentReposatory>();
            return service;
        }
    }
}
