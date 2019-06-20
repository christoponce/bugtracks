namespace BugTracker.WindowsFormApp
{
    partial class MainForm
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
            this.LBLIssueTitle = new System.Windows.Forms.Label();
            this.LBLAssignee = new System.Windows.Forms.Label();
            this.LBLDescription = new System.Windows.Forms.Label();
            this.LBLImportance = new System.Windows.Forms.Label();
            this.TBDescription = new System.Windows.Forms.TextBox();
            this.TBAssignee = new System.Windows.Forms.TextBox();
            this.TBIssueTitle = new System.Windows.Forms.TextBox();
            this.BTNCreateIssue = new System.Windows.Forms.Button();
            this.BTNShowAllIssues = new System.Windows.Forms.Button();
            this.UDImportance = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findIssueByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.titleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assigneeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iDNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCurrentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LBLMessages = new System.Windows.Forms.Label();
            this.TBMessages = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CBStatus = new System.Windows.Forms.ComboBox();
            this.TBIssueID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BTNApplyChanges = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UDImportance)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBLIssueTitle
            // 
            this.LBLIssueTitle.AutoSize = true;
            this.LBLIssueTitle.BackColor = System.Drawing.Color.White;
            this.LBLIssueTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBLIssueTitle.Location = new System.Drawing.Point(10, 133);
            this.LBLIssueTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBLIssueTitle.Name = "LBLIssueTitle";
            this.LBLIssueTitle.Size = new System.Drawing.Size(58, 14);
            this.LBLIssueTitle.TabIndex = 0;
            this.LBLIssueTitle.Text = "Issue Title:";
            // 
            // LBLAssignee
            // 
            this.LBLAssignee.AutoSize = true;
            this.LBLAssignee.BackColor = System.Drawing.Color.White;
            this.LBLAssignee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBLAssignee.Location = new System.Drawing.Point(10, 159);
            this.LBLAssignee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBLAssignee.Name = "LBLAssignee";
            this.LBLAssignee.Size = new System.Drawing.Size(56, 14);
            this.LBLAssignee.TabIndex = 1;
            this.LBLAssignee.Text = "Assignee:";
            // 
            // LBLDescription
            // 
            this.LBLDescription.AutoSize = true;
            this.LBLDescription.BackColor = System.Drawing.Color.White;
            this.LBLDescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBLDescription.Location = new System.Drawing.Point(11, 241);
            this.LBLDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBLDescription.Name = "LBLDescription";
            this.LBLDescription.Size = new System.Drawing.Size(64, 14);
            this.LBLDescription.TabIndex = 2;
            this.LBLDescription.Text = "Description:";
            // 
            // LBLImportance
            // 
            this.LBLImportance.AutoSize = true;
            this.LBLImportance.BackColor = System.Drawing.Color.White;
            this.LBLImportance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBLImportance.Location = new System.Drawing.Point(11, 185);
            this.LBLImportance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBLImportance.Name = "LBLImportance";
            this.LBLImportance.Size = new System.Drawing.Size(63, 14);
            this.LBLImportance.TabIndex = 3;
            this.LBLImportance.Text = "Importance:";
            // 
            // TBDescription
            // 
            this.TBDescription.BackColor = System.Drawing.Color.White;
            this.TBDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBDescription.Location = new System.Drawing.Point(81, 239);
            this.TBDescription.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TBDescription.Multiline = true;
            this.TBDescription.Name = "TBDescription";
            this.TBDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TBDescription.Size = new System.Drawing.Size(400, 80);
            this.TBDescription.TabIndex = 5;
            this.TBDescription.Text = "Issue Description";
            this.TBDescription.TextChanged += new System.EventHandler(this.TBDescription_TextChanged);
            // 
            // TBAssignee
            // 
            this.TBAssignee.BackColor = System.Drawing.Color.White;
            this.TBAssignee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBAssignee.Location = new System.Drawing.Point(81, 157);
            this.TBAssignee.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TBAssignee.Name = "TBAssignee";
            this.TBAssignee.Size = new System.Drawing.Size(400, 20);
            this.TBAssignee.TabIndex = 6;
            this.TBAssignee.Text = "Person Assigned";
            this.TBAssignee.TextChanged += new System.EventHandler(this.TBAssignee_TextChanged);
            // 
            // TBIssueTitle
            // 
            this.TBIssueTitle.BackColor = System.Drawing.Color.White;
            this.TBIssueTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBIssueTitle.Location = new System.Drawing.Point(81, 131);
            this.TBIssueTitle.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TBIssueTitle.Name = "TBIssueTitle";
            this.TBIssueTitle.Size = new System.Drawing.Size(400, 20);
            this.TBIssueTitle.TabIndex = 7;
            this.TBIssueTitle.Text = "Issue Title";
            this.TBIssueTitle.TextChanged += new System.EventHandler(this.TBIssueTitle_TextChanged);
            // 
            // BTNCreateIssue
            // 
            this.BTNCreateIssue.BackColor = System.Drawing.Color.White;
            this.BTNCreateIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNCreateIssue.Location = new System.Drawing.Point(81, 325);
            this.BTNCreateIssue.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BTNCreateIssue.Name = "BTNCreateIssue";
            this.BTNCreateIssue.Size = new System.Drawing.Size(120, 25);
            this.BTNCreateIssue.TabIndex = 8;
            this.BTNCreateIssue.Text = "Create Issue";
            this.BTNCreateIssue.UseVisualStyleBackColor = false;
            this.BTNCreateIssue.Click += new System.EventHandler(this.createIssueButton_Click);
            // 
            // BTNShowAllIssues
            // 
            this.BTNShowAllIssues.BackColor = System.Drawing.Color.White;
            this.BTNShowAllIssues.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNShowAllIssues.Location = new System.Drawing.Point(361, 325);
            this.BTNShowAllIssues.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BTNShowAllIssues.Name = "BTNShowAllIssues";
            this.BTNShowAllIssues.Size = new System.Drawing.Size(120, 25);
            this.BTNShowAllIssues.TabIndex = 9;
            this.BTNShowAllIssues.Text = "Show All Issues";
            this.BTNShowAllIssues.UseVisualStyleBackColor = false;
            this.BTNShowAllIssues.Click += new System.EventHandler(this.showIssuesButton_Click);
            // 
            // UDImportance
            // 
            this.UDImportance.BackColor = System.Drawing.Color.White;
            this.UDImportance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UDImportance.Location = new System.Drawing.Point(81, 183);
            this.UDImportance.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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
            this.UDImportance.Size = new System.Drawing.Size(400, 20);
            this.UDImportance.TabIndex = 10;
            this.UDImportance.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UDImportance.ValueChanged += new System.EventHandler(this.UDImportance_ValueChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.findToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(494, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open XML File...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save XML File...";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.findToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findIssueByToolStripMenuItem});
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.findToolStripMenuItem.Text = "Search";
            // 
            // findIssueByToolStripMenuItem
            // 
            this.findIssueByToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.findIssueByToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.titleToolStripMenuItem,
            this.assigneeToolStripMenuItem,
            this.importanceToolStripMenuItem,
            this.statusToolStripMenuItem,
            this.iDNumberToolStripMenuItem});
            this.findIssueByToolStripMenuItem.Name = "findIssueByToolStripMenuItem";
            this.findIssueByToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.findIssueByToolStripMenuItem.Text = "Find Issue By";
            // 
            // titleToolStripMenuItem
            // 
            this.titleToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.titleToolStripMenuItem.Name = "titleToolStripMenuItem";
            this.titleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.titleToolStripMenuItem.Text = "Title";
            this.titleToolStripMenuItem.Click += new System.EventHandler(this.searchTitleToolStripMenuItem_Click);
            // 
            // assigneeToolStripMenuItem
            // 
            this.assigneeToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.assigneeToolStripMenuItem.Name = "assigneeToolStripMenuItem";
            this.assigneeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.assigneeToolStripMenuItem.Text = "Assignee";
            this.assigneeToolStripMenuItem.Click += new System.EventHandler(this.searchAssigneeToolStripMenuItem_Click);
            // 
            // importanceToolStripMenuItem
            // 
            this.importanceToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.importanceToolStripMenuItem.Name = "importanceToolStripMenuItem";
            this.importanceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.importanceToolStripMenuItem.Text = "Importance";
            this.importanceToolStripMenuItem.Click += new System.EventHandler(this.searchImportanceToolStripMenuItem_Click);
            // 
            // statusToolStripMenuItem
            // 
            this.statusToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.statusToolStripMenuItem.Name = "statusToolStripMenuItem";
            this.statusToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.statusToolStripMenuItem.Text = "Status";
            this.statusToolStripMenuItem.Click += new System.EventHandler(this.searchStatusToolStripMenuItem_Click);
            // 
            // iDNumberToolStripMenuItem
            // 
            this.iDNumberToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.iDNumberToolStripMenuItem.Name = "iDNumberToolStripMenuItem";
            this.iDNumberToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.iDNumberToolStripMenuItem.Text = "ID Number";
            this.iDNumberToolStripMenuItem.Click += new System.EventHandler(this.searchIDNumberToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteCurrentToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // deleteCurrentToolStripMenuItem
            // 
            this.deleteCurrentToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.deleteCurrentToolStripMenuItem.Name = "deleteCurrentToolStripMenuItem";
            this.deleteCurrentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteCurrentToolStripMenuItem.Text = "Delete Current";
            this.deleteCurrentToolStripMenuItem.Click += new System.EventHandler(this.deleteCurrentToolStripMenuItem_Click);
            // 
            // LBLMessages
            // 
            this.LBLMessages.AutoSize = true;
            this.LBLMessages.BackColor = System.Drawing.Color.White;
            this.LBLMessages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBLMessages.Location = new System.Drawing.Point(10, 36);
            this.LBLMessages.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBLMessages.Name = "LBLMessages";
            this.LBLMessages.Size = new System.Drawing.Size(60, 14);
            this.LBLMessages.TabIndex = 23;
            this.LBLMessages.Text = "Messages:";
            // 
            // TBMessages
            // 
            this.TBMessages.BackColor = System.Drawing.Color.White;
            this.TBMessages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBMessages.Location = new System.Drawing.Point(81, 34);
            this.TBMessages.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TBMessages.Multiline = true;
            this.TBMessages.Name = "TBMessages";
            this.TBMessages.ReadOnly = true;
            this.TBMessages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TBMessages.Size = new System.Drawing.Size(400, 50);
            this.TBMessages.TabIndex = 24;
            this.TBMessages.Text = "Standing by...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(11, 212);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 14);
            this.label1.TabIndex = 25;
            this.label1.Text = "Status:";
            // 
            // CBStatus
            // 
            this.CBStatus.FormattingEnabled = true;
            this.CBStatus.Location = new System.Drawing.Point(81, 209);
            this.CBStatus.Name = "CBStatus";
            this.CBStatus.Size = new System.Drawing.Size(400, 22);
            this.CBStatus.TabIndex = 26;
            this.CBStatus.SelectedValueChanged += new System.EventHandler(this.CBStatus_SelectedValueChanged);
            // 
            // TBIssueID
            // 
            this.TBIssueID.BackColor = System.Drawing.Color.White;
            this.TBIssueID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBIssueID.Location = new System.Drawing.Point(81, 105);
            this.TBIssueID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TBIssueID.Name = "TBIssueID";
            this.TBIssueID.ReadOnly = true;
            this.TBIssueID.Size = new System.Drawing.Size(400, 20);
            this.TBIssueID.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(10, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 14);
            this.label2.TabIndex = 27;
            this.label2.Text = "Issue ID:";
            // 
            // BTNApplyChanges
            // 
            this.BTNApplyChanges.BackColor = System.Drawing.Color.White;
            this.BTNApplyChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNApplyChanges.Location = new System.Drawing.Point(222, 325);
            this.BTNApplyChanges.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BTNApplyChanges.Name = "BTNApplyChanges";
            this.BTNApplyChanges.Size = new System.Drawing.Size(120, 25);
            this.BTNApplyChanges.TabIndex = 29;
            this.BTNApplyChanges.Text = "Apply Changes";
            this.BTNApplyChanges.UseVisualStyleBackColor = false;
            this.BTNApplyChanges.Click += new System.EventHandler(this.BTNApplyChanges_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(494, 362);
            this.Controls.Add(this.BTNApplyChanges);
            this.Controls.Add(this.TBIssueID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CBStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBMessages);
            this.Controls.Add(this.LBLMessages);
            this.Controls.Add(this.UDImportance);
            this.Controls.Add(this.BTNShowAllIssues);
            this.Controls.Add(this.BTNCreateIssue);
            this.Controls.Add(this.TBIssueTitle);
            this.Controls.Add(this.TBAssignee);
            this.Controls.Add(this.TBDescription);
            this.Controls.Add(this.LBLImportance);
            this.Controls.Add(this.LBLDescription);
            this.Controls.Add(this.LBLAssignee);
            this.Controls.Add(this.LBLIssueTitle);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "MainForm";
            this.Text = "Bug Tracks";
            ((System.ComponentModel.ISupportInitialize)(this.UDImportance)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLIssueTitle;
        private System.Windows.Forms.Label LBLAssignee;
        private System.Windows.Forms.Label LBLDescription;
        private System.Windows.Forms.Label LBLImportance;
        private System.Windows.Forms.TextBox TBDescription;
        private System.Windows.Forms.TextBox TBAssignee;
        private System.Windows.Forms.TextBox TBIssueTitle;
        private System.Windows.Forms.Button BTNCreateIssue;
        private System.Windows.Forms.Button BTNShowAllIssues;
        private System.Windows.Forms.NumericUpDown UDImportance;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findIssueByToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem titleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assigneeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iDNumberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.Label LBLMessages;
        private System.Windows.Forms.TextBox TBMessages;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBStatus;
        private System.Windows.Forms.ToolStripMenuItem deleteCurrentToolStripMenuItem;
        private System.Windows.Forms.TextBox TBIssueID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTNApplyChanges;
    }
}

