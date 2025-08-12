using System;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using static HamoodMessangerV0._1.Form1;

namespace HamoodMessangerV0._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();


            LoadContacts();
            Chats.SelectedIndexChanged += SelectedChats;



        }
        private string ContactPath = "C:\\Users\\hamid\\source\\repos\\HamoodMessangerV0.1\\HamoodMessangerV0.1\\user\\Contacts\\contacts.json";
        private int selectedChatIndex = -1;


        private void SaveContact(Contact newContact)
        {
            contacts.Add(newContact);
            File.WriteAllText(ContactPath, JsonSerializer.Serialize(contacts, new JsonSerializerOptions { WriteIndented = true }));
            Chats.Items.Add($"{newContact.DisplayName} ({newContact.IP}:{newContact.Port})");
        }





        public class Contact
        {
            public string DisplayName { get; set; }
            public int Port { get; set; }
            public string IP { get; set; }



        }




        private List<Contact> contacts = new();

        private void LoadContacts()
        {
            
            if (File.Exists(ContactPath))
            {
                string json = File.ReadAllText(ContactPath);
                contacts = JsonSerializer.Deserialize<List<Contact>>(json) ?? new();
                foreach (var c in contacts)
                {
                    Chats.Items.Add($"{c.DisplayName}");
                }
            }

        }

        private void SelectedChats(object sender, EventArgs e)
        {
            selectedChatIndex = Chats.SelectedIndex;
            if (selectedChatIndex >= 0 && selectedChatIndex < contacts.Count)
            {
                var selectedContact = contacts[selectedChatIndex];
                ChatL.Text = selectedContact.DisplayName;
            }
            else
            {
                ChatL.Text = "";
            }



        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            if (selectedChatIndex == -1)
            {
                MessageBox.Show("Please select a chat first.", "No Chat Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning); // playing arround with warning symbols
                return;
            }

            string message = SendMessage.Text.Trim();
            if (!string.IsNullOrEmpty(message))
            {
                MainMessageBox.AppendText("You: " + message + Environment.NewLine);
                SendMessage.Clear();
            }
        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            var OpenForm = new AddContactForm();

            if (OpenForm.ShowDialog() == DialogResult.OK)
            {
                SaveContact(OpenForm.NewContact);
            }
        }
    }
}
