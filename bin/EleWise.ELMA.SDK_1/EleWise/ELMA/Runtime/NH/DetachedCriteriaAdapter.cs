// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.DetachedCriteriaAdapter
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
  /// класс нужен, чтобы понять в SetupAutoFilter, что пришли из CreateDetachedCriteria, и взять alias из критерии, а не DefaultCriteriaAlias
  /// </summary>
  public class DetachedCriteriaAdapter : ICriteria, ICloneable
  {
    private readonly DetachedCriteria detachedCriteria;
    private readonly ISession session;
    private readonly Type rootType;
    private bool enableFetchJoinForProjection;
    private bool _readOnly;
    private bool _readOnlyInitialized;
    internal static DetachedCriteriaAdapter yU1slvWNXYxWeBPE2neg;

    /// <inheritdoc />
    public Task<IList> ListAsync(CancellationToken cancellationToken = default (CancellationToken)) => throw new NotImplementedException();

    /// <inheritdoc />
    public Task<object> UniqueResultAsync(CancellationToken cancellationToken = default (CancellationToken)) => throw new NotImplementedException();

    /// <inheritdoc />
    public Task ListAsync(IList results, CancellationToken cancellationToken = default (CancellationToken)) => throw new NotImplementedException();

    /// <inheritdoc />
    public Task<IList<T>> ListAsync<T>(CancellationToken cancellationToken = default (CancellationToken)) => throw new NotImplementedException();

    /// <inheritdoc />
    public Task<T> UniqueResultAsync<T>(CancellationToken cancellationToken = default (CancellationToken)) => throw new NotImplementedException();

    public DetachedCriteriaAdapter(DetachedCriteria detachedCriteria, ISession session)
    {
      DetachedCriteriaAdapter.zXI6dDWNnFx1ksbN4Aor();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.session = session;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 2;
            continue;
          case 2:
            goto label_3;
          default:
            this.detachedCriteria = detachedCriteria;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    public DetachedCriteriaAdapter(
      DetachedCriteria detachedCriteria,
      ISession session,
      Type rootType)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      this.\u002Ector(detachedCriteria, session);
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.rootType = rootType;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    public DetachedCriteria DetachedCriteria => this.detachedCriteria;

    public ISession Session => this.session;

    public IProjection Projection => (IProjection) null;

    public ICriteria Add(ICriterion expression) => (ICriteria) DetachedCriteriaAdapter.ixyS1iWN2lHX3aNHNR3S(DetachedCriteriaAdapter.HfjQgYWNOwIkhqtZrwjf((object) this.detachedCriteria, (object) expression), (object) this.session);

    public ICriteria AddOrder(Order order) => (ICriteria) DetachedCriteriaAdapter.ixyS1iWN2lHX3aNHNR3S(DetachedCriteriaAdapter.ErVeVaWNefOwAQXEiYEK((object) this.detachedCriteria, (object) order), (object) this.session);

    public string Alias => (string) DetachedCriteriaAdapter.EOaqZPWNP1f1TTsUjT0V((object) this.detachedCriteria);

    public void ClearOrderds() => throw new NotSupportedException();

    public ICriteria CreateAlias(string associationPath, string alias, JoinType joinType) => (ICriteria) DetachedCriteriaAdapter.ixyS1iWN2lHX3aNHNR3S(DetachedCriteriaAdapter.n1Isw5WN1EIRsGehYmXe((object) this.detachedCriteria, (object) associationPath, (object) alias, joinType), (object) this.session);

    public ICriteria CreateAlias(string associationPath, string alias) => (ICriteria) DetachedCriteriaAdapter.ixyS1iWN2lHX3aNHNR3S(DetachedCriteriaAdapter.bf4sXMWNNGEtRxPxYJbD((object) this.detachedCriteria, (object) associationPath, (object) alias), (object) this.session);

    public ICriteria CreateAlias(
      string associationPath,
      string alias,
      JoinType joinType,
      ICriterion withClause)
    {
      throw new NotImplementedException();
    }

    public ICriteria CreateCriteria(string associationPath, string alias, JoinType joinType) => (ICriteria) DetachedCriteriaAdapter.ixyS1iWN2lHX3aNHNR3S(DetachedCriteriaAdapter.x30ZK2WN3Ya0QjksrqDk((object) this.detachedCriteria, (object) associationPath, (object) alias, joinType), (object) this.session);

    public ICriteria CreateCriteria(string associationPath, string alias) => (ICriteria) DetachedCriteriaAdapter.ixyS1iWN2lHX3aNHNR3S(DetachedCriteriaAdapter.VJywNCWNpiG3kuXMu92H((object) this.detachedCriteria, (object) associationPath, (object) alias), (object) this.session);

    public ICriteria CreateCriteria(string associationPath, JoinType joinType) => (ICriteria) DetachedCriteriaAdapter.ixyS1iWN2lHX3aNHNR3S(DetachedCriteriaAdapter.MPOkjUWNaRN1BSFJpiwC((object) this.detachedCriteria, (object) associationPath, joinType), (object) this.session);

    public ICriteria CreateCriteria(
      string associationPath,
      string alias,
      JoinType joinType,
      ICriterion withClause)
    {
      throw new NotImplementedException();
    }

    public ICriteria CreateCriteria(string associationPath) => (ICriteria) DetachedCriteriaAdapter.ixyS1iWN2lHX3aNHNR3S(DetachedCriteriaAdapter.WcTmySWNDUE7klsSCjZy((object) this.detachedCriteria, (object) associationPath), (object) this.session);

    public ICriteria GetCriteriaByAlias(string alias) => this.detachedCriteria.GetCriteriaByAlias(alias).Adapt(this.session);

    public ICriteria GetCriteriaByPath(string path) => (ICriteria) DetachedCriteriaAdapter.ixyS1iWN2lHX3aNHNR3S(DetachedCriteriaAdapter.UdAodAWNtVa7b4dCYahc((object) this.detachedCriteria, (object) path), (object) this.session);

    public IList<T> List<T>() => throw new NotSupportedException();

    public void List(IList results) => throw new NotSupportedException();

    public IList List() => throw new NotSupportedException();

    public ICriteria SetCacheMode(CacheMode cacheMode) => (ICriteria) DetachedCriteriaAdapter.ixyS1iWN2lHX3aNHNR3S(DetachedCriteriaAdapter.zF6GAHWNwMlKnEpx42oX((object) this.detachedCriteria, cacheMode), (object) this.session);

    public ICriteria SetCacheRegion(string cacheRegion) => throw new NotSupportedException();

    public ICriteria SetCacheable(bool cacheable) => throw new NotSupportedException();

    public ICriteria SetComment(string comment) => throw new NotSupportedException();

    public ICriteria SetFetchMode(string associationPath, FetchMode mode) => (ICriteria) DetachedCriteriaAdapter.ixyS1iWN2lHX3aNHNR3S((object) this.detachedCriteria.SetFetchMode(associationPath, mode), (object) this.session);

    public ICriteria SetFetchSize(int fetchSize) => throw new NotSupportedException();

    public ICriteria SetFirstResult(int firstResult) => (ICriteria) DetachedCriteriaAdapter.ixyS1iWN2lHX3aNHNR3S(DetachedCriteriaAdapter.LjN5GpWN4pZN6TdpnnWq((object) this.detachedCriteria, firstResult), (object) this.session);

    public ICriteria SetFlushMode(FlushMode flushMode) => throw new NotSupportedException();

    public ICriteria SetLockMode(string alias, LockMode lockMode) => throw new NotSupportedException();

    public ICriteria SetLockMode(LockMode lockMode) => throw new NotSupportedException();

    public ICriteria SetMaxResults(int maxResults) => ((DetachedCriteria) DetachedCriteriaAdapter.jZ7NtuWN6rwmSQHR9mX2((object) this.detachedCriteria, maxResults)).Adapt(this.session);

    public ICriteria SetProjection(IProjection projection) => (ICriteria) DetachedCriteriaAdapter.ixyS1iWN2lHX3aNHNR3S(DetachedCriteriaAdapter.AgxRG1WNHXiv7WDa0LGn((object) this.detachedCriteria, (object) projection), (object) this.session);

    public ICriteria SetProjection(params IProjection[] projections)
    {
      int num = 9;
      ProjectionList projectionList;
      int index;
      IProjection projection;
      IProjection[] projectionArray;
      while (true)
      {
        switch (num)
        {
          case 1:
            ++index;
            num = 3;
            continue;
          case 3:
          case 7:
            if (index < projectionArray.Length)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 2 : 2;
              continue;
            }
            goto label_2;
          case 4:
            DetachedCriteriaAdapter.VNINeVWN7da6T2NZhwGH((object) projectionList, (object) projection);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 1;
            continue;
          case 5:
            goto label_2;
          case 6:
            index = 0;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 2 : 7;
            continue;
          case 8:
            projectionArray = projections;
            num = 6;
            continue;
          case 9:
            projectionList = (ProjectionList) DetachedCriteriaAdapter.lHDxMxWNArU1Il8m8Ab5();
            num = 8;
            continue;
          default:
            projection = projectionArray[index];
            num = 4;
            continue;
        }
      }
label_2:
      return (ICriteria) DetachedCriteriaAdapter.ixyS1iWN2lHX3aNHNR3S(DetachedCriteriaAdapter.AgxRG1WNHXiv7WDa0LGn((object) this.detachedCriteria, (object) projectionList), (object) this.session);
    }

    public ICriteria SetResultTransformer(IResultTransformer resultTransformer) => (ICriteria) DetachedCriteriaAdapter.ixyS1iWN2lHX3aNHNR3S((object) this.detachedCriteria.SetResultTransformer(resultTransformer), (object) this.session);

    public ICriteria SetTimeout(int timeout) => throw new NotSupportedException();

    public T UniqueResult<T>() => throw new NotSupportedException();

    public object UniqueResult() => throw new NotSupportedException();

    public Type GetRootEntityTypeIfAvailable()
    {
      int num = 1;
      Type rootType;
      while (true)
      {
        switch (num)
        {
          case 1:
            rootType = this.rootType;
            if ((object) rootType == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          default:
            goto label_5;
        }
      }
label_2:
      return rootType;
label_5:
      return this.detachedCriteria.GetRootEntityTypeIfAvailable();
    }

    public void ClearOrders()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.detachedCriteria.ClearOrders();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public IEnumerable<T> Future<T>() => throw new NotSupportedException();

    public IFutureValue<T> FutureValue<T>() => throw new NotSupportedException();

    IFutureEnumerable<T> ICriteria.Future<T>() => throw new NotImplementedException();

    public object Clone() => throw new NotSupportedException();

    public bool IsReadOnly => this._readOnly;

    public bool IsReadOnlyInitialized => this._readOnlyInitialized;

    public ICriteria SetReadOnly(bool readOnly)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this._readOnly = readOnly;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          default:
            this._readOnlyInitialized = true;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 2 : 2;
            continue;
        }
      }
