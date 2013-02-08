#region File Info

// Solution: dotextensions
// Project: dotextensions
// 
// Filename: StringExtensions.cs
// Created: 11/09/2012 [8:27 PM]
// Modified: 11/09/2012 [8:27 PM]

#endregion

using System.Linq;

namespace dotextensions
{
  /// <summary>
  /// Commong string utilities.
  /// </summary>
  public static class StringExtensions
  {
    /// <summary>
    /// Determines whether a string contains any values from a collection.
    /// </summary>
    /// <param name="str">The string to be searched.</param>
    /// <param name="values">The values to search for.</param>
    /// <returns>Returns true if the string contains any of the specified values.</returns>
    public static bool ContainsAny(this string str, params string[] values)
    {
      return !string.IsNullOrEmpty(str) && values.Any() && values.Any(str.Contains);
    }
    
    public static bool Contains(this string str, string toCheck, StringComparison comp) 
    {
      return str.IndexOf(toCheck, comp) >= 0;
    }
  }
}
