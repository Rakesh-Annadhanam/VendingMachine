using System;
using VendingMachine.Objects;

namespace VendingMachine
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var stateFactory = new StateFactory();
            var productFactory = new ProductFactory();
            var machine = new VendingMachineCls(productFactory, stateFactory);
        }

       
    }
}
