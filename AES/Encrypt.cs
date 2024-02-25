using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AES
{
    internal class Encrypt
    {
        private KeyExpansion KE;
        private Functions func;
        private static Block[] plaintextBlocks;
        private int roundBytes;
        private static int numberOfBlocks;
        private byte[] roundArray;
        private byte[] column;
        private static int counter;
        private static byte[] plaintextBytesSliced;
        private string blockString;
        internal string round0 { get; set; }

        internal Encrypt()
        {
            KE = new KeyExpansion();
            func = new Functions();
            roundArray = new byte[16];
            blockString = "";
            round0 = "";
        }
        internal void encrypt()
        {
            // Perform key expansion
            KE.Expand(Attributes.Key);

            // Fill blocks
            FillBlocks();

            // For each block
            for (int blockNum = 0; blockNum < numberOfBlocks; blockNum++)
            {
                roundBytes = 0;
                // Add round key 1
                Array.Copy(Attributes.ExpandedKey, roundBytes, roundArray, 0, 16); // source, index, destination, length
                plaintextBlocks[blockNum] = func.AddRoundKey(plaintextBlocks[blockNum], roundArray);
                foreach (Block block in plaintextBlocks)
                {
                    round0 += block.WriteBlock(block);
                }
                for (int round = 1; round < 10; round++) // 9 rounds
                {
                    // Sub bytes    
                    for (int i = 0; i < plaintextBlocks[blockNum].Size; i++)
                    {
                        for (int j = 0; j < plaintextBlocks[blockNum].Size; j++)
                        {
                            plaintextBlocks[blockNum][i, j] = func.ApplySbox(plaintextBlocks[blockNum][i, j]);
                        }
                    }

                    // Shift rows
                    plaintextBlocks[blockNum] = func.ShiftRows(plaintextBlocks[blockNum], 0);

                    // Mix columns
                    column = new byte[4];

                    for (int a = 0; a < 4; a++)
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            column[i] = plaintextBlocks[blockNum][a, i];
                        }
                        column = func.MixColumn(column);

                        for (int i = 0; i < 4; i++)
                        {
                            plaintextBlocks[blockNum][a, i] = column[i];
                        }
                    }

                    // Add round key
                    roundBytes += 16;
                    Array.Copy(Attributes.ExpandedKey, roundBytes, roundArray, 0, 16);
                    plaintextBlocks[blockNum] = func.AddRoundKey(plaintextBlocks[blockNum], roundArray);
                }

                // Final round

                // Sub bytes
                for (int i = 0; i < plaintextBlocks[blockNum].Size; i++)
                {
                    for (int j = 0; j < plaintextBlocks[blockNum].Size; j++)
                    {
                        plaintextBlocks[blockNum][i, j] = func.ApplySbox(plaintextBlocks[blockNum][i, j]);
                    }
                }

                // Shift Rows
                plaintextBlocks[blockNum] = func.ShiftRows(plaintextBlocks[blockNum], 0);

                // Add round key
                roundBytes += 16;
                Array.Copy(Attributes.ExpandedKey, roundBytes, roundArray, 0, 16);
                plaintextBlocks[blockNum] = func.AddRoundKey(plaintextBlocks[blockNum], roundArray);
            }
            foreach (Block block in plaintextBlocks)
            {
                blockString += block.WriteBlock(block);
            }
        }
        internal string WriteBlocks()
        {
            /*string blockString = "";
            foreach (Block block in plaintextBlocks)
            {
                blockString = block.WriteBlock(block);
            }*/
            return blockString;
        }
        private static void FillBlocks()
        {
            // Calculate how many blocks are required
            numberOfBlocks = Attributes.PlaintextString.Length / 16;
            if (Attributes.PlaintextString.Length % 16 != 0)
            {
                numberOfBlocks += 1;
            }
            plaintextBlocks = new Block[numberOfBlocks];

            // Fill each block
            counter = 0;
            for (int i = 0; i < plaintextBlocks.Length; i++)
            {
                //plaintextBytesSliced = new byte[plaintextBytes.Length - counter];
                //plaintextBytesSliced = plaintextBytes[counter..];

                //ArraySegment<byte[]> plaintextBytesSliced = new ArraySegment<byte[]>(attributes.PlaintextBytes, counter, attributes.PlaintextBytes.Length - counter);

                plaintextBytesSliced = new byte[Attributes.PlaintextBytes.Length - counter];
                Array.Copy(Attributes.PlaintextBytes, counter, plaintextBytesSliced, 0, Attributes.PlaintextBytes.Length - counter);

                plaintextBlocks[i] = new Block(plaintextBytesSliced);
                counter += 16;
            }
        }
    }
}
