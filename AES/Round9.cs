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
    public partial class Round9 : Form
    {
        public Round9()
        {
            InitializeComponent();

            int startPos = 9 * (54 * Attributes.NumberOfBlocks);
            int length = 54 * Attributes.NumberOfBlocks;
            label_subBytesText.Text = Attributes.SubBytes.Substring(startPos, length);
            label_shiftRowsText.Text = Attributes.ShiftRows.Substring(startPos, length);
            label_addRoundKeyText.Text = Attributes.AddRoundKey.Substring(startPos, length);
        }
    }
}
