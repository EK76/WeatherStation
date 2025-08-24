namespace ReadTemp
{
    partial class FormShowTables
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
            buttonSetText = new Button();
            buttonClose = new Button();
            listViewShowTables = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            SuspendLayout();
            // 
            // buttonSetText
            // 
            buttonSetText.Location = new Point(151, 372);
            buttonSetText.Name = "buttonSetText";
            buttonSetText.Size = new Size(106, 23);
            buttonSetText.TabIndex = 0;
            buttonSetText.Text = "button1";
            buttonSetText.UseVisualStyleBackColor = true;
            buttonSetText.Click += buttonSetText_Click;
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(279, 372);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(100, 23);
            buttonClose.TabIndex = 1;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // listViewShowTables
            // 
            listViewShowTables.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listViewShowTables.LabelEdit = true;
            listViewShowTables.Location = new Point(12, 12);
            listViewShowTables.Name = "listViewShowTables";
            listViewShowTables.Size = new Size(367, 311);
            listViewShowTables.TabIndex = 2;
            listViewShowTables.UseCompatibleStateImageBehavior = false;
            listViewShowTables.View = View.Details;
            listViewShowTables.AfterLabelEdit += listViewShowTables_AfterLabelEdit;
            listViewShowTables.BeforeLabelEdit += listViewShowTables_BeforeLabelEdit;
            listViewShowTables.ItemSelectionChanged += listViewShowTables_ItemSelectionChanged;
            listViewShowTables.SelectedIndexChanged += listViewShowTables_SelectedIndexChanged;
            listViewShowTables.Click += listViewShowTables_Click;
            listViewShowTables.MouseUp += listViewShowTables_MouseUp;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Table";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Date";
            columnHeader2.Width = 140;
            // 
            // FormShowTables
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 407);
            Controls.Add(listViewShowTables);
            Controls.Add(buttonClose);
            Controls.Add(buttonSetText);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormShowTables";
            ShowIcon = false;
            Text = "WeatherStation";
            Load += FormShowTables_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button buttonSetText;
        private Button buttonClose;
        private ListView listViewShowTables;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
    }
}