using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Microsoft.AspNetCore.Mvc;
using mws.mc.module;

namespace mws.mc.module.Controllers
{
    public class MwsModuleController : Controller
    {
        public MwsModuleController(IMwsModuleStartup mwsModuleStartup)
        {
            MwsModule = mwsModuleStartup.MwsModule;
        }

        public MwsModule MwsModule { get; }
    }
}
