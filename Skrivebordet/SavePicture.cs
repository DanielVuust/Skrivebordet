using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skrivebordet
{
    public class SavePicture
    {
        public SavePicture(string currentPath)
        {
            File.Copy(currentPath, $"Pictures\\{Path.GetFileName(currentPath)}");
        }
    }
}
