using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPhotoshop.Filters
{
    class LightningParameters:IParameters
    {
        public double Coefficient { get; set; }

        public ParameterInfo[] GetParameters()
        {
            return new[]
                   {
                       new ParameterInfo()
                       {
                           Name = "Коэффициент",
                           MaxValue = 10,
                           MinValue = 0,
                           Increment = 0.1,
                           DefaultValue = 1
                       }
                   };
        }

        public IParameters ParseParameters( double[] parameters )
        {
            Coefficient = parameters[ 0 ];
            return this;
        }
    }
}
