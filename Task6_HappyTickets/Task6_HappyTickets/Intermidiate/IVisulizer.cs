using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_HappyTickets.Intermidiate
{
    interface IVisulizer
    {
        void SendMasage(Messages mes);
        void SendAnswer(ScryptType type, int count);
        string AskPath();
        string AskNunber();
    }
}
