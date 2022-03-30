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
    public partial class frmDoIt : Form
    {
        public frmDoIt()
        {
            InitializeComponent();
        }

        private EfOrganizationDal _efOrganizationDal = new EfOrganizationDal();
        private EfProjectDal _efProjectDal = new EfProjectDal();
        private EfQuoteDal _efQuoteDal = new EfQuoteDal();

        private int intQuote = 0;
        private IList<Quote> quotes;
        public static User _signedUser = new User();
        public static Organization _selectedOrganization = new Organization();
        public static Project _selectedProject = new Project();

        private void frmDoIt_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void frmDoIt_Load(object sender, EventArgs e)
        {
            tsmiUserfullname.Text = _signedUser.Fullname;
            _selectedOrganization = (_efOrganizationDal.GetList(f => f.UserId == _signedUser.Id).FirstOrDefault() == null) ? null : _efOrganizationDal.GetList(f => f.UserId == _signedUser.Id).FirstOrDefault();
            if (_selectedOrganization != null)
            {
                _selectedProject = _efProjectDal.Get(f => f.OrganizationId == _selectedOrganization.Id);
            }

            forumRefresh();

            quotes = _efQuoteDal.GetList(f => f.UserId == _signedUser.Id);
            if (quotes.Count == 0)
            {
                quotes.Add(new Quote()
                {
                    Text = "Always",
                    UserId = _signedUser.Id,
                });
                quotes.Add(new Quote()
                {
                    Text = "Forever",
                    UserId = _signedUser.Id,
                });
                quotes.Add(new Quote()
                {
                    Text = "Ever",
                    UserId = _signedUser.Id,
                });
                quotes.Add(new Quote()
                {
                    Text = "Continually ",
                    UserId = _signedUser.Id,
                });
                foreach (var quote in quotes)
                {
                    _efQuoteDal.Add(quote);
                }
                tsmiQuoteDoIt.Text = quotes.ElementAt<Quote>(0).Text + " Do It";
            }
            else
            {
                tsmiQuoteDoIt.Text = quotes.ElementAt<Quote>(0).Text + " Do It";
            }
        }

        private void quotesRefresh()
        {
            quotes = _efQuoteDal.GetList(f => f.UserId == _signedUser.Id && (f.EndDate == null || f.EndDate > DateTime.Now));
            if (quotes.Count() != 0)
            {
                int countQuote = quotes.Count() - 1;
                if (intQuote > countQuote)
                {
                    intQuote = 0;
                }
                tsmiQuoteDoIt.Text = quotes.ElementAt<Quote>(intQuote).Text + " Do It";
                intQuote += 1;
            }
        }

        private void forumRefresh()
        {
            if (_selectedOrganization != null)
            {
                tsmiOrganizationname.Text = _selectedOrganization.Name;
                int pOId = (_selectedProject == null) ? 0 : _selectedProject.OrganizationId;
                if (pOId == _selectedOrganization.Id)
                {
                    tsmiProjectname.Text = _selectedProject.Name;
                }
                else
                {
                    definitionsCleanupRankClear("Project");
                    tsmiProjectname.Text = (_selectedOrganization.Projects.Count == 0) ? "Create Project" : "Select Project";
                }
            }
            else
            {
                tsmiOrganizationname.Text = (_selectedOrganization == null) ? "Create Organization" : "Select Organization";
            }

            if (_selectedProject.Statuses != null)
            {
                foreach (Status status in _selectedProject.Statuses)
                {
                    ucStatus ucStatus = new ucStatus(status.Id);
                    this.Controls.Add(ucStatus);
                    ucStatus.BringToFront();
                    ucStatus.Dock = DockStyle.Left;
                }
                ucStatus ucStatusCreate = new ucStatus();
                this.Controls.Add(ucStatusCreate);
                ucStatusCreate.BringToFront();
                ucStatusCreate.Dock = DockStyle.Left;
            }

            quotesRefresh();
        }

        private void definitionsCleanupRankClear(string level)
        {
            switch (level)
            {
                case "All":
                    _signedUser = null;
                    _selectedOrganization = null;
                    _selectedProject = null;
                    quotes.Clear();
                    break;
                case "Organization":
                    _selectedOrganization = null;
                    _selectedProject = null;
                    break;
                case "Project":
                    _selectedProject = null;
                    break;
                default:
                    break;
            }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            definitionsCleanupRankClear("All");
            this.Dispose();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmiQuoteDoIt_Click(object sender, EventArgs e)
        {
            quotesRefresh();
        }

        private void tsmiProjectname_Click(object sender, EventArgs e)
        {
            frmCProject frmCProject = new frmCProject();
            DialogResult dialogResult = frmCProject.ShowDialog();
            if (dialogResult == DialogResult.Cancel)
            {
                forumRefresh();
                frmCProject.Dispose();
            }
        }

        private void tsmiOrganizationname_Click(object sender, EventArgs e)
        {
            frmCOrganization frmCOrganization = new frmCOrganization();
            DialogResult dialogResult = frmCOrganization.ShowDialog();
            if (dialogResult == DialogResult.Cancel)
            {
                forumRefresh();
                frmCOrganization.Dispose();
            }
        }

        private void quotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCQuote frmCQuote = new frmCQuote();
            DialogResult dialogResult = frmCQuote.ShowDialog();
            if (dialogResult == DialogResult.Cancel)
            {
                forumRefresh();
                frmCQuote.Dispose();
            }
        }







        private void msg(string message, object sender, EventArgs e)
        {
            MessageBox.Show("Message: " + message + " | Object: " + sender.ToString() + " | EventArgs: " + e.ToString());
        }

        private void ucDuty1_Move(object sender, EventArgs e)
        {
            msg("ucDuty1", sender, e);
        }

        private void ucDuty1_MouseClick(object sender, MouseEventArgs e)
        {
            msg("ucDuty1", sender, e);
        }
    }
}