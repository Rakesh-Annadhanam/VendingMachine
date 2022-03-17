using System;
using VendingMachine.Interfaces;
using VendingMachine.Objects.States;

namespace VendingMachine.Objects
{
    public class StateFactory: IStateFactory
    {
        public StateFactory()
        {
        }

        public IState GetStateInstance(string stateName)
        {
            if(stateName == "AskMoneyState")
            {
                return new AskMoneyState();
            }
            else if(stateName == "DeliverProductState")
            {
                return new DeliverProductState();
            }
            else
            {
                return new InitialState();
            }
            
        }
    }
}
