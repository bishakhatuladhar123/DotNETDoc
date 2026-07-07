using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNETDoc.DependencyInjections.ConstructorDI
{
    public class SecondControllerCDI
    {
        private readonly IStudentServiceCDI _iStudentServiceCDI;
        public SecondControllerCDI(IStudentServiceCDI iStudentServiceCDI)
        {
            _iStudentServiceCDI = iStudentServiceCDI;
        }
        public void Index()
        {
            _iStudentServiceCDI.GetStudentCount();
        }
    }
}
