using System;
using Todo.Domain.Commands;
using Xunit;

namespace Todo.Domain.Tests.HandlerTests
{
    public class CreateTodoHandlerTests
    {
        [Fact]
        public void CreateTodoCommand_TodoInvalido_DeveRetornarErros()
        {
            Assert.True(false);
        }
    }
}