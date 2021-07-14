// <copyright file="BaseModel.cs" company="Onno Invernizzi">
// Copyright (c) Onno Invernizzi. All rights reserved.
// </copyright>

namespace Domain.Models.Base
{
    using Domain.Models.Shared;

    /// <summary>
    /// Base for all data transfer objects.
    /// </summary>
    public abstract class BaseModel
    {
        /// <summary>
        /// Gets or sets the identity.
        /// </summary>
        public IdentityModel Identity { get; set; } = new IdentityModel();
    }
}