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
            this.TR_DGV = new System.Windows.Forms.DataGridView();
            this.TR_Search_TB = new System.Windows.Forms.TextBox();
            this.Add_Trainer_Trainee_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TR_GB = new System.Windows.Forms.GroupBox();
            this.TR_trainee_BT = new System.Windows.Forms.Button();
            this.TR_trainer_BT = new System.Windows.Forms.Button();
            this.TR_Search_attributes_CB = new System.Windows.Forms.ComboBox();
            this.Exit = new System.Windows.Forms.Button();
            this.Minimize = new System.Windows.Forms.Button();
            this.Toppanel = new System.Windows.Forms.Panel();
            this.TCC_BT = new System.Windows.Forms.Button();
            this.TR_BT = new System.Windows.Forms.Button();
            this.TCC_Atributes_CB = new System.Windows.Forms.ComboBox();
            this.TCC_Search_TB = new System.Windows.Forms.TextBox();
            this.TopCouCat_Add_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TCC_Cat_LB = new System.Windows.Forms.ListBox();
            this.TCC_Course_LB = new System.Windows.Forms.ListBox();
            this.TCC_Topic_LB = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TCC_Cat_Description_Text_LB = new System.Windows.Forms.Label();
            this.TCC_Course_Description_Text_LB = new System.Windows.Forms.Label();
            this.TCC_Topic_Description_Text_LB = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TCC_GB = new System.Windows.Forms.GroupBox();
            this.No_result_LB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TR_DGV)).BeginInit();
            this.TR_GB.SuspendLayout();
            this.Toppanel.SuspendLayout();
            this.TCC_GB.SuspendLayout();
            this.SuspendLayout();
            // 
            // TR_DGV
            // 
            this.TR_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TR_DGV.Location = new System.Drawing.Point(6, 35);
            this.TR_DGV.Name = "TR_DGV";
            this.TR_DGV.RowHeadersWidth = 51;
            this.TR_DGV.RowTemplate.Height = 24;
            this.TR_DGV.Size = new System.Drawing.Size(753, 254);
            this.TR_DGV.TabIndex = 1;
            // 
            // TR_Search_TB
            // 
            this.TR_Search_TB.Location = new System.Drawing.Point(547, 295);
            this.TR_Search_TB.Name = "TR_Search_TB";
            this.TR_Search_TB.Size = new System.Drawing.Size(212, 27);
            this.TR_Search_TB.TabIndex = 11;
            this.TR_Search_TB.TextChanged += new System.EventHandler(this.TR_Search_TB_TextChanged);
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
            this.Add_Trainer_Trainee_button.Click += new System.EventHandler(this.Add_Trainer_Trainee_button_Click);
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
            this.TR_GB.Controls.Add(this.TR_trainee_BT);
            this.TR_GB.Controls.Add(this.TR_trainer_BT);
            this.TR_GB.Controls.Add(this.label2);
            this.TR_GB.Controls.Add(this.Add_Trainer_Trainee_button);
            this.TR_GB.Controls.Add(this.TR_Search_TB);
            this.TR_GB.Controls.Add(this.TR_DGV);
            this.TR_GB.Controls.Add(this.TR_Search_attributes_CB);
            this.TR_GB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TR_GB.ForeColor = System.Drawing.Color.Yellow;
            this.TR_GB.Location = new System.Drawing.Point(191, 56);
            this.TR_GB.Name = "TR_GB";
            this.TR_GB.Size = new System.Drawing.Size(790, 462);
            this.TR_GB.TabIndex = 0;
            this.TR_GB.TabStop = false;
            this.TR_GB.Text = "Trainee & Trainer";
            // 
            // TR_trainee_BT
            // 
            this.TR_trainee_BT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TR_trainee_BT.Location = new System.Drawing.Point(85, 304);
            this.TR_trainee_BT.Name = "TR_trainee_BT";
            this.TR_trainee_BT.Size = new System.Drawing.Size(95, 35);
            this.TR_trainee_BT.TabIndex = 20;
            this.TR_trainee_BT.Text = "Trainee";
            this.TR_trainee_BT.UseVisualStyleBackColor = true;
            this.TR_trainee_BT.Click += new System.EventHandler(this.TR_trainee_BT_Click);
            // 
            // TR_trainer_BT
            // 
            this.TR_trainer_BT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TR_trainer_BT.Location = new System.Drawing.Point(6, 304);
            this.TR_trainer_BT.Name = "TR_trainer_BT";
            this.TR_trainer_BT.Size = new System.Drawing.Size(95, 35);
            this.TR_trainer_BT.TabIndex = 20;
            this.TR_trainer_BT.Text = "Trainer";
            this.TR_trainer_BT.UseVisualStyleBackColor = true;
            this.TR_trainer_BT.Click += new System.EventHandler(this.TR_trainer_BT_Click);
            // 
            // TR_Search_attributes_CB
            // 
            this.TR_Search_attributes_CB.FormattingEnabled = true;
            this.TR_Search_attributes_CB.Items.AddRange(new object[] {
            ""});
            this.TR_Search_attributes_CB.Location = new System.Drawing.Point(416, 293);
            this.TR_Search_attributes_CB.Name = "TR_Search_attributes_CB";
            this.TR_Search_attributes_CB.Size = new System.Drawing.Size(125, 28);
            this.TR_Search_attributes_CB.TabIndex = 8;
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
            this.Toppanel.Size = new System.Drawing.Size(983, 50);
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
            // TCC_Atributes_CB
            // 
            this.TCC_Atributes_CB.FormattingEnabled = true;
            this.TCC_Atributes_CB.Items.AddRange(new object[] {
            "Category",
            "Course",
            "Topic"});
            this.TCC_Atributes_CB.Location = new System.Drawing.Point(655, 324);
            this.TCC_Atributes_CB.Name = "TCC_Atributes_CB";
            this.TCC_Atributes_CB.Size = new System.Drawing.Size(125, 28);
            this.TCC_Atributes_CB.TabIndex = 6;
            // 
            // TCC_Search_TB
            // 
            this.TCC_Search_TB.Location = new System.Drawing.Point(568, 376);
            this.TCC_Search_TB.Name = "TCC_Search_TB";
            this.TCC_Search_TB.Size = new System.Drawing.Size(212, 27);
            this.TCC_Search_TB.TabIndex = 7;
            this.TCC_Search_TB.TextChanged += new System.EventHandler(this.TCC_Search_TB_TextChanged);
            // 
            // TopCouCat_Add_button
            // 
            this.TopCouCat_Add_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TopCouCat_Add_button.Location = new System.Drawing.Point(673, 416);
            this.TopCouCat_Add_button.Name = "TopCouCat_Add_button";
            this.TopCouCat_Add_button.Size = new System.Drawing.Size(107, 31);
            this.TopCouCat_Add_button.TabIndex = 4;
            this.TopCouCat_Add_button.Text = "Add New...";
            this.TopCouCat_Add_button.UseVisualStyleBackColor = true;
            this.TopCouCat_Add_button.Click += new System.EventHandler(this.TopCouCat_Add_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(533, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Search";
            // 
            // TCC_Cat_LB
            // 
            this.TCC_Cat_LB.BackColor = System.Drawing.Color.White;
            this.TCC_Cat_LB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TCC_Cat_LB.FormattingEnabled = true;
            this.TCC_Cat_LB.HorizontalScrollbar = true;
            this.TCC_Cat_LB.ItemHeight = 20;
            this.TCC_Cat_LB.Location = new System.Drawing.Point(19, 55);
            this.TCC_Cat_LB.Name = "TCC_Cat_LB";
            this.TCC_Cat_LB.Size = new System.Drawing.Size(250, 260);
            this.TCC_Cat_LB.TabIndex = 9;
            this.TCC_Cat_LB.SelectedIndexChanged += new System.EventHandler(this.TCC_Cat_LB_SelectedIndexChanged);
            // 
            // TCC_Course_LB
            // 
            this.TCC_Course_LB.BackColor = System.Drawing.Color.White;
            this.TCC_Course_LB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TCC_Course_LB.FormattingEnabled = true;
            this.TCC_Course_LB.HorizontalScrollbar = true;
            this.TCC_Course_LB.ItemHeight = 20;
            this.TCC_Course_LB.Location = new System.Drawing.Point(274, 55);
            this.TCC_Course_LB.Name = "TCC_Course_LB";
            this.TCC_Course_LB.Size = new System.Drawing.Size(250, 260);
            this.TCC_Course_LB.TabIndex = 10;
            this.TCC_Course_LB.SelectedIndexChanged += new System.EventHandler(this.TCC_Course_LB_SelectedIndexChanged);
            // 
            // TCC_Topic_LB
            // 
            this.TCC_Topic_LB.BackColor = System.Drawing.Color.White;
            this.TCC_Topic_LB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TCC_Topic_LB.FormattingEnabled = true;
            this.TCC_Topic_LB.HorizontalScrollbar = true;
            this.TCC_Topic_LB.ItemHeight = 20;
            this.TCC_Topic_LB.Location = new System.Drawing.Point(530, 55);
            this.TCC_Topic_LB.Name = "TCC_Topic_LB";
            this.TCC_Topic_LB.Size = new System.Drawing.Size(250, 260);
            this.TCC_Topic_LB.TabIndex = 11;
            this.TCC_Topic_LB.SelectedIndexChanged += new System.EventHandler(this.TCC_Topic_LB_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Description:";
            // 
            // TCC_Cat_Description_Text_LB
            // 
            this.TCC_Cat_Description_Text_LB.AutoSize = true;
            this.TCC_Cat_Description_Text_LB.Location = new System.Drawing.Point(15, 360);
            this.TCC_Cat_Description_Text_LB.Name = "TCC_Cat_Description_Text_LB";
            this.TCC_Cat_Description_Text_LB.Size = new System.Drawing.Size(245, 20);
            this.TCC_Cat_Description_Text_LB.TabIndex = 14;
            this.TCC_Cat_Description_Text_LB.Text = "TCC_Cat_Description_Text_LB";
            // 
            // TCC_Course_Description_Text_LB
            // 
            this.TCC_Course_Description_Text_LB.AutoSize = true;
            this.TCC_Course_Description_Text_LB.Location = new System.Drawing.Point(15, 387);
            this.TCC_Course_Description_Text_LB.Name = "TCC_Course_Description_Text_LB";
            this.TCC_Course_Description_Text_LB.Size = new System.Drawing.Size(273, 20);
            this.TCC_Course_Description_Text_LB.TabIndex = 15;
            this.TCC_Course_Description_Text_LB.Text = "TCC_Course_Description_Text_LB";
            // 
            // TCC_Topic_Description_Text_LB
            // 
            this.TCC_Topic_Description_Text_LB.AutoSize = true;
            this.TCC_Topic_Description_Text_LB.Location = new System.Drawing.Point(15, 416);
            this.TCC_Topic_Description_Text_LB.Name = "TCC_Topic_Description_Text_LB";
            this.TCC_Topic_Description_Text_LB.Size = new System.Drawing.Size(260, 20);
            this.TCC_Topic_Description_Text_LB.TabIndex = 16;
            this.TCC_Topic_Description_Text_LB.Text = "TCC_Topic_Description_Text_LB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Categories";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(373, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Course";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(630, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Topic";
            // 
            // TCC_GB
            // 
            this.TCC_GB.Controls.Add(this.No_result_LB);
            this.TCC_GB.Controls.Add(this.label6);
            this.TCC_GB.Controls.Add(this.label5);
            this.TCC_GB.Controls.Add(this.label3);
            this.TCC_GB.Controls.Add(this.TCC_Topic_Description_Text_LB);
            this.TCC_GB.Controls.Add(this.TCC_Course_Description_Text_LB);
            this.TCC_GB.Controls.Add(this.TCC_Cat_Description_Text_LB);
            this.TCC_GB.Controls.Add(this.label4);
            this.TCC_GB.Controls.Add(this.TCC_Topic_LB);
            this.TCC_GB.Controls.Add(this.TCC_Course_LB);
            this.TCC_GB.Controls.Add(this.TCC_Cat_LB);
            this.TCC_GB.Controls.Add(this.label1);
            this.TCC_GB.Controls.Add(this.TopCouCat_Add_button);
            this.TCC_GB.Controls.Add(this.TCC_Search_TB);
            this.TCC_GB.Controls.Add(this.TCC_Atributes_CB);
            this.TCC_GB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TCC_GB.ForeColor = System.Drawing.Color.Yellow;
            this.TCC_GB.Location = new System.Drawing.Point(30, 267);
            this.TCC_GB.Name = "TCC_GB";
            this.TCC_GB.Size = new System.Drawing.Size(206, 78);
            this.TCC_GB.TabIndex = 20;
            this.TCC_GB.TabStop = false;
            this.TCC_GB.Text = "Topics, Courses & Categories";
            // 
            // No_result_LB
            // 
            this.No_result_LB.AutoSize = true;
            this.No_result_LB.ForeColor = System.Drawing.Color.Red;
            this.No_result_LB.Location = new System.Drawing.Point(364, 379);
            this.No_result_LB.Name = "No_result_LB";
            this.No_result_LB.Size = new System.Drawing.Size(81, 20);
            this.No_result_LB.TabIndex = 20;
            this.No_result_LB.Text = "No result.";
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(983, 527);
            this.Controls.Add(this.TCC_GB);
            this.Controls.Add(this.TR_BT);
            this.Controls.Add(this.TCC_BT);
            this.Controls.Add(this.Toppanel);
            this.Controls.Add(this.TR_GB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Staff";
            this.Text = "Staff";
            ((System.ComponentModel.ISupportInitialize)(this.TR_DGV)).EndInit();
            this.TR_GB.ResumeLayout(false);
            this.TR_GB.PerformLayout();
            this.Toppanel.ResumeLayout(false);
            this.TCC_GB.ResumeLayout(false);
            this.TCC_GB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView TR_DGV;
        private System.Windows.Forms.TextBox TR_Search_TB;
        private System.Windows.Forms.Button Add_Trainer_Trainee_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox TR_GB;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Minimize;
        private System.Windows.Forms.Panel Toppanel;
        private System.Windows.Forms.Button TCC_BT;
        private System.Windows.Forms.Button TR_BT;
        private System.Windows.Forms.Button TR_trainee_BT;
        private System.Windows.Forms.Button TR_trainer_BT;
        private System.Windows.Forms.ComboBox TR_Search_attributes_CB;
        private System.Windows.Forms.ComboBox TCC_Atributes_CB;
        private System.Windows.Forms.TextBox TCC_Search_TB;
        private System.Windows.Forms.Button TopCouCat_Add_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox TCC_Cat_LB;
        private System.Windows.Forms.ListBox TCC_Course_LB;
        private System.Windows.Forms.ListBox TCC_Topic_LB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label TCC_Cat_Description_Text_LB;
        private System.Windows.Forms.Label TCC_Course_Description_Text_LB;
        private System.Windows.Forms.Label TCC_Topic_Description_Text_LB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox TCC_GB;
        private System.Windows.Forms.Label No_result_LB;
    }
}