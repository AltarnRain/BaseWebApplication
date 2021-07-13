// <copyright file="DIContainer.cs" company="Onno Invernizzi">
// Copyright (c) Onno Invernizzi. All rights reserved.
// </copyright>

namespace ServicesProvider.Container
{
    using BusinessLogic.Services;
    using StrongInject;

    /// <summary>
    /// Top level class for services.
    /// </summary>
    [Register(typeof(Provider.ServicesProvider), Scope.SingleInstance)]
    [Register(typeof(ConsoleLogger), typeof(Models.Constracts.ILogger))]
    public partial class DIContainer : IContainer<Provider.ServicesProvider>
    {
        /// <summary>
        /// The self.
        /// </summary>
        private static DIContainer? self;

        /// <summary>
        /// Prevents a default instance of the <see cref="DIContainer"/> class from being created.
        /// </summary>
        private DIContainer()
        {
        }

        /// <summary>
        /// Creates this instance.
        /// </summary>
        /// <returns>Instance of DIContainer.</returns>
        public static DIContainer Create()
        {
            if (self is null)
            {
                self = new DIContainer();
            }

            return self;
        }
    }
}
