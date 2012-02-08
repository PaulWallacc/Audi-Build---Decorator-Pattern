using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AudiBuild
{
    public class SunShades : Accessories
    {
        Audi mAudi;

        public SunShades(Audi pAudi)
        {
            this.mAudi = pAudi;
        }

        public override String getDescription()
        {
            return mAudi.getDescription() + "\nOption: Sun Shades - 500.00";
        }

        public override double cost()
        {
            return 500.00 + mAudi.cost();
        }
    }
}
