using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Prop_Event
{
    public class Lightbulb
    {
        private bool _isOn;
        private string _color;

        public Lightbulb( )
        {
            _isOn = false;
            _color = "yellow";
        }

        public bool IsOn
        {
            get { return  _isOn; }
            set { _isOn = value; }
        }

        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }
    }
}
