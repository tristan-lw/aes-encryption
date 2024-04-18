using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AES
{
    public partial class Config : Form
    {
        StringBuilder hb;
        Block block;
        public Config()
        {
            InitializeComponent();

            block = new Block();
            label_plaintextStringText.Text = Attributes.PlaintextString;

            hb = new StringBuilder(Attributes.PlaintextBytes.Length * 2);
            foreach (byte b in Attributes.PlaintextBytes)
            {
                hb.AppendFormat("{0:x2}", b);
            }
            label_plaintextBytesText.Text = Regex.Replace(hb.ToString(), ".{16}", "$0\n\n");

            hb = new StringBuilder(Attributes.Key.Length * 2);
            foreach (byte b in Attributes.Key)
            {
                hb.AppendFormat("{0:x2}", b);
            }
            label_keyBytesText.Text = Regex.Replace(hb.ToString(), ".{16}", "$0\n\n");

            hb = new StringBuilder(Attributes.ExpandedKey.Length * 2);
            foreach (byte b in Attributes.ExpandedKey)
            {
                hb.AppendFormat("{0:x2}", b);
            }
            
            label_keyExpansionText.Text = Regex.Replace(hb.ToString(), ".{32}", "$0\n\n");

            label_plaintextBlocksText.Text = "";
            foreach (Block b in Attributes.PlaintextBlocksOriginal)
            {
                label_plaintextBlocksText.Text += block.WriteBlock(b);
            }
        }
    }
}
