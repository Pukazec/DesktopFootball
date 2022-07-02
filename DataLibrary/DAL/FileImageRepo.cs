using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.DAL
{
    public class FileImageRepo
    {
        private static readonly string DIR = "C:/temp";
        private static readonly string PATH = DIR + "/images.txt";

        public FileImageRepo()
        {
            CreateFilesIfNonExistent();
        }

        private void CreateFilesIfNonExistent()
        {
            Directory.CreateDirectory(DIR);
            if (!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
        }
    }
}
