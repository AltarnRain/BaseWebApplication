// <copyright file="ResponseModel.cs" company="Onno Invernizzi">
// Copyright (c) Onno Invernizzi. All rights reserved.
// </copyright>

namespace Models
{
    using Models.Base;

    /// <summary>
    /// Wrapper class for all responses. The client only accepts JSON objects.
    /// </summary>
    /// <typeparam name="T">Any type.</typeparam>
    public class ResponseModel<T> : BaseResponse
    {
        /// <summary>
        /// Gets or sets value we want to return to the client.
        /// </summary>
        public T? Value { get; set; }
    }
}
