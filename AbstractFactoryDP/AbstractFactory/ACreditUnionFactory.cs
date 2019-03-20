using AbstractFactoryDP.AbstractProduct;

namespace AbstractFactoryDP.AbstractFactory
{
    // Abstract factory 
  public abstract class ACreditUnionFactory
  {
      // This factory has two operations Create Loan and Saving accounts 
      public abstract ILoansAccount CreateLoanAccount();
      public abstract ISavingsAccount CreateSavingAccount();
    }
}
