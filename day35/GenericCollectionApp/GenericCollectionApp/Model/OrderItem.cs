using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollectionApp.Models
{
    internal class OrderItem 
        // Data Tansfer Objects (DTO),Serializtion,Deserialization, REstfulAPIS,web developerment
    {


        public int Id { get;  set; }
        public string Name { get;  set; }
        public double UnitPrice { get;  set; }
        public int Quanity { get;  set; }
             
      
        public double LineItemCost
        {
            get
            {
                return Quanity * UnitPrice;
            }
        }

        public override string ToString()
        {
            return $" Id is {this.Id} , name is {this.Name} Quantiy  {this.Quanity} unitpric is {this.UnitPrice} , LineItemcost {this.LineItemCost}";
        }

    }
}
