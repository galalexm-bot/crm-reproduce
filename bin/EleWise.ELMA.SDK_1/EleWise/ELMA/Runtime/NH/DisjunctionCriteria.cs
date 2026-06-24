// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.DisjunctionCriteria
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.SqlCommand;
using NHibernate.Transform;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace EleWise.ELMA.Runtime.NH
{
  /// <summary>
  /// Используется для того, чтобы можно было передать Criteria в метод, который добавляет в нее новые условия, при этом, чтобы результа можно было соединить через дизьюнкцию с другими подобными критериями
  /// Передо отправкой криетрия в функцию обязательно вызвать NewDisjunctionCriteria()
  /// </summary>
  public class DisjunctionCriteria : ICriteria, ICloneable
  {
    private readonly ICriteria criteria;
    private Disjunction disjunction;
    private Conjunction conjunction;
    private static DisjunctionCriteria DjY5NiWNxXZhc25VkGXk;

    /// <inheritdoc />
    public Task<IList> ListAsync(CancellationToken cancellationToken = default (CancellationToken)) => this.criteria.ListAsync(cancellationToken);

    /// <inheritdoc />
    public Task<object> UniqueResultAsync(CancellationToken cancellationToken = default (CancellationToken)) => this.criteria.UniqueResultAsync(cancellationToken);

    /// <inheritdoc />
    public Task ListAsync(IList results, CancellationToken cancellationToken = default (CancellationToken)) => (Task) DisjunctionCriteria.IE0sltWNyKkbOZsNjWgb((object) this.criteria, (object) results, cancellationToken);

    /// <inheritdoc />
    public Task<IList<T>> ListAsync<T>(CancellationToken cancellationToken = default (CancellationToken)) => this.criteria.ListAsync<T>(cancellationToken);

    /// <inheritdoc />
    public Task<T> UniqueResultAsync<T>(CancellationToken cancellationToken = default (CancellationToken)) => this.criteria.UniqueResultAsync<T>(cancellationToken);

    public DisjunctionCriteria(ICriteria criteria)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.criteria = criteria;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>
    /// Создает новый экземпляр коньюнкции в дизьюнкции, обязательно вызывать при отправки критерия в функцию
    /// </summary>
    public void NewDisjunctionCriteria()
    {
      int num = 6;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.disjunction = new Disjunction();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_4;
          case 3:
            this.disjunction.Add((ICriterion) this.conjunction);
            num = 2;
            continue;
          case 4:
          case 5:
            this.conjunction = new Conjunction();
            num = 3;
            continue;
          case 6:
            if (this.disjunction != null)
            {
              num = 5;
              continue;
            }
            goto case 1;
          default:
            DisjunctionCriteria.KixwlJWNM2EPHOuU1r8c((object) this.criteria, (object) this.disjunction);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 4 : 1;
            continue;
        }
      }
label_4:;
    }

    public ICriteria Add(ICriterion expression)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            DisjunctionCriteria.jH0y5wWNJsAXMrtw7y4u((object) this.conjunction, (object) expression);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return (ICriteria) this;
    }

    public ICriteria CreateAlias(string associationPath, string alias)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            DisjunctionCriteria.uOxdo4WN9boTt74M8fsJ((object) this.criteria, (object) associationPath, (object) alias);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return (ICriteria) this;
    }

    public ICriteria CreateAlias(string associationPath, string alias, JoinType joinType)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            DisjunctionCriteria.L4yB0bWNdTxlWqtR98Ot((object) this.criteria, (object) associationPath, (object) alias, joinType);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return (ICriteria) this;
    }

    public string Alias => this.criteria.Alias;

    public ICriteria FetchModeForProjections(bool value)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            DisjunctionCriteria.zS8SCRWNlksS2bNaMYrV((object) this.criteria, value);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return (ICriteria) this;
    }

    public object Clone() => throw new NotImplementedException();

    public ICriteria SetProjection(params IProjection[] projection) => throw new NotImplementedException();

    public ICriteria AddOrder(Order order) => throw new NotImplementedException();

    public ICriteria SetFetchMode(string associationPath, FetchMode mode) => throw new NotImplementedException();

    public ICriteria SetLockMode(LockMode lockMode) => throw new NotImplementedException();

    public ICriteria SetLockMode(string alias, LockMode lockMode) => throw new NotImplementedException();

    public ICriteria CreateCriteria(string associationPath) => throw new NotImplementedException();

    public ICriteria CreateCriteria(string associationPath, JoinType joinType) => throw new NotImplementedException();

    public ICriteria CreateCriteria(string associationPath, string alias) => throw new NotImplementedException();

    public ICriteria CreateCriteria(string associationPath, string alias, JoinType joinType) => throw new NotImplementedException();

    public ICriteria SetResultTransformer(IResultTransformer resultTransformer) => throw new NotImplementedException();

    public ICriteria SetMaxResults(int maxResults) => throw new NotImplementedException();

    public ICriteria SetFirstResult(int firstResult) => throw new NotImplementedException();

    public ICriteria SetFetchSize(int fetchSize) => throw new NotImplementedException();

    public ICriteria SetTimeout(int timeout) => throw new NotImplementedException();

    public ICriteria SetCacheable(bool cacheable) => throw new NotImplementedException();

    public ICriteria SetCacheRegion(string cacheRegion) => throw new NotImplementedException();

    public ICriteria SetComment(string comment) => throw new NotImplementedException();

    public ICriteria SetFlushMode(FlushMode flushMode) => throw new NotImplementedException();

    public ICriteria SetCacheMode(CacheMode cacheMode) => throw new NotImplementedException();

    public IList List() => throw new NotImplementedException();

    public object UniqueResult() => throw new NotImplementedException();

    public IEnumerable<T> Future<T>() => throw new NotImplementedException();

    IFutureEnumerable<T> ICriteria.Future<T>() => this.criteria.Future<T>();

    public IFutureValue<T> FutureValue<T>() => throw new NotImplementedException();

    public void List(IList results) => throw new NotImplementedException();

    public IList<T> List<T>() => throw new NotImplementedException();

    public T UniqueResult<T>() => throw new NotImplementedException();

    public void ClearOrders() => throw new NotImplementedException();

    public ICriteria GetCriteriaByPath(string path) => throw new NotImplementedException();

    public ICriteria GetCriteriaByAlias(string alias) => throw new NotImplementedException();

    public Type GetRootEntityTypeIfAvailable() => throw new NotImplementedException();

    public ICriteria CreateAlias(
      string associationPath,
      string alias,
      JoinType joinType,
      ICriterion withClause)
    {
      throw new NotImplementedException();
    }

    public ICriteria CreateCriteria(
      string associationPath,
      string alias,
      JoinType joinType,
      ICriterion withClause)
    {
      throw new NotImplementedException();
    }

    public bool IsReadOnly => throw new NotImplementedException();

    public bool IsReadOnlyInitialized => throw new NotImplementedException();

    public ICriteria SetReadOnly(bool readOnly) => throw new NotImplementedException();

    internal static object IE0sltWNyKkbOZsNjWgb([In] object obj0, [In] object obj1, [In] CancellationToken obj2) => (object) ((ICriteria) obj0).ListAsync((IList) obj1, obj2);

    internal static bool RClhelWN0xk9E532LeY2() => DisjunctionCriteria.DjY5NiWNxXZhc25VkGXk == null;

    internal static DisjunctionCriteria EFABsHWNm6EitVrG5Vyf() => DisjunctionCriteria.DjY5NiWNxXZhc25VkGXk;

    internal static object KixwlJWNM2EPHOuU1r8c([In] object obj0, [In] object obj1) => (object) ((ICriteria) obj0).Add((ICriterion) obj1);

    internal static object jH0y5wWNJsAXMrtw7y4u([In] object obj0, [In] object obj1) => (object) ((Junction) obj0).Add((ICriterion) obj1);

    internal static object uOxdo4WN9boTt74M8fsJ([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((ICriteria) obj0).CreateAlias((string) obj1, (string) obj2);

    internal static object L4yB0bWNdTxlWqtR98Ot(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] JoinType obj3)
    {
      return (object) ((ICriteria) obj0).CreateAlias((string) obj1, (string) obj2, obj3);
    }

    internal static object zS8SCRWNlksS2bNaMYrV([In] object obj0, [In] bool obj1) => (object) ((ICriteria) obj0).FetchModeForProjections(obj1);
  }
}
