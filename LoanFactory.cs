using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    internal class LoanFactory 
    {
        public static ILoan GetLoan(string loanType) 
        {
            ILoan loanDetails = null; 
            if (loanType == "HomeLoan") 
            { 
                loanDetails = new HomeLoan(); 
            }
            else if (loanType == "PersonalLoan") 
            { 
                loanDetails = new PersonalLoan(); 
            }
            else 
            {
                loanDetails = new VehicleLoan();
            }

            return loanDetails;
        }
    }
}
