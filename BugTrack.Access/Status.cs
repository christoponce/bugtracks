using System;

namespace BugTrack.Access
{
    /// <summary>
    /// Enum that represents the current status of an Issue object.
    /// </summary>
    [Serializable]
    public enum Status
    {
        Pending = 1,
        Active = 2,
        Complete = 3
    }
}