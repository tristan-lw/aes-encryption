using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AES
{
    public partial class Main : Form
    {
        private Format format;
        private Encrypt encrypt;
        private bool keyInStringFormat;
        private Round0 round0;
        private Round1 round1;
        private Round2 round2;
        private Round3 round3;
        private Round4 round4;
        private Round5 round5;
        private Round6 round6;
        private Round7 round7;
        private Round8 round8;
        private Round9 round9;
        public Main()
        {
            InitializeComponent();
            format = new Format();
            keyInStringFormat = true;
            encrypt = new Encrypt();
        }

        private void button_encrypt_Click(object sender, EventArgs e)
        {
            if (textBox_plaintext.Text == "" || textBox_key.Text == "")
            {
                MessageBox.Show("ERROR: 1 or more inputs missing");
            }
            else
            {
                // Store plaintext in string form
                Attributes.PlaintextString = textBox_plaintext.Text;
                // Store plaintext in byte form
                Attributes.PlaintextBytes = format.ConvertPlaintextToBytes(Attributes.PlaintextString);

                // Check whether the key is in string or byte form
                // Convert key into hexadecimal bytes and store
                if (!keyInStringFormat)
                {
                    if (textBox_key.Text.Replace(" ", "").Length != 32)
                    {
                        MessageBox.Show("ERROR: Key is not 16 bytes");
                    } else
                    {
                        Attributes.Key = format.ConvertByteKeyToBytes(textBox_key.Text.Replace(" ", ""));
                        // Perform encryption
                        encrypt.encrypt();

                        // Write ciphertext
                        label_ciphertextAnswer.Text = encrypt.WriteBlocks();
                    }       
                }
                else
                {
                    if (textBox_key.Text.Length != 16)
                    {
                        MessageBox.Show("ERROR: Key is not 16 bytes");
                    } else
                    {
                        Attributes.Key = format.ConvertStringKeyToBytes(textBox_key.Text);
                        // Perform encryption
                        encrypt.encrypt();

                        // Write ciphertext
                        label_ciphertextAnswer.Text = encrypt.WriteBlocks();
                    }
                }
            }
        }

        private void button_keyInString_Click(object sender, EventArgs e)
        {
            keyInStringFormat = true;
            button_keyInString.BackColor = Color.Green;
            button_keyInBytes.BackColor = Color.Red;
        }
        private void button_keyInBytes_Click(object sender, EventArgs e)
        {
            keyInStringFormat = false;
            button_keyInBytes.BackColor = Color.Green;
            button_keyInString.BackColor = Color.Red;
        }

        private void button_round0_Click(object sender, EventArgs e)
        {
            round0 = new Round0();
            round0.Show();
        }
        private void button_round1_Click(object sender, EventArgs e)
        {
            round1 = new Round1();
            round1.Show();
        }
        private void button_round2_Click(object sender, EventArgs e)
        {
            round2 = new Round2();
            round2.Show();
        }
        private void button_round3_Click(object sender, EventArgs e)
        {
            round3 = new Round3();
            round3.Show();
        }
        private void button_round4_Click(object sender, EventArgs e)
        {
            round4 = new Round4();
            round4.Show();
        }
        private void button_round5_Click(object sender, EventArgs e)
        {
            round5 = new Round5();
            round5.Show();
        }
        private void button_round6_Click(object sender, EventArgs e)
        {
            round6 = new Round6();
            round6.Show();
        }
        private void button_round7_Click(object sender, EventArgs e)
        {
            round7 = new Round7();
            round7.Show();
        }
        private void button_round8_Click(object sender, EventArgs e)
        {
            round8 = new Round8();
            round8.Show();
        }
        private void button_round9_Click(object sender, EventArgs e)
        {
            round9 = new Round9();
            round9.Show();
        }
    }
    
}
