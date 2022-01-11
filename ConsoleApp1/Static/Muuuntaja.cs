using System;
using System.Collections.Generic;
using System.Text;

namespace Static
{
    class Muuuntaja
    {
        public static float KmToMiles(float km)
        {
            float milesArvo = 0.621371192f;
            return km * milesArvo;
        }
    }
}
