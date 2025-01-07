using FactoryDesignPattern;
using System;
class Program
{
    static void Main(string[] args) 
    {
        ILoan loan = LoanFactory.GetLoan("HomeLoan"); 
        if (loan != null)
        {
            Console.WriteLine("LoanType - " + loan.GetLoanType());
            Console.WriteLine("LoanLimit - " + loan.GetLoanLimit()); 
            Console.WriteLine("Int - " + loan.GetInterestRate());
        }
        else 
        {
            Console.WriteLine("Invalid loan Type"); 
        }
        Console.ReadLine();
    }
}