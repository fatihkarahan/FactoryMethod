using FactoryMethod.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Creator
{
    class PlatinumFactory : CardFactory
    {
        private int _creditLimit;
        private int _annualCharge;
        public PlatinumFactory(int creditLimit, int annualCharge)
        {
            _creditLimit = creditLimit;
            _annualCharge = annualCharge;
        }
        public override CreditCard GetCreditCart()
        {
            return new PlatinumCreditCard(500, 1);
        }
    }
}
