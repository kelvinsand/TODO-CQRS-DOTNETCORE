using System;
using Todo.Domain.Commands;
using Xunit;

namespace Todo.Domain.Tests.CommandTests
{
    public class CreateTodoCommandTests
    {
        [Fact]
        public void CreateTodoCommand_TodoInvalido_DeveRetornarErros()
        {
            var command = new CreateTodoCommand("", "", DateTime.Now);
            command.Validate();
            Assert.False(command.Valid);
            //testar quantidade de notificações
        }

        [Fact]
        public void CreateTodoCommand_TodoValido_DeveRetornarTodo()
        {
            var command = new CreateTodoCommand("Teste", "kelvin", DateTime.Now);
            command.Validate();
            Assert.True(command.Valid);
        }
    }
}