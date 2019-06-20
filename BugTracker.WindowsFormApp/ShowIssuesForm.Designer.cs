namespace BugTracker.WindowsFormApp
{
    partial class ShowIssuesForm
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
            this.LBLAllIssues = new System.Windows.Forms.Label();
            this.btnEditSelectedIssue = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.LBAllIssues = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // LBLAllIssues
            // 
            this.LBLAllIssues.AutoSize = true;
            this.LBLAllIssues.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBLAllIssues.Location = new System.Drawing.Point(13, 14);
            this.LBLAllIssues.Name = "LBLAllIssues";
            this.LBLAllIssues.Size = new System.Drawing.Size(57, 14);
            this.LBLAllIssues.TabIndex = 0;
            this.LBLAllIssues.Text = "All Issues:";
            // 
            // btnEditSelectedIssue
            // 
            this.btnEditSelectedIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditSelectedIssue.Location = new System.Drawing.Point(16, 232);
            this.btnEditSelectedIssue.Name = "btnEditSelectedIssue";
            this.btnEditSelectedIssue.Size = new System.Drawing.Size(150, 23);
            this.btnEditSelectedIssue.TabIndex = 2;
            this.btnEditSelectedIssue.Text = "Edit Selected Issue";
            this.btnEditSelectedIssue.UseVisualStyleBackColor = true;
            this.btnEditSelectedIssue.Click += new System.EventHandler(this.btnEditSelectedIssue_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(223, 231);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Close Window";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // LBAllIssues
            // 
            this.LBAllIssues.BackColor = System.Drawing.Color.White;
            this.LBAllIssues.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBAllIssues.FormattingEnabled = true;
            this.LBAllIssues.ItemHeight = 14;
            this.LBAllIssues.Location = new System.Drawing.Point(16, 32);
            this.LBAllIssues.Name = "LBAllIssues";
            this.LBAllIssues.Size = new System.Drawing.Size(357, 184);
            this.LBAllIssues.TabIndex = 4;
            // 
            // ShowIssuesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(389, 266);
            this.Controls.Add(this.LBAllIssues);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnEditSelectedIssue);
            this.Controls.Add(this.LBLAllIssues);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ShowIssuesForm";
            this.Text = "Bug Tracks - All Issues";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLAllIssues;
        private System.Windows.Forms.Button btnEditSelectedIssue;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox LBAllIssues;
    }
}