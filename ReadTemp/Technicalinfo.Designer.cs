namespace ReadTemp
{
    partial class FormTechnicalInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTechnicalInfo));
            buttonClose = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            labelText = new System.Windows.Forms.Label();
            labelText2 = new System.Windows.Forms.Label();
            labelText3 = new System.Windows.Forms.Label();
            labelText4 = new System.Windows.Forms.Label();
            pictureBox4 = new System.Windows.Forms.PictureBox();
            labelText5 = new System.Windows.Forms.Label();
            labelText6 = new System.Windows.Forms.Label();
            labelText7 = new System.Windows.Forms.Label();
            labelTex8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // buttonClose
            // 
            buttonClose.Location = new System.Drawing.Point(830, 737);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new System.Drawing.Size(75, 23);
            buttonClose.TabIndex = 0;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new System.Drawing.Point(26, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(313, 207);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox2.Location = new System.Drawing.Point(500, 80);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(177, 163);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new System.Drawing.Point(17, 353);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(438, 381);
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // labelText
            // 
            labelText.AutoSize = true;
            labelText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            labelText.Location = new System.Drawing.Point(26, 303);
            labelText.Name = "labelText";
            labelText.Size = new System.Drawing.Size(87, 15);
            labelText.TabIndex = 4;
            labelText.Text = "Raspberry PI 5";
            // 
            // labelText2
            // 
            labelText2.AutoSize = true;
            labelText2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            labelText2.Location = new System.Drawing.Point(500, 257);
            labelText2.Name = "labelText2";
            labelText2.Size = new System.Drawing.Size(87, 15);
            labelText2.TabIndex = 5;
            labelText2.Text = "Sensor DHT22";
            // 
            // labelText3
            // 
            labelText3.AutoSize = true;
            labelText3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelText3.Location = new System.Drawing.Point(17, 737);
            labelText3.Name = "labelText3";
            labelText3.Size = new System.Drawing.Size(83, 15);
            labelText3.TabIndex = 6;
            labelText3.Text = "My schematic";
            // 
            // labelText4
            // 
            labelText4.AutoSize = true;
            labelText4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelText4.Location = new System.Drawing.Point(26, 26);
            labelText4.Name = "labelText4";
            labelText4.Size = new System.Drawing.Size(616, 21);
            labelText4.TabIndex = 7;
            labelText4.Text = "This is the harware and schematic that are used by Weather Station application.";
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pictureBox4.Location = new System.Drawing.Point(707, 80);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new System.Drawing.Size(177, 163);
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // labelText5
            // 
            labelText5.AutoSize = true;
            labelText5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            labelText5.Location = new System.Drawing.Point(707, 257);
            labelText5.Name = "labelText5";
            labelText5.Size = new System.Drawing.Size(95, 15);
            labelText5.TabIndex = 9;
            labelText5.Text = "Sensor BMP180";
            // 
            // labelText6
            // 
            labelText6.AutoSize = true;
            labelText6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelText6.Location = new System.Drawing.Point(500, 289);
            labelText6.Name = "labelText6";
            labelText6.Size = new System.Drawing.Size(248, 15);
            labelText6.TabIndex = 10;
            labelText6.Text = "DHT22 is temperature and humitidy sensor.";
            // 
            // labelText7
            // 
            labelText7.AutoSize = true;
            labelText7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            labelText7.Location = new System.Drawing.Point(500, 314);
            labelText7.Name = "labelText7";
            labelText7.Size = new System.Drawing.Size(304, 15);
            labelText7.TabIndex = 11;
            labelText7.Text = "BMP180 is temperature, pressure and altitude sensor.";
            // 
            // labelTex8
            // 
            labelTex8.AutoSize = true;
            labelTex8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            labelTex8.Location = new System.Drawing.Point(476, 387);
            labelTex8.Name = "labelTex8";
            labelTex8.Size = new System.Drawing.Size(429, 255);
            labelTex8.TabIndex = 12;
            labelTex8.Text = resources.GetString("labelTex8.Text");
            // 
            // FormTechnicalInfo
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(917, 768);
            Controls.Add(labelTex8);
            Controls.Add(labelText7);
            Controls.Add(labelText6);
            Controls.Add(labelText5);
            Controls.Add(pictureBox4);
            Controls.Add(labelText4);
            Controls.Add(labelText3);
            Controls.Add(labelText2);
            Controls.Add(labelText);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(buttonClose);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormTechnicalInfo";
            Text = "Weather Station";
            Load += FormTechnicalInfo_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Label labelText2;
        private System.Windows.Forms.Label labelText3;
        private System.Windows.Forms.Label labelText4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label labelText5;
        private System.Windows.Forms.Label labelText6;
        private System.Windows.Forms.Label labelText7;
        private System.Windows.Forms.Label labelTex8;
    }
}