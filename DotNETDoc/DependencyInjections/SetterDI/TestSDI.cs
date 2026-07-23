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

            firstControllerSDI.Index(); //shows MathStudent count
            secondControllerSDI.Index();//shows MathStudent count

            firstControllerSDI.iStudentServiceSDI=new ScienceStudentSDI();
            secondControllerSDI.iStudentServiceSDI=new ScienceStudentSDI();

            firstControllerSDI.Index();
            secondControllerSDI.Index();    
        }
    }
}
