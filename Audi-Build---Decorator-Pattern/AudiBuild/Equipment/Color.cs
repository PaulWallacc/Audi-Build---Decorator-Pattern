using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AudiBuild
{
    public class Color : Accessories
    {
        Audi mAudi;
        String mColor;

        public Color(Audi pAudi, String pColor)
        {
            this.mAudi = pAudi;
            this.mColor = pColor;
        }

        public override String getDescription()
        {
            if (mColor == "Moonlight Blue Metallic" || mColor == "Monsoon Gray Metallic" ||
                mColor == "Ice Silver Metallic" || mColor == "Phantom Balck Pearl Effect" ||
                mColor == "Glacier White Metallic" || mColor == "Moonlight Blue Metallic")
            {
                return mAudi.getDescription() + "\nPaint: " + mColor + ": - $475.00";
            }
            else
            {
                return mAudi.getDescription() + "\nDefault Paint Color: Brilliant Black";
            }
        }

        public override double cost()
        {

            if (mColor == "Moonlight Blue Metallic" || mColor == "Monsoon Gray Metallic" ||
                mColor == "Ice Silver Metallic" || mColor == "Phantom Balck Pearl Effect" ||
                mColor == "Glacier White Metallic" || mColor == "Moonlight Blue Metallic")
            {
                //Add 475 for paint
                return 475.00 + mAudi.cost();
            }
            else
            {
                // Nothing added
                return mAudi.cost();
            }
        }
    }
}
