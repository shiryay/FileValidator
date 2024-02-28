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

        private void frmValidator_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void frmValidator_DragDrop(object sender, DragEventArgs e)
        {
            List<Rule> rules;
            string ruleFilePath = GetPath() + "rules.cfg";
            
            rules = LoadRules(ruleFilePath);
            MessageBox.Show(rules.Count.ToString());
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files) ValidateFile(file);
        }

        private List<Rule> LoadRules(string path)
        {
            List<Rule> ruleList = new List<Rule>();
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
            string folderPath = exePath.Substring(0, lastSlashIndex+1);
            return folderPath;
        }

        private Rule ParseForRules(string ruleString)
        {
            string[] ruleComponents = new string[3];
            ruleComponents = ruleString.Split(',');
            return new Rule(ruleComponents[0], ruleComponents[1], ruleComponents[2]);
        }

    }
}
