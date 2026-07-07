using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNETDoc.DependencyInjections.ConstructorDI
{
    public class FirstControllerCDI
    {
        private readonly IStudentServiceCDI _iStudentServiceCDI;
        public FirstControllerCDI(IStudentServiceCDI iStudentServiceCDI) 
        {
            _iStudentServiceCDI = iStudentServiceCDI;
        }

        public void Index()
        {
            _iStudentServiceCDI.GetStudentCount();
        }
    }
}
