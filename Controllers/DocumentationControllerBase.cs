using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace Documentation.Controllers
{
    public abstract class DocumentationControllerBase : ControllerBase
    {
        private IWebHostEnvironment webHostEnvironment;

        public DocumentationControllerBase(IWebHostEnvironment webHostEnvironment)
        {
            this.webHostEnvironment = webHostEnvironment;
        }

        public string GetClientPath()
        {
            var rootPath = this.webHostEnvironment.ContentRootPath;
            return Path.Combine(rootPath, "Client");
        }

        public string GetIndexHtmlContent()
        {
            var clientRootPath = this.GetClientPath();

            var indexHtmlFile = Path.Combine(clientRootPath, "index.html");

            var htmlFileContent = System.IO.File.ReadAllText(indexHtmlFile);
            return htmlFileContent;
        }
    }
}
