// <copyright file="ApiController.cs" company="Onno Invernizzi">
// Copyright (c) Onno Invernizzi. All rights reserved.
// </copyright>

namespace BaseWebApplication.Controllers
{
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Mvc;
    using Models;

    /// <summary>
    /// Controller for API calls.
    /// </summary>
    /// <seealso cref="BaseWebApplication.Controllers.BaseController" />
    [Route("api")]
    public class ApiController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiController"/> class.
        /// </summary>
        /// <param name="webHostEnvironment">The web host environment.</param>
        public ApiController(IWebHostEnvironment webHostEnvironment)
            : base(webHostEnvironment)
        {
        }

        /// <summary>
        /// Calls the API.
        /// </summary>
        /// <returns>String response.</returns>
        [Route("callApi")]
        [HttpPost]
        public ResponseModel<string> CallApi()
        {
            return this.Respond("I was called");
        }
    }
}
