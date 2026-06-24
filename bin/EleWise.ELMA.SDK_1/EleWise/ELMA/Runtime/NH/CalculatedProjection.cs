// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.CalculatedProjection
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.SqlCommand;
using NHibernate.Type;
using NHibernate.Util;
using SG9KiyIbtdgGDf12qr;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace EleWise.ELMA.Runtime.NH
{
  public class CalculatedProjection : SimpleProjection
  {
    private readonly CalculatedProjection.CalculationType calculationType;
    private readonly IProjection firstProjection;
    private readonly IProjection secondProjection;
    private readonly string firstPropertyName;
    private readonly string secondPropertyName;
    internal static CalculatedProjection ahiS0CWDJ20J86TI2dnS;

    /// <summary>
    /// Initializes a new instance of the CalculatedProjection class
    /// </summary>
    /// <param name="type">The type of calculation</param>
    /// <param name="firstPropertyName">The name of the first property</param>
    /// <param name="secondPropertyName">The name of the second property</param>
    protected internal CalculatedProjection(
      CalculatedProjection.CalculationType type,
      string firstPropertyName,
      string secondPropertyName)
    {
      CalculatedProjection.o718MJWDl7UhVEHMr2pg();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.secondPropertyName = secondPropertyName;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 0 : 0;
            continue;
          case 2:
            this.calculationType = type;
            num = 3;
            continue;
          case 3:
            this.firstPropertyName = firstPropertyName;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 1 : 0;
            continue;
          default:
            goto label_6;
        }
      }
label_2:
      return;
label_6:;
    }

    /// <summary>
    /// Initializes a new instance of the CalculatedProjection class
    /// </summary>
    /// <param name="type">The type of calculation</param>
    /// <param name="firstProjection">The first projection</param>
    /// <param name="secondProjection">The second projection</param>
    protected internal CalculatedProjection(
      CalculatedProjection.CalculationType type,
      IProjection firstProjection,
      IProjection secondProjection)
    {
      CalculatedProjection.o718MJWDl7UhVEHMr2pg();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.firstProjection = firstProjection;
            num = 2;
            continue;
          case 2:
            this.secondProjection = secondProjection;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 0 : 0;
            continue;
          case 3:
            this.calculationType = type;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 1 : 1;
            continue;
          default:
            goto label_6;
        }
      }
label_2:
      return;
label_6:;
    }

    /// <summary>
    /// Gets a value indicating whether the projection is grouped
    /// </summary>
    public override bool IsGrouped => false;

    /// <summary>Gets a value indicating whether IsAggregate.</summary>
    public override bool IsAggregate => false;

    /// <summary>Converts the calculation into a string</summary>
    /// <returns>The string representation of the calculation</returns>
    public override string ToString()
    {
      int num1 = 5;
      string str1;
      string str2;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          string firstPropertyName;
          switch (num2)
          {
            case 1:
              if (this.secondProjection == null)
              {
                num2 = 2;
                continue;
              }
              goto label_15;
            case 2:
              goto label_8;
            case 3:
              if (this.calculationType != CalculatedProjection.CalculationType.Minus)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 0 : 0;
                continue;
              }
              goto label_10;
            case 4:
              firstPropertyName = this.firstProjection.ToString();
              break;
            case 5:
              if (this.firstProjection != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 4 : 1;
                continue;
              }
              goto case 6;
            case 6:
              firstPropertyName = this.firstPropertyName;
              break;
            default:
              goto label_9;
          }
          str1 = firstPropertyName;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 1 : 1;
        }
label_8:
        string secondPropertyName = this.secondPropertyName;
        goto label_16;
label_15:
        secondPropertyName = this.secondProjection.ToString();
label_16:
        str2 = secondPropertyName;
        num1 = 3;
      }
label_9:
      return (string) CalculatedProjection.xNsSm4WDgcDHak1HCBV8((object) new string[5]
      {
        (string) CalculatedProjection.ol6SDfWDrfGXCXkZWMQb(--1360331293 ^ 1360338347),
        str1,
        CalculatedProjection.TypeToString(this.calculationType),
        str2,
        (string) CalculatedProjection.ol6SDfWDrfGXCXkZWMQb(--1333735954 ^ 1333734830)
      });
