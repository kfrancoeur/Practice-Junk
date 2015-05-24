namespace SimpleWeatherTest
{
    partial class WeatherWindow
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
            this.ZipText = new System.Windows.Forms.TextBox();
            this.TemperatureButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LocLabel = new System.Windows.Forms.Label();
            this.LocText = new System.Windows.Forms.TextBox();
            this.TemperatureText = new System.Windows.Forms.TextBox();
            this.TempLabel = new System.Windows.Forms.Label();
            this.CTempRadio = new System.Windows.Forms.RadioButton();
            this.FTempRadio = new System.Windows.Forms.RadioButton();
            this.TempChoice = new System.Windows.Forms.Label();
            this.KTempRadio = new System.Windows.Forms.RadioButton();
            this.RTempRadio = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // ZipText
            // 
            this.ZipText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ZipText.Location = new System.Drawing.Point(68, 12);
            this.ZipText.Name = "ZipText";
            this.ZipText.Size = new System.Drawing.Size(100, 20);
            this.ZipText.TabIndex = 1;
            this.ZipText.Text = "29732";
            // 
            // TemperatureButton
            // 
            this.TemperatureButton.Location = new System.Drawing.Point(12, 38);
            this.TemperatureButton.Name = "TemperatureButton";
            this.TemperatureButton.Size = new System.Drawing.Size(75, 44);
            this.TemperatureButton.TabIndex = 0;
            this.TemperatureButton.Text = "Pull Weather";
            this.TemperatureButton.UseVisualStyleBackColor = true;
            this.TemperatureButton.Click += new System.EventHandler(this.TemperatureButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Zip Code";
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(93, 38);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 44);
            this.ClearButton.TabIndex = 3;
            this.ClearButton.Text = "Clear Weather";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "us"});
            this.comboBox1.Location = new System.Drawing.Point(223, 11);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Text = "us";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(174, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Country";
            // 
            // LocLabel
            // 
            this.LocLabel.AutoSize = true;
            this.LocLabel.Location = new System.Drawing.Point(3, 99);
            this.LocLabel.Name = "LocLabel";
            this.LocLabel.Size = new System.Drawing.Size(48, 13);
            this.LocLabel.TabIndex = 6;
            this.LocLabel.Text = "Location";
            // 
            // LocText
            // 
            this.LocText.Location = new System.Drawing.Point(53, 96);
            this.LocText.Name = "LocText";
            this.LocText.ReadOnly = true;
            this.LocText.Size = new System.Drawing.Size(100, 20);
            this.LocText.TabIndex = 7;
            // 
            // TemperatureText
            // 
            this.TemperatureText.Location = new System.Drawing.Point(244, 96);
            this.TemperatureText.Name = "TemperatureText";
            this.TemperatureText.ReadOnly = true;
            this.TemperatureText.Size = new System.Drawing.Size(100, 20);
            this.TemperatureText.TabIndex = 9;
            // 
            // TempLabel
            // 
            this.TempLabel.AutoSize = true;
            this.TempLabel.Location = new System.Drawing.Point(171, 99);
            this.TempLabel.Name = "TempLabel";
            this.TempLabel.Size = new System.Drawing.Size(67, 13);
            this.TempLabel.TabIndex = 8;
            this.TempLabel.Text = "Temperature";
            // 
            // CTempRadio
            // 
            this.CTempRadio.AutoSize = true;
            this.CTempRadio.Checked = true;
            this.CTempRadio.Location = new System.Drawing.Point(274, 38);
            this.CTempRadio.Name = "CTempRadio";
            this.CTempRadio.Size = new System.Drawing.Size(32, 17);
            this.CTempRadio.TabIndex = 14;
            this.CTempRadio.Tag = "1";
            this.CTempRadio.Text = "C";
            this.CTempRadio.UseVisualStyleBackColor = true;
            // 
            // FTempRadio
            // 
            this.FTempRadio.AutoSize = true;
            this.FTempRadio.Location = new System.Drawing.Point(313, 38);
            this.FTempRadio.Name = "FTempRadio";
            this.FTempRadio.Size = new System.Drawing.Size(31, 17);
            this.FTempRadio.TabIndex = 15;
            this.FTempRadio.Tag = "2";
            this.FTempRadio.Text = "F";
            this.FTempRadio.UseVisualStyleBackColor = true;
            // 
            // TempChoice
            // 
            this.TempChoice.AutoSize = true;
            this.TempChoice.Enabled = false;
            this.TempChoice.Location = new System.Drawing.Point(204, 40);
            this.TempChoice.Name = "TempChoice";
            this.TempChoice.Size = new System.Drawing.Size(64, 13);
            this.TempChoice.TabIndex = 16;
            this.TempChoice.Text = "Temp Scale";
            // 
            // KTempRadio
            // 
            this.KTempRadio.AutoSize = true;
            this.KTempRadio.Location = new System.Drawing.Point(274, 61);
            this.KTempRadio.Name = "KTempRadio";
            this.KTempRadio.Size = new System.Drawing.Size(32, 17);
            this.KTempRadio.TabIndex = 19;
            this.KTempRadio.Tag = "3";
            this.KTempRadio.Text = "K";
            this.KTempRadio.UseVisualStyleBackColor = true;
            // 
            // RTempRadio
            // 
            this.RTempRadio.AutoSize = true;
            this.RTempRadio.Location = new System.Drawing.Point(313, 61);
            this.RTempRadio.Name = "RTempRadio";
            this.RTempRadio.Size = new System.Drawing.Size(33, 17);
            this.RTempRadio.TabIndex = 20;
            this.RTempRadio.Tag = "4";
            this.RTempRadio.Text = "R";
            this.RTempRadio.UseVisualStyleBackColor = true;
            // 
            // WeatherWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 141);
            this.Controls.Add(this.RTempRadio);
            this.Controls.Add(this.KTempRadio);
            this.Controls.Add(this.TempChoice);
            this.Controls.Add(this.FTempRadio);
            this.Controls.Add(this.CTempRadio);
            this.Controls.Add(this.TemperatureText);
            this.Controls.Add(this.TempLabel);
            this.Controls.Add(this.LocText);
            this.Controls.Add(this.LocLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TemperatureButton);
            this.Controls.Add(this.ZipText);
            this.Name = "WeatherWindow";
            this.Text = "Weather!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ZipText;
        private System.Windows.Forms.Button TemperatureButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LocLabel;
        private System.Windows.Forms.TextBox LocText;
        private System.Windows.Forms.TextBox TemperatureText;
        private System.Windows.Forms.Label TempLabel;
        private System.Windows.Forms.RadioButton CTempRadio;
        private System.Windows.Forms.RadioButton FTempRadio;
        private System.Windows.Forms.Label TempChoice;
        private System.Windows.Forms.RadioButton KTempRadio;
        private System.Windows.Forms.RadioButton RTempRadio;
    }
}

