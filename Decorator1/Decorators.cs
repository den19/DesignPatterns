using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator1
{
    public class MilkDecorator : CondimentDecorator
    {
        public MilkDecorator(ICoffee coffee)
            : base(coffee)
        {
            _name = "Milk";
            _price = 0.19;
        }
    }

    public class ChocolateDecorator : CondimentDecorator
    {
        public ChocolateDecorator(ICoffee coffee)
            : base(coffee)
        {
            _name = "Chocolate";
            _price = 0.29;
        }
    }
}
