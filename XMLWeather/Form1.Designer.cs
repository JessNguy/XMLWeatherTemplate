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
            this.pictureBoxLocation = new System.Windows.Forms.PictureBox();
            this.pictureBoxWind = new System.Windows.Forms.PictureBox();
            this.pictureBoxArrowDown = new System.Windows.Forms.PictureBox();
            this.pictureBoxUpArrow = new System.Windows.Forms.PictureBox();
            this.pictureBoxTemp = new System.Windows.Forms.PictureBox();
            this.labelTemp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArrowDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUpArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTemp)).BeginInit();
            this.SuspendLayout();
            // 
            // cityOutput
            // 
            this.cityOutput.AutoSize = true;
            this.cityOutput.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityOutput.Location = new System.Drawing.Point(225, 68);
            this.cityOutput.Name = "cityOutput";
            this.cityOutput.Size = new System.Drawing.Size(89, 49);
            this.cityOutput.TabIndex = 0;
            this.cityOutput.Text = "City";
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMax.Location = new System.Drawing.Point(124, 324);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(72, 38);
            this.labelMax.TabIndex = 3;
            this.labelMax.Text = "Max";
            this.labelMax.Visible = false;
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMin.Location = new System.Drawing.Point(465, 320);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(63, 38);
            this.labelMin.TabIndex = 4;
            this.labelMin.Text = "Min";
            this.labelMin.Visible = false;
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountry.Location = new System.Drawing.Point(281, 28);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(150, 49);
            this.labelCountry.TabIndex = 9;
            this.labelCountry.Text = "Country";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(202, 239);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(98, 49);
            this.labelDate.TabIndex = 11;
            this.labelDate.Text = "date";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelType.Location = new System.Drawing.Point(227, 288);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(178, 38);
            this.labelType.TabIndex = 12;
            this.labelType.Text = "Type of day";
            this.labelType.Visible = false;
            // 
            // labelWindSpd
            // 
            this.labelWindSpd.AutoSize = true;
            this.labelWindSpd.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWindSpd.Location = new System.Drawing.Point(241, 374);
            this.labelWindSpd.Name = "labelWindSpd";
            this.labelWindSpd.Size = new System.Drawing.Size(118, 38);
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
            this.buttonDay1.Text = "Day 1 (Today)";
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
            // pictureBoxLocation
            // 
            this.pictureBoxLocation.Image = global::XMLWeather.Properties.Resources.Location_icon;
            this.pictureBoxLocation.Location = new System.Drawing.Point(225, 28);
            this.pictureBoxLocation.Name = "pictureBoxLocation";
            this.pictureBoxLocation.Size = new System.Drawing.Size(60, 48);
            this.pictureBoxLocation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLocation.TabIndex = 24;
            this.pictureBoxLocation.TabStop = false;
            // 
            // pictureBoxWind
            // 
            this.pictureBoxWind.Image = global::XMLWeather.Properties.Resources._1;
            this.pictureBoxWind.Location = new System.Drawing.Point(195, 374);
            this.pictureBoxWind.Name = "pictureBoxWind";
            this.pictureBoxWind.Size = new System.Drawing.Size(50, 42);
            this.pictureBoxWind.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxWind.TabIndex = 16;
            this.pictureBoxWind.TabStop = false;
            // 
            // pictureBoxArrowDown
            // 
            this.pictureBoxArrowDown.Image = global::XMLWeather.Properties.Resources.downArrow;
            this.pictureBoxArrowDown.Location = new System.Drawing.Point(411, 320);
            this.pictureBoxArrowDown.Name = "pictureBoxArrowDown";
            this.pictureBoxArrowDown.Size = new System.Drawing.Size(55, 42);
            this.pictureBoxArrowDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxArrowDown.TabIndex = 15;
            this.pictureBoxArrowDown.TabStop = false;
            this.pictureBoxArrowDown.Visible = false;
            // 
            // pictureBoxUpArrow
            // 
            this.pictureBoxUpArrow.Image = global::XMLWeather.Properties.Resources.arrow;
            this.pictureBoxUpArrow.Location = new System.Drawing.Point(82, 322);
            this.pictureBoxUpArrow.Name = "pictureBoxUpArrow";
            this.pictureBoxUpArrow.Size = new System.Drawing.Size(51, 42);
            this.pictureBoxUpArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUpArrow.TabIndex = 14;
            this.pictureBoxUpArrow.TabStop = false;
            this.pictureBoxUpArrow.Visible = false;
            // 
            // pictureBoxTemp
            // 
            this.pictureBoxTemp.Location = new System.Drawing.Point(248, 130);
            this.pictureBoxTemp.Name = "pictureBoxTemp";
            this.pictureBoxTemp.Size = new System.Drawing.Size(133, 94);
            this.pictureBoxTemp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTemp.TabIndex = 10;
            this.pictureBoxTemp.TabStop = false;
            // 
            // labelTemp
            // 
            this.labelTemp.AutoSize = true;
            this.labelTemp.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTemp.Location = new System.Drawing.Point(225, 298);
            this.labelTemp.Name = "labelTemp";
            this.labelTemp.Size = new System.Drawing.Size(0, 51);
            this.labelTemp.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(675, 526);
            this.Controls.Add(this.labelTemp);
            this.Controls.Add(this.pictureBoxLocation);
            this.Controls.Add(this.buttonDay7);
            this.Controls.Add(this.buttonDay6);
            this.Controls.Add(this.buttonDay5);
            this.Controls.Add(this.buttonDay4);
            this.Controls.Add(this.buttonDay3);
            this.Controls.Add(this.buttonDay2);
            this.Controls.Add(this.buttonDay1);
            this.Controls.Add(this.pictureBoxWind);
            this.Controls.Add(this.pictureBoxArrowDown);
            this.Controls.Add(this.pictureBoxUpArrow);
            this.Controls.Add(this.labelWindSpd);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.pictureBoxTemp);
            this.Controls.Add(this.labelCountry);
            this.Controls.Add(this.labelMin);
            this.Controls.Add(this.labelMax);
            this.Controls.Add(this.cityOutput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Central Weather";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArrowDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUpArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTemp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cityOutput;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.PictureBox pictureBoxTemp;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelWindSpd;
        private System.Windows.Forms.PictureBox pictureBoxUpArrow;
        private System.Windows.Forms.PictureBox pictureBoxArrowDown;
        private System.Windows.Forms.PictureBox pictureBoxWind;
        private System.Windows.Forms.Button buttonDay1;
        private System.Windows.Forms.Button buttonDay2;
        private System.Windows.Forms.Button buttonDay3;
        private System.Windows.Forms.Button buttonDay4;
        private System.Windows.Forms.Button buttonDay5;
        private System.Windows.Forms.Button buttonDay6;
        private System.Windows.Forms.Button buttonDay7;
        private System.Windows.Forms.PictureBox pictureBoxLocation;
        private System.Windows.Forms.Label labelTemp;
    }
}

