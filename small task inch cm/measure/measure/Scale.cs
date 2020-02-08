using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace measure
{
    class Scale
    {
       float cm;
        float inches;
        public float inch
        {
            get { return cm / 2.54; }
            set { cm = value * 2.54; }

        }
        public float cm()
        {
            get {( return (int)(inch * 2.54); }
        }
    }
}
            
        
    

