// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.CriteriaExtension
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using NHibernate;
using NHibernate.Criterion;
using NHibernate.Impl;
using NHibernate.SqlCommand;
using System;
using System.Linq.Expressions;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Runtime.NH
{
  public static class CriteriaExtension
  {
    private static CriteriaExtension fyyRulWadXscdUvZebW8;

    /// <summary>
    /// Проверяет существование алиаса, и если его нет, то создаёт.
    /// </summary>
    /// <param name="criteria"></param>
    /// <param name="path"></param>
    /// <param name="associationPath"></param>
    /// <param name="joinType"></param>
    /// <param name="alias"></param>
    /// <returns></returns>
    public static ICriteria GetOrCreateAlias(
      this ICriteria criteria,
      string path,
      string associationPath,
      JoinType joinType,
      ref string alias)
    {
      int num1 = 1;
      ICriteria criteria1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            criteria1 = (ICriteria) null;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 0 : 0;
            continue;
          case 2:
label_14:
            if (criteria1 != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 0 : 5;
              continue;
            }
            goto case 9;
          case 3:
            try
            {
              criteria1 = (ICriteria) CriteriaExtension.ggsPOQWa5JD35HRkVcUE((object) criteria, (object) associationPath);
              int num2 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
                num2 = 0;
              switch (num2)
              {
                default:
                  goto label_9;
              }
            }
            catch (Exception ex)
            {
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
                num3 = 0;
              switch (num3)
              {
                default:
                  goto label_9;
              }
            }
          case 4:
          case 10:
            alias = (string) CriteriaExtension.N69Dj1WajtptZSgkdXKQ((object) criteria1);
            num1 = 7;
            continue;
          case 5:
          case 6:
label_9:
            if (criteria1 != null)
            {
              num1 = 10;
              continue;
            }
            goto case 8;
          case 7:
          case 11:
            goto label_24;
          case 8:
            criteria.CreateAlias(associationPath, alias, joinType);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 5 : 11;
            continue;
          case 9:
            if (CriteriaExtension.SalIuvWagl9qvhRO9qOD((object) path, (object) associationPath))
            {
              num1 = 3;
              continue;
            }
            goto case 5;
          default:
            try
            {
              criteria1 = criteria.GetCriteriaByPath(path);
              int num4 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
                num4 = 0;
              switch (num4)
              {
                default:
                  goto label_14;
              }
            }
            catch (Exception ex)
            {
              int num5 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
                num5 = 0;
              switch (num5)
              {
                default:
                  goto label_14;
              }
            }
        }
      }
label_24:
      return criteria;
    }

    /// <summary>
    /// Проверяет существование алиаса, и если его нет, то создаёт.
    /// </summary>
    /// <param name="criteria"></param>
    /// <param name="path"></param>
    /// <param name="joinType"></param>
    /// <param name="alias"></param>
    /// <returns></returns>
    public static ICriteria GetOrCreateAlias(
      this ICriteria criteria,
      string path,
      JoinType joinType,
      ref string alias)
    {
      return criteria.GetOrCreateAlias(path, path, joinType, ref alias);
    }

    /// <summary>Получить проекции для критерии.</summary>
    /// <param name="criteria">Критерия</param>
    /// <returns></returns>
    public static IProjection GetProjection(this ICriteria criteria)
    {
      int num = 3;
      CriteriaImpl criteriaImpl;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_4;
          case 2:
            if (criteriaImpl != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 0 : 0;
              continue;
            }
            goto label_4;
          case 3:
            criteriaImpl = criteria as CriteriaImpl;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 2 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_4:
      return (IProjection) null;
label_5:
      return (IProjection) CriteriaExtension.RYXaOSWaY3842X2cgGxC((object) criteriaImpl);
    }

    private static ICriteria AddProjection(
      this object criteria,
      object proj,
      Action<ProjectionList> action)
    {
      IProjection projection = ((ICriteria) criteria).GetProjection();
      if (projection == null)
      {
        ((ICriteria) criteria).SetProjection((IProjection) proj);
      }
      else
      {
        if (!(projection is ProjectionList projectionList))
        {
          projectionList = Projections.ProjectionList();
          projectionList.Add(projection);
        }
        if (action != null)
          action(projectionList);
        ((ICriteria) criteria).SetProjection((IProjection) projectionList);
      }
      return (ICriteria) criteria;
    }

    public static ICriteria AddProjection(this ICriteria criteria, IProjection projection)
    {
      int num1 = 1;
      IProjection projection1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          default:
            projection1 = projection;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 2 : 2;
            continue;
        }
      }
label_3:
      return criteria.AddProjection((object) projection1, (Action<ProjectionList>) (projectionList =>
      {
        int num2 = 1;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_2;
            case 1:
              // ISSUE: reference to a compiler-generated method
              CriteriaExtension.\u003C\u003Ec__DisplayClass4_0.ejQKOAQ9P7KVpZ3R9lnr((object) projectionList, (object) projection1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }));
    }

    public static ICriteria AddProjection(
      this ICriteria criteria,
      IProjection projection,
      string alias)
    {
      int num1 = 3;
      IProjection projection1;
      string alias1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_4;
          case 2:
            projection1 = projection;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 0 : 0;
            continue;
          case 3:
            num1 = 2;
            continue;
          default:
            alias1 = alias;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 1 : 1;
            continue;
        }
      }
label_4:
      return criteria.AddProjection((object) projection1, (Action<ProjectionList>) (projectionList =>
      {
        int num2 = 1;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_2;
            case 1:
              // ISSUE: reference to a compiler-generated method
              CriteriaExtension.\u003C\u003Ec__DisplayClass5_0.LtTwtlQ9a0OiT00f6c9Z((object) projectionList, (object) projection1, (object) alias1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }));
    }

    public static ICriteria AddProjection<T>(
      this ICriteria criteria,
      IProjection projection,
      Expression<Func<T>> alias)
    {
      return criteria.AddProjection((object) projection, (Action<ProjectionList>) (projectionList =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              projectionList.Add<T>(projection, alias);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }));
    }

    public static ICriteria If(
      this ICriteria criteria,
      bool condition,
      Func<ICriteria, ICriteria> action)
    {
      return !condition ? criteria : action(criteria);
    }

    internal static bool SalIuvWagl9qvhRO9qOD([In] object obj0, [In] object obj1) => (string) obj0 != (string) obj1;

    internal static object ggsPOQWa5JD35HRkVcUE([In] object obj0, [In] object obj1) => (object) ((ICriteria) obj0).GetCriteriaByPath((string) obj1);

    internal static object N69Dj1WajtptZSgkdXKQ([In] object obj0) => (object) ((ICriteria) obj0).Alias;

    internal static bool f7ihnpWal3Pl9hRbeCca() => CriteriaExtension.fyyRulWadXscdUvZebW8 == null;

    internal static CriteriaExtension XNCvguWarnj2Kr1IKcAa() => CriteriaExtension.fyyRulWadXscdUvZebW8;

    internal static object RYXaOSWaY3842X2cgGxC([In] object obj0) => (object) ((CriteriaImpl) obj0).Projection;
  }
}
