using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mws.mc.core.Models;

namespace mws.mc.core.Controllers
{
    public class PageController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public PageController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            PageRowsModel Model = new PageRowsModel();

            Model.Title = "page - demo";

            Model.Components.Add(new ComponentModel{ Controller = "demo" });
            Model.Components.Add(new ComponentModel{ Controller = "demo" });
            Model.Components.Add(new ComponentModel{ Controller = "demo" });
            Model.Components.Add(new ComponentModel{ Controller = "demo" });
            Model.Components.Add(new ComponentModel{ Controller = "demo" });
            Model.Components.Add(new ComponentModel{ Controller = "demo" });
            Model.Components.Add(new ComponentModel{ Controller = "demo" });
            Model.Components.Add(new ComponentModel{ Controller = "demo" });
            Model.Components.Add(new ComponentModel{ Controller = "demo" });

            return View(Model);
        }
    }
}
