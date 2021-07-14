// <copyright file="ExtensionClass.cs" company="Onno Invernizzi">
// Copyright (c) Onno Invernizzi. All rights reserved.
// </copyright>

namespace Presentation.Extensions
{
    using Microsoft.Extensions.DependencyInjection;
    using Presentation.Controllers;
    using StrongInject.Extensions.DependencyInjection;

    /// <summary>
    /// Register class.
    /// </summary>
    public static partial class ExtensionClass
    {
        /// <summary>
        /// Configures the services.
        /// </summary>
        /// <param name="services">The services.</param>
        public static void ConfigureDependencyInjection(this IServiceCollection services)
        {
            services.AddControllers().ResolveControllersThroughServiceProvider();
            services.AddTransientServiceUsingContainer<DIContainer, ApiController>();
        }
    }
}
