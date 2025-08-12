using System;
using System.Windows.Forms;
using static HamoodMessangerV0._1.Form1;

namespace HamoodMessangerV0._1
{
    public partial class AddContactForm : Form
    {
        public Contact NewContact { get; private set; }

        public AddContactForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text.Trim();
            string portText = textBox2.Text.Trim();
            string ip = textBox3.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(ip) || string.IsNullOrEmpty(portText))
            {
                MessageBox.Show("Please fill in all fields.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            

            // Try to parse port
            if (!int.TryParse(portText, out int port) || port <= 0 || port > 65535)
            {
                MessageBox.Show("Please enter a valid port number (1-65535).", "Invalid Port", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Optional: You could add simple IP validation here (e.g., using IPAddress.TryParse if you want)

            NewContact = new Contact
            {
                DisplayName = name,
                IP = ip,
                Port = port
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}

