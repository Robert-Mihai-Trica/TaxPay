using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxPay
{
    class Program
    {
        static void Main(string[] args)
        {
            Taxpayer[] payers = new Taxpayer[10];
            for (int i = 0; i < payers.Length; i++)
            {
                payers[i] = new Taxpayer();
                Console.WriteLine("Enter payer #{0} SSN", i + 1);
                payers[i].SocialSecNumber = Console.ReadLine();
                Console.WriteLine("Enter payer #{0} yearly income", i + 1);
                payers[i].YearlyGrossIncome = double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < payers.Length; i++)
            {
                Console.WriteLine("Tax payer #{0}, SSN ={1}, Income = {2}, Tax Owed = {3}", i + 1, payers[i].SocialSecNumber, payers[i].YearlyGrossIncome, payers[i].TaxOwed);
            }
        }
    }
}
