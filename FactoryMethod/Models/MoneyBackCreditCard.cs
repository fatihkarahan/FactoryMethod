﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Models
{
    class MoneyBackCreditCard : CreditCard
    {
        private readonly string _cardType;
        private int _creditLimit;
        private int _annualCharge;

        public MoneyBackCreditCard(int creditLimit, int annualCharge)
        {
            _cardType = "MoneyBack";
            _creditLimit = creditLimit;
            _annualCharge = annualCharge;
        }

        public override string CreditCartType { get => _cardType; }
        public override int CreditLimit { get  { return _creditLimit; } set => _creditLimit = value; }
        public override int AnnualCharge { get { return _annualCharge; } set => _annualCharge = value; }
    }
}
