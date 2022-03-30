namespace DoIt.WindowsFormsApp
{
    partial class ucDuty
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbTags = new System.Windows.Forms.ListBox();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.tbTagText = new System.Windows.Forms.TextBox();
            this.dtpEnddate = new System.Windows.Forms.DateTimePicker();
            this.cbTagColor = new System.Windows.Forms.ComboBox();
            this.cbAssignee = new System.Windows.Forms.ComboBox();
            this.btnTagSaveUpdate = new System.Windows.Forms.Button();
            this.cbPriority = new System.Windows.Forms.ComboBox();
            this.btnTagDelete = new System.Windows.Forms.Button();
            this.tbText = new System.Windows.Forms.TextBox();
            this.btnSaveDuty = new System.Windows.Forms.Button();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.cbStatusName = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlTopBar.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTags
            // 
            this.lbTags.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbTags.FormattingEnabled = true;
            this.lbTags.HorizontalScrollbar = true;
            this.lbTags.ImeMode = System.Windows.Forms.ImeMode.On;
            this.lbTags.ItemHeight = 21;
            this.lbTags.Location = new System.Drawing.Point(5, 120);
            this.lbTags.Name = "lbTags";
            this.lbTags.Size = new System.Drawing.Size(153, 130);
            this.lbTags.TabIndex = 6;
            this.lbTags.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lbTags_DrawItem);
            this.lbTags.SelectedIndexChanged += new System.EventHandler(this.lbTags_SelectedIndexChanged);
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(2, 97);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(58, 13);
            this.lblEndDate.TabIndex = 5;
            this.lblEndDate.Text = "End Date :";
            // 
            // tbTagText
            // 
            this.tbTagText.Location = new System.Drawing.Point(164, 120);
            this.tbTagText.Name = "tbTagText";
            this.tbTagText.Size = new System.Drawing.Size(86, 20);
            this.tbTagText.TabIndex = 7;
            this.tbTagText.Text = "tagText";
            // 
            // dtpEnddate
            // 
            this.dtpEnddate.Location = new System.Drawing.Point(66, 94);
            this.dtpEnddate.Name = "dtpEnddate";
            this.dtpEnddate.Size = new System.Drawing.Size(184, 20);
            this.dtpEnddate.TabIndex = 3;
            // 
            // cbTagColor
            // 
            this.cbTagColor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTagColor.FormattingEnabled = true;
            this.cbTagColor.Location = new System.Drawing.Point(164, 146);
            this.cbTagColor.Name = "cbTagColor";
            this.cbTagColor.Size = new System.Drawing.Size(86, 21);
            this.cbTagColor.TabIndex = 8;
            this.cbTagColor.Text = "tagColor";
            this.cbTagColor.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbTagColor_DrawItem);
            // 
            // cbAssignee
            // 
            this.cbAssignee.FormattingEnabled = true;
            this.cbAssignee.Items.AddRange(new object[] {
            "Select Assignee"});
            this.cbAssignee.Location = new System.Drawing.Point(129, 67);
            this.cbAssignee.Name = "cbAssignee";
            this.cbAssignee.Size = new System.Drawing.Size(121, 21);
            this.cbAssignee.TabIndex = 2;
            this.cbAssignee.Text = "dutyAssignee";
            // 
            // btnTagSaveUpdate
            // 
            this.btnTagSaveUpdate.Location = new System.Drawing.Point(164, 173);
            this.btnTagSaveUpdate.Name = "btnTagSaveUpdate";
            this.btnTagSaveUpdate.Size = new System.Drawing.Size(86, 23);
            this.btnTagSaveUpdate.TabIndex = 9;
            this.btnTagSaveUpdate.Text = "Save/Update";
            this.btnTagSaveUpdate.UseVisualStyleBackColor = true;
            this.btnTagSaveUpdate.Click += new System.EventHandler(this.btnTagSaveUpdate_Click);
            // 
            // cbPriority
            // 
            this.cbPriority.FormattingEnabled = true;
            this.cbPriority.Items.AddRange(new object[] {
            "Urgent",
            "High",
            "None",
            "Low"});
            this.cbPriority.Location = new System.Drawing.Point(2, 67);
            this.cbPriority.Name = "cbPriority";
            this.cbPriority.Size = new System.Drawing.Size(121, 21);
            this.cbPriority.TabIndex = 1;
            this.cbPriority.Text = "dutyPriorityText";
            // 
            // btnTagDelete
            // 
            this.btnTagDelete.Location = new System.Drawing.Point(164, 202);
            this.btnTagDelete.Name = "btnTagDelete";
            this.btnTagDelete.Size = new System.Drawing.Size(86, 23);
            this.btnTagDelete.TabIndex = 10;
            this.btnTagDelete.Text = "Delete";
            this.btnTagDelete.UseVisualStyleBackColor = true;
            this.btnTagDelete.Click += new System.EventHandler(this.btnTagDelete_Click);
            // 
            // tbText
            // 
            this.tbText.BackColor = System.Drawing.SystemColors.Window;
            this.tbText.Location = new System.Drawing.Point(2, 41);
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(248, 20);
            this.tbText.TabIndex = 0;
            this.tbText.Text = "dutyText";
            // 
            // btnSaveDuty
            // 
            this.btnSaveDuty.Location = new System.Drawing.Point(164, 231);
            this.btnSaveDuty.Name = "btnSaveDuty";
            this.btnSaveDuty.Size = new System.Drawing.Size(86, 23);
            this.btnSaveDuty.TabIndex = 11;
            this.btnSaveDuty.Text = "Save Duty";
            this.btnSaveDuty.UseVisualStyleBackColor = true;
            this.btnSaveDuty.Visible = false;
            this.btnSaveDuty.Click += new System.EventHandler(this.btnSaveDuty_Click);
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTopBar.Controls.Add(this.cbStatusName);
            this.pnlTopBar.Controls.Add(this.label6);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(251, 35);
            this.pnlTopBar.TabIndex = 12;
            // 
            // cbStatusName
            // 
            this.cbStatusName.FormattingEnabled = true;
            this.cbStatusName.Location = new System.Drawing.Point(83, 6);
            this.cbStatusName.Name = "cbStatusName";
            this.cbStatusName.Size = new System.Drawing.Size(165, 21);
            this.cbStatusName.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Status Name :";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlTopBar);
            this.pnlMain.Controls.Add(this.btnSaveDuty);
            this.pnlMain.Controls.Add(this.tbText);
            this.pnlMain.Controls.Add(this.btnTagDelete);
            this.pnlMain.Controls.Add(this.cbPriority);
            this.pnlMain.Controls.Add(this.btnTagSaveUpdate);
            this.pnlMain.Controls.Add(this.cbAssignee);
            this.pnlMain.Controls.Add(this.cbTagColor);
            this.pnlMain.Controls.Add(this.dtpEnddate);
            this.pnlMain.Controls.Add(this.tbTagText);
            this.pnlMain.Controls.Add(this.lblEndDate);
            this.pnlMain.Controls.Add(this.lbTags);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(251, 255);
            this.pnlMain.TabIndex = 11;
            // 
            // ucDuty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.pnlMain);
            this.Margin = new System.Windows.Forms.Padding(3, 3, 21, 3);
            this.MaximumSize = new System.Drawing.Size(255, 259);
            this.MinimumSize = new System.Drawing.Size(255, 259);
            this.Name = "ucDuty";
            this.Size = new System.Drawing.Size(251, 255);
            this.Load += new System.EventHandler(this.ucDuty_Load);
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbTags;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.TextBox tbTagText;
        private System.Windows.Forms.DateTimePicker dtpEnddate;
        private System.Windows.Forms.ComboBox cbTagColor;
        private System.Windows.Forms.ComboBox cbAssignee;
        private System.Windows.Forms.Button btnTagSaveUpdate;
        private System.Windows.Forms.ComboBox cbPriority;
        private System.Windows.Forms.Button btnTagDelete;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.Button btnSaveDuty;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.ComboBox cbStatusName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlMain;
    }
}
