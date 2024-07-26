// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Numerics;

class Person
{
    private double balance = 4000.00; //initial balance for the person
    private string pin = "5678";//users pin


    public double Balance
    {
        get { return balance; }
        private set { balance = value; }
    }

    public void Transfer(double amount)
    {
        double taxRate = 0.01;
        double taxamount = taxRate * amount;

        if (balance >= (amount + taxamount))
        {
            balance -= amount;
            if (amount >= 100)
            {
                balance -= taxamount;
            }
            else
            {
                taxamount = 0.00;
            }
            //Arrays of names
            string[] names = { "Eric Mills", "Randy Tawiah", "Felicia Ayebah-Kofie", "Richard Bamfo", "Emmanuel Amponsah", "Appiagyei Ababio" };
            //Randomly select a name
            Random random = new Random();
            int index = random.Next(names.Length);
            string randomName = names[index];
            //Arrays of Transaction ID
            string[] IDs = { "35895943430","35895943431","35895943432", "35895943433", "35895943434", "35895943435" };
            //Randomly select ID
            Random random1 = new Random();
            int index1 = random1.Next(IDs.Length);
            string randomID = IDs[index1];
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Payment made for GHS{amount} to " + randomName );
            Console.WriteLine($"Current balance: GHS{balance} ");
            Console.WriteLine($"Tax charged: GHS{taxamount}  Fee charged: GHS O.OO");
            Console.WriteLine("Transaction ID: "+ randomID);
            
            
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Insufficient balance ");
            Console.ResetColor ();
        }
     
    }

    public bool VerifyPin(string enteredpin)
    {
        return pin == enteredpin;
    }

    public void Withdrawal(double amount)
    {
        double feerate = 0.01;
        double feeamount = amount * feerate;
        
        if (balance >= (amount + feeamount))
        { 
            balance -= amount;
            
            if (amount <= 50)
            {
                feeamount = 0.50;
                balance -= 0.50;
            }
            else
            {
                 balance -= feeamount;
            }
            //Arrays of Tech coin agent ventures
            string[] ventures = { "ADONI D.C LTD", "", "GOOD IS GOD VENTURES", "JACK AND SONS LTD", "Mornnining Star Enterprise ", "Grace Tech Coin Venture" };
            //Randomly select a name
            Random random = new Random();
            int index = random.Next(ventures.Length);
            string randomventures = ventures[index];
            //Arrays of Transaction ID
            string[] IDs = { "25895943430", "25895943431", "25895943432", "25895943433", "25895943434", "25895943435" };
            //Randomly select ID
            Random random1 = new Random();
            int index1 = random1.Next(IDs.Length);
            string randomID = IDs[index1];
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Withdrawal made for GHS{amount} to "+randomventures);
            Console.WriteLine($"New balance: GHS{balance}");
            Console.WriteLine("Financial Transaction ID: " +randomID);
            Console.WriteLine($"Fee charged:GHS {feeamount}.00");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Please do not pay any fees to the Agent,Fees automatically are deducted from your balance.");
            Console.WriteLine("                          Thank you for using Techcom TechCoin");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Insufficient balance ");
            Console.ResetColor();
        }
    }
    public void Deposit(double amount)
    {
        balance += amount;
        Console.ForegroundColor= ConsoleColor.Green;
        Console.WriteLine($"Amount of GHS{amount} successfully Deposited");
        Console.WriteLine($"New balance: {balance}");
        Console.ResetColor();
    }
    public void Checkbalance()
    {
        Console.ForegroundColor= ConsoleColor.Green;
        Console.WriteLine($"Current Balance: GHS{balance}.00");
        Console.WriteLine($"Available Balance: GHS{balance}.00");
        Console.ResetColor();
    }
    public void Wallettobank(double amount)
    {
            if (balance >= amount)
            {
                balance -= amount;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Amount of GHS{amount}.00 successfully Deposited to BanK account.");
                Console.WriteLine($"New balance: GHS{balance}.00");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Insufficient balance ");
                Console.ResetColor();
            }
    }
    public void MiniStatement()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("                          Mini-Statement");
        Console.ResetColor();
        Console.WriteLine("                 2024-03-01 RECIEVED GHS4000.00");
        Console.WriteLine("              2024-03-01 EXTERNAL_PAYMENT GHS300.00");
        Console.WriteLine("                 2024-03-02 TRANSFER  GHS1000.00 ");
        Console.WriteLine("               2024-3-6 EXTERNAL PAYMENT GHS700.OO ");
        Console.WriteLine("                  2024-3-9 TRANSFER GHS1000.OO");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("                  THANK YOU FOR USING TECH COIN");
        Console.ResetColor();

       
    }
    public void BillPayment()
    {
        String Carrier_input2 = "";
        do
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("           Carrier info");
            Console.ResetColor();
            Console.WriteLine("Do you want to approve the transaction");
            Console.WriteLine("1.Yes" + "\n" + "2.No");
            Console.WriteLine();
            Carrier_input2 = Console.ReadLine();       
            Console.Clear();
            if (Carrier_input2 == "1")
            {
                if (balance >= 160)
                {
                    balance -= 160;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Payment of GHS160.00 has been made successfully.");
                    Console.WriteLine($"New balance: GHS{balance}.00");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Insufficient balance ");
                    Console.ResetColor();
                }
            }
            else if (Carrier_input2 == "2")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid Input, Please try again");
                Console.ResetColor();
            }
        } while (Carrier_input2 != "1" && Carrier_input2 != "2");
        
    }



}

