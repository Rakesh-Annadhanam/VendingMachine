using System;
using VendingMachine.Objects;

namespace VendingMachine.Interfaces
{
    public interface IProductFactory
    {
         Product GetProduct(string name);
    }
}
