using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterfaceApp.Models
{
    internal class ProductRespository : ICrudable
    {
        public void Create()
        {
            Console.WriteLine("Proudct is created in db");
        }

        public void Delete()
        {
            Console.WriteLine("Proudct is deleted in db");
        }

        public void Read()
        {
            Console.WriteLine("Proudct records are seelct from db");
        }

        public void Update()
        {
            Console.WriteLine("Proudct records are updated db");
        }
    }
}
