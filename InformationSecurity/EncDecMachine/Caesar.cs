using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncDecMachine
{
    class Caesar : Cryptography
    {
        int key;

        public Caesar(Logger logger, TextBox plainTextBox, TextBox cipherTextBox, TextBox keyTextBox) : base(logger, plainTextBox, cipherTextBox, keyTextBox, 3.ToString())
        {
            this.setPlainText("caesar cryptography example: no upper case");
            logger.addLog("- key for n shift.");
            printPlaintext();
        }
        
        protected override void loadKey()
        {
            try
            {
                this.key = Int32.Parse(this.getRawKey());
            }
            catch(Exception ex)
            {
                logger.addLog("No key available: default key " + this.defaultKey + " used");
                key = Int32.Parse(defaultKey);
            }
        }

        public override void encrypt()
        {
            this.loadPlainText();
            this.loadKey();

            char[] plaintext = this.getPlainText().ToCharArray();
            string ciphertext = "";

            for (int i = 0; i < plaintext.Length; i++)
            {
                if ('a' <= plaintext[i] && plaintext[i] <= 'z')
                    ciphertext += ((char)(((plaintext[i] - 'a' + key) % 26) + 'a')).ToString();
                else
                    ciphertext += plaintext[i].ToString();
            }

            this.setCipherText(ciphertext.ToUpper());

            this.printCiphertext();

            logger.addLog("Encryption complete.");
        }

        public override void decrypt()
        {
            loadCipherText();

            loadKey();

            char[] ciphertext = this.getCipherText().ToLower().ToCharArray();
            string plaintext = "";

            for (int i = 0; i < ciphertext.Length; i++)
            {
                if ('a' <= ciphertext[i] && ciphertext[i] <= 'z')
                    plaintext += ((char)(ciphertext[i] - key < 'a' ? 'z' - ('a' - (ciphertext[i] - key) - 1) : ciphertext[i] - key)).ToString();
                else
                    plaintext += ciphertext[i].ToString();
            }

            this.setPlainText(plaintext.ToLower());

            this.printPlaintext();

            logger.addLog("Decryption complete.");
        }
    }
}
