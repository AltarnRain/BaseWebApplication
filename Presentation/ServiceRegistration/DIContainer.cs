// <copyright file="DIContainer.cs" company="Onno Invernizzi">
// Copyright (c) Onno Invernizzi. All rights reserved.
// </copyright>

#pragma warning disable CS1591

namespace Presentation
{
    using Application.Contracts;
    using Application.Services;
    using Infrastructure.Services;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Logging;
    using Presentation.Controllers;
    using StrongInject;
    using System;

    /// <summary>
    /// DI Container.
    /// </summary>
    [Register(typeof(ApiController), Scope.InstancePerResolution)]
    [Register(typeof(SayService), Scope.InstancePerResolution)]
    [Register(typeof(CurrentDateTimeProvider), Scope.SingleInstance, typeof(IDateTimeProvider))]

    public partial class DIContainer : IContainer<ApiController>
    {
        /// <summary>
        /// The service provider.
        /// </summary>
        private readonly IServiceProvider serviceProvider;

        /// <summary>
        /// Initializes a new instance of the <see cref="DIContainer"/> class.
        /// </summary>
        /// <param name="serviceProvider">The service provider.</param>
        public DIContainer(IServiceProvider serviceProvider)
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