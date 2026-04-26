using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNETDoc.Interfaces
{
    public class ResolveDiamondProblem
    {
        public static void Main()
        {
            ClassD classD = new ClassD();//Note:Class D simply writes one version of Print method. There is no confusion because the interfaces didn't provide any conflicting logic—they just provided a requirement. Class D provides the actual code, so the compiler always knows exactly what to run
            ((IClassA)classD).Print();
            ((IClassB)classD).Print(); 
            ((IClassC)classD).Print();
            classD.Print();
        }
    }

    interface IClassA
    {
        void Print();
    }
    interface IClassB:IClassA
    {
        new void Print();
    }
    interface IClassC:IClassA
    {
       new void Print();
    }

    public class ClassD : IClassB, IClassC
    {
        void IClassA.Print()
        {
            Console.WriteLine("Class A");

        }
        void IClassB.Print()//Note: this run only when called via IClassB reference
        {
            Console.WriteLine("Class  B");
        }
        void IClassC.Print()//Note: this run only when called via IClassC reference
        {
            Console.WriteLine("Class  C");

        }
        // Logic: ClassD decides exactly what happens.
        // There is no more "confusion" because ClassD defines the behavior.
        public void Print() =>Console.WriteLine("ClassD");
    }
}
