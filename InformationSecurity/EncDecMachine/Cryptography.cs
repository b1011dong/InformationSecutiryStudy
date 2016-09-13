using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncDecMachine
{
    abstract class Cryptography
    {
        protected Logger logger;
        private TextBox plainTextBox;
        private TextBox cipherTextBox;
        private TextBox keyTextBox;
        private string plaintext;
        private string ciphertext;
        protected string defaultKey;

        public Cryptography(Logger logger, TextBox plainTextBox, TextBox cipherTextBox, TextBox keyTextBox, string defaultKey)
        {
            this.logger = logger;
            this.plainTextBox = plainTextBox;
            this.cipherTextBox = cipherTextBox;
            this.keyTextBox = keyTextBox;
            this.plaintext = "";
            this.ciphertext = "";
            this.defaultKey = defaultKey;

            this.keyTextBox.Text = defaultKey;

            logger.addLog("default key " + defaultKey + " is generated.");
        }

        abstract public void encrypt();

        abstract public void decrypt();

        abstract protected void loadKey();

        protected string getRawKey()
        {
            return this.keyTextBox.Text;
        }

        public void printPlaintext()
        {
            this.plainTextBox.Text = this.plaintext;
        }

        public void printCiphertext()
        {
            this.cipherTextBox.Text = this.ciphertext;
        }

        protected void loadPlainText()
        {
            this.plaintext = this.plainTextBox.Text.ToString();
        }

        protected void setPlainText(string plaintext)
        {
            this.plaintext = plaintext;
        }

        protected string getPlainText()
        {
            return this.plaintext;
        }

        protected void loadCipherText()
        {
            this.ciphertext = this.cipherTextBox.Text.ToString();
        }

        protected void setCipherText(string ciphertext)
        {
            this.ciphertext = ciphertext;
        }

        protected string getCipherText()
        {
            return this.ciphertext;
        }
    }
}