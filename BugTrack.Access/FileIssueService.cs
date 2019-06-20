using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace BugTrack.Access
{
    /// <summary>
    /// Performs basic operations on a list of Issue objects.
    /// </summary>
    public class FileIssueService : IIssueService
    {
        // list for issue objects to be used while program is running
        private static List<Issue> issueList = new List<Issue>();

        // empty, parameterless constructor
        public FileIssueService() { }
        
        /// <summary>
        /// Adds a single Issue object to the list of issues
        /// </summary>
        /// <param name="issue"></param>
        public void Add(Issue issue) => issueList.Add(issue);
        
        /// <summary>
        /// Gets the entire current list of Issue objects.
        /// </summary>
        /// <returns>Returns a list of Issue objects.</returns>
        public List<Issue> GetAllIssues() => issueList;

        /// <summary>
        /// Returns a list of issues that have the specified importance level.
        /// </summary>
        /// <param name="importance"></param>
        /// <returns>Returns a list of Issue objects that match the specified importance level.</returns>
        public List<Issue> GetByImportance(int importance) => issueList.Where(x => x.Importance == importance).ToList();
        
        /// <summary>
        /// Returns a list of issues that have the specified status.
        /// </summary>
        /// <param name="stat"></param>
        /// <returns>Returns a list of Issue objects that match the specified Status.</returns>
        public List<Issue> GetByStatus(Status stat) => issueList.Where(x => x.Status == stat).ToList();

        /// <summary>
        /// Returns a list of issues that have the specified title.
        /// </summary>
        /// <param name="title"></param>
        /// <returns>Returns a list of Issue objects that match the specified title.</returns>
        public List<Issue> GetByTitle(string title) => issueList.Where(x => x.Title == title).ToList();

        /// <summary>
        /// Returns a list of issues that have the specified assignee assigned to them.
        /// </summary>
        /// <param name="assignee"></param>
        /// <returns>Returns a list of Issue objects that have the specified assignee.</returns>
        public List<Issue> GetByAssignee(string assignee) => issueList.Where(x => x.Assignee == assignee).ToList();

        /// <summary>
        /// Gets a single Issue object from the list that matches a given ID number.
        /// <para>Returns null if no matches where found.</para>
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Returns an Issue object. Returns null otherwise.</returns>
        public Issue GetByID(Guid id) => issueList.Where(x => x.Id == id).FirstOrDefault();

        /// <summary>
        /// Saves the list of Issue objects to an XML file.
        /// </summary>
        public void Save(string path)
        {
            if (!string.IsNullOrEmpty(path))
            {
                var xs = new XmlSerializer(typeof(List<Issue>));

                using (var sr = new StreamWriter(path))
                {
                    xs.Serialize(sr, issueList);
                }
            }
        }
        
        /// <summary>
        /// Loads a list of Issue objects from an XML file.
        /// </summary>
        public void Load(string path)
        {
            if (!string.IsNullOrEmpty(path))
            {
                var xs = new XmlSerializer(typeof(List<Issue>));

                using (var reader = new StreamReader(path))
                {
                    issueList = (List<Issue>)xs.Deserialize(reader);
                }
            }
        }

        /// <summary>
        /// Searches the list of Issue objects and changes the Status enum of a matching result, if any.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="stat"></param>
        public void ChangeStatus(Guid id, Status stat)
        {
            var temp = issueList.Where(x => x.Id == id).FirstOrDefault();
            
            if (temp != null)
            {
                issueList[issueList.IndexOf(temp)].Status = stat;
            }
        }

        /// <summary>
        /// Deletes an issue that matches the specified ID.
        /// </summary>
        /// <param name="id"></param>
        public void Delete(Guid id) => issueList.RemoveAt(issueList.IndexOf(issueList.Where(x => x.Id == id).First()));
        
    }
}