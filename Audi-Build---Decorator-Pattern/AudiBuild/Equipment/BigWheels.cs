using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AudiBuild
{
    public class BigWheels : Accessories
    {
        Audi mAudi;

        public BigWheels(Audi pAudi)
        {
            this.mAudi = pAudi;
        }

        public override String getDescription()
        {
            return mAudi.getDescription() + "\nWheels: 19” 5-arm-Rotor-design Titanium-finish alloy wheels - $1250.00";
        }

        public override double cost()
        {
            return 1250.00 + mAudi.cost();
        }
    }
}
