using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TevinHamilton_CE01
{
    class Main
    {
        private Menu _menu = new Menu();
        private Customer _currentCustomer = null;
   

        public Main()
        {
            _menu = new Menu("Create Customer","Create account ","Set Account Balance","Display Account Balance","Exit");
            _menu.Title = "Bank Teller";
            Display();
        }
        private void SelectOption()
        {
            switch (Utility.IntValidate("\nPlease make a selection"))
            {
                case 1:
                    CreateCostomer();
                    break;
                case 2:
                    CreateAccount();
                    break;
                case 3:
                    SetAccountBalance();
                    break;
                case 4:
                    AccountDisplay();
                    break;
                case 5:
                    Exit();
                    break;
                default:
                    SelectOption();
                    break;
            }
        }
        private void Display()
        {
            _menu.Display();
            SelectOption();
        }
        private void CreateCostomer()
        {
            string name = Utility.StringValidate("please enter your name");
            Customer newCustomer = new Customer(name);
            _currentCustomer = newCustomer;
            Console.WriteLine("press any button to return to main menu");
            Console.ReadKey();
            Display();
        }
        private void CreateAccount()
        {
            if (_currentCustomer == null )
            {
                Console.WriteLine("please create a Customer\r\n" );
                int userChoice = Utility.YesOrNoValidation("would you like to proceed to create customer\r\n\r\n[1] Yes \r\n[2] No ");
                if (userChoice==1 )
                {
                    CreateAccount();
                }
                else if (userChoice==2)
                {
                    Display(); 
                }
            }
            else
            {
                decimal userBalanceInfo = Utility.DecimalValidate("please enter the amount for the account");
                int userAccountInfo = Utility.IntValidate("please enter the account number");
                CheckingAccount newAccount = new CheckingAccount(userBalanceInfo,userAccountInfo);
                _currentCustomer._userAccount = newAccount;               
            }
            Console.WriteLine("\r\n\r\n please press any button to return to the main menu");
            Console.ReadKey();
            Display();
        }
        private void SetAccountBalance()
        {
            if (_currentCustomer ==  null && _currentCustomer._userAccount== null )
            {
                Console.WriteLine("please make a Comstomer and create Account");
                Display();
            }
            else
            {
                int userChoice = Utility.IntValidate("would you like to make a deposit or withdrawal  from your account\r\n\r\n[1]deposit\r\n[2]withdrawal");
                if (userChoice == 1)
                {
                    decimal deposit = Utility.DecimalValidate("how much would you like to deposit");
                     _currentCustomer._userAccount._accountBalance +=  deposit;

                }
                else if (userChoice==2)
                {
                    decimal withdrawal = Utility.DecimalValidate("how much would you like to withdrawal");
                     _currentCustomer._userAccount._accountBalance -= withdrawal;
                }
                else
                {
                    Console.WriteLine("you have choosen a incorrect number the page will reset.");
                    SetAccountBalance();
                }
            }
            Console.WriteLine("\r\n\r\nplease press any button to return to the main menu");
            Console.ReadKey();
            Display();
        }
        private void AccountDisplay()
        {
            string name = _currentCustomer.GetName();
            decimal balance = _currentCustomer._userAccount._accountBalance;
            Console.WriteLine($"Customer Name: {name}");
            Console.WriteLine($"\r\nAccount Balance: {balance.ToString()}");
            Console.WriteLine("\r\n\r\nplease press any button to return to the main menu");
            Console.ReadKey();
            Display();
        }
        private void Exit()
        {
            Environment.Exit(0);
            Console.ReadKey();
        }
    }
}
