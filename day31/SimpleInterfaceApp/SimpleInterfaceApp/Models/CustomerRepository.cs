using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterfaceApp.Models
{

    //Repository layer
    internal class CustomerRepository : ICrudable
    {
        public void Foo() { 
        
        }
        public void Create()
        {
            Console.WriteLine("customer is created in db");
        }

        public void Delete()
        {
            Console.WriteLine("customer is deleted in db");
        }

        public void Read()
        {
            Console.WriteLine("customer records are seelct from db");
        }

        public void Update()
        {
            Console.WriteLine("customer records are updated db");
        }
    }
}
