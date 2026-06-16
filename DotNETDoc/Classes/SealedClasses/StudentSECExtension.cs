using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNETDoc.Classes.SealedClasses
{
    public static class StudentSECExtension
    {
        public static void Method3( this StudentSECExample studentSECExample)
        {
            Console.WriteLine("Method3");
        }
    }
}
