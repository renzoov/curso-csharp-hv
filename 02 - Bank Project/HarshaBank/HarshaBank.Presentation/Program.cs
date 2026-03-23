using System;

class Program
{
    static void Main()
    {
        System.Console.WriteLine("********** Harsha Bank **********");
        System.Console.WriteLine(("::Login Page::"));
        
        string userName = null, password = null;
        
        System.Console.Write("Username:");
        userName = System.Console.ReadLine();

        if (userName != "")
        {
            System.Console.Write("Password:");
            password = System.Console.ReadLine();   
        }

        if (userName == "system" && password == "manager")
        {
            int mainMenuChoice = -1;

            do
            {

                System.Console.WriteLine("\n::Main menu::");
                System.Console.WriteLine("1. Customers");
                System.Console.WriteLine("2. Accounts");
                System.Console.WriteLine("3. Funds Transfer");
                System.Console.WriteLine("4. Funds Transfer Statement");
                System.Console.WriteLine("5. Account Statement");
                System.Console.WriteLine("0. Exit");

                System.Console.Write("Enter choice:");
                mainMenuChoice = int.Parse(System.Console.ReadLine());

                switch (mainMenuChoice)
                {
                    case 1:
                        CustomersMenu();
                        break;
                    case 2:
                        AccountsMenu();
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                }
            } while (mainMenuChoice != 0);
        }
        else
        {
            System.Console.WriteLine("Invalid username or password. Please try again.");
        }
        
        System.Console.WriteLine("Thank you! Visit again.");
        System.Console.ReadKey();
    }

    static void CustomersMenu()
    {
        int customerMenuChoice = -1;

        do
        {
            System.Console.WriteLine("\n::Customers Menu::");
            System.Console.WriteLine("1. Add Customer");
            System.Console.WriteLine("2. Delete Customer");
            System.Console.WriteLine("3. Update Customer");
            System.Console.WriteLine("4. View Customers");
            System.Console.WriteLine("0. Back to Main Menu");

            System.Console.Write("Enter choice:");
            customerMenuChoice = Convert.ToInt32(System.Console.ReadLine());
        } while (customerMenuChoice != 0);
    }
    
    static void AccountsMenu()
    {
        int accountsMenuChoice = -1;

        do
        {
            System.Console.WriteLine("\n::Accounts Menu::");
            System.Console.WriteLine("1. Add Account");
            System.Console.WriteLine("2. Delete Account");
            System.Console.WriteLine("3. Update Account");
            System.Console.WriteLine("4. View Accounts");
            System.Console.WriteLine("0. Back to Main Menu");

            System.Console.Write("Enter choice:");
            accountsMenuChoice = Convert.ToInt32(System.Console.ReadLine());
        } while (accountsMenuChoice != 0);
    }
}