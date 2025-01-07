using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public class VehicleLoan : ILoan
    {
        public string GetLoanType()
        {
            return "Vehicle Loan";
        }

        public int GetLoanLimit()
        {
            return 700000;
        }

        public int GetInterestRate()
        {
            return 14;
        }
    }
}
