// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Collections.PaginationHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.Collections
{
  /// <summary>Extension methods for creating paged lists.</summary>
  public static class PaginationHelper
  {
    /// <summary>
    /// Converts the specified IEnumerable into an IPagination using the default page size and returns the specified page number.
    /// </summary>
    /// <typeparam name="T">Type of object in the collection</typeparam>
    /// <param name="source">Source enumerable to convert to the paged list.</param>
    /// <param name="pageNumber">The page number to return.</param>
    /// <returns>An IPagination of T</returns>
    public static IPagination<T> AsPagination<T>(this IEnumerable<T> source, int pageNumber) => source.AsPagination<T>(pageNumber, 20);

    /// <summary>
    /// Converts the speciied IEnumerable into an IPagination using the specified page size and returns the specified page.
    /// </summary>
    /// <typeparam name="T">Type of object in the collection</typeparam>
    /// <param name="source">Source enumerable to convert to the paged list.</param>
    /// <param name="pageNumber">The page number to return.</param>
    /// <param name="pageSize">Number of objects per page.</param>
    /// <returns>An IPagination of T</returns>
    public static IPagination<T> AsPagination<T>(
      this IEnumerable<T> source,
      int pageNumber,
      int pageSize)
    {
      if (pageNumber < 1)
        throw new ArgumentOutOfRangeException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1939377524 ^ -1939353422), z2jc63fLkugS1X8Q9N.tE1kD1vbB(516838154 ^ 516878684));
      return (IPagination<T>) new LazyPagination<T>(source.AsQueryable<T>(), pageNumber, pageSize);
    }
  }
}