label_3:
      return (ICriteria) this;
    }

    public ICriteria FetchModeForProjections(bool value)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.enableFetchJoinForProjection = value;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return (ICriteria) this;
    }

    internal static void zXI6dDWNnFx1ksbN4Aor() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool N1WNu2WNTWJSsqSiSojx() => DetachedCriteriaAdapter.yU1slvWNXYxWeBPE2neg == null;

    internal static DetachedCriteriaAdapter GUB3pIWNkV9cp2tBkGmm() => DetachedCriteriaAdapter.yU1slvWNXYxWeBPE2neg;

    internal static object HfjQgYWNOwIkhqtZrwjf([In] object obj0, [In] object obj1) => (object) ((DetachedCriteria) obj0).Add((ICriterion) obj1);

    internal static object ixyS1iWN2lHX3aNHNR3S([In] object obj0, [In] object obj1) => (object) ((DetachedCriteria) obj0).Adapt((ISession) obj1);

    internal static object ErVeVaWNefOwAQXEiYEK([In] object obj0, [In] object obj1) => (object) ((DetachedCriteria) obj0).AddOrder((Order) obj1);

    internal static object EOaqZPWNP1f1TTsUjT0V([In] object obj0) => (object) ((DetachedCriteria) obj0).Alias;

    internal static object n1Isw5WN1EIRsGehYmXe(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] JoinType obj3)
    {
      return (object) ((DetachedCriteria) obj0).CreateAlias((string) obj1, (string) obj2, obj3);
    }

    internal static object bf4sXMWNNGEtRxPxYJbD([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((DetachedCriteria) obj0).CreateAlias((string) obj1, (string) obj2);

    internal static object x30ZK2WN3Ya0QjksrqDk(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] JoinType obj3)
    {
      return (object) ((DetachedCriteria) obj0).CreateCriteria((string) obj1, (string) obj2, obj3);
    }

    internal static object VJywNCWNpiG3kuXMu92H([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((DetachedCriteria) obj0).CreateCriteria((string) obj1, (string) obj2);

    internal static object MPOkjUWNaRN1BSFJpiwC([In] object obj0, [In] object obj1, [In] JoinType obj2) => (object) ((DetachedCriteria) obj0).CreateCriteria((string) obj1, obj2);

    internal static object WcTmySWNDUE7klsSCjZy([In] object obj0, [In] object obj1) => (object) ((DetachedCriteria) obj0).CreateCriteria((string) obj1);

    internal static object UdAodAWNtVa7b4dCYahc([In] object obj0, [In] object obj1) => (object) ((DetachedCriteria) obj0).GetCriteriaByPath((string) obj1);

    internal static object zF6GAHWNwMlKnEpx42oX([In] object obj0, [In] CacheMode obj1) => (object) ((DetachedCriteria) obj0).SetCacheMode(obj1);

    internal static object LjN5GpWN4pZN6TdpnnWq([In] object obj0, [In] int obj1) => (object) ((DetachedCriteria) obj0).SetFirstResult(obj1);

    internal static object jZ7NtuWN6rwmSQHR9mX2([In] object obj0, [In] int obj1) => (object) ((DetachedCriteria) obj0).SetMaxResults(obj1);

    internal static object AgxRG1WNHXiv7WDa0LGn([In] object obj0, [In] object obj1) => (object) ((DetachedCriteria) obj0).SetProjection((IProjection) obj1);

    internal static object lHDxMxWNArU1Il8m8Ab5() => (object) Projections.ProjectionList();

    internal static object VNINeVWN7da6T2NZhwGH([In] object obj0, [In] object obj1) => (object) ((ProjectionList) obj0).Add((IProjection) obj1);
  }
}
