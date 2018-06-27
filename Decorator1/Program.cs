using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator1
{
    class Program
    {
        static void Main(string[] args)
        {
            var beverages = new List<ICoffee>
            {
                new ChocolateDecorator(new Filtered()),
                new ChocolateDecorator(new MilkDecorator(new Espresso()))
            };

            var filteredWithChocolate = beverages.First();
            if (beverages[0].GetDescription() == filteredWithChocolate.GetDescription())
                Console.WriteLine("Ok");

            var espressoWithMilkAndChocolate = beverages.Skip(1).First();
            if (beverages[1].GetDescription() == espressoWithMilkAndChocolate.GetDescription())
                Console.WriteLine("Ok");

            if ((2.99 + 0.19 + 0.29) == espressoWithMilkAndChocolate.GetCost())
                Console.WriteLine("Ok");

        }
    }

    public class Filtered : ICoffee
    {
        public string GetDescription()
        {
            return "Filtered with care";
        }

        public double GetCost()
        {
            return 1.99;
        }
    }

    public class Espresso : ICoffee
    {
        public string GetDescription()
        {
            return "Espresso made with care";
        }

        public double GetCost()
        {
            return 2.99;
        }
    }
}
