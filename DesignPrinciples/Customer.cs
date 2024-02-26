using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._26_28._02._2024.DesignPrinciples
{
    public class Customer
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public Customer(int id)
        {
            Id = id;
        }

        public PaymentAccount PaymentAccount { get; } = new PaymentAccount();
    }
}
