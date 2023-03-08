using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSyntax
{
    public class Customer
    {
        private decimal _availableCredit = 5000;
        public decimal GetCurrentAvailableCredit()
        {
            return _availableCredit;
        }

        /// <summary>
        /// Use this to increase the credit limit
        /// </summary>
        /// <param name="amount">the amount to add to the current credit limit</param> 
        /// <param name="effectiveDate"></param>
        public void IncreaseAvailableCredit(decimal amount, DateTimeOffset effectiveDate)
        {
            _availableCredit += amount;
        }
    }
}
