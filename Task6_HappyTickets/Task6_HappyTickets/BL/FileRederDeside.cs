using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task6_HappyTickets.Intermidiate;

namespace Task6_HappyTickets.BL
{
    class FileRederDeside : IScriptDecide
    {
        private Stream _stream;

        public ScryptType MakeChoise(string path)
        {
            string allFile = Reader(path);

            return Analizer(allFile);
        }

        private string Reader(string path)
        {
            StreamReader sr;
            try
            {
                sr = new StreamReader(path, System.Text.Encoding.Default);
            }
            catch (Exception)
            {
                throw;
            }
            string result = sr.ReadToEnd();

            return result;
        }

        private ScryptType Analizer(string str)
        {
            ScryptType result = ScryptType.Error;
            if (str == (ScryptType.Moskow).ToString())
            {
                result = ScryptType.Moskow;
            }
            if (str == (ScryptType.Piter).ToString())
            {
                result = ScryptType.Piter;
            }

            return result;
        }
    }
}
