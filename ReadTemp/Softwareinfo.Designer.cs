namespace ReadTemp
{
    partial class FormSoftwareInfo
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
            components = new System.ComponentModel.Container();
            buttonDesc = new Button();
            richTextBoxCode = new RichTextBox();
            richTextBoxDatabase = new RichTextBox();
            labelText = new Label();
            labelText2 = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            codeSaveToolStripMenuItem = new ToolStripMenuItem();
            databasesSaveToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            downloadToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            toolTip1 = new ToolTip(components);
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            buttonCopy = new Button();
            buttonCopy2 = new Button();
            timerCopy = new System.Windows.Forms.Timer(components);
            timerCopy2 = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonDesc
            // 
            buttonDesc.Location = new Point(1320, 779);
            buttonDesc.Name = "buttonDesc";
            buttonDesc.Size = new Size(144, 23);
            buttonDesc.TabIndex = 0;
            buttonDesc.Text = "Database Description";
            buttonDesc.UseVisualStyleBackColor = true;
            buttonDesc.Click += buttonDesc_Click;
            // 
            // richTextBoxCode
            // 
            richTextBoxCode.Location = new Point(12, 64);
            richTextBoxCode.Name = "richTextBoxCode";
            richTextBoxCode.ReadOnly = true;
            richTextBoxCode.Size = new Size(550, 696);
            richTextBoxCode.TabIndex = 1;
            richTextBoxCode.Text = "";
            // 
            // richTextBoxDatabase
            // 
            richTextBoxDatabase.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBoxDatabase.Location = new Point(582, 77);
            richTextBoxDatabase.Name = "richTextBoxDatabase";
            richTextBoxDatabase.ReadOnly = true;
            richTextBoxDatabase.Size = new Size(882, 696);
            richTextBoxDatabase.TabIndex = 2;
            richTextBoxDatabase.Text = "";
            // 
            // labelText
            // 
            labelText.AutoSize = true;
            labelText.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            labelText.Location = new Point(18, 20);
            labelText.Name = "labelText";
            labelText.Size = new Size(268, 20);
            labelText.TabIndex = 3;
            labelText.Text = "Pyhton code (run by Raspberry PI 5).";
            // 
            // labelText2
            // 
            labelText2.AutoSize = true;
            labelText2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            labelText2.Location = new Point(591, 17);
            labelText2.Name = "labelText2";
            labelText2.Size = new Size(374, 20);
            labelText2.TabIndex = 4;
            labelText2.Text = "Constructions for databases used in this application.";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1476, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveToolStripMenuItem, copyToolStripMenuItem, downloadToolStripMenuItem, toolStripSeparator1, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { codeSaveToolStripMenuItem, databasesSaveToolStripMenuItem });
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(256, 22);
            saveToolStripMenuItem.Text = "Save";
            // 
            // codeSaveToolStripMenuItem
            // 
            codeSaveToolStripMenuItem.Name = "codeSaveToolStripMenuItem";
            codeSaveToolStripMenuItem.Size = new Size(188, 22);
            codeSaveToolStripMenuItem.Text = "Code";
            codeSaveToolStripMenuItem.Click += codeSaveToolStripMenuItem_Click;
            // 
            // databasesSaveToolStripMenuItem
            // 
            databasesSaveToolStripMenuItem.Name = "databasesSaveToolStripMenuItem";
            databasesSaveToolStripMenuItem.Size = new Size(188, 22);
            databasesSaveToolStripMenuItem.Text = " Datebase Description";
            databasesSaveToolStripMenuItem.Click += databasesSaveToolStripMenuItem_Click_1;
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new Size(256, 22);
            copyToolStripMenuItem.Text = "Copy Database Configuration";
            copyToolStripMenuItem.Click += copyToolStripMenuItem_Click;
            // 
            // downloadToolStripMenuItem
            // 
            downloadToolStripMenuItem.Name = "downloadToolStripMenuItem";
            downloadToolStripMenuItem.Size = new Size(256, 22);
            downloadToolStripMenuItem.Text = "Download Database Configuration";
            downloadToolStripMenuItem.Click += downloadToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(253, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(256, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // printDocument1
            // 
            printDocument1.BeginPrint += printDocument1_BeginPrint;
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // buttonCopy
            // 
            buttonCopy.Location = new Point(1431, 38);
            buttonCopy.Name = "buttonCopy";
            buttonCopy.Size = new Size(33, 33);
            buttonCopy.TabIndex = 8;
            buttonCopy.UseVisualStyleBackColor = true;
            buttonCopy.Click += buttonCopy_Click;
            // 
            // buttonCopy2
            // 
            buttonCopy2.Location = new Point(529, 37);
            buttonCopy2.Name = "buttonCopy2";
            buttonCopy2.Size = new Size(33, 33);
            buttonCopy2.TabIndex = 9;
            buttonCopy2.UseVisualStyleBackColor = true;
            buttonCopy2.Click += buttonCopy2_Click;
            // 
            // timerCopy
            // 
            timerCopy.Interval = 1000;
            timerCopy.Tick += timerCopy_Tick;
            // 
            // timerCopy2
            // 
            timerCopy2.Interval = 1000;
            timerCopy2.Tick += timerCopy2_Tick;
            // 
            // FormSoftwareInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1476, 812);
            Controls.Add(buttonCopy2);
            Controls.Add(buttonCopy);
            Controls.Add(labelText2);
            Controls.Add(labelText);
            Controls.Add(richTextBoxDatabase);
            Controls.Add(richTextBoxCode);
            Controls.Add(buttonDesc);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormSoftwareInfo";
            ShowIcon = false;
            Text = "Weather Station";
            Load += FormSoftwareInfo_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button buttonDesc;
        private System.Windows.Forms.RichTextBox richTextBoxCode;
        private System.Windows.Forms.RichTextBox richTextBoxDatabase;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Label labelText2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem codeSaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databasesSaveToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Button buttonCopy2;
        private System.Windows.Forms.Timer timerCopy;
        private System.Windows.Forms.Timer timerCopy2;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem downloadToolStripMenuItem;
    }
}