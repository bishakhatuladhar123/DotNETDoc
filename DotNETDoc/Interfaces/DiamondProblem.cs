using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNETDoc.Interfaces
{
    public class DiamondProblem
    {
        public static void Main()
        {
            ClassD classD = new ClassD(); //Note:•	There is conflict when we call the print method via ClassD. There will be confusion whether to use the Print method via ClassB or via ClassC
            classD.Print();
        }

        public class ClassA
        {
            public virtual  void Print()
            {
                Console.WriteLine("ClassA");
            }
        }

        public class ClassB: ClassA //(ClassB and ClassC) both inherit from ClassA. ClassB and ClassC override the Print method from ClassA differently
        {
            public override void Print()
            {
                Console.WriteLine("ClassB");
            }
        }

        public class ClassC : ClassA 
        {
            public override void Print()
            {
                Console.WriteLine("ClassC");
            }
        }

        public class ClassD: ClassB//,ClassC// Note: ClassD inherit from both (ClassB and ClassC) (but ClassD doesnot override the Print Method)
        { 
        
        }


    }
}



