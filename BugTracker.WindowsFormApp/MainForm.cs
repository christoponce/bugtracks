using System;
using BugTrack.Access;
using System.Windows.Forms;
using System.Drawing;

namespace BugTracker.WindowsFormApp
{
    /// <summary>
    /// MessageType enum for determining how to color the background of the message textbox.
    /// </summary>
    public enum MessageType
    {
        Success = 1,
        Normal = 2,
        Error = 3
    }

    public partial class MainForm : Form
    {
        #region Fields

        private Issue currentIssue;
        private FileIssueService fis;

        #endregion

        public MainForm()
        {
            InitializeComponent();

            fis = new FileIssueService();

            CBStatus.DataSource = Enum.GetValues(typeof(Status));
            CBStatus.SelectedIndex = 0;

            DisableSearchOptions();
        }

        #region Form Events

        //create issue - button
        private void createIssueButton_Click(object sender, EventArgs e)
        {
            if (InputIsValid())
            {
                try
                {
                    Issue newIssue = new Issue()
                    {
                        Title = TBIssueTitle.Text,
                        Assignee = TBAssignee.Text,
                        Description = TBDescription.Text,
                        Importance = (int)UDImportance.Value,
                        Status = (Status)CBStatus.SelectedIndex + 1
                    };

                    fis.Add(newIssue);
                    currentIssue = newIssue;

                    WriteMessage("New issue has been created successfully and is selected for editing.", MessageType.Success);
                }
                catch (Exception ex)
                {
                    WriteMessage($"Error: {ex.Message}", MessageType.Error);
                }
            }
            else
            {
                WriteMessage("Failed to create a new issue: All fields must be filled out in order to create a new issue.", MessageType.Error);
            }
        }

        // apply all changes to the current issue - button
        private void BTNApplyChanges_Click(object sender, EventArgs e)
        {
            // currentIssue cannot be null; shouldSaveChanges must be true; all input fields must be valid (not null or empty)
            if (currentIssue != null && 
                InputIsValid())
            {
                try
                {
                    Enum.TryParse(CBStatus.SelectedValue.ToString(), out Status status);

                    currentIssue.Title = TBIssueTitle.Text;
                    currentIssue.Assignee = TBAssignee.Text;
                    currentIssue.Description = TBDescription.Text;
                    currentIssue.Importance = (int)UDImportance.Value;
                    currentIssue.Status = status;

                    WriteMessage("Changes successfully applied.", MessageType.Success);
                }
                catch (Exception ex)
                {
                    WriteMessage($"Failed to apply changes: {ex.Message}", MessageType.Error);
                }
            }
        }

        //show all issues - button
        private void showIssuesButton_Click(object sender, EventArgs e)
        {
            DialogResult result;

            using (ShowIssuesForm allIssues = new ShowIssuesForm(fis.GetAllIssues()))
            {
                result = allIssues.ShowDialog(this);

                if (allIssues.SelectedIssue != null)
                {
                    ClearAllControls();
                    ShowIssueDetails(allIssues.SelectedIssue);
                    
                    WriteMessage($"Issue ID \"{currentIssue.Id}\" selected for editing.", MessageType.Normal);
                }
            }
        }

        // load XML file
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string loadPath = string.Empty;

