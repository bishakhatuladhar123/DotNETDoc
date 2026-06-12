
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNETDoc.Classes.AbstractClasses
{
    public class KhaltiProcessor
    {
        public void LogTransaction(double amount)
        {
            Console.WriteLine($"[Log Transaction] Rs.{amount} recorded at {DateTime.Now}");
        }
        public void Pay(double amount)
        {
            Console.WriteLine($"Paying Rs.{amount} via Khalti REST api");
        }
    }
    public class EsewaProcessor
    {
        public void LogTransaction(double amount)
        {
            Console.WriteLine($"[Log Transaction] Rs.{amount} recorded at {DateTime.Now}");
        }
        public void Pay(double amount)
        {
            Console.WriteLine($"Paying Rs.{amount} via Esewa REST api");
        }
    }

    public class WithoutAbstractExample
    {
        public static void Main()
        {
            KhaltiProcessor khaltiProcessor = new KhaltiProcessor();
            khaltiProcessor.LogTransaction(500);
            khaltiProcessor.Pay(500);

            EsewaProcessor esewaProcessor = new EsewaProcessor();
            esewaProcessor.LogTransaction(800);
            esewaProcessor.Pay(800);
        }
    }
}
