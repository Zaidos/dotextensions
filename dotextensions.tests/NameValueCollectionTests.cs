#region File Info

// Solution: dotextensions
// Project: dotextensions.tests
// 
// Filename: NameValueCollectionTests.cs
// Created: 11/09/2012 [9:14 PM]
// Modified: 11/09/2012 [9:15 PM]

#endregion

using System.Collections.Specialized;
using Xunit;

namespace dotextensions.tests
{
  public class NameValueCollectionTests
  {
    public NameValueCollection Collection = new NameValueCollection();

    [Fact]
    public void ReturnsTrueIfCollectionContainsKey()
    {
      Collection.Add("key", "value");
      Assert.True(Collection.ContainsKey("key"));
    }

    [Fact]
    public void ReturnsFalseIfCollectionDoesntContainKey()
    {
      Assert.False(Collection.ContainsKey("fakeKey"));
    }
  }
}