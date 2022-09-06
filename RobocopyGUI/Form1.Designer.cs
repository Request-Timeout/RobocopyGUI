namespace RobocopyGUI
{
    partial class Form1
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
            this.sourceLabel = new System.Windows.Forms.Label();
            this.sourceText = new System.Windows.Forms.TextBox();
            this.destinationLabel = new System.Windows.Forms.Label();
            this.destinationText = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.subDirOptionsLabel = new System.Windows.Forms.Label();
            this.optionsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.subDirComboBox = new System.Windows.Forms.ComboBox();
            this.backupModeComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.backupModeLabel = new System.Windows.Forms.Label();
            this.browseSourceButton = new System.Windows.Forms.Button();
            this.browseDestButton = new System.Windows.Forms.Button();
            this.miscOptionsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sourceLabel
            // 
            this.sourceLabel.AutoSize = true;
            this.sourceLabel.Location = new System.Drawing.Point(13, 16);
            this.sourceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sourceLabel.Name = "sourceLabel";
            this.sourceLabel.Size = new System.Drawing.Size(53, 16);
            this.sourceLabel.TabIndex = 0;
            this.sourceLabel.Text = "Source:";
            // 
            // sourceText
            // 
            this.sourceText.Location = new System.Drawing.Point(13, 36);
            this.sourceText.Margin = new System.Windows.Forms.Padding(4);
            this.sourceText.Name = "sourceText";
            this.sourceText.Size = new System.Drawing.Size(960, 22);
            this.sourceText.TabIndex = 1;
            this.sourceText.TextChanged += new System.EventHandler(this.sourceText_TextChanged);
            // 
            // destinationLabel
            // 
            this.destinationLabel.AutoSize = true;
            this.destinationLabel.Location = new System.Drawing.Point(13, 62);
            this.destinationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.destinationLabel.Name = "destinationLabel";
            this.destinationLabel.Size = new System.Drawing.Size(77, 16);
            this.destinationLabel.TabIndex = 2;
            this.destinationLabel.Text = "Destination:";
            // 
            // destinationText
            // 
            this.destinationText.Location = new System.Drawing.Point(13, 82);
            this.destinationText.Margin = new System.Windows.Forms.Padding(4);
            this.destinationText.Name = "destinationText";
            this.destinationText.Size = new System.Drawing.Size(960, 22);
            this.destinationText.TabIndex = 3;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(954, 572);
            this.startButton.Margin = new System.Windows.Forms.Padding(4);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(100, 28);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // subDirOptionsLabel
            // 
            this.subDirOptionsLabel.AutoSize = true;
            this.subDirOptionsLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.subDirOptionsLabel.Location = new System.Drawing.Point(12, 108);
            this.subDirOptionsLabel.Name = "subDirOptionsLabel";
            this.subDirOptionsLabel.Size = new System.Drawing.Size(140, 16);
            this.subDirOptionsLabel.TabIndex = 7;
            this.subDirOptionsLabel.Text = "Sub Directory Options:";
            // 
            // optionsCheckedListBox
            // 
            this.optionsCheckedListBox.CheckOnClick = true;
            this.optionsCheckedListBox.FormattingEnabled = true;
            this.optionsCheckedListBox.IntegralHeight = false;
            this.optionsCheckedListBox.Items.AddRange(new object[] {
            "/J :: copy using unbuffered I/O (recommended for large files).",
            "/EFSRAW :: copy all encrypted files in EFS RAW mode.",
            "/COMPRESS :: Request network compression during file transfer, if applicable.",
            "/NOOFFLOAD :: copy files without using the Windows Copy Offload mechanism."});
            this.optionsCheckedListBox.Location = new System.Drawing.Point(520, 128);
            this.optionsCheckedListBox.Margin = new System.Windows.Forms.Padding(4);
            this.optionsCheckedListBox.Name = "optionsCheckedListBox";
            this.optionsCheckedListBox.Size = new System.Drawing.Size(500, 96);
            this.optionsCheckedListBox.TabIndex = 11;
            // 
            // subDirComboBox
            // 
            this.subDirComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subDirComboBox.FormattingEnabled = true;
            this.subDirComboBox.Items.AddRange(new object[] {
            "/S :: copy Subdirectories, but not empty ones.",
            "/E :: copy subdirectories, including Empty ones.",
            "/LEV:n :: only copy the top n LEVels of the source directory tree."});
            this.subDirComboBox.Location = new System.Drawing.Point(12, 127);
            this.subDirComboBox.Name = "subDirComboBox";
            this.subDirComboBox.Size = new System.Drawing.Size(501, 24);
            this.subDirComboBox.TabIndex = 13;
            // 
            // backupModeComboBox
            // 
            this.backupModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.backupModeComboBox.FormattingEnabled = true;
            this.backupModeComboBox.Items.AddRange(new object[] {
            "/Z :: copy files in restartable mode.",
            "/B :: copy files in Backup mode.",
            "/ZB :: use restartable mode; if access denied use Backup mode."});
            this.backupModeComboBox.Location = new System.Drawing.Point(12, 173);
            this.backupModeComboBox.Name = "backupModeComboBox";
            this.backupModeComboBox.Size = new System.Drawing.Size(501, 24);
            this.backupModeComboBox.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(942, 504);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 61);
            this.button1.TabIndex = 15;
            this.button1.Text = "BREAKPOINT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // backupModeLabel
            // 
            this.backupModeLabel.AutoSize = true;
            this.backupModeLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.backupModeLabel.Location = new System.Drawing.Point(12, 154);
            this.backupModeLabel.Name = "backupModeLabel";
            this.backupModeLabel.Size = new System.Drawing.Size(143, 16);
            this.backupModeLabel.TabIndex = 16;
            this.backupModeLabel.Text = "Backup Mode Options:";
            // 
            // browseSourceButton
            // 
            this.browseSourceButton.Location = new System.Drawing.Point(980, 33);
            this.browseSourceButton.Name = "browseSourceButton";
            this.browseSourceButton.Size = new System.Drawing.Size(75, 28);
            this.browseSourceButton.TabIndex = 17;
            this.browseSourceButton.Text = "Browse";
            this.browseSourceButton.UseVisualStyleBackColor = true;
            this.browseSourceButton.Click += new System.EventHandler(this.browseSourceButton_Click);
            // 
            // browseDestButton
            // 
            this.browseDestButton.Location = new System.Drawing.Point(980, 79);
            this.browseDestButton.Name = "browseDestButton";
            this.browseDestButton.Size = new System.Drawing.Size(75, 28);
            this.browseDestButton.TabIndex = 18;
            this.browseDestButton.Text = "Browse";
            this.browseDestButton.UseVisualStyleBackColor = true;
            this.browseDestButton.Click += new System.EventHandler(this.browseDestButton_Click);
            // 
            // miscOptionsLabel
            // 
            this.miscOptionsLabel.AutoSize = true;
            this.miscOptionsLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.miscOptionsLabel.Location = new System.Drawing.Point(519, 108);
            this.miscOptionsLabel.Name = "miscOptionsLabel";
            this.miscOptionsLabel.Size = new System.Drawing.Size(87, 16);
            this.miscOptionsLabel.TabIndex = 19;
            this.miscOptionsLabel.Text = "Misc Options:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 613);
            this.Controls.Add(this.miscOptionsLabel);
            this.Controls.Add(this.browseDestButton);
            this.Controls.Add(this.browseSourceButton);
            this.Controls.Add(this.backupModeLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.backupModeComboBox);
            this.Controls.Add(this.subDirComboBox);
            this.Controls.Add(this.optionsCheckedListBox);
            this.Controls.Add(this.subDirOptionsLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.destinationText);
            this.Controls.Add(this.destinationLabel);
            this.Controls.Add(this.sourceText);
            this.Controls.Add(this.sourceLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Robocopy GUI - By Request-Timeout";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sourceLabel;
        private System.Windows.Forms.TextBox sourceText;
        private System.Windows.Forms.Label destinationLabel;
        private System.Windows.Forms.TextBox destinationText;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label subDirOptionsLabel;
        private System.Windows.Forms.CheckedListBox optionsCheckedListBox;
        private System.Windows.Forms.ComboBox subDirComboBox;
        private System.Windows.Forms.ComboBox backupModeComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label backupModeLabel;
        private System.Windows.Forms.Button browseSourceButton;
        private System.Windows.Forms.Button browseDestButton;
        private System.Windows.Forms.Label miscOptionsLabel;
    }
}

