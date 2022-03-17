using System;
using VendingMachine.Interfaces;

namespace VendingMachine.Objects.States
{
    public class DeliverProductState: IState
    {
        public DeliverProductState()
        {
        }

        public void Act(VendingMachineCls machine)
        {
            machine.DispenseProduct();
        }
    }
}
