using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPolymorphism.Models
{
    internal abstract class Account
    {
        private string _id;
        private string _name;
        protected double _balance;

        public Account(string id, string name, double balance)
        {

            _name = name;
            _balance = balance;
            _id = id;
        }


        public abstract void Widthdraw(double amount);

        public void Deposit(double amount) {

            _balance += amount;
        }
        
        public double Balance { get { return _balance; } }
        public string Name { get { return _name; } }

        public abstract string Type { get; }

        public string Id
        {
            get
            {
                return _id;
            }
        }


    }
}
