namespace ReadTemp
{
    partial class FormConfigDatabase
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
            buttonClose = new Button();
            buttonSave = new Button();
            labelText = new Label();
            textBoxServer = new TextBox();
            textBoxUser = new TextBox();
            textBoxPassword = new TextBox();
            labelServer = new Label();
            labelUser = new Label();
            labelPassword = new Label();
            checkBoxShow = new CheckBox();
            labelDatabase = new Label();
            SuspendLayout();
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(168, 311);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(75, 23);
            buttonClose.TabIndex = 0;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // buttonSave
            // 
            buttonSave.Enabled = false;
            buttonSave.Location = new Point(74, 311);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 1;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // labelText
            // 
            labelText.AutoSize = true;
            labelText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelText.Location = new Point(60, 9);
            labelText.Name = "labelText";
            labelText.Size = new Size(136, 21);
            labelText.TabIndex = 3;
            labelText.Text = "Database Config";
            // 
            // textBoxServer
            // 
            textBoxServer.Location = new Point(9, 72);
            textBoxServer.Name = "textBoxServer";
            textBoxServer.Size = new Size(234, 23);
            textBoxServer.TabIndex = 4;
            textBoxServer.TextChanged += textBoxServer_TextChanged;
            // 
            // textBoxUser
            // 
            textBoxUser.Location = new Point(7, 131);
            textBoxUser.Name = "textBoxUser";
            textBoxUser.Size = new Size(236, 23);
            textBoxUser.TabIndex = 5;
            textBoxUser.TextChanged += textBoxUser_TextChanged;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(4, 197);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(239, 23);
            textBoxPassword.TabIndex = 6;
            textBoxPassword.TextChanged += textBoxPassword_TextChanged;
            // 
            // labelServer
            // 
            labelServer.AutoSize = true;
            labelServer.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelServer.Location = new Point(12, 45);
            labelServer.Name = "labelServer";
            labelServer.Size = new Size(47, 17);
            labelServer.TabIndex = 7;
            labelServer.Text = "Server";
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUser.Location = new Point(12, 107);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(35, 17);
            labelUser.TabIndex = 8;
            labelUser.Text = "User";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPassword.Location = new Point(7, 173);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(66, 17);
            labelPassword.TabIndex = 9;
            labelPassword.Text = "Password";
            // 
            // checkBoxShow
            // 
            checkBoxShow.AutoSize = true;
            checkBoxShow.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            checkBoxShow.Location = new Point(7, 239);
            checkBoxShow.Name = "checkBoxShow";
            checkBoxShow.Size = new Size(127, 21);
            checkBoxShow.TabIndex = 10;
            checkBoxShow.Text = "Show plain text.";
            checkBoxShow.UseVisualStyleBackColor = true;
            checkBoxShow.CheckedChanged += checkBoxShow_CheckedChanged;
            // 
            // labelDatabase
            // 
            labelDatabase.AutoSize = true;
            labelDatabase.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            labelDatabase.Location = new Point(4, 279);
            labelDatabase.Name = "labelDatabase";
            labelDatabase.Size = new Size(0, 17);
            labelDatabase.TabIndex = 11;
            // 
            // FormConfigDatabase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(259, 346);
            Controls.Add(labelDatabase);
            Controls.Add(checkBoxShow);
            Controls.Add(labelPassword);
            Controls.Add(labelUser);
            Controls.Add(labelServer);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUser);
            Controls.Add(textBoxServer);
            Controls.Add(labelText);
            Controls.Add(buttonSave);
            Controls.Add(buttonClose);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormConfigDatabase";
            ShowIcon = false;
            Text = "Weather Station";
            Load += FormConfigDatabase_Load;
            Layout += FormConfigDatabase_Layout;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.TextBox textBoxServer;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelServer;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.CheckBox checkBoxShow;
        private Label labelDatabase;
    }
}