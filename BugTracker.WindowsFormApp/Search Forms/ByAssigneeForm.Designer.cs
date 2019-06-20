namespace BugTracker.WindowsFormApp
{
    partial class ByAssigneeForm
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
            this.BTNEditSelection = new System.Windows.Forms.Button();
            this.LBSearchResult = new System.Windows.Forms.ListBox();
            this.LBLSearchResults = new System.Windows.Forms.Label();
            this.BTNCancel = new System.Windows.Forms.Button();
            this.BTNSearch = new System.Windows.Forms.Button();
            this.LBLEnterAssignee = new System.Windows.Forms.Label();
            this.TBAssignee = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BTNEditSelection
            // 
            this.BTNEditSelection.BackColor = System.Drawing.Color.White;
            this.BTNEditSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNEditSelection.Location = new System.Drawing.Point(12, 228);
            this.BTNEditSelection.Name = "BTNEditSelection";
            this.BTNEditSelection.Size = new System.Drawing.Size(334, 23);
            this.BTNEditSelection.TabIndex = 30;
            this.BTNEditSelection.Text = "Edit Selection";
            this.BTNEditSelection.UseVisualStyleBackColor = false;
            this.BTNEditSelection.Click += new System.EventHandler(this.BTNEditSelection_Click);
            // 
            // LBSearchResult
            // 
            this.LBSearchResult.BackColor = System.Drawing.Color.White;
            this.LBSearchResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBSearchResult.FormattingEnabled = true;
            this.LBSearchResult.Location = new System.Drawing.Point(12, 90);
            this.LBSearchResult.Name = "LBSearchResult";
            this.LBSearchResult.Size = new System.Drawing.Size(334, 132);
            this.LBSearchResult.TabIndex = 29;
            // 
            // LBLSearchResults
            // 
            this.LBLSearchResults.AutoSize = true;
            this.LBLSearchResults.Location = new System.Drawing.Point(9, 74);
            this.LBLSearchResults.Name = "LBLSearchResults";
            this.LBLSearchResults.Size = new System.Drawing.Size(82, 13);
            this.LBLSearchResults.TabIndex = 28;
            this.LBLSearchResults.Text = "Search Results:";
            // 
            // BTNCancel
            // 
            this.BTNCancel.BackColor = System.Drawing.Color.White;
            this.BTNCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNCancel.Location = new System.Drawing.Point(229, 38);
            this.BTNCancel.Name = "BTNCancel";
            this.BTNCancel.Size = new System.Drawing.Size(117, 23);
            this.BTNCancel.TabIndex = 27;
            this.BTNCancel.Text = "Cancel";
            this.BTNCancel.UseVisualStyleBackColor = false;
            this.BTNCancel.Click += new System.EventHandler(this.BTNCancel_Click);
            // 
            // BTNSearch
            // 
            this.BTNSearch.BackColor = System.Drawing.Color.White;
            this.BTNSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNSearch.Location = new System.Drawing.Point(96, 38);
            this.BTNSearch.Name = "BTNSearch";
            this.BTNSearch.Size = new System.Drawing.Size(117, 23);
            this.BTNSearch.TabIndex = 26;
            this.BTNSearch.Text = "Search";
            this.BTNSearch.UseVisualStyleBackColor = false;
            this.BTNSearch.Click += new System.EventHandler(this.BTNSearch_Click);
            // 
            // LBLEnterAssignee
            // 
            this.LBLEnterAssignee.AutoSize = true;
            this.LBLEnterAssignee.Location = new System.Drawing.Point(9, 15);
            this.LBLEnterAssignee.Name = "LBLEnterAssignee";
            this.LBLEnterAssignee.Size = new System.Drawing.Size(81, 13);
            this.LBLEnterAssignee.TabIndex = 25;
            this.LBLEnterAssignee.Text = "Enter Assignee:";
            // 
            // TBAssignee
            // 
            this.TBAssignee.Location = new System.Drawing.Point(96, 12);
            this.TBAssignee.Name = "TBAssignee";
            this.TBAssignee.Size = new System.Drawing.Size(250, 20);
            this.TBAssignee.TabIndex = 31;
            // 
            // ByAssigneeForm
            // 
            this.AcceptButton = this.BTNSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(359, 261);
            this.Controls.Add(this.TBAssignee);
            this.Controls.Add(this.BTNEditSelection);
            this.Controls.Add(this.LBSearchResult);
            this.Controls.Add(this.LBLSearchResults);
            this.Controls.Add(this.BTNCancel);
            this.Controls.Add(this.BTNSearch);
            this.Controls.Add(this.LBLEnterAssignee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ByAssigneeForm";
            this.Text = "Bug Tracks - Search by Assignee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BTNEditSelection;
        private System.Windows.Forms.ListBox LBSearchResult;
        private System.Windows.Forms.Label LBLSearchResults;
        private System.Windows.Forms.Button BTNCancel;
        private System.Windows.Forms.Button BTNSearch;
        private System.Windows.Forms.Label LBLEnterAssignee;
        private System.Windows.Forms.TextBox TBAssignee;
    }
}