
namespace OOPDemo1
{
    public class BankAccount // Singular, first letter in upper case
    {
        // Attributes or characteristics (do not initialise on declaration!)
        private int number;
        private string holderName;
        private string pin;
        private double balance;
        private string audit;

        public string Audit
        {
            get
            {                
                return audit;
            }
        }

        public double Balance
        {
            get
            {
                AddAuditEntry("Balance requested");
                return balance;
            }
            // if there is no set, property is read-only
        }

        public int Number
        {
            get
            {
                AddAuditEntry("Number requested");
                return number;
            }
            // if there is no set, property is read-only
        }


        public string HolderName
        {
            get
            {
                AddAuditEntry("Holder Name requested");
                return holderName;
            }
            set
            {
                AddAuditEntry("Holder Name changed");
                holderName = value;
            }
        }

        // Constructor\s: responsible for the initialisation of the object attributes
        public BankAccount()
        {
            AddAuditEntry("Account created");
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

            AddAuditEntry("Account created");
        }

        // Behaviours or Operations (Methods)
        // Retrieve or manipulate attributes
        public string GetData()
        {
            AddAuditEntry("Data Requested");
            return $"No: {number}; Holder: {holderName}; Balance: {balance}";
        }

        public void Deposit(double amount)
        {
            AddAuditEntry("Deposit of "+amount+" made");
            balance += amount;
        }

        public bool Withdraw(double amount)
        {
            AddAuditEntry("Withdraw attempted");
            bool result = false; // assume unsuccessful
            if (balance >= amount)
            {
                // we can do the transaction!
                balance -= amount; // balance = balance - amount;
                result = true; // transaction successful
                AddAuditEntry("Withdraw successful");
            }
            else
            {
                AddAuditEntry("Withdraw failed!");
            }
            return result;
        }

        private void AddAuditEntry(string description)
        {
            audit += DateTime.Now+"\t"+description+"\n";
        }
    }
}