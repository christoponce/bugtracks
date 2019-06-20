using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BugTrack.Access;

namespace BugTracker.WindowsFormApp
{
    public partial class ByIDForm : Form
    {
        private FileIssueService fis;
        public Issue SelectedIssue;

        public ByIDForm(FileIssueService fileIssueService)
        {
            InitializeComponent();

            BTNEditSelection.Enabled = false;

            fis = fileIssueService;
        }

        private void BTNSearch_Click(object sender, EventArgs e)
        {
            try
            {
                List<Issue> result = new List<Issue>();
                result.Add(fis.GetByID(Guid.Parse(TBIssueID.Text)));

                if (result != null)
                {
                    LBSearchResult.DataSource = result;

                    BTNEditSelection.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTNEditSelection_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            SelectedIssue = LBSearchResult.SelectedItem as Issue;

            Close();
        }

        private void BTNCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

            Close();
        }
    }
}
