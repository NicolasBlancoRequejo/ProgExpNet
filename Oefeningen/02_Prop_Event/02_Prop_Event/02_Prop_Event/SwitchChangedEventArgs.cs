using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Prop_Event
{
    public class SwitchChangedEventArgs : EventArgs
    {
        public bool isOn { get; set; }
    }
}
