// Decompiled with JetBrains decompiler
// Type: Microsoft.Web.Mvc.ExpressionUtil.CachedExpressionCompiler
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;

namespace Microsoft.Web.Mvc.ExpressionUtil
{
  internal static class CachedExpressionCompiler
  {
    public static Func<TModel, TValue> Process<TModel, TValue>(
      Expression<Func<TModel, TValue>> lambdaExpression)
    {
      return CachedExpressionCompiler.Compiler<TModel, TValue>.Compile(lambdaExpression);
    }

    private static class Compiler<TIn, TOut>
    {
      private static readonly ConcurrentDictionary<MemberInfo, Func<TIn, TOut>> _simpleMemberAccessDict;
      private static readonly ConcurrentDictionary<MemberInfo, Func<object, TOut>> _constMemberAccessDict;
      private static readonly ConcurrentDictionary<ExpressionFingerprintChain, Hoisted<TIn, TOut>> _fingerprintedCache;
      private static Func<TIn, TOut> _identityFunc;
      private static object b7jaSkf4m89bwDS9nJb4;

      public static Func<TIn, TOut> Compile(Expression<Func<TIn, TOut>> expr) => CachedExpressionCompiler.Compiler<TIn, TOut>.CompileFromIdentityFunc(expr) ?? CachedExpressionCompiler.Compiler<TIn, TOut>.CompileFromConstLookup(expr) ?? CachedExpressionCompiler.Compiler<TIn, TOut>.CompileFromMemberAccess(expr) ?? CachedExpressionCompiler.Compiler<TIn, TOut>.CompileFromFingerprint(expr) ?? CachedExpressionCompiler.Compiler<TIn, TOut>.CompileSlow(expr);

      private static Func<TIn, TOut> CompileFromConstLookup(Expression<Func<TIn, TOut>> expr)
      {
        if (!(expr.Body is ConstantExpression body))
          return (Func<TIn, TOut>) null;
        TOut constantValue = (TOut) body.Value;
        return (Func<TIn, TOut>) (_ => constantValue);
      }

      private static Func<TIn, TOut> CompileFromIdentityFunc(Expression<Func<TIn, TOut>> expr)
      {
        if (expr.Body != expr.Parameters[0])
          return (Func<TIn, TOut>) null;
        if (CachedExpressionCompiler.Compiler<TIn, TOut>._identityFunc == null)
          CachedExpressionCompiler.Compiler<TIn, TOut>._identityFunc = expr.Compile();
        return CachedExpressionCompiler.Compiler<TIn, TOut>._identityFunc;
      }

      private static Func<TIn, TOut> CompileFromFingerprint(Expression<Func<TIn, TOut>> expr)
      {
        List<object> capturedConstants;
        ExpressionFingerprintChain fingerprintChain = FingerprintingExpressionVisitor.GetFingerprintChain((Expression) expr, out capturedConstants);
        if (fingerprintChain == null)
          return (Func<TIn, TOut>) null;
        Hoisted<TIn, TOut> del = CachedExpressionCompiler.Compiler<TIn, TOut>._fingerprintedCache.GetOrAdd(fingerprintChain, (Func<ExpressionFingerprintChain, Hoisted<TIn, TOut>>) (_ => HoistingExpressionVisitor<TIn, TOut>.Hoist(expr).Compile()));
        return (Func<TIn, TOut>) (model => del(model, capturedConstants));
      }

      private static Func<TIn, TOut> CompileFromMemberAccess(Expression<Func<TIn, TOut>> expr)
      {
        MemberExpression memberExpr = expr.Body as MemberExpression;
        if (memberExpr != null)
        {
          if (memberExpr.Expression == expr.Parameters[0] || memberExpr.Expression == null)
            return CachedExpressionCompiler.Compiler<TIn, TOut>._simpleMemberAccessDict.GetOrAdd(memberExpr.Member, (Func<MemberInfo, Func<TIn, TOut>>) (_ => expr.Compile()));
          if (memberExpr.Expression is ConstantExpression expression)
          {
            ParameterExpression parameterExpression = (ParameterExpression) null;
            Func<object, TOut> del = CachedExpressionCompiler.Compiler<TIn, TOut>._constMemberAccessDict.GetOrAdd(memberExpr.Member, (Func<MemberInfo, Func<object, TOut>>) (_ => Expression.Lambda<Func<object, TOut>>((Expression) memberExpr.Update((Expression) Expression.Convert((Expression) parameterExpression, memberExpr.Member.DeclaringType)), parameterExpression).Compile()));
            object capturedLocal = expression.Value;
            return (Func<TIn, TOut>) (_ => del(capturedLocal));
          }
        }
        return (Func<TIn, TOut>) null;
      }

      private static Func<TIn, TOut> CompileSlow(Expression<Func<TIn, TOut>> expr) => expr.Compile();

      static Compiler()
      {
        int num1 = 2;
        while (true)
        {
          int num2 = num1;
          while (true)
          {
            switch (num2)
            {
              case 1:
                CachedExpressionCompiler.Compiler<TIn, TOut>._simpleMemberAccessDict = new ConcurrentDictionary<MemberInfo, Func<TIn, TOut>>();
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 0 : 0;
                continue;
              case 2:
                TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 1 : 1;
                continue;
              case 3:
                goto label_3;
              case 4:
                goto label_7;
              default:
                CachedExpressionCompiler.Compiler<TIn, TOut>._constMemberAccessDict = new ConcurrentDictionary<MemberInfo, Func<object, TOut>>();
                num2 = 4;
                continue;
            }
          }
label_7:
          CachedExpressionCompiler.Compiler<TIn, TOut>._fingerprintedCache = new ConcurrentDictionary<ExpressionFingerprintChain, Hoisted<TIn, TOut>>();
          num1 = 3;
        }
label_3:;
      }

      internal static bool O5F3oZf4yuhXrqaRF22h() => CachedExpressionCompiler.Compiler<TIn, TOut>.b7jaSkf4m89bwDS9nJb4 == null;

      internal static object EGkHngf4MPXyWCS0Wcya() => CachedExpressionCompiler.Compiler<TIn, TOut>.b7jaSkf4m89bwDS9nJb4;
    }
  }
}
