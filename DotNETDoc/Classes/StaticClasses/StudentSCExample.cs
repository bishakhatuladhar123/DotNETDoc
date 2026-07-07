using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNETDoc.Classes.StaticClasses
{
    public static class StudentSCExample
    {
        //static field
        public static string StudentName;

        //static constructor
        static StudentSCExample()
        {
            StudentName = "Bishakha";
        }

        //static method
        public static void Method1()
        {
            Console.WriteLine("Method1");
        }
    }

    //public class TeacherSC:StudentSCExample//static class cannot inherited.
    //{}
}
