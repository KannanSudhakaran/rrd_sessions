


namespace SimpleDelegateApp
{

    delegate void DPrintMessage(string name);

    internal class Program
    {
        static void Main(string[] args)
        {

            //   CaseStudy1();
            // CaseSTudy2();

            //CaseStudy3();


            DPrintMessage x;//can x point to lambda??

            //  x = PrintGoodBye;

            //x = delegate (string name)
            //{
            //    Console.WriteLine(name);
            //};

            x = (n) =>
            {
                Console.WriteLine($"lambda {n.ToUpper()} ");
                Console.WriteLine($"lambda {n.ToLower()} ");

            };

            x("Markonda");

        }

        private static void CaseStudy3()
        {
            PrintWizard(PrintHello);
            PrintWizard(PrintGoodBye);
            PrintWizard(delegate(string name){

                Console.WriteLine($"Anonymous functions in C#  says hello to {name}");

            });

            PrintWizard((n) =>Console.WriteLine($"Lambda functions in C#  says hello to {n}"));

        }

        static void PrintWizard(DPrintMessage fptrCallBack)//polymorphic
        {
            Console.Write("Doing priting operations");
            Console.WriteLine("Operation completed");
            fptrCallBack("CHAMP");
        }

        private static void CaseSTudy2()
        {
            DPrintMessage x;
            x = PrintGoodBye;
            x += PrintGoodBye;//x.Add()
            x += PrintHello; //x.Add()
                             // x += Foo;

            x("RRD Champ");
        }

        private static void CaseStudy1()
        {
          
            DPrintMessage x;//x expects a function
            x= PrintHello;
            x("Sachin");
            x = PrintGoodBye;
            x("Akhilesh");

        }


      


        static  void PrintHello(string name)
        {
            Console.WriteLine($"Hello {name}");

        }

       static void PrintGoodBye(string name)
        {
            Console.WriteLine($"GoodBye {name}");

        }

        static void Foo() { 
        }


    }
}
