using Departments.Infrastracture.Reposatories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Departments.Infrastracture
{
    public static class ModulesInfrastractureDependencies
    {
        public static IServiceCollection AddInfrastractureDependencies(this IServiceCollection service)
        {
            service.AddTransient(typeof(DepartmentReposatory));
            return service;
        }
    }
}
