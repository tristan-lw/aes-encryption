using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AES
{
    internal class KeyExpansion
    {
        private Functions func;
        private byte[] word;
        private int byteCounter;
        private int i;
        internal KeyExpansion()
        {
            func = new Functions();
            word = new byte[4];
            byteCounter = 16;
            i = 1;
            Attributes.ExpandedKey = new byte[176];
        }
        internal void Expand(byte[] key)
        {
            Array.Copy(key, Attributes.ExpandedKey, 16); // Round key 1
            while (byteCounter < 176)
            {
                for (int a = 0; a < 4; a++) // Create word
                {
                    word[a] = Attributes.ExpandedKey[byteCounter - 4 + a];
                }
                if (byteCounter % 16 == 0) // First word of each round key
                {
                    func.RotateWord(word);
                    for (int a = 0; a < 4; a++)
                    {
                        word[a] = func.ApplySbox(word[a]);
                    }
                    word[0] ^= func.Rcon(i);
                    i++;
                }
                for (int a = 0; a < 4; a++)
                {
                    Attributes.ExpandedKey[byteCounter] = (byte)(Attributes.ExpandedKey[byteCounter - 16] ^ word[a]);
                    byteCounter++;
                }
            }
        }
    }
}
