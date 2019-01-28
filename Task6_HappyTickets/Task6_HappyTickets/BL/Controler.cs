using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task6_HappyTickets.Intermediate;

namespace Task6_HappyTickets.BL
{
    class Controler
    {
        IInnerDataParser _innerDataParser;
        ILogics _logics;
        IScriptSelecter _scriptSelecter;
        IScriptReader _scriptReader;
        string[] _arr;
        IVisualizer _visulizer;

        public Controler(IVisualizer visulizer, IInnerDataParser innerDataParser, IScriptSelecter scriptSelecter, IScriptReader scriptReader, string [] arr)
        {
            _visulizer = visulizer;
            _innerDataParser = innerDataParser;
            _scriptSelecter = scriptSelecter;
            _scriptReader = scriptReader;
            _arr = arr;
        }

        public void Start()
        {
            string readResult;
            if (_innerDataParser.ValidArray(_arr))
            {
                readResult = _scriptReader.Read(_arr[0]);
            }
            else
            {
                _visulizer.SendMasage(Messages.Instruction);
                return;
            }
          
            if (readResult != null)
            {
                string scriptName;
                int number;
                if (_innerDataParser.StringToParams(readResult, out scriptName, out number))
                {
                    _logics = _scriptSelecter.MakeChoiсe(scriptName);
                    if (_logics != null)
                    {
                        int quantity = _logics.CalculateCountOccurrences(number);
                        _visulizer.SendAnswer(_logics.Type, quantity, number);
                    }
                    else
                    {
                        _visulizer.SendMasage(Messages.IncorectScript);
                    }

                }
                else
                {
                    _visulizer.SendMasage(Messages.IncorectContext);
                }
            }
            else
            {
                _visulizer.SendMasage(Messages.WrongPath);
            }
        }
    }
}
