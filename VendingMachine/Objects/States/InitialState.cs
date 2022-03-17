using System;
using VendingMachine.Interfaces;

namespace VendingMachine.Objects.States
{
    public class InitialState: IState
    {
        public InitialState()
        {
        }

        public void Act(VendingMachineCls machine)
        {
            machine.PromptToSelectProduct();
        }
    }
}
