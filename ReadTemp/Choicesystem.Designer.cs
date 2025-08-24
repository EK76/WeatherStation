namespace ReadTemp
{
    partial class FormChoiceSystem
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
            radioButtonDatabase = new RadioButton();
            radioButtonText = new RadioButton();
            SuspendLayout();
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(95, 138);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(75, 23);
            buttonOk.TabIndex = 0;
            buttonOk.Text = "OK";
            buttonOk.Click += buttonOk_Click;
            // 
            // radioButtonDatabase
            // 
            radioButtonDatabase.AutoSize = true;
            radioButtonDatabase.Checked = true;
            radioButtonDatabase.Location = new Point(11, 23);
            radioButtonDatabase.Name = "radioButtonDatabase";
            radioButtonDatabase.Size = new Size(162, 19);
            radioButtonDatabase.TabIndex = 1;
            radioButtonDatabase.TabStop = true;
            radioButtonDatabase.Text = "Database and text version.";
            radioButtonDatabase.UseVisualStyleBackColor = true;
            // 
            // radioButtonText
            // 
            radioButtonText.AutoSize = true;
            radioButtonText.Location = new Point(11, 75);
            radioButtonText.Name = "radioButtonText";
            radioButtonText.Size = new Size(116, 19);
            radioButtonText.TabIndex = 2;
            radioButtonText.Text = "Text version only.";
            radioButtonText.UseVisualStyleBackColor = true;
            // 
            // FormChoiceSystem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(182, 179);
            Controls.Add(radioButtonText);
            Controls.Add(radioButtonDatabase);
            Controls.Add(buttonOk);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormChoiceSystem";
            ShowIcon = false;
            Text = "Weather Station";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOk;
        private RadioButton radioButtonDatabase;
        private RadioButton radioButtonText;
    }
}