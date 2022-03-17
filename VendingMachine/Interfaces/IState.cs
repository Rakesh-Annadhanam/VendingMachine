using System;
using VendingMachine.Objects;
namespace VendingMachine.Interfaces
{
    public interface IState
    {

        void Act(VendingMachineCls machine);
    }
}
