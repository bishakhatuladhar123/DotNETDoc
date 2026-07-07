using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNETDoc.DependencyInjections.ConstructorDI
{
    public class MathStudentCDI:IStudentServiceCDI
    {
        public void GetStudentCount()
        {
            Console.WriteLine($"Math Student Count={50}");
        }
    }
}
