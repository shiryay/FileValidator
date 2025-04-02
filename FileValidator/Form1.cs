using System.Diagnostics;
using System.Drawing.Text;

namespace FileValidator
{
    public partial class frmValidator : Form
    {
        public frmValidator()
        {
            InitializeComponent();
        }

        private void ValidateFile(string fileName)
        {
            MessageBox.Show($"{fileName} has been successfully validated");
        }

        private List<Rule> LoadRules(string path)
        {
            List<Rule> ruleList = new();
            string tempString;

            if (File.Exists(path))
            {
                StreamReader sr = new StreamReader(path);
                do
                {
                    tempString = sr.ReadLine();
                    ruleList.Add(ParseForRules(tempString));
                }
                while (sr.EndOfStream != true);
                return ruleList;
            }
            else
                return new List<Rule>();
        }

        private string GetPath()
        {
            string exePath = Application.ExecutablePath;
            int lastSlashIndex = exePath.LastIndexOf(@"\");
            string folderPath = exePath.Substring(0, lastSlashIndex + 1);
            return folderPath;
        }

        private Rule ParseForRules(string ruleString)
        {
            string[] ruleComponents = new string[3];
            ruleComponents = ruleString.Split(',');
            return new Rule(ruleComponents[0], ruleComponents[1]);
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
            List<Rule> rules;
            string ruleFilePath = GetPath() + "rules.cfg";

            rules = LoadRules(ruleFilePath);
            MessageBox.Show(rules.Count.ToString());

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
    }
}
