using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.creational.factory
{
    internal class MenuFactory
    {
        public IMenu CreateOrder(string type) {
            switch (type.ToLower())
            {
                case "ale":
                    return new Ale();
                case "beer":
                    return new Beer();
                case "wine":
                    return new Wine();
                case "tea": 
                    return new Tea();
                case "coffee":
                    return new Coffee();
                default:
                    throw new ArgumentException("Error");
            }
        }
    }
}