label_10:
      return z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1852837372 ^ -1852838478) + CalculatedProjection.TypeToString(this.calculationType) + str1 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -867820560);
    }

    /// <summary>Gets the types involved in the query</summary>
    /// <param name="criteria">The current criteria</param>
    /// <param name="criteriaQuery">The criteria query</param>
    /// <returns>An array of IType</returns>
    public override IType[] GetTypes(ICriteria criteria, ICriteriaQuery criteriaQuery)
    {
      int num = 3;
      IType type;
      List<IType> first;
      IType[] types;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (first[0].Equals((object) type))
            {
              num = 5;
              continue;
            }
            goto label_20;
          case 2:
            if (this.firstProjection != null)
            {
              num = 15;
              continue;
            }
            goto case 12;
          case 3:
            first = new List<IType>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 2;
            continue;
          case 4:
            if (string.IsNullOrWhiteSpace(this.secondPropertyName))
            {
              num = 11;
              continue;
            }
            goto case 17;
          case 5:
          case 6:
          case 11:
            goto label_21;
          case 7:
            goto label_12;
          case 8:
            if (first.SequenceEqual<IType>((IEnumerable<IType>) types))
            {
              num = 6;
              continue;
            }
            goto label_12;
          case 9:
          case 13:
          case 16:
            if (this.secondProjection == null)
            {
              num = 4;
              continue;
            }
            goto case 18;
          case 12:
            if (string.IsNullOrWhiteSpace(this.firstPropertyName))
            {
              num = 16;
              continue;
            }
            goto case 14;
          case 14:
            first.Add((IType) CalculatedProjection.p6LruDWDjKKQ9HJZrkMB((object) criteriaQuery, (object) criteria, (object) this.firstPropertyName));
            num = 13;
            continue;
          case 15:
            first.AddRange((IEnumerable<IType>) CalculatedProjection.MGnuq3WD55wGo2p6S0YE((object) this.firstProjection, (object) criteria, (object) criteriaQuery));
            num = 9;
            continue;
          case 17:
            type = criteriaQuery.GetType(criteria, this.secondPropertyName);
            num = 19;
            continue;
          case 18:
            types = this.secondProjection.GetTypes(criteria, criteriaQuery);
            num = 8;
            continue;
          case 19:
            if (CalculatedProjection.mFvo4vWDYGbn7xCMamIO((object) first) == 0)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 0 : 0;
              continue;
            }
            goto case 1;
          default:
            goto label_20;
        }
      }
label_12:
      throw new HibernateException((string) CalculatedProjection.ol6SDfWDrfGXCXkZWMQb(-680446928 - -370807692 ^ -309766086));
label_20:
      throw new HibernateException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1012087039 ^ 1011951481));
label_21:
      return (IType[]) CalculatedProjection.hUtiqWWDL8FPsLjMDju5((object) first);
    }

    /// <summary>Converts the objects to an sql string representation</summary>
    /// <param name="criteria">The criteria being used in the query</param>
    /// <param name="loc">The location in the query</param>
    /// <param name="criteriaQuery">The criteria query</param>
    /// <returns>The calculation as an sql string</returns>
    public override SqlString ToSqlString(
      ICriteria criteria,
      int loc,
      ICriteriaQuery criteriaQuery)
    {
      int num = 11;
      SqlString sqlString1;
      SqlString sqlString2;
      while (true)
      {
        object obj;
        switch (num)
        {
          case 2:
          case 7:
            sqlString1 = new SqlString((string) CalculatedProjection.ekr4rbWDUKiwvXY3NOuc((object) criteriaQuery, (object) criteria, (object) this.firstPropertyName));
            num = 8;
            continue;
          case 3:
            if (this.secondProjection != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 5 : 6;
              continue;
            }
            goto case 2;
          case 4:
            sqlString2 = (SqlString) CalculatedProjection.w9pnouWDcjgn63W6q90u(CalculatedProjection.fFQFJwWDsOPsLSTZibO6((object) this.secondProjection, (object) criteria, loc, (object) criteriaQuery));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 1;
            continue;
          case 5:
            goto label_11;
          case 6:
            sqlString1 = (SqlString) CalculatedProjection.w9pnouWDcjgn63W6q90u((object) this.firstProjection.ToSqlString(criteria, loc, criteriaQuery));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 4 : 4;
            continue;
          case 8:
            sqlString2 = new SqlString((string) CalculatedProjection.ekr4rbWDUKiwvXY3NOuc((object) criteriaQuery, (object) criteria, (object) this.secondPropertyName));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 0;
            continue;
          case 9:
            obj = CalculatedProjection.w9pnouWDcjgn63W6q90u(CalculatedProjection.fFQFJwWDsOPsLSTZibO6((object) this.firstProjection, (object) criteria, loc, (object) criteriaQuery));
            break;
          case 10:
            if (this.firstProjection != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 9 : 6;
              continue;
            }
            goto case 12;
          case 11:
            if (this.calculationType == CalculatedProjection.CalculationType.Minus)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 9 : 10;
              continue;
            }
            if (this.firstProjection == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 1 : 2;
              continue;
            }
            goto case 3;
          case 12:
            obj = (object) new SqlString((string) CalculatedProjection.ekr4rbWDUKiwvXY3NOuc((object) criteriaQuery, (object) criteria, (object) this.firstPropertyName));
            break;
          default:
            goto label_15;
        }
        sqlString1 = (SqlString) obj;
        num = 5;
      }
