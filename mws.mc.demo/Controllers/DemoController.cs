using System;
using mws.mc.module.Controllers;
using Microsoft.AspNetCore.Mvc;
using mws.mc.module;

namespace mws.mc.demo
{
    //[Area(Startup.Name)]
    public class DemoController : MwsModuleController
    {
        public DemoController(IMwsModuleStartup mwsModuleStartup) : base(mwsModuleStartup)
        { 
            var a = this.MwsModule;
        }

        public IActionResult Index()
        {
            return PartialView();
        }
    }
}
