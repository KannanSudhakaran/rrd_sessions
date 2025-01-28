using SimpleInterfaceApp.Models;

namespace SimpleInterfaceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // ICrudable x;//x expects an ojbect of a class wwhich implemnts inerface

          //  DoDbOperations(new CustomerRepository());
           // DoDbOperations(new CountryRepository());
            DoDbOperations(new ProductRespository());

           

        }

        static void DoDbOperations(ICrudable crudable)//IsA,Polymorphic
        {


            Console.WriteLine("Doing db operations");
            crudable.Create();
            crudable.Read();
            crudable.Update();
            crudable.Delete();

            Console.WriteLine("Completed db operations..");

        }
    }
}