label_11:
      return (SqlString) CalculatedProjection.m5yZ0iWtBtYsHeidrAmu((object) ((SqlStringBuilder) CalculatedProjection.c3eYaVWDzFuytlYBCpg3(CalculatedProjection.c3eYaVWDzFuytlYBCpg3((object) ((SqlStringBuilder) CalculatedProjection.c3eYaVWDzFuytlYBCpg3((object) new SqlStringBuilder().Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(44884861 ^ 44891339)), (object) CalculatedProjection.TypeToString(this.calculationType))).Add(sqlString1), CalculatedProjection.ol6SDfWDrfGXCXkZWMQb(~541731958 ^ -541733835)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1837662597 ^ -1837799785))).Add((string) CalculatedProjection.vknCyyWtFgApMbEMg41G((object) this, loc)[0]));
label_15:
      return (SqlString) CalculatedProjection.m5yZ0iWtBtYsHeidrAmu((object) ((SqlStringBuilder) CalculatedProjection.c3eYaVWDzFuytlYBCpg3(CalculatedProjection.c3eYaVWDzFuytlYBCpg3((object) ((SqlStringBuilder) CalculatedProjection.c3eYaVWDzFuytlYBCpg3(CalculatedProjection.qAXHfpWto5qfZFGOpNb5(CalculatedProjection.mFLvLCWtWWp7n5YGoSrM((object) new SqlStringBuilder(), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1255365154 ^ 596875508 ^ -1765858660)), (object) sqlString1), CalculatedProjection.KmlRjVWtb9r5UX9iM41i(this.calculationType))).Add(sqlString2), CalculatedProjection.ol6SDfWDrfGXCXkZWMQb(-2112703338 ^ -2112705750)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1470998129 - 231418599 ^ 1239442278))).Add((string) CalculatedProjection.vknCyyWtFgApMbEMg41G((object) this, loc)[0]));
    }

    /// <summary>Converts the objects to an sql string representation</summary>
    /// <param name="criteria">The criteria being used in the query</param>
    /// <param name="criteriaQuery">The criteria query</param>
    /// <returns>The calculation as an sql string</returns>
    public override SqlString ToGroupSqlString(ICriteria criteria, ICriteriaQuery criteriaQuery)
    {
      int num = 1;
      StringBuilder stringBuilder;
      while (true)
      {
        switch (num)
        {
          case 1:
            stringBuilder = new StringBuilder();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return new SqlString(new object[1]
      {
        (object) stringBuilder.ToString()
      });
    }

    /// <summary>Returns the string symbol of calculation type</summary>
    /// <param name="type">The type to use</param>
    /// <returns>The string representation</returns>
    private static string TypeToString(CalculatedProjection.CalculationType type)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_9;
          case 2:
            switch (type)
            {
              case CalculatedProjection.CalculationType.Addition:
                goto label_4;
              case CalculatedProjection.CalculationType.Subtraction:
                goto label_5;
              case CalculatedProjection.CalculationType.Division:
                goto label_7;
              case CalculatedProjection.CalculationType.Multiplication:
                goto label_6;
              case CalculatedProjection.CalculationType.Minus:
                goto label_8;
              default:
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 1;
                continue;
            }
          default:
            goto label_4;
        }
      }
