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
            this.painTextBox = new System.Windows.Forms.TextBox();
            this.logGroupBox = new System.Windows.Forms.GroupBox();
            this.logListBox = new System.Windows.Forms.ListBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.menuStrip1.SuspendLayout();
            this.controlGroupBox.SuspendLayout();
            this.logGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(982, 28);
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
            this.logToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.logToolStripMenuItem.Text = "Log";
            // 
            // clearLogToolStripMenuItem
            // 
            this.clearLogToolStripMenuItem.Name = "clearLogToolStripMenuItem";
            this.clearLogToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.clearLogToolStripMenuItem.Text = "Clear log";
            this.clearLogToolStripMenuItem.Click += new System.EventHandler(this.clearLogToolStripMenuItem_Click);
            // 
            // saveLogToFileToolStripMenuItem
            // 
            this.saveLogToFileToolStripMenuItem.Name = "saveLogToFileToolStripMenuItem";
            this.saveLogToFileToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.saveLogToFileToolStripMenuItem.Text = "Save log to file";
            this.saveLogToFileToolStripMenuItem.Click += new System.EventHandler(this.saveLogToFileToolStripMenuItem_Click);
            // 
            // addBlankLineToolStripMenuItem
            // 
            this.addBlankLineToolStripMenuItem.Name = "addBlankLineToolStripMenuItem";
            this.addBlankLineToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
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
            this.controlGroupBox.Controls.Add(this.painTextBox);
            this.controlGroupBox.Location = new System.Drawing.Point(12, 27);
            this.controlGroupBox.Name = "controlGroupBox";
            this.controlGroupBox.Size = new System.Drawing.Size(958, 114);
            this.controlGroupBox.TabIndex = 2;
            this.controlGroupBox.TabStop = false;
            this.controlGroupBox.Text = "Control";
            // 
            // keyTextBox
            // 
            this.keyTextBox.Location = new System.Drawing.Point(257, 79);
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(604, 25);
            this.keyTextBox.TabIndex = 10;
            // 
            // cipherTextBox
            // 
            this.cipherTextBox.Location = new System.Drawing.Point(257, 48);
            this.cipherTextBox.Name = "cipherTextBox";
            this.cipherTextBox.Size = new System.Drawing.Size(604, 25);
            this.cipherTextBox.TabIndex = 9;
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Location = new System.Drawing.Point(178, 21);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(73, 75);
            this.textLabel.TabIndex = 7;
            this.textLabel.Text = "Plaintext\r\n\r\nCiphertext\r\n\r\nKey";
            // 
            // encryptButton
            // 
            this.encryptButton.Location = new System.Drawing.Point(867, 18);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(85, 26);
            this.encryptButton.TabIndex = 6;
            this.encryptButton.Text = "Encrypt";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // decryptButton
            // 
            this.decryptButton.Location = new System.Drawing.Point(867, 47);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(85, 26);
            this.decryptButton.TabIndex = 5;
            this.decryptButton.Text = "Decrypt";
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // crytoLabel
            // 
            this.crytoLabel.AutoSize = true;
            this.crytoLabel.Location = new System.Drawing.Point(6, 21);
            this.crytoLabel.Name = "crytoLabel";
            this.crytoLabel.Size = new System.Drawing.Size(94, 15);
            this.crytoLabel.TabIndex = 3;
            this.crytoLabel.Text = "Cryptography";
            // 
            // cryptoComboBox
            // 
            this.cryptoComboBox.FormattingEnabled = true;
            this.cryptoComboBox.Items.AddRange(new object[] {
            "Caesar",
            "Permutation",
            "Double Transposition"});
            this.cryptoComboBox.Location = new System.Drawing.Point(6, 47);
            this.cryptoComboBox.Name = "cryptoComboBox";
            this.cryptoComboBox.Size = new System.Drawing.Size(166, 23);
            this.cryptoComboBox.TabIndex = 2;
            this.cryptoComboBox.SelectedIndexChanged += new System.EventHandler(this.cryptoComboBox_SelectedIndexChanged);
            // 
            // painTextBox
            // 
            this.painTextBox.Location = new System.Drawing.Point(257, 18);
            this.painTextBox.Name = "painTextBox";
            this.painTextBox.Size = new System.Drawing.Size(604, 25);
            this.painTextBox.TabIndex = 0;
            // 
            // logGroupBox
            // 
            this.logGroupBox.Controls.Add(this.logListBox);
            this.logGroupBox.Location = new System.Drawing.Point(12, 147);
            this.logGroupBox.Name = "logGroupBox";
            this.logGroupBox.Size = new System.Drawing.Size(958, 325);
            this.logGroupBox.TabIndex = 3;
            this.logGroupBox.TabStop = false;
            this.logGroupBox.Text = "Log";
            // 
            // logListBox
            // 
            this.logListBox.FormattingEnabled = true;
            this.logListBox.ItemHeight = 15;
            this.logListBox.Location = new System.Drawing.Point(6, 24);
            this.logListBox.Name = "logListBox";
            this.logListBox.Size = new System.Drawing.Size(946, 289);
            this.logListBox.TabIndex = 0;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 478);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(958, 23);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 4;
            // 
            // EncDecMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 513);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.logGroupBox);
            this.Controls.Add(this.controlGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
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
        private System.Windows.Forms.TextBox painTextBox;
        private System.Windows.Forms.GroupBox logGroupBox;
        private System.Windows.Forms.ListBox logListBox;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveLogToFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBlankLineToolStripMenuItem;
        private System.Windows.Forms.TextBox keyTextBox;
    }
}

