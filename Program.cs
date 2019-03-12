using System;
namespace manroses_731784_A1_v3
{
    class manrosesMain
    {
        static void Main(string[] args)
        {
            manroseBankaccount[] bc = new manroseBankaccount[50];
            int i = 0;
            long acno = 1000;
            int foundIndex = 0;
            string acname, addr;
            double balance; bool isExist = false;
            double amount;
            int choice;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("____________________________________");
                Console.WriteLine("| - Royal Bank - |");
                Console.WriteLine("|121 Brunel Rd.....Mississauga,ON |");
                Console.WriteLine("|__________________________________|");
                Console.WriteLine("|1. Create New Account |");
                Console.WriteLine("|2. Deposit |");
                Console.WriteLine("|3. Withdraw |");
                Console.WriteLine("|4. Print Receipt |");
                Console.WriteLine("|5. Exit |");
                Console.WriteLine("|__________________________________|");
                Console.Write("\n\n \t Enter your choice(1/2/3/4/5(Exit)) : ");
                choice = int.Parse(Console.ReadLine());
                try //try...catch block command helps you to catch the error, and avoids
                    //abrupt termination of a program
                {
                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter Name of Account Holder: ");
                            acname = Console.ReadLine();
                            Console.Write("Enter Address of Account Holder: ");
                            addr = Console.ReadLine();
                            Console.Write("Enter the initial balance: ");
                            balance = double.Parse(Console.ReadLine());
                            acno = acno + 1;
                            bc[i++] = new manroseBankaccount(acno, acname, addr,
                            balance);
                            Console.WriteLine("Details of newly created account");
                            Console.WriteLine("________________________________");
                            bc[i - 1].MS_printRecipt();
                            Console.WriteLine("________________________________");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            Console.Clear(); //is a method to clear the screen
                            break;
                        case 3:
                            isExist = false;
                            if (i == 0)
                            {
                                Console.Write("\n\n Sorry No data in Bank Database :");
                                Console.WriteLine("\n\n... Press any key to go to Main menu...\n");
                                Console.ReadKey();
                                break;
                            }
                            else
                            {
                                Console.Write(" Enter the account number :");
                                acno = long.Parse(Console.ReadLine());
                                for (int j = 0; j < bc.Length; j++)
                                {
                                    if (bc[j].isAccountNoFound(acno) == true)
                                    {
                                        isExist = true;
                                        foundIndex = j;
                                        break;
                                    }
                                    else
                                        isExist = false;
                                }
                                if (isExist)
                                {
                                    Console.Write("Enter the amount to withdraw : ");
                                    amount = double.Parse(Console.ReadLine());
                                    bc[foundIndex].MS_withdrawal(amount);
                                    bc[foundIndex].MS_printRecipt();
                                    Console.WriteLine("\n \n Thank you ... Press any keyto go to Main Menu...");
                                    Console.ReadKey();
                                }
                                else
                                    Console.Write("Sorry account does not exist : ");
                            }
                            break;
                        case 2:
                            if (i == 0)
                            {
                                Console.Write(" \n Sorry No data in Bank Database :");
                                Console.WriteLine("Thank you ... Press any key to go to Main menu...");
                                Console.ReadKey();
                                break;
                            }
                            else
                            {
                                Console.Write(" Enter the account number :");
                                acno = long.Parse(Console.ReadLine());
                                for (int j = 0; j < bc.Length; j++)
                                {
                                    if (bc[j].isAccountNoFound(acno) == true)
                                    {
                                        foundIndex = j;
                                        break;
                                    }
                                    else
                                        isExist = false;
                                }
                                if (isExist)
                                {
                                    Console.Write("Enter the amount to Deposit : ");
                                    amount = double.Parse(Console.ReadLine());
                                    bc[foundIndex].MS_Deposit(amount);
                                    bc[foundIndex].MS_printRecipt();
                                    Console.WriteLine("\n\n\t Thank you ... Press any ke to go to Main Menu...");
                                    Console.ReadKey();
                                }
                                else
                                    Console.Write("Sorry account does not exist : ");
                            }
                            break;
                        case 4:
                            if (i == 0)
                            {
                                Console.Write(" Sorry No data in Bank Database :");
                                Console.WriteLine("Thank you ... Press any key to go to Main menu...");
                                Console.ReadKey();
                                break;
                            }
                            else
                            {
                                Console.Write(" Enter the account number :");
                                acno = long.Parse(Console.ReadLine());
                                for (int j = 0; j < bc.Length; j++)
                                {
                                    if (bc[j].isAccountNoFound(acno) == true)
                                    {
                                        foundIndex = j;
                                        break;
                                    }
                                    else
                                        isExist = false;
                                }
                                if (isExist)
                                {
                                    bc[foundIndex].MS_printRecipt();
                                    Console.WriteLine("\n\n\t Thank you ... Press any key to go to Main Menu ...");
                                    Console.ReadKey();
                                }
                                else
                                    Console.Write("Sorry account does not exist : ");
                            }
                            break;
                        case 5:
                            Environment.Exit(0);
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error is " + e.Message);
                }
            }
        }
    }
}

