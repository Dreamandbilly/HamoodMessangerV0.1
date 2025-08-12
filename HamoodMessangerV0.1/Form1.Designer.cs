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
            ((System.ComponentModel.ISupportInitialize)SendBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AddUser).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 5);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 0;
            label1.Text = "Chats";
            // 
            // MainMessageBox
            // 
            MainMessageBox.Location = new Point(311, 32);
            MainMessageBox.Margin = new Padding(2);
            MainMessageBox.Name = "MainMessageBox";
            MainMessageBox.Size = new Size(462, 334);
            MainMessageBox.TabIndex = 1;
            MainMessageBox.Text = "";
            // 
            // Chats
            // 
            Chats.FormattingEnabled = true;
            Chats.ItemHeight = 15;
            Chats.Location = new Point(16, 30);
            Chats.Margin = new Padding(2);
            Chats.Name = "Chats";
            Chats.Size = new Size(183, 394);
            Chats.TabIndex = 2;
            // 
            // ChatL
            // 
            ChatL.AutoSize = true;
            ChatL.Location = new Point(497, 5);
            ChatL.Margin = new Padding(2, 0, 2, 0);
            ChatL.Name = "ChatL";
            ChatL.Size = new Size(84, 15);
            ChatL.TabIndex = 3;
            ChatL.Text = "(Not/Selected)";
            // 
            // SendMessage
            // 
            SendMessage.Location = new Point(311, 376);
            SendMessage.Margin = new Padding(2);
            SendMessage.Name = "SendMessage";
            SendMessage.Size = new Size(415, 23);
            SendMessage.TabIndex = 4;
            // 
            // SendBtn
            // 
            SendBtn.BackgroundImage = (Image)resources.GetObject("SendBtn.BackgroundImage");
            SendBtn.Location = new Point(730, 370);
            SendBtn.Margin = new Padding(2);
            SendBtn.Name = "SendBtn";
            SendBtn.Size = new Size(43, 43);
            SendBtn.TabIndex = 5;
            SendBtn.TabStop = false;
            SendBtn.Click += SendBtn_Click;
            // 
            // AddUser
            // 
            AddUser.Image = (Image)resources.GetObject("AddUser.Image");
            AddUser.Location = new Point(175, 0);
            AddUser.Name = "AddUser";
            AddUser.Size = new Size(24, 25);
            AddUser.TabIndex = 6;
            AddUser.TabStop = false;
            AddUser.Click += AddUser_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(935, 478);
            Controls.Add(AddUser);
            Controls.Add(SendBtn);
            Controls.Add(SendMessage);
            Controls.Add(ChatL);
            Controls.Add(Chats);
            Controls.Add(MainMessageBox);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)SendBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)AddUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox MainMessageBox;
        private Label ChatL;
        private TextBox SendMessage;
        private PictureBox SendBtn;
        private ListBox Chats;
        private PictureBox AddUser;
    }
}
