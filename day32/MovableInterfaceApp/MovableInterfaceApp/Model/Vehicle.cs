using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovableInterfaceApp.Model
{
    public interface IDiscription { 
    
        string Desription { get; }
    }
    internal abstract  class Vehicle : IMovable,IDiscription
    {
        private string _brand;
        private string _chasisNo;

        public Vehicle(string brand, string chasisNo) { 
          _brand = brand;
          _chasisNo = chasisNo;
        
        }

        public string Brand { get { return _brand; } }
        public string ChasisNo { get { return _chasisNo; }}

        public string Desription {

            get {
               return "Desxription of Vehicle goes here...!!";
            }
        }

        public abstract void Move();
     
    }
}
