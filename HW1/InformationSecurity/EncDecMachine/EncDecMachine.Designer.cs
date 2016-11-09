namespace EncDecMachine
{
    partial class EncDecMachine
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EncDecMachine));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveLogToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBlankLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlGroupBox = new System.Windows.Forms.GroupBox();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.cipherTextBox = new System.Windows.Forms.TextBox();
            this.textLabel = new System.Windows.Forms.Label();
            this.encryptButton = new System.Windows.Forms.Button();
            this.decryptButton = new System.Windows.Forms.Button();
            this.crytoLabel = new System.Windows.Forms.Label();
            this.cryptoComboBox = new System.Windows.Forms.ComboBox();
            this.plainTextBox = new System.Windows.Forms.TextBox();
            this.logGroupBox = new System.Windows.Forms.GroupBox();
            this.logListBox = new System.Windows.Forms.ListBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFileForEncryptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFileForDecryptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelFileCryptoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.controlGroupBox.SuspendLayout();
            this.logGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logToolStripMenuItem,
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(859, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // logToolStripMenuItem
            // 
            this.logToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearLogToolStripMenuItem,
            this.saveLogToFileToolStripMenuItem,
            this.addBlankLineToolStripMenuItem});
            this.logToolStripMenuItem.Name = "logToolStripMenuItem";
            this.logToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.logToolStripMenuItem.Text = "Log";
            // 
            // clearLogToolStripMenuItem
            // 
            this.clearLogToolStripMenuItem.Name = "clearLogToolStripMenuItem";
            this.clearLogToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.clearLogToolStripMenuItem.Text = "Clear log";
            this.clearLogToolStripMenuItem.Click += new System.EventHandler(this.clearLogToolStripMenuItem_Click);
            // 
            // saveLogToFileToolStripMenuItem
            // 
            this.saveLogToFileToolStripMenuItem.Name = "saveLogToFileToolStripMenuItem";
            this.saveLogToFileToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.saveLogToFileToolStripMenuItem.Text = "Save log to file";
            this.saveLogToFileToolStripMenuItem.Click += new System.EventHandler(this.saveLogToFileToolStripMenuItem_Click);
            // 
            // addBlankLineToolStripMenuItem
            // 
            this.addBlankLineToolStripMenuItem.Name = "addBlankLineToolStripMenuItem";
            this.addBlankLineToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.addBlankLineToolStripMenuItem.Text = "Add blank line";
            this.addBlankLineToolStripMenuItem.Click += new System.EventHandler(this.addBlankLineToolStripMenuItem_Click);
            // 
            // controlGroupBox
            // 
            this.controlGroupBox.Controls.Add(this.keyTextBox);
            this.controlGroupBox.Controls.Add(this.cipherTextBox);
            this.controlGroupBox.Controls.Add(this.textLabel);
            this.controlGroupBox.Controls.Add(this.encryptButton);
            this.controlGroupBox.Controls.Add(this.decryptButton);
            this.controlGroupBox.Controls.Add(this.crytoLabel);
            this.controlGroupBox.Controls.Add(this.cryptoComboBox);
            this.controlGroupBox.Controls.Add(this.plainTextBox);
            this.controlGroupBox.Location = new System.Drawing.Point(10, 22);
            this.controlGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.controlGroupBox.Name = "controlGroupBox";
            this.controlGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.controlGroupBox.Size = new System.Drawing.Size(838, 91);
            this.controlGroupBox.TabIndex = 2;
            this.controlGroupBox.TabStop = false;
            this.controlGroupBox.Text = "Control";
            // 
            // keyTextBox
            // 
            this.keyTextBox.Location = new System.Drawing.Point(224, 63);
            this.keyTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(529, 21);
            this.keyTextBox.TabIndex = 10;
            // 
            // cipherTextBox
            // 
            this.cipherTextBox.Location = new System.Drawing.Point(224, 38);
            this.cipherTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cipherTextBox.Name = "cipherTextBox";
            this.cipherTextBox.Size = new System.Drawing.Size(529, 21);
            this.cipherTextBox.TabIndex = 9;
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Location = new System.Drawing.Point(156, 17);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(62, 60);
            this.textLabel.TabIndex = 7;
            this.textLabel.Text = "Plaintext\r\n\r\nCiphertext\r\n\r\nKey";
            this.textLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // encryptButton
            // 
            this.encryptButton.Location = new System.Drawing.Point(759, 14);
            this.encryptButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(74, 21);
            this.encryptButton.TabIndex = 6;
            this.encryptButton.Text = "Encrypt";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // decryptButton
            // 
            this.decryptButton.Location = new System.Drawing.Point(759, 38);
            this.decryptButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(74, 21);
            this.decryptButton.TabIndex = 5;
            this.decryptButton.Text = "Decrypt";
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // crytoLabel
            // 
            this.crytoLabel.AutoSize = true;
            this.crytoLabel.Location = new System.Drawing.Point(5, 17);
            this.crytoLabel.Name = "crytoLabel";
            this.crytoLabel.Size = new System.Drawing.Size(81, 12);
            this.crytoLabel.TabIndex = 3;
            this.crytoLabel.Text = "Cryptography";
            // 
            // cryptoComboBox
            // 
            this.cryptoComboBox.FormattingEnabled = true;
            this.cryptoComboBox.Items.AddRange(new object[] {
            "Caesar",
            "TEA"});
            this.cryptoComboBox.Location = new System.Drawing.Point(5, 38);
            this.cryptoComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cryptoComboBox.Name = "cryptoComboBox";
            this.cryptoComboBox.Size = new System.Drawing.Size(146, 20);
            this.cryptoComboBox.TabIndex = 2;
            this.cryptoComboBox.SelectedIndexChanged += new System.EventHandler(this.cryptoComboBox_SelectedIndexChanged);
            // 
            // plainTextBox
            // 
            this.plainTextBox.Location = new System.Drawing.Point(224, 14);
            this.plainTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.plainTextBox.Name = "plainTextBox";
            this.plainTextBox.Size = new System.Drawing.Size(529, 21);
            this.plainTextBox.TabIndex = 0;
            // 
            // logGroupBox
            // 
            this.logGroupBox.Controls.Add(this.logListBox);
            this.logGroupBox.Location = new System.Drawing.Point(10, 118);
            this.logGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logGroupBox.Name = "logGroupBox";
            this.logGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logGroupBox.Size = new System.Drawing.Size(838, 260);
            this.logGroupBox.TabIndex = 3;
            this.logGroupBox.TabStop = false;
            this.logGroupBox.Text = "Log";
            // 
            // logListBox
            // 
            this.logListBox.FormattingEnabled = true;
            this.logListBox.ItemHeight = 12;
            this.logListBox.Location = new System.Drawing.Point(5, 19);
            this.logListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logListBox.Name = "logListBox";
            this.logListBox.Size = new System.Drawing.Size(828, 232);
            this.logListBox.TabIndex = 0;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(10, 382);
            this.progressBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(838, 18);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 4;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadFileForEncryptionToolStripMenuItem,
            this.loadFileForDecryptionToolStripMenuItem,
            this.cancelFileCryptoToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadFileForEncryptionToolStripMenuItem
            // 
            this.loadFileForEncryptionToolStripMenuItem.Name = "loadFileForEncryptionToolStripMenuItem";
            this.loadFileForEncryptionToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.loadFileForEncryptionToolStripMenuItem.Text = "Load file for encryption";
            this.loadFileForEncryptionToolStripMenuItem.Click += new System.EventHandler(this.loadFileForEncryptionToolStripMenuItem_Click);
            // 
            // loadFileForDecryptionToolStripMenuItem
            // 
            this.loadFileForDecryptionToolStripMenuItem.Name = "loadFileForDecryptionToolStripMenuItem";
            this.loadFileForDecryptionToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.loadFileForDecryptionToolStripMenuItem.Text = "Load file for decryption";
            this.loadFileForDecryptionToolStripMenuItem.Click += new System.EventHandler(this.loadFileForDecryptionToolStripMenuItem_Click);
            // 
            // cancelFileCryptoToolStripMenuItem
            // 
            this.cancelFileCryptoToolStripMenuItem.Name = "cancelFileCryptoToolStripMenuItem";
            this.cancelFileCryptoToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.cancelFileCryptoToolStripMenuItem.Text = "Cancel file crypto";
            this.cancelFileCryptoToolStripMenuItem.Click += new System.EventHandler(this.cancelFileCryptoToolStripMenuItem_Click);
            // 
            // EncDecMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 410);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.logGroupBox);
            this.Controls.Add(this.controlGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EncDecMachine";
            this.Text = "Encryption/Decryption Machine by Park, Dongwon";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.controlGroupBox.ResumeLayout(false);
            this.controlGroupBox.PerformLayout();
            this.logGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox controlGroupBox;
        private System.Windows.Forms.TextBox cipherTextBox;
        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.Button decryptButton;
        private System.Windows.Forms.Label crytoLabel;
        private System.Windows.Forms.ComboBox cryptoComboBox;
        private System.Windows.Forms.TextBox plainTextBox;
        private System.Windows.Forms.GroupBox logGroupBox;
        private System.Windows.Forms.ListBox logListBox;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveLogToFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBlankLineToolStripMenuItem;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFileForEncryptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFileForDecryptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelFileCryptoToolStripMenuItem;
    }
}

