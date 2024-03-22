using System.Data;

namespace LegacyApp.Tests;

public class UserServiceTest
{
    [Fact]
    public void AddUser_ReturnsFalseWhenFirstNameIsEmpty()
    {
        // Arrange
        var userService = new UserService();
        
        // Act
        var result = userService.AddUser(
            null,
            "Smith",
            "mmm@mm",
            DateTime.Parse("2000-01-01"),
            1
            );

        // Assert
        Assert.False(result);
    }
    [Fact]
    public void AddUser_ThrowsExceptionIfClientNotExists()
    {
        // Arrange
        var userService = new UserService();
        
        // Act
        Action action = () => userService.AddUser(
            "Joe",
            "Smith",
            "mmm@mm",
            DateTime.Parse("2000-01-01"),
            100
        );

        // Assert
        Assert.Throws<ArgumentException>(action);
    }
}