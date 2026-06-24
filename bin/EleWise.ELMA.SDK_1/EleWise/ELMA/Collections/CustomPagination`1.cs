// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Collections.CustomPagination`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.Collections
{
  /// <summary>
  /// Implementation of IPagination that wraps a pre-paged data source.
  /// </summary>
  public class CustomPagination<T> : IPagination<T>, IPagination, IEnumerable, IEnumerable<T>
  {
    private readonly IList<T> _dataSource;
    private static object J1HZTv0YsKQ1xE9CcQo;

    /// <summary>Creates a new instance of CustomPagination</summary>
    /// <param name="dataSource">A pre-paged slice of data</param>
    /// <param name="pageNumber">The current page number</param>
    /// <param name="pageSize">The number of items per page</param>
    /// <param name="totalItems">The total number of items in the overall datasource</param>
    public CustomPagination(
      IEnumerable<T> dataSource,
      int pageNumber,
      int pageSize,
      int totalItems)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this._dataSource = (IList<T>) dataSource.ToList<T>();
      this.PageNumber = pageNumber;
      this.PageSize = pageSize;
      this.TotalItems = totalItems;
    }

    public IEnumerator<T> GetEnumerator() => this._dataSource.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => (IEnumerator) this.GetEnumerator();

    public int PageNumber
    {
      get => this.\u003CPageNumber\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CPageNumber\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    public int PageSize
    {
      get => this.\u003CPageSize\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CPageSize\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    public int TotalItems
    {
      get => this.\u003CTotalItems\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CTotalItems\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    public int TotalPages => (int) Math.Ceiling((double) this.TotalItems / (double) this.PageSize);

    public int FirstItem => (this.PageNumber - 1) * this.PageSize + 1;

    public int LastItem => this.FirstItem + this._dataSource.Count - 1;

    public bool HasPreviousPage => this.PageNumber > 1;

    public bool HasNextPage => this.PageNumber < this.TotalPages;

    internal static bool vdWVky0LkI7JTkdlaD8() => CustomPagination<T>.J1HZTv0YsKQ1xE9CcQo == null;

    internal static object AmyF1d0UJFY4d1aWpxv() => CustomPagination<T>.J1HZTv0YsKQ1xE9CcQo;
  }
}
