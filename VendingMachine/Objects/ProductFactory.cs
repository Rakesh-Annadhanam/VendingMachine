using System;
using VendingMachine.Interfaces;
using VendingMachine.Objects.Products;

namespace VendingMachine.Objects
{
    public class ProductFactory:IProductFactory
    {
        public ProductFactory()
        {
        }

        public Product GetProduct(string name)
        {
            if(name == "coke")
            {
                return new CokeProduct();
            }
            else
            {
                return new FantaProduct();
            }
        }
    }
}
