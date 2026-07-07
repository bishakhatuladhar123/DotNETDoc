using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNETDoc.DependencyInjections.MethodDI
{
    public class SecondControllerMDI
    {
        public void Index(IStudentServiceMDI iStudentServiceMDI)
        {
            iStudentServiceMDI.GetStudentCount();
        }
    }
}
