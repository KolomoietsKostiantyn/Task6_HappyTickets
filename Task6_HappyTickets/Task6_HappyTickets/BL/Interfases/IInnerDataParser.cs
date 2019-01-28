using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_HappyTickets.BL
{
    interface IInnerDataParser
    {
        bool StringToParams(string inner, out string scriptName, out int number);
        bool ValidArray(string [] arr);
    }
}
