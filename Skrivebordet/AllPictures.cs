using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Skrivebordet
{
    public class AllPictures
    {
        public List<string> GetAllPictures()
        {
            string[] fileEntries = Directory.GetFiles(@"Pictures\");
            List<string> pictures = new List<string>();

            foreach (string fileName in fileEntries)
            {
                pictures.Add(fileName);
            }

            return pictures;
        }
    }
}
