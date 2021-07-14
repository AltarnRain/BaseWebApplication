// <copyright file="IdentityModel.cs" company="Onno Invernizzi">
// Copyright (c) Onno Invernizzi. All rights reserved.
// </copyright>

namespace Domain.Models.Base
{
    /// <summary>
    /// Model for an identity.
    /// </summary>
    public class IdentityModel
    {
        /// <summary>
        /// Gets or sets the identity.
        /// </summary>
        public string Identity { get; set; } = DomainConstants.DefaultIdentity;
    }
}