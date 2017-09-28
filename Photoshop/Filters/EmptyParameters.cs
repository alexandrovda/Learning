using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPhotoshop.Filters
{
    class EmptyParameters:IParameters
    {
        public ParameterInfo[] GetParameters()
        {
            return new ParameterInfo[0];
        }

        public void SetValues( double[] parameters )
        {
        }
    }
}
