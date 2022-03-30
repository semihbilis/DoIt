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
    public partial class frmCProject : Form
    {
        public frmCProject()
        {
            InitializeComponent();
        }

        private EfProjectDal efProjectDal = new EfProjectDal();
        private int selectedRowId;
        private int selectedId;
        private int selectedColumnId;
        private string selectedColumnName;
        private DateTimePicker dtp;

        private void frmCProject_Load(object sender, EventArgs e)
        {
            IList<Project> projects = efProjectDal.GetList(f => f.OrganizationId == frmDoIt._selectedOrganization.Id);
            foreach (var project in projects)
            {
                dgvProjects.Rows.Add("", "", project.Id, project.Name, project.CreateDate, project.UpdateDate, project.EndDate);
            }
            dgvProjects.Columns["dgvProjectCreateDate"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvProjects.Columns["dgvProjectUpdateDate"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvProjects.Columns["dgvProjectEnddate"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void GetDatagridviewParametres()
        {
            selectedRowId = dgvProjects.CurrentCell.RowIndex;
            selectedId = (dgvProjects.Rows[selectedRowId].Cells["dgvId"].Value == null) ? 0 : (int)dgvProjects.Rows[selectedRowId].Cells["dgvId"].Value;
            selectedColumnId = dgvProjects.CurrentCell.ColumnIndex;
            selectedColumnName = dgvProjects.Columns[selectedColumnId].Name;
        }

        private void dgvProjects_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            tableDataSaved();
        }

        private void tableDataSaved()
        {
            GetDatagridviewParametres();

            Project project = new Project();
            if (selectedId != 0)
            {
                project = efProjectDal.Get(f => f.Id == selectedId);
                project.Name = dgvProjects.Rows[selectedRowId].Cells["dgvProjectName"].Value.ToString();
                project.EndDate = (DateTime?)dgvProjects.Rows[selectedRowId].Cells["dgvProjectEnddate"].Value;
                efProjectDal.Update(project);
                dgvProjects.Rows[selectedRowId].Cells["dgvProjectUpdatedate"].Value = project.UpdateDate;
            }
            else
            {
                if (dgvProjects.Rows[selectedRowId].Cells["dgvProjectName"].Value != null)
                {
                    project.Name = dgvProjects.Rows[selectedRowId].Cells["dgvProjectName"].Value.ToString();
                    project.EndDate = (DateTime?)dgvProjects.Rows[selectedRowId].Cells["dgvProjectEnddate"].Value;
                    project.OrganizationId = frmDoIt._selectedOrganization.Id;
                    efProjectDal.Add(project);
                    dgvProjects.Rows[selectedRowId].Cells["dgvId"].Value = project.Id;
                    dgvProjects.Rows[selectedRowId].Cells["dgvProjectCreatedate"].Value = project.CreateDate;
                }
                else
                {
                    if (dgvProjects.CurrentCell.Value == null)
                    {
                    }
                    else
                    {
                        BeginInvoke(new MethodInvoker(delegate { dgvProjects.Rows.RemoveAt(selectedRowId); }));
                    }
                }
            }
            DateTime? endDateTime = (DateTime?)dgvProjects.Rows[selectedRowId].Cells["dgvProjectEnddate"].Value;
            if (endDateTime != null && endDateTime < DateTime.Now)
            {
                dgvProjects.Rows[selectedRowId].Cells["dgvProjectEnddate"].Style.BackColor = Color.Red;
            }
            else
            {
                dgvProjects.Rows[selectedRowId].Cells["dgvProjectEnddate"].Style.BackColor = Color.Empty;
            }
        }

        private void dtp_CloseUp(object sender, EventArgs e)
        {
            dtp.Visible = false;
        }
        private void dtp_OnTextChange(object sender, EventArgs e)
        {
            GetDatagridviewParametres();
            dgvProjects.Rows[selectedRowId].Cells["dgvProjectEnddate"].Value = DateTime.Parse(dtp.Text + "23:59:59");
            tableDataSaved();
        }

        private void dgvProjects_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetDatagridviewParametres();

            Project project = new Project();
            project = efProjectDal.Get(f => f.Id == selectedId);
            if (selectedId != 0)
            {
                switch (selectedColumnName)
                {
                    case "dgvBtnDelete":
                        efProjectDal.Delete(project);
                        if (project.Id == frmDoIt._selectedProject?.Id)
                        {
                            IList<Project> projects = efProjectDal.GetList(f => f.OrganizationId == frmDoIt._selectedOrganization.Id);
                            frmDoIt._selectedProject = projects.FirstOrDefault();
                        }
                        dgvProjects.Rows.RemoveAt(selectedRowId);
                        break;
                    case "dgvBtnSelect":
                        frmDoIt._selectedProject = project;
                        this.Close();
                        break;
                    case "dgvProjectEnddate":
                        if (e.RowIndex < 0 || dgvProjects.CurrentRow.IsNewRow)
                        {
                            break;
                        }
                        if (dtp != null)
                        {
                            dtp.Visible = false;
                            dtp = null;
                        }
                        dtp = new DateTimePicker();
                        dtp.Value = (dgvProjects.Rows[e.RowIndex].Cells["dgvProjectEnddate"].Value == null) ? DateTime.Now :
                            DateTime.Parse(dgvProjects.Rows[e.RowIndex].Cells["dgvProjectEnddate"].Value.ToString());
                        var rect = dgvProjects.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                        dtp.Size = new Size(rect.Width, rect.Height);
                        dtp.Location = new Point(rect.X, rect.Y);
                        dtp.Visible = true;
                        dtp.CloseUp += new EventHandler(dtp_CloseUp);
                        dtp.TextChanged += new EventHandler(dtp_OnTextChange);
                        dgvProjects.Controls.Add(dtp);
                        break;
                    default:
                        break;
                }
            }
        }

        private void dgvProjects_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if ((DateTime?)dgvProjects.Rows[e.RowIndex].Cells["dgvProjectEnddate"].Value < DateTime.Now)
            {
                dgvProjects.Rows[e.RowIndex].Cells["dgvProjectEnddate"].Style.BackColor = Color.Red;
            }
            else
            {
                dgvProjects.Rows[e.RowIndex].Cells["dgvProjectEnddate"].Style.BackColor = Color.Empty;
            }
        }
    }
}
