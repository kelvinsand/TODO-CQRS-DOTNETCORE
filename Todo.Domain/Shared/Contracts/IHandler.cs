namespace Todo.Domain.Shared.Contracts
{
    public interface IHandler<TCommand> where TCommand : ICommand 
    {
        ICommandResult Handle(TCommand command);
    }
}