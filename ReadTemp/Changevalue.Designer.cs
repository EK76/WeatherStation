namespace ReadTemp
{
    partial class FormEditRow
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
            this.textBoxTemp = new System.Windows.Forms.TextBox();
            this.textBoxHum = new System.Windows.Forms.TextBox();
            this.textBoxPressure = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelTemp = new System.Windows.Forms.Label();
            this.labelHum = new System.Windows.Forms.Label();
            this.labelPressure = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxTemp
            // 
            this.textBoxTemp.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.textBoxTemp.Location = new System.Drawing.Point(105, 28);
            this.textBoxTemp.Name = "textBoxTemp";
            this.textBoxTemp.Size = new System.Drawing.Size(131, 24);
            this.textBoxTemp.TabIndex = 0;
            this.textBoxTemp.TextChanged += new System.EventHandler(this.textBoxTemp_TextChanged);
            this.textBoxTemp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTemp_KeyPress);
            // 
            // textBoxHum
            // 
            this.textBoxHum.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.textBoxHum.Location = new System.Drawing.Point(105, 79);
            this.textBoxHum.Name = "textBoxHum";
            this.textBoxHum.Size = new System.Drawing.Size(131, 24);
            this.textBoxHum.TabIndex = 1;
            this.textBoxHum.TextChanged += new System.EventHandler(this.textBoxHum_TextChanged);
            this.textBoxHum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxHum_KeyPress);
            // 
            // textBoxPressure
            // 
            this.textBoxPressure.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.textBoxPressure.Location = new System.Drawing.Point(105, 134);
            this.textBoxPressure.Name = "textBoxPressure";
            this.textBoxPressure.Size = new System.Drawing.Size(131, 24);
            this.textBoxPressure.TabIndex = 2;
            this.textBoxPressure.TextChanged += new System.EventHandler(this.textBoxPressure_TextChanged);
            this.textBoxPressure.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPressure_KeyPress);
            // 
            // buttonOk
            // 
            this.buttonOk.Enabled = false;
            this.buttonOk.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOk.Location = new System.Drawing.Point(69, 178);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 3;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Location = new System.Drawing.Point(161, 178);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelTemp
            // 
            this.labelTemp.AutoSize = true;
            this.labelTemp.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelTemp.Location = new System.Drawing.Point(12, 35);
            this.labelTemp.Name = "labelTemp";
            this.labelTemp.Size = new System.Drawing.Size(84, 17);
            this.labelTemp.TabIndex = 5;
            this.labelTemp.Text = "Temperature";
            // 
            // labelHum
            // 
            this.labelHum.AutoSize = true;
            this.labelHum.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelHum.Location = new System.Drawing.Point(15, 86);
            this.labelHum.Name = "labelHum";
            this.labelHum.Size = new System.Drawing.Size(62, 17);
            this.labelHum.TabIndex = 6;
            this.labelHum.Text = "Humidity";
            // 
            // labelPressure
            // 
            this.labelPressure.AutoSize = true;
            this.labelPressure.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelPressure.Location = new System.Drawing.Point(18, 137);
            this.labelPressure.Name = "labelPressure";
            this.labelPressure.Size = new System.Drawing.Size(59, 17);
            this.labelPressure.TabIndex = 7;
            this.labelPressure.Text = "Pressure";
            // 
            // FormEditRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 223);
            this.Controls.Add(this.labelPressure);
            this.Controls.Add(this.labelHum);
            this.Controls.Add(this.labelTemp);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textBoxPressure);
            this.Controls.Add(this.textBoxHum);
            this.Controls.Add(this.textBoxTemp);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEditRow";
            this.ShowIcon = false;
            this.Text = "Weather Station";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEditRow_FormClosing);
            this.Load += new System.EventHandler(this.FormEditRow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTemp;
        private System.Windows.Forms.TextBox textBoxHum;
        private System.Windows.Forms.TextBox textBoxPressure;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelTemp;
        private System.Windows.Forms.Label labelHum;
        private System.Windows.Forms.Label labelPressure;
    }
}