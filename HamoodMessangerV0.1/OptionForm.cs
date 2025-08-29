using System;
using System.IO;
using System.Windows.Forms;

namespace HamoodMessangerV0._1
{
    public partial class OptionForm : Form
    {
        private Form1 form1Instance;

        public OptionForm(Form1 form1)
        {
            InitializeComponent();
            form1Instance = form1;
        }

        public void AddImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog imageDialog = new OpenFileDialog())
            {
                imageDialog.Filter = "Image Files (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg";
                if (imageDialog.ShowDialog() != DialogResult.OK) return;

                string fileSelected = imageDialog.FileName;

                // Ensure a chat is selected
                if (form1Instance.selectedChatIndex == -1)
                {
                    MessageBox.Show("Please select a chat first.", "No Chat Selected",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Get selected contact
                var selectedContact = form1Instance.contacts[form1Instance.selectedChatIndex];

                // Append local history text
                string chatFileName = $"{selectedContact.DisplayName}_{selectedContact.Port}.txt";
                string chatFilePath = Path.Combine(form1Instance.ChatsPath, chatFileName);
                if (!File.Exists(chatFilePath)) File.WriteAllText(chatFilePath, "");

                string formatted = $"You sent an image: {Path.GetFileName(fileSelected)}";
                File.AppendAllText(chatFilePath, formatted + Environment.NewLine);

                // Update UI message box
                form1Instance.MainMessageBox.AppendText(formatted + Environment.NewLine);
                form1Instance.MainMessageBox.SelectionStart = form1Instance.MainMessageBox.Text.Length;
                form1Instance.MainMessageBox.ScrollToCaret();

                // Send the image using TCPManager
                _ = form1Instance.tcp.SendImageAsync(selectedContact.IP, selectedContact.Port, fileSelected);
            }
        }
    }
}
