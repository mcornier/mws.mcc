using Microsoft.Extensions.DependencyInjection;
using mws.mc.module;
using System.Reflection;

namespace mws.mc.core;

public static class Modules
{
    public static IEnumerable<Assembly> LoadAssembliesWithControllers(IServiceCollection services)
    {
        var assemblies = new List<Assembly>();

        // Get the modules directory path
        string appRoot = Path.GetDirectoryName(Assembly.GetEntryAssembly()?.Location) 
            ?? throw new InvalidOperationException("Unable to determine application root directory");
        string modulesPath = Path.Join(appRoot, "modules");

        if (Directory.Exists(modulesPath))
        {
            // Load all DLL files from the modules directory
            var fileEntries = Directory.GetFiles(modulesPath, "*.dll");
            foreach (string fileName in fileEntries)
            {
                try
                {
                    var moduleAssembly = Assembly.LoadFile(fileName);
                    assemblies.Add(moduleAssembly);
                }
                catch (Exception ex)
                {
                    // Log or handle the assembly loading error
                    Console.WriteLine($"Error loading module assembly {fileName}: {ex.Message}");
                }
            }
        }

        // Initialize each loaded module
        foreach (var assembly in assemblies)
        {
            InitializeModule(services, assembly);
        }

        return assemblies;
    }

    private static void InitializeModule(IServiceCollection services, Assembly assembly)
    {
        var moduleTypes = assembly.GetTypes()
            .Where(type => !type.IsAbstract && typeof(IMwsModuleStartup).IsAssignableFrom(type));

        foreach (var type in moduleTypes)
        {
            try
            {
                if (Activator.CreateInstance(type) is IMwsModuleStartup startup)
                {
                    startup.Start(services, new MwsModuleSettings());
                }
            }
            catch (Exception ex)
            {
                // Log or handle the module initialization error
                Console.WriteLine($"Error initializing module {type.FullName}: {ex.Message}");
            }
        }
    }
}
