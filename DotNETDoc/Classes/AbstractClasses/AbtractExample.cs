using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNETDoc.Classes.AbstractClasses.AbstractExample
{
    public abstract class BaseProcessor
    {
        public void LogTransaction(double amount)
        {
            Console.WriteLine($"[Log Transaction] Rs.{amount}recorded at {DateTime.Now}");
        }

        public abstract void Pay(double amount);
    }

    public class KhaltiProcessor : BaseProcessor
    {
        public override void Pay(double amount)
        {
            LogTransaction(amount);
            Console.WriteLine($"Paying Rs.{amount} via Khalti Processor");
        }
    }
    public class EsewaProcessor : BaseProcessor
    {
        public override void Pay(double amount)
        {
            LogTransaction(amount);
            Console.WriteLine($"Paying Rs.{amount} via Esewa Processor");
        }
    }

    public class AbtractExample
    {
        public static void Main()
        {
            KhaltiProcessor khaltiProcessor = new KhaltiProcessor();
            khaltiProcessor.Pay(500);

            EsewaProcessor esewaProcessor = new EsewaProcessor();
            esewaProcessor.Pay(800);
        }
    }
}
