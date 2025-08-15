namespace WeatherAPI
{
    partial class frmWeatherAPI
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
            this.btnxml = new System.Windows.Forms.Button();
            this.btnjson = new System.Windows.Forms.Button();
            this.txtzipcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtlatitude = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtlongitude = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txttemperature = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtlow = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txthigh = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtfeelslike = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtclouds = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtwind = new System.Windows.Forms.TextBox();
            this.btnclose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnxml
            // 
            this.btnxml.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnxml.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxml.ForeColor = System.Drawing.Color.Purple;
            this.btnxml.Location = new System.Drawing.Point(36, 12);
            this.btnxml.Name = "btnxml";
            this.btnxml.Size = new System.Drawing.Size(317, 59);
            this.btnxml.TabIndex = 0;
            this.btnxml.Text = "Get Weather (XML)";
            this.btnxml.UseVisualStyleBackColor = false;
            // 
            // btnjson
            // 
            this.btnjson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnjson.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnjson.ForeColor = System.Drawing.Color.Purple;
            this.btnjson.Location = new System.Drawing.Point(36, 86);
            this.btnjson.Name = "btnjson";
            this.btnjson.Size = new System.Drawing.Size(317, 56);
            this.btnjson.TabIndex = 1;
            this.btnjson.Text = "Get Weather (JSON)";
            this.btnjson.UseVisualStyleBackColor = false;
            // 
            // txtzipcode
            // 
            this.txtzipcode.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtzipcode.Location = new System.Drawing.Point(38, 238);
            this.txtzipcode.Name = "txtzipcode";
            this.txtzipcode.Size = new System.Drawing.Size(295, 30);
            this.txtzipcode.TabIndex = 2;
            this.txtzipcode.Text = "78758";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter a Zip Code:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "City";
            // 
            // txtcity
            // 
            this.txtcity.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcity.Location = new System.Drawing.Point(37, 169);
            this.txtcity.Name = "txtcity";
            this.txtcity.ReadOnly = true;
            this.txtcity.Size = new System.Drawing.Size(295, 30);
            this.txtcity.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Latitude";
            // 
            // txtlatitude
            // 
            this.txtlatitude.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlatitude.Location = new System.Drawing.Point(36, 302);
            this.txtlatitude.Name = "txtlatitude";
            this.txtlatitude.ReadOnly = true;
            this.txtlatitude.Size = new System.Drawing.Size(137, 30);
            this.txtlatitude.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(191, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Longitude";
            // 
            // txtlongitude
            // 
            this.txtlongitude.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlongitude.Location = new System.Drawing.Point(194, 302);
            this.txtlongitude.Name = "txtlongitude";
            this.txtlongitude.ReadOnly = true;
            this.txtlongitude.Size = new System.Drawing.Size(137, 30);
            this.txtlongitude.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 348);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Temperature";
            // 
            // txttemperature
            // 
            this.txttemperature.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttemperature.Location = new System.Drawing.Point(35, 369);
            this.txttemperature.Name = "txttemperature";
            this.txttemperature.ReadOnly = true;
            this.txttemperature.Size = new System.Drawing.Size(100, 30);
            this.txttemperature.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(151, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 23);
            this.label5.TabIndex = 15;
            this.label5.Text = "Low";
            // 
            // txtlow
            // 
            this.txtlow.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlow.Location = new System.Drawing.Point(154, 369);
            this.txtlow.Name = "txtlow";
            this.txtlow.ReadOnly = true;
            this.txtlow.Size = new System.Drawing.Size(52, 30);
            this.txtlow.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(216, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 23);
            this.label7.TabIndex = 17;
            this.label7.Text = "High";
            // 
            // txthigh
            // 
            this.txthigh.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthigh.Location = new System.Drawing.Point(219, 369);
            this.txthigh.Name = "txthigh";
            this.txthigh.ReadOnly = true;
            this.txthigh.Size = new System.Drawing.Size(52, 30);
            this.txthigh.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(286, 348);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 23);
            this.label8.TabIndex = 19;
            this.label8.Text = "Feels Like";
            // 
            // txtfeelslike
            // 
            this.txtfeelslike.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfeelslike.Location = new System.Drawing.Point(289, 369);
            this.txtfeelslike.Name = "txtfeelslike";
            this.txtfeelslike.ReadOnly = true;
            this.txtfeelslike.Size = new System.Drawing.Size(82, 30);
            this.txtfeelslike.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(190, 411);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 23);
            this.label9.TabIndex = 23;
            this.label9.Text = "Clouds";
            // 
            // txtclouds
            // 
            this.txtclouds.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtclouds.Location = new System.Drawing.Point(193, 432);
            this.txtclouds.Name = "txtclouds";
            this.txtclouds.ReadOnly = true;
            this.txtclouds.Size = new System.Drawing.Size(137, 30);
            this.txtclouds.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(32, 411);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 23);
            this.label10.TabIndex = 21;
            this.label10.Text = "Wind";
            // 
            // txtwind
            // 
            this.txtwind.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtwind.Location = new System.Drawing.Point(35, 432);
            this.txtwind.Name = "txtwind";
            this.txtwind.ReadOnly = true;
            this.txtwind.Size = new System.Drawing.Size(137, 30);
            this.txtwind.TabIndex = 20;
            // 
            // btnclose
            // 
            this.btnclose.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.Red;
            this.btnclose.Location = new System.Drawing.Point(306, 471);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(87, 32);
            this.btnclose.TabIndex = 24;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmWeatherAPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(405, 515);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtclouds);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtwind);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtfeelslike);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txthigh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtlow);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txttemperature);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtlongitude);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtlatitude);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtzipcode);
            this.Controls.Add(this.btnjson);
            this.Controls.Add(this.btnxml);
            this.Name = "frmWeatherAPI";
            this.Text = "Weather API";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnxml;
        private System.Windows.Forms.Button btnjson;
        private System.Windows.Forms.TextBox txtzipcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtlatitude;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtlongitude;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txttemperature;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtlow;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txthigh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtfeelslike;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtclouds;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtwind;
        private System.Windows.Forms.Button btnclose;
    }
}

