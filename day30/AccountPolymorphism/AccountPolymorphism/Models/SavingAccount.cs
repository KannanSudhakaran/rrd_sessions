using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPolymorphism.Models
{
    internal class SavingAccount : Account
    {
        public SavingAccount(string id, string name, double balance):base(id,name,balance)
        { 
        }

      
        public override void Widthdraw(double amount)
        {
            if(_balance-amount < 1000) //fail early
            {
                var ex = new Exception("NO funds,min balance 1000");
                throw ex;
            }

            _balance = _balance - amount;


        }

        public override string Type {
            get {
                return "SavingAccount";
            }
        }
    }
}
