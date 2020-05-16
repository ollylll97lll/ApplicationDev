using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationDevelopement001
{
    public partial class TopCoursCatPopup : Form
    {

        public TopCoursCatPopup()
        {
            InitializeComponent();
            Assign_CB.Hide();
            Assign_label.Hide();
        }

        private void ClearTB()
        {
            ID_TB.Text = Name_TB.Text = Description_TB.Text = "";

        }

        private bool IsEmt()
        {
            if (Role_LB.Text == "" || ID_TB.Text == "" || Name_TB.Text == "" || Description_TB.Text == "")
            {
                return true;
            }
            else return false;
        }

        private void Add_BT_Click(object sender, EventArgs e)
        {

            if (IsEmt())
            {
                MessageBox.Show("Provide information at unassigned box(es)");
                ID_TB.Focus();
            }
            else if (ID_TB.Text.Substring(0, 1) == "0")
            {
                MessageBox.Show("invalid ID input");
                ID_TB.Focus();
            }
            else
            {
                TCC_PopupCl Popup = new TCC_PopupCl(ID_TB.Text, Name_TB.Text, Description_TB.Text, Assign_CB.Text);

                if (Popup.Add(Role_LB.Text.ToString()) != 0)
                {
                    MessageBox.Show("Success");
                    ClearTB();
                    this.Close();
                }
                else
                    MessageBox.Show("Assign the god damn Course beyotch");
            }
        }

        private void Role_LB_SelectedIndexChanged(object sender, EventArgs e)
        {

            StaffClass SC = new StaffClass();
            if (Role_LB.Text != null && Role_LB.Text.ToString() != "Category")
            {
                Assign_CB.Show();
                Assign_label.Show();
                Name_TB.ReadOnly = false;
                Description_TB.ReadOnly = false;
                ID_TB.ReadOnly = false;
                Assign_CB.Enabled = true;
            }
            else
            {
                Assign_CB.Hide();
                Assign_label.Hide();
            }
            string Role = Role_LB.Text.ToString();
            switch (Role)
            {
                case "Category":
                    break;
                case "Course":
                    Assign_CB.DataSource = SC.CatNameRec();
                    break;
                case "Topic":
                    Assign_CB.DataSource = SC.CourseNameRec();
                    break;
            }
        }

        private void Cancel_BT_Click(object sender, EventArgs e)
        {
            ClearTB();
            this.Close();
            Staff STexisting = Application.OpenForms.OfType<Staff>().FirstOrDefault();
            if (STexisting != null)
            {
                STexisting.Show();
                STexisting.Refresh();
            }
            else
            {
                Staff staff = new Staff();
                staff.Show();
            }
        }

        private void Update_BT_Click(object sender, EventArgs e)
        {
            if (IsEmt())
            {
                MessageBox.Show("Provide information at unassigned box(es)");
                ID_TB.Focus();
            }
            else if (ID_TB.Text.Substring(0, 1) == "0")
            {
                MessageBox.Show("invalid ID input");
                ID_TB.Focus();
            }
            else
            {
                TCC_PopupCl Popup = new TCC_PopupCl(ID_TB.Text, Name_TB.Text, Description_TB.Text, Assign_CB.Text);

                if (Popup.Add(Role_LB.Text.ToString()) != 0)
                {
                    MessageBox.Show("Success");
                    ClearTB();
                    this.Close();
                }
                else
                    MessageBox.Show("Assign the god damn Course beyotch");
            }
        } 
    }
    
}
