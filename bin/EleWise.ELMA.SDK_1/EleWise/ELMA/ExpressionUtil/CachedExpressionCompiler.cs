// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ExpressionUtil.CachedExpressionCompiler
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Linq.Expressions;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.ExpressionUtil
{
  public static class CachedExpressionCompiler
  {
    private static readonly ParameterExpression _unusedParameterExpr;
    internal static CachedExpressionCompiler Sm8UfcGrDJiQCUvGSoVt;

    public static Func<TModel, TValue> Compile<TModel, TValue>(
      this Expression<Func<TModel, TValue>> lambdaExpression)
    {
      return lambdaExpression != null ? Microsoft.Web.Mvc.ExpressionUtil.CachedExpressionCompiler.Process<TModel, TValue>(lambdaExpression) : throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(381945751 ^ 1158627804 ^ 1406096599));
    }

    public static object Evaluate(Expression arg)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (arg != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 0 : 0;
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
      throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(901793403 ^ 901964791));
label_5:
      return CachedExpressionCompiler.Wrap((object) arg)((object) null);
    }

    private static Func<object, object> Wrap(object arg) => Microsoft.Web.Mvc.ExpressionUtil.CachedExpressionCompiler.Process<object, object>(Expression.Lambda<Func<object, object>>((Expression) Expression.Convert((Expression) arg, typeof (object)), CachedExpressionCompiler._unusedParameterExpr));

    static CachedExpressionCompiler()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            CachedExpressionCompiler.lP2hNiGr4XCpK57mFk8O();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            // ISSUE: type reference
            CachedExpressionCompiler._unusedParameterExpr = Expression.Parameter(CachedExpressionCompiler.zJKRJjGr6ZvoyGceoDK6(__typeref (object)), (string) CachedExpressionCompiler.beVtt6GrH3gTQCWeBtDL(-1290212282 ^ -644262414 ^ 1787145076));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 0 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static bool mk2o76GrtdYmLdNC9ULE() => CachedExpressionCompiler.Sm8UfcGrDJiQCUvGSoVt == null;

    internal static CachedExpressionCompiler wXKuJoGrwS4wIJEipXUM() => CachedExpressionCompiler.Sm8UfcGrDJiQCUvGSoVt;

    internal static void lP2hNiGr4XCpK57mFk8O() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static Type zJKRJjGr6ZvoyGceoDK6([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object beVtt6GrH3gTQCWeBtDL(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
  }
}
