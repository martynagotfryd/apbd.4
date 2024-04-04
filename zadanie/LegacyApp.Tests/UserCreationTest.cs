
namespace LegacyApp.Tests;

public class UserCreationTest
{
    [Fact]
    public void AddUser_ReturnsFalseWhenFirstNameIsEmpty()
    {
        // Arrange
        var userService = new UserService(); 
        
        // Act
        var result = userService.AddUser(
            null, // First name is null
            "Smith",
            "mmm@mm.com",
            DateTime.Parse("2000-01-01"),
            1
        );

        // Assert
        Assert.False(result);
    }
}