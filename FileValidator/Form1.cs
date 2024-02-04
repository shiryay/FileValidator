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
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files) ValidateFile(file);
        }
    }
}
