using System;
using System.Collections.Generic;

namespace BugTrack.Access
{
    /// <summary>
    /// Interface for handling different interactions with Issue objects.
    /// </summary>
    public interface IIssueService
    {
        // get all issues
        List<Issue> GetAllIssues();

        // get a single issue by its Guid
        Issue GetByID(Guid id);

        // list issue objects that have a specified status
        List<Issue> GetByStatus(Status stat);

        // get any issues that match the specified title
        List<Issue> GetByTitle(string title);

        // get any issues that have the given assignee assigned
        List<Issue> GetByAssignee(string assignee);

        // get any issues that have the given importance level
        List<Issue> GetByImportance(int importance);

        // writes all issues to a file
        void Save(string path);

        // read all issues from a file
        void Load(string path);

        // adds issues to an issue list
        void Add(Issue issue);

        // changes an issue object's status
        void ChangeStatus(Guid id, Status stat);

        // delete an issue object
        void Delete(Guid id);
    }
}