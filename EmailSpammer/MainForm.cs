using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.IO;
using System.Net.Mime;

namespace EmailSpammer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sendTo(string email, string code)
        {
            var fromAddress = new MailAddress(fromEmail.Text, fromFullName.Text);
            var toAddress = new MailAddress(email);
            string fromPassword = txtFromPassword.Text;
            string subject = txtSubject.Text;
            string body = txtBody.Text.Replace("{code}", code);

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                IsBodyHtml = checkHtml.Checked,
                Subject = subject,
                Body = body
            }) {
                var doSend = true;

                if (textSelectedFileName.Text != "")
                {
                    var file = new FileInfo(textSelectedFileName.Text);
                    if (!file.Exists)
                    {
                        MessageBox.Show("Selected file " + file.FullName + " was not found on disk. Can not attach :P");
                        doSend = false;
                    }
                    else
                    {
                        Attachment attachment = new Attachment(file.FullName, MediaTypeNames.Application.Octet);
                        ContentDisposition disposition = attachment.ContentDisposition;
                        disposition.CreationDate = file.CreationTime;
                        disposition.ModificationDate = file.LastWriteTime;
                        disposition.ReadDate = file.LastAccessTime;
                        disposition.FileName = Path.GetFileName(file.FullName);
                        disposition.Size = file.Length;
                        disposition.DispositionType = DispositionTypeNames.Attachment;
                        message.Attachments.Add(attachment);
                    }
                }

                if (doSend)
                {
                    smtp.Send(message);
                }
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            var listText = txtList.Text.Replace("\r", "");

            var list = listText.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);

            progressBar1.Value = 0;
            progressBar1.Maximum = list.Length;

            foreach (var s in list)
            {
                var ss = s.Split(';');
                if (ss.Length > 1)
                {
                    var email = ss[0].Trim();
                    var code = ss[1].Trim();

                    sendTo(email, code);

                    progressBar1.Value += 1;
                    progressBar1.Refresh();

                    Application.DoEvents();
                }
                
            }

            progressBar1.Value = progressBar1.Maximum;
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
            {
                textSelectedFileName.Text = openFile.FileName;
            }
            else
            {
                textSelectedFileName.Text = "";
            }
        }
    }
}
