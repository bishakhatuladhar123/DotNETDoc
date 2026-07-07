using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNETDoc.DependencyInjections.SetterDI
{
    public class SecondControllerSDI
    {
        public IStudentServiceSDI iStudentServiceSDI { get; set; } =new MathStudentSDI();

        public void Index()
        {
            iStudentServiceSDI.GetStudentCount();
        }
    }
}
