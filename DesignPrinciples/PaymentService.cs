using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._26_28._02._2024.DesignPrinciples
{
    public class PaymentService
    {
        private ICollection<PaymentAccount> PaymentAccounts { get; } = new List<PaymentAccount> { new PaymentAccount(1), new PaymentAccount(2), new PaymentAccount(3), new PaymentAccount(4), new PaymentAccount(5) };

        public bool Charge(int accountId, float amount)
        {
            var account = GetById(accountId);
            return account?.Charge(amount) ?? false;
        }

        public void Fund(int accountId, float amount)
        {
            GetById(accountId)?.Fund(amount);
        }

        private PaymentAccount? GetById(int accountId)
        {
            return PaymentAccounts.Where(x => x.Id == accountId).SingleOrDefault();
        }
    }
}
