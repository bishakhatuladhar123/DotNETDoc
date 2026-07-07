using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNETDoc.Classes.StaticClasses
{
    public class TestSC
    {
        public static void Main()
        {
            //StudentSCExample studentSCExample = new StudentSCExample();// cannot instantiated
            StudentSCExample.Method1();//directly instantiated to class name.
        }
    }
}
