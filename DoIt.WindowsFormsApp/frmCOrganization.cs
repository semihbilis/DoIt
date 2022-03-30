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
    public partial class frmCOrganization : Form
    {
        public frmCOrganization()
        {
            InitializeComponent();
        }

        private EfOrganizationDal efOrganizationDal = new EfOrganizationDal();
        private int selectedRowId;
        private int selectedId;
        private int selectedColumnId;
        private string selectedColumnName;
        private DateTimePicker dtp;

        private void frmCOrganization_Load(object sender, EventArgs e)
        {
            IList<Organization> organizations = efOrganizationDal.GetList(f => f.UserId == frmDoIt._signedUser.Id);
            foreach (var org in organizations)
            {
                dgvOrganizations.Rows.Add("", "", org.Id, org.Name, org.CreateDate, org.UpdateDate, org.EndDate);
            }
            dgvOrganizations.Columns["dgvOrganizationCreateDate"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvOrganizations.Columns["dgvOrganizationUpdateDate"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvOrganizations.Columns["dgvOrganizationEnddate"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void GetDatagridviewParametres()
        {
            selectedRowId = dgvOrganizations.CurrentCell.RowIndex;
            selectedId = (dgvOrganizations.Rows[selectedRowId].Cells["dgvId"].Value == null) ? 0 : (int)dgvOrganizations.Rows[selectedRowId].Cells["dgvId"].Value;
            selectedColumnId = dgvOrganizations.CurrentCell.ColumnIndex;
            selectedColumnName = dgvOrganizations.Columns[selectedColumnId].Name;
        }

        private void dgvOrganizations_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            tableDataSaved();
        }

        private void tableDataSaved()
        {
            GetDatagridviewParametres();

            Organization organization = new Organization();
            if (selectedId != 0)
            {
                organization = efOrganizationDal.Get(f => f.Id == selectedId);
                organization.Name = dgvOrganizations.Rows[selectedRowId].Cells["dgvOrganizationName"].Value.ToString();
                organization.EndDate = (DateTime?)dgvOrganizations.Rows[selectedRowId].Cells["dgvOrganizationEnddate"].Value;
                efOrganizationDal.Update(organization);
                dgvOrganizations.Rows[selectedRowId].Cells["dgvOrganizationUpdatedate"].Value = organization.UpdateDate;
            }
            else
            {
                if (dgvOrganizations.Rows[selectedRowId].Cells["dgvOrganizationName"].Value != null)
                {
                    organization.Name = dgvOrganizations.Rows[selectedRowId].Cells["dgvOrganizationName"].Value.ToString();
                    organization.EndDate = (DateTime?)dgvOrganizations.Rows[selectedRowId].Cells["dgvOrganizationEnddate"].Value;
                    organization.UserId = frmDoIt._signedUser.Id;
                    efOrganizationDal.Add(organization);
                    dgvOrganizations.Rows[selectedRowId].Cells["dgvId"].Value = organization.Id;
                    dgvOrganizations.Rows[selectedRowId].Cells["dgvOrganizationCreatedate"].Value = organization.CreateDate;
                }
                else
                {
                    if (dgvOrganizations.CurrentCell.Value == null)
                    {
                    }
                    else
                    {
                        BeginInvoke(new MethodInvoker(delegate { dgvOrganizations.Rows.RemoveAt(selectedRowId); }));
                    }
                }
            }
            if ((DateTime?)dgvOrganizations.Rows[selectedRowId].Cells["dgvOrganizationEnddate"].Value < DateTime.Now)
            {
                dgvOrganizations.Rows[selectedRowId].Cells["dgvOrganizationEnddate"].Style.BackColor = Color.Red;
            }
            else
            {
                dgvOrganizations.Rows[selectedRowId].Cells["dgvOrganizationEnddate"].Style.BackColor = Color.Empty;
            }
        }

        private void dgvOrganizations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetDatagridviewParametres();

            Organization organization = new Organization();
            organization = efOrganizationDal.Get(f => f.Id == selectedId);
            if (selectedId != 0)
            {
                switch (selectedColumnName)
                {
                    case "dgvBtnDelete":
                        efOrganizationDal.Delete(organization);
                        if (organization.Id == frmDoIt._selectedOrganization.Id)
                        {
                            IList<Organization> organizations = efOrganizationDal.GetList(f => f.UserId == frmDoIt._signedUser.Id);
                            frmDoIt._selectedOrganization = organizations.FirstOrDefault();
                        }
                        dgvOrganizations.Rows.RemoveAt(selectedRowId);
                        break;
                    case "dgvBtnSelect":
                        frmDoIt._selectedOrganization = organization;
                        this.Close();
                        break;
                    case "dgvOrganizationEnddate":
                        if (e.RowIndex < 0 || dgvOrganizations.CurrentRow.IsNewRow)
                        {
                            break;
                        }
                        if (dtp != null)
                        {
                            dtp.Visible = false;
                            dtp = null;
                        }
                        dtp = new DateTimePicker();
                        dtp.Value = (dgvOrganizations.Rows[e.RowIndex].Cells["dgvOrganizationEnddate"].Value == null) ? DateTime.Now :
                            DateTime.Parse(dgvOrganizations.Rows[e.RowIndex].Cells["dgvOrganizationEnddate"].Value.ToString());
                        var rect = dgvOrganizations.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                        dtp.Size = new Size(rect.Width, rect.Height);
                        dtp.Location = new Point(rect.X, rect.Y);
                        dtp.Visible = true;
                        dtp.CloseUp += new EventHandler(dtp_CloseUp);
                        dtp.TextChanged += new EventHandler(dtp_OnTextChange);
                        dgvOrganizations.Controls.Add(dtp);
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
            dgvOrganizations.Rows[selectedRowId].Cells["dgvOrganizationEnddate"].Value = DateTime.Parse(dtp.Text.ToString() + "23:59:59");
            tableDataSaved();
        }

        private void dgvOrganizations_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if ((DateTime?)dgvOrganizations.Rows[e.RowIndex].Cells["dgvOrganizationEnddate"].Value < DateTime.Now)
            {
                dgvOrganizations.Rows[e.RowIndex].Cells["dgvOrganizationEnddate"].Style.BackColor = Color.Red;
            }
            else
            {
                dgvOrganizations.Rows[e.RowIndex].Cells["dgvOrganizationEnddate"].Style.BackColor = Color.Empty;
            }
        }
    }
}