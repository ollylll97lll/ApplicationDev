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
    public partial class Staff : Form
    {
        // variables for moving windows
        // indicate mouse trigger event     mov
        // indicate mouse axis              movX
        // indicate mouse axyl              movY
        private int mov, movX, movY;

        public Staff()
        {
            InitializeComponent();
            TR_GB.Hide();
            TCC_GB.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Toppanel_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void Toppanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void Toppanel_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void TCC_BT_Click(object sender, EventArgs e)
        {
            TCC_GB.Show();
            TCC_GB.BringToFront();
        }

        private void TR_BT_Click(object sender, EventArgs e)
        {
            TR_GB.Show();
            TR_GB.BringToFront();
        }

    }
}