label_4:
      return (string) CalculatedProjection.ol6SDfWDrfGXCXkZWMQb(1251470110 >> 2 ^ 312849689);
label_5:
      return (string) CalculatedProjection.ol6SDfWDrfGXCXkZWMQb(--1360331293 ^ 1360333937);
label_6:
      return (string) CalculatedProjection.ol6SDfWDrfGXCXkZWMQb(--1867379187 ^ 1867359139);
label_7:
      return (string) CalculatedProjection.ol6SDfWDrfGXCXkZWMQb(-1255365154 ^ 596875508 ^ -1765844614);
label_8:
      return (string) CalculatedProjection.ol6SDfWDrfGXCXkZWMQb(~541731958 ^ -541729307);
label_9:
      return z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1858867585);
    }

    internal static void o718MJWDl7UhVEHMr2pg() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool slvZvtWD935i0Umw86SB() => CalculatedProjection.ahiS0CWDJ20J86TI2dnS == null;

    internal static CalculatedProjection I8L1cbWDdJrBABAGx1pP() => CalculatedProjection.ahiS0CWDJ20J86TI2dnS;

    internal static object ol6SDfWDrfGXCXkZWMQb(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object xNsSm4WDgcDHak1HCBV8([In] object obj0) => (object) string.Concat((string[]) obj0);

    internal static object MGnuq3WD55wGo2p6S0YE([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((IProjection) obj0).GetTypes((ICriteria) obj1, (ICriteriaQuery) obj2);

    internal static object p6LruDWDjKKQ9HJZrkMB([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((ICriteriaQuery) obj0).GetType((ICriteria) obj1, (string) obj2);

    internal static int mFvo4vWDYGbn7xCMamIO([In] object obj0) => ((List<IType>) obj0).Count;

    internal static object hUtiqWWDL8FPsLjMDju5([In] object obj0) => (object) ((List<IType>) obj0).ToArray();

    internal static object ekr4rbWDUKiwvXY3NOuc([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((ICriteriaQuery) obj0).GetColumn((ICriteria) obj1, (string) obj2);

    internal static object fFQFJwWDsOPsLSTZibO6([In] object obj0, [In] object obj1, [In] int obj2, [In] object obj3) => (object) ((IProjection) obj0).ToSqlString((ICriteria) obj1, obj2, (ICriteriaQuery) obj3);

    internal static object w9pnouWDcjgn63W6q90u([In] object obj0) => (object) StringHelper.RemoveAsAliasesFromSql((SqlString) obj0);

    internal static object c3eYaVWDzFuytlYBCpg3([In] object obj0, [In] object obj1) => (object) ((SqlStringBuilder) obj0).Add((string) obj1);

    internal static object vknCyyWtFgApMbEMg41G([In] object obj0, [In] int obj1) => (object) ((SimpleProjection) obj0).GetColumnAliases(obj1);

    internal static object m5yZ0iWtBtYsHeidrAmu([In] object obj0) => (object) ((SqlStringBuilder) obj0).ToSqlString();

    internal static object mFLvLCWtWWp7n5YGoSrM([In] object obj0, [In] object obj1) => (object) ((SqlStringBuilder) obj0).Add((string) obj1);

    internal static object qAXHfpWto5qfZFGOpNb5([In] object obj0, [In] object obj1) => (object) ((SqlStringBuilder) obj0).Add((SqlString) obj1);

    internal static object KmlRjVWtb9r5UX9iM41i(CalculatedProjection.CalculationType type) => (object) CalculatedProjection.TypeToString(type);

    /// <summary>The type of calculation</summary>
    public enum CalculationType
    {
      /// <summary>Addition +</summary>
      Addition,
      /// <summary>Subtraction -</summary>
      Subtraction,
      /// <summary>Division /</summary>
      Division,
      /// <summary>Division *</summary>
      Multiplication,
      /// <summary>Unary minus -</summary>
      Minus,
    }
  }
}
