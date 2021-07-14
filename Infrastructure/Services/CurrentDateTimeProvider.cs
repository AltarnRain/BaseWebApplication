// <copyright file="CurrentDateTimeProvider.cs" company="Onno Invernizzi">
// Copyright (c) Onno Invernizzi. All rights reserved.
// </copyright>

namespace Infrastructure.Services
{
    using Application.Contracts;
    using System;

    /// <summary>
    /// Provides the current date time.
    /// </summary>
    /// <seealso cref="Application.Contracts.IDateTimeProvider" />
    public class CurrentDateTimeProvider : IDateTimeProvider
    {
        /// <summary>
        /// Gets the date time.
        /// </summary>
        /// <returns>
        /// Current date time.
        /// </returns>
        public DateTime Now()
        {
            return System.DateTime.Now;
        }
    }
}
