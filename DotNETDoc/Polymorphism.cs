using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNETDoc
{
    public class Polymorphism
    {
        public static void Main()
        {
            ChildPolymorphismExample childPolymorphismExample = new ChildPolymorphismExample();
            childPolymorphismExample.Add(1, 2);
            childPolymorphismExample.Add(1, 2, 3);

            childPolymorphismExample.Sub(5, 4);

            childPolymorphismExample.Mul(5, 6);
        }
    }

    public class ParentPolymorphismExample
    {
        public void Add(int a, int b)
        {
            Console.WriteLine($"Method Overloading First a+b={a + b}");
        }
        public virtual void Sub(int a, int b)
        {
            Console.WriteLine($"Method Overriding First a-b={a - b}");
        }
        public void Mul(int a, int b)
        {
            Console.WriteLine($"Method Hiding First a*b={a * b}");
        }
    }

    public class ChildPolymorphismExample : ParentPolymorphismExample
    {
        public void Add(int a, int b, int c)
        {
            Console.WriteLine($"Method Overloading Second a+b+c={a + b + c}");
        }
        public override void Sub(int a, int b)
        {
            Console.WriteLine($"Method Overriding Second a-b={a - b}");
        }
        public new void Mul(int a, int b)
        {
            Console.WriteLine($"Method Hiding Second a*b={a * b}");
        }
    }
}
