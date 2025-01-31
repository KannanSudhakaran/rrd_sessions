using System.Runtime.Serialization;

namespace CalcCommonLib.Exceptions
{

    public class NotAnEvenNumberExcepion : Exception
    {

        private int _no;
        public NotAnEvenNumberExcepion(int no)
        {
            _no = no;

        }

        public override string Message
        {

            get
            {

                return $"The number passed {_no} is not an even number ";
            }

        }
    }
}