using BugTrack.Access;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTracker.WindowsFormApp
{
    public partial class ShowIssuesForm : Form
    {
        private List<Issue> issues;
        public Issue SelectedIssue;

        public ShowIssuesForm(List<Issue> allIssues)
        {
            InitializeComponent();

            issues = allIssues;

            LBAllIssues.DataSource = issues;
        }

        private void btnEditSelectedIssue_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            try
            {
                SelectedIssue = LBAllIssues.SelectedItem as Issue;

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

            Close();
        }
    }
}
