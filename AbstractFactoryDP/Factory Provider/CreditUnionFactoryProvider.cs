using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryDP.AbstractFactory;
using AbstractFactoryDP.ConcreteFactory;

namespace AbstractFactoryDP.Factory_Provider
{
    // This class actually decide on runtime which factory type will be returned
   public class CreditUnionFactoryProvider
    {
        public static ACreditUnionFactory GetCreditUnionFactory(string acountNo)
        {
            if (acountNo.ToLower().Contains("city"))
            {
                return  new CityCreditUnionFactory();
            }
            else if (acountNo.ToLower().Contains("national"))
            {
                return new NationalCreditUnionFactory();
            }
            else
            {
                return null;
            }
           
        }
    }
}
