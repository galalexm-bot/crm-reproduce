// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Collections.DelegatePagination`1
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
  /// Executes an delegate method in order to created a paged set of objects.
  /// The query is not executed until the DelegatePagination is enumerated or one of its properties is invoked.
  /// </summary>
  /// <typeparam name="T">Type of objects in the collection.</typeparam>
  public class DelegatePagination<T> : IPagination<T>, IPagination, IEnumerable, IEnumerable<T>
  {
    private IList<T> _results;
    private object _additionalArgs;
    private bool _doRefresh;
    private int _totalItems;
    private int _pageNumber;
    private int _pageSize;
    private static object i4a5WYmF5gU3BgVdM0j;

    /// <summary>Event raised when query is performed.</summary>
    public event DoQueryDelegate<T> DoQuery;

    /// <summary>
    /// Creates a new instance of the <see cref="T:EleWise.ELMA.Collections.DelegatePagination`1" /> class.
    /// </summary>
    /// <param name="method">The method invoked to fetch data.</param>
    /// <param name="pageNumber">The current page number.</param>
    /// <param name="pageSize">Number of items per page.</param>
    /// <param name="additionalArgs">Additional data passed in the AdditionalArgs</param>
    public DelegatePagination(
      DoQueryDelegate<T> method,
      int pageNumber,
      int pageSize,
      object additionalArgs)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this._doRefresh = true;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.DoQuery = method;
      this._pageNumber = pageNumber;
      this._pageSize = pageSize;
      this._additionalArgs = additionalArgs;
    }

    /// <summary>Raises the event to execute the query.</summary>
    /// <param name="e"></param>
    protected virtual void OnDoQuery(PagingQueryEventArgs e)
    {
      int num1 = 2;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_3;
            case 1:
              goto label_4;
            case 2:
              if (this.DoQuery != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 1 : 0;
                continue;
              }
              goto label_9;
            case 3:
              this._doRefresh = false;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 0;
              continue;
            case 4:
              this.TotalItems = e.TotalItems;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 3 : 3;
              continue;
            default:
              goto label_10;
          }
        }
label_4:
        this._results = (IList<T>) this.DoQuery((object) this, e).ToList<T>();
        num1 = 4;
      }
label_3:
      return;
label_10:
      return;
label_9:;
    }

    public IEnumerator<T> GetEnumerator()
    {
      this.TryExecuteQuery();
      return this._results.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator() => (IEnumerator) this.GetEnumerator();

    protected void TryExecuteQuery()
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_5;
          case 1:
            this.OnDoQuery(new PagingQueryEventArgs()
            {
              PageNumber = this.PageNumber,
              PageSize = this.PageSize,
              AdditionalArgs = this._additionalArgs
            });
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            if (!this._doRefresh)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 1 : 2;
              continue;
            }
            goto case 1;
          default:
            goto label_7;
        }
      }
label_5:
      return;
label_2:
      return;
label_7:;
    }

    public int PageNumber
    {
      get => this._pageNumber;
      set
      {
        int num = 3;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_2;
            case 2:
              this._doRefresh = true;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 0 : 0;
              continue;
            case 3:
              if (value != this._pageNumber)
              {
                num = 2;
                continue;
              }
              goto label_7;
            default:
              this._pageNumber = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 1 : 1;
              continue;
          }
        }
label_2:
        return;
label_7:;
      }
    }

    public int PageSize
    {
      get => this._pageSize;
      set
      {
        int num = 3;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this._pageSize = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 0 : 0;
              continue;
            case 2:
              this._doRefresh = true;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 0 : 1;
              continue;
            case 3:
              if (value != this._pageSize)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 2 : 2;
                continue;
              }
              goto label_7;
            default:
              goto label_8;
          }
        }
label_2:
        return;
label_8:
        return;
label_7:;
      }
    }

    public int TotalItems
    {
      get => this._totalItems;
      private set
      {
        int num = 3;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this._totalItems = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 0;
              continue;
            case 2:
              this._doRefresh = true;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 1 : 1;
              continue;
            case 3:
              if (value != this._totalItems)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 0 : 2;
                continue;
              }
              goto label_7;
            default:
              goto label_8;
          }
        }
label_2:
        return;
label_8:
        return;
label_7:;
      }
    }

    public object AdditionalArgs
    {
      get => this._additionalArgs;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (value != this._additionalArgs)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 0 : 0;
                continue;
              }
              goto label_7;
            case 2:
              this._additionalArgs = value;
              num = 3;
              continue;
            case 3:
              goto label_2;
            default:
              this._doRefresh = true;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 2;
              continue;
          }
        }
label_2:
        return;
label_7:;
      }
    }

    public int TotalPages
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 0;
              continue;
            default:
              goto label_3;
          }
        }
label_3:
        return (int) Math.Ceiling((double) this.TotalItems / (double) this.PageSize);
      }
    }

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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 0 : 0;
              continue;
            default:
              goto label_2;
          }
        }
label_2:
        return (this.PageNumber - 1) * this.PageSize + 1;
      }
    }

    public int LastItem
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 0 : 0;
              continue;
            default:
              goto label_3;
          }
        }
label_3:
        return this.FirstItem + this._results.Count - 1;
      }
    }

    public bool HasPreviousPage
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 0;
              continue;
            default:
              goto label_3;
          }
        }
label_3:
        return this.PageNumber > 1;
      }
    }

    public bool HasNextPage
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 0 : 0;
              continue;
            default:
              goto label_2;
          }
        }
label_2:
        return this.PageNumber < this.TotalPages;
      }
    }

    internal static bool VFdDxBmBvlYrUHmBFZx() => DelegatePagination<T>.i4a5WYmF5gU3BgVdM0j == null;

    internal static object P5gniomWi69bqWYtpy6() => DelegatePagination<T>.i4a5WYmF5gU3BgVdM0j;
  }
}
