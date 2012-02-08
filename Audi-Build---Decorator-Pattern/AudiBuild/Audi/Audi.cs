using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AudiBuild
{
    public abstract class Audi
    {
        private String description = "Some Audi";

        public virtual String getDescription()
        {
            return description;
        }

        public void setDescription(String pDesc)
        {
            description = pDesc;
        }

        public abstract double cost();
    }
}
