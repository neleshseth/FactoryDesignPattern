using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public class PersonalLoan : ILoan
    {
        public string GetLoanType()
        {
            return "Personal Loan";
        }

        public int GetLoanLimit()
        {
            return 500000;
        }

        public int GetInterestRate()
        {
            return 12;
        }
    }
}
