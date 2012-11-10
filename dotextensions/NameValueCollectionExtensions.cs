#region File Info

// Solution: dotextensions
// Project: dotextensions
// 
// Filename: NameValueCollectionExtensions.cs
// Created: 11/09/2012 [8:10 PM]
// Modified: 11/09/2012 [8:11 PM]

#endregion

using System.Linq;
using System.Collections.Specialized;

namespace dotextensions
{
  /// <summary>
  /// NameValueCollection utilities.
  /// </summary>
  public static class NameValueCollectionExtensions
  {
    /// <summary>
    /// Determines whether a NameValueCollection contains a given key.
    /// </summary>
    /// <param name="nvc">The collection to search from.</param>
    /// <param name="key">The key to search for.</param>
    /// <returns>Returns true if the collection contains the given key.</returns>
    public static bool ContainsKey(this NameValueCollection nvc, string key)
    {
      return nvc.Get(key) != null || nvc.AllKeys.Contains(key);
    }
  }
}