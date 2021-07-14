// <copyright file="TagModel.cs" company="Onno Invernizzi">
// Copyright (c) Onno Invernizzi. All rights reserved.
// </copyright>

namespace Domain.Models.Shared
{
    using Domain.Models.Base;

    /// <summary>
    /// Model for a Tag.
    /// </summary>
    public class TagModel : BaseModel
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; } = string.Empty;
    }
}