using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator1
{
    public class CondimentDecorator:ICoffee
    {
        ICoffee _coffee;

        protected string _name = "undefined condiment";
        protected double _price = 0.0;

        public CondimentDecorator(ICoffee coffee)
        {
            _coffee = coffee;
        }

        public string GetDescription()
        {
            return string.Format("{0}, {1}", _coffee.GetDescription(), _name);
        }

        public double GetCost()
        {
            return _coffee.GetCost() + _price;
        }
    }
}
