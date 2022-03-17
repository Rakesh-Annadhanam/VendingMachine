using System;
namespace VendingMachine.Interfaces
{
    public interface IStateFactory
    {
         IState GetStateInstance(string stateName);
    }
}
