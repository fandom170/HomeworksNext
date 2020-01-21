using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    class Country
    {
        private String _name;
        private Boolean _isTelenorSupported;

        public Country(String name, Boolean telenorSupported)
        {
            _name = name;
            _isTelenorSupported = telenorSupported;
        }

        //add auto property
        public string Name 
        { 
            get { return _name; }
            set { _name = value; }
        }

        public Boolean IsTelenorsupported
        {
            get { return _isTelenorSupported; }
            set {_isTelenorSupported = value;}
        }
    }
}