using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ApplicationDevelopement001
{

    public partial class LoginUI : Form
    {
        //initiate new Login Verify Class
        LoginVerification LV = new LoginVerification();
        //create role instance
        string Role;

        // variables for moving windows
        // indicate mouse trigger event     mov
        // indicate mouse axis              movX
        // indicate mouse axyl              movY
        private int mov, movX, movY;

        // variables for sliding panel
        private static int LoginPanelWidth;
        private bool IsHidden;

        public LoginUI()
        {
            InitializeComponent();
            RoleGB.BringToFront();
            LoginPanelWidth = sliding_panel.Width;
            sliding_panel.Width = 0;
            IsHidden = true;
        }

        //Close  Window
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Exit Window
        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Mouse down event take cursor location event triggered at top panel
        private void Top_panel_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        //Mouse move event take cursor location event triggered while moving
        private void Top_panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        //Mouse up event turn cursor mov attribute to false when event triggered
        private void Top_panel_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        //Sliding Panel
        private void SlideTimer_Tick(object sender, EventArgs s)
        {
            //open the panel
            if (IsHidden)
            {
                sliding_panel.Width += 20;
                if (sliding_panel.Width >= LoginPanelWidth)
                {
                    SlideTimer.Stop();
                    IsHidden = false;
                    
                }
                this.Refresh();
            }
            //hide the panel
            else
            {
                sliding_panel.Width -=  20;
                if (sliding_panel.Width <= 0)
                {
                    SlideTimer.Stop();
                    IsHidden = true;
                    
                }
                this.Refresh();
            }
        }

        //Back button
        private void Back_button_Click(object sender, EventArgs e)
        {
            SlideTimer.Start();
            Role = "";
            Username_TB.Text = "Username";
            Password_TB.Text = "Password";
            Username_TB.ForeColor = SystemColors.InactiveCaption;
            Password_TB.UseSystemPasswordChar = false;
            Password_TB.ForeColor = SystemColors.InactiveCaption;
        }
        
        //Login button
        private void Login_BT_Click(object sender, EventArgs e)
        {
            if (LV.AccountVerify(Username_TB.Text, Password_TB.Text, Role))
            {
                MessageBox.Show("Login Successfully");
                //Redirect to response UI based on selected role
                switch (Role)
                {
                    //user is Trainer
                    case "TRAINER":
                        //check if the form was created
                        Trainer TRexisting = Application.OpenForms.OfType<Trainer>().FirstOrDefault();
                        if (TRexisting != null)
                        {
                            //if there is created form, show it
                            TRexisting.Show();
                            TRexisting.Refresh();
                        }

                        else
                        {
                            //else create new form
                            Trainer trainer = new Trainer();
                            trainer.Show();
                        }
                        //turn Main form visibility off
                        this.Visible = false;
                        break;

                    //User is admin
                    case "ADMIN":
                        //check if the form was created
                        Administrator ADexisting = Application.OpenForms.OfType<Administrator>().FirstOrDefault();
                        if (ADexisting != null)
                        {
                            //if there is created form, show it
                            ADexisting.Show();
                            ADexisting.Refresh();
                        }

                        else
                        {
                            //else create new form
                            Administrator administrator = new Administrator();
                            administrator.Show();
                        }
                        //turn Main form visibility off
                        this.Visible = false;
                        break;

                    //user is staff
                    case "STAFF":
                        Staff STexisting = Application.OpenForms.OfType<Staff>().FirstOrDefault();
                        if(STexisting != null)
                        {
                            STexisting.Show();
                            STexisting.Refresh();
                        }
                        else
                        {
                            Staff staff = new Staff();
                            staff.Show();
                        }
                        break;
                }
                this.Hide();
            }
            else // Show message box indicate login failed
            {
                MessageBox.Show("Invalid input, check your username, password or role");
            }
        }

        //Username Textbox focus event
        private void Username_TB_Enter(object sender, EventArgs e)
        {
            Username_TB.Text = "";
            Username_TB.ForeColor = Color.Black;
        }

        //Password Texbox focus event
        private void Password_TB_Enter(object sender, EventArgs e)
        {
            Password_TB.Text = "";
            Password_TB.UseSystemPasswordChar = true;
            Password_TB.ForeColor = Color.Black;
        }

        //Trigger Login event at Username textbox
        private void Username_TB_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Login_BT.PerformClick();
            }
        }

        //Trigger Login event at Password textbox
        private void Password_TB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login_BT.PerformClick();
            }
        }

        //Trainer role choose button
        private void Trainer_role_button_Click(object sender, EventArgs e)
        {
            SlideTimer.Start();
            sliding_panel.BringToFront();
            Role = "TRAINER";
            //RoleTimer.Start();
        }

        //Admin role choose button
        private void Admin_role_button_Click(object sender, EventArgs e)
        {
            SlideTimer.Start();
            sliding_panel.BringToFront();
            Role = "ADMIN";
            //RoleTimer.Start();

        }

        //Staff role choose button
        private void Staff_role_button_Click(object sender, EventArgs e)
        {
            SlideTimer.Start();
            sliding_panel.BringToFront();
            Role = "STAFF";
            //RoleTimer.Start();
        }


    }
}
