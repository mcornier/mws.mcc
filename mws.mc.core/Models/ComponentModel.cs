namespace mws.mc.core.Models;

/// <summary>
/// Represents a component in the application
/// </summary>
public class ComponentModel
{
    /// <summary>
    /// Gets or sets the unique identifier for the component
    /// </summary>
    public Guid Id { get; set; } = Guid.NewGuid();
    
    /// <summary>
    /// Gets or sets the controller name for the component
    /// </summary>
    public string Controller { get; set; } = string.Empty;

    /// <summary>
    /// Initializes a new instance of the <see cref="ComponentModel"/> class
    /// </summary>
    public ComponentModel()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ComponentModel"/> class with a specified controller
    /// </summary>
    /// <param name="controller">The controller name</param>
    public ComponentModel(string controller)
    {
        Controller = controller;
    }
}
