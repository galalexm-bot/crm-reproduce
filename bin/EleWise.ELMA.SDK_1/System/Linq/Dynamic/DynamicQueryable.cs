// Decompiled with JetBrains decompiler
// Type: System.Linq.Dynamic.DynamicQueryable
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using SG9KiyIbtdgGDf12qr;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.InteropServices;

namespace System.Linq.Dynamic
{
  public static class DynamicQueryable
  {
    private static DynamicQueryable CwOQCebVnodNfUdryps;

    public static IQueryable<T> Where<T>(
      this IQueryable<T> source,
      string predicate,
      params object[] values)
    {
      return (IQueryable<T>) source.Where(predicate, values);
    }

    public static IQueryable Where(
      this IQueryable source,
      string predicate,
      params object[] values)
    {
      int num = 1;
      LambdaExpression lambda;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (source != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 0 : 0;
              continue;
            }
            goto label_6;
          case 2:
            goto label_4;
          case 3:
            goto label_9;
          case 4:
            goto label_6;
          default:
            if (predicate != null)
            {
              // ISSUE: type reference
              lambda = DynamicExpression.ParseLambda(source.ElementType, DynamicQueryable.JfQ4jGbqS2VZ0AfGXkW(__typeref (bool)), predicate, values);
              num = 3;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 1 : 2;
            continue;
        }
      }
label_4:
      throw new ArgumentNullException((string) DynamicQueryable.mD8o2IbR0SLp5fF8SOn(-2099751081 ^ -2099749407));
label_6:
      throw new ArgumentNullException((string) DynamicQueryable.mD8o2IbR0SLp5fF8SOn(-2092274397 << 4 ^ 883349654));
label_9:
      return ((IQueryProvider) DynamicQueryable.afnIjgbKCRWX6LpMnuK((object) source)).CreateQuery((Expression) DynamicQueryable.gmSNWRbnpbgcZHkZWiE(typeof (Queryable), DynamicQueryable.mD8o2IbR0SLp5fF8SOn(-16752921 ^ -16755669), (object) new Type[1]
      {
        DynamicQueryable.Q5HRCNbXCGCTIXAShjr((object) source)
      }, (object) new Expression[2]
      {
        (Expression) DynamicQueryable.sX2xITbT9yKef8gry4i((object) source),
        (Expression) DynamicQueryable.Fi1NaPbkLbBckojrqwM((object) lambda)
      }));
    }

    public static IQueryable Select(
      this IQueryable source,
      string selector,
      params object[] values)
    {
      int num = 1;
      LambdaExpression lambda;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (source == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 0;
              continue;
            }
            if (selector != null)
            {
              lambda = DynamicExpression.ParseLambda(DynamicQueryable.Q5HRCNbXCGCTIXAShjr((object) source), (Type) null, selector, values);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 2 : 1;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 3 : 3;
            continue;
          case 2:
            goto label_6;
          case 3:
            goto label_2;
          default:
            goto label_7;
        }
      }
label_2:
      throw new ArgumentNullException((string) DynamicQueryable.mD8o2IbR0SLp5fF8SOn(-812025778 ^ -812027244));
label_6:
      // ISSUE: type reference
      return (IQueryable) DynamicQueryable.gykoixbe1VsXdQxOM6C(DynamicQueryable.afnIjgbKCRWX6LpMnuK((object) source), DynamicQueryable.gmSNWRbnpbgcZHkZWiE(DynamicQueryable.JfQ4jGbqS2VZ0AfGXkW(__typeref (Queryable)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(~289714581 ^ -289717116), (object) new Type[2]
      {
        source.ElementType,
        DynamicQueryable.UP975Fb2jtUgeSYBZxN(DynamicQueryable.UQZmdebOWnCWP9qKq0q((object) lambda))
      }, (object) new Expression[2]
      {
        (Expression) DynamicQueryable.sX2xITbT9yKef8gry4i((object) source),
        (Expression) DynamicQueryable.Fi1NaPbkLbBckojrqwM((object) lambda)
      }));
label_7:
      throw new ArgumentNullException((string) DynamicQueryable.mD8o2IbR0SLp5fF8SOn(--1867379187 ^ 1867381589));
    }

