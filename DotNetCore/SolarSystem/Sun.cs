using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarSystem
{
    public class Sun
    {
        private static Sun sun = new Sun();
        public static Sun GetInstance()
        {
                return sun;
        }
        private Sun(){}
    }
}
