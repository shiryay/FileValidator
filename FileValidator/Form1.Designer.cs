namespace FileValidator
{
    partial class frmValidator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnValidate = new Button();
            btnExit = new Button();
            txtTranslation = new TextBox();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // btnValidate
            // 
            btnValidate.Location = new Point(12, 349);
            btnValidate.Name = "btnValidate";
            btnValidate.Size = new Size(94, 29);
            btnValidate.TabIndex = 0;
            btnValidate.Text = "&Validate";
            btnValidate.UseVisualStyleBackColor = true;
            btnValidate.Click += btnValidate_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(138, 349);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 1;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txtTranslation
            // 
            txtTranslation.Location = new Point(12, 12);
            txtTranslation.Multiline = true;
            txtTranslation.Name = "txtTranslation";
            txtTranslation.Size = new Size(794, 331);
            txtTranslation.TabIndex = 2;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(703, 361);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(103, 20);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Suggest a rule";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // frmValidator
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(818, 390);
            Controls.Add(linkLabel1);
            Controls.Add(txtTranslation);
            Controls.Add(btnExit);
            Controls.Add(btnValidate);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmValidator";
            Text = "File Validator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnValidate;
        private Button btnExit;
        private TextBox txtTranslation;
        private LinkLabel linkLabel1;
    }
}
