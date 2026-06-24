// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.ConditionalCountProjection
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Engine;
using NHibernate.SqlCommand;
using NHibernate.Type;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Runtime.NH
{
  [Serializable]
  public class ConditionalCountProjection : SimpleProjection
  {
    private readonly ICriterion criterion;
    internal static ConditionalCountProjection wxNftLWpzEXED69mkL3Y;

    public ConditionalCountProjection(ICriterion criterion)
    {
      ConditionalCountProjection.uqkB84WaWxJFbKA4Srhc();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.criterion = criterion;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    public override bool IsAggregate
    {
      get
      {
        int num = 6;
        IProjection[] projectionArray1;
        IProjection[] projectionArray2;
        int index;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (!ConditionalCountProjection.OptM8pWabPIL3535Hg6q((object) projectionArray2[index]))
              {
                num = 2;
                continue;
              }
              goto label_12;
            case 2:
              ++index;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 1 : 8;
              continue;
            case 3:
              goto label_5;
            case 4:
              projectionArray2 = projectionArray1;
              num = 9;
              continue;
            case 5:
              if (projectionArray1 != null)
              {
                num = 4;
                continue;
              }
              goto label_5;
            case 6:
              projectionArray1 = (IProjection[]) ConditionalCountProjection.sHKLPmWao1MJPX7q7ATL((object) this.criterion);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 1 : 5;
              continue;
            case 7:
              goto label_12;
            case 9:
              index = 0;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
              continue;
            default:
              if (index >= projectionArray2.Length)
              {
                num = 3;
                continue;
              }
              goto case 1;
          }
        }
label_5:
        return false;
label_12:
        return true;
      }
    }

    public override SqlString ToSqlString(
      ICriteria criteria,
      int position,
      ICriteriaQuery criteriaQuery)
    {
      int num = 1;
      SqlString sqlString;
      while (true)
      {
        switch (num)
        {
          case 1:
            sqlString = (SqlString) ConditionalCountProjection.weDs8gWahZWJRhH4d5n6((object) this.criterion, (object) criteria, (object) criteriaQuery);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return ((SqlStringBuilder) ConditionalCountProjection.khrTAOWaQTUQO5BekkjK(ConditionalCountProjection.khrTAOWaQTUQO5BekkjK(ConditionalCountProjection.khrTAOWaQTUQO5BekkjK(ConditionalCountProjection.khrTAOWaQTUQO5BekkjK((object) ((SqlStringBuilder) ConditionalCountProjection.kAw9kXWafRKpM82mI7jB((object) ((SqlStringBuilder) ConditionalCountProjection.s0l131WaEbaMeABcRcqr((object) new SqlStringBuilder(), ConditionalCountProjection.u8uVluWaGRiUjVelsfm1(~-397266137 ^ 397399536))).Add((string) ConditionalCountProjection.u8uVluWaGRiUjVelsfm1(1304605005 ^ 1304471669)), (object) sqlString)).Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(2008901894 << 3 ^ -1108782752)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1251470110 >> 2 ^ 312992677)), ConditionalCountProjection.u8uVluWaGRiUjVelsfm1(1505778440 - 1981636111 ^ -475864251)), ConditionalCountProjection.u8uVluWaGRiUjVelsfm1(333888594 ^ 1075625116 ^ 1408768034)), ConditionalCountProjection.CbEXqqWaCkgKD6fktcTU((object) this, position)[0])).ToSqlString();
    }

    public override IType[] GetTypes(ICriteria criteria, ICriteriaQuery criteriaQuery) => new IType[1]
    {
      (IType) NHibernateUtil.Int32
    };

    public override TypedValue[] GetTypedValues(ICriteria criteria, ICriteriaQuery criteriaQuery) => (TypedValue[]) ConditionalCountProjection.q653T4WavJlhkZ2ddNAv((object) this.criterion, (object) criteria, (object) criteriaQuery);

    public override bool IsGrouped
    {
      get
      {
        int num = 2;
        IProjection[] projectionArray1;
        int index;
        IProjection[] projectionArray2;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (projectionArray1 != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 0 : 0;
                continue;
              }
              goto label_6;
            case 2:
              projectionArray1 = (IProjection[]) ConditionalCountProjection.sHKLPmWao1MJPX7q7ATL((object) this.criterion);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 1 : 1;
              continue;
            case 3:
              goto label_4;
            case 4:
            case 7:
              if (!ConditionalCountProjection.OTA4mwWa8MEY0YQvNXW3((object) projectionArray2[index]))
              {
                num = 10;
                continue;
              }
              goto label_4;
            case 5:
            case 9:
              if (index < projectionArray2.Length)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 1 : 7;
                continue;
              }
              goto label_6;
            case 6:
              index = 0;
              num = 5;
              continue;
            case 8:
              goto label_6;
            case 10:
              ++index;
              num = 9;
              continue;
            default:
              projectionArray2 = projectionArray1;
              num = 6;
              continue;
          }
        }
label_4:
        return true;
label_6:
        return false;
      }
    }

    public override SqlString ToGroupSqlString(ICriteria criteria, ICriteriaQuery criteriaQuery)
    {
      int num1 = 10;
      SqlStringBuilder sqlStringBuilder;
      while (true)
      {
        int num2 = num1;
        IProjection[] projectionArray1;
        int index;
        IProjection[] projectionArray2;
        IProjection projection;
        while (true)
        {
          switch (num2)
          {
            case 1:
              projection = projectionArray2[index];
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 14 : 3;
              continue;
            case 2:
            case 6:
              goto label_13;
            case 3:
              projectionArray2 = projectionArray1;
              num2 = 7;
              continue;
            case 4:
              goto label_12;
            case 5:
              ConditionalCountProjection.YsZAwOWaIZZSoR4Oevj7((object) sqlStringBuilder, ConditionalCountProjection.S3At4qWauYZGOyUPfmLV((object) sqlStringBuilder) - 1);
              num2 = 4;
              continue;
            case 7:
              index = 0;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 0;
              continue;
            case 8:
              if (projectionArray1 != null)
              {
                num2 = 3;
                continue;
              }
              goto case 13;
            case 9:
              projectionArray1 = (IProjection[]) ConditionalCountProjection.sHKLPmWao1MJPX7q7ATL((object) this.criterion);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 2 : 8;
              continue;
            case 10:
              sqlStringBuilder = new SqlStringBuilder();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 6 : 9;
              continue;
            case 11:
              ((SqlStringBuilder) ConditionalCountProjection.kAw9kXWafRKpM82mI7jB((object) sqlStringBuilder, ConditionalCountProjection.O1IYJYWaZL1LviNgRjH1((object) projection, (object) criteria, (object) criteriaQuery))).Add((string) ConditionalCountProjection.u8uVluWaGRiUjVelsfm1(-477139494 ^ -477142568));
              num2 = 2;
              continue;
            case 13:
              if (ConditionalCountProjection.S3At4qWauYZGOyUPfmLV((object) sqlStringBuilder) >= 2)
              {
                num2 = 5;
                continue;
              }
              goto label_12;
            case 14:
              if (!ConditionalCountProjection.OTA4mwWa8MEY0YQvNXW3((object) projection))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 6 : 2;
                continue;
              }
              goto case 11;
            default:
              if (index >= projectionArray2.Length)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 13 : 11;
                continue;
              }
              goto case 1;
          }
        }
