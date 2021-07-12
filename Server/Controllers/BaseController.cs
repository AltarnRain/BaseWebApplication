// <copyright file="BaseController.cs" company="Onno Invernizzi">
// Copyright (c) Onno Invernizzi. All rights reserved.
// </copyright>

namespace BaseWebApplication.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Models;

    /// <summary>
    /// Base class for all controllers.
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    public abstract class BaseController : ControllerBase
    {
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
