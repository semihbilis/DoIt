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
        private EfStatusDal _efStatusDal;
        public ucStatus(int StatusId = 0)
        {
            InitializeComponent();
            if (StatusId != 0)
            {
                _efStatusDal = new EfStatusDal();
                this._Status = _efStatusDal.Get(f => f.Id == StatusId);
                this.Name = "ucStatus" + _Status.Id.ToString();
            }
        }
        public Status GetStatus()
        {
            return _Status;
        }
        public void SetStatus(Status status)
        {
            this._Status = status;
            ucStatusRefresh(1);
        }

        private void ucStatus_Load(object sender, EventArgs e)
        {
            ucStatusRefresh();
        }

        private void ucStatusToolsClear()
        {
            pbStatusIcon.Image = pbStatusIcon.ErrorImage;
            lblCreateDate.Text = "";
            lblUpdateDate.Text = "";
            dtpEndDate.Value = DateTime.Now;
            tbName.Text = "";
            flpDuties.Controls.Clear();
        }

        private void ucStatusRefresh(int s = 0)
        {
            if (s == 1)
                ucStatusToolsClear();

            if (_Status != null)
            {

                if (String.IsNullOrEmpty(_Status.Icon))
                    pbStatusIcon.Image = pbStatusIcon.ErrorImage;
                else
                    pbStatusIcon.Load(_Status.Icon);
                lblCreateDate.Text = _Status.CreateDate != null ? _Status.CreateDate.ToString() : "";
                lblUpdateDate.Text = _Status.UpdateDate != null ? _Status.UpdateDate.ToString() : "";
                dtpEndDate.Value = _Status.EndDate != null ? _Status.EndDate.Value : DateTime.Now;
                tbName.Text = _Status.Name;
                foreach (Duty duty in _Status.Duties)
                {
                    ucDuty ucDuty = new ucDuty(duty.Id);
                    flpDuties.Controls.Add(ucDuty);
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
                    AutoSize = true,
                    Text = "+ Add Status",
                    Dock = DockStyle.Fill,
                };
                _btnAddStatus.Click += new EventHandler(addStatusClick);
                this.Controls.Add(_btnAddStatus);
            }
        }

        private void addStatusClick(object sender, EventArgs e)
        {
            this.Controls.Remove(_btnAddStatus);
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
                    ucStatusRefresh(1);
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
                    };
                    _efStatusDal.Add(_Status);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_Status.Duties.Count > 0)
                return;
            _efStatusDal.Delete(_Status);
            this.Dispose();
        }
    }
}
