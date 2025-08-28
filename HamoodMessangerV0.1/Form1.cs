using System;
using System.ComponentModel.Design;
using System.Drawing.Text;
using System.IO;
using System.Net;
using System.Net.Sockets;
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
            string MYIP = GetMYIP();
            MessageBox.Show($"Your IP is: {MYIP}", "IP Address", MessageBoxButtons.OK, MessageBoxIcon.Information); // testing my ip address
            LoadContacts();
            this.KeyPreview = true;
            this.KeyDown += SendMessage_KeyDown;
            LoadProfile();



            Chats.SelectedIndexChanged += SelectedChats;
            tcp.OnMessageReceived += (senderIp, msg) =>
            {
                // We’re on a background thread; marshal to UI thread
                this.BeginInvoke((Action)(() => HandleIncomingMessage(senderIp, msg)));

            };
            if (UserProfile != null)
            {
                tcp.StartServer(UserProfile.Port);
            }



        }


        private void HandleIncomingMessage(string senderIp, string message)  //////////// Makes no sense
        {
            // Find the contact by IP (port from remote will be ephemeral, so match by IP)
            var contact = contacts.FirstOrDefault(c => c.IP == senderIp);

            if (contact == null)
            {
                // Optional: show a hint if the sender isn’t in contacts
                MainMessageBox.AppendText($"[{senderIp}] {message}" + Environment.NewLine);
                return;
            }

            // Append to that contact's chat file
            string chatFileName = $"{contact.DisplayName}_{contact.Port}.txt";
            string chatFilePath = Path.Combine(ChatsPath, chatFileName);
            if (!File.Exists(chatFilePath)) File.WriteAllText(chatFilePath, "");

            string formatted = $"{contact.DisplayName}: {message}";
            File.AppendAllText(chatFilePath, formatted + Environment.NewLine);

            // If this chat is currently selected, show it live
            if (selectedChatIndex >= 0 && contacts[selectedChatIndex].IP == contact.IP)
            {
                MainMessageBox.AppendText(formatted + Environment.NewLine);
                MainMessageBox.SelectionStart = MainMessageBox.Text.Length;
                MainMessageBox.ScrollToCaret();
            }
        }

        private TCPManager tcp = new TCPManager(); ///                                             TCP makes no sense


        private string MyProfilePath = "C:\\Users\\hamid\\source\\repos\\HamoodMessangerV0.1\\HamoodMessangerV0.1\\user\\MYProfile\\MyUserInfo.json";
        private string ContactPath = "C:\\Users\\hamid\\source\\repos\\HamoodMessangerV0.1\\HamoodMessangerV0.1\\user\\Contacts\\contacts.json";
        private string ChatsPath = "C:\\Users\\hamid\\source\\repos\\HamoodMessangerV0.1\\HamoodMessangerV0.1\\user\\Chats\\chat";
        private int selectedChatIndex = -1;
        private MyPF UserProfile;




        private void SaveContact(Contact newContact)
        {
            contacts.Add(newContact);
            File.WriteAllText(ContactPath, JsonSerializer.Serialize(contacts, new JsonSerializerOptions { WriteIndented = true }));
            Chats.Items.Add($"{newContact.DisplayName} ({newContact.IP}:{newContact.Port})");
        }


        public static string GetMYIP()
        {
            string localIP = "";
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork) // IPv4 only
                {
                    localIP = ip.ToString();
                    break;
                }
            }
            return localIP;
        }

        private void SaveUserProfile(MyPF newProfile)
        {
            Profile.Clear();
            Profile.Add(newProfile);

            // Save to JSON file for the profile
            File.WriteAllText(MyProfilePath, JsonSerializer.Serialize(Profile, new JsonSerializerOptions { WriteIndented = true }));

            Chats.Items.Add($"{newProfile.Name} ({newProfile.IP}:{newProfile.Port})");
        }




        public class Contact
        {
            public string DisplayName { get; set; }
            public int Port { get; set; }
            public string IP { get; set; }



        }

        public class MyPF
        {
            public string Name { get; set; }
            public int Port { get; set; }
            public string IP { get; set; }
            public MyPF(string name, int port)
            {
                Name = name;
                Port = port;
                IP = GetMYIP(); // automatically get local IP
            }
            public static string GetMYIP()
            {
                string localIP = "";
                var host = Dns.GetHostEntry(Dns.GetHostName());
                foreach (var ip in host.AddressList)
                {
                    if (ip.AddressFamily == AddressFamily.InterNetwork) // IPv4 only
                    {
                        localIP = ip.ToString();
                        break;
                    }
                }
                return localIP;
            }

        }

        private List<MyPF> Profile = new();


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
        private void LoadProfile()
        {
            if (File.Exists(MyProfilePath))
            {
                string json = File.ReadAllText(MyProfilePath);
                var profiles = JsonSerializer.Deserialize<List<MyPF>>(json) ?? new List<MyPF>();

                if (profiles.Count > 0)
                {
                    UserProfile = profiles[0];  // set the current profile
                    MyName.Text = UserProfile.Name;
                    MyPort.Text = UserProfile.Port.ToString();
                    IPTextBox.Text = UserProfile.IP; // display Ip
                }

            }
        }
        private void LoadChats(Contact contact)
        {
            if (contact == null) return;


            if (!Directory.Exists(ChatsPath))
                Directory.CreateDirectory(ChatsPath);


            string chatFileName = $"{contact.DisplayName}_{contact.Port}.txt"; // crating a txt file for each contact adds name and port so its unique
            string chatFilePath = Path.Combine(ChatsPath, chatFileName);

            // Creating file if it doesn't exist 
            if (!File.Exists(chatFilePath))
                File.WriteAllText(chatFilePath, "");

            // Load the chat into RichTextBox
            MainMessageBox.Text = File.ReadAllText(chatFilePath);

            // Scroll to bottom
            MainMessageBox.SelectionStart = MainMessageBox.Text.Length;
            MainMessageBox.ScrollToCaret();
        }


        private void SelectedChats(object sender, EventArgs e)
        {
            selectedChatIndex = Chats.SelectedIndex;
            if (selectedChatIndex >= 0 && selectedChatIndex < contacts.Count)
            {
                var selectedContact = contacts[selectedChatIndex];
                ChatL.Text = selectedContact.DisplayName;

                LoadChats(selectedContact);
            }
            else
            {
                ChatL.Text = "";
            }



        }

        private async void SendBtn_Click(object sender, EventArgs e)
        {
            if (selectedChatIndex == -1)
            {
                MessageBox.Show("Please select a chat first.", "No Chat Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string message = SendMessage.Text.Trim();
            if (!string.IsNullOrEmpty(message))
            {
                var selectedContact = contacts[selectedChatIndex];
                string chatFileName = $"{selectedContact.DisplayName}_{selectedContact.Port}.txt";
                string chatFilePath = Path.Combine(ChatsPath, chatFileName);

                File.AppendAllText(chatFilePath, "You: " + message + Environment.NewLine); // storing messages in the chat file
                MainMessageBox.AppendText("You: " + message + Environment.NewLine); // and displaying in the lIVE box 

                SendMessage.Clear();

                await tcp.SendMessageAsync(selectedContact.IP, selectedContact.Port, message); // actually sending the message accross the network
            }
        }
        private void SendMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendBtn_Click(sender, e);
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

        private void Manage_PF_Click(object sender, EventArgs e)
        {
            using (var form = new Manage_PF())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    SaveUserProfile(form.UserProfile);
                }
            }
        }

        
    }
}

