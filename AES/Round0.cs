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
    public partial class Round0 : Form
    {
        int blockNum;
        public Round0()
        {
            InitializeComponent();
        }
        private void updateRoundKey0()
        {
            label_stateMatrixValue.Text = Attributes.RoundKey0[blockNum];
            label_stateMatrixText.Text = $"State Matrix {blockNum}";
        }

        private void button_addRoundKey_Click(object sender, EventArgs e)
        {
            blockNum = 0;
            label_stateMatrixText.Text = "State Matrix 0";
            label_roundKeyText.Text = "Round Key 0";
            label_roundKeyValue.Text = Attributes.ExpandedKeyBlocksString[0];

            updateRoundKey0();

            button_addRoundKey.Hide();
            button_next.Show();
            button_back.Show();
            label_stateMatrixValue.Show();
            label_stateMatrixText.Show();
            label_roundKeyValue.Show();
            label_roundKeyText.Show();
            label_additionSymbol.Show();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            if (blockNum != 0)
            {
                blockNum--;
                updateRoundKey0();
            }
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            if (blockNum != Attributes.RoundKey0.Length - 1)
            {
                blockNum++;
                updateRoundKey0();
            }
        }
    }
}
