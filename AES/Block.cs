using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AES
{
    internal class Block
    {
        internal int Size { get; }
        private byte[,] block;
        private byte padding;
        private string blockString;
        internal byte this[int i, int j]
        {
            get { return block[i, j]; }
            set { block[i, j] = value; }
        }
        internal Block(byte[] plaintextBytes)
        {
            // Contents of a block
            //  [0,0] [0,1] [0,2] [0,3]
            //  [1,0] [1,1] [1,2] [1,3]
            //  ...
            //  [3,0,] [3,1] [3,2] [3,3]
            Size = 4;
            block = new byte[4, 4];
            int index = 0;
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    if (index < plaintextBytes.Length) // check if block can't be filled anymore
                    {
                        block[i, j] = plaintextBytes[index];
                        index++;
                    }
                    else
                    {
                        padding = (byte)(16 - index);
                        block[i, j] = padding;
                    }
                }
            }
        }
        internal Block()
        {

        }
        internal string WriteBlock(Block block)
        {
            blockString = "";
            for (int i = 0; i < block.Size; i++)
            {
                for (int j = 0; j < block.Size; j++)
                {
                    blockString += block[j, i].ToString("X2") + " ";                   
                }
                blockString += "\n";
            }
            blockString += "\n\n";
            return blockString;
        }
    }
}
