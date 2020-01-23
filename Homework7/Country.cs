using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    class Country
    {
        private String Name {get; set;}
        private Boolean IsTelenorSupported;

        public Country(String name, Boolean telenorSupported)
        {
            Name = name;
            IsTelenorSupported = telenorSupported;
        }
    }
}