using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNETDoc.DependencyInjections.MethodDI
{
    public class FirstControllerMDI
    {
        public void Index()
        {
            Console.WriteLine("Method Dependency Injection Index");
        }
        public void Detail(IStudentServiceMDI iStudentServiceMDI)
        {
            iStudentServiceMDI.GetStudentCount();
        }
        public void Report(IStudentServiceMDI iStudentServiceMDI)
        {
            iStudentServiceMDI.GetStudentCount();
        }
    }
}
