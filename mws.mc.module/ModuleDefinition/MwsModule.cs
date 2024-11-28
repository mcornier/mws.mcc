namespace mws.mc.module;

/// <summary>
/// Base class for MWS modules
/// </summary>
public abstract class MwsModule
{
    /// <summary>
    /// The default name of the module
    /// </summary>
    public const string Name = "mws.mc.module";

    /// <summary>
    /// Gets the unique identifier for this module
    /// </summary>
    public Guid ModuleKey { get; init; }

    /// <summary>
    /// Gets the version of this module
    /// </summary>
    public Version Version { get; init; }

    /// <summary>
    /// Gets the description of this module
    /// </summary>
    public string Description { get; init; }

    /// <summary>
    /// Initializes a new instance of the <see cref="MwsModule"/> class
    /// </summary>
    /// <param name="moduleKey">The unique identifier for this module</param>
    /// <param name="version">The version of this module</param>
    /// <param name="description">The description of this module</param>
    protected MwsModule(Guid moduleKey, Version version, string description = "")
    {
        ModuleKey = moduleKey;
        Version = version;
        Description = description;
    }
}
