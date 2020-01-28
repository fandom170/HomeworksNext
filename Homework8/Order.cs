using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    public class Order : Item<int>
    {
        private int _goodsAmount;
        private string _goodType;
        private Customer _customer;
    }
}
