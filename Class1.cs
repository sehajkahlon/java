using System;
namespace manroses_731784_A1_v3
{
    public class manroseBankaccount
    {
        private long accountNo;
        private string AC_Name, AC_Address;
        private double AC_Balance;
        public manroseBankaccount()//CONSTRUCTOR
        {
            accountNo = 0;
            AC_Name = ""; AC_Address = "";
            AC_Balance = 0.0;
        }
        public manroseBankaccount(long acno, string acnm, string addr, double
        bal)//overloaded CONSTRUCTOR
        {
            accountNo = acno;
            AC_Name = acnm;
            AC_Address = addr;
            AC_Balance = bal;
        }
        public void MS_withdrawal(double amt)
        {
            if (AC_Balance < amt)
                Console.WriteLine("Sorry not enough balance ...");
            else
                AC_Balance = AC_Balance - amt;
        }
        public void MS_Deposit(double amt)
        {
            AC_Balance = AC_Balance + amt;
        }
        public double MS_printRecipt()
        {
            Console.WriteLine("\n\n Royal Bank of Canada");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Branch : Ray Lawson .... code: 777");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Account No :{0}", accountNo);
            Console.WriteLine("customer Name :{0}", AC_Name);
            Console.WriteLine("Address :{0}", AC_Address);
            Console.WriteLine("Balance :{0}", AC_Balance);
            return AC_Balance;
        }
        public bool isAccountNoFound(long acno)
        {
            if (acno == accountNo)
                return true;
            else
                return false;
        }
    }
}

