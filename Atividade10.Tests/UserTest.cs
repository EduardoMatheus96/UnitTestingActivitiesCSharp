namespace Atividade10.Tests;

public class UserTest
{
    [Fact]
    public void Constructor_WhenCalled_CreatesUserWithValidNameAndEmail()
    {
        // Arrange
        string name = "name";
        string email = "email";

        // Act
        User user = new User(name, email);

        // Assert
        Assert.Equal(name, user.Name);
        Assert.Equal(email, user.Email);
    }
}

