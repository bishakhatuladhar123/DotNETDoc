using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNETDoc.DependencyInjection
{
    public class Hammer
    {
        public void HammerMethod()
        {
            Console.WriteLine("Hammer Method");
        }
    }
    public class Saw
    {
        public void SawMethod()
        {
            Console.WriteLine("Saw Method");
        }
    }
    public class Builder
    {
        private Hammer _hammer;
        private Saw _saw;
        public Builder()
        {
            _hammer = new Hammer();//Builder is responsible for creating its dependencies
            _saw = new Saw();
        }

        public void BuildMethod()
        {
            _hammer.HammerMethod();
            _saw.SawMethod();
            Console.WriteLine("Build Method");
        }
    }
    internal class DependencyInjection
    {
        static void Main()
        { 
            Builder builder = new Builder();
            builder.BuildMethod();
        }
    }
}
