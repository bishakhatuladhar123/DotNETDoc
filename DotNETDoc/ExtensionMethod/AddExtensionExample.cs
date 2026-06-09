using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNETDoc.ExtensionMethod
{
    public static class AddExtensionExample
    {
        public static void MethodC(this OriginalExtensionExample originalExtensionExample)
        {
            Console.WriteLine("Method C");
        }

    }
}
