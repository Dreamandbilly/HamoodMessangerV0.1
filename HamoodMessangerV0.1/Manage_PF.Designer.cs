namespace HamoodMessangerV0._1
{
    partial class Manage_PF
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
            label1 = new Label();
            MyNameTextBox = new TextBox();
            MyPortTextBox = new TextBox();
            AddContact_Port = new Label();
            AddContact_Name = new Label();
            Save_MngPf = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Save_MngPf).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.ForestGreen;
            label1.Location = new Point(64, 30);
            label1.Name = "label1";
            label1.Size = new Size(163, 30);
            label1.TabIndex = 1;
            label1.Text = "Manage Profile";
            // 
            // MyNameTextBox
            // 
            MyNameTextBox.Location = new Point(96, 134);
            MyNameTextBox.Name = "MyNameTextBox";
            MyNameTextBox.Size = new Size(162, 23);
            MyNameTextBox.TabIndex = 10;
            // 
            // MyPortTextBox
            // 
            MyPortTextBox.Location = new Point(96, 191);
            MyPortTextBox.Name = "MyPortTextBox";
            MyPortTextBox.Size = new Size(162, 23);
            MyPortTextBox.TabIndex = 11;
            // 
            // AddContact_Port
            // 
            AddContact_Port.AutoSize = true;
            AddContact_Port.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddContact_Port.ForeColor = Color.Red;
            AddContact_Port.Location = new Point(34, 192);
            AddContact_Port.Name = "AddContact_Port";
            AddContact_Port.Size = new Size(42, 17);
            AddContact_Port.TabIndex = 14;
            AddContact_Port.Text = "Port :";
            // 
            // AddContact_Name
            // 
            AddContact_Name.AutoSize = true;
            AddContact_Name.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddContact_Name.ForeColor = Color.Black;
            AddContact_Name.Location = new Point(34, 135);
            AddContact_Name.Name = "AddContact_Name";
            AddContact_Name.Size = new Size(56, 17);
            AddContact_Name.TabIndex = 15;
            AddContact_Name.Text = "Name : ";
            // 
            // Save_MngPf
            // 
            Save_MngPf.Image = Properties.Resources.Save_icon_floppy_disk_transparent_with_circle;
            Save_MngPf.Location = new Point(205, 267);
            Save_MngPf.Name = "Save_MngPf";
            Save_MngPf.Size = new Size(53, 51);
            Save_MngPf.TabIndex = 16;
            Save_MngPf.TabStop = false;
            Save_MngPf.Click += Save_MngPf_Click;
            // 
            // Manage_PF
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(296, 461);
            Controls.Add(Save_MngPf);
            Controls.Add(AddContact_Name);
            Controls.Add(AddContact_Port);
            Controls.Add(MyPortTextBox);
            Controls.Add(MyNameTextBox);
            Controls.Add(label1);
            Name = "Manage_PF";
            Text = "Manage_PF";
            ((System.ComponentModel.ISupportInitialize)Save_MngPf).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox MyNameTextBox;
        private TextBox MyPortTextBox;
        private Label AddContact_Port;
        private Label AddContact_Name;
        private PictureBox Save_MngPf;
    }
}