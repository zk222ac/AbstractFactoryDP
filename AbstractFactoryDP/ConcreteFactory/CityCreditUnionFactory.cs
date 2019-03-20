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
    // Concrete Factory 1
    class CityCreditUnionFactory : ACreditUnionFactory
    {
        public override ILoansAccount CreateLoanAccount()
        {
            CityLoanAccount objCla = new CityLoanAccount();
            return objCla;
        }

        public override ISavingsAccount CreateSavingAccount()
        {
           CitySavingAccount objCSa = new CitySavingAccount();
            return objCSa;
        }
    }
}
