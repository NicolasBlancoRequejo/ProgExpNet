using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Prop_Event
{
    class Program
    {
        public static Lightbulb bulby;
        
        static void Main(string[] args)
        {
            Switch switch1 = new Switch();
            bulby = new Lightbulb();

            switch1.SwitchChanged += OnSwitchChanged;

            switch1.TurnOn();
            switch1.TurnOff();
            switch1.TurnOff();
        }

        private static void OnSwitchChanged(object sender, SwitchChangedEventArgs args)
        {
            bool switchOn = args.isOn;

            if (switchOn != bulby.IsOn)
            {
                bulby.IsOn = switchOn;
                if (switchOn)
                {
                    Console.WriteLine("The LightBulb has been turned on.");
                }
                else
                {
                    Console.WriteLine("The LightBulb has been turned off.");
                }
            }
        }
    }
}
