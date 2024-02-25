using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AES
{
    internal class Format
    {
        internal byte[] ConvertPlaintextToBytes(string plaintext)
        {
            return Encoding.UTF8.GetBytes(plaintext);
        }
        internal byte[] ConvertStringKeyToBytes(string key)
        {
            return Encoding.UTF8.GetBytes(key);
        }
        internal byte[] ConvertByteKeyToBytes(string key)
        {
            byte[] Key;
            Key = new byte[key.Length / 2];
            for (int i = 0; i < key.Length; i += 2)
            {
                Key[i / 2] = Convert.ToByte(key.Substring(i, 2), 16); // Convert from hex
            }
            return Key;
        }
    }
}
