using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Skrivebordet.Interfaces;

namespace Skrivebordet
{
    class UploadPicture : IUpload
    {

        public void Upload(string path)
        {
            SavePicture savePicture = new SavePicture(path);
        }
    }
}
