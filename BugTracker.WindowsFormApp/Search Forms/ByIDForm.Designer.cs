namespace BugTracker.WindowsFormApp
{
    partial class ByIDForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LBLEnterIssueID = new System.Windows.Forms.Label();
            this.TBIssueID = new System.Windows.Forms.TextBox();
            this.LBSearchResult = new System.Windows.Forms.ListBox();
            this.LBLSearchResult = new System.Windows.Forms.Label();
            this.BTNSearch = new System.Windows.Forms.Button();
            this.BTNCancel = new System.Windows.Forms.Button();
            this.BTNEditSelection = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBLEnterIssueID
            // 
            this.LBLEnterIssueID.AutoSize = true;
            this.LBLEnterIssueID.BackColor = System.Drawing.Color.White;
            this.LBLEnterIssueID.Location = new System.Drawing.Point(13, 13);
            this.LBLEnterIssueID.Name = "LBLEnterIssueID";
            this.LBLEnterIssueID.Size = new System.Drawing.Size(77, 13);
            this.LBLEnterIssueID.TabIndex = 0;
            this.LBLEnterIssueID.Text = "Enter Issue ID:";
            // 
            // TBIssueID
            // 
            this.TBIssueID.BackColor = System.Drawing.Color.White;
            this.TBIssueID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBIssueID.Location = new System.Drawing.Point(97, 13);
            this.TBIssueID.Name = "TBIssueID";
            this.TBIssueID.Size = new System.Drawing.Size(250, 20);
            this.TBIssueID.TabIndex = 1;
            // 
            // LBSearchResult
            // 
            this.LBSearchResult.BackColor = System.Drawing.Color.White;
            this.LBSearchResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBSearchResult.FormattingEnabled = true;
            this.LBSearchResult.Location = new System.Drawing.Point(16, 95);
            this.LBSearchResult.Name = "LBSearchResult";
            this.LBSearchResult.Size = new System.Drawing.Size(331, 41);
            this.LBSearchResult.TabIndex = 2;
            // 
            // LBLSearchResult
            // 
            this.LBLSearchResult.AutoSize = true;
            this.LBLSearchResult.BackColor = System.Drawing.Color.White;
            this.LBLSearchResult.Location = new System.Drawing.Point(13, 79);
            this.LBLSearchResult.Name = "LBLSearchResult";
            this.LBLSearchResult.Size = new System.Drawing.Size(77, 13);
            this.LBLSearchResult.TabIndex = 3;
            this.LBLSearchResult.Text = "Search Result:";
            // 
            // BTNSearch
            // 
            this.BTNSearch.BackColor = System.Drawing.Color.White;
            this.BTNSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNSearch.Location = new System.Drawing.Point(97, 40);
            this.BTNSearch.Name = "BTNSearch";
            this.BTNSearch.Size = new System.Drawing.Size(117, 23);
            this.BTNSearch.TabIndex = 4;
            this.BTNSearch.Text = "Search";
            this.BTNSearch.UseVisualStyleBackColor = false;
            this.BTNSearch.Click += new System.EventHandler(this.BTNSearch_Click);
            // 
            // BTNCancel
            // 
            this.BTNCancel.BackColor = System.Drawing.Color.White;
            this.BTNCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNCancel.Location = new System.Drawing.Point(230, 40);
            this.BTNCancel.Name = "BTNCancel";
            this.BTNCancel.Size = new System.Drawing.Size(117, 23);
            this.BTNCancel.TabIndex = 5;
            this.BTNCancel.Text = "Cancel";
            this.BTNCancel.UseVisualStyleBackColor = false;
            this.BTNCancel.Click += new System.EventHandler(this.BTNCancel_Click);
            // 
            // BTNEditSelection
            // 
            this.BTNEditSelection.BackColor = System.Drawing.Color.White;
            this.BTNEditSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNEditSelection.Location = new System.Drawing.Point(16, 144);
            this.BTNEditSelection.Name = "BTNEditSelection";
            this.BTNEditSelection.Size = new System.Drawing.Size(331, 23);
            this.BTNEditSelection.TabIndex = 6;
            this.BTNEditSelection.Text = "Edit Selection";
            this.BTNEditSelection.UseVisualStyleBackColor = false;
            this.BTNEditSelection.Click += new System.EventHandler(this.BTNEditSelection_Click);
            // 
            // ByIDForm
            // 
            this.AcceptButton = this.BTNSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(364, 181);
            this.Controls.Add(this.BTNEditSelection);
            this.Controls.Add(this.BTNCancel);
            this.Controls.Add(this.BTNSearch);
            this.Controls.Add(this.LBLSearchResult);
            this.Controls.Add(this.LBSearchResult);
            this.Controls.Add(this.TBIssueID);
            this.Controls.Add(this.LBLEnterIssueID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ByIDForm";
            this.Text = "Bug Tracks - Search by ID";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLEnterIssueID;
        private System.Windows.Forms.TextBox TBIssueID;
        private System.Windows.Forms.ListBox LBSearchResult;
        private System.Windows.Forms.Label LBLSearchResult;
        private System.Windows.Forms.Button BTNSearch;
        private System.Windows.Forms.Button BTNCancel;
        private System.Windows.Forms.Button BTNEditSelection;
    }
}