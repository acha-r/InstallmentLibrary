using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstallmentLibrary
{
    public abstract class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public double AmountToPay { get; set; }

        protected PaymentStatusEnum Status = PaymentStatusEnum.IncompletePayment;
        public PaymentStatusEnum PaymentStatus => Status;

        protected Customer() { }

        protected Customer(string name, double amountToPay)        
        {
            Name = name;
            AmountToPay = amountToPay;
        }

    }
}
