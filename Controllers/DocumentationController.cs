using DocumentationModels.Menu;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace Documentation.Controllers
{
    [Route("api/Documentation")]
    public class DocumentationController : DocumentationControllerBase
    {
        public DocumentationController(IWebHostEnvironment webHostEnvironment) : base(webHostEnvironment)
        {
        }

        [HttpPost]
        [Route(nameof(GetMainMenu))]
        public MenuModel GetMainMenu()
        {
            return new MenuModel
            {
                Title = "Main menu",
                Menus = new MenuModel[]
                {
                    new MenuModel
                    {
                        Title = "Sub menu",
                        Menus = new MenuModel[]
                        {
                            new MenuModel
                            {
                                Title = "Sub Sub Menu"
                            },
                        }
                    }
                }
            };
        }
    }
}
