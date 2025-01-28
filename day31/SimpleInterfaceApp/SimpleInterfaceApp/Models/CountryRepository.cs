using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterfaceApp.Models
{
    internal class CountryRepository : ICrudable
    {
        public void Create()
        {
            Console.WriteLine("country is created in db");
        }

        public void Delete()
        {
            Console.WriteLine("country is deleted in db");
        }

        public void Read()
        {
            Console.WriteLine("country records are seelct from db");
        }

        public void Update()
        {
            Console.WriteLine("country records are updated db");
        }
    }
}
