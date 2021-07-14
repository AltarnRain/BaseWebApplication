// <copyright file="SayService.cs" company="Onno Invernizzi">
// Copyright (c) Onno Invernizzi. All rights reserved.
// </copyright>

namespace Application.Services
{
    using Application.Contracts;

    /// <summary>
    /// Says something.
    /// </summary>
    public class SayService
    {
        /// <summary>
        /// The date time provider.
        /// </summary>
        private readonly IDateTimeProvider dateTimeProvider;

        /// <summary>
        /// Initializes a new instance of the <see cref="SayService"/> class.
        /// </summary>
        /// <param name="dateTimeProvider">The date time provider.</param>
        public SayService(IDateTimeProvider dateTimeProvider)
        {
            this.dateTimeProvider = dateTimeProvider;
        }

        /// <summary>
        /// Says the hello.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>Hello Name.</returns>
        public string SayHello(string name)
        {
            return this.Say("Hello", name);
        }

        /// <summary>
        /// Says the goodbye.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>Bye Name.</returns>
        public string SayGoodbye(string name)
        {
            return this.Say("Goodbye", name);
        }

        private string Say(string word, string name)
        {
            var currentDateTime = this.dateTimeProvider.Now();

            return $"{word}  {name} its {currentDateTime}";
        }
    }
}
