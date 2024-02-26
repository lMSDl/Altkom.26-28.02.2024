﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._26_28._02._2024.DesignPrinciples
{
    public class PaymentAccount
    {
        public PaymentAccount(int id)
        {
            Id = id;
        }

        public int Id { get; }
        public string CustomerName { get; set; }
        public float Incomes { get; private set; }
        public float Outcomes { get; private set; }
        public float AllowedDebit { get; set; }
        public float Balance => Incomes - Outcomes;

        public bool Charge(float amount)
        {
            if (Balance + AllowedDebit < amount)
                return false;

            Outcomes += amount;
            return true;
        }

        public void Fund(float amount)
        {
            Incomes += amount;
        }
    }
}
