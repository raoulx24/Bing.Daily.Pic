using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bing.Daily.Pic.Common.Managers
{
    public class ImagesStorageManager
    {
        public ImagesStorageManager(string tempFolder)
        {
            if (!Directory.Exists(tempFolder))
                Directory.CreateDirectory(tempFolder);

            TempFiles = new TempFileCollection(tempFolder);
        }

        public string AddNewTempFile(string extension)
        {
            string fileName = string.Format("{0}.{1}", Guid.NewGuid(), extension);

            TempFiles.AddFile(Path.Combine(TempFolder, fileName), false);

            return fileName;
        }

        public string TempFolder
        {
            get { return TempFiles.TempDir; }
        }

        public void ClearTempImages()
        {
            TempFiles.Delete();
        }

        private TempFileCollection TempFiles
        {
            get { return _tempFiles; }
            set { _tempFiles = value; }
        }

        private TempFileCollection _tempFiles;
    }
}
