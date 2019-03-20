using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryDP.AbstractProduct;

namespace AbstractFactoryDP.ConceretProduct
{
    // Concrete Product A1
    class CityLoanAccount : ILoansAccount
    {
        public CityLoanAccount()
        {
            Console.WriteLine("Returned City Loan Account");
        }
    }
}
