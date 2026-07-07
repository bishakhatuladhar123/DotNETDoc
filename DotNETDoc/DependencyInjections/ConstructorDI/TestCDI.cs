using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNETDoc.DependencyInjections.ConstructorDI
{
    public class TestCDI
    {
        public static void Main()
        {
            IStudentServiceCDI iStudentServiceCDI = new ScienceStudentCDI();
            FirstControllerCDI firstControllerCDI = new FirstControllerCDI(iStudentServiceCDI);
            SecondControllerCDI secondControllerCDI = new SecondControllerCDI(iStudentServiceCDI);
            firstControllerCDI.Index();
            secondControllerCDI.Index();

        }
    }
}
