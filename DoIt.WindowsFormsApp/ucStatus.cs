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
    public partial class ucStatus : UserControl
    {
        private Status _Status;
        private Button _btnAddStatus;
        private EfStatusDal _efStatusDal = new EfStatusDal();
        public ucStatus(int StatusId = 0)
        {
            InitializeComponent();

            if (StatusId != 0)
                this._Status = _efStatusDal.Get(f => f.Id == StatusId);
        }
        public Status GetStatus()
        {
            return _Status;
        }
        public void SetStatus(Status status)
        {
            this._Status = status;
            ucStatusRefresh();
        }

        private void ucStatus_Load(object sender, EventArgs e)
        {
            ucStatusRefresh(1);
        }

        private void ucStatusToolsClear()
        {
            pbStatusIcon.Image = pbStatusIcon.ErrorImage;
            lblCreateDate.Text = "";
            lblUpdateDate.Text = "";
            dtpEndDate.Value = DateTime.Now;
            tbName.Text = "";
            btnUpdate.Text = "Update";
            flpDuties.Controls.Clear();
        }

        private void ucStatusRefresh(int s = 0)
        {
            if (s == 0)
                ucStatusToolsClear();

            if (_Status != null)
            {
                this.Name = "ucStatus" + _Status.Id.ToString();
                if (String.IsNullOrEmpty(_Status.Icon))
                    pbStatusIcon.Image = pbStatusIcon.ErrorImage;
                else
                    pbStatusIcon.Load(_Status.Icon);
                lblCreateDate.Text = _Status.CreateDate != null ? _Status.CreateDate.ToString() : "";
                lblUpdateDate.Text = _Status.UpdateDate != null ? _Status.UpdateDate.ToString() : "";
                dtpEndDate.Value = _Status.EndDate != null ? _Status.EndDate.Value : DateTime.Now;
                tbName.Text = _Status.Name;
                if (_Status.Duties != null)
                {
                    foreach (Duty duty in _Status.Duties)
                    {
                        ucDuty ucDuty = new ucDuty(duty.Id);
                        flpDuties.Controls.Add(ucDuty);
                    }
                }
                ucDuty ucDutyCreate = new ucDuty();
                flpDuties.Controls.Add(ucDutyCreate);
            }
            else
            {
                pnlTopBar.Visible = false;
                flpDuties.Visible = false;
                _btnAddStatus = new Button()
                {
                    MaximumSize = new Size(287, 0),
                    AutoSize = true,
                    Text = "+ Add Status",
                    Dock = DockStyle.Fill,
                };
                _btnAddStatus.Click += new EventHandler(addStatusClick);
                _btnAddStatus.BringToFront();
                this.Controls.Add(_btnAddStatus);
            }
        }

        private void addStatusClick(object sender, EventArgs e)
        {
            this.Controls.Remove(_btnAddStatus);
            this.MinimumSize = new Size(287, 0);
            pnlTopBar.Visible = true;
            flpDuties.Visible = true;
            btnUpdate.Text = "Save";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_Status != null)
            {
                if (dtpEndDate.Value != _Status.EndDate || tbName.Text != _Status.Name)
                {
                    _Status.EndDate = DateTime.Parse(dtpEndDate.Text + "23:59:59");
                    _Status.Name = tbName.Text;
                    _efStatusDal.Update(_Status);
                    ucStatusRefresh();
                }
            }
            else
            {
                if (!String.IsNullOrEmpty(tbName.Text))
                {
                    _Status = new Status()
                    {
                        Name = tbName.Text,
                        EndDate = dtpEndDate.Value,
                        ProjectId = frmDoIt._selectedProject.Id
                    };
                    _efStatusDal.Add(_Status);
                    ucStatusRefresh();
                    (this.Parent.Parent as frmDoIt).AddDefultUcStatusInForm();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_Status != null)
            {
                if ((_Status.Duties == null ? 0 : _Status.Duties.Count) > 0 && flpDuties.Controls.Count > 0)
                {
                    return;
                }
                else
                {
                    _efStatusDal.Delete(_Status);
                }
            }
            this.Dispose();
        }
    }
}
