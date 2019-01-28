using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_HappyTickets.BL
{
    class FileSystemReader: IScriptReader
    {
        public string Read(string path)
        {
            StreamReader sr;
            try
            {
                sr = new StreamReader(path, System.Text.Encoding.Default);
            }
            catch (Exception)
            {
                return null;
            }
            string result = sr.ReadToEnd();

            return result;
        }

    }
}
