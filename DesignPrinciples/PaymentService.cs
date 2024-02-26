﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._26_28._02._2024.DesignPrinciples
{
    public class PaymentService
    {
        private ICollection<PaymentAccount> PaymentAccounts { get; } = new List<PaymentAccount> { new PaymentAccount(1), new PaymentAccount(2), new PaymentAccount(3), new PaymentAccount(4), new PaymentAccount(5) };

        public bool DeletePaymentAccounts(PaymentAccount paymentAccount)
        {
            return PaymentAccounts.Remove(paymentAccount);
        }

        public PaymentAccount? FindByAllowedDebit(float allowedDebit)
        {
            return PaymentAccounts.SingleOrDefault(x => x.AllowedDebit == allowedDebit);
        }

        public bool Charge(int accountId, float amount)
        {
            var account = PaymentAccounts.SingleOrDefault(x => x.Id == accountId);
            if (account == null)
            {
                return false;
            }

            if (account.Incomes - account.Outcomes + account.AllowedDebit < amount)
            {
                return false;
            }

            account.Outcomes += amount;
            return true;
        }

        public void Fund(int accountId, float amount)
        {
            var account = PaymentAccounts.Where(x => x.Id == accountId).SingleOrDefault();
            if (account == null)
            {
                return;
            }

            account.Incomes += amount;
        }

        public float? GetBalance(int accountId)
        {
            var account = PaymentAccounts.Where(x => x.Id == accountId).SingleOrDefault();
            return account?.Incomes - account?.Outcomes;
        }
    }
}
