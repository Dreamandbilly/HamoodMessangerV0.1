using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HamoodMessangerV0._1.Form1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HamoodMessangerV0._1
{
    
    public partial class Manage_PF : Form
    {
        public MyPF UserProfile { get; private set; }  // new property to return
        public Manage_PF()
        {
            InitializeComponent();
        }

        private void Save_MngPf_Click(object sender, EventArgs e)
        {
            string name = MyNameTextBox.Text.Trim();
            string portText = MyPortTextBox.Text.Trim();

            if (!int.TryParse(portText, out int port) || port <= 0 || port > 65535)
            {
                MessageBox.Show("Please enter a valid port number (1-65535).", "Invalid Port", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // create the profile
            UserProfile = new MyPF(name, port);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
