using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryDP.AbstractFactory;
using AbstractFactoryDP.AbstractProduct;
using AbstractFactoryDP.ConceretProduct;

namespace AbstractFactoryDP.ConcreteFactory
{
    // Concrete Factory 2
    class NationalCreditUnionFactory : ACreditUnionFactory
    {
        public override ILoansAccount CreateLoanAccount()
        {
            NationalLoanAccount objNla = new NationalLoanAccount();
            return objNla;
        }

        public override ISavingsAccount CreateSavingAccount()
        {
           NationalSavingsAccount objNsa = new NationalSavingsAccount();
            return objNsa;
        }
    }
}
