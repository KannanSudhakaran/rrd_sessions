using CalcCommonLib.Exceptions;
using CalcCommonLib.Models;

namespace CalcConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Calculator calc = new Calculator();
            try
            {
                Console.WriteLine( calc.CubeEvenNo(2));
                Console.WriteLine(calc.PositiveNumberAddition(-3,10));
            }

         

            catch (NotAnEvenNumberExcepion ex)
            {
                Console.WriteLine(ex.Message);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }


            Console.WriteLine( "end of main");

        }
    }
}
