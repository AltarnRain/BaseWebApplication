// <copyright file="ApiRouteAttribute.cs" company="Onno Invernizzi">
// Copyright (c) Onno Invernizzi. All rights reserved.
// </copyright>

namespace BaseWebApplication.Attributes
{
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// Defines an /api/route.
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.RouteAttribute" />
    public class ApiRouteAttribute : RouteAttribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiRouteAttribute" /> class.
        /// </summary>
        /// <param name="template">The template.</param>
        public ApiRouteAttribute(string template)
            : base("api/" + template)
        {
            this.Name = template;
        }
    }
}
