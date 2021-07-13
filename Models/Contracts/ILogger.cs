// <copyright file="ILogger.cs" company="Onno Invernizzi">
// Copyright (c) Onno Invernizzi. All rights reserved.
// </copyright>

namespace Models.Constracts
{
    using Models.Diagnostics;

    /// <summary>
    /// Defines a contract for a logger class.
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// Logs the specified log model.
        /// </summary>
        /// <param name="logModel">The log model.</param>
        void Log(LogModel logModel);
    }
}