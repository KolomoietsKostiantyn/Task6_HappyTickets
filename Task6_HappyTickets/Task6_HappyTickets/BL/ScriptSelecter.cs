using System;
using System.Linq;
using System.Text;

namespace Task6_HappyTickets.BL
{
    class ScriptSelecter: IScriptSelecter
    {
        string _moskowScrypt = "Moskow";
        string _piretScrypt = "Piter";

        public ILogics MakeChoiсe(string scriptName)
        {
            if (string.IsNullOrEmpty(scriptName))
            {
                return null;
            }

            ILogics result = null;
            if (scriptName == _moskowScrypt)
            {
                result = new MoskowLogics();
            }
            if (scriptName == _piretScrypt)
            {
                result = new PiterLogics();
            }

            return result;
        }
    }
}