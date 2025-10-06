namespace ReadTemp
{
    partial class FormMessageBox
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
            buttonOk = new Button();
            buttonCancel = new Button();
            textBoxName = new TextBox();
            labelText = new Label();
            SuspendLayout();
            // 
            // buttonOk
            // 
            buttonOk.Font = new Font("Calibri", 10F, FontStyle.Bold);
            buttonOk.Location = new Point(12, 109);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(75, 23);
            buttonOk.TabIndex = 0;
            buttonOk.Text = "Ok";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Font = new Font("Calibri", 10F, FontStyle.Bold);
            buttonCancel.Location = new Point(224, 109);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Calibri", 10F, FontStyle.Bold);
            textBoxName.Location = new Point(12, 57);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(287, 24);
            textBoxName.TabIndex = 2;
            textBoxName.TextChanged += textBoxName_TextChanged;
            textBoxName.KeyPress += textBoxName_KeyPress;
            // 
            // labelText
            // 
            labelText.AutoSize = true;
            labelText.Font = new Font("Calibri", 10F, FontStyle.Bold);
            labelText.Location = new Point(15, 22);
            labelText.Name = "labelText";
            labelText.Size = new Size(43, 17);
            labelText.TabIndex = 3;
            labelText.Text = "label1";
            // 
            // FormMessageBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(310, 149);
            Controls.Add(labelText);
            Controls.Add(textBoxName);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOk);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMessageBox";
            ShowIcon = false;
            Text = "WeatherStation";
            Load += FormMessageBox_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOk;
        private Button buttonCancel;
        private TextBox textBoxName;
        private Label labelText;
    }
}