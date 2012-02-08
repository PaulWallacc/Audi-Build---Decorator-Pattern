using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AudiBuild
{
    class AudiA420TFSIAutoQuattro : Audi
    {
        public AudiA420TFSIAutoQuattro()
        {
            setDescription("Model: 2.0 TFSI Pestige with eight-speed Tiptronic trans and quattro - $44,100.00");
        }

        public override double cost()
        {
            return 44100.00;
        }

    }
}
