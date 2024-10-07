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
            buttonDesc = new System.Windows.Forms.Button();
            richTextBoxCode = new System.Windows.Forms.RichTextBox();
            richTextBoxDatabase = new System.Windows.Forms.RichTextBox();
            labelText = new System.Windows.Forms.Label();
            labelText2 = new System.Windows.Forms.Label();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            codeSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            databasesSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            codePrintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            databasePrintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            buttonCopy = new System.Windows.Forms.Button();
            buttonCopy2 = new System.Windows.Forms.Button();
            timerCopy = new System.Windows.Forms.Timer(components);
            timerCopy2 = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonDesc
            // 
            buttonDesc.Location = new System.Drawing.Point(1320, 779);
            buttonDesc.Name = "buttonDesc";
            buttonDesc.Size = new System.Drawing.Size(144, 23);
            buttonDesc.TabIndex = 0;
            buttonDesc.Text = "Database Description";
            buttonDesc.UseVisualStyleBackColor = true;
            buttonDesc.Click += buttonDesc_Click;
            // 
            // richTextBoxCode
            // 
            richTextBoxCode.Location = new System.Drawing.Point(12, 76);
            richTextBoxCode.Name = "richTextBoxCode";
            richTextBoxCode.ReadOnly = true;
            richTextBoxCode.Size = new System.Drawing.Size(550, 696);
            richTextBoxCode.TabIndex = 1;
            richTextBoxCode.Text = "";
            // 
            // richTextBoxDatabase
            // 
            richTextBoxDatabase.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            richTextBoxDatabase.Location = new System.Drawing.Point(582, 77);
            richTextBoxDatabase.Name = "richTextBoxDatabase";
            richTextBoxDatabase.ReadOnly = true;
            richTextBoxDatabase.Size = new System.Drawing.Size(882, 696);
            richTextBoxDatabase.TabIndex = 2;
            richTextBoxDatabase.Text = "";
            // 
            // labelText
            // 
            labelText.AutoSize = true;
            labelText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            labelText.Location = new System.Drawing.Point(18, 20);
            labelText.Name = "labelText";
            labelText.Size = new System.Drawing.Size(268, 20);
            labelText.TabIndex = 3;
            labelText.Text = "Pyhton code (run by Raspberry PI 5).";
            // 
            // labelText2
            // 
            labelText2.AutoSize = true;
            labelText2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            labelText2.Location = new System.Drawing.Point(591, 17);
            labelText2.Name = "labelText2";
            labelText2.Size = new System.Drawing.Size(374, 20);
            labelText2.TabIndex = 4;
            labelText2.Text = "Constructions for databases used in this application.";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(1476, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { saveToolStripMenuItem, printToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { codeSaveToolStripMenuItem, databasesSaveToolStripMenuItem });
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            saveToolStripMenuItem.Text = "Save";
            // 
            // codeSaveToolStripMenuItem
            // 
            codeSaveToolStripMenuItem.Name = "codeSaveToolStripMenuItem";
            codeSaveToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            codeSaveToolStripMenuItem.Text = "Code";
            codeSaveToolStripMenuItem.Click += codeSaveToolStripMenuItem_Click;
            // 
            // databasesSaveToolStripMenuItem
            // 
            databasesSaveToolStripMenuItem.Name = "databasesSaveToolStripMenuItem";
            databasesSaveToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            databasesSaveToolStripMenuItem.Text = "Databases";
            databasesSaveToolStripMenuItem.Click += databasesSaveToolStripMenuItem_Click_1;
            // 
            // printToolStripMenuItem
            // 
            printToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { codePrintToolStripMenuItem, databasePrintToolStripMenuItem });
            printToolStripMenuItem.Name = "printToolStripMenuItem";
            printToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            printToolStripMenuItem.Text = "Print";
            // 
            // codePrintToolStripMenuItem
            // 
            codePrintToolStripMenuItem.Name = "codePrintToolStripMenuItem";
            codePrintToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            codePrintToolStripMenuItem.Text = "Code";
            codePrintToolStripMenuItem.Click += codePrintToolStripMenuItem_Click;
            // 
            // databasePrintToolStripMenuItem
            // 
            databasePrintToolStripMenuItem.Name = "databasePrintToolStripMenuItem";
            databasePrintToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            databasePrintToolStripMenuItem.Text = "Database";
            databasePrintToolStripMenuItem.Click += databasePrintToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
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
            buttonCopy.Location = new System.Drawing.Point(1431, 38);
            buttonCopy.Name = "buttonCopy";
            buttonCopy.Size = new System.Drawing.Size(33, 33);
            buttonCopy.TabIndex = 8;
            buttonCopy.UseVisualStyleBackColor = true;
            buttonCopy.Click += buttonCopy_Click;
            // 
            // buttonCopy2
            // 
            buttonCopy2.Location = new System.Drawing.Point(529, 37);
            buttonCopy2.Name = "buttonCopy2";
            buttonCopy2.Size = new System.Drawing.Size(33, 33);
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
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1476, 812);
            Controls.Add(buttonCopy2);
            Controls.Add(buttonCopy);
            Controls.Add(labelText2);
            Controls.Add(labelText);
            Controls.Add(richTextBoxDatabase);
            Controls.Add(richTextBoxCode);
            Controls.Add(buttonDesc);
            Controls.Add(menuStrip1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem codeSaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databasesSaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem codePrintToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databasePrintToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Button buttonCopy2;
        private System.Windows.Forms.Timer timerCopy;
        private System.Windows.Forms.Timer timerCopy2;
    }
}