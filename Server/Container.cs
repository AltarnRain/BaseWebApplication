// <copyright file="Container.cs" company="Onno Invernizzi">
// Copyright (c) Onno Invernizzi. All rights reserved.
// </copyright>

namespace BaseWebApplication
{
    using System;
    using BaseWebApplication.Controllers;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Logging;
    using StrongInject;

    /// <summary>
    /// DI Container.
    /// </summary>
    [Register(typeof(ApiController), Scope.InstancePerResolution)]
    public partial class Container : IContainer<ApiController>
    {
        /// <summary>
        /// The service provider.
        /// </summary>
        private readonly IServiceProvider serviceProvider;

        /// <summary>
        /// Initializes a new instance of the <see cref="Container" /> class.
        /// </summary>
        /// <param name="serviceProvider">The service provider.</param>
        public Container(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        /// <summary>
        /// Gets the logger.
        /// </summary>
        /// <typeparam name="T">Anything.</typeparam>
        /// <returns>An ILogger.</returns>
        [Factory]
        private ILogger<T> GetLogger<T>() => this.serviceProvider.GetRequiredService<ILogger<T>>();

        /// <summary>
        /// Gets the web host environment.
        /// </summary>
        /// <returns>The Webhost environment.</returns>
        [Factory]
        private IWebHostEnvironment GetWebHostEnvironment() => this.serviceProvider.GetRequiredService<IWebHostEnvironment>();
    }
}