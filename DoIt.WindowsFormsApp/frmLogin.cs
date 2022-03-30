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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnSingin_Click(object sender, EventArgs e)
        {
            EfUserDal userDal = new EfUserDal();
            string lEmail = tbxEmail.Text;
            string lPassword = tbxPassword.Text;
            User user = userDal.Get(f => f.Email == lEmail && f.Password == lPassword);
            if (user != null)
            {
                frmDoIt frmDoIt = new frmDoIt();
                frmDoIt._signedUser = user;
                frmDoIt.Show();
                this.Hide();
            }
            else
            {
                tbxEmail.Clear();
                tbxPassword.Clear();
            }
        }

        private void btnJoinnow_Click(object sender, EventArgs e)
        {
            JoinnowClear();
        }

        private void JoinnowClear()
        {
            pnlRegister.Visible = true;
            this.Width = 200;
            this.Height = 280;
            tbxREmail.Text = tbxEmail.Text;
            tbxRPassword.Text = tbxPassword.Text;

            tbxEmail.Clear();
            tbxPassword.Clear();
        }

        private void btnRRegister_Click(object sender, EventArgs e)
        {
            EfUserDal efUserDal = new EfUserDal();
            User user = new User()
            {
                Email=tbxREmail.Text,
                Name=tbxRName.Text,
                Surname=tbxRSurname.Text,
                Password=tbxRPassword.Text
            };
            efUserDal.Add(user);

            RegisterClear();
        }

        private void RegisterClear()
        {
            pnlRegister.Visible = false;
            this.Width = 200;
            this.Height = 140;
            tbxEmail.Text = tbxREmail.Text;
            tbxPassword.Text = tbxRPassword.Text;

            tbxREmail.Clear();
            tbxRName.Clear();
            tbxRSurname.Clear();
            tbxRPassword.Clear();
        }
    }
}