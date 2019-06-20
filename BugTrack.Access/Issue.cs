using System;

namespace BugTrack.Access
{
    /// <summary>
    /// Has properties pertaining to general issues/bugs.
    /// <para>Each issue automatically gets a unique Guid for an Id when created.</para>
    /// </summary>
    public class Issue
    {
        // empty constructor
        public Issue()
        {
            Id = Guid.NewGuid();
        }

        /// <summary>
        /// An ID that is unique to each Issue object.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Represents the title/name of this Issue object.
        /// <para>End-user defined.</para>
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Represents a short description of this Issue object.
        /// <para>End-user defined.</para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Represents a level of importance for this Issue object.
        /// <para>End-user defined.</para>
        /// </summary>
        public int Importance { get; set; }

        /// <summary>
        /// Represents the person/team assigned to solving this Issue object.
        /// <para>End-user defined.</para>
        /// </summary>
        public string Assignee { get; set; }

        /// <summary>
        /// Enum that represents the current status of completion of this Issue object.
        /// </summary>
        public Status Status { get; set; }

        public override string ToString() => $"Title: {Title}   |   ID: {Id}";
    }
}