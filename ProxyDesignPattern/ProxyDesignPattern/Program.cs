namespace ProxyDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPayment payment = new ProxyPayment("12345");

            bool result = payment.Pay(100.50M);
            Console.WriteLine("Payment result: " + result);
        }
    }
}