namespace ApplicationDevelopement001
{
    partial class Administrator
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
            this.AccGridView = new System.Windows.Forms.DataGridView();
            this.Add_BT = new System.Windows.Forms.Button();
            this.Delete_BT = new System.Windows.Forms.Button();
            this.Role_Cb = new System.Windows.Forms.ComboBox();
            this.User_TB = new System.Windows.Forms.TextBox();
            this.Pass_TB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ID_TB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Cancel_BT = new System.Windows.Forms.Button();
            this.Up_BT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AccGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AccGridView
            // 
            this.AccGridView.AllowUserToAddRows = false;
            this.AccGridView.AllowUserToDeleteRows = false;
            this.AccGridView.AllowUserToOrderColumns = true;
            this.AccGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AccGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AccGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AccGridView.Location = new System.Drawing.Point(0, 224);
            this.AccGridView.MultiSelect = false;
            this.AccGridView.Name = "AccGridView";
            this.AccGridView.ReadOnly = true;
            this.AccGridView.RowHeadersWidth = 51;
            this.AccGridView.RowTemplate.Height = 24;
            this.AccGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AccGridView.Size = new System.Drawing.Size(406, 232);
            this.AccGridView.TabIndex = 22;
            this.AccGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AccGridView_CellDoubleClick);
            // 
            // Add_BT
            // 
            this.Add_BT.Location = new System.Drawing.Point(46, 172);
            this.Add_BT.Name = "Add_BT";
            this.Add_BT.Size = new System.Drawing.Size(107, 34);
            this.Add_BT.TabIndex = 1;
            this.Add_BT.Text = "add";
            this.Add_BT.UseVisualStyleBackColor = true;
            this.Add_BT.Click += new System.EventHandler(this.Add_BT_Click);
            // 
            // Delete_BT
            // 
            this.Delete_BT.Location = new System.Drawing.Point(272, 172);
            this.Delete_BT.Name = "Delete_BT";
            this.Delete_BT.Size = new System.Drawing.Size(107, 34);
            this.Delete_BT.TabIndex = 2;
            this.Delete_BT.Text = "delete";
            this.Delete_BT.UseVisualStyleBackColor = true;
            this.Delete_BT.Click += new System.EventHandler(this.Delete_BT_Click);
            // 
            // Role_Cb
            // 
            this.Role_Cb.FormattingEnabled = true;
            this.Role_Cb.Items.AddRange(new object[] {
            "STAFF",
            "TRAINER"});
            this.Role_Cb.Location = new System.Drawing.Point(159, 26);
            this.Role_Cb.Name = "Role_Cb";
            this.Role_Cb.Size = new System.Drawing.Size(182, 24);
            this.Role_Cb.TabIndex = 3;
            // 
            // User_TB
            // 
            this.User_TB.Location = new System.Drawing.Point(159, 56);
            this.User_TB.Name = "User_TB";
            this.User_TB.Size = new System.Drawing.Size(220, 22);
            this.User_TB.TabIndex = 4;
            // 
            // Pass_TB
            // 
            this.Pass_TB.Location = new System.Drawing.Point(159, 84);
            this.Pass_TB.Name = "Pass_TB";
            this.Pass_TB.Size = new System.Drawing.Size(220, 22);
            this.Pass_TB.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Account Role";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Password";
            // 
            // ID_TB
            // 
            this.ID_TB.Location = new System.Drawing.Point(159, 112);
            this.ID_TB.Name = "ID_TB";
            this.ID_TB.Size = new System.Drawing.Size(220, 22);
            this.ID_TB.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "ID";
            // 
            // Cancel_BT
            // 
            this.Cancel_BT.Location = new System.Drawing.Point(159, 172);
            this.Cancel_BT.Name = "Cancel_BT";
            this.Cancel_BT.Size = new System.Drawing.Size(107, 34);
            this.Cancel_BT.TabIndex = 1;
            this.Cancel_BT.Text = "Cancel";
            this.Cancel_BT.UseVisualStyleBackColor = true;
            this.Cancel_BT.Click += new System.EventHandler(this.Cancel_BT_Click);
            // 
            // Up_BT
            // 
            this.Up_BT.Location = new System.Drawing.Point(46, 172);
            this.Up_BT.Name = "Up_BT";
            this.Up_BT.Size = new System.Drawing.Size(107, 34);
            this.Up_BT.TabIndex = 1;
            this.Up_BT.Text = "Update";
            this.Up_BT.UseVisualStyleBackColor = true;
            this.Up_BT.Click += new System.EventHandler(this.Up_BT_Click);
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 456);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ID_TB);
            this.Controls.Add(this.Pass_TB);
            this.Controls.Add(this.User_TB);
            this.Controls.Add(this.Role_Cb);
            this.Controls.Add(this.Delete_BT);
            this.Controls.Add(this.Cancel_BT);
            this.Controls.Add(this.Up_BT);
            this.Controls.Add(this.Add_BT);
            this.Controls.Add(this.AccGridView);
            this.Name = "Administrator";
            this.Text = "Administrator_Form";
            ((System.ComponentModel.ISupportInitialize)(this.AccGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AccGridView;
        private System.Windows.Forms.Button Add_BT;
        private System.Windows.Forms.Button Delete_BT;
        private System.Windows.Forms.ComboBox Role_Cb;
        private System.Windows.Forms.TextBox User_TB;
        private System.Windows.Forms.TextBox Pass_TB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ID_TB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Cancel_BT;
        private System.Windows.Forms.Button Up_BT;
    }
}