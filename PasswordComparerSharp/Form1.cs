using System.Security.Cryptography;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PasswordComparerSharp
{
    public partial class Form1 : Form
    {
        string FileName = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void openCSV_BTN_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();

            if (!File.Exists(ofd.FileName)) return;

            FileName = ofd.FileName;
            fileLabel.Text = $"File: {FileName}";
            LoadPasswords(FileName, Convert.ToInt32(comboBox1.Text));
        }

        public void LoadPasswords(string file, int ThreatLevelFilter = 0)
        {
            if (!File.Exists(file)) return;

            int indexOfPassword = 0;
            int indexOfUrl = 0;
            string[] topTextLineArr = File.ReadAllLines(file)[0].Split(",");
            for (int i = 0; i < topTextLineArr.Length; i++)
            {
                string line = topTextLineArr[i];
                if (line == "password")
                {
                    indexOfPassword = i;
                }
                if (line == "url")
                {
                    indexOfUrl = i;
                }
            }
            if (indexOfPassword == 0)
            {
                indexOfPassword = 4; //assumed for now, will spit out warning later
            }
            if (indexOfUrl == 0)
            {
                indexOfUrl = 2; //assumed for now, will spit out warning later
            }

            flowLayoutPanel1.Controls.Clear();
            foreach (string line in File.ReadAllLines(file)[1..])
            {
                string password = line.Split(',')[indexOfPassword - 1];
                string email = line.Split(',')[indexOfUrl - 1];
                if (strictFilterYesRBTN.Checked == true)
                {
                    int e = IsPasswordVulnerable(password);
                    if (e != ThreatLevelFilter)
                    {
                        continue;
                    }
                }
                if (IsPasswordVulnerable(password) >= ThreatLevelFilter)
                {
                    int ThreatLevel = IsPasswordVulnerable(password);
                    if (password.Trim() == "")
                    {
                        password = "<No-Password>";
                    }

                    if (ThreatLevel == 0)
                    {
                        password = $"{password} (Safe)";
                    }

                    // Create a panel to display the vulnerable password information
                    Panel panel = new Panel();
                    panel.BorderStyle = BorderStyle.FixedSingle;
                    panel.Size = new Size(300, 300);
                    panel.BackColor = Color.FromArgb(255, 45, 45, 45);
                    panel.AutoSize = true;

                    // Add labels for email and password information
                    Label emailLabel = new Label();
                    emailLabel.Text = email;
                    emailLabel.Location = new Point(10, 0);
                    emailLabel.AutoSize = true;
                    emailLabel.ForeColor = Color.White;
                    emailLabel.BackColor = Color.Transparent;
                    panel.Controls.Add(emailLabel);

                    Label passwordLabel = new Label();
                    passwordLabel.Text = password;
                    passwordLabel.Location = new Point(10, 37);
                    passwordLabel.AutoSize = true;

                    if (ThreatLevel == 0) passwordLabel.ForeColor = Color.White;
                    else if (ThreatLevel == 1) passwordLabel.ForeColor = Color.Green;
                    else if (ThreatLevel == 2) passwordLabel.ForeColor = Color.GreenYellow;
                    else if (ThreatLevel == 3) passwordLabel.ForeColor = Color.Yellow;
                    else if (ThreatLevel == 4) passwordLabel.ForeColor = Color.Orange;
                    else if (ThreatLevel == 5) passwordLabel.ForeColor = Color.Red;

                    passwordLabel.BackColor = Color.Transparent;

                    panel.Controls.Add(passwordLabel);

                    // Add the panel to your form
                    flowLayoutPanel1.Controls.Add(panel);
                }
            }
        }

        private int IsPasswordVulnerable(string password)
        {
            int ThreatLevel = 0;
            var lowerCaseChars = new Regex("[a-z]");
            var upperCaseChars = new Regex("[A-Z]");
            var numbersChars = new Regex("[0-9]");
            var symbolPattern = new Regex(@"[!@#$%^&*()_\-]");

            if (password.Length < 8) ThreatLevel += 1;
            if (!lowerCaseChars.IsMatch(password)) ThreatLevel += 1;
            if (!upperCaseChars.IsMatch(password)) ThreatLevel += 1;
            if (!numbersChars.IsMatch(password)) ThreatLevel += 1;
            if (!symbolPattern.IsMatch(password)) ThreatLevel += 1;
            return ThreatLevel;
        }

        private void comboBox1_TextUpdate(object sender, EventArgs e)
        {
            UpdateList();
        }

        void UpdateList()
        {
            if (int.TryParse(comboBox1.Text, out _))
            {
                LoadPasswords(FileName, Convert.ToInt32(comboBox1.Text));
            }
        }

        private void strictFilterYesRBTN_CheckedChanged(object sender, EventArgs e)
        {
            UpdateList();
        }

        private void strictFilterNoRBTN_CheckedChanged(object sender, EventArgs e)
        {
            UpdateList();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateList();
        }
    }
}
