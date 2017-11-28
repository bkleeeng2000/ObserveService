using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IpcServiceTest
{
    class Log
    {
        private string FilePath;
        private string DirPath;

        public Log(string FilePath, string DirPath)
        {
            this.FilePath = FilePath;
            this.DirPath = DirPath;
        }

        public void Write(string msg)
        {

        }
    }
}
