namespace ReadTemp
{
    partial class FormChangePassword
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
            labelText1 = new Label();
            labelText2 = new Label();
            labelText3 = new Label();
            buttonSave = new Button();
            buttonClose = new Button();
            textBoxOldPassword = new TextBox();
            textBoxNewPassword = new TextBox();
            textBoxNewPassword2 = new TextBox();
            checkBoxShow = new CheckBox();
            SuspendLayout();
            // 
            // labelText1
            // 
            labelText1.AutoSize = true;
            labelText1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelText1.Location = new Point(18, 34);
            labelText1.Name = "labelText1";
            labelText1.Size = new Size(165, 15);
            labelText1.TabIndex = 0;
            labelText1.Text = "Type Old database password.";
            // 
            // labelText2
            // 
            labelText2.AutoSize = true;
            labelText2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelText2.Location = new Point(18, 110);
            labelText2.Name = "labelText2";
            labelText2.Size = new Size(170, 15);
            labelText2.TabIndex = 1;
            labelText2.Text = "Type new database password.";
            // 
            // labelText3
            // 
            labelText3.AutoSize = true;
            labelText3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelText3.Location = new Point(18, 190);
            labelText3.Name = "labelText3";
            labelText3.Size = new Size(184, 15);
            labelText3.TabIndex = 2;
            labelText3.Text = "Retype new database password.";
            // 
            // buttonSave
            // 
            buttonSave.Enabled = false;
            buttonSave.Location = new Point(83, 300);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 3;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(176, 300);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(75, 23);
            buttonClose.TabIndex = 4;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // textBoxOldPassword
            // 
            textBoxOldPassword.Location = new Point(18, 69);
            textBoxOldPassword.Name = "textBoxOldPassword";
            textBoxOldPassword.PasswordChar = '*';
            textBoxOldPassword.Size = new Size(239, 23);
            textBoxOldPassword.TabIndex = 5;
            textBoxOldPassword.TextChanged += textBoxOldPassword_TextChanged;
            // 
            // textBoxNewPassword
            // 
            textBoxNewPassword.Location = new Point(12, 143);
            textBoxNewPassword.Name = "textBoxNewPassword";
            textBoxNewPassword.PasswordChar = '*';
            textBoxNewPassword.Size = new Size(239, 23);
            textBoxNewPassword.TabIndex = 6;
            textBoxNewPassword.TextChanged += textBoxNewPassword_TextChanged;
            // 
            // textBoxNewPassword2
            // 
            textBoxNewPassword2.Location = new Point(18, 217);
            textBoxNewPassword2.Name = "textBoxNewPassword2";
            textBoxNewPassword2.PasswordChar = '*';
            textBoxNewPassword2.Size = new Size(239, 23);
            textBoxNewPassword2.TabIndex = 7;
            textBoxNewPassword2.TextChanged += textBoxNewPassword2_TextChanged;
            // 
            // checkBoxShow
            // 
            checkBoxShow.AutoSize = true;
            checkBoxShow.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            checkBoxShow.Location = new Point(18, 263);
            checkBoxShow.Name = "checkBoxShow";
            checkBoxShow.Size = new Size(127, 21);
            checkBoxShow.TabIndex = 11;
            checkBoxShow.Text = "Show plain text.";
            checkBoxShow.UseVisualStyleBackColor = true;
            checkBoxShow.CheckedChanged += checkBoxShow_CheckedChanged;
            // 
            // FormChangePassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(276, 335);
            Controls.Add(checkBoxShow);
            Controls.Add(textBoxNewPassword2);
            Controls.Add(textBoxNewPassword);
            Controls.Add(textBoxOldPassword);
            Controls.Add(buttonClose);
            Controls.Add(buttonSave);
            Controls.Add(labelText3);
            Controls.Add(labelText2);
            Controls.Add(labelText1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormChangePassword";
            Text = "Weather Station";
            Load += FormChangePassword_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelText1;
        private Label labelText2;
        private Label labelText3;
        private Button buttonSave;
        private Button buttonClose;
        private TextBox textBoxOldPassword;
        private TextBox textBoxNewPassword;
        private TextBox textBoxNewPassword2;
        private CheckBox checkBoxShow;
    }
}