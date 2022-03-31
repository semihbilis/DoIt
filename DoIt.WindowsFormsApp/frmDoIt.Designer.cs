
namespace DoIt.WindowsFormsApp
{
    partial class frmDoIt
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
            this.msTopmenu = new System.Windows.Forms.MenuStrip();
            this.tsmiOrganizationname = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUserfullname = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQuotes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiProjectname = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQuoteDoIt = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlStatuses = new System.Windows.Forms.Panel();
            this.msTopmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // msTopmenu
            // 
            this.msTopmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOrganizationname,
            this.tsmiUserfullname,
            this.tsmiProjectname,
            this.tsmiQuoteDoIt});
            this.msTopmenu.Location = new System.Drawing.Point(0, 0);
            this.msTopmenu.Name = "msTopmenu";
            this.msTopmenu.Size = new System.Drawing.Size(800, 24);
            this.msTopmenu.TabIndex = 0;
            this.msTopmenu.Text = "menuStrip1";
            // 
            // tsmiOrganizationname
            // 
            this.tsmiOrganizationname.Name = "tsmiOrganizationname";
            this.tsmiOrganizationname.Size = new System.Drawing.Size(124, 20);
            this.tsmiOrganizationname.Text = "Create Organization";
            this.tsmiOrganizationname.Click += new System.EventHandler(this.tsmiOrganizationname_Click);
            // 
            // tsmiUserfullname
            // 
            this.tsmiUserfullname.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmiUserfullname.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOptions,
            this.tsmiLogOut,
            this.tsmiExit});
            this.tsmiUserfullname.Name = "tsmiUserfullname";
            this.tsmiUserfullname.Size = new System.Drawing.Size(91, 20);
            this.tsmiUserfullname.Text = "UserFullname";
            // 
            // tsmiOptions
            // 
            this.tsmiOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiQuotes});
            this.tsmiOptions.Name = "tsmiOptions";
            this.tsmiOptions.Size = new System.Drawing.Size(117, 22);
            this.tsmiOptions.Text = "Options";
            // 
            // tsmiQuotes
            // 
            this.tsmiQuotes.Name = "tsmiQuotes";
            this.tsmiQuotes.Size = new System.Drawing.Size(112, 22);
            this.tsmiQuotes.Text = "Quotes";
            this.tsmiQuotes.Click += new System.EventHandler(this.quotesToolStripMenuItem_Click);
            // 
            // tsmiLogOut
            // 
            this.tsmiLogOut.Name = "tsmiLogOut";
            this.tsmiLogOut.Size = new System.Drawing.Size(117, 22);
            this.tsmiLogOut.Text = "Log Out";
            this.tsmiLogOut.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(117, 22);
            this.tsmiExit.Text = "Exit";
            this.tsmiExit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tsmiProjectname
            // 
            this.tsmiProjectname.Name = "tsmiProjectname";
            this.tsmiProjectname.Size = new System.Drawing.Size(93, 20);
            this.tsmiProjectname.Text = "Create Project";
            this.tsmiProjectname.Click += new System.EventHandler(this.tsmiProjectname_Click);
            // 
            // tsmiQuoteDoIt
            // 
            this.tsmiQuoteDoIt.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmiQuoteDoIt.MergeAction = System.Windows.Forms.MergeAction.Remove;
            this.tsmiQuoteDoIt.Name = "tsmiQuoteDoIt";
            this.tsmiQuoteDoIt.Padding = new System.Windows.Forms.Padding(0);
            this.tsmiQuoteDoIt.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.tsmiQuoteDoIt.Size = new System.Drawing.Size(76, 20);
            this.tsmiQuoteDoIt.Tag = "Do It";
            this.tsmiQuoteDoIt.Text = "Always Do It";
            this.tsmiQuoteDoIt.Click += new System.EventHandler(this.tsmiQuoteDoIt_Click);
            // 
            // pnlStatuses
            // 
            this.pnlStatuses.AutoSize = true;
            this.pnlStatuses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStatuses.Location = new System.Drawing.Point(0, 24);
            this.pnlStatuses.Name = "pnlStatuses";
            this.pnlStatuses.Size = new System.Drawing.Size(800, 727);
            this.pnlStatuses.TabIndex = 1;
            this.pnlStatuses.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.pnlStatuses_ControlRemoved);
            // 
            // frmDoIt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 751);
            this.Controls.Add(this.pnlStatuses);
            this.Controls.Add(this.msTopmenu);
            this.MainMenuStrip = this.msTopmenu;
            this.Name = "frmDoIt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Do It";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDoIt_FormClosed);
            this.Load += new System.EventHandler(this.frmDoIt_Load);
            this.msTopmenu.ResumeLayout(false);
            this.msTopmenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msTopmenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiOrganizationname;
        private System.Windows.Forms.ToolStripMenuItem tsmiUserfullname;
        private System.Windows.Forms.ToolStripMenuItem tsmiOptions;
        private System.Windows.Forms.ToolStripMenuItem tsmiLogOut;
        private System.Windows.Forms.ToolStripMenuItem tsmiQuoteDoIt;
        private System.Windows.Forms.ToolStripMenuItem tsmiProjectname;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiQuotes;
        private System.Windows.Forms.Panel pnlStatuses;
    }
}