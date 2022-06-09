using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IAU.WebApp
{
    public class ServiceParameterObject
    {
        public class ServiceParameterObject
        {
            public ServiceParameterObject()
            {

            }
            public ServiceParameterObject(string _k, string _v)
            {
                this.Key = _k;
                this.Value = _v;
            }

            public string Key { get; set; }
            public string Value { get; set; }

        }
    }
}
