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
                this.crypto = new Caesar(this.logger, this.painTextBox, this.cipherTextBox, this.keyTextBox);
            }
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            try
            {
                crypto.encrypt();
            }
            catch(Exception ex)
            {
                logger.addLog("No Cryptography Available");
            }
        }

        private void decryptButton_Click(object sender, EventArgs e)
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
}
