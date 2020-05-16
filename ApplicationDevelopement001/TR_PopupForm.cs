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
    public partial class TR_PopupForm : Form
    {
        public TR_PopupForm()
        {
            InitializeComponent();
            Trainer_GB.Hide();
            Trainee_GB.BringToFront();
            TRCl tr_Class = new TRCl();
            TRAINEECOURSEID.DataSource = tr_Class.IDretrieve();
            if(Staff.Action.ToString() == "Add")
            {
                Update_BT.Hide();
                Delete_BT.Hide();
            }
        }

        private bool trainerIsEmt()
        {
            if (TrainerID_TB.Text == "" || TrainerName_TB.Text == "" || Trainer_edu_TB.Text == "" || Topic_ID_CB.Text == "" || Type_CB.Text == "" || Location_TB.Text == "" || Email_TB.Text == "" || Tel_TB.Text == "")
            {
                return true;
            }
            else return false;
        }

        private bool traineeIsEmt()
        {
            if (TRAINEEID.Text == "" || TRAINEENAME.Text == "" || TRAINEEEDU.Text == "" || TRAINEEPROG.Text == "" || TRAINEETOEIC.Text == "" || TRAINEEEXP.Text == "" || TRAINEEDEPT.Text == "" || TRAINEECOURSEID.Text == "")
            {
                return true;
            }
            else return false;
        }

        private void ClearTB()
        {
            TrainerID_TB.Text = TrainerName_TB.Text = Trainer_edu_TB.Text = Topic_ID_CB.Text = Type_CB.Text = Location_TB.Text = Email_TB.Text = Tel_TB.Text = "";
        }
        private void Add_BT_Click(object sender, EventArgs e)
        {

            if (traineeIsEmt())
            {
                MessageBox.Show("Provide information at unassigned box(es)");
                TrainerID_TB.Focus();
            }
            else if (TRAINEEID.Text.Substring(0, 1) == "0")
            {
                MessageBox.Show("invalid ID input");
                TrainerID_TB.Focus();
            }
            else
            {
                    TRCl trainee = new TRCl(TRAINEEID.Text.ToString(),TRAINEENAME.Text.ToString(), TRAINEEEDU.Text.ToString(), TRAINEEDOB.Value.Date,TRAINEEPROG.Text.ToString(), TRAINEETOEIC.Text.ToString(), TRAINEEEXP.Text.ToString(), TRAINEEDEPT.Text.ToString(), TRAINEECOURSEID.Text.ToString());
                    if (trainee.Add() != 0)
                    {
                        MessageBox.Show("Success");
                        ClearTB();
                        this.Close();
                    }
                    else
                        MessageBox.Show("Assign the god damn Course beyotch");
            }
        }

        private void Cancel_BT_Click(object sender, EventArgs e)
        {
            ClearTB();
            this.Close();
        }
    }
}
