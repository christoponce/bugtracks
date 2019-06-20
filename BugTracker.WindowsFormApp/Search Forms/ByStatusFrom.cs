using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BugTrack.Access;

namespace BugTracker.WindowsFormApp
{
    public partial class ByStatusFrom : Form
    {
        public Issue SelectedIssue;
        private FileIssueService fis;

        public ByStatusFrom(FileIssueService fileIssueService)
        {
            InitializeComponent();

            BTNEditSelection.Enabled = false;

            fis = fileIssueService;
        }

        private void BTNSearch_Click(object sender, EventArgs e)
        {
            try
            {
                List<Issue> results = fis.GetByStatus((Status)Enum.Parse(typeof(Status), CBStatus.SelectedValue.ToString()));

                if (results != null)
                {
                    LBSearchResult.DataSource = results;
                    BTNEditSelection.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTNCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

            Close();
        }

        private void BTNEditSelection_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            SelectedIssue = LBSearchResult.SelectedItem as Issue;

            Close();
        }
    }
}
