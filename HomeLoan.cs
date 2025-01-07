using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public class HomeLoan : ILoan
    {
        public string GetLoanType() 
        {
            return "Home Loan"; 
        }
        
        public int GetLoanLimit() 
        { 
            return 1500000; 
        }
        
        public int GetInterestRate() 
        { 
            return 10; 
        }
    }
}