    public static IQueryable<T> OrderBy<T>(
      this IQueryable<T> source,
      string ordering,
      params object[] values)
    {
      return (IQueryable<T>) source.OrderBy(ordering, values);
    }

    public static IQueryable OrderBy(
      this IQueryable source,
      string ordering,
      params object[] values)
    {
      int num1 = 1;
      Expression expression;
      ParameterExpression[] parameters;
      string str1;
      string str2;
      IEnumerator<DynamicOrdering> enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (source != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 0 : 0;
              continue;
            }
            goto label_18;
          case 2:
            IEnumerable<DynamicOrdering> ordering1 = new ExpressionParser(parameters, ordering, values).ParseOrdering();
            expression = source.Expression;
            str1 = (string) DynamicQueryable.mD8o2IbR0SLp5fF8SOn(-1939377524 ^ -1939375714);
            str2 = (string) DynamicQueryable.mD8o2IbR0SLp5fF8SOn(1994213607 >> 4 ^ 124641194);
            enumerator = ordering1.GetEnumerator();
            num1 = 5;
            continue;
          case 3:
            goto label_23;
          case 4:
            goto label_18;
          case 5:
            goto label_4;
          case 6:
            goto label_2;
          default:
            if (ordering == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 2 : 3;
              continue;
            }
            parameters = new ParameterExpression[1]
            {
              (ParameterExpression) DynamicQueryable.Ux5WyjbPBOH1bcOjoI6(DynamicQueryable.Q5HRCNbXCGCTIXAShjr((object) source), (object) "")
            };
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 2 : 2;
            continue;
        }
      }
label_2:
      return (IQueryable) DynamicQueryable.gykoixbe1VsXdQxOM6C(DynamicQueryable.afnIjgbKCRWX6LpMnuK((object) source), (object) expression);
label_4:
      try
      {
label_6:
        if (enumerator.MoveNext())
          goto label_10;
        else
          goto label_7;
label_5:
        DynamicOrdering current;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              expression = (Expression) DynamicQueryable.gmSNWRbnpbgcZHkZWiE(typeof (Queryable), (object) (!current.Ascending ? str2 : str1), (object) new Type[2]
              {
                DynamicQueryable.Q5HRCNbXCGCTIXAShjr((object) source),
                DynamicQueryable.UP975Fb2jtUgeSYBZxN((object) current.Selector)
              }, (object) new Expression[2]
              {
                expression,
                (Expression) Expression.Quote((Expression) Expression.Lambda(current.Selector, parameters))
              });
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_2;
            case 3:
              goto label_10;
            case 4:
              str2 = (string) DynamicQueryable.mD8o2IbR0SLp5fF8SOn(-710283084 ^ -537863435 ^ 173613339);
              num2 = 5;
              continue;
            case 5:
              goto label_6;
            default:
              str1 = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1998538950 ^ -1998537616);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 3 : 4;
              continue;
          }
        }
label_7:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 2 : 0;
        goto label_5;
label_10:
        current = enumerator.Current;
        num2 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
        {
          num2 = 0;
          goto label_5;
        }
        else
          goto label_5;
      }
      finally
      {
        int num3;
        if (enumerator == null)
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 0 : 0;
        else
          goto label_16;
label_15:
        switch (num3)
        {
          case 1:
            break;
          default:
        }
label_16:
        DynamicQueryable.AGxUuGb1H35xpl6kQ7I((object) enumerator);
        num3 = 2;
        goto label_15;
      }
label_18:
      throw new ArgumentNullException((string) DynamicQueryable.mD8o2IbR0SLp5fF8SOn(-649342099 - -1150814748 ^ 501471023));
label_23:
      throw new ArgumentNullException((string) DynamicQueryable.mD8o2IbR0SLp5fF8SOn(712480695 ^ 712482121));
    }

    public static IQueryable Take(this IQueryable source, int count)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (source != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 0 : 0;
              continue;
            }
            goto label_4;
          case 2:
            goto label_4;
          default:
            goto label_5;
        }
      }
