namespace ReadTemp
{
    partial class FormDesc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDesc));
            buttonOk = new Button();
            richTextBoxTableInfo = new RichTextBox();
            SuspendLayout();
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(633, 225);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(75, 23);
            buttonOk.TabIndex = 0;
            buttonOk.Text = "OK";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // richTextBoxTableInfo
            // 
            richTextBoxTableInfo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBoxTableInfo.Location = new Point(17, 17);
            richTextBoxTableInfo.Name = "richTextBoxTableInfo";
            richTextBoxTableInfo.Size = new Size(691, 202);
            richTextBoxTableInfo.TabIndex = 1;
            richTextBoxTableInfo.Text = resources.GetString("richTextBoxTableInfo.Text");
            // 
            // FormDesc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 255);
            Controls.Add(richTextBoxTableInfo);
            Controls.Add(buttonOk);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormDesc";
            ShowIcon = false;
            Text = "Weather Station.";
            Load += FormDesc_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button buttonOk;
        private RichTextBox richTextBoxTableInfo;
    }
}