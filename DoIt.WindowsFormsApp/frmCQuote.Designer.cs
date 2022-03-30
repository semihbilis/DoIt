namespace DoIt.WindowsFormsApp
{
    partial class frmCQuote
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
            this.dgvQuotes = new System.Windows.Forms.DataGridView();
            this.dgvBtnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvQuoteText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvQuoteCreatedate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvQuoteUpdatedate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvQuoteEnddate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuotes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvQuotes
            // 
            this.dgvQuotes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvQuotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuotes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvBtnDelete,
            this.dgvId,
            this.dgvQuoteText,
            this.dgvQuoteCreatedate,
            this.dgvQuoteUpdatedate,
            this.dgvQuoteEnddate});
            this.dgvQuotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvQuotes.Location = new System.Drawing.Point(0, 0);
            this.dgvQuotes.MultiSelect = false;
            this.dgvQuotes.Name = "dgvQuotes";
            this.dgvQuotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvQuotes.Size = new System.Drawing.Size(664, 314);
            this.dgvQuotes.TabIndex = 4;
            this.dgvQuotes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuotes_CellClick);
            this.dgvQuotes.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuotes_CellEndEdit);
            this.dgvQuotes.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvQuotes_RowsAdded);
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
            // dgvQuoteText
            // 
            this.dgvQuoteText.Frozen = true;
            this.dgvQuoteText.HeaderText = "Text";
            this.dgvQuoteText.Name = "dgvQuoteText";
            this.dgvQuoteText.Width = 200;
            // 
            // dgvQuoteCreatedate
            // 
            this.dgvQuoteCreatedate.Frozen = true;
            this.dgvQuoteCreatedate.HeaderText = "Create Date";
            this.dgvQuoteCreatedate.Name = "dgvQuoteCreatedate";
            this.dgvQuoteCreatedate.ReadOnly = true;
            this.dgvQuoteCreatedate.Width = 110;
            // 
            // dgvQuoteUpdatedate
            // 
            this.dgvQuoteUpdatedate.Frozen = true;
            this.dgvQuoteUpdatedate.HeaderText = "Update Date";
            this.dgvQuoteUpdatedate.Name = "dgvQuoteUpdatedate";
            this.dgvQuoteUpdatedate.ReadOnly = true;
            this.dgvQuoteUpdatedate.Width = 110;
            // 
            // dgvQuoteEnddate
            // 
            this.dgvQuoteEnddate.HeaderText = "End Date";
            this.dgvQuoteEnddate.Name = "dgvQuoteEnddate";
            this.dgvQuoteEnddate.ReadOnly = true;
            this.dgvQuoteEnddate.Width = 150;
            // 
            // frmCQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 314);
            this.Controls.Add(this.dgvQuotes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCQuote";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quotes | Do It";
            this.Load += new System.EventHandler(this.frmCQuote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuotes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvQuotes;
        private System.Windows.Forms.DataGridViewButtonColumn dgvBtnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvQuoteText;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvQuoteCreatedate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvQuoteUpdatedate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvQuoteEnddate;
    }
}