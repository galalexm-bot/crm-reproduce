// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.AliasesSQLCriterion
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
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace EleWise.ELMA.Runtime.NH
{
  [Serializable]
  public class AliasesSQLCriterion : AbstractCriterion
  {
    private readonly SqlString _sql;
    private readonly TypedValue[] _typedValues;
    internal static AliasesSQLCriterion GGWZDKWDtgOou2hKdKgq;

    public AliasesSQLCriterion(SqlString sql, object[] values, IType[] types)
    {
      AliasesSQLCriterion.sbRATYWD6AEEDPvomk3k();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 4;
      int index;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_4;
          case 2:
            index = 0;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 0;
            continue;
          case 4:
            this._sql = sql;
            num = 5;
            continue;
          case 5:
            this._typedValues = new TypedValue[values.Length];
            num = 2;
            continue;
          case 6:
            this._typedValues[index] = new TypedValue(types[index], values[index]);
            num = 7;
            continue;
          case 7:
            ++index;
            num = 3;
            continue;
          default:
            if (index >= this._typedValues.Length)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 1 : 1;
              continue;
            }
            goto case 6;
        }
      }
label_4:;
    }

    public override TypedValue[] GetTypedValues(ICriteria criteria, ICriteriaQuery criteriaQuery) => this._typedValues;

    public override IProjection[] GetProjections() => (IProjection[]) null;

    public override string ToString() => this._sql.ToString();

    public override SqlString ToSqlString(ICriteria criteria, ICriteriaQuery criteriaQuery)
    {
      int num1 = 12;
      int index;
      IEnumerator<Parameter> enumerator;
      List<Parameter> list1;
      int num2;
      ICriteriaQuery criteriaQuery1;
      ICriteria criteria1;
      SqlString sql;
      while (true)
      {
        switch (num1)
        {
          case 1:
            list1 = this._sql.GetParameters().ToList<Parameter>();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 2 : 4;
            continue;
          case 2:
label_9:
            ++index;
            num1 = 6;
            continue;
          case 3:
          case 6:
            if (index >= this._typedValues.Length)
            {
              num1 = 7;
              continue;
            }
            goto case 8;
          case 4:
            num2 = 0;
            num1 = 10;
            continue;
          case 5:
            goto label_24;
          case 7:
            // ISSUE: reference to a compiler-generated method
            List<string> list2 = ((IEnumerable) AliasesSQLCriterion.GvOYQVWD08GlPLBVeA10((object) this._sql.ToString(), AliasesSQLCriterion.Ea2xVNWDxS2pI6x7QfKa(-97972138 ^ -97841370))).OfType<Match>().Select<Match, string>((Func<Match, string>) (m => (string) AliasesSQLCriterion.\u003C\u003Ec.TTvxM7QdRCUkdF7O3HJV((object) m))).ToList<string>();
            sql = this._sql;
            Action<string> action = (Action<string>) (p =>
            {
              int num3 = 1;
              SqlString[] sqlStringArray;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    sqlStringArray = (SqlString[]) AliasesSQLCriterion.\u003C\u003Ec__DisplayClass6_0.sx1ZBlQduqWNglHJChUn(AliasesSQLCriterion.\u003C\u003Ec__DisplayClass6_0.zCE75ZQdZmLJVUKCbL4B(AliasesSQLCriterion.\u003C\u003Ec__DisplayClass6_0.zCE75ZQdZmLJVUKCbL4B(AliasesSQLCriterion.\u003C\u003Ec__DisplayClass6_0.zCE75ZQdZmLJVUKCbL4B((object) p, AliasesSQLCriterion.\u003C\u003Ec__DisplayClass6_0.l0GnStQd8iWRqQyYtRX2(-1088304168 ^ -1088307164), (object) ""), AliasesSQLCriterion.\u003C\u003Ec__DisplayClass6_0.l0GnStQd8iWRqQyYtRX2(-1255365154 ^ 596875508 ^ -1765854918), (object) ""), AliasesSQLCriterion.\u003C\u003Ec__DisplayClass6_0.l0GnStQd8iWRqQyYtRX2(1021410165 ^ 1021404717), (object) ""), (object) null, (object) criteriaQuery1, (object) criteria1);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 0 : 0;
                    continue;
                  case 2:
                    sql = sql.Replace(p, sqlStringArray[0].ToString());
                    num3 = 3;
                    continue;
                  case 3:
                    goto label_2;
                  default:
                    if (sqlStringArray.Length == 1)
                    {
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 2 : 0;
                      continue;
                    }
                    goto label_7;
                }
              }
label_2:
              return;
label_7:;
            });
            list2.ForEach(action);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 5 : 4;
            continue;
          case 8:
            enumerator = criteriaQuery1.NewQueryParameter(this._typedValues[index]).GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 9 : 1;
            continue;
          case 9:
            try
            {
label_14:
              if (AliasesSQLCriterion.AhJsqDWD7d5gYFgYf0Ss((object) enumerator))
                goto label_16;
              else
                goto label_15;
label_12:
              Parameter current;
              int num4;
              while (true)
              {
                switch (num4)
                {
                  case 1:
                    AliasesSQLCriterion.MSyi2HWDAvVTPvXdMCqE((object) list1[num2++], AliasesSQLCriterion.wqFB5ZWDH4L47jh3N71i((object) current));
                    num4 = 3;
                    continue;
                  case 2:
                    goto label_16;
                  case 3:
                    goto label_14;
                  default:
                    goto label_9;
                }
              }
label_15:
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 0 : 0;
              goto label_12;
label_16:
              current = enumerator.Current;
              num4 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0)
              {
                num4 = 1;
                goto label_12;
              }
              else
                goto label_12;
            }
            finally
            {
              int num5;
              if (enumerator == null)
                num5 = 2;
              else
                goto label_21;
label_20:
              switch (num5)
              {
                case 1:
                  break;
                default:
              }
label_21:
              enumerator.Dispose();
              num5 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
              {
                num5 = 0;
                goto label_20;
              }
              else
                goto label_20;
            }
          case 10:
            index = 0;
            num1 = 3;
            continue;
          case 11:
            criteriaQuery1 = criteriaQuery;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 0;
            continue;
          case 12:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 11 : 6;
            continue;
          default:
            criteria1 = criteria;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 1 : 1;
            continue;
        }
      }
label_24:
      return sql;
    }

    internal static void sbRATYWD6AEEDPvomk3k() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool x4CbeBWDwk9DhcJ46Dk1() => AliasesSQLCriterion.GGWZDKWDtgOou2hKdKgq == null;

    internal static AliasesSQLCriterion paAv0wWD4xltwvy4q7sP() => AliasesSQLCriterion.GGWZDKWDtgOou2hKdKgq;

    internal static object wqFB5ZWDH4L47jh3N71i([In] object obj0) => ((Parameter) obj0).BackTrack;

    internal static void MSyi2HWDAvVTPvXdMCqE([In] object obj0, [In] object obj1) => ((Parameter) obj0).BackTrack = obj1;

    internal static bool AhJsqDWD7d5gYFgYf0Ss([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static object Ea2xVNWDxS2pI6x7QfKa(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object GvOYQVWD08GlPLBVeA10([In] object obj0, [In] object obj1) => (object) Regex.Matches((string) obj0, (string) obj1);
  }
}
