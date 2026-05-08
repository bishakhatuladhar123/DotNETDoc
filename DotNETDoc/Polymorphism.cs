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
            ChildExample childExample=new ChildExample();
            childExample.Add(1, 2);
            childExample.Add(1, 2, 3); 
            childExample.Sub(5, 4);
            childExample.Mul(6, 7);
        }
        public class ParentExample
        {
            public void Add(int a, int b)
            {
                Console.WriteLine("a+b= "+(a+b));
            }
            public virtual void Sub(int m, int n)
            {
                Console.WriteLine("m-n= " + (m - n));

            }
            public void Mul(int x, int y)
            {
                Console.WriteLine("e*f= " + (x * y));

            }
        }
        public class ChildExample:ParentExample
        {
            public void Add(int a,int b,int c)
            {
                Console.WriteLine("(Overloading) a+b+c= " + (a + b + c));
            }
            public override void Sub(int m, int n)
            {
                Console.WriteLine("(Overriding) m-n2= " + (m-n));
            }
            public new void Mul(int x, int y)
            {
                Console.WriteLine("(Method Hiding) x*y2= "+(x * y));
            }
        }
    }
}
