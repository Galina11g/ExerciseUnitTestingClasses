﻿using NUnit.Framework;

namespace TestApp.UnitTests;

public class MatchDatesTests
{
    // TODO: finish the test
    [Test]
    public void Test_Match_ValidDate_ReturnsExpectedResult()
    {
        // Arrange
        string input = "31-Dec-2022 random text";
        string expected = "Day: 31, Month: Dec, Year: 2022";

        // Act
        string result = MatchDates.Match(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    // TODO: finish the test
    [Test]
    public void Test_Match_NoMatch_ReturnsEmptyString()
    {
        // Arrange
        string input = "Invalid date format";
        string expected = string.Empty;

        // Act
        string result = MatchDates.Match(input);

        // Assert
        Assert.That(result, Is.EqualTo(string.Empty));
    }

    [Test]
    public void Test_Match_MultipleMatches_ReturnsFirstMatch()
    {
        // Arrange
        string input = "11.May.2024, 31-Dec-2022, 11-May-1988, random text";
        string expected = "Day: 11, Month: May, Year: 2024";

        // Act
        string result = MatchDates.Match(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Match_EmptyString_ReturnsEmptyString()
    {
        // Arrange
        string input = "";
        string expected = "";

        // Act
        string result = MatchDates.Match(input);

        // Assert
        Assert.That(result, Is.EqualTo(string.Empty));
    }

    [Test]
    public void Test_Match_NullInput_ThrowsArgumentException()
    {
        // Arrange
        string? input = null;
        string expected = "";


        // Act & Assert
        Assert.That(() => MatchDates.Match(input), Throws.ArgumentException);
    }
}
