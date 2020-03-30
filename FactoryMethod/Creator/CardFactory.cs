using FactoryMethod.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Creator
{
    abstract class CardFactory
    {
        public abstract CreditCard GetCreditCart();
    }
}
