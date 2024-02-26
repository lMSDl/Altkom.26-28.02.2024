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
        public float Incomes { get; set; }
        public float Outcomes { get; set; }
        public float AllowedDebit { get; set; }
    }
}
