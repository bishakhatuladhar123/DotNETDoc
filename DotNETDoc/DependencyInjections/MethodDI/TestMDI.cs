using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNETDoc.DependencyInjections.MethodDI
{
    public class TestMDI
    {
        public static void Main()
        {
            IStudentServiceMDI iStudentServiceMDI = new MathStudentMDI();

            FirstControllerMDI firstControllerMDI = new FirstControllerMDI();
            SecondControllerMDI secondControllerMDI = new SecondControllerMDI();

            firstControllerMDI.Index(iStudentServiceMDI);
            secondControllerMDI.Index(iStudentServiceMDI);
        }
    }
}
