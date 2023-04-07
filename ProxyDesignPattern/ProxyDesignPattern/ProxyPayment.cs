using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPattern
{
    internal class ProxyPayment : IPayment
    {
        private Payment payment;
        private string paymentApiKey;

        public ProxyPayment(string paymentApiKey)
        {
            this.paymentApiKey = paymentApiKey;
        }

        public bool Pay(decimal amount)
        {
            if (string.IsNullOrEmpty(paymentApiKey))
            {
                Console.WriteLine("Payment API key is invalid.");
                return false;
            }

            if (!IsPaymentApiAvailable())
            {
                Console.WriteLine("Could not connect to Payment API.");
                return false;
            }

            payment = new Payment();
            bool result = payment.Pay(amount);
            if (result)
            {
                Console.WriteLine("Payment made successfully.");
            }

            return result;
        }

        private bool IsPaymentApiAvailable()
        {
            Console.WriteLine("Connecting to Payment API...");
            return true;
        }
    }
}
