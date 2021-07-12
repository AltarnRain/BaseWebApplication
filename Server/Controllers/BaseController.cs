// <copyright file="BaseController.cs" company="Onno Invernizzi">
// Copyright (c) Onno Invernizzi. All rights reserved.
// </copyright>

namespace BaseWebApplication.Controllers
{
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Mvc;
    using Models;

    /// <summary>
    /// Base class for all controllers.
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    public abstract class BaseController : ControllerBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseController"/> class.
        /// </summary>
        /// <param name="webHostEnvironment">The web host environment.</param>
        public BaseController(IWebHostEnvironment webHostEnvironment)
        {
            this.WebHostEnvironment = webHostEnvironment;
        }

        /// <summary>
        /// Gets the web host environment.
        /// </summary>
        protected IWebHostEnvironment WebHostEnvironment { get; }

        /// <summary>
        /// Responds with the specified value.
        /// </summary>
        /// <typeparam name="T">Any type.</typeparam>
        /// <param name="value">The value.</param>
        /// <returns>A response model that contains the value.</returns>
        public ResponseModel<T> Respond<T>(T value)
        {
            var response = new ResponseModel<T>
            {
                Value = value,
            };

            return response;
        }
    }
}
