﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task6_HappyTickets.Intermidiate;

namespace Task6_HappyTickets.BL
{
    class MoskowLogics : ILogics
    {
        private readonly int _dozen = 10;
        private readonly int _thousand = 1000;
        private readonly int MaxValue = 999999;

        public MoskowLogics()
        {
            Type = ScryptType.Moskow;
        }
        public ScryptType Type
        {
            get;
            private set;
        }

        public int Calculate(int num)
        {
            if (num <= 999)
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
            for (int i = _thousand; i < num; i++)
            {
                int part1;
                int part2;
                DivideNumberInHalf(i, out part1, out part2);
                if (CheckLuck(part1, part2))
                {
                    result++;
                }
            }

            return result;
        }

        private bool CheckLuck(int num1, int num2)
        {
            bool result = false;
            num1 = SumNumInNumber(num1);
            num2 = SumNumInNumber(num2);
            if (num1 == num2)
            {
                result = true;
            }

            return result;
        }


        private void DivideNumberInHalf(int num,out int part1, out int part2)
        {
            part1 = (num - (num - (num / _thousand) * _thousand))/ _thousand;
            part2 = num - part1 * _thousand;
        }


        private int SumNumInNumber(int num)
        {
            int result = 0;
            while (num != 0)
            {
                result += (num - (num / 10) * 10);
                num = num / 10;
            }

            return result;
        }
    }
}
