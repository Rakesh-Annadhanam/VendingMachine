using System;
using VendingMachine.Interfaces;

namespace VendingMachine.Objects
{
    public class VendingMachineCls
    {
        private IProductFactory _productFactory { get; set; }
        private IStateFactory _stateFactory { get; set; }
        Product SelectedProduct { get; set; }
        int InsertedMoney { get; set; }

        public VendingMachineCls(IProductFactory productFactory,IStateFactory stateFactory)
        {
            _productFactory = productFactory;
            _stateFactory = stateFactory;
            CreateAndInvokeState("InitialState");
        }

  
        private void CreateAndInvokeState(string stateName)
        {
            var state = _stateFactory.GetStateInstance(stateName);
            state.Act(this);
        }

        public void PromptToSelectProduct()
        {
            Console.WriteLine("Please enter the product you want...");
            var productname = Console.ReadLine();
            var product = _productFactory.GetProduct(productname);
            SelectProduct(product);
        }

        public void TakeMoney()
        {
            Console.WriteLine("Enter coin value to insert in next line.......");
            InsertedMoney  += Int32.Parse(Console.ReadLine());
            if (InsertedMoney >= SelectedProduct.Price) 
                CreateAndInvokeState("DeliverProductState");
            else
                CreateAndInvokeState("AskMoneyState");
        }

        private void SelectProduct(Product product)
        {
            SelectedProduct = product;
            Console.WriteLine("Select product - " + SelectedProduct.Name);
            CreateAndInvokeState("AskMoneyState");
        }

        private void RenderChange()
        {
            Console.WriteLine("Change is rendered...");
        }

        public void DispenseProduct()
        {
            Console.WriteLine($"{SelectedProduct.Name} Product is Dispensed");
            RenderChange();
            SelectedProduct = null;
            CreateAndInvokeState("InitialState");
        }

        
    }
}
