namespace Rykard.Shared.Security;

/// <summary>
/// Available roles for Rykard.
/// </summary>
public static class ApplicationRoles
{
    /// <summary>
    /// Can manage the application, like creating new administrators, adding new motors and garage doors.
    /// </summary>
    public const string Administrator = nameof(Administrator);
    
    /// <summary>
    /// Default application user, can list doors, and manage their states. Also can see door logs.
    /// </summary>
    public const string Default = nameof(Default);
    
    /// <summary>
    /// Can open or close doors once based on a TTL.
    /// </summary>
    public const string Guest = nameof(Guest);
}