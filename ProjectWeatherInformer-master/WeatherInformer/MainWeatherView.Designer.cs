namespace WeatherInformer
{
    partial class MainWeatherView
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
            this.comboBoxCity = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelTemperature = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelPressure = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelWind = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelClouds = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.labelHumidity = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.labelSunrise = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.labelSunset = new System.Windows.Forms.Label();
            this.btnWeather = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureWeather = new System.Windows.Forms.PictureBox();
            this.btnCSV = new System.Windows.Forms.Button();
            this.btnPDF = new System.Windows.Forms.Button();
            this.btnTXT = new System.Windows.Forms.Button();
            this.btnSendMail = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureWeather)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxCity
            // 
            this.comboBoxCity.FormattingEnabled = true;
            this.comboBoxCity.Location = new System.Drawing.Point(139, 29);
            this.comboBoxCity.Name = "comboBoxCity";
            this.comboBoxCity.Size = new System.Drawing.Size(250, 21);
            this.comboBoxCity.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wybierz miasto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(32, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Miasto";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCity.ForeColor = System.Drawing.Color.Tomato;
            this.labelCity.Location = new System.Drawing.Point(224, 105);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(14, 17);
            this.labelCity.TabIndex = 2;
            this.labelCity.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(33, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Temperatura:";
            // 
            // labelTemperature
            // 
            this.labelTemperature.AutoSize = true;
            this.labelTemperature.Location = new System.Drawing.Point(225, 157);
            this.labelTemperature.Name = "labelTemperature";
            this.labelTemperature.Size = new System.Drawing.Size(10, 13);
            this.labelTemperature.TabIndex = 2;
            this.labelTemperature.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(34, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Ciśnienie:";
            // 
            // labelPressure
            // 
            this.labelPressure.AutoSize = true;
            this.labelPressure.Location = new System.Drawing.Point(226, 190);
            this.labelPressure.Name = "labelPressure";
            this.labelPressure.Size = new System.Drawing.Size(10, 13);
            this.labelPressure.TabIndex = 2;
            this.labelPressure.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(34, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Wiatr:";
            // 
            // labelWind
            // 
            this.labelWind.AutoSize = true;
            this.labelWind.Location = new System.Drawing.Point(226, 224);
            this.labelWind.Name = "labelWind";
            this.labelWind.Size = new System.Drawing.Size(10, 13);
            this.labelWind.TabIndex = 2;
            this.labelWind.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label10.Location = new System.Drawing.Point(34, 253);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Zachmurzenie:";
            // 
            // labelClouds
            // 
            this.labelClouds.AutoSize = true;
            this.labelClouds.Location = new System.Drawing.Point(226, 258);
            this.labelClouds.Name = "labelClouds";
            this.labelClouds.Size = new System.Drawing.Size(10, 13);
            this.labelClouds.TabIndex = 2;
            this.labelClouds.Text = "-";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label12.Location = new System.Drawing.Point(33, 290);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 17);
            this.label12.TabIndex = 2;
            this.label12.Text = "Wilgotność:";
            // 
            // labelHumidity
            // 
            this.labelHumidity.AutoSize = true;
            this.labelHumidity.Location = new System.Drawing.Point(225, 295);
            this.labelHumidity.Name = "labelHumidity";
            this.labelHumidity.Size = new System.Drawing.Size(10, 13);
            this.labelHumidity.TabIndex = 2;
            this.labelHumidity.Text = "-";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label14.Location = new System.Drawing.Point(34, 327);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(124, 17);
            this.label14.TabIndex = 2;
            this.label14.Text = "Wschód Słońca:";
            // 
            // labelSunrise
            // 
            this.labelSunrise.AutoSize = true;
            this.labelSunrise.Location = new System.Drawing.Point(226, 332);
            this.labelSunrise.Name = "labelSunrise";
            this.labelSunrise.Size = new System.Drawing.Size(10, 13);
            this.labelSunrise.TabIndex = 2;
            this.labelSunrise.Text = "-";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label16.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label16.Location = new System.Drawing.Point(33, 362);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(121, 17);
            this.label16.TabIndex = 2;
            this.label16.Text = "Zachód Słońca:";
            // 
            // labelSunset
            // 
            this.labelSunset.AutoSize = true;
            this.labelSunset.Location = new System.Drawing.Point(225, 367);
            this.labelSunset.Name = "labelSunset";
            this.labelSunset.Size = new System.Drawing.Size(10, 13);
            this.labelSunset.TabIndex = 2;
            this.labelSunset.Text = "-";
            // 
            // btnWeather
            // 
            this.btnWeather.Location = new System.Drawing.Point(139, 70);
            this.btnWeather.Name = "btnWeather";
            this.btnWeather.Size = new System.Drawing.Size(250, 23);
            this.btnWeather.TabIndex = 3;
            this.btnWeather.Text = "Wyświetl pogodę";
            this.btnWeather.UseVisualStyleBackColor = true;
            this.btnWeather.Click += new System.EventHandler(this.btnWeather_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.pictureWeather);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.labelCity);
            this.groupBox1.Controls.Add(this.labelSunset);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.labelTemperature);
            this.groupBox1.Controls.Add(this.labelSunrise);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.labelPressure);
            this.groupBox1.Controls.Add(this.labelHumidity);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.labelWind);
            this.groupBox1.Controls.Add(this.labelClouds);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(50, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 412);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dane pogodowe";
            // 
            // pictureWeather
            // 
            this.pictureWeather.Location = new System.Drawing.Point(215, 19);
            this.pictureWeather.Name = "pictureWeather";
            this.pictureWeather.Size = new System.Drawing.Size(76, 68);
            this.pictureWeather.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureWeather.TabIndex = 9;
            this.pictureWeather.TabStop = false;
            // 
            // btnCSV
            // 
            this.btnCSV.Location = new System.Drawing.Point(425, 133);
            this.btnCSV.Name = "btnCSV";
            this.btnCSV.Size = new System.Drawing.Size(190, 23);
            this.btnCSV.TabIndex = 5;
            this.btnCSV.Text = "Zapisz do pliku CSV";
            this.btnCSV.UseVisualStyleBackColor = true;
            this.btnCSV.Click += new System.EventHandler(this.btnCSV_Click);
            // 
            // btnPDF
            // 
            this.btnPDF.Location = new System.Drawing.Point(425, 178);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(190, 23);
            this.btnPDF.TabIndex = 6;
            this.btnPDF.Text = "Zapisz do pliku PDF";
            this.btnPDF.UseVisualStyleBackColor = true;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // btnTXT
            // 
            this.btnTXT.Location = new System.Drawing.Point(425, 225);
            this.btnTXT.Name = "btnTXT";
            this.btnTXT.Size = new System.Drawing.Size(190, 23);
            this.btnTXT.TabIndex = 7;
            this.btnTXT.Text = "Zapisz do pliku TXT";
            this.btnTXT.UseVisualStyleBackColor = true;
            this.btnTXT.Click += new System.EventHandler(this.btnTXT_Click);
            // 
            // btnSendMail
            // 
            this.btnSendMail.Location = new System.Drawing.Point(425, 300);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.Size = new System.Drawing.Size(190, 46);
            this.btnSendMail.TabIndex = 8;
            this.btnSendMail.Text = "Wyślij e-mail";
            this.btnSendMail.UseVisualStyleBackColor = true;
            this.btnSendMail.Click += new System.EventHandler(this.btnSendMail_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(462, 495);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(153, 50);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Zamknij";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 578);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSendMail);
            this.Controls.Add(this.btnTXT);
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.btnCSV);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnWeather);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxCity);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureWeather)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelTemperature;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelPressure;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelWind;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelClouds;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelHumidity;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label labelSunrise;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label labelSunset;
        private System.Windows.Forms.Button btnWeather;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCSV;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Button btnTXT;
        private System.Windows.Forms.Button btnSendMail;
        private System.Windows.Forms.PictureBox pictureWeather;
        private System.Windows.Forms.Button btnClose;
    }
}

