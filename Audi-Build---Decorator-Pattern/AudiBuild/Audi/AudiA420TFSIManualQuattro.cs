using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AudiBuild
{
    public class AudiA420TFSIManualQuattro : Audi
    {
        public AudiA420TFSIManualQuattro()
        {
            setDescription("Model: 2.0 TFSI Prestige with six-speed manual trans and quattro - $42,800.00");
        }

        public override double cost()
        {
            return 42800.00;
        }
    }
}
