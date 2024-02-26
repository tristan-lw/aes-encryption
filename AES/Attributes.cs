using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AES
{
    internal class Attributes
    {
        internal static string PlaintextString { get; set; }
        internal static byte[] PlaintextBytes { get; set; }
        internal static byte[] Key { get; set; }
        internal static byte[] ExpandedKey { get; set; }
        internal static Block[] PlaintextBlocks { get; set; }
        internal static string[] RoundKey0 { get; set; }
        internal static string[] ExpandedKeyBlocksString { get; set; }
    }
}
