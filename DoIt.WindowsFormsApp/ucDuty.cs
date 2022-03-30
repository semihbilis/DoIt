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
    public partial class ucDuty : UserControl
    {
        private Duty _Duty;
        private Button _btnAddDuty;
        private EfDutyDal _efDutyDal;
        public ucDuty(int DutyId=0)
        {
            InitializeComponent();
            if (DutyId!=0)
            {
                _efDutyDal = new EfDutyDal();
                this._Duty = _efDutyDal.Get(v => v.Id == DutyId);
                this.Name = "ucDuty" + _Duty.Id.ToString();
            }
        }

        public Duty GetDuty()
        {
            return _Duty;
        }
        public void SetDuty(Duty duty)
        {
            this._Duty = duty;
            ucDutyRefresh();
        }

        private void ucDuty_Load(object sender, EventArgs e)
        {
            if (_Duty != null)
            {
                cbTagColor.DataSource = typeof(Color).GetProperties()
                    .Where(x => x.PropertyType == typeof(Color))
                    .Select(x => x.GetValue(null)).ToList();

                ucDutyRefresh();
            }
            else
            {
                pnlMain.Visible = false;
                this.Size = new Size(275, 67);
                _btnAddDuty = new Button()
                {
                    Visible = true,
                    Text = "Add Duty",
                    TextAlign = ContentAlignment.MiddleCenter,
                    BackColor = Color.Transparent,
                    ForeColor = Color.Black,
                    Dock = DockStyle.Fill
                };
                _btnAddDuty.Click += new EventHandler(addDutyClick);
                this.Controls.Add(_btnAddDuty);
            }
        }

        private void addDutyClick(object sender, EventArgs e)
        {
            this.Controls.Remove(_btnAddDuty);
            this.Size = new Size(275, 241);
            btnSaveDuty.Visible = true;
            pnlMain.Visible = true;
        }

        private void ucDutyRefresh()
        {
            cbStatusName.Items.AddRange(_Duty.Status.Project.Statuses.ToArray());
            cbStatusName.DisplayMember = "Name";
            cbStatusName.SelectedItem = _Duty.Status;

            EfUserDal efUserDal = new EfUserDal();
            ICollection<User> users = efUserDal.GetList();
            foreach (var user in users)
            {
                cbAssignee.Items.Insert(user.Id, user);
            }
            tbText.Text = _Duty.Text;
            cbPriority.SelectedIndex = _Duty.Priority;
            cbAssignee.SelectedIndex = _Duty.AssigneeId == null ? 0 : _Duty.AssigneeId.Value;
            cbAssignee.DisplayMember = "Fullname";
            dtpEnddate.Value = (_Duty.EndDate == null) ? DateTime.Now : DateTime.Parse(_Duty.EndDate.ToString());
            lbTags.Items.AddRange(_Duty.Tags.ToArray());
        }

        private void lbTags_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            ListBox listBox = sender as ListBox;
            Tag tag = listBox.Items[e.Index] as Tag;
            Color tagColor = (tag.Color == null) ? Color.Black : Color.FromName(tag.Color);
            bool selected = ((e.State & DrawItemState.Selected) == DrawItemState.Selected);
            //tagColor = (selected) ? Color.FromKnownColor(KnownColor.Highlight) : tagColor;
            e.Graphics.FillRectangle(new SolidBrush(tagColor), e.Bounds.X+3, e.Bounds.Y+3, 21, 15);
            StringFormat stringFormat = new StringFormat()
            {
                Alignment = StringAlignment.Near,
                LineAlignment = StringAlignment.Center,
            };
            e.Graphics.DrawString(tag.Text, e.Font, Brushes.Black, e.Bounds.X+27,e.Bounds.Y+10, stringFormat);
            Rectangle rect = new Rectangle()
            {
                X = e.Bounds.X + 3,
                Y = e.Bounds.Y + 3,
                Width = e.Bounds.Width - 6,
                Height = e.Bounds.Height - 6
            };
            Pen penColor = (tagColor.Name == "Red") ? Pens.Blue : Pens.Red;
            if (selected)
                e.Graphics.DrawRectangle(penColor, e.Bounds.X+3, e.Bounds.Y+3, 21, 15);
            else
                e.Graphics.DrawRectangle(Pens.Transparent, rect);
            e.DrawFocusRectangle();
        }

        private void cbTagColor_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            if (e.Index >= 0)
            {
                string txt = cbTagColor.GetItemText(cbTagColor.Items[e.Index]);
                Color color = (Color)cbTagColor.Items[e.Index];
                Rectangle r1 = new Rectangle(e.Bounds.Left + 1, e.Bounds.Top + 1,
                    2 * (e.Bounds.Height - 2), e.Bounds.Height - 2);
                Rectangle r2 = Rectangle.FromLTRB(r1.Right + 2, e.Bounds.Top,
                    e.Bounds.Right, e.Bounds.Bottom);
                using (SolidBrush b = new SolidBrush(color))
                    e.Graphics.FillRectangle(b, r1);
                e.Graphics.DrawRectangle(Pens.Black, r1);
                TextRenderer.DrawText(e.Graphics, txt, cbTagColor.Font, r2,
                    cbTagColor.ForeColor, TextFormatFlags.Left | TextFormatFlags.VerticalCenter);
            }
        }

        private void lbTags_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tag tag = ((ListBox)sender).SelectedItem as Tag;
            if (tag != null)
            {
                tbTagText.Text = tag.Text;
                cbTagColor.SelectedItem = Color.FromName(tag.Color);
            }
            else
            {
                tbTagText.Text = "";
                cbTagColor.SelectedIndex = 0;
            }
        }

        private void btnTagSaveUpdate_Click(object sender, EventArgs e)
        {
            if (tbTagText.Text == ((Tag)lbTags.SelectedItem).Text)
            {
                //Update proccess.
            }
            else
            {
                //Added proccess.
            }
        }

        private void btnSaveDuty_Click(object sender, EventArgs e)
        {
            //Duty saved proccess.
        }

        private void btnTagDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
