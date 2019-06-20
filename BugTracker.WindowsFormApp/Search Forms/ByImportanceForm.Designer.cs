namespace BugTracker.WindowsFormApp
{
    partial class ByImportanceForm
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
            this.LBLEnterImportance = new System.Windows.Forms.Label();
            this.UDImportance = new System.Windows.Forms.NumericUpDown();
            this.BTNSearch = new System.Windows.Forms.Button();
            this.BTNCancel = new System.Windows.Forms.Button();
            this.LBLSearchResults = new System.Windows.Forms.Label();
            this.LBSearchResult = new System.Windows.Forms.ListBox();
            this.BTNEditSelection = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UDImportance)).BeginInit();
            this.SuspendLayout();
            // 
            // LBLEnterImportance
            // 
            this.LBLEnterImportance.AutoSize = true;
            this.LBLEnterImportance.Location = new System.Drawing.Point(12, 14);
            this.LBLEnterImportance.Name = "LBLEnterImportance";
            this.LBLEnterImportance.Size = new System.Drawing.Size(91, 13);
            this.LBLEnterImportance.TabIndex = 0;
            this.LBLEnterImportance.Text = "Enter Importance:";
            // 
            // UDImportance
            // 
            this.UDImportance.BackColor = System.Drawing.Color.White;
            this.UDImportance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UDImportance.Location = new System.Drawing.Point(109, 12);
            this.UDImportance.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.UDImportance.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UDImportance.Name = "UDImportance";
            this.UDImportance.Size = new System.Drawing.Size(250, 20);
            this.UDImportance.TabIndex = 1;
            this.UDImportance.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // BTNSearch
            // 
            this.BTNSearch.BackColor = System.Drawing.Color.White;
            this.BTNSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNSearch.Location = new System.Drawing.Point(109, 38);
            this.BTNSearch.Name = "BTNSearch";
            this.BTNSearch.Size = new System.Drawing.Size(117, 23);
            this.BTNSearch.TabIndex = 5;
            this.BTNSearch.Text = "Search";
            this.BTNSearch.UseVisualStyleBackColor = false;
            this.BTNSearch.Click += new System.EventHandler(this.BTNSearch_Click);
            // 
            // BTNCancel
            // 
            this.BTNCancel.BackColor = System.Drawing.Color.White;
            this.BTNCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNCancel.Location = new System.Drawing.Point(242, 38);
            this.BTNCancel.Name = "BTNCancel";
            this.BTNCancel.Size = new System.Drawing.Size(117, 23);
            this.BTNCancel.TabIndex = 6;
            this.BTNCancel.Text = "Cancel";
            this.BTNCancel.UseVisualStyleBackColor = false;
            this.BTNCancel.Click += new System.EventHandler(this.BTNCancel_Click);
            // 
            // LBLSearchResults
            // 
            this.LBLSearchResults.AutoSize = true;
            this.LBLSearchResults.Location = new System.Drawing.Point(15, 77);
            this.LBLSearchResults.Name = "LBLSearchResults";
            this.LBLSearchResults.Size = new System.Drawing.Size(82, 13);
            this.LBLSearchResults.TabIndex = 7;
            this.LBLSearchResults.Text = "Search Results:";
            // 
            // LBSearchResult
            // 
            this.LBSearchResult.BackColor = System.Drawing.Color.White;
            this.LBSearchResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBSearchResult.FormattingEnabled = true;
            this.LBSearchResult.Location = new System.Drawing.Point(18, 93);
            this.LBSearchResult.Name = "LBSearchResult";
            this.LBSearchResult.Size = new System.Drawing.Size(341, 132);
            this.LBSearchResult.TabIndex = 8;
            // 
            // BTNEditSelection
            // 
            this.BTNEditSelection.BackColor = System.Drawing.Color.White;
            this.BTNEditSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNEditSelection.Location = new System.Drawing.Point(18, 231);
            this.BTNEditSelection.Name = "BTNEditSelection";
            this.BTNEditSelection.Size = new System.Drawing.Size(341, 23);
            this.BTNEditSelection.TabIndex = 9;
            this.BTNEditSelection.Text = "Edit Selection";
            this.BTNEditSelection.UseVisualStyleBackColor = false;
            this.BTNEditSelection.Click += new System.EventHandler(this.BTNEditSelection_Click);
            // 
            // ByImportanceForm
            // 
            this.AcceptButton = this.BTNSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(369, 266);
            this.Controls.Add(this.BTNEditSelection);
            this.Controls.Add(this.LBSearchResult);
            this.Controls.Add(this.LBLSearchResults);
            this.Controls.Add(this.BTNCancel);
            this.Controls.Add(this.BTNSearch);
            this.Controls.Add(this.UDImportance);
            this.Controls.Add(this.LBLEnterImportance);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ByImportanceForm";
            this.Text = "Bug Tracks - Search by Importance";
            ((System.ComponentModel.ISupportInitialize)(this.UDImportance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLEnterImportance;
        private System.Windows.Forms.NumericUpDown UDImportance;
        private System.Windows.Forms.Button BTNSearch;
        private System.Windows.Forms.Button BTNCancel;
        private System.Windows.Forms.Label LBLSearchResults;
        private System.Windows.Forms.ListBox LBSearchResult;
        private System.Windows.Forms.Button BTNEditSelection;
    }
}