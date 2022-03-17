using System;
namespace VendingMachine.Objects.Products
{
    public class FantaProduct:Product
    {
        public FantaProduct()
        {
        }

        public override int Price => 15;

        public override string Name => "fanta";
    }
}
