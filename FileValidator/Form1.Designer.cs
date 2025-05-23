﻿namespace FileValidator
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
            btnClear = new Button();
            btnUpdateRules = new Button();
            btnViewRules = new Button();
            SuspendLayout();
            // 
            // btnValidate
            // 
            btnValidate.Location = new Point(15, 349);
            btnValidate.Name = "btnValidate";
            btnValidate.Size = new Size(115, 29);
            btnValidate.TabIndex = 0;
            btnValidate.Text = "&Validate";
            btnValidate.UseVisualStyleBackColor = true;
            btnValidate.Click += btnValidate_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(555, 349);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(115, 29);
            btnExit.TabIndex = 1;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txtTranslation
            // 
            txtTranslation.Location = new Point(15, 15);
            txtTranslation.Multiline = true;
            txtTranslation.Name = "txtTranslation";
            txtTranslation.ScrollBars = ScrollBars.Both;
            txtTranslation.Size = new Size(790, 330);
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
            // btnClear
            // 
            btnClear.Location = new Point(150, 349);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(115, 29);
            btnClear.TabIndex = 4;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnUpdateRules
            // 
            btnUpdateRules.Location = new Point(285, 349);
            btnUpdateRules.Name = "btnUpdateRules";
            btnUpdateRules.Size = new Size(115, 29);
            btnUpdateRules.TabIndex = 5;
            btnUpdateRules.Text = "&Update Rules";
            btnUpdateRules.UseVisualStyleBackColor = true;
            btnUpdateRules.Click += btnUpdateRules_Click;
            // 
            // btnViewRules
            // 
            btnViewRules.Location = new Point(420, 349);
            btnViewRules.Name = "btnViewRules";
            btnViewRules.Size = new Size(115, 29);
            btnViewRules.TabIndex = 6;
            btnViewRules.Text = "V&iew Rules";
            btnViewRules.UseVisualStyleBackColor = true;
            btnViewRules.Click += btnViewRules_Click;
            // 
            // frmValidator
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(812, 382);
            Controls.Add(btnViewRules);
            Controls.Add(btnUpdateRules);
            Controls.Add(btnClear);
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
        private Button btnClear;
        private Button btnUpdateRules;
        private Button btnViewRules;
    }
}
