namespace ApplicationDevelopement001
{
    partial class TopCoursCatPopup
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
            this.Role_LB = new System.Windows.Forms.ComboBox();
            this.Name_TB = new System.Windows.Forms.TextBox();
            this.Description_TB = new System.Windows.Forms.TextBox();
            this.Add_BT = new System.Windows.Forms.Button();
            this.Assign_CB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Assign_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ID_TB = new System.Windows.Forms.TextBox();
            this.Cancel_BT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Role_LB
            // 
            this.Role_LB.FormattingEnabled = true;
            this.Role_LB.Items.AddRange(new object[] {
            "Topic",
            "Course",
            "Category"});
            this.Role_LB.Location = new System.Drawing.Point(146, 32);
            this.Role_LB.Name = "Role_LB";
            this.Role_LB.Size = new System.Drawing.Size(203, 24);
            this.Role_LB.TabIndex = 0;
            this.Role_LB.SelectedIndexChanged += new System.EventHandler(this.Role_LB_SelectedIndexChanged);
            // 
            // Name_TB
            // 
            this.Name_TB.Location = new System.Drawing.Point(146, 90);
            this.Name_TB.Name = "Name_TB";
            this.Name_TB.Size = new System.Drawing.Size(227, 22);
            this.Name_TB.TabIndex = 1;
            // 
            // Description_TB
            // 
            this.Description_TB.Location = new System.Drawing.Point(146, 118);
            this.Description_TB.Name = "Description_TB";
            this.Description_TB.Size = new System.Drawing.Size(227, 22);
            this.Description_TB.TabIndex = 2;
            // 
            // Add_BT
            // 
            this.Add_BT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Add_BT.ForeColor = System.Drawing.Color.Yellow;
            this.Add_BT.Location = new System.Drawing.Point(158, 191);
            this.Add_BT.Name = "Add_BT";
            this.Add_BT.Size = new System.Drawing.Size(78, 33);
            this.Add_BT.TabIndex = 4;
            this.Add_BT.Text = "Add";
            this.Add_BT.UseVisualStyleBackColor = true;
            this.Add_BT.Click += new System.EventHandler(this.Add_BT_Click);
            // 
            // Assign_CB
            // 
            this.Assign_CB.FormattingEnabled = true;
            this.Assign_CB.Location = new System.Drawing.Point(146, 146);
            this.Assign_CB.Name = "Assign_CB";
            this.Assign_CB.Size = new System.Drawing.Size(203, 24);
            this.Assign_CB.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Create new:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(13, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(12, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Description";
            // 
            // Assign_label
            // 
            this.Assign_label.AutoSize = true;
            this.Assign_label.ForeColor = System.Drawing.Color.Yellow;
            this.Assign_label.Location = new System.Drawing.Point(13, 146);
            this.Assign_label.Name = "Assign_label";
            this.Assign_label.Size = new System.Drawing.Size(86, 17);
            this.Assign_label.TabIndex = 11;
            this.Assign_label.Text = "Assigned to:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(12, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "ID";
            // 
            // ID_TB
            // 
            this.ID_TB.Location = new System.Drawing.Point(146, 62);
            this.ID_TB.Name = "ID_TB";
            this.ID_TB.Size = new System.Drawing.Size(227, 22);
            this.ID_TB.TabIndex = 12;
            // 
            // Cancel_BT
            // 
            this.Cancel_BT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cancel_BT.ForeColor = System.Drawing.Color.Yellow;
            this.Cancel_BT.Location = new System.Drawing.Point(271, 191);
            this.Cancel_BT.Name = "Cancel_BT";
            this.Cancel_BT.Size = new System.Drawing.Size(78, 33);
            this.Cancel_BT.TabIndex = 4;
            this.Cancel_BT.Text = "Cancel";
            this.Cancel_BT.UseVisualStyleBackColor = true;
            this.Cancel_BT.Click += new System.EventHandler(this.Cancel_BT_Click);
            // 
            // TopCoursCatPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(444, 286);
            this.Controls.Add(this.ID_TB);
            this.Controls.Add(this.Assign_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Assign_CB);
            this.Controls.Add(this.Cancel_BT);
            this.Controls.Add(this.Add_BT);
            this.Controls.Add(this.Description_TB);
            this.Controls.Add(this.Name_TB);
            this.Controls.Add(this.Role_LB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TopCoursCatPopup";
            this.Text = "TopCoursCatPopup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Role_LB;
        private System.Windows.Forms.TextBox Name_TB;
        private System.Windows.Forms.TextBox Description_TB;
        private System.Windows.Forms.Button Add_BT;
        private System.Windows.Forms.ComboBox Assign_CB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Assign_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ID_TB;
        private System.Windows.Forms.Button Cancel_BT;
    }
}