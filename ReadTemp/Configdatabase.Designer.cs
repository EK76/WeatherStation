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
            labelText = new System.Windows.Forms.Label();
            labelText2 = new System.Windows.Forms.Label();
            labelText3 = new System.Windows.Forms.Label();
            labelText4 = new System.Windows.Forms.Label();
            textBoxUsername = new System.Windows.Forms.TextBox();
            textBoxPassword = new System.Windows.Forms.TextBox();
            textBoxDatabase = new System.Windows.Forms.TextBox();
            textBoxServer = new System.Windows.Forms.TextBox();
            buttonClose = new System.Windows.Forms.Button();
            buttonSave = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // labelText
            // 
            labelText.AutoSize = true;
            labelText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            labelText.Location = new System.Drawing.Point(34, 37);
            labelText.Name = "labelText";
            labelText.Size = new System.Drawing.Size(84, 20);
            labelText.TabIndex = 2;
            labelText.Text = "User name";
            // 
            // labelText2
            // 
            labelText2.AutoSize = true;
            labelText2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            labelText2.Location = new System.Drawing.Point(34, 102);
            labelText2.Name = "labelText2";
            labelText2.Size = new System.Drawing.Size(76, 20);
            labelText2.TabIndex = 3;
            labelText2.Text = "Password";
            // 
            // labelText3
            // 
            labelText3.AutoSize = true;
            labelText3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            labelText3.Location = new System.Drawing.Point(34, 168);
            labelText3.Name = "labelText3";
            labelText3.Size = new System.Drawing.Size(74, 20);
            labelText3.TabIndex = 4;
            labelText3.Text = "Database";
            // 
            // labelText4
            // 
            labelText4.AutoSize = true;
            labelText4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            labelText4.Location = new System.Drawing.Point(34, 224);
            labelText4.Name = "labelText4";
            labelText4.Size = new System.Drawing.Size(54, 20);
            labelText4.TabIndex = 5;
            labelText4.Text = "Server";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new System.Drawing.Point(34, 60);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new System.Drawing.Size(214, 23);
            textBoxUsername.TabIndex = 6;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new System.Drawing.Point(34, 125);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new System.Drawing.Size(214, 23);
            textBoxPassword.TabIndex = 7;
            // 
            // textBoxDatabase
            // 
            textBoxDatabase.Location = new System.Drawing.Point(35, 193);
            textBoxDatabase.Name = "textBoxDatabase";
            textBoxDatabase.Size = new System.Drawing.Size(213, 23);
            textBoxDatabase.TabIndex = 8;
            // 
            // textBoxServer
            // 
            textBoxServer.Location = new System.Drawing.Point(34, 247);
            textBoxServer.Name = "textBoxServer";
            textBoxServer.Size = new System.Drawing.Size(214, 23);
            textBoxServer.TabIndex = 9;
            // 
            // buttonClose
            // 
            buttonClose.Location = new System.Drawing.Point(240, 295);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new System.Drawing.Size(75, 23);
            buttonClose.TabIndex = 0;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new System.Drawing.Point(146, 295);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new System.Drawing.Size(75, 23);
            buttonSave.TabIndex = 1;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // FormConfigDatabase
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(321, 326);
            Controls.Add(textBoxServer);
            Controls.Add(textBoxDatabase);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(labelText4);
            Controls.Add(labelText3);
            Controls.Add(labelText2);
            Controls.Add(labelText);
            Controls.Add(buttonSave);
            Controls.Add(buttonClose);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormConfigDatabase";
            ShowIcon = false;
            Text = "Weather Station";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Label labelText2;
        private System.Windows.Forms.Label labelText3;
        private System.Windows.Forms.Label labelText4;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxDatabase;
        private System.Windows.Forms.TextBox textBoxServer;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonSave;
    }
}