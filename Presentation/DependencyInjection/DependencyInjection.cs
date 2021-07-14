// <copyright file="DependencyInjection.cs" company="Onno Invernizzi">
// Copyright (c) Onno Invernizzi. All rights reserved.
// </copyright>

namespace Presentation.DependencyInjection
{
    using Microsoft.Extensions.DependencyInjection;
    using Presentation.Controllers;
    using StrongInject.Extensions.DependencyInjection;

    /// <summary>
    /// DependencyInjection extension class.
    /// </summary>
    public static class DependencyInjection
    {
        /// <summary>
        /// Setups the dependency injection.
        /// </summary>
        /// <param name="services">The services.</param>
        /// <returns>The IServiceCollection.</returns>
        public static IServiceCollection SetupDependencyInjection(this IServiceCollection services)
        {
            services.AddControllers().ResolveControllersThroughServiceProvider();
            services.AddTransientServiceUsingContainer<DIContainer, ApiController>();

            return services;
        }
    }
}
