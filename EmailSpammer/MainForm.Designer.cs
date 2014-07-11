namespace EmailSpammer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.fromEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFromPassword = new System.Windows.Forms.MaskedTextBox();
            this.emailSubject = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtBody = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtList = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSend = new System.Windows.Forms.Button();
            this.fromFullName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.checkHtml = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.textSelectedFileName = new System.Windows.Forms.TextBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gmail address";
            // 
            // fromEmail
            // 
            this.fromEmail.Location = new System.Drawing.Point(140, 13);
            this.fromEmail.Name = "fromEmail";
            this.fromEmail.Size = new System.Drawing.Size(179, 20);
            this.fromEmail.TabIndex = 1;
            this.fromEmail.Text = "nercury@gmail.com";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gmail password";
            // 
            // txtFromPassword
            // 
            this.txtFromPassword.Location = new System.Drawing.Point(140, 39);
            this.txtFromPassword.Name = "txtFromPassword";
            this.txtFromPassword.PasswordChar = '*';
            this.txtFromPassword.Size = new System.Drawing.Size(179, 20);
            this.txtFromPassword.TabIndex = 3;
            // 
            // emailSubject
            // 
            this.emailSubject.AutoSize = true;
            this.emailSubject.Location = new System.Drawing.Point(12, 86);
            this.emailSubject.Name = "emailSubject";
            this.emailSubject.Size = new System.Drawing.Size(43, 13);
            this.emailSubject.TabIndex = 4;
            this.emailSubject.Text = "Subject";
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(15, 102);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(304, 20);
            this.txtSubject.TabIndex = 5;
            this.txtSubject.Text = "Hello, this is email subject";
            // 
            // txtBody
            // 
            this.txtBody.Location = new System.Drawing.Point(15, 145);
            this.txtBody.Multiline = true;
            this.txtBody.Name = "txtBody";
            this.txtBody.Size = new System.Drawing.Size(304, 204);
            this.txtBody.TabIndex = 7;
            this.txtBody.Text = "<html>\r\n<body>\r\n<p>\r\n<b>Hello</b>,\r\n</p>\r\n<p>\r\nBlah blah, the <i>code</i>: {code}" +
    ".\r\n</p>\r\n</body>\r\n</html>";
            this.txtBody.TextChanged += new System.EventHandler(this.txtBody_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Text";
            // 
            // txtList
            // 
            this.txtList.Location = new System.Drawing.Point(365, 102);
            this.txtList.Multiline = true;
            this.txtList.Name = "txtList";
            this.txtList.Size = new System.Drawing.Size(316, 295);
            this.txtList.TabIndex = 8;
            this.txtList.Text = "nercury@gmail.com;85456\r\nnercury@gmail.com;8888";
            this.txtList.TextChanged += new System.EventHandler(this.txtList_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(362, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Send to";
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(15, 423);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 10;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // fromFullName
            // 
            this.fromFullName.Location = new System.Drawing.Point(490, 10);
            this.fromFullName.Name = "fromFullName";
            this.fromFullName.Size = new System.Drawing.Size(179, 20);
            this.fromFullName.TabIndex = 12;
            this.fromFullName.Text = "Someones Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(362, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Full from name";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(140, 423);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(541, 23);
            this.progressBar1.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(362, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Format";
            // 
            // checkHtml
            // 
            this.checkHtml.AutoSize = true;
            this.checkHtml.Checked = true;
            this.checkHtml.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkHtml.Location = new System.Drawing.Point(490, 41);
            this.checkHtml.Name = "checkHtml";
            this.checkHtml.Size = new System.Drawing.Size(118, 17);
            this.checkHtml.TabIndex = 15;
            this.checkHtml.Text = "Send text as HTML";
            this.checkHtml.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 361);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Attach a file";
            // 
            // textSelectedFileName
            // 
            this.textSelectedFileName.Location = new System.Drawing.Point(15, 377);
            this.textSelectedFileName.Name = "textSelectedFileName";
            this.textSelectedFileName.ReadOnly = true;
            this.textSelectedFileName.Size = new System.Drawing.Size(235, 20);
            this.textSelectedFileName.TabIndex = 17;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(256, 373);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(63, 27);
            this.buttonBrowse.TabIndex = 18;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 458);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.textSelectedFileName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checkHtml);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.fromFullName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtList);
            this.Controls.Add(this.txtBody);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.emailSubject);
            this.Controls.Add(this.txtFromPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fromEmail);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Email Spammer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fromEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtFromPassword;
        private System.Windows.Forms.Label emailSubject;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtBody;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.TextBox fromFullName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkHtml;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.TextBox textSelectedFileName;
        private System.Windows.Forms.Button buttonBrowse;
    }
}

