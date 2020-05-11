namespace ApplicationDevelopement001
{
    partial class LoginPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPanel));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Admin_role_button = new System.Windows.Forms.Button();
            this.Staff_role_button = new System.Windows.Forms.Button();
            this.Trainer_role_button = new System.Windows.Forms.Button();
            this.Admin_description = new System.Windows.Forms.Label();
            this.Staff_Description = new System.Windows.Forms.Label();
            this.Trainer_Description = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Open Sans", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(81, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(12, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(375, 81);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hope you have a nice day\r\nPlease choose your role from bellow. \r\nThank you";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Admin_role_button
            // 
            this.Admin_role_button.BackColor = System.Drawing.Color.Transparent;
            this.Admin_role_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Admin_role_button.BackgroundImage")));
            this.Admin_role_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Admin_role_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Admin_role_button.FlatAppearance.BorderSize = 0;
            this.Admin_role_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Admin_role_button.Location = new System.Drawing.Point(165, 273);
            this.Admin_role_button.Name = "Admin_role_button";
            this.Admin_role_button.Size = new System.Drawing.Size(65, 62);
            this.Admin_role_button.TabIndex = 2;
            this.Admin_role_button.UseVisualStyleBackColor = false;
            // 
            // Staff_role_button
            // 
            this.Staff_role_button.BackColor = System.Drawing.Color.Transparent;
            this.Staff_role_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Staff_role_button.BackgroundImage")));
            this.Staff_role_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Staff_role_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Staff_role_button.FlatAppearance.BorderSize = 0;
            this.Staff_role_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Staff_role_button.Location = new System.Drawing.Point(165, 382);
            this.Staff_role_button.Name = "Staff_role_button";
            this.Staff_role_button.Size = new System.Drawing.Size(65, 62);
            this.Staff_role_button.TabIndex = 3;
            this.Staff_role_button.UseVisualStyleBackColor = false;
            // 
            // Trainer_role_button
            // 
            this.Trainer_role_button.BackColor = System.Drawing.Color.Transparent;
            this.Trainer_role_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Trainer_role_button.BackgroundImage")));
            this.Trainer_role_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Trainer_role_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Trainer_role_button.FlatAppearance.BorderSize = 0;
            this.Trainer_role_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Trainer_role_button.Location = new System.Drawing.Point(165, 492);
            this.Trainer_role_button.Name = "Trainer_role_button";
            this.Trainer_role_button.Size = new System.Drawing.Size(65, 62);
            this.Trainer_role_button.TabIndex = 4;
            this.Trainer_role_button.UseVisualStyleBackColor = false;
            // 
            // Admin_description
            // 
            this.Admin_description.AutoSize = true;
            this.Admin_description.Location = new System.Drawing.Point(116, 338);
            this.Admin_description.Name = "Admin_description";
            this.Admin_description.Size = new System.Drawing.Size(157, 17);
            this.Admin_description.TabIndex = 5;
            this.Admin_description.Text = "Sign in as Administrator";
            // 
            // Staff_Description
            // 
            this.Staff_Description.AutoSize = true;
            this.Staff_Description.Location = new System.Drawing.Point(116, 460);
            this.Staff_Description.Name = "Staff_Description";
            this.Staff_Description.Size = new System.Drawing.Size(159, 17);
            this.Staff_Description.TabIndex = 6;
            this.Staff_Description.Text = "Sign in as Training Staff";
            // 
            // Trainer_Description
            // 
            this.Trainer_Description.AutoSize = true;
            this.Trainer_Description.Location = new System.Drawing.Point(138, 557);
            this.Trainer_Description.Name = "Trainer_Description";
            this.Trainer_Description.Size = new System.Drawing.Size(120, 17);
            this.Trainer_Description.TabIndex = 6;
            this.Trainer_Description.Text = "Sign In as Trainer";
            // 
            // LoginPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Trainer_Description);
            this.Controls.Add(this.Staff_Description);
            this.Controls.Add(this.Admin_description);
            this.Controls.Add(this.Trainer_role_button);
            this.Controls.Add(this.Staff_role_button);
            this.Controls.Add(this.Admin_role_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginPanel";
            this.Size = new System.Drawing.Size(400, 640);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Admin_role_button;
        private System.Windows.Forms.Button Staff_role_button;
        private System.Windows.Forms.Button Trainer_role_button;
        private System.Windows.Forms.Label Admin_description;
        private System.Windows.Forms.Label Staff_Description;
        private System.Windows.Forms.Label Trainer_Description;
    }
}