label_13:
        ++index;
        num1 = 12;
      }
label_12:
      return (SqlString) ConditionalCountProjection.Ma2AFZWaV8oTjX90wIh6((object) sqlStringBuilder);
    }

    internal static void uqkB84WaWxJFbKA4Srhc() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool jxhQmFWaFZKA1hYTySdA() => ConditionalCountProjection.wxNftLWpzEXED69mkL3Y == null;

    internal static ConditionalCountProjection UP9Tq3WaBLxE8ruxNxEy() => ConditionalCountProjection.wxNftLWpzEXED69mkL3Y;

    internal static object sHKLPmWao1MJPX7q7ATL([In] object obj0) => (object) ((ICriterion) obj0).GetProjections();

    internal static bool OptM8pWabPIL3535Hg6q([In] object obj0) => ((IProjection) obj0).IsAggregate;

    internal static object weDs8gWahZWJRhH4d5n6([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((ICriterion) obj0).ToSqlString((ICriteria) obj1, (ICriteriaQuery) obj2);

    internal static object u8uVluWaGRiUjVelsfm1(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object s0l131WaEbaMeABcRcqr([In] object obj0, [In] object obj1) => (object) ((SqlStringBuilder) obj0).Add((string) obj1);

    internal static object kAw9kXWafRKpM82mI7jB([In] object obj0, [In] object obj1) => (object) ((SqlStringBuilder) obj0).Add((SqlString) obj1);

    internal static object khrTAOWaQTUQO5BekkjK([In] object obj0, [In] object obj1) => (object) ((SqlStringBuilder) obj0).Add((string) obj1);

    internal static object CbEXqqWaCkgKD6fktcTU([In] object obj0, [In] int obj1) => (object) ((SimpleProjection) obj0).GetColumnAliases(obj1);

    internal static object q653T4WavJlhkZ2ddNAv([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((ICriterion) obj0).GetTypedValues((ICriteria) obj1, (ICriteriaQuery) obj2);

    internal static bool OTA4mwWa8MEY0YQvNXW3([In] object obj0) => ((IProjection) obj0).IsGrouped;

    internal static object O1IYJYWaZL1LviNgRjH1([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((IProjection) obj0).ToGroupSqlString((ICriteria) obj1, (ICriteriaQuery) obj2);

    internal static int S3At4qWauYZGOyUPfmLV([In] object obj0) => ((SqlStringBuilder) obj0).Count;

    internal static object YsZAwOWaIZZSoR4Oevj7([In] object obj0, [In] int obj1) => (object) ((SqlStringBuilder) obj0).RemoveAt(obj1);

    internal static object Ma2AFZWaV8oTjX90wIh6([In] object obj0) => (object) ((SqlStringBuilder) obj0).ToSqlString();
  }
}
