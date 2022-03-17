using System;
namespace VendingMachine.Objects.Products
{
    public class CokeProduct:Product
    {
        public CokeProduct()
        {
        }

        public override int Price => 20;

        public override string Name => "coke";
    }
    
}
