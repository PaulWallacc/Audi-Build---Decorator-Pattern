using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AudiBuild
{
    public class SelectiveDrive : Accessories
    {
        Audi mAudi;

        public SelectiveDrive(Audi pAudi)
        {
            this.mAudi = pAudi;
        }

        public override String getDescription()
        {
            return mAudi.getDescription() + "\nOption: Audi drive select package - 2950.00";
        }

        public override double cost()
        {
            return 2950.00 + mAudi.cost();
        }
    }
}
