using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using TaskManagement.Application.Common.Behaviour;

namespace TaskManagement.Application
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddAppliction(this IServiceCollection services)
        {
            services.AddMediatR(cfg =>
            {
                cfg.RegisterServicesFromAssembly(typeof(ApplicationServiceExtensions).Assembly);
               cfg.AddBehavior(typeof(IPipelineBehavior<,>),typeof(ValidationBehaviour<,>));
            });
            services.AddAutoMapper(cfg =>
            {
                cfg.AddMaps(typeof(ApplicationServiceExtensions).Assembly);
            });
            services.AddValidatorsFromAssembly(typeof(ApplicationServiceExtensions).Assembly);
            return services;
        }
    }
}