using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AudiBuild
{
    public class CruiseControl : Accessories
    {
        Audi mAudi;

        public CruiseControl(Audi pAudi)
        {
            this.mAudi = pAudi;
        }

        public override String getDescription()
        {
            return mAudi.getDescription() + "\nOption: Audi adaptive cruise control - 2100.00";
        }

        public override double cost()
        {
            return 2100.00 + mAudi.cost();
        }
    }
}
