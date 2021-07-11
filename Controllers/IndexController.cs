using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace Documentation.Controllers
{
    /// <summary>
    /// Controller when the user first hits the website.
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    //public class IndexController : DocumentationControllerBase
    //{
    //    //public IndexController(IWebHostEnvironment webHostEnvironment) : base(webHostEnvironment)
    //    //{
    //    //}

    //    //[HttpGet]
    //    //[Route("/")]
    //    //public ContentResult Index()
    //    //{   
    //    //    return base.Content(this.GetIndexHtmlContent(), "text/html");
    //    //}

    //    //[HttpGet]
    //    //[Route("/Client/{*file}")]
    //    //public ContentResult Client(string file)
    //    //{
    //    //    var jsFile = Path.Combine(this.GetClientPath(), file + ".js");

    //    //    string fileContent = string.Empty;

    //    //    if (System.IO.File.Exists(jsFile)) 
    //    //    {
    //    //        fileContent = System.IO.File.ReadAllText(jsFile);
    //    //    }

    //    //    return base.Content(fileContent);
    //    //}

    //    //[HttpGet]
    //    //[Route("/js/{*file}")]
    //    //public ContentResult Js(string file)
    //    //{
    //    //    var jsFile = Path.Combine(this.GetClientPath(), "js", file);

    //    //    string fileContent = string.Empty;

    //    //    if (System.IO.File.Exists(jsFile))
    //    //    {
    //    //        fileContent = System.IO.File.ReadAllText(jsFile);
    //    //    }

    //    //    return base.Content(fileContent);
    //    //}
    //}
}
