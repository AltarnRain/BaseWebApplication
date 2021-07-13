// <copyright file="ServicesProvider.cs" company="Onno Invernizzi">
// Copyright (c) Onno Invernizzi. All rights reserved.
// </copyright>

namespace ServicesProvider.Provider
{
    using Models.Constracts;

    /// <summary>
    /// Top level class for providing services.
    /// </summary>
    public class ServicesProvider
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServicesProvider"/> class.
        /// </summary>
        /// <param name="logger">The logger.</param>
        public ServicesProvider(ILogger logger)
        {
            this.Logger = logger;
        }

        /// <summary>
        /// Gets the logger.
        /// </summary>
        public ILogger Logger { get; }
    }
}
