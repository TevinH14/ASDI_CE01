using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TevinHamilton_CE01
{
    class Customer
    {
        private string _name;
        public CheckingAccount _userAccount { get; set; }

        public Customer(string name)
        {
            Console.WriteLine("costomer created");
            _name = name;
        }
        public string GetName()
        {
            return _name;
        }

    }
}
