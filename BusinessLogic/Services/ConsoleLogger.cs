// <copyright file="ConsoleLogger.cs" company="Onno Invernizzi">
// Copyright (c) Onno Invernizzi. All rights reserved.
// </copyright>

namespace BusinessLogic.Services
{
    using System;
    using Models.Diagnostics;

    /// <summary>
    /// Logs to the console.
    /// </summary>
    /// <seealso cref="Models.Constracts.ILogger" />
    public class ConsoleLogger : Models.Constracts.ILogger
    {
        /// <summary>
        /// Logs the specified log model.
        /// </summary>
        /// <param name="logModel">The log model.</param>
        public void Log(LogModel logModel)
        {
            Console.WriteLine(logModel.Message);
        }
    }
}
