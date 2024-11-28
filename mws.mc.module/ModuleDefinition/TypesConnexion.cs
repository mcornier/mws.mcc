namespace mws.mc.module;

/// <summary>
/// Defines the supported database connection types
/// </summary>
public enum TypesConnexion
{
    /// <summary>
    /// No connection type specified
    /// </summary>
    None = 0,

    /// <summary>
    /// SQLite database connection
    /// </summary>
    Sqlite = 1,

    /// <summary>
    /// SQL Server database connection
    /// </summary>
    SqlServer = 2,

    /// <summary>
    /// MySQL database connection
    /// </summary>
    MySql = 3
}
