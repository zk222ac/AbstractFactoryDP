using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryDP.AbstractProduct;

namespace AbstractFactoryDP.ConceretProduct
{
    // Concrete Product B2
    class NationalSavingsAccount : ISavingsAccount
    {
        public NationalSavingsAccount()
        {
            Console.WriteLine("Returned National Saving Accounts");
        }
    }

}
