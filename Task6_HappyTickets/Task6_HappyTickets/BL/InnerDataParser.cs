using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_HappyTickets.BL
{
    class InnerDataParser : IInnerDataParser
    {
        private readonly int _maxValue = 999999;

        public bool StringToParams(string inner, out string scriptName, out int number)
        {
            number = 0;
            scriptName = string.Empty;
            if (string.IsNullOrWhiteSpace(inner))
            {
                return false;
            }

            string[] arr = inner.Split(' ');
            int paramNumber = 2;
            if (arr.Length != paramNumber)
            {
                return false;
            }
            foreach (string item in arr)
            {
                if (string.IsNullOrWhiteSpace(item))
                {
                    return false;
                }
            }

            scriptName = arr[0];
            bool result = false;
            if (int.TryParse(arr[1], out number))
            {
                if (number > 0 && number <= _maxValue)
                {
                    result = true;
                }
            }

            return result;
        }

        public bool ValidArray(string[] arr)
        {
            if (arr != null || arr.Length < 1)
            {
                return false;
            }

            foreach (string item in arr)
            {
                if (string.IsNullOrWhiteSpace(item))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
