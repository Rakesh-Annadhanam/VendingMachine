using System;
namespace VendingMachine.Objects
{
    public abstract class Product
    {
        public Product()
        {
        }

        public abstract int Price { get; }

        public abstract string Name { get; }
    }
}
