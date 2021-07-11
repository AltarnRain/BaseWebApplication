using DocumentationModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace Documentation.Controllers
{
    public abstract class DocumentationControllerBase : ControllerBase
    {
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
