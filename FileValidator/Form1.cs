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
            MessageBox.Show(fileName);
        }

        private void frmValidator_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void frmValidator_DragDrop(object sender, DragEventArgs e)
        {
            List<Rule> rules;
            string ruleFilePath = "rules.cfg";

            rules = LoadRules(ruleFilePath);
            //foreach (Rule rule in rules) Debug.WriteLine(rule.Comment);
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files) ValidateFile(file);
        }

        private List<Rule> LoadRules(string path)
        {
            List<Rule> ruleList = new List<Rule>();
            if (File.Exists(path))
            {
                StreamReader sr = new StreamReader(path);
                do
                {
                    ruleList.Add(new Rule("name", "regex", "comment"));
                }
                while (sr.EndOfStream != true);
                return ruleList;
            }
            else
                return new List<Rule>();
        }

    }
}
