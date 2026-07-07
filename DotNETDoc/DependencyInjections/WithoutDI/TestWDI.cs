using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNETDoc.DependencyInjections.WithoutDI
{
    public class TestWDI
    {
        public static void Main()
        {
            FirstControllerWDI firstControllerWDI = new FirstControllerWDI();
            firstControllerWDI.Index();

            SecondControllerWDI secondControllerWDI = new SecondControllerWDI();
            secondControllerWDI.Index();
        }
    }
}
