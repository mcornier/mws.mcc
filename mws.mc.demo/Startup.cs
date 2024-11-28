using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using mws.mc.module;

namespace mws.mc.demo;

public class Startup : MwsModule, IMwsModuleStartup
{
    private static readonly Guid ModuleGuid = new("5b1c2320-c82e-457d-b843-8e6dbbcc3e26");
    private static readonly Version ModuleVersion = new(0, 1);
    private const string ModuleDescription = "demo module";
    public new const string Name = "demo";

    private static IMwsModuleStartup? _instance;
    private static readonly object _lock = new();

    public Startup() : base(ModuleGuid, ModuleVersion, ModuleDescription)
    {
    }

    public MwsModuleSettings Settings { get; private set; } = null!;

    public static IMwsModuleStartup Instance
    {
        get
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    _instance ??= new Startup();
                }
            }
            return _instance;
        }
    }

    public MwsModule MwsModule => this;

    Task IMwsModuleStartup.Start(IServiceCollection services, MwsModuleSettings settings)
    {
        Settings = settings;
        services.AddSingleton<IMwsModuleStartup>(_ => this);
        
        lock (_lock)
        {
            _instance = this;
        }

        return Task.CompletedTask;
    }
}
