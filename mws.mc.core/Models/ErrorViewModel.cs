namespace mws.mc.core.Models;

/// <summary>
/// Represents the view model for error pages
/// </summary>
public class ErrorViewModel
{
    /// <summary>
    /// Gets or sets the request ID associated with the error
    /// </summary>
    public string RequestId { get; set; } = string.Empty;

    /// <summary>
    /// Gets a value indicating whether to show the request ID
    /// </summary>
    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

    /// <summary>
    /// Initializes a new instance of the <see cref="ErrorViewModel"/> class
    /// </summary>
    public ErrorViewModel()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ErrorViewModel"/> class with a specified request ID
    /// </summary>
    /// <param name="requestId">The request ID associated with the error</param>
    public ErrorViewModel(string requestId)
    {
        RequestId = requestId;
    }
}
