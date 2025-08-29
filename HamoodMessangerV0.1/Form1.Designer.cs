namespace HamoodMessangerV0._1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            MainMessageBox = new RichTextBox();
            Chats = new ListBox();
            ChatL = new Label();
            SendMessage = new TextBox();
            SendBtn = new PictureBox();
            AddUser = new PictureBox();
            Manage_PF = new PictureBox();
            MyPort = new Label();
            MyName = new Label();
            IPTextBox = new Label();
            PlusButton = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)SendBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AddUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Manage_PF).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PlusButton).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 7);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 0;
            label1.Text = "Chats";
            // 
            // MainMessageBox
            // 
            MainMessageBox.BackColor = Color.Magenta;
            MainMessageBox.Location = new Point(355, 43);
            MainMessageBox.Margin = new Padding(2, 3, 2, 3);
            MainMessageBox.Name = "MainMessageBox";
            MainMessageBox.Size = new Size(527, 444);
            MainMessageBox.TabIndex = 1;
            MainMessageBox.Text = "";
            // 
            // Chats
            // 
            Chats.FormattingEnabled = true;
            Chats.Location = new Point(18, 40);
            Chats.Margin = new Padding(2, 3, 2, 3);
            Chats.Name = "Chats";
            Chats.Size = new Size(209, 524);
            Chats.TabIndex = 2;
            // 
            // ChatL
            // 
            ChatL.AutoSize = true;
            ChatL.Location = new Point(568, 7);
            ChatL.Margin = new Padding(2, 0, 2, 0);
            ChatL.Name = "ChatL";
            ChatL.Size = new Size(107, 20);
            ChatL.TabIndex = 3;
            ChatL.Text = "(Not/Selected)";
            // 
            // SendMessage
            // 
            SendMessage.Location = new Point(355, 501);
            SendMessage.Margin = new Padding(2, 3, 2, 3);
            SendMessage.Name = "SendMessage";
            SendMessage.Size = new Size(474, 27);
            SendMessage.TabIndex = 4;
            // 
            // SendBtn
            // 
            SendBtn.BackgroundImage = (Image)resources.GetObject("SendBtn.BackgroundImage");
            SendBtn.Location = new Point(834, 493);
            SendBtn.Margin = new Padding(2, 3, 2, 3);
            SendBtn.Name = "SendBtn";
            SendBtn.Size = new Size(39, 44);
            SendBtn.TabIndex = 5;
            SendBtn.TabStop = false;
            SendBtn.Click += SendBtn_Click;
            // 
            // AddUser
            // 
            AddUser.Image = (Image)resources.GetObject("AddUser.Image");
            AddUser.Location = new Point(200, 0);
            AddUser.Margin = new Padding(3, 4, 3, 4);
            AddUser.Name = "AddUser";
            AddUser.Size = new Size(27, 33);
            AddUser.TabIndex = 6;
            AddUser.TabStop = false;
            AddUser.Click += AddUser_Click;
            // 
            // Manage_PF
            // 
            Manage_PF.Image = Properties.Resources.manage_pfp;
            Manage_PF.Location = new Point(14, 0);
            Manage_PF.Margin = new Padding(3, 4, 3, 4);
            Manage_PF.Name = "Manage_PF";
            Manage_PF.Size = new Size(27, 35);
            Manage_PF.TabIndex = 7;
            Manage_PF.TabStop = false;
            Manage_PF.Click += Manage_PF_Click;
            // 
            // MyPort
            // 
            MyPort.AutoSize = true;
            MyPort.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MyPort.Location = new Point(903, 7);
            MyPort.Name = "MyPort";
            MyPort.Size = new Size(122, 32);
            MyPort.TabIndex = 8;
            MyPort.Text = "MYPort : ";
            // 
            // MyName
            // 
            MyName.AutoSize = true;
            MyName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MyName.Location = new Point(903, 40);
            MyName.Name = "MyName";
            MyName.Size = new Size(102, 32);
            MyName.TabIndex = 9;
            MyName.Text = "Name : ";
            // 
            // IPTextBox
            // 
            IPTextBox.AutoSize = true;
            IPTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IPTextBox.Location = new Point(903, 73);
            IPTextBox.Name = "IPTextBox";
            IPTextBox.Size = new Size(51, 32);
            IPTextBox.TabIndex = 10;
            IPTextBox.Text = "IP: ";
            // 
            // PlusButton
            // 
            PlusButton.Image = (Image)resources.GetObject("PlusButton.Image");
            PlusButton.Location = new Point(887, 501);
            PlusButton.Name = "PlusButton";
            PlusButton.Size = new Size(51, 36);
            PlusButton.TabIndex = 11;
            PlusButton.TabStop = false;
            PlusButton.Click += PlusButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(1069, 637);
            Controls.Add(PlusButton);
            Controls.Add(IPTextBox);
            Controls.Add(MyName);
            Controls.Add(MyPort);
            Controls.Add(Manage_PF);
            Controls.Add(AddUser);
            Controls.Add(SendBtn);
            Controls.Add(SendMessage);
            Controls.Add(ChatL);
            Controls.Add(Chats);
            Controls.Add(MainMessageBox);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(2, 3, 2, 3);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)SendBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)AddUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)Manage_PF).EndInit();
            ((System.ComponentModel.ISupportInitialize)PlusButton).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        public RichTextBox MainMessageBox;
        private Label ChatL;
        private TextBox SendMessage;
        private PictureBox SendBtn;
        private ListBox Chats;
        private PictureBox AddUser;
        private PictureBox Manage_PF;
        private Label MyPort;
        private Label MyName;
        private Label IPTextBox;
        private PictureBox PlusButton;
    }
}
