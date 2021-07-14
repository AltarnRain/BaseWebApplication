// <copyright file="IDateTimeProvider.cs" company="Onno Invernizzi">
// Copyright (c) Onno Invernizzi. All rights reserved.
// </copyright>

namespace Application.Contracts
{
    using System;

    /// <summary>
    /// Provides a Date Time.
    /// </summary>
    public interface IDateTimeProvider
    {
        /// <summary>
        /// Gets the date time.
        /// </summary>
        /// <returns>Current date time.</returns>
        DateTime Now();
    }
}
