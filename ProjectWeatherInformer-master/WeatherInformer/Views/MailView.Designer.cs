namespace WeatherInformer
{
    partial class MailView
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
            this.txtbSendTo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbSubject = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.rtxtbBody = new System.Windows.Forms.RichTextBox();
            this.btnAddAttachment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wyślij do:";
            // 
            // txtbSendTo
            // 
            this.txtbSendTo.Location = new System.Drawing.Point(47, 47);
            this.txtbSendTo.Name = "txtbSendTo";
            this.txtbSendTo.Size = new System.Drawing.Size(176, 20);
            this.txtbSendTo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Temat:";
            // 
            // txtbSubject
            // 
            this.txtbSubject.Location = new System.Drawing.Point(47, 99);
            this.txtbSubject.Name = "txtbSubject";
            this.txtbSubject.Size = new System.Drawing.Size(176, 20);
            this.txtbSubject.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Treść:";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(179, 321);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(167, 37);
            this.btnSend.TabIndex = 8;
            this.btnSend.Text = "Wyślij";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // rtxtbBody
            // 
            this.rtxtbBody.Location = new System.Drawing.Point(47, 152);
            this.rtxtbBody.Name = "rtxtbBody";
            this.rtxtbBody.Size = new System.Drawing.Size(259, 71);
            this.rtxtbBody.TabIndex = 9;
            this.rtxtbBody.Text = "";
            // 
            // btnAddAttachment
            // 
            this.btnAddAttachment.Location = new System.Drawing.Point(186, 242);
            this.btnAddAttachment.Name = "btnAddAttachment";
            this.btnAddAttachment.Size = new System.Drawing.Size(120, 23);
            this.btnAddAttachment.TabIndex = 10;
            this.btnAddAttachment.Text = "Dodaj załącznik";
            this.btnAddAttachment.UseVisualStyleBackColor = true;
            this.btnAddAttachment.Click += new System.EventHandler(this.btnAddAttachment_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 369);
            this.Controls.Add(this.btnAddAttachment);
            this.Controls.Add(this.rtxtbBody);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbSubject);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbSendTo);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbSendTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbSubject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.RichTextBox rtxtbBody;
        private System.Windows.Forms.Button btnAddAttachment;
    }
}