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
            buttonClose = new System.Windows.Forms.Button();
            buttonSave = new System.Windows.Forms.Button();
            labelText = new System.Windows.Forms.Label();
            textBoxServer = new System.Windows.Forms.TextBox();
            textBoxUser = new System.Windows.Forms.TextBox();
            textBoxPassword = new System.Windows.Forms.TextBox();
            labelServer = new System.Windows.Forms.Label();
            labelUser = new System.Windows.Forms.Label();
            labelPassword = new System.Windows.Forms.Label();
            checkBoxShow = new System.Windows.Forms.CheckBox();
            SuspendLayout();
            // 
            // buttonClose
            // 
            buttonClose.Location = new System.Drawing.Point(166, 269);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new System.Drawing.Size(75, 23);
            buttonClose.TabIndex = 0;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // buttonSave
            // 
            buttonSave.Enabled = false;
            buttonSave.Location = new System.Drawing.Point(72, 269);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new System.Drawing.Size(75, 23);
            buttonSave.TabIndex = 1;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // labelText
            // 
            labelText.AutoSize = true;
            labelText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelText.Location = new System.Drawing.Point(60, 9);
            labelText.Name = "labelText";
            labelText.Size = new System.Drawing.Size(136, 21);
            labelText.TabIndex = 3;
            labelText.Text = "Database Config";
            // 
            // textBoxServer
            // 
            textBoxServer.Location = new System.Drawing.Point(9, 72);
            textBoxServer.Name = "textBoxServer";
            textBoxServer.Size = new System.Drawing.Size(234, 23);
            textBoxServer.TabIndex = 4;
            textBoxServer.TextChanged += textBoxServer_TextChanged;
            // 
            // textBoxUser
            // 
            textBoxUser.Location = new System.Drawing.Point(7, 131);
            textBoxUser.Name = "textBoxUser";
            textBoxUser.Size = new System.Drawing.Size(234, 23);
            textBoxUser.TabIndex = 5;
            textBoxUser.TextChanged += textBoxUser_TextChanged;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new System.Drawing.Point(8, 194);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new System.Drawing.Size(233, 23);
            textBoxPassword.TabIndex = 6;
            textBoxPassword.TextChanged += textBoxPassword_TextChanged;
            // 
            // labelServer
            // 
            labelServer.AutoSize = true;
            labelServer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelServer.Location = new System.Drawing.Point(12, 45);
            labelServer.Name = "labelServer";
            labelServer.Size = new System.Drawing.Size(47, 17);
            labelServer.TabIndex = 7;
            labelServer.Text = "Server";
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelUser.Location = new System.Drawing.Point(12, 107);
            labelUser.Name = "labelUser";
            labelUser.Size = new System.Drawing.Size(35, 17);
            labelUser.TabIndex = 8;
            labelUser.Text = "User";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelPassword.Location = new System.Drawing.Point(11, 170);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new System.Drawing.Size(66, 17);
            labelPassword.TabIndex = 9;
            labelPassword.Text = "Password";
            // 
            // checkBoxShow
            // 
            checkBoxShow.AutoSize = true;
            checkBoxShow.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            checkBoxShow.Location = new System.Drawing.Point(11, 236);
            checkBoxShow.Name = "checkBoxShow";
            checkBoxShow.Size = new System.Drawing.Size(127, 21);
            checkBoxShow.TabIndex = 10;
            checkBoxShow.Text = "Show plain text.";
            checkBoxShow.UseVisualStyleBackColor = true;
            checkBoxShow.CheckedChanged += checkBoxShow_CheckedChanged;
            // 
            // FormConfigDatabase
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(259, 313);
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
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormConfigDatabase";
            ShowIcon = false;
            Text = "Weather Station";
            Load += FormConfigDatabase_Load;
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
    }
}