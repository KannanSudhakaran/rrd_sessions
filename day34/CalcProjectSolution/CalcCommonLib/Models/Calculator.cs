using CalcCommonLib.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcCommonLib.Models
{
    public class Calculator
    {


        public long PositiveNumberAddition(int first, int second) {
            if (AnyNumberIsNegative(first, second))
                throw new NegativeINputException(first, second);

            return first + second;
        
        
        }

        private bool AnyNumberIsNegative(int first, int second)
        {
            if (first < 0 || second < 0)
                return true;

            return false;
        }

        public long CubeEvenNo(int no) {
            if (!IsEven(no))
                throw new NotAnEvenNumberExcepion(no);

            return no * no * no;
        
        }

        private bool IsEven(int no)
        {
            return no % 2 == 0;
        }
    }
}
