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
    public partial class Administrator : Form
    {
        AdminCl admin = new AdminCl();
        public Administrator()
        {
            InitializeComponent();
            AccGridView.DataSource = admin.AccountTable();
            //Hide Update Button
            Up_BT.Hide();
        }

        private void ClearData()
        {
            User_TB.Text = Pass_TB.Text = Role_Cb.Text = ID_TB.Text = "";
        }
        private bool IsEmt()
        {
            if (User_TB.Text == "" || Pass_TB.Text == "" || Role_Cb.Text == "" || ID_TB.Text == "")
                return true;
            else return false;
        }
        private void Add_BT_Click(object sender, EventArgs e)
        {
            AdminCl admin = new AdminCl(User_TB.Text, Pass_TB.Text, Role_Cb.Text, ID_TB.Text);
            if (!IsEmt())
            {
                if (admin.Add() != 0)
                {
                    MessageBox.Show("Success");
                    ClearData();
                    AccGridView.DataSource = admin.AccountTable();
                }
                else
                {
                    MessageBox.Show("failed");
                    User_TB.Focus();
                }
            }
            else MessageBox.Show("Fill all input box");
        }

        private void AccGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Show Update button and hide add button
            Up_BT.Show();
            Add_BT.Hide();
            AdminCl admin = new AdminCl();

            //bring data to the textboxes
            string UpdateRow = AccGridView.CurrentRow.Cells["Acc_ID"].Value.ToString();
            Role_Cb.Text    = admin.UpdateData(UpdateRow, "Role");
            User_TB.Text    = admin.UpdateData(UpdateRow, "Username");
            Pass_TB.Text    = admin.UpdateData(UpdateRow, "Password");
            ID_TB.Text      = admin.UpdateData(UpdateRow, "Acc_ID");

        }

        private void Cancel_BT_Click(object sender, EventArgs e)
        {
            //Clear textbox
            ClearData();

            //Hide update button and show add button
            Up_BT.Hide();
            Add_BT.Show();
        }

        private void Up_BT_Click(object sender, EventArgs e)
        {

            string UpdateRow = AccGridView.CurrentRow.Cells["Acc_ID"].Value.ToString();
            AdminCl admin = new AdminCl(User_TB.Text, Pass_TB.Text, Role_Cb.Text, ID_TB.Text);
            admin.Update(UpdateRow);
            if (!IsEmt())
            {
                if (admin.Update(UpdateRow) != 0)
                {
                    MessageBox.Show("Success");
                    ClearData();
                    AccGridView.DataSource = admin.AccountTable();
                }
                else
                {
                    MessageBox.Show("failed");
                    User_TB.Focus();
                }
            }
            else MessageBox.Show("fill all input box to update oni-chan");
        }

        private void Delete_BT_Click(object sender, EventArgs e)
        {
            string UpdateRow = AccGridView.CurrentRow.Cells["Acc_ID"].Value.ToString();
            if (DialogResult.Yes == MessageBox.Show("Do You Want Delete ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                admin.Delete(UpdateRow);
                ClearData();
                AccGridView.DataSource = admin.AccountTable();
            }
        }
    }
}
