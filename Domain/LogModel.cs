// <copyright file="LogModel.cs" company="Onno Invernizzi">
// Copyright (c) Onno Invernizzi. All rights reserved.
// </copyright>

namespace Models.Diagnostics
{
    using Models.Base;

    /// <summary>
    /// Basic model for logging messages.
    /// </summary>
    public class LogModel : BaseModel
    {
        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        public string? Message { get; set; }
    }
}