﻿using DocumentationModels.Menu;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace Documentation.Controllers
{
    [Route("api")]
    public class ApiController : DocumentationControllerBase
    {
        private readonly IWebHostEnvironment webHostEnvironment;

        public ApiController(IWebHostEnvironment webHostEnvironment)
        {
            this.webHostEnvironment = webHostEnvironment;
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