label_4:
      throw new ArgumentNullException((string) DynamicQueryable.mD8o2IbR0SLp5fF8SOn(--1867379187 ^ 1867381589));
label_5:
      // ISSUE: type reference
      return (IQueryable) DynamicQueryable.gykoixbe1VsXdQxOM6C(DynamicQueryable.afnIjgbKCRWX6LpMnuK((object) source), DynamicQueryable.gmSNWRbnpbgcZHkZWiE(DynamicQueryable.JfQ4jGbqS2VZ0AfGXkW(__typeref (Queryable)), DynamicQueryable.mD8o2IbR0SLp5fF8SOn(-1921202237 ^ -1921200963), (object) new Type[1]
      {
        DynamicQueryable.Q5HRCNbXCGCTIXAShjr((object) source)
      }, (object) new Expression[2]
      {
        (Expression) DynamicQueryable.sX2xITbT9yKef8gry4i((object) source),
        (Expression) DynamicQueryable.dTobGdbNkqLvxKejHeH((object) count)
      }));
    }

    public static IQueryable Skip(this IQueryable source, int count)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            if (source != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 1 : 1;
              continue;
            }
            goto label_2;
          default:
            goto label_2;
        }
      }
label_2:
      throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1317792138));
label_3:
      // ISSUE: type reference
      return (IQueryable) DynamicQueryable.gykoixbe1VsXdQxOM6C(DynamicQueryable.afnIjgbKCRWX6LpMnuK((object) source), DynamicQueryable.gmSNWRbnpbgcZHkZWiE(DynamicQueryable.JfQ4jGbqS2VZ0AfGXkW(__typeref (Queryable)), DynamicQueryable.mD8o2IbR0SLp5fF8SOn(874012245 ^ 874010079), (object) new Type[1]
      {
        DynamicQueryable.Q5HRCNbXCGCTIXAShjr((object) source)
      }, (object) new Expression[2]
      {
        (Expression) DynamicQueryable.sX2xITbT9yKef8gry4i((object) source),
        (Expression) DynamicQueryable.dTobGdbNkqLvxKejHeH((object) count)
      }));
    }

    public static IQueryable GroupBy(
      this IQueryable source,
      string keySelector,
      string elementSelector,
      params object[] values)
    {
      int num = 6;
      LambdaExpression lambda1;
      LambdaExpression lambda2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_6;
          case 2:
            goto label_10;
          case 3:
            lambda1 = DynamicExpression.ParseLambda(DynamicQueryable.Q5HRCNbXCGCTIXAShjr((object) source), (Type) null, keySelector, values);
            num = 7;
            continue;
          case 4:
            goto label_11;
          case 5:
            if (keySelector != null)
            {
              if (elementSelector != null)
              {
                num = 3;
                continue;
              }
              goto label_2;
            }
            else
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 1 : 1;
              continue;
            }
          case 6:
            if (source != null)
            {
              num = 5;
              continue;
            }
            goto label_11;
          case 7:
            lambda2 = DynamicExpression.ParseLambda(DynamicQueryable.Q5HRCNbXCGCTIXAShjr((object) source), (Type) null, elementSelector, values);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 2 : 2;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      throw new ArgumentNullException((string) DynamicQueryable.mD8o2IbR0SLp5fF8SOn(1021410165 ^ 1021407429));
label_6:
      throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1360331293 ^ 1360333195));
label_10:
      return (IQueryable) DynamicQueryable.gykoixbe1VsXdQxOM6C((object) source.Provider, (object) Expression.Call(typeof (Queryable), (string) DynamicQueryable.mD8o2IbR0SLp5fF8SOn(1232639661 >> 3 ^ 154081543), new Type[3]
      {
        DynamicQueryable.Q5HRCNbXCGCTIXAShjr((object) source),
        DynamicQueryable.UP975Fb2jtUgeSYBZxN(DynamicQueryable.UQZmdebOWnCWP9qKq0q((object) lambda1)),
        ((Expression) DynamicQueryable.UQZmdebOWnCWP9qKq0q((object) lambda2)).Type
      }, (Expression) DynamicQueryable.sX2xITbT9yKef8gry4i((object) source), (Expression) Expression.Quote((Expression) lambda1), (Expression) DynamicQueryable.Fi1NaPbkLbBckojrqwM((object) lambda2)));
