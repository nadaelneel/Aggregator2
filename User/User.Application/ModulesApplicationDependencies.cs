using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using User.Application.Behaviors;

namespace User.Application
{
    public static class ModulesApplicationDependencies
    {
        public static IServiceCollection AddModulesAppDependencies(this IServiceCollection service)
        {
            service.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            // 
            service.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));

            return service;
        }
    }
}
