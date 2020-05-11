namespace ApplicationDevelopement001
{
    partial class Staff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staff));
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Add_Trainer_Trainee_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TR_GB = new System.Windows.Forms.GroupBox();
            this.Exit = new System.Windows.Forms.Button();
            this.Minimize = new System.Windows.Forms.Button();
            this.Toppanel = new System.Windows.Forms.Panel();
            this.TCC_BT = new System.Windows.Forms.Button();
            this.TR_BT = new System.Windows.Forms.Button();
            this.TCC_GB = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.TopCouCat_Add_button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.TR_GB.SuspendLayout();
            this.Toppanel.SuspendLayout();
            this.TCC_GB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(416, 293);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(125, 28);
            this.comboBox2.TabIndex = 8;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 35);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(753, 254);
            this.dataGridView2.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(547, 295);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(212, 27);
            this.textBox2.TabIndex = 11;
            // 
            // Add_Trainer_Trainee_button
            // 
            this.Add_Trainer_Trainee_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Add_Trainer_Trainee_button.Location = new System.Drawing.Point(602, 347);
            this.Add_Trainer_Trainee_button.Name = "Add_Trainer_Trainee_button";
            this.Add_Trainer_Trainee_button.Size = new System.Drawing.Size(156, 31);
            this.Add_Trainer_Trainee_button.TabIndex = 5;
            this.Add_Trainer_Trainee_button.Text = "Add New...";
            this.Add_Trainer_Trainee_button.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Search";
            // 
            // TR_GB
            // 
            this.TR_GB.Controls.Add(this.label2);
            this.TR_GB.Controls.Add(this.Add_Trainer_Trainee_button);
            this.TR_GB.Controls.Add(this.textBox2);
            this.TR_GB.Controls.Add(this.dataGridView2);
            this.TR_GB.Controls.Add(this.comboBox2);
            this.TR_GB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TR_GB.ForeColor = System.Drawing.Color.Yellow;
            this.TR_GB.Location = new System.Drawing.Point(191, 56);
            this.TR_GB.Name = "TR_GB";
            this.TR_GB.Size = new System.Drawing.Size(778, 418);
            this.TR_GB.TabIndex = 0;
            this.TR_GB.TabStop = false;
            this.TR_GB.Text = "Trainee & Trainer";
            // 
            // Exit
            // 
            this.Exit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
            this.Exit.Location = new System.Drawing.Point(939, 12);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(30, 30);
            this.Exit.TabIndex = 15;
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Minimize
            // 
            this.Minimize.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Minimize.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Minimize.FlatAppearance.BorderSize = 0;
            this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize.Image = ((System.Drawing.Image)(resources.GetObject("Minimize.Image")));
            this.Minimize.Location = new System.Drawing.Point(883, 12);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(30, 30);
            this.Minimize.TabIndex = 14;
            this.Minimize.UseVisualStyleBackColor = true;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Toppanel
            // 
            this.Toppanel.BackColor = System.Drawing.Color.Transparent;
            this.Toppanel.Controls.Add(this.Exit);
            this.Toppanel.Controls.Add(this.Minimize);
            this.Toppanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Toppanel.Location = new System.Drawing.Point(0, 0);
            this.Toppanel.Name = "Toppanel";
            this.Toppanel.Size = new System.Drawing.Size(981, 50);
            this.Toppanel.TabIndex = 16;
            this.Toppanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Toppanel_MouseDown);
            this.Toppanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Toppanel_MouseMove);
            this.Toppanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Toppanel_MouseUp);
            // 
            // TCC_BT
            // 
            this.TCC_BT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TCC_BT.ForeColor = System.Drawing.Color.Yellow;
            this.TCC_BT.Location = new System.Drawing.Point(30, 111);
            this.TCC_BT.Name = "TCC_BT";
            this.TCC_BT.Size = new System.Drawing.Size(146, 61);
            this.TCC_BT.TabIndex = 17;
            this.TCC_BT.Text = "Manage Topics, Courses and others";
            this.TCC_BT.UseVisualStyleBackColor = true;
            this.TCC_BT.Click += new System.EventHandler(this.TCC_BT_Click);
            // 
            // TR_BT
            // 
            this.TR_BT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TR_BT.ForeColor = System.Drawing.Color.Yellow;
            this.TR_BT.Location = new System.Drawing.Point(30, 178);
            this.TR_BT.Name = "TR_BT";
            this.TR_BT.Size = new System.Drawing.Size(146, 61);
            this.TR_BT.TabIndex = 18;
            this.TR_BT.Text = "Manage \r\nTrainer and Trainee";
            this.TR_BT.UseVisualStyleBackColor = true;
            this.TR_BT.Click += new System.EventHandler(this.TR_BT_Click);
            // 
            // TCC_GB
            // 
            this.TCC_GB.Controls.Add(this.label1);
            this.TCC_GB.Controls.Add(this.dataGridView4);
            this.TCC_GB.Controls.Add(this.TopCouCat_Add_button);
            this.TCC_GB.Controls.Add(this.textBox1);
            this.TCC_GB.Controls.Add(this.comboBox1);
            this.TCC_GB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TCC_GB.ForeColor = System.Drawing.Color.Yellow;
            this.TCC_GB.Location = new System.Drawing.Point(191, 56);
            this.TCC_GB.Name = "TCC_GB";
            this.TCC_GB.Size = new System.Drawing.Size(790, 428);
            this.TCC_GB.TabIndex = 19;
            this.TCC_GB.TabStop = false;
            this.TCC_GB.Text = "Topics, Courses & Categories";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Search";
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(6, 35);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(762, 254);
            this.dataGridView4.TabIndex = 1;
            // 
            // TopCouCat_Add_button
            // 
            this.TopCouCat_Add_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TopCouCat_Add_button.Location = new System.Drawing.Point(661, 350);
            this.TopCouCat_Add_button.Name = "TopCouCat_Add_button";
            this.TopCouCat_Add_button.Size = new System.Drawing.Size(107, 31);
            this.TopCouCat_Add_button.TabIndex = 4;
            this.TopCouCat_Add_button.Text = "Add New...";
            this.TopCouCat_Add_button.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(556, 295);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 27);
            this.textBox1.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(425, 295);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(125, 28);
            this.comboBox1.TabIndex = 6;
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(981, 486);
            this.Controls.Add(this.TCC_GB);
            this.Controls.Add(this.TR_BT);
            this.Controls.Add(this.TCC_BT);
            this.Controls.Add(this.Toppanel);
            this.Controls.Add(this.TR_GB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Staff";
            this.Text = "Staff";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.TR_GB.ResumeLayout(false);
            this.TR_GB.PerformLayout();
            this.Toppanel.ResumeLayout(false);
            this.TCC_GB.ResumeLayout(false);
            this.TCC_GB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Add_Trainer_Trainee_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox TR_GB;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Minimize;
        private System.Windows.Forms.Panel Toppanel;
        private System.Windows.Forms.Button TCC_BT;
        private System.Windows.Forms.Button TR_BT;
        private System.Windows.Forms.GroupBox TCC_GB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Button TopCouCat_Add_button;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}