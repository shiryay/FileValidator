using System.Text.RegularExpressions;

namespace FileValidator
{
    public partial class frmValidator : Form
    {
        private List<Rule> rules;
        private string rulesFile = "rules.cfg";
        private string rulesUrl = "https://github.com/shiryay/rulesrepo/raw/refs/heads/main/rules.cfg";
        private string validatedText;
        private string reportText;

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
                sr.Close();
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
            String targetText;

            if (txtTranslation.Text.Trim().Length > 0)
            {
                validatedText = txtTranslation.Text;
                txtTranslation.Clear();
                CheckText();
                txtTranslation.Text = reportText;
            }
            else
            {
                MessageBox.Show("Please enter some text to validate");
                return;
            }
        }

        private void CheckText()
        {
            List<String> reportList = new List<String>();
            reportText = "";

            // Checking rules
            foreach (Rule rule in rules)
            {
                MatchCollection matches = Regex.Matches(validatedText, rule.Regex);
                if (matches.Count > 0)
                {
                    reportList.Add($"Found {matches.Count} instances:\r\n");
                    reportList.Add(rule.Comment + Environment.NewLine);
                    reportList.Add("------------------------\r\n");
                    foreach (Match m in matches)
                    {
                        reportList.Add($"\t{m.Value}\r\n");
                    }
                    reportList.Add(Environment.NewLine);
                }
            }

            if (!validatedText.Trim().EndsWith("-end of document-"))
            {
                reportList.Add("No end tag found!\r\n");
            }

            if (reportList.Count > 0)
            {
                reportText = "Validation report:" + Environment.NewLine + Environment.NewLine;
                foreach (String s in reportList)
                {
                    reportText += s;
                }
            }
            else
            {
                reportText = "No issues found";
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTranslation.Clear();
        }

        private async void btnUpdateRules_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var response = await client.GetAsync(rulesUrl);
                    response.EnsureSuccessStatusCode();
                    var rulesContent = await response.Content.ReadAsStringAsync();
                    await File.WriteAllTextAsync(rulesFile, rulesContent);
                    MessageBox.Show("Rules updated successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error downloading rules file: " + ex.Message);
                    return;
                }
            }
        }
    }
}
