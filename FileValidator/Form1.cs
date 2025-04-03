using System.Diagnostics;
using System.Drawing.Text;

namespace FileValidator
{
    public partial class frmValidator : Form
    {
        private List<Rule> rules;
        private string rulesFile = "rules.cfg";

        public frmValidator()
        {
            InitializeComponent();
            rules = new List<Rule>();
            LoadRules();
        }

        private void LoadRules()
        {
            string tempString;

            if (File.Exists(rulesFile))
            {
                StreamReader sr = new StreamReader(rulesFile);
                do
                {
                    tempString = sr.ReadLine().TrimEnd();
                    rules.Add(new Rule(tempString));
                }
                while (sr.EndOfStream != true);
                MessageBox.Show(rules.Count + " rules loaded successfully");
            }
            else
            {
                MessageBox.Show("Rules file not found");
                return;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string email = "mailto:shiryaev.sergey@gmail.com?subject=Rule%20Suggestion";
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(email) { UseShellExecute = true });

        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            String targetText = "";

            if (txtTranslation.Text.Trim().Length > 0) {
                targetText = txtTranslation.Text;
                MessageBox.Show(targetText);
            }
            else
            {
                MessageBox.Show("Please enter some text to validate");
                return;
            }
        }

        private void ValidateFile(string fileName)
        {
            MessageBox.Show($"{fileName} has been successfully validated");
        }

    }
}
