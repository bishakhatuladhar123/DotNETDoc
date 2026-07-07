using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNETDoc.DependencyInjections.MethodDI
{
    public class MathStudentMDI:IStudentServiceMDI
    {
        public void GetStudentCount()
        {
            Console.WriteLine($"Math Student Count={50}");
        }
    }
}
