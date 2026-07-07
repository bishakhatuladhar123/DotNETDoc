using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNETDoc.DependencyInjections.ConstructorDI
{
    public class ScienceStudentCDI:IStudentServiceCDI
    {
        public void GetStudentCount()
        {
            Console.WriteLine($"Science Student Count={100}");
        }
    }

}
