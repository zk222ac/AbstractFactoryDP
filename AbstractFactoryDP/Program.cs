using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryDP.AbstractFactory;
using AbstractFactoryDP.AbstractProduct;
using AbstractFactoryDP.Factory_Provider;

namespace AbstractFactoryDP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Client!");
            List<string> accountNumbers = new List<string>()
            {
                "city-3645", "national-6725" , "chase-897"
            };

            for (int i = 0; i < accountNumbers.Count; i++)
            {
                ACreditUnionFactory abstractFactory = CreditUnionFactoryProvider.GetCreditUnionFactory(accountNumbers[i]);
                if (abstractFactory == null)
                {
                    Console.WriteLine($"sorry account number is invalid :{accountNumbers[i]}");
                }
                else
                {
                    ILoansAccount loan = abstractFactory.CreateLoanAccount();
                    ISavingsAccount saving = abstractFactory.CreateSavingAccount();
                }
            }

            Console.ReadKey();

           
        }
    }
}
