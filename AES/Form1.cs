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
        private Details detailsForm;
        private string text;
        public Main()
        {
            InitializeComponent();
            format = new Format();
            keyInStringFormat = true;
            encrypt = new Encrypt();
            detailsForm = new Details();
        }

        private void button_encrypt_Click(object sender, EventArgs e)
        {
            if (textBox_plaintext.Text == "" || textBox_key.Text == "")
            {
                MessageBox.Show("ERROR: 1 or more inputs missing");
            } else
            {
                // Store plaintext in string form
                Attributes.PlaintextString = textBox_plaintext.Text;
                // Store plaintext in byte form
                Attributes.PlaintextBytes = format.ConvertPlaintextToBytes(Attributes.PlaintextString);

                // Check whether the key is in string or byte form
                // Convert key into hexadecimal bytes and store
                if (!keyInStringFormat)
                {
                    Attributes.Key = format.ConvertByteKeyToBytes(textBox_key.Text);
                }
                else
                {
                    Attributes.Key = format.ConvertStringKeyToBytes(textBox_key.Text);
                }

                // Perform encryption
                encrypt.encrypt();
                
                label_ciphertextAnswer.Text = encrypt.WriteBlocks();
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
            text = "This isn't really a round, but each state matrix is XORed with round key 0:\n";
            text += encrypt.round0;
            detailsForm.label_detailsForm.Text = text;
            detailsForm.label_detailsForm.BringToFront();
            detailsForm.Show();
        }

        private void button_keyExpansion_Click(object sender, EventArgs e)
        {
            text = $"Key: {BitConverter.ToString(Attributes.Key).Replace("-", "")}\n";

            List<string> chunks = Enumerable.Range(0, BitConverter.ToString(Attributes.ExpandedKey).Replace("-", "").Length / 32)
            .Select(i => BitConverter.ToString(Attributes.ExpandedKey).Replace("-", "").Substring(i * 32, 32)).ToList();

            for (int i = 0; i < chunks.Count; i++) {
                text += $"Round {i}: {chunks[i]}\n";
            }

            detailsForm.label_detailsForm.Text = text;
            detailsForm.Show();
        }
    }
    
}
