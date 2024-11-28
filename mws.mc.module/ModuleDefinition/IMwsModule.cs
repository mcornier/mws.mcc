using Microsoft.Extensions.DependencyInjection;

namespace mws.mc.module;

public interface IMwsModuleStartup
{
    /// <summary>
    /// Initializes the module with the provided services and settings
    /// </summary>
    /// <param name="services">The service collection to configure</param>
    /// <param name="settings">The module settings</param>
    Task Start(IServiceCollection services, MwsModuleSettings settings);

    /// <summary>
    /// Gets the current module settings
    /// </summary>
    MwsModuleSettings Settings { get; }

    /// <summary>
    /// Gets the associated MWS module
    /// </summary>
    MwsModule MwsModule { get; }
}
