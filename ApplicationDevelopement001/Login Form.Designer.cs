namespace ApplicationDevelopement001
{
    partial class LoginUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginUI));
            this.Minimize = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Top_panel = new System.Windows.Forms.Panel();
            this.SlideTimer = new System.Windows.Forms.Timer(this.components);
            this.RoleGB = new System.Windows.Forms.GroupBox();
            this.Trainer_Description = new System.Windows.Forms.Label();
            this.Staff_Description = new System.Windows.Forms.Label();
            this.Admin_description = new System.Windows.Forms.Label();
            this.Trainer_role_button = new System.Windows.Forms.Button();
            this.Staff_role_button = new System.Windows.Forms.Button();
            this.Admin_role_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Back_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Username_TB = new System.Windows.Forms.TextBox();
            this.Password_TB = new System.Windows.Forms.TextBox();
            this.Login_BT = new System.Windows.Forms.Button();
            this.sliding_panel = new System.Windows.Forms.Panel();
            this.Top_panel.SuspendLayout();
            this.RoleGB.SuspendLayout();
            this.sliding_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Minimize
            // 
            this.Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimize.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Minimize.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Minimize.FlatAppearance.BorderSize = 0;
            this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize.Image = ((System.Drawing.Image)(resources.GetObject("Minimize.Image")));
            this.Minimize.Location = new System.Drawing.Point(551, 12);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(30, 30);
            this.Minimize.TabIndex = 0;
            this.Minimize.UseVisualStyleBackColor = true;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
            this.Exit.Location = new System.Drawing.Point(607, 12);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(30, 30);
            this.Exit.TabIndex = 1;
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Top_panel
            // 
            this.Top_panel.BackColor = System.Drawing.Color.Transparent;
            this.Top_panel.Controls.Add(this.Exit);
            this.Top_panel.Controls.Add(this.Minimize);
            this.Top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Top_panel.Location = new System.Drawing.Point(0, 0);
            this.Top_panel.Name = "Top_panel";
            this.Top_panel.Size = new System.Drawing.Size(649, 48);
            this.Top_panel.TabIndex = 2;
            this.Top_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Top_panel_MouseDown);
            this.Top_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Top_panel_MouseMove);
            this.Top_panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Top_panel_MouseUp);
            // 
            // SlideTimer
            // 
            this.SlideTimer.Interval = 30;
            this.SlideTimer.Tick += new System.EventHandler(this.SlideTimer_Tick);
            // 
            // RoleGB
            // 
            this.RoleGB.BackColor = System.Drawing.Color.Transparent;
            this.RoleGB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RoleGB.Controls.Add(this.Trainer_Description);
            this.RoleGB.Controls.Add(this.Staff_Description);
            this.RoleGB.Controls.Add(this.Admin_description);
            this.RoleGB.Controls.Add(this.Trainer_role_button);
            this.RoleGB.Controls.Add(this.Staff_role_button);
            this.RoleGB.Controls.Add(this.Admin_role_button);
            this.RoleGB.Controls.Add(this.label2);
            this.RoleGB.Controls.Add(this.label1);
            this.RoleGB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RoleGB.ForeColor = System.Drawing.Color.Black;
            this.RoleGB.Location = new System.Drawing.Point(267, 48);
            this.RoleGB.Name = "RoleGB";
            this.RoleGB.Size = new System.Drawing.Size(382, 589);
            this.RoleGB.TabIndex = 5;
            this.RoleGB.TabStop = false;
            // 
            // Trainer_Description
            // 
            this.Trainer_Description.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Trainer_Description.AutoSize = true;
            this.Trainer_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Trainer_Description.ForeColor = System.Drawing.Color.Yellow;
            this.Trainer_Description.Location = new System.Drawing.Point(122, 530);
            this.Trainer_Description.Name = "Trainer_Description";
            this.Trainer_Description.Size = new System.Drawing.Size(141, 20);
            this.Trainer_Description.TabIndex = 21;
            this.Trainer_Description.Text = "Sign In as Trainer";
            // 
            // Staff_Description
            // 
            this.Staff_Description.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Staff_Description.AutoSize = true;
            this.Staff_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Staff_Description.ForeColor = System.Drawing.Color.Yellow;
            this.Staff_Description.Location = new System.Drawing.Point(100, 419);
            this.Staff_Description.Name = "Staff_Description";
            this.Staff_Description.Size = new System.Drawing.Size(188, 20);
            this.Staff_Description.TabIndex = 22;
            this.Staff_Description.Text = "Sign in as Training Staff";
            // 
            // Admin_description
            // 
            this.Admin_description.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Admin_description.AutoSize = true;
            this.Admin_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Admin_description.ForeColor = System.Drawing.Color.Yellow;
            this.Admin_description.Location = new System.Drawing.Point(100, 297);
            this.Admin_description.Name = "Admin_description";
            this.Admin_description.Size = new System.Drawing.Size(188, 20);
            this.Admin_description.TabIndex = 20;
            this.Admin_description.Text = "Sign in as Administrator";
            // 
            // Trainer_role_button
            // 
            this.Trainer_role_button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Trainer_role_button.BackColor = System.Drawing.Color.Transparent;
            this.Trainer_role_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Trainer_role_button.BackgroundImage")));
            this.Trainer_role_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Trainer_role_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Trainer_role_button.FlatAppearance.BorderSize = 0;
            this.Trainer_role_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Trainer_role_button.Location = new System.Drawing.Point(162, 451);
            this.Trainer_role_button.Name = "Trainer_role_button";
            this.Trainer_role_button.Size = new System.Drawing.Size(65, 62);
            this.Trainer_role_button.TabIndex = 19;
            this.Trainer_role_button.UseVisualStyleBackColor = false;
            this.Trainer_role_button.Click += new System.EventHandler(this.Trainer_role_button_Click);
            // 
            // Staff_role_button
            // 
            this.Staff_role_button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Staff_role_button.BackColor = System.Drawing.Color.Transparent;
            this.Staff_role_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Staff_role_button.BackgroundImage")));
            this.Staff_role_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Staff_role_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Staff_role_button.FlatAppearance.BorderSize = 0;
            this.Staff_role_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Staff_role_button.Location = new System.Drawing.Point(162, 341);
            this.Staff_role_button.Name = "Staff_role_button";
            this.Staff_role_button.Size = new System.Drawing.Size(65, 62);
            this.Staff_role_button.TabIndex = 18;
            this.Staff_role_button.UseVisualStyleBackColor = false;
            this.Staff_role_button.Click += new System.EventHandler(this.Staff_role_button_Click);
            // 
            // Admin_role_button
            // 
            this.Admin_role_button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Admin_role_button.BackColor = System.Drawing.Color.Transparent;
            this.Admin_role_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Admin_role_button.BackgroundImage")));
            this.Admin_role_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Admin_role_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Admin_role_button.FlatAppearance.BorderSize = 0;
            this.Admin_role_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Admin_role_button.Location = new System.Drawing.Point(162, 232);
            this.Admin_role_button.Name = "Admin_role_button";
            this.Admin_role_button.Size = new System.Drawing.Size(65, 62);
            this.Admin_role_button.TabIndex = 17;
            this.Admin_role_button.UseVisualStyleBackColor = false;
            this.Admin_role_button.Click += new System.EventHandler(this.Admin_role_button_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(9, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(375, 81);
            this.label2.TabIndex = 16;
            this.label2.Text = "Hope you have a nice day\r\nPlease choose your role from bellow. \r\nThank you";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Open Sans", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(67, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 59);
            this.label1.TabIndex = 15;
            this.label1.Text = "WELCOME";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Back_button
            // 
            this.Back_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Back_button.BackgroundImage")));
            this.Back_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Back_button.FlatAppearance.BorderSize = 0;
            this.Back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back_button.Location = new System.Drawing.Point(18, 477);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(50, 50);
            this.Back_button.TabIndex = 1;
            this.Back_button.UseVisualStyleBackColor = true;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(13, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(371, 81);
            this.label3.TabIndex = 9;
            this.label3.Text = "Hope you have a nice day\r\nPlease fill in your information bellow\r\nThank you";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Username_TB
            // 
            this.Username_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Username_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Username_TB.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.Username_TB.Location = new System.Drawing.Point(55, 274);
            this.Username_TB.Name = "Username_TB";
            this.Username_TB.Size = new System.Drawing.Size(298, 27);
            this.Username_TB.TabIndex = 10;
            this.Username_TB.Text = "Username";
            this.Username_TB.Enter += new System.EventHandler(this.Username_TB_Enter);
            this.Username_TB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Username_TB_KeyDown);
            // 
            // Password_TB
            // 
            this.Password_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Password_TB.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.Password_TB.Location = new System.Drawing.Point(55, 337);
            this.Password_TB.Name = "Password_TB";
            this.Password_TB.Size = new System.Drawing.Size(298, 27);
            this.Password_TB.TabIndex = 11;
            this.Password_TB.Text = "Password";
            this.Password_TB.Enter += new System.EventHandler(this.Password_TB_Enter);
            this.Password_TB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Password_TB_KeyDown);
            // 
            // Login_BT
            // 
            this.Login_BT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Login_BT.FlatAppearance.BorderSize = 0;
            this.Login_BT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_BT.ForeColor = System.Drawing.Color.Yellow;
            this.Login_BT.Image = ((System.Drawing.Image)(resources.GetObject("Login_BT.Image")));
            this.Login_BT.Location = new System.Drawing.Point(167, 404);
            this.Login_BT.Name = "Login_BT";
            this.Login_BT.Size = new System.Drawing.Size(71, 72);
            this.Login_BT.TabIndex = 12;
            this.Login_BT.UseVisualStyleBackColor = true;
            this.Login_BT.Click += new System.EventHandler(this.Login_BT_Click);
            // 
            // sliding_panel
            // 
            this.sliding_panel.BackColor = System.Drawing.Color.Transparent;
            this.sliding_panel.Controls.Add(this.Login_BT);
            this.sliding_panel.Controls.Add(this.Password_TB);
            this.sliding_panel.Controls.Add(this.Username_TB);
            this.sliding_panel.Controls.Add(this.label3);
            this.sliding_panel.Controls.Add(this.Back_button);
            this.sliding_panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.sliding_panel.Location = new System.Drawing.Point(249, 48);
            this.sliding_panel.Name = "sliding_panel";
            this.sliding_panel.Size = new System.Drawing.Size(400, 601);
            this.sliding_panel.TabIndex = 3;
            // 
            // LoginUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(649, 649);
            this.Controls.Add(this.RoleGB);
            this.Controls.Add(this.sliding_panel);
            this.Controls.Add(this.Top_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Top_panel.ResumeLayout(false);
            this.RoleGB.ResumeLayout(false);
            this.RoleGB.PerformLayout();
            this.sliding_panel.ResumeLayout(false);
            this.sliding_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Minimize;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Panel Top_panel;
        private System.Windows.Forms.Timer SlideTimer;
        private System.Windows.Forms.GroupBox RoleGB;
        private System.Windows.Forms.Label Trainer_Description;
        private System.Windows.Forms.Label Staff_Description;
        private System.Windows.Forms.Label Admin_description;
        private System.Windows.Forms.Button Trainer_role_button;
        private System.Windows.Forms.Button Staff_role_button;
        private System.Windows.Forms.Button Admin_role_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Username_TB;
        private System.Windows.Forms.TextBox Password_TB;
        private System.Windows.Forms.Button Login_BT;
        private System.Windows.Forms.Panel sliding_panel;
    }
}

