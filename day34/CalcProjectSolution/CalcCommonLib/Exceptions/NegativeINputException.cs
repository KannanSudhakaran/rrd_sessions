using System.Runtime.Serialization;

namespace CalcCommonLib.Exceptions
{

    public class NegativeINputException : Exception
    {
        private int first;
        private int second;



        public NegativeINputException(int first, int second)
        {
            this.first = first;
            this.second = second;
        }

        public override string Message
        {

            get
            {

                if (first < 0 && second < 0)
                    return $"The number {first} and {second} both are Negative,Only postives supportd ";

                else if (first < 0)
                    return $"The number {first} is Negative,Only postives supportd ";
                else if (second < 0)

                    return $"The number {second} is Negative,Only postives supportd ";

                return base.Message;

            }

        }

    }
}