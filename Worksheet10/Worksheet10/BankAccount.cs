using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet10
{
    public class BankAccount // Singular, first letter in upper case
    {
        // Attributes or characteristics (do not initialise on declaration!)
        public int number;
        public string holderName;
        public string pin;
        public double balance;

        // Constructor\s: responsible for the initialisation of the object attributes
        public BankAccount()
        {
            // This is an example of a parameterless constructor
            // Constructors have the exact same name as the class
            // Constructor do not have a return type
            // Invoked as "new BankAccount();"
            number = 0;
            holderName = string.Empty;
            pin = string.Empty;
            balance = 0;
        }

        public BankAccount(int pNumber, string pHolderName, string pPin, double initialBalance)
        {
            // This is an example of a parameterised constructor
            // We can have as many constructors as we want as long as they have different parameters
            // Invoked as "new BankAccount(1, "Sam", 1234, 500);"
            number = pNumber;
            holderName = pHolderName;
            pin = pPin;
            balance = initialBalance;
        }

        // Behaviours or Operations (Methods)
        // Retrieve or manipulate attributes
        public string GetData()
        {
            return $"No: {number}; Holder: {holderName}; Balance: {balance}";
        }

        public void Deposit(double amount)
        {
            balance += amount;
        }

        public bool Withdraw(double amount)
        {
            bool result = false; // assume unsuccessful
            if (balance >= amount)
            {
                // we can do the transaction!
                balance -= amount; // balance = balance - amount;
                result = true; // transaction successful
            }
            return result;
        }

        public bool ValidatePin(string pPin)
        // public bool ValidatePin(string pin)
        {
            return (pin == pPin);
            // return (this.pin == pin);
        }
    }
}
