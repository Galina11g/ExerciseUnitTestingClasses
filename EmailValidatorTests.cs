using NUnit.Framework;
using System.ComponentModel.DataAnnotations;

namespace TestApp.UnitTests;

public class EmailValidatorTests
{
    
    [TestCase("ivan_ivanov@softuni.bg")]
    [TestCase("peter_petrov@abv.bg")]
    [TestCase("angel+123@yahoo.com")]
    public void Test_ValidEmails_ReturnsTrue(string email)
    {
        // Arrange


        // Act
        bool result = EmailValidator.IsValidEmail(email);

        // Assert
        Assert.That(result, Is.True);
    }

    [TestCase("ivan ivanov@softuni.bg")]
    [TestCase("Invalid e-mail")]
    [TestCase("valid%mail@in_valid.domain")]
    public void Test_InvalidEmails_ReturnsFalse(string email)
    {
        // Arrange

        // Act
        bool result = EmailValidator.IsValidEmail(email);
        
        // Assert
        Assert.That(result, Is.False);
    }
}
