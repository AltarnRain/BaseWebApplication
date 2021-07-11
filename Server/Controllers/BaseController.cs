using DocumentationModels;
using Microsoft.AspNetCore.Mvc;

namespace Documentation.Controllers
{
    public abstract class BaseController : ControllerBase
    {
        /// <summary>
        /// Responds the specified value.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public ResponseModel<T> Respond<T>(T value)
        {
            var response = new ResponseModel<T>
            {
                Model = value
            };

            return response;
        }
    }
}
