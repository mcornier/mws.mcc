using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using mws.mc.module;

namespace mws.mc.core
{
    public static class Modules
    {
        public static IEnumerable<Assembly> LoadAssembliesWithControllers(IServiceCollection services)
        {
            List<Assembly> assemblies = new List<Assembly>();

            // Todo : check in module folder and load
            string appRoot = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            string modulesPath = Path.Combine(appRoot, "modules");
            if(Directory.Exists(modulesPath))
            {
                string [] fileEntries = Directory.GetFiles(modulesPath, "*.dll");
                foreach(string fileName in fileEntries)
                {
                    Assembly moduleAssembly = Assembly.LoadFile(fileName);

                    if(fileName.Contains(".Views.dll"))
                    {
                        var a = moduleAssembly.FullName;
                    }

                    assemblies.Add(moduleAssembly);
                }
            }

            foreach(Assembly assembly in assemblies)
            {
                InitializeModule(services, assembly);
            }

            return assemblies;
        }

        private static void InitializeModule(IServiceCollection services, Assembly assembly)
        {
            foreach (Type type in assembly.GetTypes())
            {
                if (typeof(IMwsModuleStartup).IsAssignableFrom(type))
                {
                    IMwsModuleStartup startup = Activator.CreateInstance(type) as IMwsModuleStartup;

                    if(startup != null)
                    {
                        startup.Start(services, new MwsModuleSettings());
                    }
                }
            }
        }
    }
}