label_11:
      throw new ArgumentNullException((string) DynamicQueryable.mD8o2IbR0SLp5fF8SOn(979449278 ^ 979451672));
    }

    public static bool Any(this IQueryable source)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (source == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      throw new ArgumentNullException((string) DynamicQueryable.mD8o2IbR0SLp5fF8SOn(323422137 << 2 ^ 1293685826));
label_3:
      // ISSUE: type reference
      return (bool) DynamicQueryable.ygICXXb31xre3IIQOO9(DynamicQueryable.afnIjgbKCRWX6LpMnuK((object) source), DynamicQueryable.gmSNWRbnpbgcZHkZWiE(DynamicQueryable.JfQ4jGbqS2VZ0AfGXkW(__typeref (Queryable)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1917256330 ^ 1917258094), (object) new Type[1]
      {
        DynamicQueryable.Q5HRCNbXCGCTIXAShjr((object) source)
      }, (object) new Expression[1]
      {
        (Expression) DynamicQueryable.sX2xITbT9yKef8gry4i((object) source)
      }));
    }

    public static int Count(this IQueryable source)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (source == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      throw new ArgumentNullException((string) DynamicQueryable.mD8o2IbR0SLp5fF8SOn(1642859704 ^ 1642858014));
label_5:
      // ISSUE: type reference
      return (int) ((IQueryProvider) DynamicQueryable.afnIjgbKCRWX6LpMnuK((object) source)).Execute((Expression) Expression.Call(DynamicQueryable.JfQ4jGbqS2VZ0AfGXkW(__typeref (Queryable)), (string) DynamicQueryable.mD8o2IbR0SLp5fF8SOn(-680446928 - -370807692 ^ -309638062), new Type[1]
      {
        source.ElementType
      }, (Expression) DynamicQueryable.sX2xITbT9yKef8gry4i((object) source)));
    }

    internal static object mD8o2IbR0SLp5fF8SOn(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static Type JfQ4jGbqS2VZ0AfGXkW([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object afnIjgbKCRWX6LpMnuK([In] object obj0) => (object) ((IQueryable) obj0).Provider;

    internal static Type Q5HRCNbXCGCTIXAShjr([In] object obj0) => ((IQueryable) obj0).ElementType;

    internal static object sX2xITbT9yKef8gry4i([In] object obj0) => (object) ((IQueryable) obj0).Expression;

    internal static object Fi1NaPbkLbBckojrqwM([In] object obj0) => (object) Expression.Quote((Expression) obj0);

    internal static object gmSNWRbnpbgcZHkZWiE([In] Type obj0, [In] object obj1, [In] object obj2, [In] object obj3) => (object) Expression.Call(obj0, (string) obj1, (Type[]) obj2, (Expression[]) obj3);

    internal static bool ERipGcbSkjNPMWNxOaI() => DynamicQueryable.CwOQCebVnodNfUdryps == null;

    internal static DynamicQueryable ClqGoabimHVtWg5Uwuu() => DynamicQueryable.CwOQCebVnodNfUdryps;

    internal static object UQZmdebOWnCWP9qKq0q([In] object obj0) => (object) ((LambdaExpression) obj0).Body;

    internal static Type UP975Fb2jtUgeSYBZxN([In] object obj0) => ((Expression) obj0).Type;

    internal static object gykoixbe1VsXdQxOM6C([In] object obj0, [In] object obj1) => (object) ((IQueryProvider) obj0).CreateQuery((Expression) obj1);

    internal static object Ux5WyjbPBOH1bcOjoI6([In] Type obj0, [In] object obj1) => (object) Expression.Parameter(obj0, (string) obj1);

    internal static void AGxUuGb1H35xpl6kQ7I([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object dTobGdbNkqLvxKejHeH([In] object obj0) => (object) Expression.Constant(obj0);

    internal static object ygICXXb31xre3IIQOO9([In] object obj0, [In] object obj1) => ((IQueryProvider) obj0).Execute((Expression) obj1);
  }
}
