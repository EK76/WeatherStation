namespace ReadTemp
{
    partial class FormInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInfo));
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            changeBackgroundPictureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            changeTextColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            fullViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            labelTemp = new System.Windows.Forms.Label();
            labelHum = new System.Windows.Forms.Label();
            contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(components);
            standardViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            screenShotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            exit2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            labelDateTime = new System.Windows.Forms.Label();
            labelDateTime2 = new System.Windows.Forms.Label();
            labelDate = new System.Windows.Forms.Label();
            labelStartDate = new System.Windows.Forms.Label();
            labelLowTemp = new System.Windows.Forms.Label();
            labelHighTemp = new System.Windows.Forms.Label();
            labelLowHum = new System.Windows.Forms.Label();
            labelHighHum = new System.Windows.Forms.Label();
            labelLowPressure = new System.Windows.Forms.Label();
            labelHighPressure = new System.Windows.Forms.Label();
            labelInfo = new System.Windows.Forms.Label();
            labelPressure = new System.Windows.Forms.Label();
            colorDialog1 = new System.Windows.Forms.ColorDialog();
            panelPicture = new System.Windows.Forms.Panel();
            menuStrip1.SuspendLayout();
            contextMenuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, viewToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            menuStrip1.Size = new System.Drawing.Size(1858, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            exitToolStripMenuItem.Text = "Close";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { copyToolStripMenuItem, changeBackgroundPictureToolStripMenuItem, changeTextColorToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            copyToolStripMenuItem.Text = "Copy weather data";
            copyToolStripMenuItem.Click += copyToolStripMenuItem_Click;
            // 
            // changeBackgroundPictureToolStripMenuItem
            // 
            changeBackgroundPictureToolStripMenuItem.Name = "changeBackgroundPictureToolStripMenuItem";
            changeBackgroundPictureToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            changeBackgroundPictureToolStripMenuItem.Text = "Change Background Picture";
            changeBackgroundPictureToolStripMenuItem.Click += changeBackgroundPictureToolStripMenuItem_Click;
            // 
            // changeTextColorToolStripMenuItem
            // 
            changeTextColorToolStripMenuItem.Name = "changeTextColorToolStripMenuItem";
            changeTextColorToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            changeTextColorToolStripMenuItem.Text = "Change Text Color";
            changeTextColorToolStripMenuItem.Click += changeTextColorToolStripMenuItem_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { refreshToolStripMenuItem, fullViewToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            viewToolStripMenuItem.Text = "View";
            // 
            // refreshToolStripMenuItem
            // 
            refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            refreshToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            refreshToolStripMenuItem.Text = "Refresh";
            refreshToolStripMenuItem.Click += refreshToolStripMenuItem_Click;
            // 
            // fullViewToolStripMenuItem
            // 
            fullViewToolStripMenuItem.Name = "fullViewToolStripMenuItem";
            fullViewToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            fullViewToolStripMenuItem.Text = "Full View";
            fullViewToolStripMenuItem.Click += fullViewToolStripMenuItem_Click;
            // 
            // labelTemp
            // 
            labelTemp.AutoSize = true;
            labelTemp.BackColor = System.Drawing.Color.Transparent;
            labelTemp.Font = new System.Drawing.Font("Calibri", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelTemp.ForeColor = System.Drawing.Color.DarkCyan;
            labelTemp.Location = new System.Drawing.Point(42, 228);
            labelTemp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelTemp.Name = "labelTemp";
            labelTemp.Size = new System.Drawing.Size(526, 66);
            labelTemp.TabIndex = 2;
            labelTemp.Text = "Outdoor temperature: ";
            // 
            // labelHum
            // 
            labelHum.AutoSize = true;
            labelHum.BackColor = System.Drawing.Color.Transparent;
            labelHum.Font = new System.Drawing.Font("Calibri", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelHum.ForeColor = System.Drawing.Color.DarkCyan;
            labelHum.Location = new System.Drawing.Point(42, 383);
            labelHum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelHum.Name = "labelHum";
            labelHum.Size = new System.Drawing.Size(431, 66);
            labelHum.TabIndex = 3;
            labelHum.Text = "Outdoor humidity:";
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { standardViewToolStripMenuItem, screenShotToolStripMenuItem, exit2ToolStripMenuItem });
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new System.Drawing.Size(159, 70);
            // 
            // standardViewToolStripMenuItem
            // 
            standardViewToolStripMenuItem.Name = "standardViewToolStripMenuItem";
            standardViewToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            standardViewToolStripMenuItem.Text = "FullView";
            standardViewToolStripMenuItem.Click += standardViewToolStripMenuItem_Click;
            // 
            // screenShotToolStripMenuItem
            // 
            screenShotToolStripMenuItem.Enabled = false;
            screenShotToolStripMenuItem.Name = "screenShotToolStripMenuItem";
            screenShotToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            screenShotToolStripMenuItem.Text = "Take Screenshot";
            screenShotToolStripMenuItem.Click += screenShotToolStripMenuItem_Click;
            // 
            // exit2ToolStripMenuItem
            // 
            exit2ToolStripMenuItem.Name = "exit2ToolStripMenuItem";
            exit2ToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            exit2ToolStripMenuItem.Text = "Exit";
            exit2ToolStripMenuItem.Click += exit2ToolStripMenuItem_Click;
            // 
            // labelDateTime
            // 
            labelDateTime.AutoSize = true;
            labelDateTime.BackColor = System.Drawing.Color.Transparent;
            labelDateTime.Font = new System.Drawing.Font("Calibri", 30F);
            labelDateTime.ForeColor = System.Drawing.Color.DarkCyan;
            labelDateTime.Location = new System.Drawing.Point(649, 28);
            labelDateTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelDateTime.Name = "labelDateTime";
            labelDateTime.Size = new System.Drawing.Size(0, 49);
            labelDateTime.TabIndex = 9;
            // 
            // labelDateTime2
            // 
            labelDateTime2.AutoSize = true;
            labelDateTime2.BackColor = System.Drawing.Color.Transparent;
            labelDateTime2.Font = new System.Drawing.Font("Calibri", 30F);
            labelDateTime2.ForeColor = System.Drawing.Color.DarkCyan;
            labelDateTime2.Location = new System.Drawing.Point(349, 74);
            labelDateTime2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelDateTime2.Name = "labelDateTime2";
            labelDateTime2.Size = new System.Drawing.Size(0, 49);
            labelDateTime2.TabIndex = 10;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.BackColor = System.Drawing.Color.Transparent;
            labelDate.Font = new System.Drawing.Font("Calibri", 40F);
            labelDate.Location = new System.Drawing.Point(254, 28);
            labelDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelDate.Name = "labelDate";
            labelDate.Size = new System.Drawing.Size(160, 66);
            labelDate.TabIndex = 11;
            labelDate.Text = "label1";
            // 
            // labelStartDate
            // 
            labelStartDate.AutoSize = true;
            labelStartDate.BackColor = System.Drawing.Color.Transparent;
            labelStartDate.Font = new System.Drawing.Font("Calibri", 22F);
            labelStartDate.ForeColor = System.Drawing.Color.DarkCyan;
            labelStartDate.Location = new System.Drawing.Point(295, 635);
            labelStartDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelStartDate.Name = "labelStartDate";
            labelStartDate.Size = new System.Drawing.Size(91, 37);
            labelStartDate.TabIndex = 12;
            labelStartDate.Text = "label1";
            // 
            // labelLowTemp
            // 
            labelLowTemp.AutoSize = true;
            labelLowTemp.BackColor = System.Drawing.Color.Transparent;
            labelLowTemp.Font = new System.Drawing.Font("Calibri", 22F);
            labelLowTemp.ForeColor = System.Drawing.Color.DarkCyan;
            labelLowTemp.Location = new System.Drawing.Point(259, 721);
            labelLowTemp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelLowTemp.Name = "labelLowTemp";
            labelLowTemp.Size = new System.Drawing.Size(91, 37);
            labelLowTemp.TabIndex = 13;
            labelLowTemp.Text = "label2";
            // 
            // labelHighTemp
            // 
            labelHighTemp.AutoSize = true;
            labelHighTemp.BackColor = System.Drawing.Color.Transparent;
            labelHighTemp.Font = new System.Drawing.Font("Calibri", 22F);
            labelHighTemp.ForeColor = System.Drawing.Color.DarkCyan;
            labelHighTemp.Location = new System.Drawing.Point(852, 720);
            labelHighTemp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelHighTemp.Name = "labelHighTemp";
            labelHighTemp.Size = new System.Drawing.Size(91, 37);
            labelHighTemp.TabIndex = 14;
            labelHighTemp.Text = "label3";
            // 
            // labelLowHum
            // 
            labelLowHum.AutoSize = true;
            labelLowHum.BackColor = System.Drawing.Color.Transparent;
            labelLowHum.Font = new System.Drawing.Font("Calibri", 22F);
            labelLowHum.ForeColor = System.Drawing.Color.DarkCyan;
            labelLowHum.Location = new System.Drawing.Point(259, 804);
            labelLowHum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelLowHum.Name = "labelLowHum";
            labelLowHum.Size = new System.Drawing.Size(91, 37);
            labelLowHum.TabIndex = 15;
            labelLowHum.Text = "label4";
            // 
            // labelHighHum
            // 
            labelHighHum.AutoSize = true;
            labelHighHum.BackColor = System.Drawing.Color.Transparent;
            labelHighHum.Font = new System.Drawing.Font("Calibri", 22F);
            labelHighHum.ForeColor = System.Drawing.Color.DarkCyan;
            labelHighHum.Location = new System.Drawing.Point(852, 803);
            labelHighHum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelHighHum.Name = "labelHighHum";
            labelHighHum.Size = new System.Drawing.Size(91, 37);
            labelHighHum.TabIndex = 17;
            labelHighHum.Text = "label1";
            // 
            // labelLowPressure
            // 
            labelLowPressure.AutoSize = true;
            labelLowPressure.BackColor = System.Drawing.Color.Transparent;
            labelLowPressure.Font = new System.Drawing.Font("Calibri", 22F);
            labelLowPressure.ForeColor = System.Drawing.Color.DarkCyan;
            labelLowPressure.Location = new System.Drawing.Point(259, 890);
            labelLowPressure.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelLowPressure.Name = "labelLowPressure";
            labelLowPressure.Size = new System.Drawing.Size(91, 37);
            labelLowPressure.TabIndex = 18;
            labelLowPressure.Text = "label2";
            // 
            // labelHighPressure
            // 
            labelHighPressure.AutoSize = true;
            labelHighPressure.BackColor = System.Drawing.Color.Transparent;
            labelHighPressure.Font = new System.Drawing.Font("Calibri", 22F);
            labelHighPressure.ForeColor = System.Drawing.Color.DarkCyan;
            labelHighPressure.Location = new System.Drawing.Point(852, 888);
            labelHighPressure.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelHighPressure.Name = "labelHighPressure";
            labelHighPressure.Size = new System.Drawing.Size(91, 37);
            labelHighPressure.TabIndex = 19;
            labelHighPressure.Text = "label3";
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.BackColor = System.Drawing.Color.Transparent;
            labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelInfo.ForeColor = System.Drawing.Color.DarkCyan;
            labelInfo.Location = new System.Drawing.Point(43, 520);
            labelInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new System.Drawing.Size(0, 37);
            labelInfo.TabIndex = 6;
            // 
            // labelPressure
            // 
            labelPressure.AutoSize = true;
            labelPressure.BackColor = System.Drawing.Color.Transparent;
            labelPressure.Font = new System.Drawing.Font("Calibri", 40F);
            labelPressure.Location = new System.Drawing.Point(1104, 308);
            labelPressure.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelPressure.Name = "labelPressure";
            labelPressure.Size = new System.Drawing.Size(426, 66);
            labelPressure.TabIndex = 21;
            labelPressure.Text = "Outdoor pressure:";
            // 
            // panelPicture
            // 
            panelPicture.BackColor = System.Drawing.SystemColors.ActiveCaption;
            panelPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            panelPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            panelPicture.Location = new System.Drawing.Point(0, 24);
            panelPicture.Name = "panelPicture";
            panelPicture.Size = new System.Drawing.Size(1858, 969);
            panelPicture.TabIndex = 22;
            // 
            // FormInfo
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ActiveCaption;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(1858, 993);
            ContextMenuStrip = contextMenuStrip2;
            Controls.Add(labelHighHum);
            Controls.Add(labelLowHum);
            Controls.Add(labelHighTemp);
            Controls.Add(labelLowTemp);
            Controls.Add(labelStartDate);
            Controls.Add(labelDate);
            Controls.Add(labelDateTime2);
            Controls.Add(labelDateTime);
            Controls.Add(labelHum);
            Controls.Add(labelTemp);
            Controls.Add(labelPressure);
            Controls.Add(panelPicture);
            Controls.Add(labelHighPressure);
            Controls.Add(labelLowPressure);
            Controls.Add(labelInfo);
            Controls.Add(menuStrip1);
            ForeColor = System.Drawing.Color.DarkSlateBlue;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "FormInfo";
            ShowInTaskbar = false;
            Text = "Weather Info";
            Load += FormInfo_Load;
            DoubleClick += FormInfo_DoubleClick;
            MouseDown += FormInfo_MouseDown;
            MouseMove += FormInfo_MouseMove;
            MouseUp += FormInfo_MouseUp;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            contextMenuStrip2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.Label labelTemp;
        private System.Windows.Forms.Label labelHum;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullViewToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem standardViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exit2ToolStripMenuItem;
        private System.Windows.Forms.Label labelDateTime;
        private System.Windows.Forms.Label labelDateTime2;
        private System.Windows.Forms.ToolStripMenuItem screenShotToolStripMenuItem;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.Label labelLowTemp;
        private System.Windows.Forms.Label labelHighTemp;
        private System.Windows.Forms.Label labelLowHum;
        private System.Windows.Forms.Label labelHighHum;
        private System.Windows.Forms.Label labelLowPressure;
        private System.Windows.Forms.Label labelHighPressure;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label labelPressure;
        private System.Windows.Forms.ToolStripMenuItem changeBackgroundPictureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeTextColorToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel panelPicture;
    }
}

