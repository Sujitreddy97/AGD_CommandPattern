using System.Collections;
using System.Collections.Generic;
using System.Windows.Input;

public class CommandInvoker
{
    private Stack<ICommand> commandRegistry = new Stack<ICommand>();

    public void ProcessCommand(ICommand commandToProcess)
    {
        ExecuteCommand(commandToProcess);
        RegisterCommand(commandToProcess);
    }

    public void ExecuteCommand(ICommand commandToExecute) => commandToExecute.Execute(commandToExecute);

    public void RegisterCommand(ICommand commandToRegister) => commandRegistry.Push(commandToRegister);
}
