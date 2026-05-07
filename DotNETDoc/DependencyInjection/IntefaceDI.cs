using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNETDoc.DependencyInjection
{
    public interface IToolUserIDI
    {
        void SetHammerIDI(HammerIDI hammerIDI);

        void SetSawIDI(SawIDI sawIDI);
    }
    public class HammerIDI
    {
        public void HammerIDIMethod()
        {
            Console.WriteLine("HammerIDI Method");
        }
    }
    public class SawIDI
    {
        public void SawIDIMethod()
        {
            Console.WriteLine("SawIDI Method");
        }
    }
    public class BuilderIDI : IToolUserIDI
    {
        private HammerIDI _hammerIDI;
        private SawIDI _sawIDI;

        public void SetHammerIDI(HammerIDI hammerIDI)
        {
            _hammerIDI = hammerIDI;
        }

        public void SetSawIDI(SawIDI sawIDI)
        {
            _sawIDI = sawIDI;
        }
        public void BuilderIDIMethod()
        {
            _hammerIDI.HammerIDIMethod();
            _sawIDI.SawIDIMethod();
            Console.WriteLine("Builder IDI");
        }

      
    }

    public class InterfaceDI
    {
        public static void Main()
        {
            HammerIDI hammerIDI = new HammerIDI();
            SawIDI sawIDI = new SawIDI();

            BuilderIDI builderIDI = new BuilderIDI();
            builderIDI.SetHammerIDI(hammerIDI);
            builderIDI.SetSawIDI(sawIDI);
            builderIDI.BuilderIDIMethod();
        }
    }

}
