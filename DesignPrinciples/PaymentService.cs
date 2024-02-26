using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._26_28._02._2024.DesignPrinciples
{
    public class PaymentService
    {
        public bool Charge(Customer customer, float amount)
        {
            var account = customer?.PaymentAccount;
            return account?.Charge(amount) ?? false;
        }

        public void Fund(Customer customer, float amount)
        {
            customer?.PaymentAccount.Fund(amount);
        }
    }
}
