﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AES
{
    internal class KeyExpansion
    {
        private static Block[] expandedKeyBlocks;
        private Functions func;
        private byte[] word;
        private int byteCounter;
        private int i;
        private static int numberOfBlocks;
        private static byte[] expandedKeySliced;
        private static int counter;
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
            FillBlocks();
        }
        private static void FillBlocks()
        {
            // Calculate how many blocks are required
            numberOfBlocks = Attributes.Key.Length / 16;
            if (Attributes.Key.Length % 16 != 0)
            {
                numberOfBlocks += 1;
            }
            expandedKeyBlocks = new Block[numberOfBlocks];

            // Fill each block
            counter = 0;
            for (int i = 0; i < expandedKeyBlocks.Length; i++)
            {
                //plaintextBytesSliced = new byte[plaintextBytes.Length - counter];
                //plaintextBytesSliced = plaintextBytes[counter..];

                //ArraySegment<byte[]> plaintextBytesSliced = new ArraySegment<byte[]>(attributes.PlaintextBytes, counter, attributes.PlaintextBytes.Length - counter);

                expandedKeySliced = new byte[Attributes.Key.Length - counter];
                Array.Copy(Attributes.Key, counter, expandedKeySliced, 0, Attributes.Key.Length - counter);

                expandedKeyBlocks[i] = new Block(expandedKeySliced);
                counter += 16;
            }
            counter = 0;
            Attributes.ExpandedKeyBlocksString = new string[expandedKeyBlocks.Length];
            foreach (Block block in expandedKeyBlocks)
            {
                Attributes.ExpandedKeyBlocksString[counter] = block.WriteBlock(block);
                counter++;
            }
        }
    }
}
