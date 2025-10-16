using Worksheet10;

BankAccount myBankAccount = null;

int choice;
do
{
    choice = ShowMenu();
    switch (choice)
    {
        case 1: // Open Account
            HandleOpenAccount();
            break;
        case 2: // Deposit
            HandleDeposit();
            break;
        case 3: // Withdraw
            HandleWithdraw();
            break;
        case 4: // Check Balance
            HandleCheckBalance();
            break;
    }
    Console.WriteLine("Press any key.");
    Console.ReadKey();
} while (choice != 5); // 5 means Quit!


void HandleDeposit()
{
    Console.WriteLine("\nDeposit");
    Console.WriteLine("-------\n");

    if (Validate())
    {
        Console.Write("Deposit Amount: ");
        double amount = Convert.ToDouble(Console.ReadLine());
        myBankAccount.Deposit(amount);
        PrintSuccessMsg("Deposit successful!");
    }
    else
        PrintErrorMsg("Deposit unsuccessful!");
}

void HandleWithdraw()
{
    Console.WriteLine("\nWithdraw");
    Console.WriteLine("--------\n");

    if (Validate()) // checking that 1) account exists, and 2) pin is valid
    {
        Console.Write("Withdraw Amount: ");
        double amount = Convert.ToDouble(Console.ReadLine());
        bool sufficientFunds = myBankAccount.Withdraw(amount);
        if (sufficientFunds) // (sufficientFunds == true)
            PrintSuccessMsg("Withdraw successful!");
        else
            PrintErrorMsg("Withdraw unsuccessful because of insufficient funds");
    }
    else
        PrintErrorMsg("Withdraw unsuccessful!");
}

void HandleCheckBalance()
{
    Console.WriteLine("\nCheck Balance");
    Console.WriteLine("-------------\n");

    if (Validate())
    {
        Console.WriteLine($"Current Balance is {myBankAccount.balance}");
        PrintSuccessMsg("Deposit successful!");
    }
    else
        PrintErrorMsg("Check Balance unsuccessful!");
}

void HandleOpenAccount()
{
    Console.WriteLine("\nOpen Account");
    Console.WriteLine("------------\n");

    Console.Write("Account No: ");
    int accountNo = Convert.ToInt32(Console.ReadLine());
    Console.Write("Holder: ");
    string holder = Console.ReadLine();
    Console.Write("Pin: ");
    string pin = Console.ReadLine();
    Console.Write("Initial Balance: ");
    double initialBalance = Convert.ToDouble(Console.ReadLine());
    myBankAccount =
        new BankAccount(accountNo, holder, pin, initialBalance);
    PrintSuccessMsg("Account creation successful!");
}

int ShowMenu()
{
    int choice = 0;
    Console.Clear();
    if (myBankAccount == null)
        Console.WriteLine("Bank Account does not exist");
    else
        Console.WriteLine($"Bank Account: {myBankAccount.GetData()}");

    Console.WriteLine("\nMenu");
    Console.WriteLine("----");
    Console.WriteLine("1. Open Account");
    Console.WriteLine("2. Deposit");
    Console.WriteLine("3. Withdraw");
    Console.WriteLine("4. Check Balance");
    Console.WriteLine("5. Quit");
    Console.Write("Choice: ");
    choice = Convert.ToInt32(Console.ReadLine());
    return choice;
}

bool Validate()
{
    // Ensure that the account exists and that the pin is valid
    bool result = true;
    if (myBankAccount == null)
    {
        PrintErrorMsg("Account does not exist yet");
        result = false;
    }
    else // account exists...
    {
        Console.Write("Pin: ");
        string userPin = Console.ReadLine();
        result = myBankAccount.ValidatePin(userPin);
        if (!result) // if (result == false)
            PrintErrorMsg("Pin invalid. Operation aborted!");
    }
    return result;
}

void PrintSuccessMsg(string message)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Success: {message}");
    Console.ResetColor();
}

void PrintErrorMsg(string message)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Error: {message}");
    Console.ResetColor();
}
