namespace Todo.Domain.Shared
{
    public class GenericCommandResult : ICommandResult
    {
        public GenericCommandResult() { }

        public GenericCommandResult(string message, object data)
        {
            Message = message;
            Data = data;
        }

        public string Message { get; set; }
        public object Data { get; set; }
    }
}