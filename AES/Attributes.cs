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
    }
}
