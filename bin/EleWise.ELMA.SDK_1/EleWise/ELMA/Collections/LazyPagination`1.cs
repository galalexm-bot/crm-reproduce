// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Collections.LazyPagination`1
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
  /// Executes an IQueryable in order to created a paged set of objects.
  /// The query is not executed until the LazyPagination is enumerated or one of its properties is invoked.
  /// The results of the query are cached.
  /// </summary>
  /// <typeparam name="T">Type of objects in the collection.</typeparam>
  public class LazyPagination<T> : IPagination<T>, IPagination, IEnumerable, IEnumerable<T>
  {
    /// <summary>Default page size.</summary>
    public const int DefaultPageSize = 20;
    private IList<T> results;
    private int totalItems;
    private static object GxC7QpmQyQPXPb5wVs4;

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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 0 : 0;
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

    /// <summary>The query to execute.</summary>
    public IQueryable<T> Query { get; protected set; }

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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 0 : 0;
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

    /// <summary>
    /// Creates a new instance of the <see cref="T:EleWise.ELMA.Collections.LazyPagination`1" /> class.
    /// </summary>
    /// <param name="query">The query to page.</param>
    /// <param name="pageNumber">The current page number.</param>
    /// <param name="pageSize">Number of items per page.</param>
    public LazyPagination(IQueryable<T> query, int pageNumber, int pageSize)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.PageNumber = pageNumber;
      this.PageSize = pageSize;
      this.Query = query;
    }

    IEnumerator<T> IEnumerable<T>.GetEnumerator() => (IEnumerator<T>) new LazyPagination<T>.\u003CSystem\u002DCollections\u002DGeneric\u002DIEnumerable\u003CT\u003E\u002DGetEnumerator\u003Ed__16(0)
    {
      \u003C\u003E4__this = this
    };

    /// <summary>
    /// Executes the query if it has not already been executed.
    /// </summary>
    protected void TryExecuteQuery()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.results == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 2:
            goto label_6;
          case 3:
            this.results = this.ExecuteQuery();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 1 : 2;
            continue;
          case 4:
            goto label_5;
          default:
            this.totalItems = this.Query.Count<T>();
            num = 3;
            continue;
        }
      }
label_6:
      return;
label_5:
      return;
label_2:;
    }

    /// <summary>Calls Queryable.Skip/Take to perform the pagination.</summary>
    /// <returns>The paged set of results.</returns>
    protected virtual IList<T> ExecuteQuery() => (IList<T>) this.Query.Skip<T>((this.PageNumber - 1) * this.PageSize).Take<T>(this.PageSize).ToList<T>();

    public IEnumerator GetEnumerator() => (IEnumerator) ((IEnumerable<T>) this).GetEnumerator();

    public int TotalItems
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              this.TryExecuteQuery();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 0 : 0;
              continue;
            default:
              goto label_3;
          }
        }
label_3:
        return this.totalItems;
      }
    }

    public int TotalPages => (int) Math.Ceiling((double) this.TotalItems / (double) this.PageSize);

    public int FirstItem
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              this.TryExecuteQuery();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 0;
              continue;
            default:
              goto label_2;
          }
        }
label_2:
        return (this.PageNumber - 1) * this.PageSize + 1;
      }
    }

    public int LastItem => this.FirstItem + this.results.Count - 1;

    public bool HasPreviousPage => this.PageNumber > 1;

    public bool HasNextPage => this.PageNumber < this.TotalPages;

    internal static bool rpOmKRmC4qs42w0Mksv() => LazyPagination<T>.GxC7QpmQyQPXPb5wVs4 == null;

    internal static object jVsdFfmv5pwMiAtTkuq() => LazyPagination<T>.GxC7QpmQyQPXPb5wVs4;
  }
}
