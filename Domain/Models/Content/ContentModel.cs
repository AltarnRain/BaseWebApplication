// <copyright file="ContentModel.cs" company="Onno Invernizzi">
// Copyright (c) Onno Invernizzi. All rights reserved.
// </copyright>

namespace Models.Content
{
    using Domain.Models.Base;

    /// <summary>
    /// Model for content server to the client.
    /// </summary>
    public class ContentModel : BaseModel
    {
        /// <summary>
        /// Gets or sets the content.
        /// </summary>
        public string Content { get; set; } = string.Empty;
    }
}
