namespace HamoodMessangerV0._1
{
    partial class AddContactForm
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            AddContact_IP = new Label();
            AddContact_Port = new Label();
            AddContact_Name = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.ForestGreen;
            label1.Location = new Point(103, 9);
            label1.Name = "label1";
            label1.Size = new Size(187, 30);
            label1.TabIndex = 0;
            label1.Text = "Add New Contact";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(119, 82);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(162, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(119, 154);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(162, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(119, 220);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(162, 23);
            textBox3.TabIndex = 3;
            // 
            // AddContact_IP
            // 
            AddContact_IP.AutoSize = true;
            AddContact_IP.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddContact_IP.ForeColor = Color.Red;
            AddContact_IP.Location = new Point(58, 226);
            AddContact_IP.Name = "AddContact_IP";
            AddContact_IP.Size = new Size(28, 17);
            AddContact_IP.TabIndex = 5;
            AddContact_IP.Text = "IP :";
            // 
            // AddContact_Port
            // 
            AddContact_Port.AutoSize = true;
            AddContact_Port.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddContact_Port.ForeColor = Color.Red;
            AddContact_Port.Location = new Point(52, 155);
            AddContact_Port.Name = "AddContact_Port";
            AddContact_Port.Size = new Size(42, 17);
            AddContact_Port.TabIndex = 6;
            AddContact_Port.Text = "Port :";
            // 
            // AddContact_Name
            // 
            AddContact_Name.AutoSize = true;
            AddContact_Name.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddContact_Name.ForeColor = Color.Lime;
            AddContact_Name.Location = new Point(52, 83);
            AddContact_Name.Name = "AddContact_Name";
            AddContact_Name.Size = new Size(56, 17);
            AddContact_Name.TabIndex = 7;
            AddContact_Name.Text = "Name : ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Save_icon_floppy_disk_transparent_with_circle;
            pictureBox1.Location = new Point(228, 276);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 51);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // AddContactForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 379);
            Controls.Add(pictureBox1);
            Controls.Add(AddContact_Name);
            Controls.Add(AddContact_Port);
            Controls.Add(AddContact_IP);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "AddContactForm";
            Text = "AddContactForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label AddContact_IP;
        private Label AddContact_Port;
        private Label AddContact_Name;
        private PictureBox pictureBox1;
    }
}