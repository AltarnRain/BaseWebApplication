// <copyright file="ApiController.cs" company="Onno Invernizzi">
// Copyright (c) Onno Invernizzi. All rights reserved.
// </copyright>

namespace Presentation.Controllers
{
    using Application.Services;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Mvc;
    using Models;
    using Presentation.Attributes;

    /// <summary>
    /// Controller for API calls.
    /// </summary>
    public class ApiController : BaseController
    {
        private readonly SayService sayService;

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiController" /> class.
        /// </summary>
        /// <param name="webHostEnvironment">The web host environment.</param>
        /// <param name="sayService">The say service.</param>
        public ApiController(IWebHostEnvironment webHostEnvironment, SayService sayService)
            : base(webHostEnvironment)
        {
            this.sayService = sayService;
        }

        /// <summary>
        /// Calls the API.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>
        /// String response.
        /// </returns>
        [ApiRoute(nameof(SayHello))]
        [HttpPost]
        public ResponseModel<string> SayHello(string name)
        {
            var response = this.sayService.SayHello(name);
            return this.Respond(response);
        }

        /// <summary>
        /// Calls the API.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>
        /// String response.
        /// </returns>
        [ApiRoute(nameof(SayGoodbye))]
        [HttpPost]
        public ResponseModel<string> SayGoodbye(string name)
        {
            var response = this.sayService.SayGoodbye(name);
            return this.Respond(response);
        }
    }
}
