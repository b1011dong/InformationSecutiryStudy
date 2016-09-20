using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace EncDecMachine
{
    public partial class EncDecMachine : Form
    {
        private Cryptography crypto;
        private Logger logger;
        private bool isFileCrypto;

        public EncDecMachine()
        {
            InitializeComponent();

            logger = new Logger(this.logListBox);
        }

        private void clearLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logger.clearLog();
        }

        private void saveLogToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logger.saveLog();
        }

        private void addBlankLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int randNum = rand.Next(Int32.MinValue, Int32.MaxValue);
            string line = "";

            for (int i = 0; i < 32; i++)
            {
                if ((1 & (randNum >> i)) == 1)
                    line += "-";
                else
                    line += "_";
            }
            logger.addLog(line);
        }

        private void cryptoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            logger.addLog(this.cryptoComboBox.SelectedItem.ToString() + " Mode");
            
            if(this.cryptoComboBox.SelectedItem.ToString().Contains("Caesar"))
            {
                this.crypto = new Caesar(this.logger, this.plainTextBox, this.cipherTextBox, this.keyTextBox, "3");
            }
            else if (this.cryptoComboBox.SelectedItem.ToString().Contains("TEA"))
            {
                this.crypto = new TEA(this.logger, this.plainTextBox, this.cipherTextBox, this.keyTextBox, "00112233445566778899AABBCCDDEEFF");
            }
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            if (isFileCrypto == true)
            {
                logger.addLog("File crypto is not yet implemented");
            }
            else
            {
                try
                {
                    crypto.encrypt();
                }
                catch (Exception ex)
                {
                    logger.addLog("No Cryptography Available");
                }
            }
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            if (isFileCrypto == true)
            {
                logger.addLog("File crypto is not yet implemented");
            }
            else
            {
                try
                {
                    crypto.decrypt();
                }
                catch (Exception ex)
                {
                    logger.addLog("No Cryptography Available");
                }
            }
        }

        private void loadFileForEncryptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = fileDialog.FileName;
                string filename = fileDialog.SafeFileName;

                this.plainTextBox.Text = path;
                this.plainTextBox.Enabled = false;
                this.cipherTextBox.Enabled = false;
                this.isFileCrypto = true;
            }
        }

        private void loadFileForDecryptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = fileDialog.FileName;
                string filename = fileDialog.SafeFileName;

                this.cipherTextBox.Text = path;
                this.plainTextBox.Enabled = false;
                this.cipherTextBox.Enabled = false;
                this.isFileCrypto = true;
            }
        }

        private void cancelFileCryptoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.plainTextBox.Enabled = true;
            this.cipherTextBox.Enabled = true;
            this.isFileCrypto = false;
        }
    }
}
