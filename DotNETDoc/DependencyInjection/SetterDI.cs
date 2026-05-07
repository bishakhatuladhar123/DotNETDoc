using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DotNETDoc.DependencyInjection
{
    public class HammerSDI
    {
        public void HammerSDIMethod() => Console.WriteLine("HammerSDI Method");
    }


    public class SawSDI
    {
        public void SawSDIMethod() => Console.WriteLine("SawSDI Method");
    }
    public class BuilderSDI
    {
        public HammerSDI HammerSDI { get; set; }
        public SawSDI SawSDI { get; set; }

        public void BuilderSDIMethod()
        {
            HammerSDI.HammerSDIMethod();
            SawSDI.SawSDIMethod();
            Console.WriteLine("Builder SDI Method");
        }
    }
    public class SetterDI
    {
        public static void Main()
        {
            HammerSDI hammerSDI = new HammerSDI();//create dependency outside
            SawSDI sawSDI = new SawSDI();

            BuilderSDI builderSDI = new BuilderSDI();
            builderSDI.HammerSDI = hammerSDI;//inject the dependency via setter
            builderSDI.SawSDI = sawSDI;//inject the dependency via setter
            builderSDI.BuilderSDIMethod();
        }
    }

}
