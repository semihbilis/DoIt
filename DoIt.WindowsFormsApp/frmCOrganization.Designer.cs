
namespace DoIt.WindowsFormsApp
{
    partial class frmCOrganization
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
            this.dgvOrganizations = new System.Windows.Forms.DataGridView();
            this.dgvBtnSelect = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvBtnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvOrganizationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvOrganizationCreatedate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvOrganizationUpdatedate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvOrganizationEnddate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrganizations)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrganizations
            // 
            this.dgvOrganizations.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvOrganizations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrganizations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvBtnSelect,
            this.dgvBtnDelete,
            this.dgvId,
            this.dgvOrganizationName,
            this.dgvOrganizationCreatedate,
            this.dgvOrganizationUpdatedate,
            this.dgvOrganizationEnddate});
            this.dgvOrganizations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrganizations.Location = new System.Drawing.Point(0, 0);
            this.dgvOrganizations.MultiSelect = false;
            this.dgvOrganizations.Name = "dgvOrganizations";
            this.dgvOrganizations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvOrganizations.Size = new System.Drawing.Size(713, 314);
            this.dgvOrganizations.TabIndex = 3;
            this.dgvOrganizations.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrganizations_CellClick);
            this.dgvOrganizations.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrganizations_CellEndEdit);
            this.dgvOrganizations.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvOrganizations_RowsAdded);
            // 
            // dgvBtnSelect
            // 
            this.dgvBtnSelect.Frozen = true;
            this.dgvBtnSelect.HeaderText = "Select";
            this.dgvBtnSelect.Name = "dgvBtnSelect";
            this.dgvBtnSelect.Text = "Select";
            this.dgvBtnSelect.UseColumnTextForButtonValue = true;
            this.dgvBtnSelect.Width = 50;
            // 
            // dgvBtnDelete
            // 
            this.dgvBtnDelete.Frozen = true;
            this.dgvBtnDelete.HeaderText = "Delete";
            this.dgvBtnDelete.Name = "dgvBtnDelete";
            this.dgvBtnDelete.Text = "Delete";
            this.dgvBtnDelete.UseColumnTextForButtonValue = true;
            this.dgvBtnDelete.Width = 50;
            // 
            // dgvId
            // 
            this.dgvId.HeaderText = "Id";
            this.dgvId.Name = "dgvId";
            this.dgvId.Visible = false;
            // 
            // dgvOrganizationName
            // 
            this.dgvOrganizationName.Frozen = true;
            this.dgvOrganizationName.HeaderText = "Name";
            this.dgvOrganizationName.Name = "dgvOrganizationName";
            this.dgvOrganizationName.Width = 200;
            // 
            // dgvOrganizationCreatedate
            // 
            this.dgvOrganizationCreatedate.Frozen = true;
            this.dgvOrganizationCreatedate.HeaderText = "Create Date";
            this.dgvOrganizationCreatedate.Name = "dgvOrganizationCreatedate";
            this.dgvOrganizationCreatedate.ReadOnly = true;
            this.dgvOrganizationCreatedate.Width = 110;
            // 
            // dgvOrganizationUpdatedate
            // 
            this.dgvOrganizationUpdatedate.Frozen = true;
            this.dgvOrganizationUpdatedate.HeaderText = "Update Date";
            this.dgvOrganizationUpdatedate.Name = "dgvOrganizationUpdatedate";
            this.dgvOrganizationUpdatedate.Width = 110;
            // 
            // dgvOrganizationEnddate
            // 
            this.dgvOrganizationEnddate.HeaderText = "End Date";
            this.dgvOrganizationEnddate.Name = "dgvOrganizationEnddate";
            this.dgvOrganizationEnddate.Width = 150;
            // 
            // frmCOrganization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 314);
            this.Controls.Add(this.dgvOrganizations);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCOrganization";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Organizations | Do It";
            this.Load += new System.EventHandler(this.frmCOrganization_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrganizations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvOrganizations;
        private System.Windows.Forms.DataGridViewButtonColumn dgvBtnSelect;
        private System.Windows.Forms.DataGridViewButtonColumn dgvBtnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvOrganizationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvOrganizationCreatedate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvOrganizationUpdatedate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvOrganizationEnddate;
    }
}