﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxPay
{
    class Taxpayer
    {
        private string socialSecNumber;
        private double yearlyGrossIncome;
        private double taxOwed;
        public string SocialSecNumber
        {
            get
            {
                return socialSecNumber;
            }
            set
            {
                socialSecNumber = value;
            }
        }

        public double YearlyGrossIncome
        {
            get
            {
                return yearlyGrossIncome;
            }
            set
            {
                yearlyGrossIncome = value;
                calcTaxOwed();
            }
        }
        public double TaxOwed
        {
            get
            {
                return taxOwed;
            }
        }
        private void calcTaxOwed()
        {
            if (yearlyGrossIncome < 30000)
            {
                taxOwed = yearlyGrossIncome * .15;
            }
            else
            {
                taxOwed = yearlyGrossIncome * .28;
            }
        }
    }
}
