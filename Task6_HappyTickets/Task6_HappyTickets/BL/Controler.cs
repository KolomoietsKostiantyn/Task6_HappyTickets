using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task6_HappyTickets.Intermidiate;

namespace Task6_HappyTickets.BL
{
    class Controler
    {
        private readonly int MaxNum = 999999;
        private IVisulizer _visulizer;
        private string [] _arr;
        IScriptDecide _scriptDecide;
        ILogics _logics;
        private string _path;
        private int _count;



        public Controler(IVisulizer visulizer, string[] arr)
        {
            _visulizer = visulizer;
            _arr = arr;
            _scriptDecide = new FileRederDeside();
        }

        public void Start()
        {
            if (ValidateInnerArr(_arr))
            {
                ScryptType alg = AlgoritmSelector(_path);
                if (AlgorithmCreator(alg))
                {
                    int result = _logics.Calculate(_count);
                    _visulizer.SendAnswer(_logics.Type, result);
                }
            }
            else
            {
                ScryptType alg;
                do
                {
                    _path =  _visulizer.AskPath();
                    alg = AlgoritmSelector(_path);
                    AlgorithmCreator(alg);
                } while (!AlgorithmCreator(alg));
                string strNum;
                do
                {
                    strNum = _visulizer.AskNunber();
                } while (!StringToNum(strNum,out _count));
                int result = _logics.Calculate(_count);
                _visulizer.SendAnswer(_logics.Type, result);
            }
        }




        private bool StringToNum(string str, out int num)
        {
            bool result = false;
            if (int.TryParse(str,out num))
            {
                if (num > 0 && num <= MaxNum)
                {
                    result = true;
                }
            }
            if (!result)
            {
                _visulizer.SendMasage(Messages.IncorectNumber);
            }

            return result;
        }

        private bool AlgorithmCreator(ScryptType algorithm)
        {
            bool result = false;
            switch (algorithm)
            {
                case ScryptType.Error:
                    _visulizer.SendMasage(Messages.WrongPath);
                    break;
                case ScryptType.Moskow:
                    _logics = new MoskowLogics();
                    result = true;
                    break;
                case ScryptType.Piter:
                    _logics = new PiterLogics();
                    result = true;
                    break;
                default:
                    break;
            }

            return result;
        }


        private ScryptType AlgoritmSelector(string path)
        {
            ScryptType type = ScryptType.Error;
            try
            {
                type = _scriptDecide.MakeChoise(path);
            }
            catch (FileNotFoundException)
            {
                //добавить логирование
            }
            return type;
        }

        private bool ValidateInnerArr(string[] arr)
        {
            if (arr == null || arr.Length != 2)
            {
                _visulizer.SendMasage(Messages.Instruction);
                return false;
            }

            bool result = true;
            _path = arr[0];
            if (!int.TryParse(arr[1],out _count))
            {
                _visulizer.SendMasage(Messages.Instruction);
                result = false;
            }

            return result;
        }

        

    }
}
