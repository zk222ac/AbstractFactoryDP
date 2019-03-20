using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryDP.AbstractProduct;

namespace AbstractFactoryDP.ConceretProduct
{
    // Concrete Product A2
    class NationalLoanAccount : ILoansAccount
    {
        public NationalLoanAccount()
        {
            Console.WriteLine("Returned National Loan Account");
        }
    }
}
