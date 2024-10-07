namespace ReadTemp
{
    partial class FormAbout
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
            labelText1 = new System.Windows.Forms.Label();
            labelText2 = new System.Windows.Forms.Label();
            labelText3 = new System.Windows.Forms.Label();
            labelText4 = new System.Windows.Forms.Label();
            buttonClose = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelText1
            // 
            labelText1.AutoSize = true;
            labelText1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelText1.ForeColor = System.Drawing.Color.Black;
            labelText1.Location = new System.Drawing.Point(45, 9);
            labelText1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelText1.Name = "labelText1";
            labelText1.Size = new System.Drawing.Size(132, 26);
            labelText1.TabIndex = 0;
            labelText1.Text = "Weather Info ";
            // 
            // labelText2
            // 
            labelText2.AutoSize = true;
            labelText2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            labelText2.ForeColor = System.Drawing.Color.Black;
            labelText2.Location = new System.Drawing.Point(51, 63);
            labelText2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelText2.Name = "labelText2";
            labelText2.Size = new System.Drawing.Size(93, 21);
            labelText2.TabIndex = 1;
            labelText2.Text = "Version 2.1";
            // 
            // labelText3
            // 
            labelText3.AutoSize = true;
            labelText3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            labelText3.ForeColor = System.Drawing.Color.Black;
            labelText3.Location = new System.Drawing.Point(27, 106);
            labelText3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelText3.Name = "labelText3";
            labelText3.Size = new System.Drawing.Size(141, 21);
            labelText3.TabIndex = 2;
            labelText3.Text = "2024 Ken Ekholm";
            // 
            // labelText4
            // 
            labelText4.AutoSize = true;
            labelText4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            labelText4.ForeColor = System.Drawing.Color.Black;
            labelText4.Location = new System.Drawing.Point(13, 151);
            labelText4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelText4.Name = "labelText4";
            labelText4.Size = new System.Drawing.Size(199, 21);
            labelText4.TabIndex = 3;
            labelText4.Text = "@ ken.ekholm@live.com";
            // 
            // buttonClose
            // 
            buttonClose.BackColor = System.Drawing.SystemColors.Window;
            buttonClose.ForeColor = System.Drawing.Color.DarkSlateBlue;
            buttonClose.Location = new System.Drawing.Point(406, 224);
            buttonClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new System.Drawing.Size(88, 27);
            buttonClose.TabIndex = 4;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = false;
            buttonClose.Click += buttonClose_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox1.Location = new System.Drawing.Point(255, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(239, 209);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ControlLight;
            ClientSize = new System.Drawing.Size(500, 257);
            Controls.Add(pictureBox1);
            Controls.Add(buttonClose);
            Controls.Add(labelText4);
            Controls.Add(labelText3);
            Controls.Add(labelText2);
            Controls.Add(labelText1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            ShowIcon = false;
            Text = "Weather Info";
            Load += FormAbout_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelText1;
        private System.Windows.Forms.Label labelText2;
        private System.Windows.Forms.Label labelText3;
        private System.Windows.Forms.Label labelText4;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}