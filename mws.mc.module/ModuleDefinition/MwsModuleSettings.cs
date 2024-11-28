namespace mws.mc.module;

/// <summary>
/// Settings for MWS modules
/// </summary>
public class MwsModuleSettings
{
    /// <summary>
    /// Gets the connection string for the module
    /// </summary>
    public string ConnectionString { get; init; }

    /// <summary>
    /// Gets the type of connection for the module
    /// </summary>
    public TypesConnexion ConnectionType { get; init; }

    /// <summary>
    /// Gets the MAPI version for the module
    /// </summary>
    public Version MapiVersion { get; init; }

    /// <summary>
    /// Initializes a new instance of the <see cref="MwsModuleSettings"/> class
    /// </summary>
    /// <param name="connectionString">The connection string</param>
    /// <param name="connectionType">The type of connection</param>
    /// <param name="mapiVersion">The MAPI version</param>
    public MwsModuleSettings(
        string connectionString = "",
        TypesConnexion connectionType = TypesConnexion.None,
        Version? mapiVersion = null)
    {
        ConnectionString = connectionString;
        ConnectionType = connectionType;
        MapiVersion = mapiVersion ?? new Version(1, 0);
    }
}
