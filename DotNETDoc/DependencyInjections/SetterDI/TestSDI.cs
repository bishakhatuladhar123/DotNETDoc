using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNETDoc.DependencyInjections.SetterDI
{
    public class TestSDI
    {
        public static void Main()
        {
            FirstControllerSDI firstControllerSDI = new FirstControllerSDI();
            SecondControllerSDI secondControllerSDI = new SecondControllerSDI();    
            firstControllerSDI.iStudentServiceSDI=new MathStudentSDI();
            secondControllerSDI.iStudentServiceSDI=new MathStudentSDI();

            firstControllerSDI.Index();
            secondControllerSDI.Index();    
        }
    }
}
