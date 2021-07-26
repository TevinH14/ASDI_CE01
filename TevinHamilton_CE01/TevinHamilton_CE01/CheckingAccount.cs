using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TevinHamilton_CE01
{
    class CheckingAccount
    {
        public decimal _accountBalance { get; set; }
        public int _accountNumber { get; set; }

        public CheckingAccount(decimal balance, int account)
        {
            Console.WriteLine("account created");
        }
        
        

    }
}
