namespace Lab8_WindowsForm
{
    partial class Form1
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
            txtBrowse = new TextBox();
            btnBrowse = new Button();
            lstBox1 = new ListBox();
            btnSubmit = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // txtBrowse
            // 
            txtBrowse.Location = new Point(96, 58);
            txtBrowse.Name = "txtBrowse";
            txtBrowse.Size = new Size(314, 31);
            txtBrowse.TabIndex = 0;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(470, 55);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(112, 34);
            btnBrowse.TabIndex = 1;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // lstBox1
            // 
            lstBox1.FormattingEnabled = true;
            lstBox1.ItemHeight = 25;
            lstBox1.Location = new Point(156, 122);
            lstBox1.Name = "lstBox1";
            lstBox1.Size = new Size(400, 354);
            lstBox1.TabIndex = 2;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(172, 526);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(112, 34);
            btnSubmit.TabIndex = 3;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(416, 526);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 34);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(736, 642);
            Controls.Add(btnExit);
            Controls.Add(btnSubmit);
            Controls.Add(lstBox1);
            Controls.Add(btnBrowse);
            Controls.Add(txtBrowse);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBrowse;
        private Button btnBrowse;
        private ListBox lstBox1;
        private Button btnSubmit;
        private Button btnExit;
    }
}