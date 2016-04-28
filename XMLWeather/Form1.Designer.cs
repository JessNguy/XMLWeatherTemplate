namespace XMLWeather
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cityOutput = new System.Windows.Forms.Label();
            this.labelTemp = new System.Windows.Forms.Label();
            this.labelMax = new System.Windows.Forms.Label();
            this.labelMin = new System.Windows.Forms.Label();
            this.labelCountry = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelWindSpd = new System.Windows.Forms.Label();
            this.buttonDay1 = new System.Windows.Forms.Button();
            this.buttonDay2 = new System.Windows.Forms.Button();
            this.buttonDay3 = new System.Windows.Forms.Button();
            this.buttonDay4 = new System.Windows.Forms.Button();
            this.buttonDay5 = new System.Windows.Forms.Button();
            this.buttonDay6 = new System.Windows.Forms.Button();
            this.buttonDay7 = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelCloud1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cityOutput
            // 
            this.cityOutput.AutoSize = true;
            this.cityOutput.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityOutput.Location = new System.Drawing.Point(237, 87);
            this.cityOutput.Name = "cityOutput";
            this.cityOutput.Size = new System.Drawing.Size(70, 38);
            this.cityOutput.TabIndex = 0;
            this.cityOutput.Text = "City";
            // 
            // labelTemp
            // 
            this.labelTemp.AutoSize = true;
            this.labelTemp.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTemp.Location = new System.Drawing.Point(239, 258);
            this.labelTemp.Name = "labelTemp";
            this.labelTemp.Size = new System.Drawing.Size(118, 51);
            this.labelTemp.TabIndex = 1;
            this.labelTemp.Text = "Temp";
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMax.Location = new System.Drawing.Point(174, 393);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(56, 30);
            this.labelMax.TabIndex = 3;
            this.labelMax.Text = "Max";
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMin.Location = new System.Drawing.Point(294, 393);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(49, 30);
            this.labelMin.TabIndex = 4;
            this.labelMin.Text = "Min";
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountry.Location = new System.Drawing.Point(283, 49);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(117, 38);
            this.labelCountry.TabIndex = 9;
            this.labelCountry.Text = "Country";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(151, 307);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(66, 35);
            this.labelDate.TabIndex = 11;
            this.labelDate.Text = "date";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelType.Location = new System.Drawing.Point(218, 338);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(139, 30);
            this.labelType.TabIndex = 12;
            this.labelType.Text = "Type of day";
            // 
            // labelWindSpd
            // 
            this.labelWindSpd.AutoSize = true;
            this.labelWindSpd.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWindSpd.Location = new System.Drawing.Point(402, 393);
            this.labelWindSpd.Name = "labelWindSpd";
            this.labelWindSpd.Size = new System.Drawing.Size(91, 30);
            this.labelWindSpd.TabIndex = 13;
            this.labelWindSpd.Text = "W.Spd.";
            // 
            // buttonDay1
            // 
            this.buttonDay1.BackColor = System.Drawing.Color.Red;
            this.buttonDay1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonDay1.FlatAppearance.BorderSize = 0;
            this.buttonDay1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonDay1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonDay1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDay1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDay1.ForeColor = System.Drawing.Color.White;
            this.buttonDay1.Location = new System.Drawing.Point(5, 449);
            this.buttonDay1.Name = "buttonDay1";
            this.buttonDay1.Size = new System.Drawing.Size(96, 57);
            this.buttonDay1.TabIndex = 17;
            this.buttonDay1.Text = "DAY 1";
            this.buttonDay1.UseVisualStyleBackColor = false;
            this.buttonDay1.Click += new System.EventHandler(this.buttonDay1_Click);
            // 
            // buttonDay2
            // 
            this.buttonDay2.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonDay2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonDay2.FlatAppearance.BorderSize = 0;
            this.buttonDay2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDay2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDay2.ForeColor = System.Drawing.Color.White;
            this.buttonDay2.Location = new System.Drawing.Point(100, 449);
            this.buttonDay2.Name = "buttonDay2";
            this.buttonDay2.Size = new System.Drawing.Size(96, 57);
            this.buttonDay2.TabIndex = 18;
            this.buttonDay2.Text = "Day 2";
            this.buttonDay2.UseVisualStyleBackColor = false;
            this.buttonDay2.Click += new System.EventHandler(this.buttonDay2_Click);
            // 
            // buttonDay3
            // 
            this.buttonDay3.BackColor = System.Drawing.Color.Yellow;
            this.buttonDay3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonDay3.FlatAppearance.BorderSize = 0;
            this.buttonDay3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDay3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDay3.ForeColor = System.Drawing.Color.White;
            this.buttonDay3.Location = new System.Drawing.Point(195, 449);
            this.buttonDay3.Name = "buttonDay3";
            this.buttonDay3.Size = new System.Drawing.Size(96, 57);
            this.buttonDay3.TabIndex = 19;
            this.buttonDay3.Text = "Day 3";
            this.buttonDay3.UseVisualStyleBackColor = false;
            this.buttonDay3.Click += new System.EventHandler(this.buttonDay3_Click);
            // 
            // buttonDay4
            // 
            this.buttonDay4.BackColor = System.Drawing.Color.Lime;
            this.buttonDay4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonDay4.FlatAppearance.BorderSize = 0;
            this.buttonDay4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDay4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDay4.ForeColor = System.Drawing.Color.White;
            this.buttonDay4.Location = new System.Drawing.Point(290, 449);
            this.buttonDay4.Name = "buttonDay4";
            this.buttonDay4.Size = new System.Drawing.Size(96, 57);
            this.buttonDay4.TabIndex = 20;
            this.buttonDay4.Text = "Day 4";
            this.buttonDay4.UseVisualStyleBackColor = false;
            this.buttonDay4.Click += new System.EventHandler(this.buttonDay4_Click);
            // 
            // buttonDay5
            // 
            this.buttonDay5.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonDay5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonDay5.FlatAppearance.BorderSize = 0;
            this.buttonDay5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDay5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDay5.ForeColor = System.Drawing.Color.White;
            this.buttonDay5.Location = new System.Drawing.Point(385, 449);
            this.buttonDay5.Name = "buttonDay5";
            this.buttonDay5.Size = new System.Drawing.Size(96, 57);
            this.buttonDay5.TabIndex = 21;
            this.buttonDay5.Text = "Day 5";
            this.buttonDay5.UseVisualStyleBackColor = false;
            this.buttonDay5.Click += new System.EventHandler(this.buttonDay5_Click);
            // 
            // buttonDay6
            // 
            this.buttonDay6.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonDay6.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonDay6.FlatAppearance.BorderSize = 0;
            this.buttonDay6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDay6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDay6.ForeColor = System.Drawing.Color.White;
            this.buttonDay6.Location = new System.Drawing.Point(480, 449);
            this.buttonDay6.Name = "buttonDay6";
            this.buttonDay6.Size = new System.Drawing.Size(96, 57);
            this.buttonDay6.TabIndex = 22;
            this.buttonDay6.Text = "Day 6";
            this.buttonDay6.UseVisualStyleBackColor = false;
            this.buttonDay6.Click += new System.EventHandler(this.buttonDay6_Click);
            // 
            // buttonDay7
            // 
            this.buttonDay7.BackColor = System.Drawing.Color.Purple;
            this.buttonDay7.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonDay7.FlatAppearance.BorderSize = 0;
            this.buttonDay7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDay7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDay7.ForeColor = System.Drawing.Color.White;
            this.buttonDay7.Location = new System.Drawing.Point(575, 449);
            this.buttonDay7.Name = "buttonDay7";
            this.buttonDay7.Size = new System.Drawing.Size(96, 57);
            this.buttonDay7.TabIndex = 23;
            this.buttonDay7.Text = "Day 7";
            this.buttonDay7.UseVisualStyleBackColor = false;
            this.buttonDay7.Click += new System.EventHandler(this.buttonDay7_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::XMLWeather.Properties.Resources.Location_icon;
            this.pictureBox5.Location = new System.Drawing.Point(231, 36);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(60, 48);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 24;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::XMLWeather.Properties.Resources.Location_icon;
            this.pictureBox4.Location = new System.Drawing.Point(356, 393);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 30);
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::XMLWeather.Properties.Resources.downArrow;
            this.pictureBox3.Location = new System.Drawing.Point(248, 393);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::XMLWeather.Properties.Resources.arrow;
            this.pictureBox2.Location = new System.Drawing.Point(138, 393);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(231, 147);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 94);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // labelCloud1
            // 
            this.labelCloud1.AutoSize = true;
            this.labelCloud1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCloud1.Location = new System.Drawing.Point(501, 354);
            this.labelCloud1.Name = "labelCloud1";
            this.labelCloud1.Size = new System.Drawing.Size(91, 30);
            this.labelCloud1.TabIndex = 25;
            this.labelCloud1.Text = "W.Spd.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 526);
            this.Controls.Add(this.labelCloud1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.buttonDay7);
            this.Controls.Add(this.buttonDay6);
            this.Controls.Add(this.buttonDay5);
            this.Controls.Add(this.buttonDay4);
            this.Controls.Add(this.buttonDay3);
            this.Controls.Add(this.buttonDay2);
            this.Controls.Add(this.buttonDay1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.labelWindSpd);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelCountry);
            this.Controls.Add(this.labelMin);
            this.Controls.Add(this.labelMax);
            this.Controls.Add(this.labelTemp);
            this.Controls.Add(this.cityOutput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Central Weather";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cityOutput;
        private System.Windows.Forms.Label labelTemp;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelWindSpd;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button buttonDay1;
        private System.Windows.Forms.Button buttonDay2;
        private System.Windows.Forms.Button buttonDay3;
        private System.Windows.Forms.Button buttonDay4;
        private System.Windows.Forms.Button buttonDay5;
        private System.Windows.Forms.Button buttonDay6;
        private System.Windows.Forms.Button buttonDay7;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label labelCloud1;
    }
}

