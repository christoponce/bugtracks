namespace BugTracker.WindowsFormApp
{
    partial class ByTitleForm
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
            this.LBLEnterTitle = new System.Windows.Forms.Label();
            this.TBTitle = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BTNEditSelection
            // 
            this.BTNEditSelection.BackColor = System.Drawing.Color.White;
            this.BTNEditSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNEditSelection.Location = new System.Drawing.Point(17, 231);
            this.BTNEditSelection.Name = "BTNEditSelection";
            this.BTNEditSelection.Size = new System.Drawing.Size(308, 23);
            this.BTNEditSelection.TabIndex = 16;
            this.BTNEditSelection.Text = "Edit Selection";
            this.BTNEditSelection.UseVisualStyleBackColor = false;
            this.BTNEditSelection.Click += new System.EventHandler(this.BTNEditSelection_Click);
            // 
            // LBSearchResult
            // 
            this.LBSearchResult.BackColor = System.Drawing.Color.White;
            this.LBSearchResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBSearchResult.FormattingEnabled = true;
            this.LBSearchResult.Location = new System.Drawing.Point(17, 93);
            this.LBSearchResult.Name = "LBSearchResult";
            this.LBSearchResult.Size = new System.Drawing.Size(308, 132);
            this.LBSearchResult.TabIndex = 15;
            // 
            // LBLSearchResults
            // 
            this.LBLSearchResults.AutoSize = true;
            this.LBLSearchResults.Location = new System.Drawing.Point(14, 77);
            this.LBLSearchResults.Name = "LBLSearchResults";
            this.LBLSearchResults.Size = new System.Drawing.Size(82, 13);
            this.LBLSearchResults.TabIndex = 14;
            this.LBLSearchResults.Text = "Search Results:";
            // 
            // BTNCancel
            // 
            this.BTNCancel.BackColor = System.Drawing.Color.White;
            this.BTNCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNCancel.Location = new System.Drawing.Point(208, 42);
            this.BTNCancel.Name = "BTNCancel";
            this.BTNCancel.Size = new System.Drawing.Size(117, 23);
            this.BTNCancel.TabIndex = 13;
            this.BTNCancel.Text = "Cancel";
            this.BTNCancel.UseVisualStyleBackColor = false;
            this.BTNCancel.Click += new System.EventHandler(this.BTNCancel_Click);
            // 
            // BTNSearch
            // 
            this.BTNSearch.BackColor = System.Drawing.Color.White;
            this.BTNSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNSearch.Location = new System.Drawing.Point(78, 42);
            this.BTNSearch.Name = "BTNSearch";
            this.BTNSearch.Size = new System.Drawing.Size(117, 23);
            this.BTNSearch.TabIndex = 12;
            this.BTNSearch.Text = "Search";
            this.BTNSearch.UseVisualStyleBackColor = false;
            this.BTNSearch.Click += new System.EventHandler(this.BTNSearch_Click);
            // 
            // LBLEnterTitle
            // 
            this.LBLEnterTitle.AutoSize = true;
            this.LBLEnterTitle.Location = new System.Drawing.Point(14, 18);
            this.LBLEnterTitle.Name = "LBLEnterTitle";
            this.LBLEnterTitle.Size = new System.Drawing.Size(58, 13);
            this.LBLEnterTitle.TabIndex = 10;
            this.LBLEnterTitle.Text = "Enter Title:";
            // 
            // TBTitle
            // 
            this.TBTitle.BackColor = System.Drawing.Color.White;
            this.TBTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBTitle.Location = new System.Drawing.Point(78, 15);
            this.TBTitle.Name = "TBTitle";
            this.TBTitle.Size = new System.Drawing.Size(247, 20);
            this.TBTitle.TabIndex = 17;
            // 
            // ByTitleForm
            // 
            this.AcceptButton = this.BTNSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(339, 266);
            this.Controls.Add(this.TBTitle);
            this.Controls.Add(this.BTNEditSelection);
            this.Controls.Add(this.LBSearchResult);
            this.Controls.Add(this.LBLSearchResults);
            this.Controls.Add(this.BTNCancel);
            this.Controls.Add(this.BTNSearch);
            this.Controls.Add(this.LBLEnterTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ByTitleForm";
            this.Text = "Bug Tracks - Search by Title";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNEditSelection;
        private System.Windows.Forms.ListBox LBSearchResult;
        private System.Windows.Forms.Label LBLSearchResults;
        private System.Windows.Forms.Button BTNCancel;
        private System.Windows.Forms.Button BTNSearch;
        private System.Windows.Forms.Label LBLEnterTitle;
        private System.Windows.Forms.TextBox TBTitle;
    }
}