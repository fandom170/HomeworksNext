using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    public abstract class Item <T>
    {
        private T _id;

        public T Id 
        {
            get { return _id; }
            set { _id = value; }
        }
    }
}
