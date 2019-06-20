namespace BugTracker.WindowsFormApp
{
    partial class ByStatusFrom
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
            this.LBLEnterStatus = new System.Windows.Forms.Label();
            this.CBStatus = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BTNEditSelection
            // 
            this.BTNEditSelection.BackColor = System.Drawing.Color.White;
            this.BTNEditSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNEditSelection.Location = new System.Drawing.Point(13, 228);
            this.BTNEditSelection.Name = "BTNEditSelection";
            this.BTNEditSelection.Size = new System.Drawing.Size(321, 23);
            this.BTNEditSelection.TabIndex = 23;
            this.BTNEditSelection.Text = "Edit Selection";
            this.BTNEditSelection.UseVisualStyleBackColor = false;
            this.BTNEditSelection.Click += new System.EventHandler(this.BTNEditSelection_Click);
            // 
            // LBSearchResult
            // 
            this.LBSearchResult.BackColor = System.Drawing.Color.White;
            this.LBSearchResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBSearchResult.FormattingEnabled = true;
            this.LBSearchResult.Location = new System.Drawing.Point(13, 90);
            this.LBSearchResult.Name = "LBSearchResult";
            this.LBSearchResult.Size = new System.Drawing.Size(321, 132);
            this.LBSearchResult.TabIndex = 22;
            // 
            // LBLSearchResults
            // 
            this.LBLSearchResults.AutoSize = true;
            this.LBLSearchResults.Location = new System.Drawing.Point(10, 74);
            this.LBLSearchResults.Name = "LBLSearchResults";
            this.LBLSearchResults.Size = new System.Drawing.Size(82, 13);
            this.LBLSearchResults.TabIndex = 21;
            this.LBLSearchResults.Text = "Search Results:";
            // 
            // BTNCancel
            // 
            this.BTNCancel.BackColor = System.Drawing.Color.White;
            this.BTNCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNCancel.Location = new System.Drawing.Point(217, 39);
            this.BTNCancel.Name = "BTNCancel";
            this.BTNCancel.Size = new System.Drawing.Size(117, 23);
            this.BTNCancel.TabIndex = 20;
            this.BTNCancel.Text = "Cancel";
            this.BTNCancel.UseVisualStyleBackColor = false;
            this.BTNCancel.Click += new System.EventHandler(this.BTNCancel_Click);
            // 
            // BTNSearch
            // 
            this.BTNSearch.BackColor = System.Drawing.Color.White;
            this.BTNSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNSearch.Location = new System.Drawing.Point(84, 39);
            this.BTNSearch.Name = "BTNSearch";
            this.BTNSearch.Size = new System.Drawing.Size(117, 23);
            this.BTNSearch.TabIndex = 19;
            this.BTNSearch.Text = "Search";
            this.BTNSearch.UseVisualStyleBackColor = false;
            this.BTNSearch.Click += new System.EventHandler(this.BTNSearch_Click);
            // 
            // LBLEnterStatus
            // 
            this.LBLEnterStatus.AutoSize = true;
            this.LBLEnterStatus.Location = new System.Drawing.Point(10, 15);
            this.LBLEnterStatus.Name = "LBLEnterStatus";
            this.LBLEnterStatus.Size = new System.Drawing.Size(68, 13);
            this.LBLEnterStatus.TabIndex = 18;
            this.LBLEnterStatus.Text = "Enter Status:";
            // 
            // CBStatus
            // 
            this.CBStatus.BackColor = System.Drawing.Color.White;
            this.CBStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBStatus.FormattingEnabled = true;
            this.CBStatus.Items.AddRange(new object[] {
            "Pending",
            "Active",
            "Complete"});
            this.CBStatus.Location = new System.Drawing.Point(84, 12);
            this.CBStatus.Name = "CBStatus";
            this.CBStatus.Size = new System.Drawing.Size(250, 21);
            this.CBStatus.TabIndex = 24;
            // 
            // ByStatusFrom
            // 
            this.AcceptButton = this.BTNSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(344, 261);
            this.Controls.Add(this.CBStatus);
            this.Controls.Add(this.BTNEditSelection);
            this.Controls.Add(this.LBSearchResult);
            this.Controls.Add(this.LBLSearchResults);
            this.Controls.Add(this.BTNCancel);
            this.Controls.Add(this.BTNSearch);
            this.Controls.Add(this.LBLEnterStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ByStatusFrom";
            this.Text = "Bug Tracks - Search by Status";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BTNEditSelection;
        private System.Windows.Forms.ListBox LBSearchResult;
        private System.Windows.Forms.Label LBLSearchResults;
        private System.Windows.Forms.Button BTNCancel;
        private System.Windows.Forms.Button BTNSearch;
        private System.Windows.Forms.Label LBLEnterStatus;
        private System.Windows.Forms.ComboBox CBStatus;
    }
}