class Program
{
    static Program()
    {
        string short_Code = "*170#";
        string CodeInput = Console.ReadLine();
        if (CodeInput == short_Code)
        {
            Main();
            Environment.Exit(0);
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("UNKNOWN APPLICATION");
            Console.ResetColor();
            Environment.Exit(0);
        }
    }
    static Stack<string> history = new Stack<string>();
    static void Transfer(Person person)
    {
        string transferInput = "";
        do
        {

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Transfer Money");
            Console.ResetColor();
            string transferOption1 = "1.Tech Coin User";
            string transferOption2 = "2.Non Tech Coin User";
            string transferOption3 = "3.Other Networks";
            string transferOption4 = "4.Bank Account";
            string transferOption5 = "0.back";
            Console.WriteLine(transferOption1 + "\n" + transferOption2 + "\n" + transferOption3 + "\n" + transferOption4 + "\n" + transferOption5);
            Console.WriteLine();
            transferInput = Console.ReadLine();

            Console.Clear();

            switch (transferInput)
            {

                case "1":

                    int maxAttempt = 3;
                    int attempts = 0;
                    string requiredPrefixA = "058";
                    string requiredPrefixB = "051";
                    string requiredPrefixC = "052";
                    string userNumber = "";
                    //Get number from the user and confirm validation

                    do
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Enter Number: ");
                        Console.ResetColor();
                        Console.WriteLine();
                        userNumber = Console.ReadLine();
                        Console.Clear();
                        if (userNumber.Length == 10 && (userNumber.StartsWith(requiredPrefixA) || userNumber.StartsWith(requiredPrefixB) || userNumber.StartsWith(requiredPrefixC)) && userNumber.All(char.IsDigit))
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Confirm Number");
                            Console.ResetColor();
                            Console.WriteLine();
                            String ConfirmNumber = Console.ReadLine();
                            Console.Clear();
                            if (ConfirmNumber == userNumber)
                            {

                                //Get the amount from the userwith input validation

                                double amount;
                                bool isValidAmount = false;
                                do
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.WriteLine("Enter amount:");
                                    Console.ResetColor();
                                    Console.WriteLine();
                                    string amountInput = Console.ReadLine();
                                    Console.Clear();
                                    isValidAmount = double.TryParse(amountInput, out amount);
                                    attempts++;
                                    if (!isValidAmount || amount < 1)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Invalid input.");
                                        Console.ResetColor();
                                        Console.WriteLine("Please Enter a valid amount");                                     
                                    }
                                  
                                    
                                }
                                while ((!isValidAmount || amount < 1) && attempts < maxAttempt);

                                //Get reference number
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("Enter Reference:");
                                Console.ResetColor();
                                Console.WriteLine();
                                String referenceNumber = Console.ReadLine();
                                Console.Clear();



                                //Ask user to confirm Pin

                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("Enter PIN: ");
                                Console.ResetColor();
                                Console.WriteLine();
                                string enteredpin = Console.ReadLine();
                                Console.Clear();
                                if (person.VerifyPin(enteredpin))
                                {
                                    person.Transfer(amount);
                                    break;

                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("incorrect pin");
                                    Console.ResetColor();

                                    break;

                                }

                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Number Mismatch");
                                Console.ResetColor();

                                break;
                            }

                        }
                        else
                        {
                            attempts++;
                            if (attempts < maxAttempt)
                            {
                                Console.WriteLine("Invalid Number please try again");

                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Maximum input reached");
                                Console.ResetColor();

                            }
                        }
                    }
                    while (attempts < maxAttempt);

                    break;
                case "2":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Enter Receivers Name");
                    Console.ResetColor();
                    Console.WriteLine();
                    string Recievername = Console.ReadLine();
                    Console.Clear();

                    //Get the amount from the userwith input validation

                    double amounttoken;
                    bool isValidAmounttoken = false;
                    do
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Enter amount:");
                        Console.ResetColor();
                        Console.WriteLine();
                        string amountInputtoken = Console.ReadLine();
                        Console.Clear();
                        isValidAmounttoken = double.TryParse(amountInputtoken, out amounttoken);
                        if (!isValidAmounttoken || amounttoken < 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid input.");
                            Console.ResetColor();
                            Console.WriteLine("Please Enter a valid amount");

                        }
                    }
                    while (!isValidAmounttoken || amounttoken < 1);
                    //Get refrence number
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Enter Reference:");
                    Console.ResetColor();
                    Console.WriteLine();
                    String referenceNumber90 = Console.ReadLine();
                    Console.Clear();

                    //GET and confirm secret code
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Enter Secret Code");
                    Console.ResetColor();
                    Console.WriteLine();
                    string scode = Console.ReadLine();
                    Console.Clear();




                    if (scode.Length == 4 && scode.All(char.IsDigit))
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Confirm Secret Code");
                        Console.ResetColor();
                        Console.WriteLine();
                        string confirmscode = Console.ReadLine();
                        Console.Clear();
                        if (scode == confirmscode)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Enter PIN: ");
                            Console.ResetColor();
                            Console.WriteLine();
                            string enteredpintoken = Console.ReadLine();
                            Console.Clear();
                            if (person.VerifyPin(enteredpintoken))
                            {
                                person.Transfer(amounttoken);
                                Environment.Exit(0);
                                break;

                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("incorrect pin");
                                Console.ResetColor();
                                Environment.Exit(0);
                                break;
                                
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid secret code, code must be 4 digits");
                        Environment.Exit(0);
                    }
                    break;
                case "3":
                    string transferOthernetworkInput = "";
                    do
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Transfer Money to other Networks");
                        Console.ResetColor();
                        string transferOthernetwork1 = "1.AirtelTigo";
                        string transferOthernetwork2 = "2.Telecel";
                        string transferOthernetwork3 = "3.MTN";
                        string transferOthernetwork4 = "4.E-zwich";
                        string transferOthernetwork5 = "0.Back";
                        Console.WriteLine(transferOthernetwork1 + "\n" + transferOthernetwork2 + "\n" + transferOthernetwork3 + "\n" + transferOthernetwork4 + "\n" + transferOthernetwork5);
                        Console.WriteLine();
                        transferOthernetworkInput = Console.ReadLine();
                        Console.Clear();

                        if (transferOthernetworkInput == "1")
                        {
                            int maxAttempt1a = 3;
                            int attempts1a = 0;
                            string airtelnetworkcode1 = "027";
                            string airtelnetworkcode2 = "057";
                            string airtelnetworkcode3 = "026";
                            string airtelnetworkcode4 = "056";

                            string userNumber1a = "";
                            // Get number from the user and confirm validation
                            do
                            {
                                Console.ForegroundColor = (ConsoleColor)ConsoleColor.Blue;
                                Console.WriteLine("Enter Number: ");
                                Console.ResetColor();
                                Console.WriteLine();
                                userNumber1a = Console.ReadLine();
                                Console.Clear();
                                if (userNumber1a.Length == 10 && (userNumber1a.StartsWith(airtelnetworkcode1) || userNumber1a.StartsWith(airtelnetworkcode2) || userNumber1a.StartsWith(airtelnetworkcode3) || userNumber1a.StartsWith(airtelnetworkcode4)) && userNumber1a.All(char.IsDigit))
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.WriteLine("Confirm Number");
                                    Console.ResetColor();
                                    Console.WriteLine();
                                    String ConfirmNumber1a = Console.ReadLine();
                                    Console.Clear();
                                    if (ConfirmNumber1a == userNumber1a)
                                    {
                                        //Get the amount from the userwith input validation
                                        double amount1a;
                                        bool isValidAmount1a = false;
                                        do
                                        {
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.WriteLine("Enter amount:");
                                            Console.ResetColor();
                                            Console.WriteLine();
                                            string amountInput1a = Console.ReadLine();
                                            Console.Clear();
                                            Console.WriteLine();
                                            isValidAmount1a = double.TryParse(amountInput1a, out amount1a);
                                            if (!isValidAmount1a || amount1a < 1)
                                            {
                                                Console.WriteLine("Invalid input. Please Enter a valid amount");
                                            }
                                        }
                                        while (!isValidAmount1a || amount1a < 1);

                                        //Get refrence number
                                        Console.WriteLine("Enter Reference:");
                                        String Referenceno1a = Console.ReadLine();
                                        Console.WriteLine();
                                        Console.Clear();

                                        //Ask user to confirm Pin
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        Console.WriteLine("Enter PIN: ");
                                        Console.ResetColor();
                                        Console.WriteLine();
                                        string enteredpin1a = Console.ReadLine();
                                        Console.Clear();
                                        if (person.VerifyPin(enteredpin1a))
                                        {
                                            person.Transfer(amount1a);
                                            break;
                                        }
                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("incorrect pin");
                                            Console.ResetColor();
                                            Console.WriteLine();
                                            break;
                                        }



                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Number Mismatch");
                                        Console.ResetColor();
                                        break;
                                    }

                                }
                                else
                                {
                                    attempts1a++;
                                    if (attempts1a < maxAttempt1a)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        Console.WriteLine("Invalid Number please try again");
                                        Console.ResetColor();
                                        Console.WriteLine();
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Maximum input reached");
                                        Console.ResetColor();
                                        Console.WriteLine();
                                    }
                                }
                            }
                            while (attempts1a < maxAttempt1a);
                        }
                        else if (transferOthernetworkInput == "2")
                        {
                            int maxAttempt1t = 3;
                            int attempts1t = 0;
                            string telecelnetworkcode1 = "050";
                            string telecelnetworkcode2 = "020";

                            string userNumber1t = "";
                            // Get number from the user and confirm validation
                            do
                            {
                                Console.ForegroundColor = (ConsoleColor)ConsoleColor.Blue;
                                Console.WriteLine("Enter Number: ");
                                Console.ResetColor();
                                Console.WriteLine();
                                userNumber1t = Console.ReadLine();
                                Console.Clear();
                                if (userNumber1t.Length == 10 && (userNumber1t.StartsWith(telecelnetworkcode1) || userNumber1t.StartsWith(telecelnetworkcode2)) && userNumber1t.All(char.IsDigit))
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.WriteLine("Confirm Number");
                                    Console.ResetColor();
                                    Console.WriteLine();
                                    String ConfirmNumber1t = Console.ReadLine();
                                    Console.Clear();
                                    if (ConfirmNumber1t == userNumber1t)
                                    {
                                        //Get the amount from the userwith input validation
                                        double amount1t;
                                        bool isValidAmount1t = false;
                                        do
                                        {
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.WriteLine("Enter amount:");
                                            Console.ResetColor();
                                            Console.WriteLine();
                                            string amountInput1t = Console.ReadLine();
                                            Console.Clear();
                                            Console.WriteLine();
                                            isValidAmount1t = double.TryParse(amountInput1t, out amount1t);
                                            if (!isValidAmount1t || amount1t < 1)
                                            {
                                                Console.WriteLine("Invalid input. Please Enter a valid amount");
                                            }
                                        }
                                        while (!isValidAmount1t || amount1t < 1);

                                        //Get refrence number
                                        Console.WriteLine("Enter Reference:");
                                        String Referenceno1t = Console.ReadLine();
                                        Console.WriteLine();
                                        Console.Clear();

                                        //Ask user to confirm Pin
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        Console.WriteLine("Enter PIN: ");
                                        Console.ResetColor();
                                        Console.WriteLine();
                                        string enteredpin1t = Console.ReadLine();
                                        Console.Clear();
                                        if (person.VerifyPin(enteredpin1t))
                                        {
                                            person.Transfer(amount1t);
                                            break;
                                        }
                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("incorrect pin");
                                            Console.ResetColor();
                                            Console.WriteLine();
                                            break;
                                        }



                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Number Mismatch");
                                        Console.ResetColor();
                                        break;
                                    }

                                }
                                else
                                {
                                    attempts1t++;
                                    if (attempts1t < maxAttempt1t)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        Console.WriteLine("Invalid Number please try again");
                                        Console.ResetColor();
                                        Console.WriteLine();
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Maximum input reached");
                                        Console.ResetColor();
                                        Console.WriteLine();
                                    }
                                }
                            }
                            while (attempts1t < maxAttempt1t);
                        }
                        else if (transferOthernetworkInput == "3")
                        {
                            int maxAttempt1m = 3;
                            int attempts1m = 0;
                            string MTNnetworkcode1 = "O24";
                            string MTNnetworkcode2 = "025";
                            string MTNnetworkcode3 = "053";
                            string MTNnetworkcode4 = "059";
                            string MTNnetworkcode5 = "054";
                            string MTNnetworkcode6 = "055";



                            string userNumber1m = "";
                            // Get number from the user and confirm validation
                            do
                            {
                                Console.ForegroundColor = (ConsoleColor)ConsoleColor.Blue;
                                Console.WriteLine("Enter Number: ");
                                Console.ResetColor();
                                Console.WriteLine();
                                userNumber1m = Console.ReadLine();
                                Console.Clear();
                                if (userNumber1m.Length == 10 && (userNumber1m.StartsWith(MTNnetworkcode1) || userNumber1m.StartsWith(MTNnetworkcode2) || userNumber1m.StartsWith(MTNnetworkcode3) || userNumber1m.StartsWith(MTNnetworkcode4) || userNumber1m.StartsWith(MTNnetworkcode5) || userNumber1m.StartsWith(MTNnetworkcode6)) && userNumber1m.All(char.IsDigit))
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.WriteLine("Confirm Number");
                                    Console.ResetColor();
                                    Console.WriteLine();
                                    String ConfirmNumber1m = Console.ReadLine();
                                    Console.Clear();
                                    if (ConfirmNumber1m == userNumber1m)
                                    {
                                        //Get the amount from the userwith input validation
                                        double amount1m;
                                        bool isValidAmount1m = false;
                                        do
                                        {
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.WriteLine("Enter amount:");
                                            Console.ResetColor();
                                            Console.WriteLine();
                                            string amountInput1m = Console.ReadLine();
                                            Console.Clear();
                                            Console.WriteLine();
                                            isValidAmount1m = double.TryParse(amountInput1m, out amount1m);
                                            if (!isValidAmount1m || amount1m < 1)
                                            {
                                                Console.WriteLine("Invalid input. Please Enter a valid amount");
                                            }
                                        }
                                        while (!isValidAmount1m || amount1m < 1);

                                        //Get refrence number
                                        Console.WriteLine("Enter Reference:");
                                        String Referenceno1m = Console.ReadLine();
                                        Console.Clear();
                                        Console.WriteLine();

                                        //Ask user to confirm Pin
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        Console.WriteLine("Enter PIN: ");
                                        Console.ResetColor();
                                        Console.WriteLine();
                                        string enteredpin1m = Console.ReadLine();
                                        Console.Clear();
                                        if (person.VerifyPin(enteredpin1m))
                                        {
                                            person.Transfer(amount1m);
                                            break;
                                        }
                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("incorrect pin");
                                            Console.ResetColor();
                                            Console.WriteLine();
                                            break;
                                        }



                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Number Mismatch");
                                        Console.ResetColor();
                                        break;
                                    }

                                }
                                else
                                {
                                    attempts1m++;
                                    if (attempts1m < maxAttempt1m)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        Console.WriteLine("Invalid Number please try again");
                                        Console.ResetColor();
                                        Console.WriteLine();
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Maximum input reached");
                                        Console.ResetColor();
                                        Console.WriteLine();
                                    }
                                }
                            }
                            while (attempts1m < maxAttempt1m);
                        }
                        else if (transferOthernetworkInput == "4")
                        {
                            int maxAttempt1e = 3;
                            int attempts1e = 0;
                            string Pattern = @"^\d{8}-\d$";

                            string userNumber1e = "";
                            // Get number from the user and confirm validation
                            do
                            {
                                Console.ForegroundColor = (ConsoleColor)ConsoleColor.Blue;
                                Console.WriteLine("Enter E-Zwich card Number: ");
                                Console.ResetColor();
                                Console.WriteLine();
                                userNumber1e = Console.ReadLine();
                                Console.Clear();
                                if (Regex.IsMatch(userNumber1e, Pattern))
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.WriteLine("Confirm E-zwich CardNumber");
                                    Console.ResetColor();
                                    Console.WriteLine();
                                    String ConfirmNumber1e = Console.ReadLine();
                                    Console.Clear();
                                    if (ConfirmNumber1e == userNumber1e)
                                    {
                                        //Get the amount from the userwith input validation
                                        double amount1e;
                                        bool isValidAmount1e = false;
                                        do
                                        {
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.WriteLine("Enter amount:");
                                            Console.ResetColor();
                                            Console.WriteLine();
                                            string amountInput1e = Console.ReadLine();
                                            Console.Clear();
                                            isValidAmount1e = double.TryParse(amountInput1e, out amount1e);
                                            if (!isValidAmount1e  || amount1e < 1)
                                            {
                                                Console.WriteLine("Invalid input. Please Enter a valid amount");
                                            }
                                        }
                                        while (!isValidAmount1e || amount1e < 1);

                                        //Get refrence number
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        Console.WriteLine("Enter Reference:");
                                        Console.WriteLine();
                                        Console.ResetColor();
                                        String Referenceno1e = Console.ReadLine();
                                        Console.Clear();

                                        //Ask user to confirm Pin
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        Console.WriteLine("Enter PIN: ");
                                        Console.ResetColor();
                                        Console.WriteLine();
                                        string enteredpin1t = Console.ReadLine();
                                        Console.Clear();
                                        if (person.VerifyPin(enteredpin1t))
                                        {
                                            person.Transfer(amount1e);
                                            break;
                                        }
                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("incorrect pin");
                                            Console.ResetColor();
                                            Console.WriteLine();
                                            break;
                                        }



                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Number Mismatch");
                                        Console.ResetColor();
                                        break;
                                    }

                                }
                                else
                                {
                                    attempts1e++;
                                    if (attempts1e < maxAttempt1e)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        Console.WriteLine("Invalid Number please try again");
                                        Console.ResetColor();
                                        Console.WriteLine();
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Maximum input reached");
                                        Console.ResetColor();
                                        Console.WriteLine();
                                    }
                                }
                            }
                            while (attempts1e < maxAttempt1e);
                        }
                        else if(transferOthernetworkInput == "0")
                        {
                            Program.Transfer(person);
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input Try again");
                        }
                    }
                    while (transferOthernetworkInput != "1" && transferOthernetworkInput != "2" && transferOthernetworkInput != "3" && transferOthernetworkInput != "4");
                    break;
                case "4":
                    string Bankinput = "";
                    do
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Bank Transfer service");
                        Console.ResetColor();
                        Console.WriteLine("1.Wallet to Bank Account " + "\n" + "0.Back");
                        Console.WriteLine();
                        Bankinput = Console.ReadLine();
                        Console.Clear();
                        if (Bankinput == "1")
                        {
                            Console.WriteLine("Enter Account Number:");
                            string accountinput = Console.ReadLine();
                            Console.Clear();
                            if (accountinput.Length == 14 && accountinput.All(char.IsDigit))
                            {
                                //Get the amount from the userwith input validation
                                double amount9;
                                bool isValidAmount9 = false;
                                do
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.WriteLine("Enter amount:");
                                    Console.ResetColor();
                                    Console.WriteLine();
                                    string amountInput9 = Console.ReadLine();
                                    Console.Clear();
                                    Console.WriteLine();
                                    isValidAmount9 = double.TryParse(amountInput9, out amount9);
                                    if (!isValidAmount9 || amount9 < 1)
                                    {
                                        Console.WriteLine("Invalid input. Please Enter a valid amount");
                                    }
                                }
                                while (!isValidAmount9 || amount9 < 1);

                                //Ask user to confirm Pin
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("Enter PIN: ");
                                Console.ResetColor();
                                Console.WriteLine();
                                string enteredpin9 = Console.ReadLine();
                                Console.Clear();
                                if (person.VerifyPin(enteredpin9))
                                {
                                    person.Wallettobank(amount9);
                                    Environment.Exit(0);
                                    break;                                    

                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("incorrect pin");
                                    Console.ResetColor();
                                    Environment.Exit(0);
                                    break;
                                }
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Invalid Account Number");
                                Console.ResetColor();
                                Environment.Exit(0);
                            }

                        }
                        else if (Bankinput == "0")
                        {
                            Main();
                        }
                        else
                        {
                            Console.WriteLine("Invalid input try again");
                        }
                    } while (Bankinput != "1" && Bankinput != "0");
                    break;
                case "0":
                    // Go Back Logic
                    Main();

                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }
        while (transferInput != "1" && transferInput != "2" && transferInput != "3" && transferInput != "0");
    }
    static void Withdrawals(Person person)
    {
        Console.WriteLine("How much money do you want to withdraw");

        //Get the amount from the userwith input validation
        double amount1;
        bool isValidAmount1 = false;
        do
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Enter amount:");
            Console.ResetColor();
            Console.WriteLine();
            string amountInput1 = Console.ReadLine();
            Console.Clear();
            isValidAmount1 = double.TryParse(amountInput1, out amount1);
            if (!isValidAmount1 || amount1 < 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Please Enter a valid amount: ");
                Console.ResetColor();
                Console.WriteLine();
            }
        }
        while (!isValidAmount1 || amount1 < 1);


        //Ask user to confirm Pin
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Enter PIN: ");
        Console.ResetColor();
        Console.WriteLine();
        string enteredpin1 = Console.ReadLine();
        Console.Clear();
        if (person.VerifyPin(enteredpin1))
        {
            person.Withdrawal(amount1);

        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("incorrect pin");
            Console.ResetColor();

        }
    }
    static void Deposit(Person person)
    {
        Console.WriteLine("How much would you want to deposit");
        //Get the amount from the userwith input validation
        double amount2;
        bool isValidAmount2 = false;
        do
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Enter amount:");
            Console.ResetColor();
            Console.WriteLine();
            string amountInput2 = Console.ReadLine();
            Console.Clear();
            isValidAmount2 = double.TryParse(amountInput2, out amount2);
            if (!isValidAmount2 || amount2 < 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input");
                Console.ResetColor();
                Console.WriteLine("Please Enter a valid amount: ");
                
            }
        }
        while (!isValidAmount2 || amount2 < 1);

        //Ask user to confirm Pin
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Enter PIN: ");
        Console.ResetColor();
        Console.WriteLine();
        string enteredpin2 = Console.ReadLine();
        Console.Clear();
        if (person.VerifyPin(enteredpin2))
        {
            person.Deposit(amount2);
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("incorrect pin");
            Console.ResetColor();
        }
    }
    static void MyAccount(Person person)
    {
        string AccountInput = "0";
        do
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("My Account");
            Console.ResetColor();
            string AccountOption1 = "1.Check Balance";
            string AccountOption2 = "2.Mini Statements";
            string AccountOption3 = "3.Change  Pin";
            string AccountOption4 = "0.Back";
            Console.WriteLine(AccountOption1 + "\n" + AccountOption2 + "\n" + AccountOption3 + "\n" + AccountOption4);
            Console.WriteLine();
            AccountInput = Console.ReadLine();
            Console.Clear();

            if (AccountInput == "1")
            {
                //Ask user to confirm Pin
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Enter PIN: ");
                Console.ResetColor();
                Console.WriteLine();
                string enteredpin3 = Console.ReadLine();
                Console.Clear();
                if (person.VerifyPin(enteredpin3))
                {
                    person.Checkbalance();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("incorrect pin");
                    Console.ResetColor();
                }
            }
            else if (AccountInput == "2")
            {
                //Ask user to confirm Pin
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Enter PIN: ");
                Console.ResetColor();
                Console.WriteLine();
                string enteredpin0 = Console.ReadLine();
                Console.Clear();
                if (person.VerifyPin(enteredpin0))
                {
                    person.MiniStatement();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("incorrect pin");
                    Console.ResetColor();
                }

            }
            else if (AccountInput == "3")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Enter Old PIN: ");
                Console.ResetColor();
                Console.WriteLine();
                string enteredpin00 = Console.ReadLine();
                Console.Clear();
                if (person.VerifyPin(enteredpin00))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Enter New Pin");
                    Console.ResetColor();
                    string newpin = Console.ReadLine();
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Confirm New Pin");
                    Console.ResetColor();
                    string Cnewpin = Console.ReadLine();
                    Console.Clear();
                    if (newpin == Cnewpin)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Pin Successfully Changed");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Pin Mismatch");
                        Console.ResetColor();
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("incorrect pin");
                    Console.ResetColor();
                }

            }
            else if (AccountInput == "0")
            {
                Main();
            }
            else
            {
                Console.WriteLine("Invalid choice please select a valid choice");
            }
        } while (AccountInput != "1" && AccountInput != "2" && AccountInput != "3" && AccountInput != "0");
    }
    static void Techpay(Person person)
    {
        string Techpayinput = "";
        do
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("My Account");
            Console.ResetColor();
            string TechpayOption1 = "1.Tech pay";
            string TechpayOption2 = "2.Pay DStv/GOtv Bills";
            string TechpayOption3 = "0.Back";
            Console.WriteLine(TechpayOption1 + "\n" + TechpayOption2 + "\n" + TechpayOption3);
            Console.WriteLine();
            Techpayinput = Console.ReadLine();
            Console.Clear();
            if (Techpayinput == "1")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Enter Merchant ID:");
                Console.ResetColor();
                Console.WriteLine();              
                string merchantid = Console.ReadLine();
                Console.Clear();

                if (merchantid.Length == 6 && merchantid.All(char.IsDigit))
                {
                    //Get the amount from the userwith input validation
                    double amountid;                
                    bool isValidAmountid = false;
                    do
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Enter amount:");
                        Console.ResetColor();
                        Console.WriteLine();
                        String amountInputid = Console.ReadLine();
                        Console.WriteLine();
                        Console.Clear();
                        isValidAmountid = double.TryParse(amountInputid, out amountid);
                        if (!isValidAmountid || amountid < 1)
                        {
                            Console.WriteLine("Invalid input. Please Enter a valid amount");
                        }
                    }
                    while (!isValidAmountid || amountid < 1 );

                    //Ask user to confirm Pin
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Enter PIN: ");
                    Console.ResetColor();
                    Console.WriteLine();
                    string enteredpinid = Console.ReadLine();
                    Console.Clear();
                    if (person.VerifyPin(enteredpinid))
                    {
                        person.Transfer(amountid);
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("incorrect pin");
                        Console.ResetColor();
                        Console.WriteLine();
                        break;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("No customer found for this account number ");
                    Console.ResetColor();
                }

            }
            else if (Techpayinput == "2")
            {
                Console.ForegroundColor= ConsoleColor.Blue;
                Console.WriteLine("WELCOME TO MULTICHOICE GHANA");
                Console.ResetColor();
                Console.WriteLine("Enter Smart Card Number/IUC Number:");
                Console.WriteLine();
                string IUC = Console.ReadLine();
                Console.Clear();
                if (IUC.Length == 10 && IUC.All(char.IsDigit))
                {
                    string[] Customernames = { "Dennis Obeng", "Pasty Asamoah","Prince Williams"};
                    //Randomly select a Customer's name
                    Random random1 = new Random();
                    int index1 = random1.Next(Customernames.Length);
                    string randomName1 = Customernames[index1];
                    string[] Account_Type = { "GoTV", "DsTV" };

                    //Randomly select an Account type
                    Random random2 = new Random();
                    int index2 = random2.Next(Account_Type.Length);
                    string randomName2 = Account_Type[index1];
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("          Carrier Info");
                    Console.ResetColor();
                    Console.WriteLine("CUSTOMER NAME: Mr."+randomName1);
                    Console.WriteLine("ACCOUNT TYPE: " + randomName2);
                    Console.WriteLine("1.Proceed" + "\n" + "2.Cancel");
                    String Carrer_input = Console.ReadLine();
                    Console.Clear();
                    do
                    {
                        if (Carrer_input == "1")
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("            Carrier Info");
                            Console.ResetColor();
                            Console.WriteLine("Authorize payment of GHS 160.00 from your account to GoTV/DsTV");
                            Console.WriteLine("Enter PIN to continue");
                        }
                        else if (Carrer_input == "2")
                        {
                            Environment.Exit(0);
                        }
                        else
                        {
                            Console.ForegroundColor= ConsoleColor.Red;
                            Console.WriteLine("Invalid input, Please try again");
                            Console.ResetColor();
                        }
                    }while(Carrer_input != "1" && Carrer_input != "2");
                   

                    //Ask user to confirm Pin
                   
                    string enteredpinIUC = Console.ReadLine();
                    Console.Clear();
                    if (person.VerifyPin(enteredpinIUC))
                    {
                        person.BillPayment();
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("incorrect pin");
                        Console.ResetColor();
                        Console.WriteLine();
                        break;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid Smart Card Number/IUC Number ");
                    Console.ResetColor();
                }
            }
            else if (Techpayinput == "0")
            {
                Main();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Invalid choice please select a valid choice");
                Console.ResetColor();
            }

        } while (Techpayinput != "1" && Techpayinput != "2" && Techpayinput != "3" && Techpayinput != "0");
    }

    static void Main()
    {
        Person person = new Person();
        Console.Title = "Tech Coin";
        
        string Option1 = "1.Transfer";
        string Option2 = "2.Withdrawals";
        string Option3 = "3.Deposit";
        string Option4 = "4.My Account";
        string Option5 = "5.TechPAY & PayBill"; 
        Console.Clear();

        string optionInput = "";
        do
        {                    
           Console.ForegroundColor = ConsoleColor.Cyan;
           Console.ResetColor();
           Console.ForegroundColor = ConsoleColor.Blue;
           Console.WriteLine("WELCOME TO TECH COIN");
           Console.ResetColor();
           Console.WriteLine();
           Console.ForegroundColor = ConsoleColor.Blue;
           Console.WriteLine("Please choose one of the following options....");
           Console.ResetColor();
           Console.WriteLine(Option1 + "\n" + Option2 + "\n" + Option3 + "\n" + Option4 + "\n" + Option5);
           Console.WriteLine();
           optionInput = Console.ReadLine();                      
           Console.Clear();
           
            if (optionInput == "1")
            {
                Program.Transfer(person);             
            }  
            else if (optionInput == "2")
            {
                Program.Withdrawals(person);
            }
            else if (optionInput == "3")
            {              
               Program.Deposit(person);
            }
            else if (optionInput == "4")
            {             
                Program.MyAccount(person);
            }
            else if (optionInput == "5")
            {               
               Program.Techpay(person); 
            }         
            else
            {
              Console.WriteLine("Invalid input please try again");
            }

        } while (optionInput != "1" && optionInput != "2" && optionInput != "3" && optionInput != "4" && optionInput !="5");
        
    }
    
}
 


  


    


    


    


