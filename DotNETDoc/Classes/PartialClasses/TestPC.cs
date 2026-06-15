using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNETDoc.Classes.PartialClasses
{
    public class TestPC
    {
        public static void Main()
        {
            StudentPC studentPC = new StudentPC();
            studentPC.Method1();
            studentPC.Method2();
           // studentPC.Method3();
        }
    }

    public class BookExample
    { 
        public void Method3()
        {
            Console.WriteLine("Method3");
        }
    }
}
