using NSubstitute;
using Xunit;

namespace Atividade07.Tests
{
    public class DatabaseTests
    {
        [Fact]
        public void SaveUser_WhenCalled_InvokesSaveOnDatabase()
        {
            // Arrange
            var database = Substitute.For<IDatabase>();
            var user = new User ("Eduardo","eduardo@email.com");
            
            // Act
            database.SaveUser(user);
            
            // Assert
            database.Received(1).SaveUser(user);
        }
    }
}
