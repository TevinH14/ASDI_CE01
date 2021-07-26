# ASDI_CE01
 Code Exercise 1: OOP & Class Basics


Classes
Create a CheckingAccount class
CheckingAccount must have the following fields
a decimal field for the account balance.
a int field for the account number.
Create a Customer class
Customer must have the following fields
a CheckingAccount field for the customer’s account
a string field for the customer’s name 
Constructors
CheckingAccount needs a constructor that takes an int parameter and a decimal parameter
These parameters should be assigned to the appropriate fields
Customer needs a constructor that takes a string parameter
This parameter should be assigned to the appropriate field.  
Main
In main before anything else you will need a Customer variable to use for the currentCustomer.
Program runs until the user chooses to exit.
Menu
The menu must have the following options:
Create customer - this option needs to prompt the user for a customer name, use that input to instantiate a new Customer object, and  assign that object to the currentCustomer variable.
Create account - this option should only run if a currentCustomer isn’t null, it needs to prompt the user for values to create a CheckingAccount with, use those values to instantiate a new CheckingAccount object and assign it to the currentCustomer.
Set account balance - this option should only run if currentCustomer isn’t null and currentCustomer’s account isn’t null, it needs to prompt the user for a new account balance and then apply it to currentCustomer’s account.
Display account balance - this option needs to display the current customer’s account balance and the name associated with the account
Exit - stop the program.
