// <copyright file="MenuModel.cs" company="Onno Invernizzi">
// Copyright (c) Onno Invernizzi. All rights reserved.
// </copyright>

namespace Domain.Models.Menu
{
    using Domain.Models.Base;
    using Domain.Models.Shared;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Model for a menu.
    /// </summary>
    public class MenuModel : BaseModel
    {
        /// <summary>
        /// Gets or sets the items.
        /// </summary>
        public IEnumerable<MenuModel> Items { get; set; } = Array.Empty<MenuModel>();

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the tags.
        /// </summary>
        public IEnumerable<TagModel> Tags { get; set; } = Array.Empty<TagModel>();
    }
}
