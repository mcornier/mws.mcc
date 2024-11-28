namespace mws.mc.core.Models;

/// <summary>
/// Represents a page in the application
/// </summary>
public class PageModel
{
    /// <summary>
    /// Gets or sets the unique identifier for the page
    /// </summary>
    public Guid Id { get; set; } = Guid.NewGuid();

    /// <summary>
    /// Gets or sets the title of the page
    /// </summary>
    public string Title { get; set; } = string.Empty;

    /// <summary>
    /// Initializes a new instance of the <see cref="PageModel"/> class
    /// </summary>
    public PageModel()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="PageModel"/> class with a specified title
    /// </summary>
    /// <param name="title">The page title</param>
    public PageModel(string title)
    {
        Title = title;
    }
}

/// <summary>
/// Represents a page that contains components arranged in rows
/// </summary>
public class PageRowsModel : PageModel
{
    /// <summary>
    /// Gets or sets the list of components in the page
    /// </summary>
    public List<ComponentModel> Components { get; set; } = new();

    /// <summary>
    /// Initializes a new instance of the <see cref="PageRowsModel"/> class
    /// </summary>
    public PageRowsModel()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="PageRowsModel"/> class with a specified title
    /// </summary>
    /// <param name="title">The page title</param>
    public PageRowsModel(string title) : base(title)
    {
    }
}
