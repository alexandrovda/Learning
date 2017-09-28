using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPhotoshop.Filters
{
    public abstract class ParametrisedFilter<T>:IFilter
        where T: IParameters, new()
    {
        public ParameterInfo[] GetParameters()
        {
            return new T().GetParameters();
        }

        public Photo Process( Photo original, double[] values )
        {
            var parameters = new T();
            parameters.SetValues( values );

            return Process( original, parameters );
        }

        protected abstract Photo Process( Photo original, T parameters );
    }
}
