using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNETDoc.DependencyInjection
{
    public class HammerCDI
    {
        public void HammerCDIMethod()
        {
            Console.WriteLine("Hammer CDI Method");
        }
    }
    public class SawCDI
    {
        public void SawCDIMethod()
        {
            Console.WriteLine("Saw CDI Method");
        }
    }

    public class BuilderCDI
    {
        private HammerCDI _hammerCDI;
        private SawCDI _sawCDI;

        public BuilderCDI(HammerCDI hammerCDI, SawCDI sawCDI)//Constructor Dependency Injection
        {
            _hammerCDI = hammerCDI;
            _sawCDI = sawCDI;
        }

        public void BuilderCDIMethod()
        {
            _hammerCDI.HammerCDIMethod();
            _sawCDI.SawCDIMethod();

            Console.WriteLine("BuilderCDI Method");
        }
    }
    internal class ConstructorDI
    {
        static void Main()
        {
            HammerCDI hammerCDI = new HammerCDI();
            SawCDI sawCDI = new SawCDI();
            BuilderCDI builderCDI = new BuilderCDI(hammerCDI,sawCDI);
            builderCDI.BuilderCDIMethod();

        }
    }
}
