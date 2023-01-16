using InstallmentPaymentLibrary;

namespace ConsoleApp1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Customer Customer = new Customer("Rachel", 100000);
            Customer.DailyPlan();

        }
    }
}