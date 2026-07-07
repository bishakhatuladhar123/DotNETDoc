using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNETDoc.DependencyInjections.SetterDI
{
    public class MathStudentSDI:IStudentServiceSDI
    {
        public void GetStudentCount()
        {
            Console.WriteLine($"Math Student Count={50}");
        }
    }
}
