using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using System;
using System.Threading.Tasks;
using mws.mc.module;

namespace mws.mc.demo
{
    public class Startup : MwsModule, IMwsModuleStartup
    {
        public new const string Name = "demo";

        public new Guid ModuleKey => new Guid("5b1c2320-c82e-457d-b843-8e6dbbcc3e26");

        public new Version Version => new Version(0,1);

        public new string Description => "demo module";

        Task IMwsModuleStartup.Start(IServiceCollection services, MwsModuleSettings settings)
        {
            Settings = settings;

            services.AddSingleton<IMwsModuleStartup, Startup>();

            _instance = this;

            return Task.CompletedTask;
        }

        public MwsModuleSettings Settings { get; private set; }

        private static IMwsModuleStartup _instance = null;
        public static IMwsModuleStartup Instance => _instance;

        public MwsModule MwsModule => this;

    }
}
