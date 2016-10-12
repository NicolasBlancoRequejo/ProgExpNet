using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Prop_Event
{
    public class Switch
    {
        public event SwitchChangedDelegate SwitchChanged;

        public void TurnOn()
        {
            SwitchChangedEventArgs args = new SwitchChangedEventArgs();
            args.isOn = true;
            SwitchChanged(this, args);
        }
        public void TurnOff()
        {
            SwitchChangedEventArgs args = new SwitchChangedEventArgs();
            args.isOn = false;
            SwitchChanged(this, args);
        }
    }
}
