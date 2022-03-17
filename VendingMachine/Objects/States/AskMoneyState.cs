using System;
using VendingMachine.Interfaces;

namespace VendingMachine.Objects.States
{
    public class AskMoneyState:IState
    {
        public AskMoneyState()
        {
        }

        public void Act(VendingMachineCls machine)
        {
            machine.TakeMoney();
        }
    }
}
