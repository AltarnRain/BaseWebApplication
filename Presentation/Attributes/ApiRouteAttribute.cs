// <copyright file="ApiRouteAttribute.cs" company="Onno Invernizzi">
// Copyright (c) Onno Invernizzi. All rights reserved.
// </copyright>

namespace Presentation.Attributes
{
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// Defines an /api/route.
    /// Extends RouteAttribute and sets the 'template' as the 'Name'. This ensures the OpenAPI v3 json file contains
    /// names we can base server call methods on in the client. These are automatically generated so it is very, very
    /// important to set the name otherwise you'll get server call methods called postService1, postService2, etc.
    /// </summary>
    /// <seealso cref="RouteAttribute" />
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
