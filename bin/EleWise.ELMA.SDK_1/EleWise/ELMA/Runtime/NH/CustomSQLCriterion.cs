// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.CustomSQLCriterion
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

namespace EleWise.ELMA.Runtime.NH
{
  [Serializable]
  public class CustomSQLCriterion : AbstractCriterion
  {
    private readonly SqlString _sql;
    private readonly TypedValue[] _typedValues;
    private readonly Func<SqlString, ICriteria, ICriteriaQuery, SqlString> _toSqlStringFunc;
    internal static CustomSQLCriterion GUsxdLWtJJOyev0cM217;

    public CustomSQLCriterion(
      string sql,
      object[] values,
      IType[] types,
      Func<SqlString, ICriteria, ICriteriaQuery, SqlString> toSqlStringFunc = null)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      this.\u002Ector(SqlString.Parse(sql), values, types, toSqlStringFunc);
    }

    public CustomSQLCriterion(
      SqlString sql,
      object[] values,
      IType[] types,
      Func<SqlString, ICriteria, ICriteriaQuery, SqlString> toSqlStringFunc = null)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this._sql = sql;
      this._typedValues = new TypedValue[values.Length];
      this._toSqlStringFunc = toSqlStringFunc;
      for (int index = 0; index < this._typedValues.Length; ++index)
        this._typedValues[index] = new TypedValue(types[index], values[index]);
    }

    public override IProjection[] GetProjections() => (IProjection[]) null;

    public override TypedValue[] GetTypedValues(ICriteria criteria, ICriteriaQuery criteriaQuery) => this._typedValues;

    public override SqlString ToSqlString(ICriteria criteria, ICriteriaQuery criteriaQuery)
    {
      int num1 = 7;
      SqlString sqlString;
      while (true)
      {
        int num2 = num1;
        int index;
        IEnumerator<Parameter> enumerator;
        List<Parameter> list;
        int num3;
        while (true)
        {
          switch (num2)
          {
            case 2:
label_8:
              ++index;
              num2 = 10;
              continue;
            case 3:
              goto label_5;
            case 4:
              if (this._toSqlStringFunc != null)
              {
                num2 = 8;
                continue;
              }
              goto label_7;
            case 5:
              try
              {
label_12:
                if (CustomSQLCriterion.sTdu9hWtrp7cIMDn58w2((object) enumerator))
                  goto label_14;
                else
                  goto label_13;
label_10:
                Parameter current;
                int num4;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      goto label_8;
                    case 2:
                      list[num3++].BackTrack = CustomSQLCriterion.Ao4jjGWtl50j3k45JqJT((object) current);
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 3 : 2;
                      continue;
                    case 3:
                      goto label_12;
                    default:
                      goto label_14;
                  }
                }
label_13:
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 1 : 0;
                goto label_10;
label_14:
                current = enumerator.Current;
                num4 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
                {
                  num4 = 2;
                  goto label_10;
                }
                else
                  goto label_10;
              }
              finally
              {
                if (enumerator != null)
                {
                  int num5 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
                    num5 = 0;
                  while (true)
                  {
                    switch (num5)
                    {
                      case 1:
                        goto label_21;
                      default:
                        CustomSQLCriterion.gjFoiMWtgsbPtxYrTkpy((object) enumerator);
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 1 : 0;
                        continue;
                    }
                  }
                }
label_21:;
              }
            case 6:
              num3 = 0;
              num2 = 9;
              continue;
            case 7:
              list = this._sql.GetParameters().ToList<Parameter>();
              num2 = 6;
              continue;
            case 8:
              sqlString = this._toSqlStringFunc(this._sql, criteria, criteriaQuery);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 11 : 5;
              continue;
            case 9:
              index = 0;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 8 : 12;
              continue;
            case 10:
            case 12:
              if (index < this._typedValues.Length)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 0 : 1;
                continue;
              }
              goto label_5;
            case 11:
              goto label_7;
            default:
              goto label_6;
          }
        }
label_5:
        sqlString = this._sql;
        num1 = 4;
        continue;
label_6:
        enumerator = criteriaQuery.NewQueryParameter(this._typedValues[index]).GetEnumerator();
        num1 = 5;
      }
label_7:
      return (SqlString) CustomSQLCriterion.LHr1EAWtYtwFHb9a6Bam((object) sqlString, CustomSQLCriterion.iXekqUWt5T5YSrV4YUc9(-105199646 ^ -105322696), CustomSQLCriterion.vgnR3qWtjbGOX3944xgG((object) criteriaQuery, (object) criteria));
    }

    public override string ToString() => this._sql.ToString();

    internal static object Ao4jjGWtl50j3k45JqJT([In] object obj0) => ((Parameter) obj0).BackTrack;

    internal static bool sTdu9hWtrp7cIMDn58w2([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void gjFoiMWtgsbPtxYrTkpy([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object iXekqUWt5T5YSrV4YUc9(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object vgnR3qWtjbGOX3944xgG([In] object obj0, [In] object obj1) => (object) ((ICriteriaQuery) obj0).GetSQLAlias((ICriteria) obj1);

    internal static object LHr1EAWtYtwFHb9a6Bam([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((SqlString) obj0).Replace((string) obj1, (string) obj2);

    internal static bool ylOPSXWt906yAvM16CS2() => CustomSQLCriterion.GUsxdLWtJJOyev0cM217 == null;

    internal static CustomSQLCriterion zfHaWOWtdjsjv594aeba() => CustomSQLCriterion.GUsxdLWtJJOyev0cM217;
  }
}
