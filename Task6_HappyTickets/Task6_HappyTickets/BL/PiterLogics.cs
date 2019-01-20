using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task6_HappyTickets.Intermidiate;

namespace Task6_HappyTickets.BL
{
    class PiterLogics : ILogics
    {
        private readonly int _dozen = 10;
        private readonly int _minAvalible = 10;
        private readonly int MaxValue = 999999;

        public ScryptType Type
        {
            get;
            private set;
        }

        public PiterLogics()
        {
            Type = ScryptType.Piter;
        }


        public int Calculate(int num)
        {
            if (num < _minAvalible)
            {
                return 0;
            }
            if (num > MaxValue)
            {
                throw new ArgumentOutOfRangeException();
            }

            return CalcCountOccurrences(num);
        }

        private int CalcCountOccurrences(int num)
        {
            int result = 0;
            int num1;
            int num2;
            for (int i = _minAvalible; i < num; i++)
            {
                DivideNumberInTwoSum(i, out num1, out num2);
                if (CheckLuck(num1, num2))
                {
                    result++;
                }
            }

            return result;
        }

        private bool CheckLuck(int num1, int num2)
        {
            bool result = false;
            if (num1 == num2)
            {
                result = true;
            }

            return result;
        }

        private void DivideNumberInTwoSum(int num, out int sum1, out int sum2)
        {
            int i = 1;
            sum1 = 0;
            sum2 = 0;
            do
            {
                int digit = NumberDigit(num);
                int digitInPower = (int)Math.Pow(_dozen, digit);
                int number = num / digitInPower;
                if (i % 2 == 0)
                {
                    sum1 += number;
                }
                else
                {
                    sum2 += number;
                }
                i++;
                num = num - (num / digitInPower) * digitInPower;
            } while (num != 0);
        }

        private int NumberDigit(int num)
        {
            if (num == 0)
            {
                return 0;
            }
            int i = 0;
            do
            {
                i++;
                num = num / _dozen;
            } while (num !=0);

            return i -1;
        }
    }
}
