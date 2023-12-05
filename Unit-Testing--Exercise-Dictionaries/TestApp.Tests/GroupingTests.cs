﻿using NUnit.Framework;

using System;
using System.Collections.Generic;

namespace TestApp.Tests;

public class GroupingTests
{
    // TODO: finish test
    [Test]
    public void Test_GroupNumbers_WithEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<int> emptyList = new List<int>();

        // Act
        string result = Grouping.GroupNumbers(emptyList);

        // Assert
        Assert.That(result, Is.EqualTo(string.Empty));
    }

    [Test]
    public void Test_GroupNumbers_WithEvenAndOddNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> evenOddNumbersList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Act
        string result = Grouping.GroupNumbers(evenOddNumbersList);

        // Assert
        Assert.That(result, Is.EqualTo("Odd numbers: 1, 3, 5, 7, 9\r\nEven numbers: 2, 4, 6, 8, 10"));

    }

    [Test]
    public void Test_GroupNumbers_WithOnlyEvenNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> onlyEvenNumbersList = new List<int> { 2, 4, 6, 8, 10 };

        // Act
        string result = Grouping.GroupNumbers(onlyEvenNumbersList);

        // Assert
        Assert.That(result, Is.EqualTo("Even numbers: 2, 4, 6, 8, 10"));
    }

    [Test]
    public void Test_GroupNumbers_WithOnlyOddNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> onlyOddNumbersList = new List<int> { 1, 3, 5, 7, 9 };

        // Act
        string result = Grouping.GroupNumbers(onlyOddNumbersList);

        // Assert
        Assert.That(result, Is.EqualTo("Odd numbers: 1, 3, 5, 7, 9"));
    }

    [Test]
    public void Test_GroupNumbers_WithNegativeNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> negativeNumbersList = new List<int> { -2, -4, -6, -8, -10 };

        // Act
        string result = Grouping.GroupNumbers(negativeNumbersList);

        // Assert
        Assert.That(result, Is.EqualTo("Even numbers: -2, -4, -6, -8, -10"));
    }
}