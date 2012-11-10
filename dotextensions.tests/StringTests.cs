#region File Info

// Solution: dotextensions
// Project: dotextensions.tests
// 
// Filename: StringTests.cs
// Created: 11/09/2012 [8:38 PM]
// Modified: 11/09/2012 [9:13 PM]

#endregion

using Xunit;

namespace dotextensions.tests
{
  public class StringTests
  {
    private const string SomeString = "apple orange banana";

    [Fact]
    public void ReturnsTrueIfStringContainsValue()
    {
      var values = new[] {"mango", "orange"};
      Assert.True(SomeString.ContainsAny(values));
    }

    [Fact]
    public void ReturnsFalseIfStringDoesntContainValue()
    {
      var values = new[] {"strawberry", "mango"};
      Assert.False(SomeString.ContainsAny(values));
    }
  }
}