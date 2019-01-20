using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task6_HappyTickets.Intermidiate;

namespace Task6_HappyTickets.BL
{
    interface ILogics
    {
        ScryptType Type { get;}
        int Calculate(int num);
    }
}
