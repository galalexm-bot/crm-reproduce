// Decompiled with JetBrains decompiler
// Type: Microsoft.Web.Mvc.ExpressionUtil.HoistingExpressionVisitor`2
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Microsoft.Web.Mvc.ExpressionUtil
{
  internal sealed class HoistingExpressionVisitor<TIn, TOut> : ExpressionVisitor
  {
    private static readonly ParameterExpression _hoistedConstantsParamExpr;
    private int _numConstantsProcessed;
    private static object j1YFhGoC35H8ETTao8p;

    private HoistingExpressionVisitor()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    public static Expression<Hoisted<TIn, TOut>> Hoist(Expression<Func<TIn, TOut>> expr) => Expression.Lambda<Hoisted<TIn, TOut>>(new HoistingExpressionVisitor<TIn, TOut>().Visit(expr.Body), expr.Parameters[0], HoistingExpressionVisitor<TIn, TOut>._hoistedConstantsParamExpr);

    protected override Expression VisitConstant(ConstantExpression node) => (Expression) Expression.Convert((Expression) Expression.Property((Expression) HoistingExpressionVisitor<TIn, TOut>._hoistedConstantsParamExpr, z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1418440330 ^ 1418438628), (Expression) Expression.Constant((object) this._numConstantsProcessed++)), node.Type);

    static HoistingExpressionVisitor()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            HoistingExpressionVisitor<TIn, TOut>._hoistedConstantsParamExpr = Expression.Parameter(typeof (List<object>), z2jc63fLkugS1X8Q9N.tE1kD1vbB(92412609 - 1050237057 ^ -957822150));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 2 : 0;
            continue;
        }
      }
label_2:;
    }

    internal static bool fbtnQNovIINKpVKEyOn() => HoistingExpressionVisitor<TIn, TOut>.j1YFhGoC35H8ETTao8p == null;

    internal static object ib3eVMo8NFYusEpmFQV() => HoistingExpressionVisitor<TIn, TOut>.j1YFhGoC35H8ETTao8p;
  }
}
