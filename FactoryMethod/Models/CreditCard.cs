using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Models
{
    abstract class CreditCard
    {
        public abstract string CreditCartType { get;}
        public abstract int CreditLimit { get; set; }
        public abstract int AnnualCharge { get; set; }
    }
}
