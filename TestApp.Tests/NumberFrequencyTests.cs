using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class NumberFrequencyTests
{
    [Test]
    public void Test_CountDigits_ZeroNumber_ReturnsEmptyDictionary()
    {
        // Arrange
        int number = 0;

        // Act
        Dictionary<int, int> result = NumberFrequency.CountDigits(number);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_CountDigits_SingleDigitNumber_ReturnsDictionaryWithSingleEntry()
    {
        // Arrange
        int number = 6;

        // Act
        Dictionary<int, int> result = NumberFrequency.CountDigits(number);

        // Assert
        Assert.AreEqual(1, result.Count);
        Assert.IsTrue(result.ContainsKey(number));
        Assert.AreEqual(1, result[number]);
    }

    [Test]
    public void Test_CountDigits_MultipleDigitNumber_ReturnsDictionaryWithDigitFrequencies()
    {
        // Arrange
        int number = 1223334444;

        // Act
        Dictionary<int, int> result = NumberFrequency.CountDigits(number);

        // Assert
        Assert.AreEqual(4, result.Count);
        Assert.AreEqual(1, result[1]);
        Assert.AreEqual(2, result[2]);
        Assert.AreEqual(3, result[3]);
        Assert.AreEqual(4, result[4]);
    }

    [Test]
    public void Test_CountDigits_NegativeNumber_ReturnsDictionaryWithDigitFrequencies()
    {
        // Arrange
        int number = -23232;

        // Act
        Dictionary<int, int> result = NumberFrequency.CountDigits(number);

        // Assert
        Assert.AreEqual(2, result.Count);
        Assert.AreEqual(2, result[3]);
        Assert.AreEqual(3, result[2]);
    }
}
