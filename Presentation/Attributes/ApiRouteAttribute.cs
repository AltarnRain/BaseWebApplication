// <copyright file="ApiRouteAttribute.cs" company="Onno Invernizzi">
// Copyright (c) Onno Invernizzi. All rights reserved.
// </copyright>

namespace Presentation.Attributes
{
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// Defines an /api/route.
    /// Extends RouteAttribute and sets the 'template' as the 'Name'.
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
