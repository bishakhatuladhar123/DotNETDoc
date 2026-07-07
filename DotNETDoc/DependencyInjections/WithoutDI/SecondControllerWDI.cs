using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNETDoc.DependencyInjections.WithoutDI
{
    public class SecondControllerWDI
    {
        public void Index()
        {
            ScienceStudentWDI mathStudentWDI = new ScienceStudentWDI();
            mathStudentWDI.GetStudentCount();
        }
    }
}
