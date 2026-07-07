using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNETDoc.DependencyInjections.MethodDI
{
    public class FirstControllerMDI
    {
        public void Index(IStudentServiceMDI iStudentServiceMDI)
        {
            iStudentServiceMDI.GetStudentCount();
        }
    }
}
