using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task6_HappyTickets.Intermediate;

namespace Task6_HappyTickets.BL
{
    interface ILogics
    {
        int CalculateCountOccurrences(int num);
        ScryptType Type{get;}
    }
}
