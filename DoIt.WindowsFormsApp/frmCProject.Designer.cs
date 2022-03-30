
namespace DoIt.WindowsFormsApp
{
    partial class frmCProject
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
            this.dgvProjects = new System.Windows.Forms.DataGridView();
            this.dgvBtnSelect = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvBtnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProjectCreatedate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProjectUpdatedate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProjectEnddate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjects)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProjects
            // 
            this.dgvProjects.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvBtnSelect,
            this.dgvBtnDelete,
            this.dgvId,
            this.dgvProjectName,
            this.dgvProjectCreatedate,
            this.dgvProjectUpdatedate,
            this.dgvProjectEnddate});
            this.dgvProjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProjects.Location = new System.Drawing.Point(0, 0);
            this.dgvProjects.MultiSelect = false;
            this.dgvProjects.Name = "dgvProjects";
            this.dgvProjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvProjects.Size = new System.Drawing.Size(764, 314);
            this.dgvProjects.TabIndex = 5;
            this.dgvProjects.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProjects_CellClick);
            this.dgvProjects.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProjects_CellEndEdit);
            this.dgvProjects.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvProjects_RowsAdded);
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
            this.dgvId.MinimumWidth = 2;
            this.dgvId.Name = "dgvId";
            this.dgvId.Visible = false;
            this.dgvId.Width = 2;
            // 
            // dgvProjectName
            // 
            this.dgvProjectName.Frozen = true;
            this.dgvProjectName.HeaderText = "Name";
            this.dgvProjectName.Name = "dgvProjectName";
            this.dgvProjectName.Width = 250;
            // 
            // dgvProjectCreatedate
            // 
            this.dgvProjectCreatedate.Frozen = true;
            this.dgvProjectCreatedate.HeaderText = "Create Date";
            this.dgvProjectCreatedate.Name = "dgvProjectCreatedate";
            this.dgvProjectCreatedate.ReadOnly = true;
            this.dgvProjectCreatedate.Width = 110;
            // 
            // dgvProjectUpdatedate
            // 
            this.dgvProjectUpdatedate.Frozen = true;
            this.dgvProjectUpdatedate.HeaderText = "Update Date";
            this.dgvProjectUpdatedate.Name = "dgvProjectUpdatedate";
            this.dgvProjectUpdatedate.ReadOnly = true;
            this.dgvProjectUpdatedate.Width = 110;
            // 
            // dgvProjectEnddate
            // 
            this.dgvProjectEnddate.Frozen = true;
            this.dgvProjectEnddate.HeaderText = "End Date";
            this.dgvProjectEnddate.Name = "dgvProjectEnddate";
            this.dgvProjectEnddate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProjectEnddate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvProjectEnddate.Width = 150;
            // 
            // frmCProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 314);
            this.Controls.Add(this.dgvProjects);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCProject";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Projects | Do It";
            this.Load += new System.EventHandler(this.frmCProject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjects)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvProjects;
        private System.Windows.Forms.DataGridViewButtonColumn dgvBtnSelect;
        private System.Windows.Forms.DataGridViewButtonColumn dgvBtnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProjectCreatedate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProjectUpdatedate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProjectEnddate;
    }
}