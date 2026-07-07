using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNETDoc.DependencyInjections.MethodDI
{
    public class ScienceStudentMDI:IStudentServiceMDI
    {
        public void GetStudentCount()
        {
            Console.WriteLine($"Science Student Count={100}");
        }
    }
}
