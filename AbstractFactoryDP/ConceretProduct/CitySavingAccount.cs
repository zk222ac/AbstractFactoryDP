using System;
using AbstractFactoryDP.AbstractProduct;

namespace AbstractFactoryDP.ConceretProduct
{
    // Concrete Product B1
   public class CitySavingAccount : ISavingsAccount
    {
        public CitySavingAccount()
        {
            Console.WriteLine("Return City Savings Accounts");
        }

    }
}
