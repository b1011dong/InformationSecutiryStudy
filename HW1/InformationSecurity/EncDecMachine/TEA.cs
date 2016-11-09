using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncDecMachine
{
    class TEA : Cryptography
    {
        uint[] key;
        uint delta = 0x9e3779b9;

        public TEA(Logger logger, TextBox plainTextBox, TextBox cipherTextBox, TextBox keyTextBox, string defaultKey)
            : base(logger, plainTextBox, cipherTextBox, keyTextBox, defaultKey)
        {
            this.setPlainText("TEA, the Tiny Encryption Algorithm.");
            logger.addLog("- 64bit block(8 chars per block), 128bit key(hexadecimal length of 32)");
            printPlaintext();

            key = new uint[4];
        }

        protected override void loadKey()
        {
            char[] charKey;

            try
            {
                charKey = this.getRawKey().ToCharArray();
            }
            catch (Exception ex)
            {
                logger.addLog("No key available: default key " + this.defaultKey + " used");
                charKey = defaultKey.ToCharArray();
            }

            for(int i = 0; i < 4; i++)
            {
                string strKey = "";
                for(int j = i * 8; j < i * 8 + 8; j++)
                    strKey += charKey[j];
                this.key[i] = (uint)Convert.ToInt32(strKey, 16);
            }
        }

        public override void encrypt()
        {
            this.loadPlainText();
            this.loadKey();

            char[] plainText = this.getPlainText().ToCharArray();
            string ciphertext = "";
            uint l = 0, r = 0;
            uint sum = 0;

            for (int i = 0; i < plainText.Length; i += 8)
            {
                l = 0;
                r = 0;
                for (int j = 0; j < 4; j++)
                {
                    if(i + j < plainText.Length)
                        l += (uint)plainText[i + j] << ((3 - j) * 8);
                    else
                        l += (uint)' ' << ((3 - j) * 8);
                }
                for (int j = 4; j < 8; j++)
                {
                    if (i + j < plainText.Length)
                        r += (uint)plainText[i + j] << ((7 - j) * 8);
                    else
                        r += (uint)' ' << ((7 - j) * 8);
                }
                sum = 0;
                for (int j = 0; j < 32; j++)
                {
                    sum += delta;
                    l += ((r << 4) + (uint)key[0]) ^ (r + sum) ^ ((r >> 5) + (uint)key[1]);
                    r += ((l << 4) + (uint)key[2]) ^ (l + sum) ^ ((l >> 5) + (uint)key[3]);
                }
                uint[] mask = { 0x000000ff, 0x0000ff00, 0x00ff0000, 0xff000000 };
                for(int j = 3; j >= 0; j--)
                {
                    ciphertext += ((char)((l & mask[j]) >> (8 * j))).ToString();
                }
                for (int j = 3; j >= 0; j--)
                {
                    ciphertext += ((char)((r & mask[j]) >> (8 * j))).ToString();
                }
            }

            this.setCipherText(ciphertext);
            this.printCiphertext();

            logger.addLog("Encryption complete.");
        }

        public override void decrypt()
        {
            loadCipherText();
            loadKey();

            char[] ciphertext = this.getCipherText().ToCharArray();
            string plaintext = "";
            uint l = 0, r = 0;
            uint sum = this.delta << 5;

            for (int i = 0; i < ciphertext.Length; i += 8)
            {
                l = 0;
                r = 0;
                for (int j = 0; j < 4; j++)
                {
                    if (i + j < ciphertext.Length)
                        l += (uint)ciphertext[i + j] << (3 - j) * 8;
                    else
                        l += (uint)' ' << ((3 - j) * 8);
                }
                for (int j = 4; j < 8; j++)
                {
                    if (i + j < ciphertext.Length)
                        r += (uint)ciphertext[i + j] << ((7 - j) * 8);
                    else
                        r += (uint)' ' << ((7 - j) * 8);
                }
                sum = this.delta << 5;
                for (int j = 0; j < 32; j++)
                {
                    r -= ((l << 4) + key[2]) ^ (l + sum) ^ ((l >> 5) + key[3]);
                    l -= ((r << 4) + key[0]) ^ (r + sum) ^ ((r >> 5) + key[1]);
                    sum -= delta;
                }
                uint[] mask = { 0x000000ff, 0x0000ff00, 0x00ff0000, 0xff000000 };
                for (int j = 3; j >= 0; j--)
                {
                    plaintext += ((char)((l & mask[j]) >> (8 * j))).ToString();
                }
                for (int j = 3; j >= 0; j--)
                {
                    plaintext += ((char)((r & mask[j]) >> (8 * j))).ToString();
                }
            }

            this.setPlainText(plaintext);
            this.printPlaintext();

            logger.addLog("Decryption complete.");
        }
    }
}
