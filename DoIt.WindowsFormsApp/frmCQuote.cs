using DoIt.DataAccess.Concrete.EntityFramework;
using DoIt.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoIt.WindowsFormsApp
{
    public partial class frmCQuote : Form
    {
        public frmCQuote()
        {
            InitializeComponent();
        }

        private EfQuoteDal efQuoteDal = new EfQuoteDal();
        private int selectedRowId;
        private int selectedId;
        private int selectedColumnId;
        private string selectedColumnName;
        private DateTimePicker dtp;


        private void frmCQuote_Load(object sender, EventArgs e)
        {
            IList<Quote> quotes = efQuoteDal.GetList(f => f.UserId == frmDoIt._signedUser.Id);
            foreach (var quote in quotes)
            {
                dgvQuotes.Rows.Add("", quote.Id, quote.Text, quote.CreateDate, quote.UpdateDate, quote.EndDate);
            }
            dgvQuotes.Columns["dgvQuoteEnddate"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void GetDatagridviewParametres()
        {
            selectedRowId = dgvQuotes.CurrentCell.RowIndex;
            selectedId = (dgvQuotes.Rows[selectedRowId].Cells["dgvId"].Value == null) ? 0 : (int)dgvQuotes.Rows[selectedRowId].Cells["dgvId"].Value;
            selectedColumnId = dgvQuotes.CurrentCell.ColumnIndex;
            selectedColumnName = dgvQuotes.Columns[selectedColumnId].Name;
        }

        private void dgvQuotes_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            tableDataSaved();
        }

        private void tableDataSaved()
        {
            GetDatagridviewParametres();

            Quote quote = new Quote();
            if (selectedId != 0)
            {
                quote = efQuoteDal.Get(f => f.Id == selectedId);
                quote.Text = dgvQuotes.Rows[selectedRowId].Cells["dgvQuoteText"].Value.ToString();
                quote.EndDate = (DateTime?)dgvQuotes.Rows[selectedRowId].Cells["dgvQuoteEnddate"].Value;
                efQuoteDal.Update(quote);
                dgvQuotes.Rows[selectedRowId].Cells["dgvQuoteUpdatedate"].Value = quote.UpdateDate;
            }
            else
            {
                if (dgvQuotes.Rows[selectedRowId].Cells["dgvQuoteText"].Value != null)
                {
                    quote.Text = dgvQuotes.Rows[selectedRowId].Cells["dgvQuoteText"].Value.ToString();
                    quote.EndDate = (DateTime?)dgvQuotes.Rows[selectedRowId].Cells["dgvQuoteEnddate"].Value;
                    quote.UserId = frmDoIt._signedUser.Id;
                    efQuoteDal.Add(quote);
                    dgvQuotes.Rows[selectedRowId].Cells["dgvId"].Value = quote.Id;
                    dgvQuotes.Rows[selectedRowId].Cells["dgvQuoteCreatedate"].Value = quote.CreateDate;
                }
                else
                {
                    if (dgvQuotes.CurrentCell.Value == null)
                    {
                    }
                    else
                    {
                        BeginInvoke(new MethodInvoker(delegate { dgvQuotes.Rows.RemoveAt(selectedRowId); }));
                    }
                }
            }
            if ((DateTime?)dgvQuotes.Rows[selectedRowId].Cells["dgvQuoteEnddate"].Value < DateTime.Now)
            {
                dgvQuotes.Rows[selectedRowId].Cells["dgvQuoteEnddate"].Style.BackColor = Color.Red;
            }
            else
            {
                dgvQuotes.Rows[selectedRowId].Cells["dgvQuoteEnddate"].Style.BackColor = Color.Empty;
            }
        }

        private void dgvQuotes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetDatagridviewParametres();

            Quote quote = new Quote();
            quote = efQuoteDal.Get(f => f.Id == selectedId);
            if (selectedId != 0)
            {
                switch (selectedColumnName)
                {
                    case "dgvBtnDelete":
                        efQuoteDal.Delete(quote);
                        dgvQuotes.Rows.RemoveAt(selectedRowId);
                        break;
                    case "dgvQuoteEnddate":
                        if (e.RowIndex < 0 || dgvQuotes.CurrentRow.IsNewRow)
                        {
                            break;
                        }
                        if (dtp != null)
                        {
                            dtp.Visible = false;
                            dtp = null;
                        }
                        dtp = new DateTimePicker();
                        dtp.Value = (dgvQuotes.Rows[e.RowIndex].Cells["dgvQuoteEnddate"].Value == null) ? DateTime.Now :
                            DateTime.Parse(dgvQuotes.Rows[e.RowIndex].Cells["dgvQuoteEnddate"].Value.ToString());
                        var rect = dgvQuotes.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                        dtp.Size = new Size(rect.Width, rect.Height);
                        dtp.Location = new Point(rect.X, rect.Y);
                        dtp.Visible = true;
                        dtp.CloseUp += new EventHandler(dtp_CloseUp);
                        dtp.TextChanged += new EventHandler(dtp_OnTextChange);
                        dgvQuotes.Controls.Add(dtp);
                        break;
                    default:
                        break;
                }
            }
        }

        private void dtp_CloseUp(object sender, EventArgs e)
        {
            dtp.Visible = false;
        }
        private void dtp_OnTextChange(object sender, EventArgs e)
        {
            GetDatagridviewParametres();
            dgvQuotes.Rows[selectedRowId].Cells["dgvQuoteEnddate"].Value = DateTime.Parse(dtp.Text.ToString() + "23:59:59");
            tableDataSaved();
        }

        private void dgvQuotes_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if ((DateTime?)dgvQuotes.Rows[e.RowIndex].Cells["dgvQuoteEnddate"].Value < DateTime.Now)
            {
                dgvQuotes.Rows[e.RowIndex].Cells["dgvQuoteEnddate"].Style.BackColor = Color.Red;
            }
            else
            {
                dgvQuotes.Rows[selectedRowId].Cells["dgvQuoteEnddate"].Style.BackColor = Color.Empty;
            }
        }
    }
}
