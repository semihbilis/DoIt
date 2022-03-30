namespace DoIt.WindowsFormsApp
{
    partial class ucStatus
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
            this.flpDuties = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pbStatusIcon = new System.Windows.Forms.PictureBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblUpdateDate = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCreateDate = new System.Windows.Forms.Label();
            this.pnlTopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatusIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // flpDuties
            // 
            this.flpDuties.AutoScroll = true;
            this.flpDuties.AutoScrollMinSize = new System.Drawing.Size(53, 0);
            this.flpDuties.AutoSize = true;
            this.flpDuties.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpDuties.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flpDuties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpDuties.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpDuties.Location = new System.Drawing.Point(0, 131);
            this.flpDuties.Name = "flpDuties";
            this.flpDuties.Size = new System.Drawing.Size(287, 306);
            this.flpDuties.TabIndex = 3;
            this.flpDuties.WrapContents = false;
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.Controls.Add(this.btnDelete);
            this.pnlTopBar.Controls.Add(this.pbStatusIcon);
            this.pnlTopBar.Controls.Add(this.btnUpdate);
            this.pnlTopBar.Controls.Add(this.label3);
            this.pnlTopBar.Controls.Add(this.label4);
            this.pnlTopBar.Controls.Add(this.tbName);
            this.pnlTopBar.Controls.Add(this.lblUpdateDate);
            this.pnlTopBar.Controls.Add(this.dtpEndDate);
            this.pnlTopBar.Controls.Add(this.label5);
            this.pnlTopBar.Controls.Add(this.label6);
            this.pnlTopBar.Controls.Add(this.lblCreateDate);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.MaximumSize = new System.Drawing.Size(287, 131);
            this.pnlTopBar.MinimumSize = new System.Drawing.Size(287, 131);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(287, 131);
            this.pnlTopBar.TabIndex = 4;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.Location = new System.Drawing.Point(17, 97);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(48, 23);
            this.btnDelete.TabIndex = 42;
            this.btnDelete.Tag = "Delete";
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pbStatusIcon
            // 
            this.pbStatusIcon.Location = new System.Drawing.Point(17, 12);
            this.pbStatusIcon.MaximumSize = new System.Drawing.Size(30, 30);
            this.pbStatusIcon.MinimumSize = new System.Drawing.Size(30, 30);
            this.pbStatusIcon.Name = "pbStatusIcon";
            this.pbStatusIcon.Size = new System.Drawing.Size(30, 30);
            this.pbStatusIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStatusIcon.TabIndex = 32;
            this.pbStatusIcon.TabStop = false;
            this.pbStatusIcon.Tag = "Status Icon";
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSize = true;
            this.btnUpdate.Location = new System.Drawing.Point(210, 97);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(52, 23);
            this.btnUpdate.TabIndex = 41;
            this.btnUpdate.Tag = "Update";
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Created Date :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Updated Date :";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(97, 71);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(165, 20);
            this.tbName.TabIndex = 40;
            this.tbName.Tag = "Status Name";
            this.tbName.Text = "Status Name";
            // 
            // lblUpdateDate
            // 
            this.lblUpdateDate.AutoSize = true;
            this.lblUpdateDate.Location = new System.Drawing.Point(139, 29);
            this.lblUpdateDate.Name = "lblUpdateDate";
            this.lblUpdateDate.Size = new System.Drawing.Size(0, 13);
            this.lblUpdateDate.TabIndex = 39;
            this.lblUpdateDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(78, 45);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(184, 20);
            this.dtpEndDate.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "End Date :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Status Name :";
            // 
            // lblCreateDate
            // 
            this.lblCreateDate.AutoSize = true;
            this.lblCreateDate.Location = new System.Drawing.Point(139, 12);
            this.lblCreateDate.Name = "lblCreateDate";
            this.lblCreateDate.Size = new System.Drawing.Size(127, 13);
            this.lblCreateDate.TabIndex = 35;
            this.lblCreateDate.Text = "2022-03-02 17:44:50.593";
            this.lblCreateDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.flpDuties);
            this.Controls.Add(this.pnlTopBar);
            this.Name = "ucStatus";
            this.Size = new System.Drawing.Size(287, 437);
            this.Load += new System.EventHandler(this.ucStatus_Load);
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatusIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flpDuties;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.PictureBox pbStatusIcon;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblUpdateDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCreateDate;
    }
}
