using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenHand.Helper
{
    public class ResourcesHelper
    {
        public const string closeButtonName = "close_16.png";
        public static string ResourcesFilePath
            = Path.Combine(Path.GetFullPath(@"..\..\"), "resources");
    }
}