                using (OpenFileDialog loadFileDialog = new OpenFileDialog())
                {
                    loadFileDialog.Filter = "XML files (*.xml) | *.xml";
                    loadFileDialog.ShowDialog(this);

                    loadPath = loadFileDialog.FileName;

                    if (!string.IsNullOrEmpty(loadPath))
                    {
                        fis.Load(loadPath);

                        ClearAllControls();
                        EnabledSearchOptions();
                        
                        WriteMessage("File loaded successfully from the following location:" + Environment.NewLine + 
                                     $"{loadPath}" + Environment.NewLine + 
                                     "Note: No issue has been selected for editing yet!", MessageType.Success);
                    }
                }
            }
            catch (Exception ex)
            {
                WriteMessage($"Error Loading File: {ex.Message}", MessageType.Error);
            }
        }

        // save to XML file
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string savePath = string.Empty;

                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "XML Files | *.xml";
                    saveFileDialog.ShowDialog(this);

                    savePath = saveFileDialog.FileName;

                    if (!string.IsNullOrEmpty(savePath))
                    {
                        fis.Save(savePath);

                        BTNApplyChanges.Enabled = false;
                        
                        WriteMessage("File saved successfully to the following location:" + Environment.NewLine + 
                                     $"{savePath}", MessageType.Success);
                    }
                }
            }
            catch (Exception ex)
            {
                WriteMessage($"Error Saving File: {ex.Message}", MessageType.Error);
            }
        }

        // close application
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        // search for an issue by its Title
        private void searchTitleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result;

            using (ByTitleForm searchByTitleForm = new ByTitleForm(fis))
            {
                result = searchByTitleForm.ShowDialog(this);

                if (searchByTitleForm.SelectedIssue != null)
                {
                    ClearAllControls();
                    ShowIssueDetails(searchByTitleForm.SelectedIssue);
                    
                    WriteMessage($"Issue ID \"{currentIssue.Id}\" selected for editing.", MessageType.Normal);
                }
            }
        }

        // search for an issue by its Assignee
        private void searchAssigneeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result;

            using (ByAssigneeForm searchByAssigneeForm = new ByAssigneeForm(fis))
            {
                result = searchByAssigneeForm.ShowDialog(this);

                if (searchByAssigneeForm.SelectedIssue != null)
                {
                    ClearAllControls();
                    ShowIssueDetails(searchByAssigneeForm.SelectedIssue);
                    
                    WriteMessage($"Issue ID \"{currentIssue.Id}\" selected for editing.", MessageType.Normal);
                }
            }
        }

        // search for an issue by its Importance
        private void searchImportanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result;

            using (ByImportanceForm searchByImportanceForm = new ByImportanceForm(fis))
            {
                result = searchByImportanceForm.ShowDialog(this);

                if (searchByImportanceForm.SelectedIssue != null)
                {
                    ClearAllControls();
                    ShowIssueDetails(searchByImportanceForm.SelectedIssue);
                    
                    WriteMessage($"Issue ID \"{currentIssue.Id}\" selected for editing.", MessageType.Normal);
                }
            }
        }

        // search for an issue by its Status
        private void searchStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result;

            using (ByStatusFrom searchByStatusForm = new ByStatusFrom(fis))
            {
                result = searchByStatusForm.ShowDialog(this);

                if (searchByStatusForm.SelectedIssue != null)
                {
                    ClearAllControls();
                    ShowIssueDetails(searchByStatusForm.SelectedIssue);
                    
                    WriteMessage($"Issue ID \"{currentIssue.Id}\" selected for editing.", MessageType.Normal);
                }
            }
        }

        // search for an issue by its ID (Guid)
        private void searchIDNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result;

            using (ByIDForm searchByIDForm = new ByIDForm(fis))
            {
                result = searchByIDForm.ShowDialog(this);

                if (searchByIDForm.SelectedIssue != null)
                {
                    ClearAllControls();
                    ShowIssueDetails(searchByIDForm.SelectedIssue);
                    
                    WriteMessage($"Issue ID \"{currentIssue.Id}\" selected for editing.", MessageType.Normal);
                }
            }
        }

        // delete an issue based on its ID (Guid)
        private void deleteCurrentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentIssue != null)
            {
                try
                {
                    fis.Delete(currentIssue.Id);

                    ClearAllControls();
                    currentIssue = null;

                    BTNApplyChanges.Enabled = true;
                    
                    WriteMessage("Issue deleted successfully. Remember to save your changes before quitting.", MessageType.Success);
                }
                catch (Exception ex)
                {
                    WriteMessage($"Failed to delete issue: {ex.Message}" + Environment.NewLine +
                                 "Issue was not deleted.", MessageType.Error);
                }
            }
            else
            {
                WriteMessage("Failed to delete issue: An issue needs to be selected for editing in order to be deleted.", MessageType.Error);
            }
        }

        private void TBIssueTitle_TextChanged(object sender, EventArgs e)
        {
            if (currentIssue != null)
            {
                BTNApplyChanges.Enabled = true;
            }
            else
            {
                BTNApplyChanges.Enabled = false;
            }
        }

        private void TBAssignee_TextChanged(object sender, EventArgs e)
        {
            if (currentIssue != null)
            {
                BTNApplyChanges.Enabled = true;
            }
            else
            {
                BTNApplyChanges.Enabled = false;
            }
        }

        private void TBDescription_TextChanged(object sender, EventArgs e)
        {
            if (currentIssue != null)
            {
                BTNApplyChanges.Enabled = true;
            }
            else
            {
                BTNApplyChanges.Enabled = false;
            }
        }

        private void CBStatus_SelectedValueChanged(object sender, EventArgs e)
        {
            if (currentIssue != null)
            {
                BTNApplyChanges.Enabled = true;
            }
            else
            {
                BTNApplyChanges.Enabled = false;
            }
        }

        private void UDImportance_ValueChanged(object sender, EventArgs e)
        {
            if (currentIssue != null)
            {
                BTNApplyChanges.Enabled = true;
            }
            else
            {
                BTNApplyChanges.Enabled = false;
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Checks the input fields to ensure that required values are not null or empty.
        /// </summary>
        /// <returns>Returns true if all input fields are valid; otherwise returns false.</returns>
        private bool InputIsValid()
        {
            if (!string.IsNullOrEmpty(TBIssueTitle.Text) &&
                !string.IsNullOrEmpty(TBAssignee.Text) &&
                !string.IsNullOrEmpty(TBDescription.Text) &&
                CBStatus.SelectedIndex > -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Clears the values of all textboxes and combo boxes.
        /// </summary>
        private void ClearAllControls()
        {
            TBMessages.Clear();
            TBIssueTitle.Clear();
            TBAssignee.Clear();
            TBDescription.Clear();
            TBIssueID.Clear();
            CBStatus.SelectedIndex = -1;
        }

        /// <summary>
        /// Displays the details of a specified issue and sets it as the current issue being edited.
        /// </summary>
        /// <param name="issue"></param>
        private void ShowIssueDetails(Issue issue)
        {
            try
            {
                TBIssueTitle.Text = issue.Title;
                TBAssignee.Text = issue.Assignee;
                TBDescription.Text = issue.Description;
                TBIssueID.Text = issue.Id.ToString();
                CBStatus.SelectedIndex = (int)issue.Status - 1;

                // keep the "apply changes" option disabled until the user actually makes changes to a selected issue
                BTNApplyChanges.Enabled = false;

                SetCurrentIssue(issue);
            }
            catch (Exception ex)
            {
                WriteMessage($"Error: {ex.Message}", MessageType.Error);
            }
        }

        /// <summary>
        /// Sets a specified issue as the issue currently being edited.
        /// </summary>
        /// <param name="issue"></param>
        private void SetCurrentIssue(Issue issue)
        {
            if (issue != null)
            {
                currentIssue = issue;
                return;
            }
            
            WriteMessage("Error: This issue has no data and cannot be edited.", MessageType.Error);
        }

        /// <summary>
        /// Writes a specified string to a textbox and applies a background color to said textbox, based on the specified message type.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="messageType"></param>
        private void WriteMessage(string message, MessageType messageType)
        {
            Color messageColor;

            switch (messageType)
            {
                case MessageType.Success:
                    messageColor = Color.LightGreen;
                    break;
                case MessageType.Normal:
                    messageColor = Color.White;
                    break;
                case MessageType.Error:
                    messageColor = Color.LightPink;
                    break;
                default:
                    messageColor = Color.White;
                    break;
            }

            TBMessages.BackColor = messageColor;
            TBMessages.Text = message;
        }

        /// <summary>
        /// Enables all search options in the menu tool strip.
        /// </summary>
        private void EnabledSearchOptions()
        {
            titleToolStripMenuItem.Enabled = true;
            assigneeToolStripMenuItem.Enabled = true;
            importanceToolStripMenuItem.Enabled = true;
            statusToolStripMenuItem.Enabled = true;
            iDNumberToolStripMenuItem.Enabled = true;
        }

        /// <summary>
        /// Disables all search options in the menu tool strip.
        /// </summary>
        private void DisableSearchOptions()
        {
            titleToolStripMenuItem.Enabled = false;
            assigneeToolStripMenuItem.Enabled = false;
            importanceToolStripMenuItem.Enabled = false;
            statusToolStripMenuItem.Enabled = false;
            iDNumberToolStripMenuItem.Enabled = false;
        }

        #endregion
        
    }
}