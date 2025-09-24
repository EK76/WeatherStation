namespace ReadTemp
{
    partial class FormRenameTable
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
            buttonRename = new Button();
            buttonClose = new Button();
            textBoxRename = new TextBox();
            labelText = new Label();
            SuspendLayout();
            // 
            // buttonRename
            // 
            buttonRename.Location = new Point(185, 83);
            buttonRename.Name = "buttonRename";
            buttonRename.Size = new Size(75, 23);
            buttonRename.TabIndex = 0;
            buttonRename.Text = "Rename";
            buttonRename.UseVisualStyleBackColor = true;
            buttonRename.Click += buttonRename_Click;
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(284, 83);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(75, 23);
            buttonClose.TabIndex = 1;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // textBoxRename
            // 
            textBoxRename.Location = new Point(19, 41);
            textBoxRename.Name = "textBoxRename";
            textBoxRename.Size = new Size(340, 23);
            textBoxRename.TabIndex = 2;
            textBoxRename.KeyPress += textBoxRename_KeyPress;
            // 
            // labelText
            // 
            labelText.AutoSize = true;
            labelText.Location = new Point(21, 15);
            labelText.Name = "labelText";
            labelText.Size = new Size(68, 15);
            labelText.TabIndex = 3;
            labelText.Text = "Table name";
            // 
            // FormRenameTable
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 125);
            Controls.Add(labelText);
            Controls.Add(textBoxRename);
            Controls.Add(buttonClose);
            Controls.Add(buttonRename);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "FormRenameTable";
            ShowIcon = false;
            Text = "Weather Station";
            Load += FormRenameTable_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonRename;
        private Button buttonClose;
        private TextBox textBoxRename;
        private Label labelText;
    }
}