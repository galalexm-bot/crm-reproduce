// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ExpressionUtil.ExpressionCompiler
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq.Expressions;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Threading;

namespace EleWise.ELMA.ExpressionUtil
{
  /// <summary>Compiles expression to delegate ~20 times faster than Expression.Compile.
  /// Partial to extend with your things when used as source file.</summary>
  internal static class ExpressionCompiler
  {
    private static readonly Type[] _closureAsASingleParamType;
    private static readonly Type[][] _closureTypePlusParamTypesPool;
    public static readonly ExpressionCompiler.ArrayClosure EmptyArrayClosure;
    public static FieldInfo ArrayClosureArrayField;
    public static FieldInfo ArrayClosureWithNonPassedParamsField;
    public static ConstructorInfo ArrayClosureWithNonPassedParamsConstructor;
    internal static ExpressionCompiler CN5P1LGlJTFMqrvxeopG;

    /// <summary>Compiles lambda expression to TDelegate type. Use ifFastFailedReturnNull parameter to Not fallback to Expression.Compile, useful for testing.</summary>
    public static TDelegate CompileFast<TDelegate>(
      this LambdaExpression lambdaExpr,
      bool ifFastFailedReturnNull = false)
      where TDelegate : class
    {
      return (TDelegate) (ExpressionCompiler.TryCompileBoundToFirstClosureParam(typeof (TDelegate) == typeof (Delegate) ? lambdaExpr.Type : typeof (TDelegate), lambdaExpr.Body, (IReadOnlyList<ParameterExpression>) lambdaExpr.Parameters, ExpressionCompiler.GetClosureTypeToParamTypes((IReadOnlyList<ParameterExpression>) lambdaExpr.Parameters), lambdaExpr.ReturnType) ?? (ifFastFailedReturnNull ? (object) null : (object) lambdaExpr.CompileSys()));
    }

    /// Compiles a static method to the passed IL Generator.
    ///             Could be used as alternative for `CompileToMethod` like this <code><![CDATA[funcExpr.CompileFastToIL(methodBuilder.GetILGenerator())]]></code>
    /// .
    ///             Check `IssueTests.Issue179_Add_something_like_LambdaExpression_CompileToMethod.cs` for example.
    public static bool CompileFastToIL(
      this LambdaExpression lambdaExpr,
      ILGenerator il,
      bool ifFastFailedReturnNull = false)
    {
      int num1 = 2;
      while (true)
      {
        ExpressionCompiler.ClosureInfo closure;
        ExpressionCompiler.ParentFlags parent;
        int num2;
        switch (num1)
        {
          case 1:
            // ISSUE: type reference
            if (lambdaExpr.ReturnType == ExpressionCompiler.JkmB0yGllAfHfTkdILLI(__typeref (void)))
            {
              num1 = 5;
              continue;
            }
            goto case 3;
          case 2:
            closure = new ExpressionCompiler.ClosureInfo(ExpressionCompiler.ClosureStatus.ShouldBeStaticMethod);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 1 : 1;
            continue;
          case 3:
            num2 = 0;
            break;
          case 4:
            goto label_7;
          case 5:
            num2 = 2;
            break;
          case 6:
            if (!ExpressionCompiler.EmittingVisitor.TryEmit(ExpressionCompiler.WbynNKGlrTj29YWqJQaj((object) lambdaExpr), (IReadOnlyList<ParameterExpression>) lambdaExpr.Parameters, (object) il, ref closure, parent))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 0 : 0;
              continue;
            }
            ExpressionCompiler.oYYXJrGlgD1jeK8CT6Df((object) il, OpCodes.Ret);
            num1 = 4;
            continue;
          default:
            goto label_9;
        }
        parent = (ExpressionCompiler.ParentFlags) num2;
        num1 = 6;
      }
label_7:
      return true;
label_9:
      return false;
    }

    /// <summary>Compiles lambda expression to delegate. Use ifFastFailedReturnNull parameter to Not fallback to Expression.Compile, useful for testing.</summary>
    public static Delegate CompileFast(
      this LambdaExpression lambdaExpr,
      bool ifFastFailedReturnNull = false)
    {
      int num1 = 2;
      Delegate firstClosureParam;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_4;
            case 2:
              firstClosureParam = (Delegate) ExpressionCompiler.TryCompileBoundToFirstClosureParam(ExpressionCompiler.suwSTaGl5Sj3Xtn547vC((object) lambdaExpr), (Expression) ExpressionCompiler.WbynNKGlrTj29YWqJQaj((object) lambdaExpr), (IReadOnlyList<ParameterExpression>) lambdaExpr.Parameters, ExpressionCompiler.GetClosureTypeToParamTypes((IReadOnlyList<ParameterExpression>) lambdaExpr.Parameters), ExpressionCompiler.SNk1duGlj46D25gVxGVD((object) lambdaExpr));
              if ((object) firstClosureParam == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 1 : 0;
                continue;
              }
              goto label_3;
            case 3:
              goto label_9;
            default:
              goto label_8;
          }
        }
label_4:
        if (ifFastFailedReturnNull)
          num1 = 3;
        else
          goto label_8;
      }
label_3:
      return firstClosureParam;
label_8:
      return (Delegate) ExpressionCompiler.AUcGUTGlY4agyWHYGUQq((object) lambdaExpr);
label_9:
      return (Delegate) null;
    }

    /// <summary>Unifies Compile for System.Linq.Expressions and FEC.LightExpression</summary>
    public static TDelegate CompileSys<TDelegate>(this Expression<TDelegate> lambdaExpr) where TDelegate : class => lambdaExpr.Compile();

    /// <summary>Unifies Compile for System.Linq.Expressions and FEC.LightExpression</summary>
    public static Delegate CompileSys(this LambdaExpression lambdaExpr) => (Delegate) ExpressionCompiler.Uj0Tc3GlLQB0qwWS8Fqv((object) lambdaExpr);

    /// <summary>Compiles lambda expression to TDelegate type. Use ifFastFailedReturnNull parameter to Not fallback to Expression.Compile, useful for testing.</summary>
    public static TDelegate CompileFast<TDelegate>(
      this Expression<TDelegate> lambdaExpr,
      bool ifFastFailedReturnNull = false)
      where TDelegate : class
    {
      return ExpressionCompiler.CompileFast<TDelegate>(lambdaExpr, ifFastFailedReturnNull);
    }

    /// <summary>Compiles lambda expression to delegate. Use ifFastFailedReturnNull parameter to Not fallback to Expression.Compile, useful for testing.</summary>
    public static Func<R> CompileFast<R>(
      this Expression<Func<R>> lambdaExpr,
      bool ifFastFailedReturnNull = false)
    {
      Func<R> firstClosureParam = (Func<R>) ExpressionCompiler.TryCompileBoundToFirstClosureParam(typeof (Func<R>), lambdaExpr.Body, (IReadOnlyList<ParameterExpression>) lambdaExpr.Parameters, ExpressionCompiler._closureAsASingleParamType, typeof (R));
      if (firstClosureParam != null)
        return firstClosureParam;
      return !ifFastFailedReturnNull ? lambdaExpr.CompileSys<Func<R>>() : (Func<R>) null;
    }

    /// <summary>Compiles lambda expression to delegate. Use ifFastFailedReturnNull parameter to Not fallback to Expression.Compile, useful for testing.</summary>
    public static Func<T1, R> CompileFast<T1, R>(
      this Expression<Func<T1, R>> lambdaExpr,
      bool ifFastFailedReturnNull = false)
    {
      Func<T1, R> firstClosureParam = (Func<T1, R>) ExpressionCompiler.TryCompileBoundToFirstClosureParam(typeof (Func<T1, R>), lambdaExpr.Body, (IReadOnlyList<ParameterExpression>) lambdaExpr.Parameters, new Type[2]
      {
        typeof (ExpressionCompiler.ArrayClosure),
        typeof (T1)
      }, typeof (R));
      if (firstClosureParam != null)
        return firstClosureParam;
      return !ifFastFailedReturnNull ? lambdaExpr.CompileSys<Func<T1, R>>() : (Func<T1, R>) null;
    }

    /// <summary>Compiles lambda expression to TDelegate type. Use ifFastFailedReturnNull parameter to Not fallback to Expression.Compile, useful for testing.</summary>
    public static Func<T1, T2, R> CompileFast<T1, T2, R>(
      this Expression<Func<T1, T2, R>> lambdaExpr,
      bool ifFastFailedReturnNull = false)
    {
      Func<T1, T2, R> firstClosureParam = (Func<T1, T2, R>) ExpressionCompiler.TryCompileBoundToFirstClosureParam(typeof (Func<T1, T2, R>), lambdaExpr.Body, (IReadOnlyList<ParameterExpression>) lambdaExpr.Parameters, new Type[3]
      {
        typeof (ExpressionCompiler.ArrayClosure),
        typeof (T1),
        typeof (T2)
      }, typeof (R));
      if (firstClosureParam != null)
        return firstClosureParam;
      return !ifFastFailedReturnNull ? lambdaExpr.CompileSys<Func<T1, T2, R>>() : (Func<T1, T2, R>) null;
    }

    /// <summary>Compiles lambda expression to delegate. Use ifFastFailedReturnNull parameter to Not fallback to Expression.Compile, useful for testing.</summary>
    public static Func<T1, T2, T3, R> CompileFast<T1, T2, T3, R>(
      this Expression<Func<T1, T2, T3, R>> lambdaExpr,
      bool ifFastFailedReturnNull = false)
    {
      Func<T1, T2, T3, R> firstClosureParam = (Func<T1, T2, T3, R>) ExpressionCompiler.TryCompileBoundToFirstClosureParam(typeof (Func<T1, T2, T3, R>), lambdaExpr.Body, (IReadOnlyList<ParameterExpression>) lambdaExpr.Parameters, new Type[4]
      {
        typeof (ExpressionCompiler.ArrayClosure),
        typeof (T1),
        typeof (T2),
        typeof (T3)
      }, typeof (R));
      if (firstClosureParam != null)
        return firstClosureParam;
      return !ifFastFailedReturnNull ? lambdaExpr.CompileSys<Func<T1, T2, T3, R>>() : (Func<T1, T2, T3, R>) null;
    }

    /// <summary>Compiles lambda expression to TDelegate type. Use ifFastFailedReturnNull parameter to Not fallback to Expression.Compile, useful for testing.</summary>
    public static Func<T1, T2, T3, T4, R> CompileFast<T1, T2, T3, T4, R>(
      this Expression<Func<T1, T2, T3, T4, R>> lambdaExpr,
      bool ifFastFailedReturnNull = false)
    {
      Func<T1, T2, T3, T4, R> firstClosureParam = (Func<T1, T2, T3, T4, R>) ExpressionCompiler.TryCompileBoundToFirstClosureParam(typeof (Func<T1, T2, T3, T4, R>), lambdaExpr.Body, (IReadOnlyList<ParameterExpression>) lambdaExpr.Parameters, new Type[5]
      {
        typeof (ExpressionCompiler.ArrayClosure),
        typeof (T1),
        typeof (T2),
        typeof (T3),
        typeof (T4)
      }, typeof (R));
      if (firstClosureParam != null)
        return firstClosureParam;
      return !ifFastFailedReturnNull ? lambdaExpr.CompileSys<Func<T1, T2, T3, T4, R>>() : (Func<T1, T2, T3, T4, R>) null;
    }

    /// <summary>Compiles lambda expression to delegate. Use ifFastFailedReturnNull parameter to Not fallback to Expression.Compile, useful for testing.</summary>
    public static Func<T1, T2, T3, T4, T5, R> CompileFast<T1, T2, T3, T4, T5, R>(
      this Expression<Func<T1, T2, T3, T4, T5, R>> lambdaExpr,
      bool ifFastFailedReturnNull = false)
    {
      Func<T1, T2, T3, T4, T5, R> firstClosureParam = (Func<T1, T2, T3, T4, T5, R>) ExpressionCompiler.TryCompileBoundToFirstClosureParam(typeof (Func<T1, T2, T3, T4, T5, R>), lambdaExpr.Body, (IReadOnlyList<ParameterExpression>) lambdaExpr.Parameters, new Type[6]
      {
        typeof (ExpressionCompiler.ArrayClosure),
        typeof (T1),
        typeof (T2),
        typeof (T3),
        typeof (T4),
        typeof (T5)
      }, typeof (R));
      if (firstClosureParam != null)
        return firstClosureParam;
      return !ifFastFailedReturnNull ? lambdaExpr.CompileSys<Func<T1, T2, T3, T4, T5, R>>() : (Func<T1, T2, T3, T4, T5, R>) null;
    }

    /// <summary>Compiles lambda expression to delegate. Use ifFastFailedReturnNull parameter to Not fallback to Expression.Compile, useful for testing.</summary>
    public static Func<T1, T2, T3, T4, T5, T6, R> CompileFast<T1, T2, T3, T4, T5, T6, R>(
      this Expression<Func<T1, T2, T3, T4, T5, T6, R>> lambdaExpr,
      bool ifFastFailedReturnNull = false)
    {
      Func<T1, T2, T3, T4, T5, T6, R> firstClosureParam = (Func<T1, T2, T3, T4, T5, T6, R>) ExpressionCompiler.TryCompileBoundToFirstClosureParam(typeof (Func<T1, T2, T3, T4, T5, T6, R>), lambdaExpr.Body, (IReadOnlyList<ParameterExpression>) lambdaExpr.Parameters, new Type[7]
      {
        typeof (ExpressionCompiler.ArrayClosure),
        typeof (T1),
        typeof (T2),
        typeof (T3),
        typeof (T4),
        typeof (T5),
        typeof (T6)
      }, typeof (R));
      if (firstClosureParam != null)
        return firstClosureParam;
      return !ifFastFailedReturnNull ? lambdaExpr.CompileSys<Func<T1, T2, T3, T4, T5, T6, R>>() : (Func<T1, T2, T3, T4, T5, T6, R>) null;
    }

    /// <summary>Compiles lambda expression to delegate. Use ifFastFailedReturnNull parameter to Not fallback to Expression.Compile, useful for testing.</summary>
    public static System.Action CompileFast(
      this Expression<System.Action> lambdaExpr,
      bool ifFastFailedReturnNull = false)
    {
      System.Action firstClosureParam = (System.Action) ExpressionCompiler.TryCompileBoundToFirstClosureParam(typeof (System.Action), lambdaExpr.Body, (IReadOnlyList<ParameterExpression>) lambdaExpr.Parameters, ExpressionCompiler._closureAsASingleParamType, typeof (void));
      if (firstClosureParam != null)
        return firstClosureParam;
      return !ifFastFailedReturnNull ? lambdaExpr.CompileSys<System.Action>() : (System.Action) null;
    }

    /// <summary>Compiles lambda expression to delegate. Use ifFastFailedReturnNull parameter to Not fallback to Expression.Compile, useful for testing.</summary>
    public static Action<T1> CompileFast<T1>(
      this Expression<Action<T1>> lambdaExpr,
      bool ifFastFailedReturnNull = false)
    {
      Action<T1> firstClosureParam = (Action<T1>) ExpressionCompiler.TryCompileBoundToFirstClosureParam(typeof (Action<T1>), lambdaExpr.Body, (IReadOnlyList<ParameterExpression>) lambdaExpr.Parameters, new Type[2]
      {
        typeof (ExpressionCompiler.ArrayClosure),
        typeof (T1)
      }, typeof (void));
      if (firstClosureParam != null)
        return firstClosureParam;
      return !ifFastFailedReturnNull ? lambdaExpr.CompileSys<Action<T1>>() : (Action<T1>) null;
    }

    /// <summary>Compiles lambda expression to delegate. Use ifFastFailedReturnNull parameter to Not fallback to Expression.Compile, useful for testing.</summary>
    public static Action<T1, T2> CompileFast<T1, T2>(
      this Expression<Action<T1, T2>> lambdaExpr,
      bool ifFastFailedReturnNull = false)
    {
      Action<T1, T2> firstClosureParam = (Action<T1, T2>) ExpressionCompiler.TryCompileBoundToFirstClosureParam(typeof (Action<T1, T2>), lambdaExpr.Body, (IReadOnlyList<ParameterExpression>) lambdaExpr.Parameters, new Type[3]
      {
        typeof (ExpressionCompiler.ArrayClosure),
        typeof (T1),
        typeof (T2)
      }, typeof (void));
      if (firstClosureParam != null)
        return firstClosureParam;
      return !ifFastFailedReturnNull ? lambdaExpr.CompileSys<Action<T1, T2>>() : (Action<T1, T2>) null;
    }

    /// <summary>Compiles lambda expression to delegate. Use ifFastFailedReturnNull parameter to Not fallback to Expression.Compile, useful for testing.</summary>
    public static Action<T1, T2, T3> CompileFast<T1, T2, T3>(
      this Expression<Action<T1, T2, T3>> lambdaExpr,
      bool ifFastFailedReturnNull = false)
    {
      Action<T1, T2, T3> firstClosureParam = (Action<T1, T2, T3>) ExpressionCompiler.TryCompileBoundToFirstClosureParam(typeof (Action<T1, T2, T3>), lambdaExpr.Body, (IReadOnlyList<ParameterExpression>) lambdaExpr.Parameters, new Type[4]
      {
        typeof (ExpressionCompiler.ArrayClosure),
        typeof (T1),
        typeof (T2),
        typeof (T3)
      }, typeof (void));
      if (firstClosureParam != null)
        return firstClosureParam;
      return !ifFastFailedReturnNull ? lambdaExpr.CompileSys<Action<T1, T2, T3>>() : (Action<T1, T2, T3>) null;
    }

    /// <summary>Compiles lambda expression to delegate. Use ifFastFailedReturnNull parameter to Not fallback to Expression.Compile, useful for testing.</summary>
    public static Action<T1, T2, T3, T4> CompileFast<T1, T2, T3, T4>(
      this Expression<Action<T1, T2, T3, T4>> lambdaExpr,
      bool ifFastFailedReturnNull = false)
    {
      Action<T1, T2, T3, T4> firstClosureParam = (Action<T1, T2, T3, T4>) ExpressionCompiler.TryCompileBoundToFirstClosureParam(typeof (Action<T1, T2, T3, T4>), lambdaExpr.Body, (IReadOnlyList<ParameterExpression>) lambdaExpr.Parameters, new Type[5]
      {
        typeof (ExpressionCompiler.ArrayClosure),
        typeof (T1),
        typeof (T2),
        typeof (T3),
        typeof (T4)
      }, typeof (void));
      if (firstClosureParam != null)
        return firstClosureParam;
      return !ifFastFailedReturnNull ? lambdaExpr.CompileSys<Action<T1, T2, T3, T4>>() : (Action<T1, T2, T3, T4>) null;
    }

    /// <summary>Compiles lambda expression to delegate. Use ifFastFailedReturnNull parameter to Not fallback to Expression.Compile, useful for testing.</summary>
    public static Action<T1, T2, T3, T4, T5> CompileFast<T1, T2, T3, T4, T5>(
      this Expression<Action<T1, T2, T3, T4, T5>> lambdaExpr,
      bool ifFastFailedReturnNull = false)
    {
      Action<T1, T2, T3, T4, T5> firstClosureParam = (Action<T1, T2, T3, T4, T5>) ExpressionCompiler.TryCompileBoundToFirstClosureParam(typeof (Action<T1, T2, T3, T4, T5>), lambdaExpr.Body, (IReadOnlyList<ParameterExpression>) lambdaExpr.Parameters, new Type[6]
      {
        typeof (ExpressionCompiler.ArrayClosure),
        typeof (T1),
        typeof (T2),
        typeof (T3),
        typeof (T4),
        typeof (T5)
      }, typeof (void));
      if (firstClosureParam != null)
        return firstClosureParam;
      return !ifFastFailedReturnNull ? lambdaExpr.CompileSys<Action<T1, T2, T3, T4, T5>>() : (Action<T1, T2, T3, T4, T5>) null;
    }

    /// <summary>Compiles lambda expression to delegate. Use ifFastFailedReturnNull parameter to Not fallback to Expression.Compile, useful for testing.</summary>
    public static Action<T1, T2, T3, T4, T5, T6> CompileFast<T1, T2, T3, T4, T5, T6>(
      this Expression<Action<T1, T2, T3, T4, T5, T6>> lambdaExpr,
      bool ifFastFailedReturnNull = false)
    {
      Action<T1, T2, T3, T4, T5, T6> firstClosureParam = (Action<T1, T2, T3, T4, T5, T6>) ExpressionCompiler.TryCompileBoundToFirstClosureParam(typeof (Action<T1, T2, T3, T4, T5, T6>), lambdaExpr.Body, (IReadOnlyList<ParameterExpression>) lambdaExpr.Parameters, new Type[7]
      {
        typeof (ExpressionCompiler.ArrayClosure),
        typeof (T1),
        typeof (T2),
        typeof (T3),
        typeof (T4),
        typeof (T5),
        typeof (T6)
      }, typeof (void));
      if (firstClosureParam != null)
        return firstClosureParam;
      return !ifFastFailedReturnNull ? lambdaExpr.CompileSys<Action<T1, T2, T3, T4, T5, T6>>() : (Action<T1, T2, T3, T4, T5, T6>) null;
    }

    /// <summary>Tries to compile lambda expression to <typeparamref name="TDelegate" /></summary>
    public static TDelegate TryCompile<TDelegate>(this LambdaExpression lambdaExpr) where TDelegate : class => (TDelegate) ExpressionCompiler.TryCompileBoundToFirstClosureParam(typeof (TDelegate) == typeof (Delegate) ? lambdaExpr.Type : typeof (TDelegate), lambdaExpr.Body, (IReadOnlyList<ParameterExpression>) lambdaExpr.Parameters, ExpressionCompiler.GetClosureTypeToParamTypes((IReadOnlyList<ParameterExpression>) lambdaExpr.Parameters), lambdaExpr.ReturnType);

    /// <summary>Tries to compile lambda expression to <typeparamref name="TDelegate" />
    /// with the provided closure object and constant expressions (or lack there of) -
    /// Constant expression should be the in order of Fields in closure object!
    /// Note 1: Use it on your own risk - FEC won't verify the expression is compile-able with passed closure, it is up to you!
    /// Note 2: The expression with NESTED LAMBDA IS NOT SUPPORTED!
    /// Note 3: `Label` and `GoTo` are not supported in this case, because they need first round to collect out-of-order labels</summary>
    public static TDelegate TryCompileWithPreCreatedClosure<TDelegate>(
      this LambdaExpression lambdaExpr,
      params ConstantExpression[] closureConstantsExprs)
      where TDelegate : class
    {
      object[] objArray = new object[closureConstantsExprs.Length];
      for (int index = 0; index < objArray.Length; ++index)
        objArray[index] = closureConstantsExprs[index].Value;
      ExpressionCompiler.ClosureInfo closure = new ExpressionCompiler.ClosureInfo(ExpressionCompiler.ClosureStatus.UserProvided | ExpressionCompiler.ClosureStatus.HasClosure, objArray);
      Type[] typeToParamTypes = ExpressionCompiler.GetClosureTypeToParamTypes((IReadOnlyList<ParameterExpression>) lambdaExpr.Parameters);
      DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, lambdaExpr.ReturnType, typeToParamTypes, typeof (ExpressionCompiler), true);
      ILGenerator ilGenerator = dynamicMethod.GetILGenerator();
      ExpressionCompiler.EmittingVisitor.EmitLoadConstantsAndNestedLambdasIntoVars((object) ilGenerator, ref closure);
      ExpressionCompiler.ParentFlags parent = lambdaExpr.ReturnType == typeof (void) ? ExpressionCompiler.ParentFlags.IgnoreResult : ExpressionCompiler.ParentFlags.Empty;
      if (!ExpressionCompiler.EmittingVisitor.TryEmit((object) lambdaExpr.Body, (IReadOnlyList<ParameterExpression>) lambdaExpr.Parameters, (object) ilGenerator, ref closure, parent))
        return default (TDelegate);
      ilGenerator.Emit(OpCodes.Ret);
      Type delegateType = typeof (TDelegate) != typeof (Delegate) ? typeof (TDelegate) : lambdaExpr.Type;
      TDelegate @delegate = (TDelegate) dynamicMethod.CreateDelegate(delegateType, (object) new ExpressionCompiler.ArrayClosure(objArray));
      ExpressionCompiler.ReturnClosureTypeToParamTypesToPool((object) typeToParamTypes);
      return @delegate;
    }

    /// <summary>Tries to compile expression to "static" delegate, skipping the step of collecting the closure object.</summary>
    public static TDelegate TryCompileWithoutClosure<TDelegate>(this LambdaExpression lambdaExpr) where TDelegate : class
    {
      ExpressionCompiler.ClosureInfo closure = new ExpressionCompiler.ClosureInfo(ExpressionCompiler.ClosureStatus.UserProvided);
      Type[] typeToParamTypes = ExpressionCompiler.GetClosureTypeToParamTypes((IReadOnlyList<ParameterExpression>) lambdaExpr.Parameters);
      DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, lambdaExpr.ReturnType, typeToParamTypes, typeof (ExpressionCompiler.ArrayClosure), true);
      ILGenerator ilGenerator = dynamicMethod.GetILGenerator();
      ExpressionCompiler.ParentFlags parent = lambdaExpr.ReturnType == typeof (void) ? ExpressionCompiler.ParentFlags.IgnoreResult : ExpressionCompiler.ParentFlags.Empty;
      if (!ExpressionCompiler.EmittingVisitor.TryEmit((object) lambdaExpr.Body, (IReadOnlyList<ParameterExpression>) lambdaExpr.Parameters, (object) ilGenerator, ref closure, parent))
        return default (TDelegate);
      ilGenerator.Emit(OpCodes.Ret);
      Type delegateType = typeof (TDelegate) != typeof (Delegate) ? typeof (TDelegate) : lambdaExpr.Type;
      TDelegate @delegate = (TDelegate) dynamicMethod.CreateDelegate(delegateType, (object) ExpressionCompiler.EmptyArrayClosure);
      ExpressionCompiler.ReturnClosureTypeToParamTypesToPool((object) typeToParamTypes);
      return @delegate;
    }

    /// Obsolete
    [Obsolete("Not used - candidate for removal")]
    public static TDelegate TryCompile<TDelegate>(
      Expression bodyExpr,
      IReadOnlyList<ParameterExpression> paramExprs,
      Type[] paramTypes,
      Type returnType)
      where TDelegate : class
    {
      return (TDelegate) ExpressionCompiler.TryCompile(typeof (TDelegate), bodyExpr, paramExprs, paramTypes, returnType);
    }

    /// Obsolete
    [Obsolete("Not used - candidate for removal")]
    public static object TryCompile(
      Type delegateType,
      Expression bodyExpr,
      IReadOnlyList<ParameterExpression> paramExprs,
      Type[] paramTypes,
      Type returnType)
    {
      return ExpressionCompiler.TryCompileBoundToFirstClosureParam(delegateType != typeof (Delegate) ? delegateType : Tools.GetFuncOrActionType(paramTypes, returnType), bodyExpr, paramExprs, ExpressionCompiler.GetClosureTypeToParamTypes(paramExprs), returnType);
    }

    internal static object TryCompileBoundToFirstClosureParam(
      Type delegateType,
      Expression bodyExpr,
      IReadOnlyList<ParameterExpression> paramExprs,
      Type[] closurePlusParamTypes,
      Type returnType)
    {
      ExpressionCompiler.ClosureInfo closureInfo = new ExpressionCompiler.ClosureInfo(ExpressionCompiler.ClosureStatus.ToBeCollected);
      if (!ExpressionCompiler.TryCollectBoundConstants(ref closureInfo, (object) bodyExpr, paramExprs, false, ref closureInfo))
        return (object) null;
      ExpressionCompiler.NestedLambdaInfo[] nestedLambdas = closureInfo.NestedLambdas;
      if (nestedLambdas.Length != 0)
      {
        for (int nestedLambdaIndex = 0; nestedLambdaIndex < nestedLambdas.Length; ++nestedLambdaIndex)
        {
          if (!ExpressionCompiler.TryCompileNestedLambda(ref closureInfo, nestedLambdaIndex))
            return (object) null;
        }
      }
      ExpressionCompiler.ArrayClosure target = (closureInfo.Status & ExpressionCompiler.ClosureStatus.HasClosure) == (ExpressionCompiler.ClosureStatus) 0 ? ExpressionCompiler.EmptyArrayClosure : new ExpressionCompiler.ArrayClosure(closureInfo.GetArrayOfConstantsAndNestedLambdas());
      DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, returnType, closurePlusParamTypes, typeof (ExpressionCompiler.ArrayClosure), true);
      ILGenerator ilGenerator = dynamicMethod.GetILGenerator();
      if (target.ConstantsAndNestedLambdas != null)
        ExpressionCompiler.EmittingVisitor.EmitLoadConstantsAndNestedLambdasIntoVars((object) ilGenerator, ref closureInfo);
      ExpressionCompiler.ParentFlags parent = returnType == typeof (void) ? ExpressionCompiler.ParentFlags.IgnoreResult : ExpressionCompiler.ParentFlags.Empty;
      if (!ExpressionCompiler.EmittingVisitor.TryEmit((object) bodyExpr, paramExprs, (object) ilGenerator, ref closureInfo, parent))
        return (object) null;
      ilGenerator.Emit(OpCodes.Ret);
      Delegate firstClosureParam = dynamicMethod.CreateDelegate(delegateType, (object) target);
      ExpressionCompiler.ReturnClosureTypeToParamTypesToPool((object) closurePlusParamTypes);
      return (object) firstClosureParam;
    }

    private static Type[] PrependClosureTypeToParamTypes(
      IReadOnlyList<ParameterExpression> paramExprs)
    {
      int count = paramExprs.Count;
      Type[] paramTypes = new Type[count + 1];
      paramTypes[0] = typeof (ExpressionCompiler.ArrayClosure);
      for (int index = 0; index < count; ++index)
      {
        ParameterExpression paramExpr = paramExprs[index];
        paramTypes[index + 1] = paramExpr.IsByRef ? paramExpr.Type.MakeByRefType() : paramExpr.Type;
      }
      return paramTypes;
    }

    private static Type[] GetClosureTypeToParamTypes(IReadOnlyList<ParameterExpression> paramExprs)
    {
      int count = paramExprs.Count;
      if (count == 0)
        return ExpressionCompiler._closureAsASingleParamType;
      if (count < ExpressionCompiler._closureTypePlusParamTypesPool.Length)
      {
        Type[] typeToParamTypes = Interlocked.Exchange<Type[]>(ref ExpressionCompiler._closureTypePlusParamTypesPool[count], (Type[]) null);
        if (typeToParamTypes != null)
        {
          for (int index = 0; index < paramExprs.Count; ++index)
          {
            ParameterExpression paramExpr = paramExprs[index];
            typeToParamTypes[index + 1] = paramExpr.IsByRef ? paramExpr.Type.MakeByRefType() : paramExpr.Type;
          }
          return typeToParamTypes;
        }
      }
      return ExpressionCompiler.PrependClosureTypeToParamTypes(paramExprs);
    }

    private static void ReturnClosureTypeToParamTypesToPool(object closurePlusParamTypes)
    {
      int num = 1;
      int index;
      while (true)
      {
        switch (num)
        {
          case 1:
            index = closurePlusParamTypes.Length - 1;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 0 : 0;
            continue;
          case 2:
            if (index >= ExpressionCompiler._closureTypePlusParamTypesPool.Length)
            {
              num = 4;
              continue;
            }
            goto case 6;
          case 3:
            goto label_7;
          case 4:
            goto label_3;
          case 5:
            goto label_2;
          case 6:
            Interlocked.Exchange<Type[]>(ref ExpressionCompiler._closureTypePlusParamTypesPool[index], (Type[]) closurePlusParamTypes);
            num = 5;
            continue;
          default:
            if (index == 0)
            {
              num = 3;
              continue;
            }
            goto case 2;
        }
      }
label_7:
      return;
label_3:
      return;
label_2:;
    }

    /// Helps to identify constants as the one to be put into the Closure
    public static bool IsClosureBoundConstant(object value, TypeInfo type)
    {
      int num1 = 5;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (!(value is string))
              {
                num2 = 2;
                continue;
              }
              goto label_8;
            case 2:
              if ((object) (value as Type) != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 0;
                continue;
              }
              goto label_7;
            case 3:
              if (!type.IsEnum)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 0 : 1;
                continue;
              }
              goto label_8;
            case 4:
              if (type.IsPrimitive)
              {
                num2 = 7;
                continue;
              }
              goto case 3;
            case 5:
              goto label_14;
            case 6:
              goto label_7;
            default:
              goto label_8;
          }
        }
label_14:
        if ((object) (value as Delegate) == null)
          num1 = 4;
        else
          goto label_9;
      }
label_7:
      return !(value is Decimal);
label_8:
      return false;
label_9:
      return true;
    }

    private static bool TryCollectBoundConstants(
      ref ExpressionCompiler.ClosureInfo closure,
      object expr,
      IReadOnlyList<ParameterExpression> paramExprs,
      bool isNestedLambda,
      ref ExpressionCompiler.ClosureInfo rootClosure)
    {
      while (expr != null)
      {
        ExpressionType nodeType = ((Expression) expr).NodeType;
        if (nodeType <= ExpressionType.MemberInit)
        {
          if (nodeType <= ExpressionType.Invoke)
          {
            switch (nodeType - 6)
            {
              case ExpressionType.Add:
                MethodCallExpression methodCallExpression = (MethodCallExpression) expr;
                Expression expression1 = methodCallExpression.Object;
                ReadOnlyCollection<Expression> arguments1 = methodCallExpression.Arguments;
                int count1 = arguments1.Count;
                if (count1 == 0)
                {
                  if (expression1 == null)
                    return true;
                  expr = (object) expression1;
                  continue;
                }
                if (expression1 != null && !ExpressionCompiler.TryCollectBoundConstants(ref closure, (object) methodCallExpression.Object, paramExprs, isNestedLambda, ref rootClosure))
                  return false;
                for (int index = 0; index < count1 - 1; ++index)
                {
                  if (!ExpressionCompiler.TryCollectBoundConstants(ref closure, (object) arguments1[index], paramExprs, isNestedLambda, ref rootClosure))
                    return false;
                }
                expr = (object) arguments1[count1 - 1];
                continue;
              case ExpressionType.AddChecked:
                break;
              case ExpressionType.And:
                ConditionalExpression conditionalExpression = (ConditionalExpression) expr;
                if (!ExpressionCompiler.TryCollectBoundConstants(ref closure, (object) conditionalExpression.Test, paramExprs, isNestedLambda, ref rootClosure) || !ExpressionCompiler.TryCollectBoundConstants(ref closure, (object) conditionalExpression.IfFalse, paramExprs, isNestedLambda, ref rootClosure))
                  return false;
                expr = (object) conditionalExpression.IfTrue;
                continue;
              case ExpressionType.AndAlso:
                object obj = ((ConstantExpression) expr).Value;
                if (obj != null && ExpressionCompiler.IsClosureBoundConstant(obj, IntrospectionExtensions.GetTypeInfo(obj.GetType())))
                  closure.AddConstant(obj);
                return true;
              default:
                if (nodeType == ExpressionType.Invoke)
                {
                  InvocationExpression invocationExpression = (InvocationExpression) expr;
                  ReadOnlyCollection<Expression> arguments2 = invocationExpression.Arguments;
                  int count2 = arguments2.Count;
                  if (count2 == 0)
                  {
                    expr = (object) ((invocationExpression.Expression is LambdaExpression expression2 ? expression2.Body : (Expression) null) ?? invocationExpression.Expression);
                    continue;
                  }
                  if (!ExpressionCompiler.TryCollectBoundConstants(ref closure, (object) invocationExpression.Expression, paramExprs, isNestedLambda, ref rootClosure))
                    return false;
                  for (int index = 0; index < arguments2.Count - 1; ++index)
                  {
                    if (!ExpressionCompiler.TryCollectBoundConstants(ref closure, (object) arguments2[index], paramExprs, isNestedLambda, ref rootClosure))
                      return false;
                  }
                  expr = (object) arguments2[count2 - 1];
                  continue;
                }
                break;
            }
          }
          else if (nodeType != ExpressionType.Lambda)
          {
            if (nodeType != ExpressionType.MemberAccess)
            {
              if (nodeType == ExpressionType.MemberInit)
                return ExpressionCompiler.TryCollectMemberInitExprConstants(ref closure, (object) (MemberInitExpression) expr, paramExprs, isNestedLambda, ref rootClosure);
            }
            else
            {
              Expression expression3 = ((MemberExpression) expr).Expression;
              if (expression3 == null)
                return true;
              expr = (object) expression3;
              continue;
            }
          }
          else
          {
            LambdaExpression lambdaExpression = (LambdaExpression) expr;
            ExpressionCompiler.NestedLambdaInfo[] nestedLambdas = rootClosure.NestedLambdas;
            if (nestedLambdas.Length != 0)
            {
              ExpressionCompiler.NestedLambdaInfo[] foundInLambdas;
              ExpressionCompiler.NestedLambdaInfo nestedLambdaInfo = ExpressionCompiler.FindAlreadyCollectedNestedLambdaInfo((object) nestedLambdas, (object) lambdaExpression, out foundInLambdas);
              if (nestedLambdaInfo != null)
              {
                if (foundInLambdas == closure.NestedLambdas)
                {
                  ++nestedLambdaInfo.UsageCountOrVarIndex;
                }
                else
                {
                  closure.AddNestedLambda(nestedLambdaInfo);
                  ParameterExpression[] passedParameters = nestedLambdaInfo.ClosureInfo.NonPassedParameters;
                  if (passedParameters.Length != 0)
                    ExpressionCompiler.PropagateNonPassedParamsToOuterLambda(ref closure, paramExprs, (IReadOnlyList<ParameterExpression>) lambdaExpression.Parameters, (object) passedParameters);
                }
                return true;
              }
            }
            ExpressionCompiler.NestedLambdaInfo nestedLambdaInfo1 = new ExpressionCompiler.NestedLambdaInfo(lambdaExpression);
            if (!ExpressionCompiler.TryCollectBoundConstants(ref nestedLambdaInfo1.ClosureInfo, (object) lambdaExpression.Body, (IReadOnlyList<ParameterExpression>) lambdaExpression.Parameters, true, ref rootClosure))
              return false;
            closure.AddNestedLambda(nestedLambdaInfo1);
            ParameterExpression[] passedParameters1 = nestedLambdaInfo1.ClosureInfo.NonPassedParameters;
            if (passedParameters1.Length != 0)
              ExpressionCompiler.PropagateNonPassedParamsToOuterLambda(ref closure, paramExprs, (IReadOnlyList<ParameterExpression>) lambdaExpression.Parameters, (object) passedParameters1);
            return true;
          }
        }
        else if (nodeType <= ExpressionType.NewArrayBounds)
        {
          if (nodeType != ExpressionType.New)
          {
            if ((uint) (nodeType - 32) <= 1U)
            {
              ReadOnlyCollection<Expression> expressions = ((NewArrayExpression) expr).Expressions;
              int count3 = expressions.Count;
              if (count3 == 0)
                return true;
              for (int index = 0; index < count3 - 1; ++index)
              {
                if (!ExpressionCompiler.TryCollectBoundConstants(ref closure, (object) expressions[index], paramExprs, isNestedLambda, ref rootClosure))
                  return false;
              }
              expr = (object) expressions[count3 - 1];
              continue;
            }
          }
          else
          {
            ReadOnlyCollection<Expression> arguments3 = ((NewExpression) expr).Arguments;
            int index1 = arguments3.Count - 1;
            if (index1 == -1)
              return true;
            for (int index2 = 0; index2 < index1; ++index2)
            {
              if (!ExpressionCompiler.TryCollectBoundConstants(ref closure, (object) arguments3[index2], paramExprs, isNestedLambda, ref rootClosure))
                return false;
            }
            expr = (object) arguments3[index1];
            continue;
          }
        }
        else if (nodeType != ExpressionType.Parameter)
        {
          if (nodeType == ExpressionType.Quote)
            return false;
          switch (nodeType - 47)
          {
            case ExpressionType.Add:
              BlockExpression blockExpression = (BlockExpression) expr;
              ReadOnlyCollection<ParameterExpression> variables = blockExpression.Variables;
              ReadOnlyCollection<Expression> expressions = blockExpression.Expressions;
              if (variables.Count == 0)
              {
                for (int index = 0; index < expressions.Count - 1; ++index)
                {
                  if (!ExpressionCompiler.TryCollectBoundConstants(ref closure, (object) expressions[index], paramExprs, isNestedLambda, ref rootClosure))
                    return false;
                }
                expr = (object) expressions[expressions.Count - 1];
                continue;
              }
              if (variables.Count == 1)
                closure.PushBlockWithVars(variables[0]);
              else
                closure.PushBlockWithVars((IReadOnlyList<ParameterExpression>) variables);
              for (int index = 0; index < expressions.Count; ++index)
              {
                if (!ExpressionCompiler.TryCollectBoundConstants(ref closure, (object) expressions[index], paramExprs, isNestedLambda, ref rootClosure))
                  return false;
              }
              closure.PopBlock();
              return true;
            case ExpressionType.ArrayLength:
              return true;
            case ExpressionType.ArrayIndex:
              expr = (object) ((Expression) expr).Reduce();
              continue;
            case ExpressionType.Call:
              GotoExpression gotoExpression = (GotoExpression) expr;
              if (gotoExpression.Kind == GotoExpressionKind.Return)
                closure.MarkAsContainsReturnGotoExpression();
              if (gotoExpression.Value == null)
                return true;
              expr = (object) gotoExpression.Value;
              continue;
            case ExpressionType.Conditional:
              IndexExpression indexExpression = (IndexExpression) expr;
              ReadOnlyCollection<Expression> arguments4 = indexExpression.Arguments;
              for (int index = 0; index < arguments4.Count; ++index)
              {
                if (!ExpressionCompiler.TryCollectBoundConstants(ref closure, (object) arguments4[index], paramExprs, isNestedLambda, ref rootClosure))
                  return false;
              }
              if (indexExpression.Object == null)
                return true;
              expr = (object) indexExpression.Object;
              continue;
            case ExpressionType.Constant:
              LabelExpression labelExpression = (LabelExpression) expr;
              Expression defaultValue = labelExpression.DefaultValue;
              closure.AddLabel(labelExpression.Target);
              if (defaultValue == null)
                return true;
              expr = (object) defaultValue;
              continue;
            case ExpressionType.ConvertChecked:
              LoopExpression loopExpression = (LoopExpression) expr;
              closure.AddLabel(loopExpression.BreakLabel);
              closure.AddLabel(loopExpression.ContinueLabel);
              expr = (object) loopExpression.Body;
              continue;
            case ExpressionType.Divide:
              SwitchExpression switchExpression = (SwitchExpression) expr;
              if (!ExpressionCompiler.TryCollectBoundConstants(ref closure, (object) switchExpression.SwitchValue, paramExprs, isNestedLambda, ref rootClosure) || switchExpression.DefaultBody != null && !ExpressionCompiler.TryCollectBoundConstants(ref closure, (object) switchExpression.DefaultBody, paramExprs, isNestedLambda, ref rootClosure))
                return false;
              ReadOnlyCollection<SwitchCase> cases = switchExpression.Cases;
              for (int index = 0; index < cases.Count - 1; ++index)
              {
                if (!ExpressionCompiler.TryCollectBoundConstants(ref closure, (object) cases[index].Body, paramExprs, isNestedLambda, ref rootClosure))
                  return false;
              }
              expr = (object) cases[cases.Count - 1].Body;
              continue;
            case ExpressionType.ExclusiveOr:
              return ExpressionCompiler.TryCollectTryExprConstants(ref closure, (object) (TryExpression) expr, paramExprs, isNestedLambda, ref rootClosure);
          }
        }
        else
        {
          int index = paramExprs.Count - 1;
          while (index != -1 && paramExprs[index] != expr)
            --index;
          if (index == -1 && !closure.IsLocalVar(expr))
          {
            if (!isNestedLambda)
              return false;
            closure.AddNonPassedParam((ParameterExpression) expr);
          }
          return true;
        }
        switch (expr)
        {
          case UnaryExpression unaryExpression:
            expr = (object) unaryExpression.Operand;
            continue;
          case BinaryExpression binaryExpression1:
            if (!ExpressionCompiler.TryCollectBoundConstants(ref closure, (object) binaryExpression1.Left, paramExprs, isNestedLambda, ref rootClosure))
              return false;
            expr = (object) binaryExpression1.Right;
            continue;
          case TypeBinaryExpression binaryExpression2:
            expr = (object) binaryExpression2.Expression;
            continue;
          default:
            return false;
        }
      }
      return false;
    }

    private static void PropagateNonPassedParamsToOuterLambda(
      ref ExpressionCompiler.ClosureInfo closure,
      IReadOnlyList<ParameterExpression> paramExprs,
      IReadOnlyList<ParameterExpression> nestedLambdaParamExprs,
      object nestedNonPassedParams)
    {
      for (int index1 = 0; index1 < nestedNonPassedParams.Length; ++index1)
      {
        ParameterExpression nestedNonPassedParam = (ParameterExpression) nestedNonPassedParams[index1];
        bool flag1 = false;
        if (nestedLambdaParamExprs.Count != 0)
        {
          for (int index2 = 0; !flag1 && index2 < nestedLambdaParamExprs.Count; ++index2)
            flag1 = nestedLambdaParamExprs[index2] == nestedNonPassedParam;
        }
        bool flag2 = false;
        if (paramExprs.Count != 0)
        {
          for (int index3 = 0; !flag2 && index3 < paramExprs.Count; ++index3)
            flag2 = paramExprs[index3] == nestedNonPassedParam;
        }
        if (!flag1 && !flag2)
          closure.AddNonPassedParam(nestedNonPassedParam);
      }
    }

    private static ExpressionCompiler.NestedLambdaInfo FindAlreadyCollectedNestedLambdaInfo(
      object nestedLambdas,
      object nestedLambdaExpr,
      out ExpressionCompiler.NestedLambdaInfo[] foundInLambdas)
    {
      int num1 = 10;
      ExpressionCompiler.NestedLambdaInfo nestedLambdaInfo;
      ExpressionCompiler.NestedLambdaInfo nestedLambda;
      while (true)
      {
        int num2 = num1;
        ExpressionCompiler.NestedLambdaInfo[] nestedLambdas1;
        while (true)
        {
          int index;
          switch (num2)
          {
            case 1:
            case 4:
              nestedLambda = (ExpressionCompiler.NestedLambdaInfo) nestedLambdas[index];
              num2 = 5;
              continue;
            case 2:
              goto label_6;
            case 3:
              goto label_15;
            case 5:
              if (nestedLambda.LambdaExpression == nestedLambdaExpr)
              {
                num2 = 13;
                continue;
              }
              goto label_9;
            case 6:
            case 9:
              if (index < nestedLambdas.Length)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 1 : 0;
                continue;
              }
              goto case 12;
            case 7:
              if (nestedLambdaInfo != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 2 : 2;
                continue;
              }
              break;
            case 8:
              nestedLambdaInfo = ExpressionCompiler.FindAlreadyCollectedNestedLambdaInfo((object) nestedLambdas1, nestedLambdaExpr, out foundInLambdas);
              num2 = 7;
              continue;
            case 10:
              index = 0;
              num2 = 9;
              continue;
            case 11:
              if (nestedLambdas1.Length != 0)
              {
                num2 = 8;
                continue;
              }
              break;
            case 12:
              foundInLambdas = (ExpressionCompiler.NestedLambdaInfo[]) null;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 2 : 3;
              continue;
            case 13:
              foundInLambdas = (ExpressionCompiler.NestedLambdaInfo[]) nestedLambdas;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 0 : 0;
              continue;
            default:
              goto label_8;
          }
          ++index;
          num2 = 6;
        }
label_9:
        nestedLambdas1 = nestedLambda.ClosureInfo.NestedLambdas;
        num1 = 11;
      }
label_6:
      return nestedLambdaInfo;
label_8:
      return nestedLambda;
label_15:
      return (ExpressionCompiler.NestedLambdaInfo) null;
    }

    private static bool TryCompileNestedLambda(
      ref ExpressionCompiler.ClosureInfo outerClosureInfo,
      int nestedLambdaIndex)
    {
      int num1 = 37;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          ExpressionCompiler.NestedLambdaInfo nestedLambda;
          DynamicMethod dynamicMethod;
          LambdaExpression lambdaExpression;
          ExpressionCompiler.ArrayClosure arrayClosure;
          ReadOnlyCollection<ParameterExpression> parameters;
          // ISSUE: variable of a reference type
          ExpressionCompiler.ClosureInfo& local;
          ExpressionCompiler.NestedLambdaInfo[] nestedLambdas;
          Type returnType;
          ILGenerator ilGenerator;
          ExpressionCompiler.ParentFlags parent;
          int nestedLambdaIndex1;
          Type[] typeToParamTypes;
          int num3;
          switch (num2)
          {
            case 1:
              goto label_16;
            case 2:
              goto label_45;
            case 3:
            case 19:
              if (ExpressionCompiler.TryCompileNestedLambda(ref local, nestedLambdaIndex1))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 0 : 0;
                continue;
              }
              goto label_18;
            case 4:
              goto label_43;
            case 5:
              typeToParamTypes = ExpressionCompiler.GetClosureTypeToParamTypes((IReadOnlyList<ParameterExpression>) parameters);
              num2 = 35;
              continue;
            case 6:
              if ((local.Status & ExpressionCompiler.ClosureStatus.HasClosure) != (ExpressionCompiler.ClosureStatus) 0)
                goto case 32;
              else
                goto label_7;
            case 7:
              if (local.NonPassedParameters.Length != 0)
              {
                num2 = 17;
                continue;
              }
              goto case 6;
            case 8:
            case 10:
            case 17:
              returnType = ExpressionCompiler.SNk1duGlj46D25gVxGVD((object) lambdaExpression);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 5 : 4;
              continue;
            case 9:
              // ISSUE: type reference
              if (ExpressionCompiler.TIEdetGlUCPNlyvbTK1j(returnType, ExpressionCompiler.JkmB0yGllAfHfTkdILLI(__typeref (void))))
              {
                num2 = 33;
                continue;
              }
              goto case 23;
            case 11:
              arrayClosure = ExpressionCompiler.EmptyArrayClosure;
              num2 = 10;
              continue;
            case 12:
              if (nestedLambdas.Length != 0)
              {
                num2 = 26;
                continue;
              }
              goto case 34;
            case 13:
              nestedLambdas = local.NestedLambdas;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 10 : 12;
              continue;
            case 14:
              lambdaExpression = (LambdaExpression) nestedLambda.LambdaExpression;
              num2 = 27;
              continue;
            case 15:
            case 24:
              if (nestedLambdaIndex1 < nestedLambdas.Length)
              {
                num2 = 3;
                continue;
              }
              goto case 34;
            case 16:
            case 39:
              nestedLambda.Lambda = (object) dynamicMethod.CreateDelegate(ExpressionCompiler.CIK6yQGlc3HZ1kSGyZ0k((object) typeToParamTypes, returnType), (object) null);
              num2 = 22;
              continue;
            case 18:
            case 22:
              ExpressionCompiler.V1cnsXGlzsIBMCcn7h0d((object) typeToParamTypes);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 4 : 4;
              continue;
            case 20:
              ilGenerator = dynamicMethod.GetILGenerator();
              num2 = 21;
              continue;
            case 21:
              if ((local.Status & ExpressionCompiler.ClosureStatus.HasClosure) != (ExpressionCompiler.ClosureStatus) 0)
              {
                num2 = 25;
                continue;
              }
              goto case 9;
            case 23:
              num3 = 0;
              break;
            case 25:
              ExpressionCompiler.EmittingVisitor.EmitLoadConstantsAndNestedLambdasIntoVars((object) ilGenerator, ref local);
              num2 = 9;
              continue;
            case 26:
              nestedLambdaIndex1 = 0;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 24 : 5;
              continue;
            case 27:
              local = ref nestedLambda.ClosureInfo;
              num2 = 29;
              continue;
            case 28:
              if (!ExpressionCompiler.EmittingVisitor.TryEmit(ExpressionCompiler.WbynNKGlrTj29YWqJQaj((object) lambdaExpression), (IReadOnlyList<ParameterExpression>) parameters, (object) ilGenerator, ref local, parent))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 2 : 1;
                continue;
              }
              ExpressionCompiler.oYYXJrGlgD1jeK8CT6Df((object) ilGenerator, OpCodes.Ret);
              num2 = 31;
              continue;
            case 29:
              parameters = lambdaExpression.Parameters;
              num2 = 13;
              continue;
            case 30:
              nestedLambda.Lambda = ExpressionCompiler.VUchioGlsMVMhBVbeM0b((object) dynamicMethod, ExpressionCompiler.suwSTaGl5Sj3Xtn547vC((object) lambdaExpression), (object) arrayClosure);
              num2 = 18;
              continue;
            case 31:
              if (arrayClosure == null)
              {
                num2 = 16;
                continue;
              }
              goto case 30;
            case 32:
              arrayClosure = new ExpressionCompiler.ArrayClosure(local.GetArrayOfConstantsAndNestedLambdas());
              num2 = 8;
              continue;
            case 33:
              num3 = 2;
              break;
            case 34:
              arrayClosure = (ExpressionCompiler.ArrayClosure) null;
              num2 = 7;
              continue;
            case 35:
              dynamicMethod = new DynamicMethod(string.Empty, returnType, typeToParamTypes, typeof (ExpressionCompiler.ArrayClosure), true);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 20 : 4;
              continue;
            case 36:
              if (nestedLambda.Lambda == null)
              {
                num2 = 14;
                continue;
              }
              goto label_16;
            case 37:
              nestedLambda = outerClosureInfo.NestedLambdas[nestedLambdaIndex];
              num2 = 36;
              continue;
            case 38:
              goto label_18;
            default:
              ++nestedLambdaIndex1;
              num2 = 15;
              continue;
          }
          parent = (ExpressionCompiler.ParentFlags) num3;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 28 : 5;
        }
label_7:
        num1 = 11;
      }
label_16:
      return true;
label_18:
      return false;
label_43:
      return true;
label_45:
      return false;
    }

    private static bool TryCollectMemberInitExprConstants(
      ref ExpressionCompiler.ClosureInfo closure,
      object expr,
      IReadOnlyList<ParameterExpression> paramExprs,
      bool isNestedLambda,
      ref ExpressionCompiler.ClosureInfo rootClosure)
    {
      NewExpression newExpression = ((MemberInitExpression) expr).NewExpression;
      if (!ExpressionCompiler.TryCollectBoundConstants(ref closure, (object) newExpression, paramExprs, isNestedLambda, ref rootClosure))
        return false;
      ReadOnlyCollection<MemberBinding> bindings = ((MemberInitExpression) expr).Bindings;
      for (int index = 0; index < bindings.Count; ++index)
      {
        MemberBinding memberBinding = bindings[index];
        if (memberBinding.BindingType == MemberBindingType.Assignment && !ExpressionCompiler.TryCollectBoundConstants(ref closure, (object) ((MemberAssignment) memberBinding).Expression, paramExprs, isNestedLambda, ref rootClosure))
          return false;
      }
      return true;
    }

    private static bool TryCollectTryExprConstants(
      ref ExpressionCompiler.ClosureInfo closure,
      object tryExpr,
      IReadOnlyList<ParameterExpression> paramExprs,
      bool isNestedLambda,
      ref ExpressionCompiler.ClosureInfo rootClosure)
    {
      closure.AddTryCatchFinallyInfo();
      if (!ExpressionCompiler.TryCollectBoundConstants(ref closure, (object) ((TryExpression) tryExpr).Body, paramExprs, isNestedLambda, ref rootClosure))
        return false;
      ReadOnlyCollection<CatchBlock> handlers = ((TryExpression) tryExpr).Handlers;
      for (int index = 0; index < handlers.Count; ++index)
      {
        CatchBlock catchBlock = handlers[index];
        ParameterExpression variable = catchBlock.Variable;
        if (variable != null)
        {
          closure.PushBlockWithVars(variable);
          if (!ExpressionCompiler.TryCollectBoundConstants(ref closure, (object) variable, paramExprs, isNestedLambda, ref rootClosure))
            return false;
        }
        if (catchBlock.Filter != null && !ExpressionCompiler.TryCollectBoundConstants(ref closure, (object) catchBlock.Filter, paramExprs, isNestedLambda, ref rootClosure) || !ExpressionCompiler.TryCollectBoundConstants(ref closure, (object) catchBlock.Body, paramExprs, isNestedLambda, ref rootClosure))
          return false;
        if (variable != null)
          closure.PopBlock();
      }
      if (((TryExpression) tryExpr).Finally != null && !ExpressionCompiler.TryCollectBoundConstants(ref closure, (object) ((TryExpression) tryExpr).Finally, paramExprs, isNestedLambda, ref rootClosure))
        return false;
      --closure.CurrentTryCatchFinallyIndex;
      return true;
    }

    internal static bool IgnoresResult(this ExpressionCompiler.ParentFlags parent) => (parent & ExpressionCompiler.ParentFlags.IgnoreResult) != 0;

    static ExpressionCompiler()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            // ISSUE: type reference
            ExpressionCompiler._closureAsASingleParamType = new Type[1]
            {
              ExpressionCompiler.JkmB0yGllAfHfTkdILLI(__typeref (ExpressionCompiler.ArrayClosure))
            };
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 0 : 0;
            continue;
          case 2:
            ExpressionCompiler.cSn8ASGrFr0ZgSE1Gu9t();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 0 : 1;
            continue;
          case 3:
            // ISSUE: type reference
            ExpressionCompiler.ArrayClosureWithNonPassedParamsConstructor = IntrospectionExtensions.GetTypeInfo(ExpressionCompiler.JkmB0yGllAfHfTkdILLI(__typeref (ExpressionCompiler.ArrayClosureWithNonPassedParams))).DeclaredConstructors.GetFirst<ConstructorInfo>();
            num = 6;
            continue;
          case 4:
            ExpressionCompiler.EmptyArrayClosure = new ExpressionCompiler.ArrayClosure((object[]) null);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 7 : 5;
            continue;
          case 5:
            // ISSUE: type reference
            ExpressionCompiler.ArrayClosureWithNonPassedParamsField = ((TypeInfo) ExpressionCompiler.RUnPnOGrBm5dO31UT9WK(ExpressionCompiler.JkmB0yGllAfHfTkdILLI(__typeref (ExpressionCompiler.ArrayClosureWithNonPassedParams)))).GetDeclaredField((string) ExpressionCompiler.lcDfKhGro1Jpx3ARkfWp(1669371371 ^ 1669629187));
            num = 3;
            continue;
          case 6:
            goto label_2;
          case 7:
            // ISSUE: type reference
            ExpressionCompiler.ArrayClosureArrayField = (FieldInfo) ExpressionCompiler.aJBMSUGrWdcGC9dFKsPr(ExpressionCompiler.RUnPnOGrBm5dO31UT9WK(ExpressionCompiler.JkmB0yGllAfHfTkdILLI(__typeref (ExpressionCompiler.ArrayClosure))), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-398663332 ^ -398921234));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 5 : 1;
            continue;
          default:
            ExpressionCompiler._closureTypePlusParamTypesPool = new Type[8][];
            num = 4;
            continue;
        }
      }
label_2:;
    }

    internal static Type JkmB0yGllAfHfTkdILLI([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object WbynNKGlrTj29YWqJQaj([In] object obj0) => (object) ((LambdaExpression) obj0).Body;

    internal static void oYYXJrGlgD1jeK8CT6Df([In] object obj0, [In] OpCode obj1) => ((ILGenerator) obj0).Emit(obj1);

    internal static bool naCC8JGl99t669pq4DhV() => ExpressionCompiler.CN5P1LGlJTFMqrvxeopG == null;

    internal static ExpressionCompiler EP97QHGld3fjQ02buIP6() => ExpressionCompiler.CN5P1LGlJTFMqrvxeopG;

    internal static Type suwSTaGl5Sj3Xtn547vC([In] object obj0) => ((Expression) obj0).Type;

    internal static Type SNk1duGlj46D25gVxGVD([In] object obj0) => ((LambdaExpression) obj0).ReturnType;

    internal static object AUcGUTGlY4agyWHYGUQq([In] object obj0) => (object) ((LambdaExpression) obj0).CompileSys();

    internal static object Uj0Tc3GlLQB0qwWS8Fqv([In] object obj0) => (object) ((LambdaExpression) obj0).Compile();

    internal static bool TIEdetGlUCPNlyvbTK1j([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static object VUchioGlsMVMhBVbeM0b([In] object obj0, [In] Type obj1, [In] object obj2) => (object) ((MethodInfo) obj0).CreateDelegate(obj1, obj2);

    internal static Type CIK6yQGlc3HZ1kSGyZ0k([In] object obj0, Type returnType) => Tools.GetFuncOrActionType((Type[]) obj0, returnType);

    internal static void V1cnsXGlzsIBMCcn7h0d([In] object obj0) => ExpressionCompiler.ReturnClosureTypeToParamTypesToPool(obj0);

    internal static void cSn8ASGrFr0ZgSE1Gu9t() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object RUnPnOGrBm5dO31UT9WK([In] Type obj0) => (object) IntrospectionExtensions.GetTypeInfo(obj0);

    internal static object aJBMSUGrWdcGC9dFKsPr([In] object obj0, [In] object obj1) => (object) ((TypeInfo) obj0).GetDeclaredField((string) obj1);

    internal static object lcDfKhGro1Jpx3ARkfWp(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    private struct BlockInfo
    {
      public object VarExprs;
      public int[] VarIndexes;
    }

    [Flags]
    private enum ClosureStatus
    {
      ToBeCollected = 1,
      UserProvided = 2,
      HasClosure = 4,
      ShouldBeStaticMethod = 8,
    }

    /// Track the info required to build a closure object + some context information not directly related to closure.
    private struct ClosureInfo
    {
      public bool LastEmitIsAddress;
      /// Helpers to know if a Return GotoExpression's Label should be emitted.
      ///             First set bit is ContainsReturnGoto, the rest is ReturnLabelIndex
      private int[] _tryCatchFinallyInfos;
      public int CurrentTryCatchFinallyIndex;
      /// Tracks the stack of blocks where are we in emit phase
      private LiveCountArray<ExpressionCompiler.BlockInfo> _blockStack;
      /// Dictionary for the used Labels in IL
      private KeyValuePair<LabelTarget, Label?>[] _labels;
      public ExpressionCompiler.ClosureStatus Status;
      /// Constant expressions to find an index (by reference) of constant expression from compiled expression.
      public LiveCountArray<object> Constants;
      /// Parameters not passed through lambda parameter list But used inside lambda body.
      ///             The top expression should Not contain not passed parameters.
      public ParameterExpression[] NonPassedParameters;
      /// All nested lambdas recursively nested in expression
      public ExpressionCompiler.NestedLambdaInfo[] NestedLambdas;
      /// Constant usage count and variable index
      public LiveCountArray<int> ConstantUsage;
      private static object AIExvi8vCm5CtIgivpoW;

      /// Populates info directly with provided closure object and constants.
      public ClosureInfo(ExpressionCompiler.ClosureStatus status, object[] constValues = null)
      {
        ExpressionCompiler.ClosureInfo.ORpq0h8vZQU0lMk1BlpF();
        int num1 = 6;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
          goto label_9;
label_2:
        while (true)
        {
          int num2;
          switch (num1)
          {
            case 1:
              this._tryCatchFinallyInfos = (int[]) null;
              num1 = 3;
              continue;
            case 2:
              this.ConstantUsage = new LiveCountArray<int>(constValues != null ? new int[constValues.Length] : Tools.Empty<int>());
              num1 = 8;
              continue;
            case 3:
              this._labels = (KeyValuePair<LabelTarget, Label?>[]) null;
              num1 = 10;
              continue;
            case 4:
              this.LastEmitIsAddress = false;
              num1 = 5;
              continue;
            case 5:
              this.CurrentTryCatchFinallyIndex = -1;
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 1 : 1;
              continue;
            case 6:
              this.Status = status;
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 0 : 0;
              continue;
            case 7:
              this.NestedLambdas = Tools.Empty<ExpressionCompiler.NestedLambdaInfo>();
              num2 = 4;
              break;
            case 8:
              this.NonPassedParameters = Tools.Empty<ParameterExpression>();
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 4 : 7;
              continue;
            case 9:
              goto label_14;
            case 10:
              this._blockStack = new LiveCountArray<ExpressionCompiler.BlockInfo>(Tools.Empty<ExpressionCompiler.BlockInfo>());
              num2 = 9;
              break;
            default:
              this.Constants = new LiveCountArray<object>(constValues ?? Tools.Empty<object>());
              num1 = 2;
              continue;
          }
          num1 = num2;
        }
label_14:
        return;
label_9:
        num1 = 4;
        goto label_2;
      }

      public void AddConstant(object value)
      {
        int num1 = 7;
        while (true)
        {
          int num2 = num1;
          object[] items;
          int index;
          while (true)
          {
            switch (num2)
            {
              case 2:
                this.ConstantUsage.PushSlot(1);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 5 : 4;
                continue;
              case 3:
                this.Constants.PushSlot(value);
                num2 = 2;
                continue;
              case 4:
                --index;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 1;
                continue;
              case 5:
                goto label_12;
              case 6:
                goto label_11;
              case 7:
                this.Status |= ExpressionCompiler.ClosureStatus.HasClosure;
                num2 = 6;
                continue;
              case 8:
                index = this.Constants.Count - 1;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 0 : 0;
                continue;
              case 9:
                if (index == -1)
                {
                  num2 = 3;
                  continue;
                }
                ++this.ConstantUsage.Items[index];
                num2 = 10;
                continue;
              case 10:
                goto label_10;
              case 11:
                if (items[index] == value)
                {
                  num2 = 9;
                  continue;
                }
                goto case 4;
              default:
                if (index != -1)
                {
                  num2 = 11;
                  continue;
                }
                goto case 9;
            }
          }
label_11:
          items = this.Constants.Items;
          num1 = 8;
        }
label_12:
        return;
label_10:;
      }

      public void AddNonPassedParam(ParameterExpression expr)
      {
        int num1 = 18;
        while (true)
        {
          int num2 = num1;
          int length;
          ParameterExpression[] parameterExpressionArray;
          int index;
          while (true)
          {
            switch (num2)
            {
              case 0:
                goto label_26;
              case 1:
              case 5:
                if (index < length)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 6 : 3;
                  continue;
                }
                goto case 14;
              case 2:
                this.NonPassedParameters = new ParameterExpression[2]
                {
                  this.NonPassedParameters[0],
                  expr
                };
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 11 : 0;
                continue;
              case 3:
                goto label_7;
              case 4:
                goto label_5;
              case 6:
              case 9:
                if (this.NonPassedParameters[index] != expr)
                {
                  ++index;
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 5 : 5;
                  continue;
                }
                num2 = 3;
                continue;
              case 7:
                index = 0;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 1 : 1;
                continue;
              case 8:
                this.NonPassedParameters = new ParameterExpression[1]
                {
                  expr
                };
                num2 = 4;
                continue;
              case 10:
                goto label_3;
              case 11:
                goto label_10;
              case 12:
                goto label_8;
              case 13:
                this.NonPassedParameters = new ParameterExpression[3]
                {
                  this.NonPassedParameters[0],
                  this.NonPassedParameters[1],
                  expr
                };
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 0 : 0;
                continue;
              case 14:
                if (this.NonPassedParameters.Length != 1)
                {
                  if (this.NonPassedParameters.Length != 2)
                  {
                    parameterExpressionArray = new ParameterExpression[length + 1];
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 13 : 16;
                    continue;
                  }
                  num2 = 13;
                  continue;
                }
                num2 = 2;
                continue;
              case 15:
                this.NonPassedParameters = parameterExpressionArray;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 6 : 10;
                continue;
              case 16:
                ExpressionCompiler.ClosureInfo.Re0ZNv8vu8VoltRnhQRJ((object) this.NonPassedParameters, 0, (object) parameterExpressionArray, 0, length);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 19 : 16;
                continue;
              case 17:
                if (this.NonPassedParameters.Length != 0)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 12 : 2;
                  continue;
                }
                goto case 8;
              case 18:
                this.Status |= ExpressionCompiler.ClosureStatus.HasClosure;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 5 : 17;
                continue;
              case 19:
                parameterExpressionArray[length] = expr;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 15 : 15;
                continue;
              default:
                goto label_19;
            }
          }
label_8:
          length = this.NonPassedParameters.Length;
          num1 = 7;
        }
label_26:
        return;
label_7:
        return;
label_5:
        return;
label_3:
        return;
label_10:
        return;
label_19:;
      }

      public void AddNestedLambda(
        ExpressionCompiler.NestedLambdaInfo nestedLambdaInfo)
      {
        int num = 11;
        int length;
        ExpressionCompiler.NestedLambdaInfo[] nestedLambdaInfoArray;
        ExpressionCompiler.NestedLambdaInfo[] nestedLambdas;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.NestedLambdas = nestedLambdaInfoArray;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 2 : 9;
              continue;
            case 2:
              switch (length)
              {
                case 0:
                  num = 5;
                  continue;
                case 1:
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 1 : 13;
                  continue;
                case 2:
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 7 : 6;
                  continue;
                default:
                  nestedLambdaInfoArray = new ExpressionCompiler.NestedLambdaInfo[length + 1];
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 0 : 4;
                  continue;
              }
            case 3:
              length = nestedLambdas.Length;
              num = 2;
              continue;
            case 4:
              ExpressionCompiler.ClosureInfo.Re0ZNv8vu8VoltRnhQRJ((object) nestedLambdas, 0, (object) nestedLambdaInfoArray, 0, length);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 8 : 8;
              continue;
            case 5:
              this.NestedLambdas = new ExpressionCompiler.NestedLambdaInfo[1]
              {
                nestedLambdaInfo
              };
              num = 6;
              continue;
            case 6:
              goto label_3;
            case 7:
              this.NestedLambdas = new ExpressionCompiler.NestedLambdaInfo[3]
              {
                nestedLambdas[0],
                nestedLambdas[1],
                nestedLambdaInfo
              };
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 0 : 0;
              continue;
            case 8:
              nestedLambdaInfoArray[length] = nestedLambdaInfo;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 1 : 1;
              continue;
            case 9:
              goto label_12;
            case 10:
              nestedLambdas = this.NestedLambdas;
              num = 3;
              continue;
            case 11:
              this.Status |= ExpressionCompiler.ClosureStatus.HasClosure;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 8 : 10;
              continue;
            case 12:
              goto label_17;
            case 13:
              this.NestedLambdas = new ExpressionCompiler.NestedLambdaInfo[2]
              {
                nestedLambdas[0],
                nestedLambdaInfo
              };
              num = 12;
              continue;
            default:
              goto label_20;
          }
        }
label_2:
        return;
label_3:
        return;
label_12:
        return;
label_17:
        return;
label_20:;
      }

      public void AddLabel(LabelTarget labelTarget)
      {
        int num = 4;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (this.GetLabelIndex(labelTarget) == -1)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            case 2:
              goto label_3;
            case 3:
              goto label_9;
            case 4:
              if (labelTarget == null)
              {
                num = 3;
                continue;
              }
              goto case 1;
            default:
              this._labels = this._labels.WithLast<KeyValuePair<LabelTarget, Label?>>(new KeyValuePair<LabelTarget, Label?>(labelTarget, new Label?()));
              num = 2;
              continue;
          }
        }
label_3:
        return;
label_9:
        return;
label_2:;
      }

      public Label GetOrCreateLabel(LabelTarget labelTarget, ILGenerator il) => this.GetOrCreateLabel(this.GetLabelIndex(labelTarget), il);

      public Label GetOrCreateLabel(int index, ILGenerator il)
      {
        int num = 1;
        KeyValuePair<LabelTarget, Label?> label;
        Label? nullable1;
        while (true)
        {
          switch (num)
          {
            case 1:
              label = this._labels[index];
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
              continue;
            case 2:
              if (!nullable1.HasValue)
              {
                num = 3;
                continue;
              }
              goto label_3;
            case 3:
              KeyValuePair<LabelTarget, Label?>[] labels = this._labels;
              int index1 = index;
              LabelTarget key = label.Key;
              nullable1 = new Label?(ExpressionCompiler.ClosureInfo.of7DXT8vI7Rw4H3omHIp((object) il));
              Label? nullable2 = nullable1;
              KeyValuePair<LabelTarget, Label?> keyValuePair = new KeyValuePair<LabelTarget, Label?>(key, nullable2);
              labels[index1] = keyValuePair;
              num = 4;
              continue;
            case 4:
              goto label_3;
            default:
              nullable1 = label.Value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 2 : 0;
              continue;
          }
        }
label_3:
        return nullable1.Value;
      }

      public int GetLabelIndex(LabelTarget labelTarget)
      {
        int num1 = 5;
        int labelIndex;
        while (true)
        {
          int num2 = num1;
          while (true)
          {
            switch (num2)
            {
              case 1:
              case 3:
                if (this._labels[labelIndex].Key != labelTarget)
                {
                  ++labelIndex;
                  num2 = 2;
                  continue;
                }
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 6 : 2;
                continue;
              case 4:
                labelIndex = 0;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 0 : 0;
                continue;
              case 5:
                goto label_9;
              case 6:
                goto label_4;
              case 7:
                goto label_3;
              default:
                if (labelIndex < this._labels.Length)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 3;
                  continue;
                }
                goto label_3;
            }
          }
label_9:
          if (this._labels != null)
            num1 = 4;
          else
            break;
        }
label_3:
        return -1;
label_4:
        return labelIndex;
      }

      public void AddTryCatchFinallyInfo()
      {
        int num1 = 6;
        while (true)
        {
          int num2 = num1;
          int[] catchFinallyInfos;
          int[] destinationArray;
          int length;
          while (true)
          {
            switch (num2)
            {
              case 0:
                goto label_3;
              case 1:
                this._tryCatchFinallyInfos = new int[1];
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 8;
                continue;
              case 2:
                this._tryCatchFinallyInfos = destinationArray;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 0 : 0;
                continue;
              case 3:
                if (catchFinallyInfos == null)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 1 : 0;
                  continue;
                }
                if (catchFinallyInfos.Length != 1)
                {
                  if (catchFinallyInfos.Length == 2)
                  {
                    num2 = 7;
                    continue;
                  }
                  length = catchFinallyInfos.Length;
                  num2 = 12;
                  continue;
                }
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 1 : 4;
                continue;
              case 4:
                goto label_18;
              case 5:
                catchFinallyInfos = this._tryCatchFinallyInfos;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 3 : 3;
                continue;
              case 6:
                ++this.CurrentTryCatchFinallyIndex;
                num2 = 5;
                continue;
              case 7:
                this._tryCatchFinallyInfos = new int[3]
                {
                  catchFinallyInfos[0],
                  catchFinallyInfos[1],
                  0
                };
                num2 = 11;
                continue;
              case 8:
                goto label_12;
              case 9:
                Array.Copy((Array) catchFinallyInfos, (Array) destinationArray, length);
                num2 = 2;
                continue;
              case 10:
                goto label_4;
              case 11:
                goto label_9;
              case 12:
                destinationArray = new int[length + 1];
                num2 = 9;
                continue;
              default:
                goto label_22;
            }
          }
label_18:
          this._tryCatchFinallyInfos = new int[2]
          {
            catchFinallyInfos[0],
            0
          };
          num1 = 10;
        }
label_3:
        return;
label_12:
        return;
label_4:
        return;
label_9:
        return;
label_22:;
      }

      public void MarkAsContainsReturnGotoExpression()
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (this.CurrentTryCatchFinallyIndex != -1)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 0;
                continue;
              }
              goto label_6;
            case 2:
              goto label_2;
            default:
              this._tryCatchFinallyInfos[this.CurrentTryCatchFinallyIndex] |= 1;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 2;
              continue;
          }
        }
label_2:
        return;
label_6:;
      }

      public void MarkReturnLabelIndex(int index)
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this._tryCatchFinallyInfos[this.CurrentTryCatchFinallyIndex] |= index << 1;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 0;
              continue;
            case 2:
              if (this.CurrentTryCatchFinallyIndex != -1)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 1 : 0;
                continue;
              }
              goto label_6;
            default:
              goto label_7;
          }
        }
label_2:
        return;
label_7:
        return;
label_6:;
      }

      public bool TryCatchFinallyContainsReturnGotoExpression()
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (this._tryCatchFinallyInfos == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            case 2:
              goto label_2;
            default:
              goto label_3;
          }
        }
label_2:
        return (this._tryCatchFinallyInfos[++this.CurrentTryCatchFinallyIndex] & 1) != 0;
label_3:
        return false;
      }

      public object[] GetArrayOfConstantsAndNestedLambdas()
      {
        int num1 = 36;
        object[] andNestedLambdas1;
        object[] items;
        object[] andNestedLambdas2;
        while (true)
        {
          int num2 = num1;
          ExpressionCompiler.NestedLambdaInfo[] nestedLambdas;
          int index1;
          ExpressionCompiler.NestedLambdaInfo nestedLambdaInfo1;
          int index2;
          ExpressionCompiler.NestedLambdaInfo nestedLambdaInfo2;
          int index3;
          int count;
          int length;
          while (true)
          {
            switch (num2)
            {
              case 1:
              case 2:
                goto label_30;
              case 3:
                goto label_41;
              case 4:
                if (nestedLambdas.Length != 0)
                {
                  num2 = 8;
                  continue;
                }
                goto label_37;
              case 5:
                nestedLambdaInfo2 = nestedLambdas[index2];
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 17 : 5;
                continue;
              case 6:
                goto label_8;
              case 7:
              case 20:
                if (index2 >= nestedLambdas.Length)
                {
                  num2 = 6;
                  continue;
                }
                goto case 5;
              case 8:
                andNestedLambdas1 = new object[nestedLambdas.Length];
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 0;
                continue;
              case 9:
                goto label_23;
              case 10:
              case 26:
                andNestedLambdas2[index3] = items[index3];
                num2 = 28;
                continue;
              case 11:
                goto label_37;
              case 12:
              case 39:
                andNestedLambdas2[count + index1] = (object) new ExpressionCompiler.NestedLambdaWithConstantsAndNestedLambdas(nestedLambdaInfo1.Lambda, (object) nestedLambdaInfo1.ClosureInfo.GetArrayOfConstantsAndNestedLambdas());
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 21 : 25;
                continue;
              case 13:
                length = count + nestedLambdas.Length;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 9;
                continue;
              case 14:
                andNestedLambdas1[index2] = nestedLambdaInfo2.Lambda;
                num2 = 24;
                continue;
              case 15:
              case 23:
                if (index3 < count)
                {
                  num2 = 10;
                  continue;
                }
                goto case 33;
              case 16:
              case 40:
                goto label_3;
              case 17:
                if (nestedLambdaInfo2.ClosureInfo.NonPassedParameters.Length != 0)
                {
                  num2 = 22;
                  continue;
                }
                goto case 14;
              case 18:
              case 22:
                andNestedLambdas1[index2] = (object) new ExpressionCompiler.NestedLambdaWithConstantsAndNestedLambdas(nestedLambdaInfo2.Lambda, (object) nestedLambdaInfo2.ClosureInfo.GetArrayOfConstantsAndNestedLambdas());
                num2 = 30;
                continue;
              case 19:
                index3 = 0;
                num2 = 15;
                continue;
              case 21:
                andNestedLambdas2[count + index1] = nestedLambdaInfo1.Lambda;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 35 : 37;
                continue;
              case 24:
              case 30:
                ++index2;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 10 : 20;
                continue;
              case 25:
              case 37:
                ++index1;
                num2 = 2;
                continue;
              case 27:
                if (nestedLambdas.Length != 0)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 12 : 13;
                  continue;
                }
                goto label_41;
              case 28:
                ++index3;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 3 : 23;
                continue;
              case 29:
                if (length > items.Length)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 6 : 31;
                  continue;
                }
                goto case 33;
              case 31:
                andNestedLambdas2 = new object[length];
                num2 = 19;
                continue;
              case 32:
                goto label_12;
              case 33:
                index1 = 0;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 1 : 1;
                continue;
              case 34:
                if (count != 0)
                {
                  items = this.Constants.Items;
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 19 : 27;
                  continue;
                }
                num2 = 4;
                continue;
              case 35:
                goto label_34;
              case 36:
                goto label_17;
              case 38:
                if (nestedLambdaInfo1.ClosureInfo.NonPassedParameters.Length != 0)
                {
                  num2 = 39;
                  continue;
                }
                goto case 21;
              default:
                index2 = 0;
                num2 = 7;
                continue;
            }
          }
label_3:
          nestedLambdaInfo1 = nestedLambdas[index1];
          num1 = 38;
          continue;
label_17:
          count = this.Constants.Count;
          num1 = 35;
          continue;
label_23:
          andNestedLambdas2 = items;
          num1 = 29;
          continue;
label_30:
          if (index1 < nestedLambdas.Length)
          {
            num1 = 40;
            continue;
          }
          goto label_12;
label_34:
          nestedLambdas = this.NestedLambdas;
          num1 = 34;
        }
label_8:
        return andNestedLambdas1;
label_12:
        return andNestedLambdas2;
label_37:
        return (object[]) null;
label_41:
        return items;
      }

      /// LocalVar maybe a `null` in collecting phase when we only need to decide if ParameterExpression is an actual parameter or variable
      public void PushBlockWithVars(ParameterExpression blockVarExpr)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this._blockStack.PushSlot().VarExprs = (object) blockVarExpr;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }

      public void PushBlockWithVars(ParameterExpression blockVarExpr, int varIndex)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              ref ExpressionCompiler.BlockInfo local = ref this._blockStack.PushSlot();
              local.VarExprs = (object) blockVarExpr;
              local.VarIndexes = new int[1]{ varIndex };
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }

      /// LocalVars maybe a `null` in collecting phase when we only need to decide if ParameterExpression is an actual parameter or variable
      public void PushBlockWithVars(
        IReadOnlyList<ParameterExpression> blockVarExprs,
        int[] localVarIndexes = null)
      {
        ref ExpressionCompiler.BlockInfo local = ref this._blockStack.PushSlot();
        local.VarExprs = (object) blockVarExprs;
        local.VarIndexes = localVarIndexes;
      }

      public void PushBlockAndConstructLocalVars(
        IReadOnlyList<ParameterExpression> blockVarExprs,
        ILGenerator il)
      {
        int[] localVarIndexes = new int[blockVarExprs.Count];
        for (int index = 0; index < localVarIndexes.Length; ++index)
          localVarIndexes[index] = il.GetNextLocalVarIndex(blockVarExprs[index].Type);
        this.PushBlockWithVars(blockVarExprs, localVarIndexes);
      }

      public void PopBlock()
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this._blockStack.Pop();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }

      public bool IsLocalVar(object varParamExpr)
      {
        int num = 8;
        int index1;
        object varExprs;
        int index2;
        while (true)
        {
          switch (num)
          {
            case 1:
            case 11:
              if (index2 >= ExpressionCompiler.ClosureInfo.KpSo4f8vVBWp2rJVPvJf((object) parameterExpressionList))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 0 : 0;
                continue;
              }
              goto case 5;
            case 2:
            case 7:
              if (index1 <= -1)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 0 : 9;
                continue;
              }
              goto case 4;
            case 3:
              goto label_9;
            case 4:
              varExprs = this._blockStack.Items[index1].VarExprs;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 13 : 3;
              continue;
            case 5:
              if (parameterExpressionList[index2] != varParamExpr)
              {
                ++index2;
                num = 11;
                continue;
              }
              num = 12;
              continue;
            case 6:
              index2 = 0;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 1 : 0;
              continue;
            case 8:
              index1 = this._blockStack.Count - 1;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 1 : 7;
              continue;
            case 9:
              goto label_19;
            case 12:
              goto label_7;
            case 13:
              if (varExprs == varParamExpr)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 3 : 3;
                continue;
              }
              if (!(varExprs is IReadOnlyList<ParameterExpression> parameterExpressionList))
              {
                num = 10;
                continue;
              }
              goto case 6;
            default:
              --index1;
              num = 2;
              continue;
          }
        }
label_7:
        return true;
label_9:
        return true;
label_19:
        return false;
      }

      public int GetDefinedLocalVarOrDefault(ParameterExpression varParamExpr)
      {
        int num1 = 13;
        // ISSUE: variable of a reference type
        ExpressionCompiler.BlockInfo& local;
        int index1;
        while (true)
        {
          int num2 = num1;
          int index2;
          object varExprs;
          while (true)
          {
            switch (num2)
            {
              case 2:
              case 12:
                if (index2 <= -1)
                {
                  num2 = 10;
                  continue;
                }
                goto label_16;
              case 3:
                varExprs = local.VarExprs;
                num2 = 5;
                continue;
              case 4:
              case 7:
                if (parameterExpressionList[index1] != varParamExpr)
                {
                  ++index1;
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 0;
                  continue;
                }
                num2 = 8;
                continue;
              case 5:
                if (varExprs != varParamExpr)
                {
                  if (varExprs is IReadOnlyList<ParameterExpression> parameterExpressionList)
                  {
                    num2 = 6;
                    continue;
                  }
                  goto case 14;
                }
                else
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 0 : 11;
                  continue;
                }
              case 6:
                index1 = 0;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 1 : 1;
                continue;
              case 8:
                goto label_3;
              case 9:
                goto label_16;
              case 10:
                goto label_8;
              case 11:
                goto label_10;
              case 13:
                index2 = this._blockStack.Count - 1;
                num2 = 12;
                continue;
              case 14:
                --index2;
                num2 = 2;
                continue;
              default:
                if (index1 < ExpressionCompiler.ClosureInfo.KpSo4f8vVBWp2rJVPvJf((object) parameterExpressionList))
                {
                  num2 = 4;
                  continue;
                }
                goto case 14;
            }
          }
label_16:
          local = ref this._blockStack.Items[index2];
          num1 = 3;
        }
label_3:
        return local.VarIndexes[index1];
label_8:
        return -1;
label_10:
        return local.VarIndexes[0];
      }

      public bool IsTryReturnLabel(int index)
      {
        int num1 = 3;
        while (true)
        {
          int num2 = num1;
          int[] catchFinallyInfos;
          int index1;
          while (true)
          {
            switch (num2)
            {
              case 1:
              case 6:
                if (catchFinallyInfos[index1] >> 1 == index)
                {
                  num2 = 9;
                  continue;
                }
                ++index1;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 0 : 0;
                continue;
              case 2:
                if (catchFinallyInfos == null)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 8 : 2;
                  continue;
                }
                goto case 4;
              case 3:
                goto label_7;
              case 4:
                index1 = 0;
                num2 = 5;
                continue;
              case 7:
              case 8:
                goto label_12;
              case 9:
                goto label_10;
              default:
                if (index1 < catchFinallyInfos.Length)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 1 : 1;
                  continue;
                }
                goto label_12;
            }
          }
label_7:
          catchFinallyInfos = this._tryCatchFinallyInfos;
          num1 = 2;
        }
label_10:
        return true;
label_12:
        return false;
      }

      internal static void ORpq0h8vZQU0lMk1BlpF() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool URmbJP8vvMH9Kle5UOwY() => ExpressionCompiler.ClosureInfo.AIExvi8vCm5CtIgivpoW == null;

      internal static object xWbDJK8v83NnrZssTgRm() => ExpressionCompiler.ClosureInfo.AIExvi8vCm5CtIgivpoW;

      internal static void Re0ZNv8vu8VoltRnhQRJ(
        [In] object obj0,
        [In] int obj1,
        [In] object obj2,
        [In] int obj3,
        [In] int obj4)
      {
        Array.Copy((Array) obj0, obj1, (Array) obj2, obj3, obj4);
      }

      internal static Label of7DXT8vI7Rw4H3omHIp([In] object obj0) => ((ILGenerator) obj0).DefineLabel();

      internal static int KpSo4f8vVBWp2rJVPvJf([In] object obj0) => ((IReadOnlyCollection<ParameterExpression>) obj0).Count;
    }

    public class ArrayClosure
    {
      public readonly object[] ConstantsAndNestedLambdas;
      private static ExpressionCompiler.ArrayClosure V3lN0u8vSC8TkHvx0DsF;

      public ArrayClosure(object[] constantsAndNestedLambdas)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
          num = 0;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_3;
            default:
              this.ConstantsAndNestedLambdas = constantsAndNestedLambdas;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 1 : 1;
              continue;
          }
        }
label_3:;
      }

      internal static bool fRLHr88vigSvGmIWtguD() => ExpressionCompiler.ArrayClosure.V3lN0u8vSC8TkHvx0DsF == null;

      internal static ExpressionCompiler.ArrayClosure x1tGtk8vRkqv2rU2XlAR() => ExpressionCompiler.ArrayClosure.V3lN0u8vSC8TkHvx0DsF;
    }

    public sealed class ArrayClosureWithNonPassedParams : ExpressionCompiler.ArrayClosure
    {
      public readonly object[] NonPassedParams;
      internal static ExpressionCompiler.ArrayClosureWithNonPassedParams uGupaD8vqWl2JETHW9V7;

      public ArrayClosureWithNonPassedParams(
        object[] constantsAndNestedLambdas,
        object[] nonPassedParams)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector(constantsAndNestedLambdas);
        int num = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
          num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_3;
            case 1:
              this.NonPassedParams = nonPassedParams;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 0;
              continue;
            default:
              goto label_5;
          }
        }
label_3:
        return;
label_5:;
      }

      internal static bool NbTO5P8vK76qQf2bsrlZ() => ExpressionCompiler.ArrayClosureWithNonPassedParams.uGupaD8vqWl2JETHW9V7 == null;

      internal static ExpressionCompiler.ArrayClosureWithNonPassedParams MVQ89c8vXbExn57HYr0Q() => ExpressionCompiler.ArrayClosureWithNonPassedParams.uGupaD8vqWl2JETHW9V7;
    }

    public sealed class NestedLambdaWithConstantsAndNestedLambdas
    {
      public static FieldInfo NestedLambdaField;
      public static FieldInfo ConstantsAndNestedLambdasField;
      public readonly object NestedLambda;
      public readonly object ConstantsAndNestedLambdas;
      internal static ExpressionCompiler.NestedLambdaWithConstantsAndNestedLambdas RjHRa08vT7qEBmvkbTg4;

      public NestedLambdaWithConstantsAndNestedLambdas(
        object nestedLambda,
        object constantsAndNestedLambdas)
      {
        ExpressionCompiler.NestedLambdaWithConstantsAndNestedLambdas.mRsJ018vOZpwG5OKOCCN();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_2;
            case 2:
              this.NestedLambda = nestedLambda;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 0;
              continue;
            default:
              this.ConstantsAndNestedLambdas = constantsAndNestedLambdas;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 0 : 1;
              continue;
          }
        }
label_2:;
      }

      static NestedLambdaWithConstantsAndNestedLambdas()
      {
        int num = 3;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              ExpressionCompiler.NestedLambdaWithConstantsAndNestedLambdas.ConstantsAndNestedLambdasField = (FieldInfo) ExpressionCompiler.NestedLambdaWithConstantsAndNestedLambdas.mKpYPB8v1StVlGcAaIfc(ExpressionCompiler.NestedLambdaWithConstantsAndNestedLambdas.T3E3um8veZt1UcADe8JJ(typeof (ExpressionCompiler.NestedLambdaWithConstantsAndNestedLambdas)), ExpressionCompiler.NestedLambdaWithConstantsAndNestedLambdas.HbPjeE8vPyKKPi96MhV1(-420743386 ^ -420485228));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 0 : 0;
              continue;
            case 2:
              // ISSUE: type reference
              ExpressionCompiler.NestedLambdaWithConstantsAndNestedLambdas.NestedLambdaField = (FieldInfo) ExpressionCompiler.NestedLambdaWithConstantsAndNestedLambdas.mKpYPB8v1StVlGcAaIfc(ExpressionCompiler.NestedLambdaWithConstantsAndNestedLambdas.T3E3um8veZt1UcADe8JJ(ExpressionCompiler.NestedLambdaWithConstantsAndNestedLambdas.cwwuI08v2G7FrVGldgmm(__typeref (ExpressionCompiler.NestedLambdaWithConstantsAndNestedLambdas))), ExpressionCompiler.NestedLambdaWithConstantsAndNestedLambdas.HbPjeE8vPyKKPi96MhV1(1149433385 + 173655049 ^ 1322869034));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 1 : 0;
              continue;
            case 3:
              ExpressionCompiler.NestedLambdaWithConstantsAndNestedLambdas.mRsJ018vOZpwG5OKOCCN();
              num = 2;
              continue;
            default:
              goto label_6;
          }
        }
label_2:
        return;
label_6:;
      }

      internal static void mRsJ018vOZpwG5OKOCCN() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool UmHAL58vkvHbMQ9CY0rH() => ExpressionCompiler.NestedLambdaWithConstantsAndNestedLambdas.RjHRa08vT7qEBmvkbTg4 == null;

      internal static ExpressionCompiler.NestedLambdaWithConstantsAndNestedLambdas yosSyZ8vnvfwUryMf9ix() => ExpressionCompiler.NestedLambdaWithConstantsAndNestedLambdas.RjHRa08vT7qEBmvkbTg4;

      internal static Type cwwuI08v2G7FrVGldgmm([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

      internal static object T3E3um8veZt1UcADe8JJ([In] Type obj0) => (object) IntrospectionExtensions.GetTypeInfo(obj0);

      internal static object HbPjeE8vPyKKPi96MhV1(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static object mKpYPB8v1StVlGcAaIfc([In] object obj0, [In] object obj1) => (object) ((TypeInfo) obj0).GetDeclaredField((string) obj1);
    }

    private sealed class NestedLambdaInfo
    {
      public readonly object LambdaExpression;
      public ExpressionCompiler.ClosureInfo ClosureInfo;
      public object Lambda;
      public int UsageCountOrVarIndex;
      private static object M9Bxop8vNERju3IyK0F2;

      public NestedLambdaInfo(LambdaExpression lambdaExpression)
      {
        ExpressionCompiler.NestedLambdaInfo.FW5j8D8vaSVRCoV0rtXq();
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
              this.ClosureInfo = new ExpressionCompiler.ClosureInfo(ExpressionCompiler.ClosureStatus.ToBeCollected);
              num = 3;
              continue;
            case 2:
              this.LambdaExpression = (object) lambdaExpression;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 1 : 1;
              continue;
            case 3:
              this.Lambda = (object) null;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 0 : 0;
              continue;
            default:
              goto label_6;
          }
        }
label_2:
        return;
label_6:;
      }

      internal static void FW5j8D8vaSVRCoV0rtXq() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool oWEKFR8v31KisxF366XP() => ExpressionCompiler.NestedLambdaInfo.M9Bxop8vNERju3IyK0F2 == null;

      internal static ExpressionCompiler.NestedLambdaInfo wdCpeh8vpYwmw4ijGPwZ() => (ExpressionCompiler.NestedLambdaInfo) ExpressionCompiler.NestedLambdaInfo.M9Bxop8vNERju3IyK0F2;
    }

    internal static class CurryClosureFuncs
    {
      public static readonly MethodInfo[] Methods;
      internal static ExpressionCompiler.CurryClosureFuncs Ashgy48vDjss3HgQ7mES;

      public static Func<R> Curry<C, R>(Func<C, R> f, C c) => (Func<R>) (() => f(c));

      public static Func<T1, R> Curry<C, T1, R>(Func<C, T1, R> f, C c) => (Func<T1, R>) (t1 => f(c, t1));

      public static Func<T1, T2, R> Curry<C, T1, T2, R>(Func<C, T1, T2, R> f, C c) => (Func<T1, T2, R>) ((t1, t2) => f(c, t1, t2));

      public static Func<T1, T2, T3, R> Curry<C, T1, T2, T3, R>(Func<C, T1, T2, T3, R> f, C c) => (Func<T1, T2, T3, R>) ((t1, t2, t3) => f(c, t1, t2, t3));

      public static Func<T1, T2, T3, T4, R> Curry<C, T1, T2, T3, T4, R>(
        Func<C, T1, T2, T3, T4, R> f,
        C c)
      {
        return (Func<T1, T2, T3, T4, R>) ((t1, t2, t3, t4) => f(c, t1, t2, t3, t4));
      }

      public static Func<T1, T2, T3, T4, T5, R> Curry<C, T1, T2, T3, T4, T5, R>(
        Func<C, T1, T2, T3, T4, T5, R> f,
        C c)
      {
        return (Func<T1, T2, T3, T4, T5, R>) ((t1, t2, t3, t4, t5) => f(c, t1, t2, t3, t4, t5));
      }

      public static Func<T1, T2, T3, T4, T5, T6, R> Curry<C, T1, T2, T3, T4, T5, T6, R>(
        Func<C, T1, T2, T3, T4, T5, T6, R> f,
        C c)
      {
        return (Func<T1, T2, T3, T4, T5, T6, R>) ((t1, t2, t3, t4, t5, t6) => f(c, t1, t2, t3, t4, t5, t6));
      }

      static CurryClosureFuncs()
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              ExpressionCompiler.CurryClosureFuncs.tlnsJT8v4P94voqGVeth();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_2;
            default:
              // ISSUE: type reference
              ExpressionCompiler.CurryClosureFuncs.Methods = ((TypeInfo) ExpressionCompiler.CurryClosureFuncs.Ed90rt8vHLd1JgAcMQKq(ExpressionCompiler.CurryClosureFuncs.xLHGGw8v6Tcf73jW1Xxi(__typeref (ExpressionCompiler.CurryClosureFuncs)))).DeclaredMethods.AsArray<MethodInfo>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 2 : 1;
              continue;
          }
        }
label_2:;
      }

      internal static void tlnsJT8v4P94voqGVeth() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static Type xLHGGw8v6Tcf73jW1Xxi([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

      internal static object Ed90rt8vHLd1JgAcMQKq([In] Type obj0) => (object) IntrospectionExtensions.GetTypeInfo(obj0);

      internal static bool Dt74EW8vtVEGDcHkfO5D() => ExpressionCompiler.CurryClosureFuncs.Ashgy48vDjss3HgQ7mES == null;

      internal static ExpressionCompiler.CurryClosureFuncs I4Guxq8vwAp35h9aQvSr() => ExpressionCompiler.CurryClosureFuncs.Ashgy48vDjss3HgQ7mES;
    }

    internal static class CurryClosureActions
    {
      public static readonly MethodInfo[] Methods;
      internal static ExpressionCompiler.CurryClosureActions LbUF5Q8vAWeff57DbtNa;

      public static System.Action Curry<C>(Action<C> a, C c) => (System.Action) (() =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              a(c);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      });

      public static Action<T1> Curry<C, T1>(Action<C, T1> f, C c) => (Action<T1>) (t1 => f(c, t1));

      public static Action<T1, T2> Curry<C, T1, T2>(Action<C, T1, T2> f, C c) => (Action<T1, T2>) ((t1, t2) => f(c, t1, t2));

      public static Action<T1, T2, T3> Curry<C, T1, T2, T3>(Action<C, T1, T2, T3> f, C c) => (Action<T1, T2, T3>) ((t1, t2, t3) => f(c, t1, t2, t3));

      public static Action<T1, T2, T3, T4> Curry<C, T1, T2, T3, T4>(
        Action<C, T1, T2, T3, T4> f,
        C c)
      {
        return (Action<T1, T2, T3, T4>) ((t1, t2, t3, t4) => f(c, t1, t2, t3, t4));
      }

      public static Action<T1, T2, T3, T4, T5> Curry<C, T1, T2, T3, T4, T5>(
        Action<C, T1, T2, T3, T4, T5> f,
        C c)
      {
        return (Action<T1, T2, T3, T4, T5>) ((t1, t2, t3, t4, t5) => f(c, t1, t2, t3, t4, t5));
      }

      public static Action<T1, T2, T3, T4, T5, T6> Curry<C, T1, T2, T3, T4, T5, T6>(
        Action<C, T1, T2, T3, T4, T5, T6> f,
        C c)
      {
        return (Action<T1, T2, T3, T4, T5, T6>) ((t1, t2, t3, t4, t5, t6) => f(c, t1, t2, t3, t4, t5, t6));
      }

      static CurryClosureActions()
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              ExpressionCompiler.CurryClosureActions.PVnFl58v0lT1Q1LWLLRO();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_2;
            default:
              ExpressionCompiler.CurryClosureActions.Methods = ((TypeInfo) ExpressionCompiler.CurryClosureActions.m9H5l08vmZvmfXrNrnvT(typeof (ExpressionCompiler.CurryClosureActions))).DeclaredMethods.AsArray<MethodInfo>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 2 : 0;
              continue;
          }
        }
label_2:;
      }

      internal static void PVnFl58v0lT1Q1LWLLRO() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static object m9H5l08vmZvmfXrNrnvT([In] Type obj0) => (object) IntrospectionExtensions.GetTypeInfo(obj0);

      internal static bool LXp2Wd8v7GahDPkHcg56() => ExpressionCompiler.CurryClosureActions.LbUF5Q8vAWeff57DbtNa == null;

      internal static ExpressionCompiler.CurryClosureActions jNMSNE8vxBOHI6dUGnsX() => ExpressionCompiler.CurryClosureActions.LbUF5Q8vAWeff57DbtNa;
    }

    [Flags]
    internal enum ParentFlags
    {
      Empty = 0,
      IgnoreResult = 2,
      Call = 4,
      MemberAccess = 8,
      Arithmetic = 16, // 0x00000010
      Coalesce = 32, // 0x00000020
      InstanceAccess = 64, // 0x00000040
      DupMemberOwner = 128, // 0x00000080
      TryCatch = 256, // 0x00000100
      InstanceCall = InstanceAccess | Call, // 0x00000044
    }

    /// <summary>Supports emitting of selected expressions, e.g. lambdaExpr are not supported yet.
    /// When emitter find not supported expression it will return false from <see cref="M:EleWise.ELMA.ExpressionUtil.ExpressionCompiler.EmittingVisitor.TryEmit(System.Linq.Expressions.Expression,System.Collections.Generic.IReadOnlyList{System.Linq.Expressions.ParameterExpression},System.Reflection.Emit.ILGenerator,EleWise.ELMA.ExpressionUtil.ExpressionCompiler.ClosureInfo@,EleWise.ELMA.ExpressionUtil.ExpressionCompiler.ParentFlags,System.Int32)" />, so I could fallback
    /// to normal and slow Expression.Compile.</summary>
    private static class EmittingVisitor
    {
      private static readonly object _getTypeFromHandleMethod;
      private static readonly object _objectEqualsMethod;
      private static readonly Lazy<ConstructorInfo> _decimalCtor;
      private static object KMULmi8v997Yn3cUEGre;

      public static bool TryEmit(
        object expr,
        IReadOnlyList<ParameterExpression> paramExprs,
        object il,
        ref ExpressionCompiler.ClosureInfo closure,
        ExpressionCompiler.ParentFlags parent,
        int byRefIndex = -1)
      {
        while (true)
        {
          int count;
          do
          {
            closure.LastEmitIsAddress = false;
            switch (((Expression) expr).NodeType)
            {
              case ExpressionType.Add:
              case ExpressionType.AddChecked:
              case ExpressionType.And:
              case ExpressionType.Divide:
              case ExpressionType.ExclusiveOr:
              case ExpressionType.LeftShift:
              case ExpressionType.Modulo:
              case ExpressionType.Multiply:
              case ExpressionType.MultiplyChecked:
              case ExpressionType.Or:
              case ExpressionType.Power:
              case ExpressionType.RightShift:
              case ExpressionType.Subtract:
              case ExpressionType.SubtractChecked:
                return ExpressionCompiler.EmittingVisitor.TryEmitArithmetic((object) (BinaryExpression) expr, ((Expression) expr).NodeType, paramExprs, il, ref closure, parent);
              case ExpressionType.AndAlso:
              case ExpressionType.OrElse:
                return ExpressionCompiler.EmittingVisitor.TryEmitLogicalOperator((object) (BinaryExpression) expr, paramExprs, il, ref closure, parent);
              case ExpressionType.ArrayLength:
                return ExpressionCompiler.EmittingVisitor.TryEmitArrayLength((object) (UnaryExpression) expr, paramExprs, il, ref closure, parent);
              case ExpressionType.ArrayIndex:
                BinaryExpression binaryExpression1 = (BinaryExpression) expr;
                return ExpressionCompiler.EmittingVisitor.TryEmit((object) binaryExpression1.Left, paramExprs, il, ref closure, parent) && ExpressionCompiler.EmittingVisitor.TryEmit((object) binaryExpression1.Right, paramExprs, il, ref closure, parent) && ExpressionCompiler.EmittingVisitor.TryEmitArrayIndex(((Expression) expr).Type, il);
              case ExpressionType.Call:
                return ExpressionCompiler.EmittingVisitor.TryEmitMethodCall(expr, paramExprs, il, ref closure, parent);
              case ExpressionType.Coalesce:
                return ExpressionCompiler.EmittingVisitor.TryEmitCoalesceOperator((object) (BinaryExpression) expr, paramExprs, il, ref closure, parent);
              case ExpressionType.Conditional:
                return ExpressionCompiler.EmittingVisitor.TryEmitConditional((object) (ConditionalExpression) expr, paramExprs, il, ref closure, parent);
              case ExpressionType.Constant:
                ConstantExpression constantExpression = (ConstantExpression) expr;
                if ((parent & ExpressionCompiler.ParentFlags.IgnoreResult) != ExpressionCompiler.ParentFlags.Empty)
                  return true;
                if (constantExpression.Value != null)
                  return ExpressionCompiler.EmittingVisitor.TryEmitNotNullConstant(true, constantExpression.Type, constantExpression.Value, il, ref closure);
                ((ILGenerator) il).Emit(OpCodes.Ldnull);
                return true;
              case ExpressionType.Convert:
              case ExpressionType.ConvertChecked:
                return ExpressionCompiler.EmittingVisitor.TryEmitConvert((object) (UnaryExpression) expr, paramExprs, il, ref closure, parent);
              case ExpressionType.Equal:
              case ExpressionType.GreaterThan:
              case ExpressionType.GreaterThanOrEqual:
              case ExpressionType.LessThan:
              case ExpressionType.LessThanOrEqual:
              case ExpressionType.NotEqual:
                BinaryExpression binaryExpression2 = (BinaryExpression) expr;
                return ExpressionCompiler.EmittingVisitor.TryEmitComparison((object) binaryExpression2.Left, (object) binaryExpression2.Right, binaryExpression2.NodeType, paramExprs, il, ref closure, parent);
              case ExpressionType.Invoke:
                if (!(((InvocationExpression) expr).Expression is LambdaExpression expression) || expression.Parameters.Count != 0)
                  return ExpressionCompiler.EmittingVisitor.TryEmitInvoke((object) (InvocationExpression) expr, paramExprs, il, ref closure, parent);
                expr = (object) expression.Body;
                continue;
              case ExpressionType.Lambda:
                return ExpressionCompiler.EmittingVisitor.TryEmitNestedLambda((object) (LambdaExpression) expr, paramExprs, il, ref closure);
              case ExpressionType.MemberAccess:
                return ExpressionCompiler.EmittingVisitor.TryEmitMemberAccess((object) (MemberExpression) expr, paramExprs, il, ref closure, parent);
              case ExpressionType.MemberInit:
                return ExpressionCompiler.EmittingVisitor.EmitMemberInit((object) (MemberInitExpression) expr, paramExprs, il, ref closure, parent);
              case ExpressionType.Negate:
              case ExpressionType.UnaryPlus:
              case ExpressionType.NegateChecked:
              case ExpressionType.TypeAs:
              case ExpressionType.Decrement:
              case ExpressionType.Increment:
              case ExpressionType.Unbox:
              case ExpressionType.OnesComplement:
              case ExpressionType.IsTrue:
              case ExpressionType.IsFalse:
                return ExpressionCompiler.EmittingVisitor.TryEmitSimpleUnaryExpression((object) (UnaryExpression) expr, paramExprs, il, ref closure, parent);
              case ExpressionType.New:
                return ExpressionCompiler.EmittingVisitor.TryEmitNew(expr, paramExprs, il, ref closure, parent);
              case ExpressionType.NewArrayInit:
              case ExpressionType.NewArrayBounds:
                return ExpressionCompiler.EmittingVisitor.EmitNewArray((object) (NewArrayExpression) expr, paramExprs, il, ref closure, parent);
              case ExpressionType.Not:
                return ExpressionCompiler.EmittingVisitor.TryEmitNot((object) (UnaryExpression) expr, paramExprs, il, ref closure, parent);
              case ExpressionType.Parameter:
                return (parent & ExpressionCompiler.ParentFlags.IgnoreResult) != ExpressionCompiler.ParentFlags.Empty || ExpressionCompiler.EmittingVisitor.TryEmitParameter((object) (ParameterExpression) expr, paramExprs, il, ref closure, parent, byRefIndex);
              case ExpressionType.Quote:
                return false;
              case ExpressionType.TypeIs:
                return ExpressionCompiler.EmittingVisitor.TryEmitTypeIs((object) (TypeBinaryExpression) expr, paramExprs, il, ref closure, parent);
              case ExpressionType.Assign:
              case ExpressionType.AddAssign:
              case ExpressionType.AndAssign:
              case ExpressionType.DivideAssign:
              case ExpressionType.ExclusiveOrAssign:
              case ExpressionType.LeftShiftAssign:
              case ExpressionType.ModuloAssign:
              case ExpressionType.MultiplyAssign:
              case ExpressionType.OrAssign:
              case ExpressionType.PowerAssign:
              case ExpressionType.RightShiftAssign:
              case ExpressionType.SubtractAssign:
              case ExpressionType.AddAssignChecked:
              case ExpressionType.MultiplyAssignChecked:
              case ExpressionType.SubtractAssignChecked:
                return ExpressionCompiler.EmittingVisitor.TryEmitAssign((object) (BinaryExpression) expr, paramExprs, il, ref closure, parent);
              case ExpressionType.Block:
                BlockExpression blockExpression = (BlockExpression) expr;
                ReadOnlyCollection<ParameterExpression> variables = blockExpression.Variables;
                count = variables.Count;
                if (count == 1)
                  closure.PushBlockWithVars(variables[0], ((ILGenerator) il).GetNextLocalVarIndex(variables[0].Type));
                else if (count > 1)
                  closure.PushBlockAndConstructLocalVars((IReadOnlyList<ParameterExpression>) variables, (ILGenerator) il);
                ReadOnlyCollection<Expression> expressions = blockExpression.Expressions;
                int num = expressions.Count;
                expr = (object) expressions[num - 1];
                if (num > 1)
                {
                  int index = num - 1;
                  while (index != -1 && expressions[index].NodeType != ExpressionType.Throw)
                    --index;
                  if (index != -1 && index != num - 1)
                  {
                    expr = (object) Expression.Throw(((UnaryExpression) expressions[index]).Operand, blockExpression.Type);
                    num = index + 1;
                  }
                }
                if (num > 1)
                {
                  for (int index = 0; index < num - 1; ++index)
                  {
                    if (!ExpressionCompiler.EmittingVisitor.TryEmit((object) expressions[index], paramExprs, il, ref closure, parent | ExpressionCompiler.ParentFlags.IgnoreResult))
                      return false;
                  }
                }
                continue;
              case ExpressionType.Default:
                goto label_59;
              case ExpressionType.Extension:
                goto label_66;
              case ExpressionType.Goto:
                goto label_63;
              case ExpressionType.Index:
                goto label_62;
              case ExpressionType.Label:
                goto label_64;
              case ExpressionType.Loop:
                goto label_54;
              case ExpressionType.Switch:
                goto label_65;
              case ExpressionType.Throw:
                goto label_56;
              case ExpressionType.Try:
                goto label_55;
              case ExpressionType.PreIncrementAssign:
              case ExpressionType.PreDecrementAssign:
              case ExpressionType.PostIncrementAssign:
              case ExpressionType.PostDecrementAssign:
                return ExpressionCompiler.EmittingVisitor.TryEmitIncDecAssign((object) (UnaryExpression) expr, paramExprs, il, ref closure, parent);
              default:
                goto label_67;
            }
          }
          while (count == 0);
          break;
label_66:
          expr = (object) ((Expression) expr).Reduce();
        }
        if (!ExpressionCompiler.EmittingVisitor.TryEmit(expr, paramExprs, il, ref closure, parent))
          return false;
        closure.PopBlock();
        return true;
label_54:
        return ExpressionCompiler.EmittingVisitor.TryEmitLoop((object) (LoopExpression) expr, paramExprs, il, ref closure, parent);
label_55:
        return ExpressionCompiler.EmittingVisitor.TryEmitTryCatchFinallyBlock((object) (TryExpression) expr, paramExprs, il, ref closure, parent | ExpressionCompiler.ParentFlags.TryCatch);
label_56:
        if (!ExpressionCompiler.EmittingVisitor.TryEmit((object) ((UnaryExpression) expr).Operand, paramExprs, il, ref closure, parent & ~ExpressionCompiler.ParentFlags.IgnoreResult))
          return false;
        ((ILGenerator) il).Emit(OpCodes.Throw);
        return true;
label_59:
        if (((Expression) expr).Type != typeof (void) && (parent & ExpressionCompiler.ParentFlags.IgnoreResult) == ExpressionCompiler.ParentFlags.Empty)
          ExpressionCompiler.EmittingVisitor.EmitDefault(((Expression) expr).Type, il);
        return true;
label_62:
        return ExpressionCompiler.EmittingVisitor.TryEmitIndex((object) (IndexExpression) expr, paramExprs, il, ref closure, parent);
label_63:
        return ExpressionCompiler.EmittingVisitor.TryEmitGoto((object) (GotoExpression) expr, paramExprs, il, ref closure, parent);
label_64:
        return ExpressionCompiler.EmittingVisitor.TryEmitLabel((object) (LabelExpression) expr, paramExprs, il, ref closure, parent);
label_65:
        return ExpressionCompiler.EmittingVisitor.TryEmitSwitch((object) (SwitchExpression) expr, paramExprs, il, ref closure, parent);
label_67:
        return false;
      }

      private static bool TryEmitNew(
        object expr,
        IReadOnlyList<ParameterExpression> paramExprs,
        object il,
        ref ExpressionCompiler.ClosureInfo closure,
        ExpressionCompiler.ParentFlags parent)
      {
        NewExpression newExpression = (NewExpression) expr;
        ReadOnlyCollection<Expression> arguments = newExpression.Arguments;
        if (arguments.Count != 0)
        {
          ParameterInfo[] parameters = newExpression.Constructor.GetParameters();
          for (int index = 0; index < parameters.Length; ++index)
          {
            if (!ExpressionCompiler.EmittingVisitor.TryEmit((object) arguments[index], paramExprs, il, ref closure, parent, parameters[index].ParameterType.IsByRef ? index : -1))
              return false;
          }
        }
        if (newExpression.Constructor != (ConstructorInfo) null)
        {
          ((ILGenerator) il).Emit(OpCodes.Newobj, newExpression.Constructor);
        }
        else
        {
          if (!newExpression.Type.IsValueType())
            return false;
          ExpressionCompiler.EmittingVisitor.EmitLoadLocalVariable(il, ExpressionCompiler.EmittingVisitor.InitValueTypeVariable(il, newExpression.Type));
        }
        return true;
      }

      private static bool TryEmitArrayLength(
        object arrLengthExpr,
        IReadOnlyList<ParameterExpression> paramExprs,
        object il,
        ref ExpressionCompiler.ClosureInfo closure,
        ExpressionCompiler.ParentFlags parent)
      {
        if (!ExpressionCompiler.EmittingVisitor.TryEmit((object) ((UnaryExpression) arrLengthExpr).Operand, paramExprs, il, ref closure, parent))
          return false;
        if ((parent & ExpressionCompiler.ParentFlags.IgnoreResult) == ExpressionCompiler.ParentFlags.Empty)
        {
          ((ILGenerator) il).Emit(OpCodes.Ldlen);
          ((ILGenerator) il).Emit(OpCodes.Conv_I4);
        }
        return true;
      }

      private static bool TryEmitLoop(
        object loopExpr,
        IReadOnlyList<ParameterExpression> paramExprs,
        object il,
        ref ExpressionCompiler.ClosureInfo closure,
        ExpressionCompiler.ParentFlags parent)
      {
        Label label = ((ILGenerator) il).DefineLabel();
        ((ILGenerator) il).MarkLabel(label);
        if (((LoopExpression) loopExpr).ContinueLabel != null)
          ((ILGenerator) il).MarkLabel(closure.GetOrCreateLabel(((LoopExpression) loopExpr).ContinueLabel, (ILGenerator) il));
        if (!ExpressionCompiler.EmittingVisitor.TryEmit((object) ((LoopExpression) loopExpr).Body, paramExprs, il, ref closure, parent))
          return false;
        ((ILGenerator) il).Emit(OpCodes.Br, label);
        if (((LoopExpression) loopExpr).BreakLabel != null)
          ((ILGenerator) il).MarkLabel(closure.GetOrCreateLabel(((LoopExpression) loopExpr).BreakLabel, (ILGenerator) il));
        return true;
      }

      private static bool TryEmitIndex(
        object indexExpr,
        IReadOnlyList<ParameterExpression> paramExprs,
        object il,
        ref ExpressionCompiler.ClosureInfo closure,
        ExpressionCompiler.ParentFlags parent)
      {
        if (((IndexExpression) indexExpr).Object != null && !ExpressionCompiler.EmittingVisitor.TryEmit((object) ((IndexExpression) indexExpr).Object, paramExprs, il, ref closure, parent))
          return false;
        ReadOnlyCollection<Expression> arguments = ((IndexExpression) indexExpr).Arguments;
        for (int index = 0; index < arguments.Count; ++index)
        {
          if (!ExpressionCompiler.EmittingVisitor.TryEmit((object) arguments[index], paramExprs, il, ref closure, parent, arguments[index].Type.IsByRef ? index : -1))
            return false;
        }
        PropertyInfo indexer = ((IndexExpression) indexExpr).Indexer;
        if (indexer != (PropertyInfo) null)
          return ExpressionCompiler.EmittingVisitor.EmitMethodCall(il, (object) indexer.DeclaringType.FindPropertyGetMethod(indexer.Name));
        if (((IndexExpression) indexExpr).Arguments.Count == 1)
          return ExpressionCompiler.EmittingVisitor.TryEmitArrayIndex(((Expression) indexExpr).Type, il);
        object il1 = il;
        Expression expression = ((IndexExpression) indexExpr).Object;
        MethodInfo method = expression != null ? expression.Type.FindMethod(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1255365154 ^ 596875508 ^ -1766039054)) : (MethodInfo) null;
        return ExpressionCompiler.EmittingVisitor.EmitMethodCall(il1, (object) method);
      }

      private static bool TryEmitLabel(
        object expr,
        IReadOnlyList<ParameterExpression> paramExprs,
        object il,
        ref ExpressionCompiler.ClosureInfo closure,
        ExpressionCompiler.ParentFlags parent)
      {
        int labelIndex = closure.GetLabelIndex(((LabelExpression) expr).Target);
        if (labelIndex == -1)
          return false;
        if (closure.IsTryReturnLabel(labelIndex))
          return true;
        Label label = closure.GetOrCreateLabel(labelIndex, (ILGenerator) il);
        ((ILGenerator) il).MarkLabel(label);
        return ((LabelExpression) expr).DefaultValue == null || ExpressionCompiler.EmittingVisitor.TryEmit((object) ((LabelExpression) expr).DefaultValue, paramExprs, il, ref closure, parent);
      }

      private static bool TryEmitGoto(
        object expr,
        IReadOnlyList<ParameterExpression> paramExprs,
        object il,
        ref ExpressionCompiler.ClosureInfo closure,
        ExpressionCompiler.ParentFlags parent)
      {
        int labelIndex = closure.GetLabelIndex(((GotoExpression) expr).Target);
        if (labelIndex == -1)
        {
          if ((closure.Status & ExpressionCompiler.ClosureStatus.ToBeCollected) == (ExpressionCompiler.ClosureStatus) 0)
            return false;
          throw new InvalidOperationException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1598106783 - -968262081 ^ -630157802));
        }
        if (((GotoExpression) expr).Value != null && !ExpressionCompiler.EmittingVisitor.TryEmit((object) ((GotoExpression) expr).Value, paramExprs, il, ref closure, parent & ~ExpressionCompiler.ParentFlags.IgnoreResult))
          return false;
        switch (((GotoExpression) expr).Kind)
        {
          case GotoExpressionKind.Goto:
            if (((GotoExpression) expr).Value == null)
            {
              ((ILGenerator) il).Emit(OpCodes.Br, closure.GetOrCreateLabel(labelIndex, (ILGenerator) il));
              return true;
            }
            goto case GotoExpressionKind.Return;
          case GotoExpressionKind.Return:
            if ((parent & ExpressionCompiler.ParentFlags.TryCatch) != ExpressionCompiler.ParentFlags.Empty)
              closure.MarkReturnLabelIndex(labelIndex);
            else
              ((ILGenerator) il).Emit(OpCodes.Ret, closure.GetOrCreateLabel(labelIndex, (ILGenerator) il));
            return true;
          case GotoExpressionKind.Break:
          case GotoExpressionKind.Continue:
            ((ILGenerator) il).Emit(OpCodes.Br, closure.GetOrCreateLabel(labelIndex, (ILGenerator) il));
            return true;
          default:
            return false;
        }
      }

      private static bool TryEmitCoalesceOperator(
        object exprObj,
        IReadOnlyList<ParameterExpression> paramExprs,
        object il,
        ref ExpressionCompiler.ClosureInfo closure,
        ExpressionCompiler.ParentFlags parent)
      {
        Label label1 = ((ILGenerator) il).DefineLabel();
        Label label2 = ((ILGenerator) il).DefineLabel();
        Expression left = ((BinaryExpression) exprObj).Left;
        Expression right = ((BinaryExpression) exprObj).Right;
        if (!ExpressionCompiler.EmittingVisitor.TryEmit((object) left, paramExprs, il, ref closure, parent | ExpressionCompiler.ParentFlags.Coalesce))
          return false;
        Type type = left.Type;
        if (type.IsValueType())
        {
          int location = ExpressionCompiler.EmittingVisitor.EmitStoreLocalVariableAndLoadItsAddress(il, type);
          ((ILGenerator) il).Emit(OpCodes.Call, type.FindNullableHasValueGetterMethod());
          ((ILGenerator) il).Emit(OpCodes.Brfalse, label1);
          ExpressionCompiler.EmittingVisitor.EmitLoadLocalVariableAddress(il, location);
          ((ILGenerator) il).Emit(OpCodes.Call, type.FindNullableGetValueOrDefaultMethod());
          ((ILGenerator) il).Emit(OpCodes.Br, label2);
          ((ILGenerator) il).MarkLabel(label1);
          if (!ExpressionCompiler.EmittingVisitor.TryEmit((object) right, paramExprs, il, ref closure, parent | ExpressionCompiler.ParentFlags.Coalesce))
            return false;
          ((ILGenerator) il).MarkLabel(label2);
          return true;
        }
        ((ILGenerator) il).Emit(OpCodes.Dup);
        ((ILGenerator) il).Emit(OpCodes.Ldnull);
        ((ILGenerator) il).Emit(OpCodes.Ceq);
        ((ILGenerator) il).Emit(OpCodes.Brfalse, label1);
        ((ILGenerator) il).Emit(OpCodes.Pop);
        if (!ExpressionCompiler.EmittingVisitor.TryEmit((object) right, paramExprs, il, ref closure, parent | ExpressionCompiler.ParentFlags.Coalesce))
          return false;
        if (right.Type != ((Expression) exprObj).Type && right.Type.IsValueType())
          ((ILGenerator) il).Emit(OpCodes.Box, right.Type);
        if (left.Type == ((Expression) exprObj).Type)
        {
          ((ILGenerator) il).MarkLabel(label1);
        }
        else
        {
          ((ILGenerator) il).Emit(OpCodes.Br, label2);
          ((ILGenerator) il).MarkLabel(label1);
          ((ILGenerator) il).Emit(OpCodes.Castclass, ((Expression) exprObj).Type);
          ((ILGenerator) il).MarkLabel(label2);
        }
        return true;
      }

      private static void EmitDefault(Type type, object il)
      {
        int num1 = 3;
        while (true)
        {
          int num2 = num1;
          while (true)
          {
            switch (num2)
            {
              case 1:
                // ISSUE: type reference
                if (!ExpressionCompiler.EmittingVisitor.fXH2wl8v53gf6fwkZ1cA(type, ExpressionCompiler.EmittingVisitor.U4TPVi8vg9UgNc6Skdyl(__typeref (int))))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 6 : 8;
                  continue;
                }
                goto case 16;
              case 2:
                // ISSUE: type reference
                if (!ExpressionCompiler.EmittingVisitor.fXH2wl8v53gf6fwkZ1cA(type, ExpressionCompiler.EmittingVisitor.U4TPVi8vg9UgNc6Skdyl(__typeref (bool))))
                {
                  num2 = 15;
                  continue;
                }
                goto case 16;
              case 3:
                if (((Type) ExpressionCompiler.EmittingVisitor.GNKm9i8vrhrfeYTW9WQI(type)).IsValueType)
                {
                  num2 = 2;
                  continue;
                }
                goto case 26;
              case 4:
                goto label_3;
              case 5:
                goto label_31;
              case 6:
                // ISSUE: type reference
                if (!ExpressionCompiler.EmittingVisitor.fXH2wl8v53gf6fwkZ1cA(type, ExpressionCompiler.EmittingVisitor.U4TPVi8vg9UgNc6Skdyl(__typeref (char))))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 17 : 5;
                  continue;
                }
                goto case 16;
              case 7:
                goto label_11;
              case 8:
                // ISSUE: type reference
                if (ExpressionCompiler.EmittingVisitor.fXH2wl8v53gf6fwkZ1cA(type, ExpressionCompiler.EmittingVisitor.U4TPVi8vg9UgNc6Skdyl(__typeref (uint))))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 22 : 2;
                  continue;
                }
                goto case 9;
              case 9:
                if (!(type == typeof (short)))
                {
                  num2 = 23;
                  continue;
                }
                goto case 16;
              case 10:
                ((ILGenerator) il).Emit(OpCodes.Ldc_R4, 0.0f);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 4 : 5;
                continue;
              case 11:
                ExpressionCompiler.EmittingVisitor.pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Conv_I8);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 13 : 20;
                continue;
              case 12:
                ExpressionCompiler.EmittingVisitor.knkv2X8vYB8jrNg6F4Ng(il, OpCodes.Ldc_R8, 0.0);
                num2 = 4;
                continue;
              case 13:
                // ISSUE: type reference
                if (ExpressionCompiler.EmittingVisitor.fXH2wl8v53gf6fwkZ1cA(type, ExpressionCompiler.EmittingVisitor.U4TPVi8vg9UgNc6Skdyl(__typeref (long))))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 21 : 19;
                  continue;
                }
                goto case 24;
              case 14:
                goto label_20;
              case 15:
                // ISSUE: type reference
                if (!ExpressionCompiler.EmittingVisitor.fXH2wl8v53gf6fwkZ1cA(type, ExpressionCompiler.EmittingVisitor.U4TPVi8vg9UgNc6Skdyl(__typeref (byte))))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 1 : 6;
                  continue;
                }
                goto case 16;
              case 16:
              case 18:
              case 22:
                ExpressionCompiler.EmittingVisitor.pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Ldc_I4_0);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 6 : 14;
                continue;
              case 17:
                if (ExpressionCompiler.EmittingVisitor.fXH2wl8v53gf6fwkZ1cA(type, typeof (sbyte)))
                {
                  num2 = 18;
                  continue;
                }
                goto case 1;
              case 19:
                goto label_34;
              case 20:
                goto label_23;
              case 23:
                // ISSUE: type reference
                if (!ExpressionCompiler.EmittingVisitor.fXH2wl8v53gf6fwkZ1cA(type, ExpressionCompiler.EmittingVisitor.U4TPVi8vg9UgNc6Skdyl(__typeref (ushort))))
                {
                  num2 = 13;
                  continue;
                }
                goto case 16;
              case 24:
                if (ExpressionCompiler.EmittingVisitor.fXH2wl8v53gf6fwkZ1cA(type, typeof (ulong)))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 0 : 0;
                  continue;
                }
                if (!ExpressionCompiler.EmittingVisitor.fXH2wl8v53gf6fwkZ1cA(type, typeof (float)))
                {
                  // ISSUE: type reference
                  if (!ExpressionCompiler.EmittingVisitor.fXH2wl8v53gf6fwkZ1cA(type, ExpressionCompiler.EmittingVisitor.U4TPVi8vg9UgNc6Skdyl(__typeref (double))))
                  {
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 25 : 20;
                    continue;
                  }
                  goto case 12;
                }
                else
                  goto label_33;
              case 25:
                ExpressionCompiler.EmittingVisitor.EmitLoadLocalVariable(il, ExpressionCompiler.EmittingVisitor.iZFBo28vLdpJZ0EgaTu9(il, type));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 7;
                continue;
              case 26:
                ((ILGenerator) il).Emit(OpCodes.Ldnull);
                num2 = 19;
                continue;
              default:
                goto label_27;
            }
          }
label_27:
          ExpressionCompiler.EmittingVisitor.pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Ldc_I4_0);
          num1 = 11;
          continue;
label_33:
          num1 = 10;
        }
label_3:
        return;
label_31:
        return;
label_11:
        return;
label_20:
        return;
label_34:
        return;
label_23:;
      }

      private static bool TryEmitTryCatchFinallyBlock(
        object tryExpr,
        IReadOnlyList<ParameterExpression> paramExprs,
        object il,
        ref ExpressionCompiler.ClosureInfo closure,
        ExpressionCompiler.ParentFlags parent)
      {
        bool flag1 = closure.TryCatchFinallyContainsReturnGotoExpression();
        ((ILGenerator) il).BeginExceptionBlock();
        if (!ExpressionCompiler.EmittingVisitor.TryEmit((object) ((TryExpression) tryExpr).Body, paramExprs, il, ref closure, parent))
          return false;
        Type type = ((Expression) tryExpr).Type;
        bool flag2 = type != typeof (void) && (flag1 || !parent.IgnoresResult());
        int location = -1;
        if (flag2)
          ExpressionCompiler.EmittingVisitor.EmitStoreLocalVariable(il, location = ((ILGenerator) il).GetNextLocalVarIndex(type));
        ReadOnlyCollection<CatchBlock> handlers = ((TryExpression) tryExpr).Handlers;
        for (int index = 0; index < handlers.Count; ++index)
        {
          CatchBlock catchBlock = handlers[index];
          if (catchBlock.Filter != null)
            return false;
          ((ILGenerator) il).BeginCatchBlock(catchBlock.Test);
          ParameterExpression variable = catchBlock.Variable;
          if (variable != null)
          {
            int nextLocalVarIndex = ((ILGenerator) il).GetNextLocalVarIndex(variable.Type);
            closure.PushBlockWithVars(variable, nextLocalVarIndex);
            ExpressionCompiler.EmittingVisitor.EmitStoreLocalVariable(il, nextLocalVarIndex);
          }
          if (!ExpressionCompiler.EmittingVisitor.TryEmit((object) catchBlock.Body, paramExprs, il, ref closure, parent))
            return false;
          if (variable != null)
            closure.PopBlock();
          if (flag2)
            ExpressionCompiler.EmittingVisitor.EmitStoreLocalVariable(il, location);
        }
        Expression expr = ((TryExpression) tryExpr).Finally;
        if (expr != null)
        {
          ((ILGenerator) il).BeginFinallyBlock();
          if (!ExpressionCompiler.EmittingVisitor.TryEmit((object) expr, paramExprs, il, ref closure, parent))
            return false;
        }
        ((ILGenerator) il).EndExceptionBlock();
        if (flag2)
          ExpressionCompiler.EmittingVisitor.EmitLoadLocalVariable(il, location);
        --closure.CurrentTryCatchFinallyIndex;
        return true;
      }

      private static bool TryEmitParameter(
        object paramExpr,
        IReadOnlyList<ParameterExpression> paramExprs,
        object il,
        ref ExpressionCompiler.ClosureInfo closure,
        ExpressionCompiler.ParentFlags parent,
        int byRefIndex = -1)
      {
        Type type = ((Expression) paramExpr).Type;
        bool isByRef = ((ParameterExpression) paramExpr).IsByRef;
        int index = paramExprs.Count - 1;
        while (index != -1 && paramExprs[index] != paramExpr)
          --index;
        if (index != -1)
        {
          bool flag = byRefIndex != -1;
          closure.LastEmitIsAddress = !isByRef & flag || !isByRef && type.IsValueType() && ((parent & ExpressionCompiler.ParentFlags.InstanceCall) == ExpressionCompiler.ParentFlags.InstanceCall || (parent & ExpressionCompiler.ParentFlags.MemberAccess) != 0);
          if ((closure.Status & ExpressionCompiler.ClosureStatus.ShouldBeStaticMethod) == (ExpressionCompiler.ClosureStatus) 0)
            ++index;
          if (closure.LastEmitIsAddress)
          {
            ((ILGenerator) il).Emit(OpCodes.Ldarga_S, (byte) index);
          }
          else
          {
            switch (index)
            {
              case 0:
                ((ILGenerator) il).Emit(OpCodes.Ldarg_0);
                break;
              case 1:
                ((ILGenerator) il).Emit(OpCodes.Ldarg_1);
                break;
              case 2:
                ((ILGenerator) il).Emit(OpCodes.Ldarg_2);
                break;
              case 3:
                ((ILGenerator) il).Emit(OpCodes.Ldarg_3);
                break;
              default:
                ((ILGenerator) il).Emit(OpCodes.Ldarg_S, (byte) index);
                break;
            }
          }
          if (isByRef)
          {
            if (type.IsValueType())
            {
              if ((parent & ExpressionCompiler.ParentFlags.Call) != ExpressionCompiler.ParentFlags.Empty && !flag || (parent & ExpressionCompiler.ParentFlags.Arithmetic) != ExpressionCompiler.ParentFlags.Empty)
                ExpressionCompiler.EmittingVisitor.EmitValueTypeDereference(il, type);
            }
            else if ((parent & ExpressionCompiler.ParentFlags.Call) != ExpressionCompiler.ParentFlags.Empty && !flag || (parent & (ExpressionCompiler.ParentFlags.MemberAccess | ExpressionCompiler.ParentFlags.Coalesce)) != ExpressionCompiler.ParentFlags.Empty)
              ((ILGenerator) il).Emit(OpCodes.Ldind_Ref);
          }
          return true;
        }
        int localVarOrDefault = closure.GetDefinedLocalVarOrDefault((ParameterExpression) paramExpr);
        if (localVarOrDefault != -1)
        {
          if (byRefIndex != -1 || type.IsValueType() && (parent & (ExpressionCompiler.ParentFlags.MemberAccess | ExpressionCompiler.ParentFlags.InstanceAccess)) != ExpressionCompiler.ParentFlags.Empty)
            ExpressionCompiler.EmittingVisitor.EmitLoadLocalVariableAddress(il, localVarOrDefault);
          else
            ExpressionCompiler.EmittingVisitor.EmitLoadLocalVariable(il, localVarOrDefault);
          return true;
        }
        if (isByRef)
        {
          ExpressionCompiler.EmittingVisitor.EmitLoadLocalVariableAddress(il, byRefIndex);
          return true;
        }
        ParameterExpression[] passedParameters = closure.NonPassedParameters;
        int i = passedParameters.Length - 1;
        while (i != -1 && passedParameters[i] != paramExpr)
          --i;
        if (i == -1)
          return false;
        ((ILGenerator) il).Emit(OpCodes.Ldarg_0);
        ((ILGenerator) il).Emit(OpCodes.Ldfld, ExpressionCompiler.ArrayClosureWithNonPassedParamsField);
        ExpressionCompiler.EmittingVisitor.EmitLoadConstantInt(il, i);
        ((ILGenerator) il).Emit(OpCodes.Ldelem_Ref);
        if (type.IsValueType())
          ((ILGenerator) il).Emit(OpCodes.Unbox_Any, type);
        return true;
      }

      private static void EmitValueTypeDereference(object il, Type type)
      {
        int num1 = 4;
        while (true)
        {
          int num2 = num1;
          while (true)
          {
            switch (num2)
            {
              case 0:
                goto label_11;
              case 1:
                // ISSUE: type reference
                if (!ExpressionCompiler.EmittingVisitor.fXH2wl8v53gf6fwkZ1cA(type, ExpressionCompiler.EmittingVisitor.U4TPVi8vg9UgNc6Skdyl(__typeref (sbyte))))
                {
                  num2 = 29;
                  continue;
                }
                goto label_38;
              case 2:
                ExpressionCompiler.EmittingVisitor.pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Ldind_I2);
                num2 = 27;
                continue;
              case 3:
                // ISSUE: type reference
                if (!ExpressionCompiler.EmittingVisitor.fXH2wl8v53gf6fwkZ1cA(type, ExpressionCompiler.EmittingVisitor.U4TPVi8vg9UgNc6Skdyl(__typeref (long))))
                {
                  // ISSUE: type reference
                  if (!ExpressionCompiler.EmittingVisitor.fXH2wl8v53gf6fwkZ1cA(type, ExpressionCompiler.EmittingVisitor.U4TPVi8vg9UgNc6Skdyl(__typeref (short))))
                  {
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 1 : 0;
                    continue;
                  }
                  goto case 2;
                }
                else
                  goto label_19;
              case 4:
                // ISSUE: type reference
                if (!ExpressionCompiler.EmittingVisitor.fXH2wl8v53gf6fwkZ1cA(type, ExpressionCompiler.EmittingVisitor.U4TPVi8vg9UgNc6Skdyl(__typeref (int))))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 1 : 3;
                  continue;
                }
                goto case 5;
              case 5:
                ExpressionCompiler.EmittingVisitor.pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Ldind_I4);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 13 : 0;
                continue;
              case 6:
                ExpressionCompiler.EmittingVisitor.pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Ldind_U1);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 20 : 20;
                continue;
              case 7:
                goto label_38;
              case 8:
                ExpressionCompiler.EmittingVisitor.pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Ldind_I8);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 0 : 0;
                continue;
              case 9:
                goto label_3;
              case 10:
                goto label_22;
              case 11:
                goto label_5;
              case 12:
                goto label_8;
              case 13:
                goto label_14;
              case 14:
                ExpressionCompiler.EmittingVisitor.pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Ldind_I);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 5 : 11;
                continue;
              case 15:
                goto label_17;
              case 16:
                goto label_46;
              case 17:
                // ISSUE: type reference
                if (ExpressionCompiler.EmittingVisitor.fXH2wl8v53gf6fwkZ1cA(type, ExpressionCompiler.EmittingVisitor.U4TPVi8vg9UgNc6Skdyl(__typeref (byte))))
                {
                  num2 = 6;
                  continue;
                }
                if (!(type == typeof (ushort)))
                {
                  // ISSUE: type reference
                  if (!ExpressionCompiler.EmittingVisitor.fXH2wl8v53gf6fwkZ1cA(type, ExpressionCompiler.EmittingVisitor.U4TPVi8vg9UgNc6Skdyl(__typeref (uint))))
                  {
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 18 : 2;
                    continue;
                  }
                  goto case 26;
                }
                else
                {
                  num2 = 28;
                  continue;
                }
              case 18:
                ExpressionCompiler.EmittingVisitor.J2osBm8vUaIa3b3WwLmF(il, OpCodes.Ldobj, type);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 10 : 16;
                continue;
              case 19:
                if (ExpressionCompiler.EmittingVisitor.fXH2wl8v53gf6fwkZ1cA(type, typeof (double)))
                {
                  num2 = 25;
                  continue;
                }
                if (!ExpressionCompiler.EmittingVisitor.fXH2wl8v53gf6fwkZ1cA(type, typeof (IntPtr)))
                {
                  num2 = 22;
                  continue;
                }
                goto label_20;
              case 20:
                goto label_39;
              case 21:
                ExpressionCompiler.EmittingVisitor.pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Ldind_R4);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 11 : 15;
                continue;
              case 22:
                // ISSUE: type reference
                if (!ExpressionCompiler.EmittingVisitor.fXH2wl8v53gf6fwkZ1cA(type, ExpressionCompiler.EmittingVisitor.U4TPVi8vg9UgNc6Skdyl(__typeref (UIntPtr))))
                {
                  num2 = 17;
                  continue;
                }
                goto case 14;
              case 23:
                goto label_20;
              case 24:
                goto label_43;
              case 25:
                ExpressionCompiler.EmittingVisitor.pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Ldind_R8);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 13 : 24;
                continue;
              case 26:
                ((ILGenerator) il).Emit(OpCodes.Ldind_U4);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 7 : 10;
                continue;
              case 27:
                goto label_26;
              case 28:
                ExpressionCompiler.EmittingVisitor.pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Ldind_U2);
                num2 = 9;
                continue;
              case 29:
                // ISSUE: type reference
                if (!(type == ExpressionCompiler.EmittingVisitor.U4TPVi8vg9UgNc6Skdyl(__typeref (float))))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 8 : 19;
                  continue;
                }
                goto case 21;
              case 30:
                goto label_29;
              default:
                goto label_42;
            }
          }
label_19:
          num1 = 8;
          continue;
label_20:
          ExpressionCompiler.EmittingVisitor.pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Ldind_I);
          num1 = 12;
          continue;
label_38:
          ExpressionCompiler.EmittingVisitor.pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Ldind_I1);
          num1 = 30;
        }
label_11:
        return;
label_3:
        return;
label_22:
        return;
label_5:
        return;
label_8:
        return;
label_14:
        return;
label_17:
        return;
label_46:
        return;
label_39:
        return;
label_43:
        return;
label_26:
        return;
label_29:
        return;
label_42:;
      }

      private static bool TryEmitSimpleUnaryExpression(
        object expr,
        IReadOnlyList<ParameterExpression> paramExprs,
        object il,
        ref ExpressionCompiler.ClosureInfo closure,
        ExpressionCompiler.ParentFlags parent)
      {
        Type type = ((Expression) expr).Type;
        if (type == typeof (Decimal) || !ExpressionCompiler.EmittingVisitor.TryEmit((object) ((UnaryExpression) expr).Operand, paramExprs, il, ref closure, parent))
          return false;
        if ((parent & ExpressionCompiler.ParentFlags.IgnoreResult) != ExpressionCompiler.ParentFlags.Empty)
          ((ILGenerator) il).Emit(OpCodes.Pop);
        else if (((Expression) expr).NodeType == ExpressionType.TypeAs)
          ((ILGenerator) il).Emit(OpCodes.Isinst, type);
        else if (((Expression) expr).NodeType == ExpressionType.IsFalse)
        {
          Label label1 = ((ILGenerator) il).DefineLabel();
          Label label2 = ((ILGenerator) il).DefineLabel();
          ((ILGenerator) il).Emit(OpCodes.Brfalse, label1);
          ((ILGenerator) il).Emit(OpCodes.Ldc_I4_0);
          ((ILGenerator) il).Emit(OpCodes.Br, label2);
          ((ILGenerator) il).MarkLabel(label1);
          ((ILGenerator) il).Emit(OpCodes.Ldc_I4_1);
          ((ILGenerator) il).MarkLabel(label2);
        }
        else if (((Expression) expr).NodeType == ExpressionType.Increment)
        {
          if (!ExpressionCompiler.EmittingVisitor.TryEmitNumberOne(il, type))
            return false;
          ((ILGenerator) il).Emit(OpCodes.Add);
        }
        else if (((Expression) expr).NodeType == ExpressionType.Decrement)
        {
          if (!ExpressionCompiler.EmittingVisitor.TryEmitNumberOne(il, type))
            return false;
          ((ILGenerator) il).Emit(OpCodes.Sub);
        }
        else if (((Expression) expr).NodeType == ExpressionType.Negate || ((Expression) expr).NodeType == ExpressionType.NegateChecked)
          ((ILGenerator) il).Emit(OpCodes.Neg);
        else if (((Expression) expr).NodeType == ExpressionType.OnesComplement)
          ((ILGenerator) il).Emit(OpCodes.Not);
        else if (((Expression) expr).NodeType == ExpressionType.Unbox)
          ((ILGenerator) il).Emit(OpCodes.Unbox_Any, type);
        else if (((Expression) expr).NodeType != ExpressionType.IsTrue)
        {
          int nodeType = (int) ((Expression) expr).NodeType;
        }
        return true;
      }

      private static bool TryEmitTypeIs(
        object expr,
        IReadOnlyList<ParameterExpression> paramExprs,
        object il,
        ref ExpressionCompiler.ClosureInfo closure,
        ExpressionCompiler.ParentFlags parent)
      {
        if (!ExpressionCompiler.EmittingVisitor.TryEmit((object) ((TypeBinaryExpression) expr).Expression, paramExprs, il, ref closure, parent))
          return false;
        if ((parent & ExpressionCompiler.ParentFlags.IgnoreResult) != ExpressionCompiler.ParentFlags.Empty)
        {
          ((ILGenerator) il).Emit(OpCodes.Pop);
        }
        else
        {
          ((ILGenerator) il).Emit(OpCodes.Isinst, ((TypeBinaryExpression) expr).TypeOperand);
          ((ILGenerator) il).Emit(OpCodes.Ldnull);
          ((ILGenerator) il).Emit(OpCodes.Cgt_Un);
        }
        return true;
      }

      private static bool TryEmitNot(
        object expr,
        IReadOnlyList<ParameterExpression> paramExprs,
        object il,
        ref ExpressionCompiler.ClosureInfo closure,
        ExpressionCompiler.ParentFlags parent)
      {
        if (!ExpressionCompiler.EmittingVisitor.TryEmit((object) ((UnaryExpression) expr).Operand, paramExprs, il, ref closure, parent))
          return false;
        if ((parent & ExpressionCompiler.ParentFlags.IgnoreResult) > ExpressionCompiler.ParentFlags.Empty)
          ((ILGenerator) il).Emit(OpCodes.Pop);
        else if (((Expression) expr).Type == typeof (bool))
        {
          ((ILGenerator) il).Emit(OpCodes.Ldc_I4_0);
          ((ILGenerator) il).Emit(OpCodes.Ceq);
        }
        else
          ((ILGenerator) il).Emit(OpCodes.Not);
        return true;
      }

      private static bool TryEmitConvert(
        object expr,
        IReadOnlyList<ParameterExpression> paramExprs,
        object il,
        ref ExpressionCompiler.ClosureInfo closure,
        ExpressionCompiler.ParentFlags parent)
      {
        Expression operand = ((UnaryExpression) expr).Operand;
        MethodInfo method = ((UnaryExpression) expr).Method;
        if (method != (MethodInfo) null && method.Name != z2jc63fLkugS1X8Q9N.tE1kD1vbB(1253244298 - 1829393894 ^ -575832876) && method.Name != z2jc63fLkugS1X8Q9N.tE1kD1vbB(1051802738 - -1831968059 ^ -1410923993))
        {
          if (!ExpressionCompiler.EmittingVisitor.TryEmit((object) operand, paramExprs, il, ref closure, parent & ~ExpressionCompiler.ParentFlags.IgnoreResult | ExpressionCompiler.ParentFlags.InstanceCall))
            return false;
          ((ILGenerator) il).Emit(method.IsVirtual ? OpCodes.Callvirt : OpCodes.Call, method);
          if ((parent & ExpressionCompiler.ParentFlags.IgnoreResult) != ExpressionCompiler.ParentFlags.Empty && method.ReturnType != typeof (void))
            ((ILGenerator) il).Emit(OpCodes.Pop);
          return true;
        }
        Type type1 = operand.Type;
        bool flag1 = type1.IsNullable();
        Type underlyingType1 = Nullable.GetUnderlyingType(type1);
        Type type2 = ((Expression) expr).Type;
        if (flag1 && type2 == underlyingType1)
        {
          if (!ExpressionCompiler.EmittingVisitor.TryEmit((object) operand, paramExprs, il, ref closure, parent & ~ExpressionCompiler.ParentFlags.IgnoreResult | ExpressionCompiler.ParentFlags.InstanceAccess))
            return false;
          if (!closure.LastEmitIsAddress)
            ExpressionCompiler.EmittingVisitor.EmitStoreLocalVariableAndLoadItsAddress(il, type1);
          ((ILGenerator) il).Emit(OpCodes.Call, type1.FindValueGetterMethod());
          if ((parent & ExpressionCompiler.ParentFlags.IgnoreResult) != ExpressionCompiler.ParentFlags.Empty)
            ((ILGenerator) il).Emit(OpCodes.Pop);
          return true;
        }
        if (!ExpressionCompiler.EmittingVisitor.TryEmit((object) operand, paramExprs, il, ref closure, parent & ~ExpressionCompiler.ParentFlags.IgnoreResult & ~ExpressionCompiler.ParentFlags.InstanceAccess))
          return false;
        bool flag2 = type2.IsNullable();
        Type underlyingType2 = Nullable.GetUnderlyingType(type2);
        if (flag2 && type1 == underlyingType2)
        {
          ((ILGenerator) il).Emit(OpCodes.Newobj, IntrospectionExtensions.GetTypeInfo(type2).DeclaredConstructors.GetFirst<ConstructorInfo>());
          return true;
        }
        if (type1 == type2 || type2 == typeof (object))
        {
          if (type2 == typeof (object) && type1.IsValueType())
            ((ILGenerator) il).Emit(OpCodes.Box, type1);
          if (parent.IgnoresResult())
            ((ILGenerator) il).Emit(OpCodes.Pop);
          return true;
        }
        if (!flag1 && !type1.IsPrimitive())
        {
          Type targetType = flag2 ? underlyingType2 : type2;
          MethodInfo methodInfo = method;
          if ((object) methodInfo == null)
            methodInfo = type1.FindConvertOperator(type1, targetType);
          MethodInfo meth = methodInfo;
          if (meth != (MethodInfo) null)
          {
            ((ILGenerator) il).Emit(OpCodes.Call, meth);
            if (flag2)
              ((ILGenerator) il).Emit(OpCodes.Newobj, IntrospectionExtensions.GetTypeInfo(type2).DeclaredConstructors.GetFirst<ConstructorInfo>());
            if ((parent & ExpressionCompiler.ParentFlags.IgnoreResult) != ExpressionCompiler.ParentFlags.Empty)
              ((ILGenerator) il).Emit(OpCodes.Pop);
            return true;
          }
        }
        else if (!flag2)
        {
          Type type3 = flag1 ? underlyingType1 : type1;
          MethodInfo methodInfo = method;
          if ((object) methodInfo == null)
            methodInfo = type3.FindConvertOperator(type3, type2);
          MethodInfo meth = methodInfo;
          if (meth != (MethodInfo) null)
          {
            if (flag1)
            {
              ExpressionCompiler.EmittingVisitor.EmitStoreLocalVariableAndLoadItsAddress(il, type1);
              ((ILGenerator) il).Emit(OpCodes.Call, type1.FindValueGetterMethod());
            }
            ((ILGenerator) il).Emit(OpCodes.Call, meth);
            if ((parent & ExpressionCompiler.ParentFlags.IgnoreResult) != ExpressionCompiler.ParentFlags.Empty)
              ((ILGenerator) il).Emit(OpCodes.Pop);
            return true;
          }
        }
        if (!flag2 && !type2.IsPrimitive())
        {
          Type sourceType = flag1 ? underlyingType1 : type1;
          MethodInfo methodInfo = method;
          if ((object) methodInfo == null)
            methodInfo = type2.FindConvertOperator(sourceType, type2);
          MethodInfo meth = methodInfo;
          if (meth != (MethodInfo) null)
          {
            if (flag1)
            {
              ExpressionCompiler.EmittingVisitor.EmitStoreLocalVariableAndLoadItsAddress(il, type1);
              ((ILGenerator) il).Emit(OpCodes.Call, type1.FindValueGetterMethod());
            }
            ((ILGenerator) il).Emit(OpCodes.Call, meth);
            if ((parent & ExpressionCompiler.ParentFlags.IgnoreResult) != ExpressionCompiler.ParentFlags.Empty)
              ((ILGenerator) il).Emit(OpCodes.Pop);
            return true;
          }
        }
        else if (!flag1)
        {
          Type type4 = flag2 ? underlyingType2 : type2;
          MethodInfo methodInfo = method;
          if ((object) methodInfo == null)
            methodInfo = type4.FindConvertOperator(type1, type4);
          MethodInfo meth = methodInfo;
          if (meth != (MethodInfo) null)
          {
            ((ILGenerator) il).Emit(OpCodes.Call, meth);
            if (flag2)
              ((ILGenerator) il).Emit(OpCodes.Newobj, IntrospectionExtensions.GetTypeInfo(type2).DeclaredConstructors.GetFirst<ConstructorInfo>());
            if ((parent & ExpressionCompiler.ParentFlags.IgnoreResult) != ExpressionCompiler.ParentFlags.Empty)
              ((ILGenerator) il).Emit(OpCodes.Pop);
            return true;
          }
        }
        if (type1 == typeof (object) && type2.IsValueType())
          ((ILGenerator) il).Emit(OpCodes.Unbox_Any, type2);
        else if (flag2)
        {
          if (!flag1)
          {
            if (!ExpressionCompiler.EmittingVisitor.TryEmitValueConvert(underlyingType2, il, false))
              return false;
            ((ILGenerator) il).Emit(OpCodes.Newobj, IntrospectionExtensions.GetTypeInfo(type2).DeclaredConstructors.GetFirst<ConstructorInfo>());
          }
          else
          {
            int location = ExpressionCompiler.EmittingVisitor.EmitStoreLocalVariableAndLoadItsAddress(il, type1);
            ((ILGenerator) il).Emit(OpCodes.Call, type1.FindNullableHasValueGetterMethod());
            Label label1 = ((ILGenerator) il).DefineLabel();
            ((ILGenerator) il).Emit(OpCodes.Brtrue_S, label1);
            ExpressionCompiler.EmittingVisitor.EmitLoadLocalVariable(il, ExpressionCompiler.EmittingVisitor.InitValueTypeVariable(il, type2));
            Label label2 = ((ILGenerator) il).DefineLabel();
            ((ILGenerator) il).Emit(OpCodes.Br_S, label2);
            ((ILGenerator) il).MarkLabel(label1);
            ExpressionCompiler.EmittingVisitor.EmitLoadLocalVariableAddress(il, location);
            ((ILGenerator) il).Emit(OpCodes.Call, type1.FindNullableGetValueOrDefaultMethod());
            if (!ExpressionCompiler.EmittingVisitor.TryEmitValueConvert(underlyingType2, il, ((Expression) expr).NodeType == ExpressionType.ConvertChecked))
            {
              MethodInfo methodInfo = method;
              if ((object) methodInfo == null)
                methodInfo = underlyingType2.FindConvertOperator(underlyingType1, underlyingType2);
              MethodInfo meth = methodInfo;
              if (meth == (MethodInfo) null)
                return false;
              ((ILGenerator) il).Emit(OpCodes.Call, meth);
            }
            ((ILGenerator) il).Emit(OpCodes.Newobj, IntrospectionExtensions.GetTypeInfo(type2).DeclaredConstructors.GetFirst<ConstructorInfo>());
            ((ILGenerator) il).MarkLabel(label2);
          }
        }
        else
        {
          if (IntrospectionExtensions.GetTypeInfo(type2).IsEnum)
            type2 = Enum.GetUnderlyingType(type2);
          if (flag1)
          {
            ExpressionCompiler.EmittingVisitor.EmitStoreLocalVariableAndLoadItsAddress(il, type1);
            ((ILGenerator) il).Emit(OpCodes.Call, type1.FindValueGetterMethod());
          }
          if (!ExpressionCompiler.EmittingVisitor.TryEmitValueConvert(type2, il, ((Expression) expr).NodeType == ExpressionType.ConvertChecked))
            ((ILGenerator) il).Emit(OpCodes.Castclass, type2);
        }
        if ((parent & ExpressionCompiler.ParentFlags.IgnoreResult) != ExpressionCompiler.ParentFlags.Empty)
          ((ILGenerator) il).Emit(OpCodes.Pop);
        return true;
      }

      private static bool TryEmitValueConvert(Type targetType, object il, bool isChecked)
      {
        int num1 = 8;
        while (true)
        {
          int num2 = num1;
          while (true)
          {
            switch (num2)
            {
              case 1:
                ExpressionCompiler.EmittingVisitor.pO5qbK8vj7kF4Bx0nVcJ(il, isChecked ? OpCodes.Conv_Ovf_I1 : OpCodes.Conv_I1);
                num2 = 20;
                continue;
              case 2:
                ExpressionCompiler.EmittingVisitor.pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Conv_R8);
                num2 = 18;
                continue;
              case 5:
                goto label_11;
              case 6:
                // ISSUE: type reference
                if (targetType == ExpressionCompiler.EmittingVisitor.U4TPVi8vg9UgNc6Skdyl(__typeref (ulong)))
                {
                  num2 = 14;
                  continue;
                }
                goto case 23;
              case 7:
                ExpressionCompiler.EmittingVisitor.pO5qbK8vj7kF4Bx0nVcJ(il, isChecked ? OpCodes.Conv_Ovf_I4 : OpCodes.Conv_I4);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 10 : 34;
                continue;
              case 8:
                // ISSUE: type reference
                if (ExpressionCompiler.EmittingVisitor.fXH2wl8v53gf6fwkZ1cA(targetType, ExpressionCompiler.EmittingVisitor.U4TPVi8vg9UgNc6Skdyl(__typeref (int))))
                {
                  num2 = 7;
                  continue;
                }
                goto case 22;
              case 9:
              case 25:
                // ISSUE: type reference
                if (ExpressionCompiler.EmittingVisitor.fXH2wl8v53gf6fwkZ1cA(targetType, ExpressionCompiler.EmittingVisitor.U4TPVi8vg9UgNc6Skdyl(__typeref (long))))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 29 : 3;
                  continue;
                }
                goto case 6;
              case 11:
                ((ILGenerator) il).Emit(isChecked ? OpCodes.Conv_Ovf_I2 : OpCodes.Conv_I2);
                num2 = 4;
                continue;
              case 12:
              case 16:
                if (!ExpressionCompiler.EmittingVisitor.fXH2wl8v53gf6fwkZ1cA(targetType, typeof (byte)))
                {
                  num2 = 30;
                  continue;
                }
                goto case 26;
              case 13:
                // ISSUE: type reference
                if (!ExpressionCompiler.EmittingVisitor.fXH2wl8v53gf6fwkZ1cA(targetType, ExpressionCompiler.EmittingVisitor.U4TPVi8vg9UgNc6Skdyl(__typeref (ushort))))
                {
                  num2 = 27;
                  continue;
                }
                goto case 28;
              case 14:
                ((ILGenerator) il).Emit(isChecked ? OpCodes.Conv_Ovf_U8 : OpCodes.Conv_U8);
                num2 = 32;
                continue;
              case 15:
                ExpressionCompiler.EmittingVisitor.pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Conv_R4);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 2 : 3;
                continue;
              case 17:
                ExpressionCompiler.EmittingVisitor.pO5qbK8vj7kF4Bx0nVcJ(il, isChecked ? OpCodes.Conv_Ovf_U4 : OpCodes.Conv_U4);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 33 : 22;
                continue;
              case 19:
                // ISSUE: type reference
                if (ExpressionCompiler.EmittingVisitor.fXH2wl8v53gf6fwkZ1cA(targetType, ExpressionCompiler.EmittingVisitor.U4TPVi8vg9UgNc6Skdyl(__typeref (sbyte))))
                  goto case 1;
                else
                  goto label_21;
              case 21:
              case 30:
                // ISSUE: type reference
                if (!ExpressionCompiler.EmittingVisitor.fXH2wl8v53gf6fwkZ1cA(targetType, ExpressionCompiler.EmittingVisitor.U4TPVi8vg9UgNc6Skdyl(__typeref (short))))
                  goto case 13;
                else
                  goto label_14;
              case 22:
                // ISSUE: type reference
                if (!ExpressionCompiler.EmittingVisitor.fXH2wl8v53gf6fwkZ1cA(targetType, ExpressionCompiler.EmittingVisitor.U4TPVi8vg9UgNc6Skdyl(__typeref (float))))
                  goto case 24;
                else
                  goto label_23;
              case 23:
                if (targetType == typeof (double))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 2 : 0;
                  continue;
                }
                goto label_11;
              case 24:
                if (ExpressionCompiler.EmittingVisitor.fXH2wl8v53gf6fwkZ1cA(targetType, typeof (uint)))
                {
                  num2 = 17;
                  continue;
                }
                goto case 19;
              case 26:
                ExpressionCompiler.EmittingVisitor.pO5qbK8vj7kF4Bx0nVcJ(il, !isChecked ? OpCodes.Conv_U1 : OpCodes.Conv_Ovf_U1);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 0 : 0;
                continue;
              case 27:
                // ISSUE: type reference
                if (!(targetType == ExpressionCompiler.EmittingVisitor.U4TPVi8vg9UgNc6Skdyl(__typeref (char))))
                {
                  num2 = 25;
                  continue;
                }
                goto case 28;
              case 28:
                ExpressionCompiler.EmittingVisitor.pO5qbK8vj7kF4Bx0nVcJ(il, !isChecked ? OpCodes.Conv_U2 : OpCodes.Conv_Ovf_U2);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 1 : 10;
                continue;
              case 29:
                ExpressionCompiler.EmittingVisitor.pO5qbK8vj7kF4Bx0nVcJ(il, !isChecked ? OpCodes.Conv_I8 : OpCodes.Conv_Ovf_I8);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 31 : 17;
                continue;
              default:
                goto label_12;
            }
          }
label_14:
          num1 = 11;
          continue;
label_21:
          num1 = 12;
          continue;
label_23:
          num1 = 15;
        }
label_11:
        return false;
label_12:
        return true;
      }

      private static bool TryEmitNotNullConstant(
        bool considerClosure,
        Type exprType,
        object constantValue,
        object il,
        ref ExpressionCompiler.ClosureInfo closure)
      {
        int num1 = 18;
        while (true)
        {
          int num2 = num1;
          int i;
          int location;
          object[] items;
          Type type1;
          while (true)
          {
            switch (num2)
            {
              case 1:
                ExpressionCompiler.EmittingVisitor.cr9PXh88BxyHDixSqTcC(il, OpCodes.Call, ExpressionCompiler.EmittingVisitor._getTypeFromHandleMethod);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 3;
                continue;
              case 2:
              case 6:
              case 8:
                if (ExpressionCompiler.EmittingVisitor.aiU5Py88bf4bvp4KvZlA(ExpressionCompiler.EmittingVisitor.Y3ZBnF88oFL48nB4EbDT(exprType), (Type) null))
                {
                  num2 = 9;
                  continue;
                }
                goto case 15;
              case 3:
                goto label_37;
              case 4:
                i = closure.Constants.Count - 1;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 29 : 15;
                continue;
              case 5:
              case 16:
              case 22:
                switch (constantValue)
                {
                  case string str:
                    num2 = 39;
                    continue;
                  case Type type2:
                    goto label_7;
                  default:
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 19 : 5;
                    continue;
                }
              case 7:
                ExpressionCompiler.EmittingVisitor.sAHEtL8vcqrjhyn5Thl8(il, location);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 4 : 8;
                continue;
              case 9:
                ExpressionCompiler.EmittingVisitor.EeScqP88h5wEXIWJQdtf(il, OpCodes.Newobj, (object) ((TypeInfo) ExpressionCompiler.EmittingVisitor.GNKm9i8vrhrfeYTW9WQI(exprType)).DeclaredConstructors.GetFirst<ConstructorInfo>());
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 23 : 13;
                continue;
              case 10:
                ExpressionCompiler.EmittingVisitor.pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Ldelem_Ref);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 25 : 5;
                continue;
              case 11:
label_7:
                ExpressionCompiler.EmittingVisitor.J2osBm8vUaIa3b3WwLmF(il, OpCodes.Ldtoken, type2);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 1 : 0;
                continue;
              case 12:
                if (!ExpressionCompiler.EmittingVisitor.FmvXlm8vsuRxLNJZHiE0(constantValue, (object) IntrospectionExtensions.GetTypeInfo(type1)))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 21 : 22;
                  continue;
                }
                goto case 33;
              case 13:
                if (ExpressionCompiler.EmittingVisitor.PjFnO38vzkxjGZ63tFdS(type1))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 21 : 18;
                  continue;
                }
                goto label_26;
              case 14:
                type1 = Enum.GetUnderlyingType(type1);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 35;
                continue;
              case 15:
                // ISSUE: type reference
                if (ExpressionCompiler.EmittingVisitor.fXH2wl8v53gf6fwkZ1cA(exprType, ExpressionCompiler.EmittingVisitor.U4TPVi8vg9UgNc6Skdyl(__typeref (object))))
                {
                  num2 = 13;
                  continue;
                }
                goto label_26;
              case 17:
                if (!considerClosure)
                {
                  num2 = 5;
                  continue;
                }
                goto case 12;
              case 18:
                type1 = constantValue.GetType();
                num2 = 17;
                continue;
              case 19:
                if (((Type) ExpressionCompiler.EmittingVisitor.GNKm9i8vrhrfeYTW9WQI(type1)).IsEnum)
                {
                  num2 = 14;
                  continue;
                }
                goto case 35;
              case 20:
              case 26:
                ExpressionCompiler.EmittingVisitor.pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Ldloc_0);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 2 : 38;
                continue;
              case 21:
                ExpressionCompiler.EmittingVisitor.J2osBm8vUaIa3b3WwLmF(il, OpCodes.Box, constantValue.GetType());
                num2 = 31;
                continue;
              case 23:
              case 31:
                goto label_26;
              case 24:
                goto label_34;
              case 25:
                if (!ExpressionCompiler.EmittingVisitor.PjFnO38vzkxjGZ63tFdS(exprType))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 0 : 6;
                  continue;
                }
                goto label_34;
              case 27:
                if (i == -1)
                {
                  num2 = 30;
                  continue;
                }
                location = closure.ConstantUsage.Items[i] - 1;
                num2 = 36;
                continue;
              case 28:
              case 29:
                if (i != -1)
                {
                  num2 = 37;
                  continue;
                }
                goto case 27;
              case 30:
                goto label_8;
              case 32:
                goto label_19;
              case 33:
                items = closure.Constants.Items;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 2 : 4;
                continue;
              case 34:
                --i;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 4 : 28;
                continue;
              case 35:
                if (!ExpressionCompiler.EmittingVisitor.fokGig88WnZPreE4vi54(il, constantValue, type1))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 32 : 19;
                  continue;
                }
                goto case 2;
              case 36:
                if (location <= 0)
                {
                  num2 = 26;
                  continue;
                }
                goto case 7;
              case 37:
                if (items[i] == constantValue)
                {
                  num2 = 27;
                  continue;
                }
                goto case 34;
              case 38:
                ExpressionCompiler.EmittingVisitor.EmitLoadConstantInt(il, i);
                num2 = 10;
                continue;
              case 39:
                ExpressionCompiler.EmittingVisitor.UviTP688Flh13scInDsp(il, OpCodes.Ldstr, (object) str);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 0;
                continue;
              default:
                goto label_43;
            }
          }
label_34:
          ExpressionCompiler.EmittingVisitor.J2osBm8vUaIa3b3WwLmF(il, OpCodes.Unbox_Any, exprType);
          num1 = 2;
        }
label_8:
        return false;
label_19:
        return false;
label_26:
        return true;
label_37:
        return true;
label_43:
        return true;
      }

      private static bool TryEmitNumberConstant(
        object il,
        object constantValue,
        Type constValueType)
      {
        int num1 = 45;
        while (true)
        {
          int num2 = num1;
          while (true)
          {
            switch (num2)
            {
              case 1:
              case 31:
                // ISSUE: type reference
                if (ExpressionCompiler.EmittingVisitor.fXH2wl8v53gf6fwkZ1cA(constValueType, ExpressionCompiler.EmittingVisitor.U4TPVi8vg9UgNc6Skdyl(__typeref (UIntPtr))))
                {
                  num2 = 30;
                  continue;
                }
                goto case 22;
              case 2:
              case 37:
                // ISSUE: type reference
                if (!ExpressionCompiler.EmittingVisitor.fXH2wl8v53gf6fwkZ1cA(constValueType, ExpressionCompiler.EmittingVisitor.U4TPVi8vg9UgNc6Skdyl(__typeref (ushort))))
                {
                  num2 = 26;
                  continue;
                }
                goto case 9;
              case 3:
              case 5:
              case 6:
              case 8:
              case 11:
              case 14:
              case 17:
              case 18:
              case 19:
              case 25:
              case 29:
              case 40:
              case 41:
              case 42:
              case 48:
                goto label_45;
              case 4:
                if (!ExpressionCompiler.EmittingVisitor.fXH2wl8v53gf6fwkZ1cA(constValueType, typeof (bool)))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 5 : 21;
                  continue;
                }
                goto case 7;
              case 7:
                ((ILGenerator) il).Emit(!(bool) constantValue ? OpCodes.Ldc_I4_0 : OpCodes.Ldc_I4_1);
                num2 = 8;
                continue;
              case 9:
                ExpressionCompiler.EmittingVisitor.xSvlU588GkZCQcYNHxR9(il, (int) (ushort) constantValue);
                num2 = 40;
                continue;
              case 10:
              case 26:
                // ISSUE: type reference
                if (!ExpressionCompiler.EmittingVisitor.fXH2wl8v53gf6fwkZ1cA(constValueType, ExpressionCompiler.EmittingVisitor.U4TPVi8vg9UgNc6Skdyl(__typeref (sbyte))))
                  goto case 36;
                else
                  goto label_34;
              case 12:
                ExpressionCompiler.EmittingVisitor.xSvlU588GkZCQcYNHxR9(il, (int) (char) constantValue);
                num2 = 48;
                continue;
              case 13:
                ExpressionCompiler.EmittingVisitor.xSvlU588GkZCQcYNHxR9(il, (int) (uint) constantValue);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 17 : 19;
                continue;
              case 15:
                ExpressionCompiler.EmittingVisitor.knkv2X8vYB8jrNg6F4Ng(il, OpCodes.Ldc_R8, (double) constantValue);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 39 : 41;
                continue;
              case 16:
              case 46:
                // ISSUE: type reference
                if (!ExpressionCompiler.EmittingVisitor.fXH2wl8v53gf6fwkZ1cA(constValueType, ExpressionCompiler.EmittingVisitor.U4TPVi8vg9UgNc6Skdyl(__typeref (byte))))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 2 : 1;
                  continue;
                }
                break;
              case 20:
                goto label_44;
              case 21:
              case 23:
                // ISSUE: type reference
                if (!ExpressionCompiler.EmittingVisitor.fXH2wl8v53gf6fwkZ1cA(constValueType, ExpressionCompiler.EmittingVisitor.U4TPVi8vg9UgNc6Skdyl(__typeref (IntPtr))))
                {
                  num2 = 31;
                  continue;
                }
                goto case 38;
              case 22:
                // ISSUE: type reference
                if (ExpressionCompiler.EmittingVisitor.fXH2wl8v53gf6fwkZ1cA(constValueType, ExpressionCompiler.EmittingVisitor.U4TPVi8vg9UgNc6Skdyl(__typeref (Decimal))))
                {
                  num2 = 34;
                  continue;
                }
                goto label_44;
              case 24:
                goto label_6;
              case 27:
                if (ExpressionCompiler.EmittingVisitor.fXH2wl8v53gf6fwkZ1cA(constValueType, typeof (char)))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 9 : 12;
                  continue;
                }
                goto case 50;
              case 28:
                // ISSUE: type reference
                if (!(constValueType == ExpressionCompiler.EmittingVisitor.U4TPVi8vg9UgNc6Skdyl(__typeref (long))))
                {
                  num2 = 51;
                  continue;
                }
                goto case 39;
              case 30:
                ExpressionCompiler.EmittingVisitor.cM3sss88EePhWUr2IKkE(il, OpCodes.Ldc_I8, (long) ((UIntPtr) constantValue).ToUInt64());
                num2 = 5;
                continue;
              case 32:
              case 51:
                // ISSUE: type reference
                if (ExpressionCompiler.EmittingVisitor.fXH2wl8v53gf6fwkZ1cA(constValueType, ExpressionCompiler.EmittingVisitor.U4TPVi8vg9UgNc6Skdyl(__typeref (ulong))))
                {
                  num2 = 35;
                  continue;
                }
                goto case 43;
              case 33:
                ((ILGenerator) il).Emit(OpCodes.Ldc_R4, (float) constantValue);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 11 : 8;
                continue;
              case 34:
                ExpressionCompiler.EmittingVisitor.W7pcad88fNEKh1EdX85b((Decimal) constantValue, il);
                num2 = 14;
                continue;
              case 35:
                ExpressionCompiler.EmittingVisitor.cM3sss88EePhWUr2IKkE(il, OpCodes.Ldc_I8, (long) (ulong) constantValue);
                num2 = 3;
                continue;
              case 36:
                // ISSUE: type reference
                if (constValueType == ExpressionCompiler.EmittingVisitor.U4TPVi8vg9UgNc6Skdyl(__typeref (uint)))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 13 : 3;
                  continue;
                }
                goto case 28;
              case 38:
                ExpressionCompiler.EmittingVisitor.cM3sss88EePhWUr2IKkE(il, OpCodes.Ldc_I8, ((IntPtr) constantValue).ToInt64());
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 6 : 3;
                continue;
              case 39:
                ExpressionCompiler.EmittingVisitor.cM3sss88EePhWUr2IKkE(il, OpCodes.Ldc_I8, (long) constantValue);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 24 : 29;
                continue;
              case 43:
                // ISSUE: type reference
                if (ExpressionCompiler.EmittingVisitor.fXH2wl8v53gf6fwkZ1cA(constValueType, ExpressionCompiler.EmittingVisitor.U4TPVi8vg9UgNc6Skdyl(__typeref (float))))
                {
                  num2 = 33;
                  continue;
                }
                goto case 49;
              case 44:
                ExpressionCompiler.EmittingVisitor.xSvlU588GkZCQcYNHxR9(il, (int) constantValue);
                num2 = 18;
                continue;
              case 45:
                // ISSUE: type reference
                if (ExpressionCompiler.EmittingVisitor.fXH2wl8v53gf6fwkZ1cA(constValueType, ExpressionCompiler.EmittingVisitor.U4TPVi8vg9UgNc6Skdyl(__typeref (int))))
                {
                  num2 = 44;
                  continue;
                }
                goto case 27;
              case 47:
                ExpressionCompiler.EmittingVisitor.xSvlU588GkZCQcYNHxR9(il, (int) (short) constantValue);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 8 : 17;
                continue;
              case 49:
                // ISSUE: type reference
                if (ExpressionCompiler.EmittingVisitor.fXH2wl8v53gf6fwkZ1cA(constValueType, ExpressionCompiler.EmittingVisitor.U4TPVi8vg9UgNc6Skdyl(__typeref (double))))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 2 : 15;
                  continue;
                }
                goto case 4;
              case 50:
                // ISSUE: type reference
                if (!(constValueType == ExpressionCompiler.EmittingVisitor.U4TPVi8vg9UgNc6Skdyl(__typeref (short))))
                {
                  num2 = 46;
                  continue;
                }
                goto case 47;
            }
            ExpressionCompiler.EmittingVisitor.xSvlU588GkZCQcYNHxR9(il, (int) (byte) constantValue);
            num2 = 25;
          }
label_6:
          ExpressionCompiler.EmittingVisitor.EmitLoadConstantInt(il, (int) (sbyte) constantValue);
          num1 = 42;
          continue;
label_34:
          num1 = 24;
        }
label_44:
        return false;
label_45:
        return true;
      }

      internal static bool TryEmitNumberOne(object il, Type type)
      {
        int num1 = 14;
        while (true)
        {
          int num2 = num1;
          while (true)
          {
            switch (num2)
            {
              case 1:
                if (!ExpressionCompiler.EmittingVisitor.fXH2wl8v53gf6fwkZ1cA(type, typeof (short)))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 29 : 11;
                  continue;
                }
                goto case 13;
              case 2:
                // ISSUE: type reference
                if (!(type == ExpressionCompiler.EmittingVisitor.U4TPVi8vg9UgNc6Skdyl(__typeref (sbyte))))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 24 : 7;
                  continue;
                }
                goto case 13;
              case 3:
              case 12:
                goto label_16;
              case 4:
                // ISSUE: type reference
                if (ExpressionCompiler.EmittingVisitor.fXH2wl8v53gf6fwkZ1cA(type, ExpressionCompiler.EmittingVisitor.U4TPVi8vg9UgNc6Skdyl(__typeref (ulong))))
                {
                  num2 = 10;
                  continue;
                }
                goto case 18;
              case 5:
                // ISSUE: type reference
                if (!ExpressionCompiler.EmittingVisitor.fXH2wl8v53gf6fwkZ1cA(type, ExpressionCompiler.EmittingVisitor.U4TPVi8vg9UgNc6Skdyl(__typeref (char))))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 1 : 1;
                  continue;
                }
                goto case 13;
              case 6:
              case 9:
                // ISSUE: type reference
                if (ExpressionCompiler.EmittingVisitor.fXH2wl8v53gf6fwkZ1cA(type, ExpressionCompiler.EmittingVisitor.U4TPVi8vg9UgNc6Skdyl(__typeref (double))))
                  goto case 27;
                else
                  goto label_6;
              case 7:
              case 16:
              case 21:
              case 23:
                goto label_17;
              case 10:
              case 20:
              case 25:
                goto label_11;
              case 11:
                // ISSUE: type reference
                if (!ExpressionCompiler.EmittingVisitor.fXH2wl8v53gf6fwkZ1cA(type, ExpressionCompiler.EmittingVisitor.U4TPVi8vg9UgNc6Skdyl(__typeref (float))))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 6 : 0;
                  continue;
                }
                goto label_10;
              case 13:
              case 15:
              case 22:
              case 28:
                ExpressionCompiler.EmittingVisitor.pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Ldc_I4_1);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 7 : 2;
                continue;
              case 14:
                // ISSUE: type reference
                if (ExpressionCompiler.EmittingVisitor.fXH2wl8v53gf6fwkZ1cA(type, ExpressionCompiler.EmittingVisitor.U4TPVi8vg9UgNc6Skdyl(__typeref (int))))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 10 : 13;
                  continue;
                }
                goto case 5;
              case 17:
                goto label_10;
              case 18:
                // ISSUE: type reference
                if (!(type == ExpressionCompiler.EmittingVisitor.U4TPVi8vg9UgNc6Skdyl(__typeref (IntPtr))))
                {
                  num2 = 26;
                  continue;
                }
                goto label_11;
              case 19:
                // ISSUE: type reference
                if (type == ExpressionCompiler.EmittingVisitor.U4TPVi8vg9UgNc6Skdyl(__typeref (ushort)))
                {
                  num2 = 22;
                  continue;
                }
                goto case 2;
              case 24:
                // ISSUE: type reference
                if (!ExpressionCompiler.EmittingVisitor.fXH2wl8v53gf6fwkZ1cA(type, ExpressionCompiler.EmittingVisitor.U4TPVi8vg9UgNc6Skdyl(__typeref (uint))))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 0 : 0;
                  continue;
                }
                goto case 13;
              case 26:
                // ISSUE: type reference
                if (ExpressionCompiler.EmittingVisitor.fXH2wl8v53gf6fwkZ1cA(type, ExpressionCompiler.EmittingVisitor.U4TPVi8vg9UgNc6Skdyl(__typeref (UIntPtr))))
                {
                  num2 = 25;
                  continue;
                }
                goto case 11;
              case 27:
                ExpressionCompiler.EmittingVisitor.knkv2X8vYB8jrNg6F4Ng(il, OpCodes.Ldc_R8, 1.0);
                num2 = 23;
                continue;
              case 29:
                // ISSUE: type reference
                if (ExpressionCompiler.EmittingVisitor.fXH2wl8v53gf6fwkZ1cA(type, ExpressionCompiler.EmittingVisitor.U4TPVi8vg9UgNc6Skdyl(__typeref (byte))))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 19 : 28;
                  continue;
                }
                goto case 19;
              default:
                // ISSUE: type reference
                if (ExpressionCompiler.EmittingVisitor.fXH2wl8v53gf6fwkZ1cA(type, ExpressionCompiler.EmittingVisitor.U4TPVi8vg9UgNc6Skdyl(__typeref (long))))
                {
                  num2 = 20;
                  continue;
                }
                goto case 4;
            }
          }
label_6:
          num1 = 3;
          continue;
label_10:
          ExpressionCompiler.EmittingVisitor.wCQlP088QNaoX0PDRj9h(il, OpCodes.Ldc_R4, 1f);
          num1 = 21;
          continue;
label_11:
          ExpressionCompiler.EmittingVisitor.cM3sss88EePhWUr2IKkE(il, OpCodes.Ldc_I8, 1L);
          num1 = 16;
        }
label_16:
        return false;
label_17:
        return true;
      }

      internal static void EmitLoadConstantsAndNestedLambdasIntoVars(
        object il,
        ref ExpressionCompiler.ClosureInfo closure)
      {
        int num1 = 16;
        while (true)
        {
          int num2 = num1;
          int i;
          ExpressionCompiler.NestedLambdaInfo nestedLambdaInfo;
          int location;
          int count;
          int index;
          int[] items1;
          Type type;
          ExpressionCompiler.NestedLambdaInfo[] nestedLambdas;
          object[] items2;
          while (true)
          {
            switch (num2)
            {
              case 1:
                ++index;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 4 : 13;
                continue;
              case 2:
                items2 = closure.Constants.Items;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 19 : 14;
                continue;
              case 3:
                ((ILGenerator) il).Emit(OpCodes.Ldloc_0);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 5 : 21;
                continue;
              case 4:
                if (nestedLambdaInfo.UsageCountOrVarIndex > 1)
                {
                  num2 = 12;
                  continue;
                }
                goto case 1;
              case 5:
              case 35:
                location = ((ILGenerator) il).GetNextLocalVarIndex(type);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 18 : 13;
                continue;
              case 6:
              case 23:
                if (i >= count)
                {
                  num2 = 25;
                  continue;
                }
                goto case 31;
              case 7:
                i = 0;
                num2 = 6;
                continue;
              case 8:
                index = 0;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 12 : 34;
                continue;
              case 9:
                type = items2[i].GetType();
                num2 = 27;
                continue;
              case 10:
                ExpressionCompiler.EmittingVisitor.xSvlU588GkZCQcYNHxR9(il, count + index);
                num2 = 14;
                continue;
              case 11:
              case 26:
                ++i;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 23 : 23;
                continue;
              case 12:
                ExpressionCompiler.EmittingVisitor.pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Ldloc_0);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 10 : 4;
                continue;
              case 13:
              case 34:
                if (index >= nestedLambdas.Length)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 33 : 19;
                  continue;
                }
                goto case 29;
              case 14:
                ((ILGenerator) il).Emit(OpCodes.Ldelem_Ref);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 17 : 14;
                continue;
              case 15:
                ExpressionCompiler.EmittingVisitor.sRdP0O88C2XPgBIGfmr9(il, OpCodes.Ldfld, (object) ExpressionCompiler.ArrayClosureArrayField);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 17 : 20;
                continue;
              case 16:
                ((ILGenerator) il).Emit(OpCodes.Ldarg_0);
                num2 = 15;
                continue;
              case 17:
                location = ExpressionCompiler.EmittingVisitor.biffFd88v5EVI03AcKVJ(il, nestedLambdaInfo.Lambda.GetType());
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 0;
                continue;
              case 18:
                items1[i] = location + 1;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 24 : 1;
                continue;
              case 19:
                count = closure.Constants.Count;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 12 : 32;
                continue;
              case 20:
                ExpressionCompiler.EmittingVisitor.EmitStoreLocalVariable(il, ExpressionCompiler.EmittingVisitor.biffFd88v5EVI03AcKVJ(il, typeof (object[])));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 1 : 2;
                continue;
              case 21:
                ExpressionCompiler.EmittingVisitor.xSvlU588GkZCQcYNHxR9(il, i);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 10 : 28;
                continue;
              case 22:
                ExpressionCompiler.EmittingVisitor.n5iKim888ZeKefyA2HBg(il, location);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 1 : 1;
                continue;
              case 24:
                ExpressionCompiler.EmittingVisitor.EmitStoreLocalVariable(il, location);
                num2 = 26;
                continue;
              case 25:
                nestedLambdas = closure.NestedLambdas;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 8 : 8;
                continue;
              case 27:
                if (ExpressionCompiler.EmittingVisitor.PjFnO38vzkxjGZ63tFdS(type))
                  goto case 30;
                else
                  goto label_24;
              case 28:
                ExpressionCompiler.EmittingVisitor.pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Ldelem_Ref);
                num2 = 9;
                continue;
              case 29:
                nestedLambdaInfo = nestedLambdas[index];
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 4 : 0;
                continue;
              case 30:
                ExpressionCompiler.EmittingVisitor.J2osBm8vUaIa3b3WwLmF(il, OpCodes.Unbox_Any, type);
                num2 = 35;
                continue;
              case 31:
                if (items1[i] <= 1)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 9 : 11;
                  continue;
                }
                goto case 3;
              case 32:
                items1 = closure.ConstantUsage.Items;
                num2 = 7;
                continue;
              case 33:
                goto label_20;
              default:
                goto label_4;
            }
          }
label_4:
          nestedLambdaInfo.UsageCountOrVarIndex = location + 1;
          num1 = 22;
          continue;
label_24:
          num1 = 5;
        }
label_20:;
      }

      private static void EmitDecimalConstant(Decimal value, object il)
      {
        int num1 = 21;
        while (true)
        {
          int num2 = num1;
          int[] bits;
          while (true)
          {
            byte i;
            bool flag;
            switch (num2)
            {
              case 1:
                goto label_31;
              case 2:
                goto label_26;
              case 3:
                // ISSUE: type reference
                // ISSUE: type reference
                ExpressionCompiler.EmittingVisitor.EeScqP88h5wEXIWJQdtf(il, OpCodes.Newobj, ExpressionCompiler.EmittingVisitor.w6M2Rh88SoDltf7X7pW3(ExpressionCompiler.EmittingVisitor.U4TPVi8vg9UgNc6Skdyl(__typeref (Decimal)), ExpressionCompiler.EmittingVisitor.U4TPVi8vg9UgNc6Skdyl(__typeref (int))));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 25 : 25;
                continue;
              case 4:
                ExpressionCompiler.EmittingVisitor.cM3sss88EePhWUr2IKkE(il, OpCodes.Ldc_I8, ExpressionCompiler.EmittingVisitor.oVcLfh88iS6O3DRXOoA1(value));
                num2 = 23;
                continue;
              case 5:
                flag = ((ulong) bits[3] & 2147483648UL) > 0UL;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 6 : 14;
                continue;
              case 6:
                ExpressionCompiler.EmittingVisitor.xSvlU588GkZCQcYNHxR9(il, ExpressionCompiler.EmittingVisitor.BQ35wh88VnygI3LvNAkj(value));
                num2 = 3;
                continue;
              case 7:
                ExpressionCompiler.EmittingVisitor.xSvlU588GkZCQcYNHxR9(il, bits[1]);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 1;
                continue;
              case 8:
                goto label_27;
              case 9:
                goto label_25;
              case 10:
                goto label_30;
              case 11:
                goto label_18;
              case 12:
                ExpressionCompiler.EmittingVisitor.sRdP0O88C2XPgBIGfmr9(il, OpCodes.Ldsfld, ExpressionCompiler.EmittingVisitor.m3LAa488ReLmpwmaDB7T(ExpressionCompiler.EmittingVisitor.GNKm9i8vrhrfeYTW9WQI(typeof (Decimal)), ExpressionCompiler.EmittingVisitor.Fn0VLG88qZFRYO4uCytV(694673736 ^ -23604109 ^ -671859883)));
                num2 = 11;
                continue;
              case 13:
                goto label_22;
              case 14:
                i = (byte) (bits[3] >> 16 & (int) sbyte.MaxValue);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 2 : 2;
                continue;
              case 15:
                if (value >= -9223372036854775808M)
                {
                  num2 = 16;
                  continue;
                }
                break;
              case 16:
                if (value <= 9223372036854775807M)
                {
                  num2 = 4;
                  continue;
                }
                break;
              case 17:
                if (value <= 2147483647M)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 0 : 6;
                  continue;
                }
                goto case 15;
              case 18:
                ExpressionCompiler.EmittingVisitor.pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Conv_U1);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 7 : 10;
                continue;
              case 19:
                ExpressionCompiler.EmittingVisitor.pO5qbK8vj7kF4Bx0nVcJ(il, flag ? OpCodes.Ldc_I4_1 : OpCodes.Ldc_I4_0);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 0 : 0;
                continue;
              case 20:
                if (!ExpressionCompiler.EmittingVisitor.fqmiM488Il8d7HP1lXaU(value, -2147483648M))
                {
                  num2 = 15;
                  continue;
                }
                goto case 17;
              case 21:
                if (ExpressionCompiler.EmittingVisitor.e7eD7j88uPJ67KFlpEWt(ExpressionCompiler.EmittingVisitor.xafoql88ZtB6XHGZK6dR(value, 1M), 0M))
                {
                  num2 = 20;
                  continue;
                }
                break;
              case 22:
                if (!ExpressionCompiler.EmittingVisitor.e7eD7j88uPJ67KFlpEWt(value, Decimal.MaxValue))
                {
                  bits = Decimal.GetBits(value);
                  num2 = 5;
                  continue;
                }
                num2 = 12;
                continue;
              case 23:
                // ISSUE: type reference
                // ISSUE: type reference
                ExpressionCompiler.EmittingVisitor.EeScqP88h5wEXIWJQdtf(il, OpCodes.Newobj, ExpressionCompiler.EmittingVisitor.w6M2Rh88SoDltf7X7pW3(ExpressionCompiler.EmittingVisitor.U4TPVi8vg9UgNc6Skdyl(__typeref (Decimal)), ExpressionCompiler.EmittingVisitor.U4TPVi8vg9UgNc6Skdyl(__typeref (long))));
                num2 = 9;
                continue;
              case 24:
label_12:
                // ISSUE: type reference
                ((ILGenerator) il).Emit(OpCodes.Ldsfld, (FieldInfo) ExpressionCompiler.EmittingVisitor.m3LAa488ReLmpwmaDB7T(ExpressionCompiler.EmittingVisitor.GNKm9i8vrhrfeYTW9WQI(ExpressionCompiler.EmittingVisitor.U4TPVi8vg9UgNc6Skdyl(__typeref (Decimal))), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(964881585 - -1459193222 ^ -1871152019)));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 13 : 5;
                continue;
              case 25:
                goto label_7;
              default:
                ExpressionCompiler.EmittingVisitor.xSvlU588GkZCQcYNHxR9(il, (int) i);
                num2 = 18;
                continue;
            }
            if (!ExpressionCompiler.EmittingVisitor.e7eD7j88uPJ67KFlpEWt(value, Decimal.MinValue))
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 19 : 22;
            else
              goto label_12;
          }
label_26:
          ExpressionCompiler.EmittingVisitor.EmitLoadConstantInt(il, bits[0]);
          num1 = 7;
          continue;
label_30:
          ((ILGenerator) il).Emit(OpCodes.Newobj, ExpressionCompiler.EmittingVisitor._decimalCtor.Value);
          num1 = 8;
          continue;
label_31:
          ExpressionCompiler.EmittingVisitor.xSvlU588GkZCQcYNHxR9(il, bits[2]);
          num1 = 19;
        }
label_27:
        return;
label_25:
        return;
label_18:
        return;
label_22:
        return;
label_7:;
      }

      private static int InitValueTypeVariable(object il, Type exprType)
      {
        int num = 2;
        int nextLocalVarIndex;
        while (true)
        {
          switch (num)
          {
            case 1:
              ExpressionCompiler.EmittingVisitor.zd5dF088K7mOoR6NMGKO(il, nextLocalVarIndex);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 0 : 0;
              continue;
            case 2:
              nextLocalVarIndex = ((ILGenerator) il).GetNextLocalVarIndex(exprType);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 0 : 1;
              continue;
            case 3:
              goto label_4;
            default:
              ((ILGenerator) il).Emit(OpCodes.Initobj, exprType);
              num = 3;
              continue;
          }
        }
label_4:
        return nextLocalVarIndex;
      }

      private static bool EmitNewArray(
        object expr,
        IReadOnlyList<ParameterExpression> paramExprs,
        object il,
        ref ExpressionCompiler.ClosureInfo closure,
        ExpressionCompiler.ParentFlags parent)
      {
        Type type = ((Expression) expr).Type;
        ReadOnlyCollection<Expression> expressions = ((NewArrayExpression) expr).Expressions;
        Type elementType = type.GetElementType();
        if (elementType == (Type) null)
          return false;
        if (type.GetArrayRank() == 1)
        {
          ExpressionCompiler.EmittingVisitor.EmitLoadConstantInt(il, expressions.Count);
          ((ILGenerator) il).Emit(OpCodes.Newarr, elementType);
          bool flag = elementType.IsValueType();
          int num = 0;
          for (int count = expressions.Count; num < count; ++num)
          {
            ((ILGenerator) il).Emit(OpCodes.Dup);
            ExpressionCompiler.EmittingVisitor.EmitLoadConstantInt(il, num);
            if (flag)
              ((ILGenerator) il).Emit(OpCodes.Ldelema, elementType);
            if (!ExpressionCompiler.EmittingVisitor.TryEmit((object) expressions[num], paramExprs, il, ref closure, parent))
              return false;
            if (flag)
              ((ILGenerator) il).Emit(OpCodes.Stobj, elementType);
            else
              ((ILGenerator) il).Emit(OpCodes.Stelem_Ref);
          }
          return true;
        }
        for (int index = 0; index < expressions.Count; ++index)
        {
          if (!ExpressionCompiler.EmittingVisitor.TryEmit((object) expressions[index], paramExprs, il, ref closure, parent, index))
            return false;
        }
        ((ILGenerator) il).Emit(OpCodes.Newobj, IntrospectionExtensions.GetTypeInfo(type).DeclaredConstructors.GetFirst<ConstructorInfo>());
        return true;
      }

      private static bool TryEmitArrayIndex(Type exprType, object il)
      {
        int num = 5;
        while (true)
        {
          switch (num)
          {
            case 1:
            case 4:
              ExpressionCompiler.EmittingVisitor.pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Ldelem_Ref);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 2 : 0;
              continue;
            case 3:
              ExpressionCompiler.EmittingVisitor.J2osBm8vUaIa3b3WwLmF(il, OpCodes.Ldelem, exprType);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 0;
              continue;
            case 5:
              if (!ExpressionCompiler.EmittingVisitor.PjFnO38vzkxjGZ63tFdS(exprType))
              {
                num = 4;
                continue;
              }
              goto case 3;
            default:
              goto label_5;
          }
        }
label_5:
        return true;
      }

      private static bool EmitMemberInit(
        object expr,
        IReadOnlyList<ParameterExpression> paramExprs,
        object il,
        ref ExpressionCompiler.ClosureInfo closure,
        ExpressionCompiler.ParentFlags parent)
      {
        int location = -1;
        if (((Expression) expr).Type.IsValueType())
          location = ((ILGenerator) il).GetNextLocalVarIndex(((Expression) expr).Type);
        NewExpression newExpression = ((MemberInitExpression) expr).NewExpression;
        ReadOnlyCollection<Expression> arguments = newExpression.Arguments;
        for (int index = 0; index < arguments.Count; ++index)
        {
          if (!ExpressionCompiler.EmittingVisitor.TryEmit((object) arguments[index], paramExprs, il, ref closure, parent, index))
            return false;
        }
        ConstructorInfo constructor = newExpression.Constructor;
        if (constructor != (ConstructorInfo) null)
        {
          ((ILGenerator) il).Emit(OpCodes.Newobj, constructor);
        }
        else
        {
          if (!newExpression.Type.IsValueType())
            return false;
          if (location == -1)
            location = ((ILGenerator) il).GetNextLocalVarIndex(((Expression) expr).Type);
          ExpressionCompiler.EmittingVisitor.EmitLoadLocalVariableAddress(il, location);
          ((ILGenerator) il).Emit(OpCodes.Initobj, newExpression.Type);
        }
        ReadOnlyCollection<MemberBinding> bindings = ((MemberInitExpression) expr).Bindings;
        for (int index = 0; index < bindings.Count; ++index)
        {
          MemberBinding memberBinding = bindings[index];
          if (memberBinding.BindingType != MemberBindingType.Assignment)
            return false;
          if (location != -1)
            ExpressionCompiler.EmittingVisitor.EmitLoadLocalVariableAddress(il, location);
          else
            ((ILGenerator) il).Emit(OpCodes.Dup);
          if (!ExpressionCompiler.EmittingVisitor.TryEmit((object) ((MemberAssignment) memberBinding).Expression, paramExprs, il, ref closure, parent) || !ExpressionCompiler.EmittingVisitor.EmitMemberAssign(il, (object) memberBinding.Member))
            return false;
        }
        if (location != -1)
          ExpressionCompiler.EmittingVisitor.EmitLoadLocalVariable(il, location);
        return true;
      }

      private static bool EmitMemberAssign(object il, object member)
      {
        int num = 7;
        MethodInfo methodInfo;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_12;
            case 2:
              if (methodInfo == (MethodInfo) null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 1 : 0;
                continue;
              }
              ExpressionCompiler.EmittingVisitor.cr9PXh88BxyHDixSqTcC(il, ExpressionCompiler.EmittingVisitor.wl8EMB88kTNmCG4OyVv6((object) methodInfo) ? OpCodes.Callvirt : OpCodes.Call, (object) methodInfo);
              num = 4;
              continue;
            case 3:
              methodInfo = (MethodInfo) ExpressionCompiler.EmittingVisitor.fBt6Va88T9YSt8ARF6Or(ExpressionCompiler.EmittingVisitor.Nc9dVJ88XPZkULo3u0Bi((object) propertyInfo), (object) propertyInfo.Name);
              num = 2;
              continue;
            case 4:
              goto label_4;
            case 5:
              ((ILGenerator) il).Emit(ExpressionCompiler.EmittingVisitor.deLCCA88neVcu5oRhSLo((object) field) ? OpCodes.Stsfld : OpCodes.Stfld, field);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 0;
              continue;
            case 6:
              if (member is FieldInfo field)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 4 : 5;
                continue;
              }
              goto label_11;
            case 7:
              if (!(member is PropertyInfo propertyInfo))
              {
                num = 6;
                continue;
              }
              goto case 3;
            default:
              goto label_10;
          }
        }
label_4:
        return true;
label_10:
        return true;
label_11:
        return false;
label_12:
        return false;
      }

      private static bool TryEmitIncDecAssign(
        object expr,
        IReadOnlyList<ParameterExpression> paramExprs,
        object il,
        ref ExpressionCompiler.ClosureInfo closure,
        ExpressionCompiler.ParentFlags parent)
      {
        Expression operand = ((UnaryExpression) expr).Operand;
        bool flag = false;
        int index = -1;
        bool isVar = operand.NodeType == ExpressionType.Parameter;
        bool usesResult = (parent & ExpressionCompiler.ParentFlags.IgnoreResult) == ExpressionCompiler.ParentFlags.Empty;
        int num;
        MemberExpression expr1;
        if (isVar)
        {
          num = closure.GetDefinedLocalVarOrDefault((ParameterExpression) operand);
          if (num != -1)
          {
            ExpressionCompiler.EmittingVisitor.EmitLoadLocalVariable(il, num);
            flag = true;
          }
          else
          {
            index = paramExprs.Count - 1;
            while (index != -1 && paramExprs[index] != operand)
              --index;
            if (index == -1)
              return false;
            ((ILGenerator) il).Emit(OpCodes.Ldarg, index + 1);
          }
          expr1 = (MemberExpression) null;
        }
        else
        {
          if (operand.NodeType != ExpressionType.MemberAccess)
            return false;
          expr1 = (MemberExpression) operand;
          if (!ExpressionCompiler.EmittingVisitor.TryEmitMemberAccess((object) expr1, paramExprs, il, ref closure, parent | ExpressionCompiler.ParentFlags.DupMemberOwner))
            return false;
          flag = expr1.Expression != null && (usesResult || expr1.Member is PropertyInfo);
          num = flag ? ((ILGenerator) il).GetNextLocalVarIndex(operand.Type) : -1;
        }
        switch (((Expression) expr).NodeType)
        {
          case ExpressionType.PreIncrementAssign:
            ((ILGenerator) il).Emit(OpCodes.Ldc_I4_1);
            ((ILGenerator) il).Emit(OpCodes.Add);
            ExpressionCompiler.EmittingVisitor.StoreIncDecValue(il, usesResult, isVar, num);
            break;
          case ExpressionType.PreDecrementAssign:
            ((ILGenerator) il).Emit(OpCodes.Ldc_I4_1);
            ((ILGenerator) il).Emit(OpCodes.Sub);
            ExpressionCompiler.EmittingVisitor.StoreIncDecValue(il, usesResult, isVar, num);
            break;
          case ExpressionType.PostIncrementAssign:
            ExpressionCompiler.EmittingVisitor.StoreIncDecValue(il, usesResult, isVar, num);
            ((ILGenerator) il).Emit(OpCodes.Ldc_I4_1);
            ((ILGenerator) il).Emit(OpCodes.Add);
            break;
          case ExpressionType.PostDecrementAssign:
            ExpressionCompiler.EmittingVisitor.StoreIncDecValue(il, usesResult, isVar, num);
            ((ILGenerator) il).Emit(OpCodes.Ldc_I4_1);
            ((ILGenerator) il).Emit(OpCodes.Sub);
            break;
        }
        if (isVar && index != -1)
          ((ILGenerator) il).Emit(OpCodes.Starg_S, index + 1);
        else if (isVar || flag && !usesResult)
          ExpressionCompiler.EmittingVisitor.EmitStoreLocalVariable(il, num);
        if (isVar)
          return true;
        if (flag && !usesResult)
          ExpressionCompiler.EmittingVisitor.EmitLoadLocalVariable(il, num);
        if (!ExpressionCompiler.EmittingVisitor.EmitMemberAssign(il, (object) expr1.Member))
          return false;
        if (flag & usesResult)
          ExpressionCompiler.EmittingVisitor.EmitLoadLocalVariable(il, num);
        return true;
      }

      private static void StoreIncDecValue(
        object il,
        bool usesResult,
        bool isVar,
        int localVarIndex)
      {
        int num1 = 8;
        while (true)
        {
          int num2 = num1;
          while (true)
          {
            switch (num2)
            {
              case 1:
                if (localVarIndex == -1)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 0 : 0;
                  continue;
                }
                ExpressionCompiler.EmittingVisitor.n5iKim888ZeKefyA2HBg(il, localVarIndex);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 3 : 5;
                continue;
              case 3:
                goto label_3;
              case 4:
                goto label_13;
              case 5:
                ExpressionCompiler.EmittingVisitor.sAHEtL8vcqrjhyn5Thl8(il, localVarIndex);
                num2 = 3;
                continue;
              case 6:
                goto label_10;
              case 7:
                if (!isVar)
                  goto case 1;
                else
                  goto label_5;
              case 8:
                if (usesResult)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 0 : 7;
                  continue;
                }
                goto label_9;
              default:
                ExpressionCompiler.EmittingVisitor.pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Dup);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 6 : 4;
                continue;
            }
          }
label_5:
          num1 = 2;
        }
label_3:
        return;
label_13:
        return;
label_10:
        return;
label_9:;
      }

      private static bool TryEmitAssign(
        object expr,
        IReadOnlyList<ParameterExpression> paramExprs,
        object il,
        ref ExpressionCompiler.ClosureInfo closure,
        ExpressionCompiler.ParentFlags parent)
      {
        Expression left = ((BinaryExpression) expr).Left;
        Expression right = ((BinaryExpression) expr).Right;
        ExpressionType nodeType1 = ((BinaryExpression) expr).Left.NodeType;
        ExpressionType nodeType2 = ((Expression) expr).NodeType;
        ExpressionCompiler.ParentFlags parent1 = parent & ~ExpressionCompiler.ParentFlags.IgnoreResult;
        switch (nodeType1)
        {
          case ExpressionType.MemberAccess:
            bool flag = right.NodeType == ExpressionType.Try;
            int location = -1;
            if (flag)
            {
              location = ((ILGenerator) il).GetNextLocalVarIndex(right.Type);
              if (!ExpressionCompiler.EmittingVisitor.TryEmit((object) right, paramExprs, il, ref closure, ExpressionCompiler.ParentFlags.Empty))
                return false;
              ExpressionCompiler.EmittingVisitor.EmitStoreLocalVariable(il, location);
            }
            MemberExpression memberExpression = (MemberExpression) left;
            Expression expression = memberExpression.Expression;
            if (expression != null && !ExpressionCompiler.EmittingVisitor.TryEmit((object) expression, paramExprs, il, ref closure, parent1 | ExpressionCompiler.ParentFlags.MemberAccess | ExpressionCompiler.ParentFlags.InstanceAccess))
              return false;
            if (flag)
              ExpressionCompiler.EmittingVisitor.EmitLoadLocalVariable(il, location);
            else if (!ExpressionCompiler.EmittingVisitor.TryEmit((object) right, paramExprs, il, ref closure, ExpressionCompiler.ParentFlags.Empty))
              return false;
            MemberInfo member = memberExpression.Member;
            if ((parent & ExpressionCompiler.ParentFlags.IgnoreResult) != ExpressionCompiler.ParentFlags.Empty)
              return ExpressionCompiler.EmittingVisitor.EmitMemberAssign(il, (object) member);
            ((ILGenerator) il).Emit(OpCodes.Dup);
            int nextLocalVarIndex1 = ((ILGenerator) il).GetNextLocalVarIndex(((Expression) expr).Type);
            ExpressionCompiler.EmittingVisitor.EmitStoreLocalVariable(il, nextLocalVarIndex1);
            if (!ExpressionCompiler.EmittingVisitor.EmitMemberAssign(il, (object) member))
              return false;
            ExpressionCompiler.EmittingVisitor.EmitLoadLocalVariable(il, nextLocalVarIndex1);
            return true;
          case ExpressionType.Parameter:
            ParameterExpression varParamExpr = (ParameterExpression) left;
            int index1 = paramExprs.Count - 1;
            while (index1 != -1 && paramExprs[index1] != varParamExpr)
              --index1;
            ExpressionType exprNodeType = nodeType2;
            switch (nodeType2)
            {
              case ExpressionType.AddAssign:
                exprNodeType = ExpressionType.Add;
                break;
              case ExpressionType.AndAssign:
                exprNodeType = ExpressionType.And;
                break;
              case ExpressionType.DivideAssign:
                exprNodeType = ExpressionType.Divide;
                break;
              case ExpressionType.ExclusiveOrAssign:
                exprNodeType = ExpressionType.ExclusiveOr;
                break;
              case ExpressionType.LeftShiftAssign:
                exprNodeType = ExpressionType.LeftShift;
                break;
              case ExpressionType.ModuloAssign:
                exprNodeType = ExpressionType.Modulo;
                break;
              case ExpressionType.MultiplyAssign:
                exprNodeType = ExpressionType.Multiply;
                break;
              case ExpressionType.OrAssign:
                exprNodeType = ExpressionType.Or;
                break;
              case ExpressionType.PowerAssign:
                exprNodeType = ExpressionType.Power;
                break;
              case ExpressionType.RightShiftAssign:
                exprNodeType = ExpressionType.RightShift;
                break;
              case ExpressionType.SubtractAssign:
                exprNodeType = ExpressionType.Subtract;
                break;
              case ExpressionType.AddAssignChecked:
                exprNodeType = ExpressionType.AddChecked;
                break;
              case ExpressionType.MultiplyAssignChecked:
                exprNodeType = ExpressionType.MultiplyChecked;
                break;
              case ExpressionType.SubtractAssignChecked:
                exprNodeType = ExpressionType.SubtractChecked;
                break;
            }
            if (index1 != -1)
            {
              if ((closure.Status & ExpressionCompiler.ClosureStatus.ShouldBeStaticMethod) == (ExpressionCompiler.ClosureStatus) 0)
                ++index1;
              if (varParamExpr.IsByRef)
              {
                switch (index1)
                {
                  case 0:
                    ((ILGenerator) il).Emit(OpCodes.Ldarg_0);
                    break;
                  case 1:
                    ((ILGenerator) il).Emit(OpCodes.Ldarg_1);
                    break;
                  case 2:
                    ((ILGenerator) il).Emit(OpCodes.Ldarg_2);
                    break;
                  case 3:
                    ((ILGenerator) il).Emit(OpCodes.Ldarg_3);
                    break;
                  default:
                    ((ILGenerator) il).Emit(OpCodes.Ldarg_S, (byte) index1);
                    break;
                }
              }
              if (exprNodeType == nodeType2)
              {
                if (!ExpressionCompiler.EmittingVisitor.TryEmit((object) right, paramExprs, il, ref closure, parent1))
                  return false;
              }
              else if (!ExpressionCompiler.EmittingVisitor.TryEmitArithmetic(expr, exprNodeType, paramExprs, il, ref closure, parent))
                return false;
              if ((parent & ExpressionCompiler.ParentFlags.IgnoreResult) == ExpressionCompiler.ParentFlags.Empty)
                ((ILGenerator) il).Emit(OpCodes.Dup);
              if (varParamExpr.IsByRef)
                ExpressionCompiler.EmittingVisitor.EmitByRefStore(il, varParamExpr.Type);
              else
                ((ILGenerator) il).Emit(OpCodes.Starg_S, index1);
              return true;
            }
            if (exprNodeType != nodeType2)
            {
              int localVarOrDefault = closure.GetDefinedLocalVarOrDefault(varParamExpr);
              if (localVarOrDefault != -1)
              {
                if (!ExpressionCompiler.EmittingVisitor.TryEmitArithmetic(expr, exprNodeType, paramExprs, il, ref closure, parent))
                  return false;
                ExpressionCompiler.EmittingVisitor.EmitStoreLocalVariable(il, localVarOrDefault);
                return true;
              }
            }
            int localVarOrDefault1 = closure.GetDefinedLocalVarOrDefault(varParamExpr);
            if (localVarOrDefault1 != -1)
            {
              if (!ExpressionCompiler.EmittingVisitor.TryEmit((object) right, paramExprs, il, ref closure, parent1))
                return false;
              if ((right is ParameterExpression parameterExpression ? (parameterExpression.IsByRef ? 1 : 0) : 0) != 0)
                ((ILGenerator) il).Emit(OpCodes.Ldind_I4);
              if ((parent & ExpressionCompiler.ParentFlags.IgnoreResult) == ExpressionCompiler.ParentFlags.Empty)
                ((ILGenerator) il).Emit(OpCodes.Dup);
              ExpressionCompiler.EmittingVisitor.EmitStoreLocalVariable(il, localVarOrDefault1);
              return true;
            }
            ParameterExpression[] passedParameters = closure.NonPassedParameters;
            int i = passedParameters.Length - 1;
            while (i != -1 && passedParameters[i] != varParamExpr)
              --i;
            if (i == -1)
              return false;
            ((ILGenerator) il).Emit(OpCodes.Ldarg_0);
            if ((parent & ExpressionCompiler.ParentFlags.IgnoreResult) == ExpressionCompiler.ParentFlags.Empty)
            {
              if (!ExpressionCompiler.EmittingVisitor.TryEmit((object) right, paramExprs, il, ref closure, parent1))
                return false;
              int nextLocalVarIndex2 = ((ILGenerator) il).GetNextLocalVarIndex(((Expression) expr).Type);
              ExpressionCompiler.EmittingVisitor.EmitStoreLocalVariable(il, nextLocalVarIndex2);
              ((ILGenerator) il).Emit(OpCodes.Ldfld, ExpressionCompiler.ArrayClosureWithNonPassedParamsField);
              ExpressionCompiler.EmittingVisitor.EmitLoadConstantInt(il, i);
              ExpressionCompiler.EmittingVisitor.EmitLoadLocalVariable(il, nextLocalVarIndex2);
              if (((Expression) expr).Type.IsValueType())
                ((ILGenerator) il).Emit(OpCodes.Box, ((Expression) expr).Type);
              ((ILGenerator) il).Emit(OpCodes.Stelem_Ref);
              ExpressionCompiler.EmittingVisitor.EmitLoadLocalVariable(il, nextLocalVarIndex2);
            }
            else
            {
              ((ILGenerator) il).Emit(OpCodes.Ldfld, ExpressionCompiler.ArrayClosureWithNonPassedParamsField);
              ExpressionCompiler.EmittingVisitor.EmitLoadConstantInt(il, i);
              if (!ExpressionCompiler.EmittingVisitor.TryEmit((object) right, paramExprs, il, ref closure, parent1))
                return false;
              if (((Expression) expr).Type.IsValueType())
                ((ILGenerator) il).Emit(OpCodes.Box, ((Expression) expr).Type);
              ((ILGenerator) il).Emit(OpCodes.Stelem_Ref);
            }
            return true;
          case ExpressionType.Index:
            IndexExpression indexExpr = (IndexExpression) left;
            Expression expr1 = indexExpr.Object;
            if (expr1 != null && !ExpressionCompiler.EmittingVisitor.TryEmit((object) expr1, paramExprs, il, ref closure, parent1))
              return false;
            ReadOnlyCollection<Expression> arguments = indexExpr.Arguments;
            for (int index2 = 0; index2 < arguments.Count; ++index2)
            {
              if (!ExpressionCompiler.EmittingVisitor.TryEmit((object) arguments[index2], paramExprs, il, ref closure, parent1, index2))
                return false;
            }
            if (!ExpressionCompiler.EmittingVisitor.TryEmit((object) right, paramExprs, il, ref closure, parent1))
              return false;
            if ((parent & ExpressionCompiler.ParentFlags.IgnoreResult) != ExpressionCompiler.ParentFlags.Empty)
              return ExpressionCompiler.EmittingVisitor.TryEmitIndexAssign((object) indexExpr, expr1?.Type, ((Expression) expr).Type, il);
            int nextLocalVarIndex3 = ((ILGenerator) il).GetNextLocalVarIndex(((Expression) expr).Type);
            ((ILGenerator) il).Emit(OpCodes.Dup);
            ExpressionCompiler.EmittingVisitor.EmitStoreLocalVariable(il, nextLocalVarIndex3);
            if (!ExpressionCompiler.EmittingVisitor.TryEmitIndexAssign((object) indexExpr, expr1?.Type, ((Expression) expr).Type, il))
              return false;
            ExpressionCompiler.EmittingVisitor.EmitLoadLocalVariable(il, nextLocalVarIndex3);
            return true;
          default:
            return false;
        }
      }

      private static void EmitByRefStore(object il, Type type)
      {
        int num1 = 17;
        while (true)
        {
          int num2 = num1;
          while (true)
          {
            switch (num2)
            {
              case 1:
                goto label_17;
              case 2:
                goto label_6;
              case 3:
                goto label_35;
              case 4:
                goto label_8;
              case 5:
                goto label_42;
              case 6:
                ExpressionCompiler.EmittingVisitor.pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Stind_I2);
                num2 = 2;
                continue;
              case 7:
                goto label_3;
              case 8:
                // ISSUE: type reference
                if (!ExpressionCompiler.EmittingVisitor.fXH2wl8v53gf6fwkZ1cA(type, ExpressionCompiler.EmittingVisitor.U4TPVi8vg9UgNc6Skdyl(__typeref (UIntPtr))))
                {
                  ExpressionCompiler.EmittingVisitor.J2osBm8vUaIa3b3WwLmF(il, OpCodes.Stobj, type);
                  num2 = 3;
                  continue;
                }
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 25 : 9;
                continue;
              case 9:
                // ISSUE: type reference
                if (!ExpressionCompiler.EmittingVisitor.fXH2wl8v53gf6fwkZ1cA(type, ExpressionCompiler.EmittingVisitor.U4TPVi8vg9UgNc6Skdyl(__typeref (long))))
                {
                  num2 = 24;
                  continue;
                }
                goto case 19;
              case 10:
                ((ILGenerator) il).Emit(OpCodes.Stind_R4);
                num2 = 5;
                continue;
              case 11:
                if (!ExpressionCompiler.EmittingVisitor.fXH2wl8v53gf6fwkZ1cA(type, typeof (short)))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 0;
                  continue;
                }
                goto case 6;
              case 12:
              case 16:
                ExpressionCompiler.EmittingVisitor.pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Stind_I4);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 8 : 22;
                continue;
              case 13:
                // ISSUE: type reference
                if (!ExpressionCompiler.EmittingVisitor.fXH2wl8v53gf6fwkZ1cA(type, ExpressionCompiler.EmittingVisitor.U4TPVi8vg9UgNc6Skdyl(__typeref (uint))))
                {
                  num2 = 21;
                  continue;
                }
                goto case 12;
              case 14:
                ExpressionCompiler.EmittingVisitor.pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Stind_I1);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 8 : 20;
                continue;
              case 15:
                ExpressionCompiler.EmittingVisitor.pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Stind_R8);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 26 : 11;
                continue;
              case 17:
                // ISSUE: type reference
                if (ExpressionCompiler.EmittingVisitor.fXH2wl8v53gf6fwkZ1cA(type, ExpressionCompiler.EmittingVisitor.U4TPVi8vg9UgNc6Skdyl(__typeref (int))))
                {
                  num2 = 16;
                  continue;
                }
                goto case 13;
              case 18:
                // ISSUE: type reference
                if (ExpressionCompiler.EmittingVisitor.fXH2wl8v53gf6fwkZ1cA(type, ExpressionCompiler.EmittingVisitor.U4TPVi8vg9UgNc6Skdyl(__typeref (double))))
                {
                  num2 = 15;
                  continue;
                }
                if (type == typeof (object))
                {
                  num2 = 4;
                  continue;
                }
                // ISSUE: type reference
                if (!(type == ExpressionCompiler.EmittingVisitor.U4TPVi8vg9UgNc6Skdyl(__typeref (IntPtr))))
                {
                  num2 = 8;
                  continue;
                }
                goto case 25;
              case 19:
                ((ILGenerator) il).Emit(OpCodes.Stind_I8);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 1 : 1;
                continue;
              case 20:
                goto label_28;
              case 21:
                // ISSUE: type reference
                if (!ExpressionCompiler.EmittingVisitor.fXH2wl8v53gf6fwkZ1cA(type, ExpressionCompiler.EmittingVisitor.U4TPVi8vg9UgNc6Skdyl(__typeref (byte))))
                {
                  num2 = 11;
                  continue;
                }
                goto case 14;
              case 22:
                goto label_9;
              case 23:
                goto label_21;
              case 24:
                // ISSUE: type reference
                if (!ExpressionCompiler.EmittingVisitor.fXH2wl8v53gf6fwkZ1cA(type, ExpressionCompiler.EmittingVisitor.U4TPVi8vg9UgNc6Skdyl(__typeref (ulong))))
                {
                  // ISSUE: type reference
                  if (!ExpressionCompiler.EmittingVisitor.fXH2wl8v53gf6fwkZ1cA(type, ExpressionCompiler.EmittingVisitor.U4TPVi8vg9UgNc6Skdyl(__typeref (float))))
                  {
                    num2 = 18;
                    continue;
                  }
                  goto case 10;
                }
                else
                {
                  num2 = 19;
                  continue;
                }
              case 25:
                ExpressionCompiler.EmittingVisitor.pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Stind_I);
                num2 = 7;
                continue;
              case 26:
                goto label_13;
              default:
                // ISSUE: type reference
                if (!(type == ExpressionCompiler.EmittingVisitor.U4TPVi8vg9UgNc6Skdyl(__typeref (ushort))))
                {
                  num2 = 9;
                  continue;
                }
                goto case 6;
            }
          }
label_8:
          ExpressionCompiler.EmittingVisitor.pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Stind_Ref);
          num1 = 23;
        }
label_17:
        return;
label_6:
        return;
label_35:
        return;
label_42:
        return;
label_3:
        return;
label_28:
        return;
label_9:
        return;
label_21:
        return;
label_13:;
      }

      private static bool TryEmitIndexAssign(
        object indexExpr,
        Type instType,
        Type elementType,
        object il)
      {
        int num = 4;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (ExpressionCompiler.EmittingVisitor.PjFnO38vzkxjGZ63tFdS(elementType))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 6 : 5;
                continue;
              }
              break;
            case 2:
            case 5:
              goto label_11;
            case 3:
              goto label_2;
            case 4:
              if (!(((IndexExpression) indexExpr).Indexer != (PropertyInfo) null))
              {
                if (((IndexExpression) indexExpr).Arguments.Count == 1)
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 0 : 1;
                  continue;
                }
                goto label_12;
              }
              else
              {
                num = 3;
                continue;
              }
            case 6:
              ExpressionCompiler.EmittingVisitor.J2osBm8vUaIa3b3WwLmF(il, OpCodes.Stelem, elementType);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 2 : 2;
              continue;
          }
          ExpressionCompiler.EmittingVisitor.pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Stelem_Ref);
          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 3 : 5;
        }
label_2:
        return ExpressionCompiler.EmittingVisitor.EmitMemberAssign(il, ExpressionCompiler.EmittingVisitor.JBBhye88OM33sBK79Znn(indexExpr));
label_11:
        return true;
label_12:
        return ExpressionCompiler.EmittingVisitor.EmitMethodCall(il, (object) instType != null ? ExpressionCompiler.EmittingVisitor.uoSAA2882sdDqJKDnujY(instType, ExpressionCompiler.EmittingVisitor.Fn0VLG88qZFRYO4uCytV(1470440286 ^ 1470409770)) : (object) null);
      }

      private static bool TryEmitMethodCall(
        object expr,
        IReadOnlyList<ParameterExpression> paramExprs,
        object il,
        ref ExpressionCompiler.ClosureInfo closure,
        ExpressionCompiler.ParentFlags parent)
      {
        ExpressionCompiler.ParentFlags parent1 = parent & ~ExpressionCompiler.ParentFlags.IgnoreResult | ExpressionCompiler.ParentFlags.Call;
        MethodCallExpression methodCallExpression = (MethodCallExpression) expr;
        Expression expr1 = methodCallExpression.Object;
        MethodInfo method = methodCallExpression.Method;
        ParameterInfo[] parameters = method.GetParameters();
        bool flag = false;
        if (expr1 != null)
        {
          if (!ExpressionCompiler.EmittingVisitor.TryEmit((object) expr1, paramExprs, il, ref closure, parent1 | ExpressionCompiler.ParentFlags.InstanceAccess))
            return false;
          flag = expr1.Type.IsValueType();
          if (flag && expr1.NodeType != ExpressionType.Parameter && !closure.LastEmitIsAddress)
            ExpressionCompiler.EmittingVisitor.EmitStoreLocalVariableAndLoadItsAddress(il, expr1.Type);
        }
        ReadOnlyCollection<Expression> arguments = methodCallExpression.Arguments;
        for (int index = 0; index < parameters.Length; ++index)
        {
          if (!ExpressionCompiler.EmittingVisitor.TryEmit((object) arguments[index], paramExprs, il, ref closure, parent1, parameters[index].ParameterType.IsByRef ? index : -1))
            return false;
        }
        if (flag && method.IsVirtual)
          ((ILGenerator) il).Emit(OpCodes.Constrained, expr1.Type);
        ((ILGenerator) il).Emit(method.IsVirtual ? OpCodes.Callvirt : OpCodes.Call, method);
        if (parent.IgnoresResult() && method.ReturnType != typeof (void))
          ((ILGenerator) il).Emit(OpCodes.Pop);
        closure.LastEmitIsAddress = false;
        return true;
      }

      private static bool TryEmitMemberAccess(
        object expr,
        IReadOnlyList<ParameterExpression> paramExprs,
        object il,
        ref ExpressionCompiler.ClosureInfo closure,
        ExpressionCompiler.ParentFlags parent)
      {
        if (((MemberExpression) expr).Member is PropertyInfo member1)
        {
          Expression expression = ((MemberExpression) expr).Expression;
          if (expression != null)
          {
            if (!ExpressionCompiler.EmittingVisitor.TryEmit((object) expression, paramExprs, il, ref closure, ~(ExpressionCompiler.ParentFlags.IgnoreResult | ExpressionCompiler.ParentFlags.DupMemberOwner) & (parent | ExpressionCompiler.ParentFlags.Call | ExpressionCompiler.ParentFlags.MemberAccess | ExpressionCompiler.ParentFlags.InstanceAccess)))
              return false;
            if ((parent & ExpressionCompiler.ParentFlags.DupMemberOwner) != ExpressionCompiler.ParentFlags.Empty)
              ((ILGenerator) il).Emit(OpCodes.Dup);
            if (!closure.LastEmitIsAddress && expression.NodeType != ExpressionType.Parameter && expression.Type.IsValueType())
              ExpressionCompiler.EmittingVisitor.EmitStoreLocalVariableAndLoadItsAddress(il, expression.Type);
          }
          closure.LastEmitIsAddress = false;
          MethodInfo propertyGetMethod = member1.DeclaringType.FindPropertyGetMethod(member1.Name);
          if (propertyGetMethod == (MethodInfo) null)
            return false;
          ((ILGenerator) il).Emit(propertyGetMethod.IsVirtual ? OpCodes.Callvirt : OpCodes.Call, propertyGetMethod);
          return true;
        }
        if (!(((MemberExpression) expr).Member is FieldInfo member2))
          return false;
        Expression expression1 = ((MemberExpression) expr).Expression;
        if (expression1 != null)
        {
          if (!ExpressionCompiler.EmittingVisitor.TryEmit((object) expression1, paramExprs, il, ref closure, ~(ExpressionCompiler.ParentFlags.IgnoreResult | ExpressionCompiler.ParentFlags.DupMemberOwner) & (parent | ExpressionCompiler.ParentFlags.MemberAccess | ExpressionCompiler.ParentFlags.InstanceAccess)))
            return false;
          if ((parent & ExpressionCompiler.ParentFlags.DupMemberOwner) != ExpressionCompiler.ParentFlags.Empty)
            ((ILGenerator) il).Emit(OpCodes.Dup);
          closure.LastEmitIsAddress = member2.FieldType.IsValueType() && (parent & ExpressionCompiler.ParentFlags.InstanceAccess) != 0;
          ((ILGenerator) il).Emit(closure.LastEmitIsAddress ? OpCodes.Ldflda : OpCodes.Ldfld, member2);
        }
        else if (member2.IsLiteral)
        {
          object constantValue = member2.GetValue((object) null);
          if (constantValue != null)
            return ExpressionCompiler.EmittingVisitor.TryEmitNotNullConstant(false, member2.FieldType, constantValue, il, ref closure);
          ((ILGenerator) il).Emit(OpCodes.Ldnull);
        }
        else
          ((ILGenerator) il).Emit(OpCodes.Ldsfld, member2);
        return true;
      }

      private static bool TryEmitNestedLambda(
        object lambdaExpr,
        IReadOnlyList<ParameterExpression> outerParamExprs,
        object il,
        ref ExpressionCompiler.ClosureInfo closure)
      {
        ExpressionCompiler.NestedLambdaInfo[] nestedLambdas = closure.NestedLambdas;
        int index1 = nestedLambdas.Length - 1;
        while (index1 != -1 && nestedLambdas[index1].LambdaExpression != lambdaExpr)
          --index1;
        if (index1 == -1)
          return false;
        ExpressionCompiler.NestedLambdaInfo nestedLambda = closure.NestedLambdas[index1];
        object lambda = nestedLambda.Lambda;
        int i1 = index1 + closure.Constants.Count;
        int location = nestedLambda.UsageCountOrVarIndex - 1;
        if (location > 0)
        {
          ExpressionCompiler.EmittingVisitor.EmitLoadLocalVariable(il, location);
        }
        else
        {
          ((ILGenerator) il).Emit(OpCodes.Ldloc_0);
          ExpressionCompiler.EmittingVisitor.EmitLoadConstantInt(il, i1);
          ((ILGenerator) il).Emit(OpCodes.Ldelem_Ref);
        }
        ParameterExpression[] passedParameters1 = nestedLambda.ClosureInfo.NonPassedParameters;
        if (passedParameters1.Length == 0)
          return true;
        if (location > 0)
        {
          ((ILGenerator) il).Emit(OpCodes.Ldfld, ExpressionCompiler.NestedLambdaWithConstantsAndNestedLambdas.NestedLambdaField);
          ExpressionCompiler.EmittingVisitor.EmitLoadLocalVariable(il, location);
          ((ILGenerator) il).Emit(OpCodes.Ldfld, ExpressionCompiler.NestedLambdaWithConstantsAndNestedLambdas.ConstantsAndNestedLambdasField);
        }
        else
        {
          int nextLocalVarIndex = ((ILGenerator) il).GetNextLocalVarIndex(typeof (ExpressionCompiler.NestedLambdaWithConstantsAndNestedLambdas));
          ExpressionCompiler.EmittingVisitor.EmitStoreLocalVariable(il, nextLocalVarIndex);
          ExpressionCompiler.EmittingVisitor.EmitLoadLocalVariable(il, nextLocalVarIndex);
          ((ILGenerator) il).Emit(OpCodes.Ldfld, ExpressionCompiler.NestedLambdaWithConstantsAndNestedLambdas.NestedLambdaField);
          ExpressionCompiler.EmittingVisitor.EmitLoadLocalVariable(il, nextLocalVarIndex);
          ((ILGenerator) il).Emit(OpCodes.Ldfld, ExpressionCompiler.NestedLambdaWithConstantsAndNestedLambdas.ConstantsAndNestedLambdasField);
        }
        ExpressionCompiler.EmittingVisitor.EmitLoadConstantInt(il, passedParameters1.Length);
        ((ILGenerator) il).Emit(OpCodes.Newarr, typeof (object));
        ParameterExpression[] passedParameters2 = closure.NonPassedParameters;
        for (int i2 = 0; i2 < passedParameters1.Length; ++i2)
        {
          ParameterExpression varParamExpr = passedParameters1[i2];
          ((ILGenerator) il).Emit(OpCodes.Dup);
          ExpressionCompiler.EmittingVisitor.EmitLoadConstantInt(il, i2);
          int index2 = outerParamExprs.Count - 1;
          while (index2 != -1 && outerParamExprs[index2] != varParamExpr)
            --index2;
          switch (index2)
          {
            case -1:
              if (passedParameters2.Length == 0)
                return false;
              int localVarOrDefault = closure.GetDefinedLocalVarOrDefault(varParamExpr);
              if (localVarOrDefault != -1)
              {
                ExpressionCompiler.EmittingVisitor.EmitLoadLocalVariable(il, localVarOrDefault);
                goto label_34;
              }
              else
              {
                int i3 = passedParameters2.Length - 1;
                while (i3 != -1 && passedParameters2[i3] != varParamExpr)
                  --i3;
                if (i3 == -1)
                  return false;
                ((ILGenerator) il).Emit(OpCodes.Ldarg_0);
                ((ILGenerator) il).Emit(OpCodes.Ldfld, ExpressionCompiler.ArrayClosureWithNonPassedParamsField);
                ExpressionCompiler.EmittingVisitor.EmitLoadConstantInt(il, i3);
                ((ILGenerator) il).Emit(OpCodes.Ldelem_Ref);
                goto label_34;
              }
            case 0:
              ((ILGenerator) il).Emit(OpCodes.Ldarg_1);
              break;
            case 1:
              ((ILGenerator) il).Emit(OpCodes.Ldarg_2);
              break;
            case 2:
              ((ILGenerator) il).Emit(OpCodes.Ldarg_3);
              break;
            default:
              ((ILGenerator) il).Emit(OpCodes.Ldarg_S, (byte) (1 + index2));
              break;
          }
          if (varParamExpr.Type.IsValueType())
            ((ILGenerator) il).Emit(OpCodes.Box, varParamExpr.Type);
label_34:
          ((ILGenerator) il).Emit(OpCodes.Stelem_Ref);
        }
        ((ILGenerator) il).Emit(OpCodes.Newobj, ExpressionCompiler.ArrayClosureWithNonPassedParamsConstructor);
        Type[] genericTypeArguments = IntrospectionExtensions.GetTypeInfo(lambda.GetType()).GenericTypeArguments;
        MethodInfo meth = ((LambdaExpression) nestedLambda.LambdaExpression).ReturnType == typeof (void) ? ExpressionCompiler.CurryClosureActions.Methods[genericTypeArguments.Length - 1].MakeGenericMethod(genericTypeArguments) : ExpressionCompiler.CurryClosureFuncs.Methods[genericTypeArguments.Length - 2].MakeGenericMethod(genericTypeArguments);
        ((ILGenerator) il).Emit(OpCodes.Call, meth);
        return true;
      }

      private static bool TryEmitInvoke(
        object expr,
        IReadOnlyList<ParameterExpression> paramExprs,
        object il,
        ref ExpressionCompiler.ClosureInfo closure,
        ExpressionCompiler.ParentFlags parent)
      {
        Expression expression = ((InvocationExpression) expr).Expression;
        if (!ExpressionCompiler.EmittingVisitor.TryEmit((object) expression, paramExprs, il, ref closure, parent & ~ExpressionCompiler.ParentFlags.IgnoreResult))
          return false;
        ReadOnlyCollection<Expression> arguments = ((InvocationExpression) expr).Arguments;
        if (arguments.Count != 0)
        {
          ExpressionCompiler.ParentFlags parent1 = parent & ~ExpressionCompiler.ParentFlags.IgnoreResult & ~ExpressionCompiler.ParentFlags.InstanceAccess;
          for (int index = 0; index < arguments.Count; ++index)
          {
            if (!ExpressionCompiler.EmittingVisitor.TryEmit((object) arguments[index], paramExprs, il, ref closure, parent1, arguments[index].Type.IsByRef ? index : -1))
              return false;
          }
        }
        MethodInfo delegateInvokeMethod = expression.Type.FindDelegateInvokeMethod();
        ((ILGenerator) il).Emit(OpCodes.Call, delegateInvokeMethod);
        if ((parent & ExpressionCompiler.ParentFlags.IgnoreResult) != ExpressionCompiler.ParentFlags.Empty && delegateInvokeMethod.ReturnType != typeof (void))
          ((ILGenerator) il).Emit(OpCodes.Pop);
        return true;
      }

      private static bool TryEmitSwitch(
        object expr,
        IReadOnlyList<ParameterExpression> paramExprs,
        object il,
        ref ExpressionCompiler.ClosureInfo closure,
        ExpressionCompiler.ParentFlags parent)
      {
        Label label = ((ILGenerator) il).DefineLabel();
        Label[] labelArray = new Label[((SwitchExpression) expr).Cases.Count];
        for (int index = 0; index < ((SwitchExpression) expr).Cases.Count; ++index)
        {
          SwitchCase switchCase = ((SwitchExpression) expr).Cases[index];
          labelArray[index] = ((ILGenerator) il).DefineLabel();
          foreach (Expression testValue in switchCase.TestValues)
          {
            if (!ExpressionCompiler.EmittingVisitor.TryEmitComparison((object) ((SwitchExpression) expr).SwitchValue, (object) testValue, ExpressionType.Equal, paramExprs, il, ref closure, parent))
              return false;
            ((ILGenerator) il).Emit(OpCodes.Brtrue, labelArray[index]);
          }
        }
        if (((SwitchExpression) expr).DefaultBody != null)
        {
          if (!ExpressionCompiler.EmittingVisitor.TryEmit((object) ((SwitchExpression) expr).DefaultBody, paramExprs, il, ref closure, parent))
            return false;
          ((ILGenerator) il).Emit(OpCodes.Br, label);
        }
        for (int index = 0; index < ((SwitchExpression) expr).Cases.Count; ++index)
        {
          SwitchCase switchCase = ((SwitchExpression) expr).Cases[index];
          ((ILGenerator) il).MarkLabel(labelArray[index]);
          if (!ExpressionCompiler.EmittingVisitor.TryEmit((object) switchCase.Body, paramExprs, il, ref closure, parent))
            return false;
          if (index != ((SwitchExpression) expr).Cases.Count - 1)
            ((ILGenerator) il).Emit(OpCodes.Br, label);
        }
        ((ILGenerator) il).MarkLabel(label);
        return true;
      }

      private static bool TryEmitComparison(
        object exprLeft,
        object exprRight,
        ExpressionType expressionType,
        IReadOnlyList<ParameterExpression> paramExprs,
        object il,
        ref ExpressionCompiler.ClosureInfo closure,
        ExpressionCompiler.ParentFlags parent)
      {
        Type type1 = ((Expression) exprLeft).Type;
        bool flag = type1.IsNullable();
        Type type2 = ((Expression) exprRight).Type;
        if (exprRight is ConstantExpression constantExpression && constantExpression.Value == null && ((Expression) exprRight).Type == typeof (object))
          type2 = type1;
        int location1 = -1;
        int location2 = -1;
        if (!ExpressionCompiler.EmittingVisitor.TryEmit(exprLeft, paramExprs, il, ref closure, parent & ~ExpressionCompiler.ParentFlags.IgnoreResult & ~ExpressionCompiler.ParentFlags.InstanceAccess))
          return false;
        if (flag)
        {
          location1 = ExpressionCompiler.EmittingVisitor.EmitStoreLocalVariableAndLoadItsAddress(il, type1);
          ((ILGenerator) il).Emit(OpCodes.Call, type1.FindNullableGetValueOrDefaultMethod());
          type1 = Nullable.GetUnderlyingType(type1);
        }
        if (!ExpressionCompiler.EmittingVisitor.TryEmit(exprRight, paramExprs, il, ref closure, parent & ~ExpressionCompiler.ParentFlags.IgnoreResult & ~ExpressionCompiler.ParentFlags.InstanceAccess))
          return false;
        if (type1 != type2 && type1.IsClass() && type2.IsClass() && (type1 == typeof (object) || type2 == typeof (object)))
        {
          switch (expressionType)
          {
            case ExpressionType.Equal:
              ((ILGenerator) il).Emit(OpCodes.Ceq);
              if ((parent & ExpressionCompiler.ParentFlags.IgnoreResult) != ExpressionCompiler.ParentFlags.Empty)
              {
                ((ILGenerator) il).Emit(OpCodes.Pop);
                break;
              }
              break;
            case ExpressionType.NotEqual:
              ((ILGenerator) il).Emit(OpCodes.Ceq);
              ((ILGenerator) il).Emit(OpCodes.Ldc_I4_0);
              ((ILGenerator) il).Emit(OpCodes.Ceq);
              break;
            default:
              return false;
          }
          if ((parent & ExpressionCompiler.ParentFlags.IgnoreResult) != ExpressionCompiler.ParentFlags.Empty)
            ((ILGenerator) il).Emit(OpCodes.Pop);
          return true;
        }
        if (type2.IsNullable())
        {
          location2 = ExpressionCompiler.EmittingVisitor.EmitStoreLocalVariableAndLoadItsAddress(il, type2);
          ((ILGenerator) il).Emit(OpCodes.Call, type2.FindNullableGetValueOrDefaultMethod());
          type2 = Nullable.GetUnderlyingType(type2);
        }
        TypeInfo typeInfo = IntrospectionExtensions.GetTypeInfo(type1);
        if (!typeInfo.IsPrimitive && !typeInfo.IsEnum)
        {
          string str1;
          switch (expressionType)
          {
            case ExpressionType.Equal:
              str1 = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -867968994);
              break;
            case ExpressionType.GreaterThan:
              str1 = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1255365154 ^ 596875508 ^ -1766137538);
              break;
            case ExpressionType.GreaterThanOrEqual:
              str1 = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -489056211);
              break;
            case ExpressionType.LessThan:
              str1 = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978201282);
              break;
            case ExpressionType.LessThanOrEqual:
              str1 = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1204263869 ^ -1341583247 ^ 137670550);
              break;
            case ExpressionType.NotEqual:
              str1 = z2jc63fLkugS1X8Q9N.tE1kD1vbB(979449278 ^ 979691914);
              break;
            default:
              str1 = (string) null;
              break;
          }
          string str2 = str1;
          if (str2 == null)
            return false;
          foreach (MethodInfo meth in typeInfo.DeclaredMethods.AsArray<MethodInfo>())
          {
            if (meth.IsSpecialName && meth.IsStatic && meth.Name == str2 && ExpressionCompiler.EmittingVisitor.IsComparisonOperatorSignature(type1, (object) meth.GetParameters()))
            {
              ((ILGenerator) il).Emit(OpCodes.Call, meth);
              return true;
            }
          }
          if (expressionType != ExpressionType.Equal && expressionType != ExpressionType.NotEqual)
            return false;
          ((ILGenerator) il).Emit(OpCodes.Call, (MethodInfo) ExpressionCompiler.EmittingVisitor._objectEqualsMethod);
          if (expressionType == ExpressionType.NotEqual)
          {
            ((ILGenerator) il).Emit(OpCodes.Ldc_I4_0);
            ((ILGenerator) il).Emit(OpCodes.Ceq);
          }
          if (!flag)
          {
            if ((parent & ExpressionCompiler.ParentFlags.IgnoreResult) > ExpressionCompiler.ParentFlags.Empty)
              ((ILGenerator) il).Emit(OpCodes.Pop);
            return true;
          }
        }
        else
        {
          switch (expressionType)
          {
            case ExpressionType.Equal:
              ((ILGenerator) il).Emit(OpCodes.Ceq);
              break;
            case ExpressionType.GreaterThan:
              ((ILGenerator) il).Emit(OpCodes.Cgt);
              break;
            case ExpressionType.GreaterThanOrEqual:
            case ExpressionType.LessThanOrEqual:
              Label label1 = ((ILGenerator) il).DefineLabel();
              if (type2 == typeof (uint) || type2 == typeof (ulong) || type2 == typeof (ushort) || type2 == typeof (byte))
                ((ILGenerator) il).Emit(expressionType == ExpressionType.GreaterThanOrEqual ? OpCodes.Bge_Un_S : OpCodes.Ble_Un_S, label1);
              else
                ((ILGenerator) il).Emit(expressionType == ExpressionType.GreaterThanOrEqual ? OpCodes.Bge_S : OpCodes.Ble_S, label1);
              ((ILGenerator) il).Emit(OpCodes.Ldc_I4_0);
              Label label2 = ((ILGenerator) il).DefineLabel();
              ((ILGenerator) il).Emit(OpCodes.Br_S, label2);
              ((ILGenerator) il).MarkLabel(label1);
              ((ILGenerator) il).Emit(OpCodes.Ldc_I4_1);
              ((ILGenerator) il).MarkLabel(label2);
              break;
            case ExpressionType.LessThan:
              ((ILGenerator) il).Emit(OpCodes.Clt);
              break;
            case ExpressionType.NotEqual:
              ((ILGenerator) il).Emit(OpCodes.Ceq);
              ((ILGenerator) il).Emit(OpCodes.Ldc_I4_0);
              ((ILGenerator) il).Emit(OpCodes.Ceq);
              break;
            default:
              return false;
          }
        }
        if (flag)
        {
          MethodInfo valueGetterMethod = ((Expression) exprLeft).Type.FindNullableHasValueGetterMethod();
          ExpressionCompiler.EmittingVisitor.EmitLoadLocalVariableAddress(il, location1);
          ((ILGenerator) il).Emit(OpCodes.Call, valueGetterMethod);
          ExpressionCompiler.EmittingVisitor.EmitLoadLocalVariableAddress(il, location2);
          ((ILGenerator) il).Emit(OpCodes.Call, valueGetterMethod);
          switch (expressionType)
          {
            case ExpressionType.Equal:
              ((ILGenerator) il).Emit(OpCodes.Ceq);
              ((ILGenerator) il).Emit(OpCodes.And);
              break;
            case ExpressionType.GreaterThan:
            case ExpressionType.GreaterThanOrEqual:
            case ExpressionType.LessThan:
            case ExpressionType.LessThanOrEqual:
              ((ILGenerator) il).Emit(OpCodes.Ceq);
              ((ILGenerator) il).Emit(OpCodes.Ldc_I4_1);
              ((ILGenerator) il).Emit(OpCodes.Ceq);
              ((ILGenerator) il).Emit(OpCodes.And);
              break;
            case ExpressionType.NotEqual:
              ((ILGenerator) il).Emit(OpCodes.Ceq);
              ((ILGenerator) il).Emit(OpCodes.Ldc_I4_0);
              ((ILGenerator) il).Emit(OpCodes.Ceq);
              ((ILGenerator) il).Emit(OpCodes.Or);
              break;
            default:
              return false;
          }
        }
        if ((parent & ExpressionCompiler.ParentFlags.IgnoreResult) > ExpressionCompiler.ParentFlags.Empty)
          ((ILGenerator) il).Emit(OpCodes.Pop);
        return true;
      }

      private static bool IsComparisonOperatorSignature(Type t, object pars)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (pars.Length == 2)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 0 : 0;
                continue;
              }
              goto label_5;
            case 2:
              goto label_4;
            default:
              if (ExpressionCompiler.EmittingVisitor.fXH2wl8v53gf6fwkZ1cA(((ParameterInfo) pars[0]).ParameterType, t))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 2 : 0;
                continue;
              }
              goto label_5;
          }
        }
label_4:
        return ExpressionCompiler.EmittingVisitor.fXH2wl8v53gf6fwkZ1cA(ExpressionCompiler.EmittingVisitor.otgWhy88e6vv3pdqxkCd(pars[1]), t);
label_5:
        return false;
      }

      private static bool TryEmitArithmetic(
        object expr,
        ExpressionType exprNodeType,
        IReadOnlyList<ParameterExpression> paramExprs,
        object il,
        ref ExpressionCompiler.ClosureInfo closure,
        ExpressionCompiler.ParentFlags parent)
      {
        ExpressionCompiler.ParentFlags parent1 = parent & ~ExpressionCompiler.ParentFlags.IgnoreResult & ~ExpressionCompiler.ParentFlags.InstanceCall | ExpressionCompiler.ParentFlags.Arithmetic;
        Label label1 = new Label();
        Expression left = ((BinaryExpression) expr).Left;
        Type type1 = left.Type;
        bool flag1 = type1.IsNullable();
        if (flag1)
        {
          label1 = ((ILGenerator) il).DefineLabel();
          if (!ExpressionCompiler.EmittingVisitor.TryEmit((object) left, paramExprs, il, ref closure, parent1 | ExpressionCompiler.ParentFlags.InstanceCall))
            return false;
          if (!closure.LastEmitIsAddress)
            ExpressionCompiler.EmittingVisitor.EmitStoreLocalVariableAndLoadItsAddress(il, type1);
          ((ILGenerator) il).Emit(OpCodes.Dup);
          ((ILGenerator) il).Emit(OpCodes.Call, type1.FindNullableHasValueGetterMethod());
          ((ILGenerator) il).Emit(OpCodes.Brfalse, label1);
          ((ILGenerator) il).Emit(OpCodes.Call, type1.FindNullableGetValueOrDefaultMethod());
        }
        else if (!ExpressionCompiler.EmittingVisitor.TryEmit((object) left, paramExprs, il, ref closure, parent1))
          return false;
        Label label2 = new Label();
        Expression right = ((BinaryExpression) expr).Right;
        Type type2 = right.Type;
        bool flag2 = type2.IsNullable();
        if (flag2)
        {
          label2 = ((ILGenerator) il).DefineLabel();
          if (!ExpressionCompiler.EmittingVisitor.TryEmit((object) right, paramExprs, il, ref closure, parent1 | ExpressionCompiler.ParentFlags.InstanceCall))
            return false;
          if (!closure.LastEmitIsAddress)
            ExpressionCompiler.EmittingVisitor.EmitStoreLocalVariableAndLoadItsAddress(il, type2);
          ((ILGenerator) il).Emit(OpCodes.Dup);
          ((ILGenerator) il).Emit(OpCodes.Call, type2.FindNullableHasValueGetterMethod());
          ((ILGenerator) il).Emit(OpCodes.Brfalse, label2);
          ((ILGenerator) il).Emit(OpCodes.Call, type2.FindNullableGetValueOrDefaultMethod());
        }
        else if (!ExpressionCompiler.EmittingVisitor.TryEmit((object) right, paramExprs, il, ref closure, parent1))
          return false;
        Type type3 = ((Expression) expr).Type;
        if (!ExpressionCompiler.EmittingVisitor.TryEmitArithmeticOperation(expr, exprNodeType, type3, il))
          return false;
        if (flag1 | flag2)
        {
          Label label3 = ((ILGenerator) il).DefineLabel();
          ((ILGenerator) il).Emit(OpCodes.Br, label3);
          if (flag2)
            ((ILGenerator) il).MarkLabel(label2);
          ((ILGenerator) il).Emit(OpCodes.Pop);
          if (flag1)
            ((ILGenerator) il).MarkLabel(label1);
          ((ILGenerator) il).Emit(OpCodes.Pop);
          if (type3.IsNullable())
          {
            Label label4 = ((ILGenerator) il).DefineLabel();
            int location = ExpressionCompiler.EmittingVisitor.InitValueTypeVariable(il, type3);
            ExpressionCompiler.EmittingVisitor.EmitLoadLocalVariable(il, location);
            ((ILGenerator) il).Emit(OpCodes.Br_S, label4);
            ((ILGenerator) il).MarkLabel(label3);
            ((ILGenerator) il).Emit(OpCodes.Newobj, IntrospectionExtensions.GetTypeInfo(type3).DeclaredConstructors.GetFirst<ConstructorInfo>());
            ((ILGenerator) il).MarkLabel(label4);
          }
          else
          {
            ((ILGenerator) il).Emit(OpCodes.Ldc_I4_0);
            ((ILGenerator) il).MarkLabel(label3);
          }
        }
        return true;
      }

      private static bool TryEmitArithmeticOperation(
        object expr,
        ExpressionType exprNodeType,
        Type exprType,
        object il)
      {
        int num1 = 24;
        while (true)
        {
          int num2 = num1;
          int index1;
          MethodInfo methodInfo1;
          MethodInfo methodInfo2;
          while (true)
          {
            Type type;
            MethodInfo methodInfo3;
            MethodInfo[] methodInfoArray1;
            int index2;
            MethodInfo[] methodInfoArray2;
            string str;
            object obj;
            switch (num2)
            {
              case 1:
                methodInfo2 = methodInfoArray2[index2];
                num2 = 72;
                continue;
              case 2:
                // ISSUE: type reference
                type = ExpressionCompiler.EmittingVisitor.U4TPVi8vg9UgNc6Skdyl(__typeref (string));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 19 : 21;
                continue;
              case 3:
                goto label_125;
              case 4:
                ExpressionCompiler.EmittingVisitor.cr9PXh88BxyHDixSqTcC(il, !methodInfo1.IsVirtual ? OpCodes.Call : OpCodes.Callvirt, (object) methodInfo1);
                num2 = 38;
                continue;
              case 5:
              case 41:
                switch (exprNodeType)
                {
                  case ExpressionType.Or:
                    goto label_27;
                  case ExpressionType.OrElse:
                  case ExpressionType.Parameter:
                  case ExpressionType.Quote:
                    goto label_35;
                  case ExpressionType.Power:
                    // ISSUE: type reference
                    ExpressionCompiler.EmittingVisitor.cr9PXh88BxyHDixSqTcC(il, OpCodes.Call, ExpressionCompiler.EmittingVisitor.uoSAA2882sdDqJKDnujY(ExpressionCompiler.EmittingVisitor.U4TPVi8vg9UgNc6Skdyl(__typeref (Math)), ExpressionCompiler.EmittingVisitor.Fn0VLG88qZFRYO4uCytV(1051276242 - 990076387 ^ 60819741)));
                    num2 = 75;
                    continue;
                  case ExpressionType.RightShift:
                    goto label_89;
                  case ExpressionType.Subtract:
                    break;
                  case ExpressionType.SubtractChecked:
                    goto label_126;
                  default:
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 26 : 7;
                    continue;
                }
                break;
              case 6:
label_102:
                ExpressionCompiler.EmittingVisitor.pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Add);
                num2 = 22;
                continue;
              case 7:
                if (exprNodeType != ExpressionType.Modulo)
                {
                  num2 = 65;
                  continue;
                }
                obj = (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606933648);
                goto label_120;
              case 8:
                switch (exprNodeType)
                {
                  case ExpressionType.Modulo:
                    goto label_30;
                  case ExpressionType.Multiply:
                    goto label_97;
                  case ExpressionType.MultiplyChecked:
                    goto label_128;
                  default:
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 16 : 2;
                    continue;
                }
              case 9:
                if (ExpressionCompiler.EmittingVisitor.n6g7oS88aQ3OpAmxEDgB(ExpressionCompiler.EmittingVisitor.gsLJHN88pa2A268EfMbs((object) methodInfo2), (object) str))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 4 : 25;
                  continue;
                }
                goto case 45;
              case 10:
                if (exprNodeType != ExpressionType.LeftShift)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 8 : 1;
                  continue;
                }
                goto label_84;
              case 11:
                goto label_121;
              case 12:
                if (index2 >= methodInfoArray2.Length)
                {
                  num2 = 54;
                  continue;
                }
                goto case 1;
              case 13:
                // ISSUE: type reference
                if (ExpressionCompiler.EmittingVisitor.aiU5Py88bf4bvp4KvZlA(((Expression) ExpressionCompiler.EmittingVisitor.HG4E25881F3PGheegRQI(expr)).Type, ExpressionCompiler.EmittingVisitor.U4TPVi8vg9UgNc6Skdyl(__typeref (string))))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 43 : 18;
                  continue;
                }
                goto case 14;
              case 14:
                methodInfoArray1 = IntrospectionExtensions.GetTypeInfo(typeof (string)).DeclaredMethods.AsArray<MethodInfo>();
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 20 : 16;
                continue;
              case 15:
                methodInfo1 = (MethodInfo) null;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 13 : 42;
                continue;
              case 16:
              case 31:
              case 49:
                goto label_35;
              case 17:
                if (exprNodeType == ExpressionType.SubtractChecked)
                {
                  obj = ExpressionCompiler.EmittingVisitor.Fn0VLG88qZFRYO4uCytV(1470440286 ^ 1470169062);
                  goto label_120;
                }
                else
                {
                  num2 = 57;
                  continue;
                }
              case 18:
              case 67:
                if (ExpressionCompiler.EmittingVisitor.cqpyYd88wuAuE70gaROo((object) methodInfo1, (object) null))
                {
                  num2 = 12;
                  continue;
                }
                goto case 37;
              case 19:
                if (exprNodeType != ExpressionType.Add)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 0 : 0;
                  continue;
                }
                obj = ExpressionCompiler.EmittingVisitor.Fn0VLG88qZFRYO4uCytV(1051276242 - 990076387 ^ 60819767);
                goto label_120;
              case 20:
                index1 = 0;
                num2 = 28;
                continue;
              case 21:
                if (ExpressionCompiler.EmittingVisitor.XTROpG88NXfDY02TA2TM(ExpressionCompiler.EmittingVisitor.HG4E25881F3PGheegRQI(expr)) != ExpressionCompiler.EmittingVisitor.XTROpG88NXfDY02TA2TM(ExpressionCompiler.EmittingVisitor.vGqfcq883GxgYQw8sWuO(expr)))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 59 : 4;
                  continue;
                }
                goto case 13;
              case 22:
                goto label_123;
              case 23:
                if (exprType.IsNullable())
                {
                  num2 = 77;
                  continue;
                }
                goto case 56;
              case 24:
                if (!ExpressionCompiler.EmittingVisitor.R9kTwj88PSmNdg9VwAeW(exprType))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 19 : 23;
                  continue;
                }
                goto label_50;
              case 25:
                goto label_59;
              case 26:
                switch (exprNodeType)
                {
                  case ExpressionType.AddAssign:
                    goto label_102;
                  case ExpressionType.AndAssign:
                    goto label_19;
                  case ExpressionType.DivideAssign:
                    goto label_65;
                  case ExpressionType.ExclusiveOrAssign:
                    goto label_110;
                  case ExpressionType.LeftShiftAssign:
                    goto label_84;
                  case ExpressionType.ModuloAssign:
                    goto label_30;
                  case ExpressionType.MultiplyAssign:
                    goto label_97;
                  case ExpressionType.OrAssign:
                    goto label_27;
                  case ExpressionType.PowerAssign:
                    goto label_35;
                  case ExpressionType.RightShiftAssign:
                    goto label_89;
                  case ExpressionType.SubtractAssign:
                    break;
                  case ExpressionType.AddAssignChecked:
                    goto label_124;
                  case ExpressionType.MultiplyAssignChecked:
                    goto label_128;
                  case ExpressionType.SubtractAssignChecked:
                    goto label_126;
                  default:
                    goto label_37;
                }
                break;
              case 27:
                goto label_109;
              case 28:
              case 36:
                if (index1 >= methodInfoArray1.Length)
                {
                  num2 = 53;
                  continue;
                }
                goto case 44;
              case 29:
                if (methodInfo3.IsStatic)
                  goto case 63;
                else
                  goto label_86;
              case 30:
                goto label_83;
              case 32:
                if (methodInfo2.IsStatic)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 0 : 9;
                  continue;
                }
                goto case 45;
              case 33:
                goto label_29;
              case 34:
                if (exprNodeType != ExpressionType.Divide)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 43 : 76;
                  continue;
                }
                goto label_65;
              case 35:
                goto label_26;
              case 37:
              case 53:
              case 54:
                if (!(methodInfo1 == (MethodInfo) null))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 4 : 4;
                  continue;
                }
                goto label_121;
              case 38:
                goto label_49;
              case 39:
                goto label_64;
              case 40:
                if (!(ExpressionCompiler.EmittingVisitor.otgWhy88e6vv3pdqxkCd(ExpressionCompiler.EmittingVisitor.ld8c6R88DVMhn1v9af95((object) methodInfo3)[0]) == type))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 45 : 50;
                  continue;
                }
                goto case 61;
              case 42:
                // ISSUE: type reference
                if (!ExpressionCompiler.EmittingVisitor.fXH2wl8v53gf6fwkZ1cA(exprType, ExpressionCompiler.EmittingVisitor.U4TPVi8vg9UgNc6Skdyl(__typeref (string))))
                  goto case 19;
                else
                  goto label_55;
              case 43:
              case 59:
                // ISSUE: type reference
                type = ExpressionCompiler.EmittingVisitor.U4TPVi8vg9UgNc6Skdyl(__typeref (object));
                num2 = 14;
                continue;
              case 44:
                methodInfo3 = methodInfoArray1[index1];
                num2 = 29;
                continue;
              case 45:
                ++index2;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 67 : 25;
                continue;
              case 46:
              case 50:
              case 51:
              case 71:
                goto label_3;
              case 47:
label_81:
                switch (exprNodeType)
                {
                  case ExpressionType.Add:
                    goto label_102;
                  case ExpressionType.AddChecked:
                    goto label_124;
                  case ExpressionType.And:
                    goto label_19;
                  default:
                    num2 = 34;
                    continue;
                }
              case 48:
                index2 = 0;
                num2 = 18;
                continue;
              case 52:
                if (exprNodeType != ExpressionType.MultiplyChecked)
                {
                  num2 = 74;
                  continue;
                }
                obj = (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1642859704 ^ 1642713126);
                goto label_120;
              case 55:
                if (methodInfo3.GetParameters().Length == 2)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 40 : 25;
                  continue;
                }
                goto label_3;
              case 56:
                if (!ExpressionCompiler.EmittingVisitor.R9kTwj88PSmNdg9VwAeW(exprType))
                {
                  num2 = 15;
                  continue;
                }
                goto label_50;
              case 57:
                if (exprNodeType != ExpressionType.Multiply)
                {
                  num2 = 52;
                  continue;
                }
                obj = ExpressionCompiler.EmittingVisitor.Fn0VLG88qZFRYO4uCytV(654297945 ^ 653924295);
                goto label_120;
              case 58:
                if (str != null)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 67 : 69;
                  continue;
                }
                goto case 37;
              case 60:
                goto label_88;
              case 61:
                methodInfo1 = methodInfo3;
                num2 = 37;
                continue;
              case 62:
                if (exprNodeType != ExpressionType.Subtract)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 17 : 11;
                  continue;
                }
                obj = (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-16752921 ^ -16416161);
                goto label_120;
              case 63:
                if (!ExpressionCompiler.EmittingVisitor.n6g7oS88aQ3OpAmxEDgB(ExpressionCompiler.EmittingVisitor.gsLJHN88pa2A268EfMbs((object) methodInfo3), ExpressionCompiler.EmittingVisitor.Fn0VLG88qZFRYO4uCytV(874012245 ^ 874006279)))
                {
                  num2 = 46;
                  continue;
                }
                goto case 55;
              case 64:
              case 79:
                if (exprNodeType > ExpressionType.MultiplyChecked)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 16 : 41;
                  continue;
                }
                goto case 10;
              case 65:
                obj = (object) null;
                goto label_120;
              case 66:
                goto label_74;
              case 68:
                goto label_96;
              case 69:
                methodInfoArray2 = ((TypeInfo) ExpressionCompiler.EmittingVisitor.GNKm9i8vrhrfeYTW9WQI(exprType)).DeclaredMethods.AsArray<MethodInfo>();
                num2 = 48;
                continue;
              case 70:
                goto label_14;
              case 72:
                if (ExpressionCompiler.EmittingVisitor.C53Pi688tdxbqC7lWMQv((object) methodInfo2))
                {
                  num2 = 32;
                  continue;
                }
                goto case 45;
              case 73:
                goto label_127;
              case 74:
                if (exprNodeType != ExpressionType.Divide)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 0 : 7;
                  continue;
                }
                obj = (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-138018305 ^ -138158725);
                goto label_120;
              case 75:
                goto label_34;
              case 76:
                if (exprNodeType != ExpressionType.ExclusiveOr)
                {
                  num2 = 31;
                  continue;
                }
                goto label_110;
              case 77:
                exprType = ExpressionCompiler.EmittingVisitor.Y3ZBnF88oFL48nB4EbDT(exprType);
                num2 = 56;
                continue;
              case 78:
                goto label_18;
              default:
                if (exprNodeType == ExpressionType.AddChecked)
                {
                  obj = (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1470998129 - 231418599 ^ 1239918418);
                  goto label_120;
                }
                else
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 62 : 60;
                  continue;
                }
            }
            ExpressionCompiler.EmittingVisitor.pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Sub);
            num2 = 3;
            continue;
label_19:
            ExpressionCompiler.EmittingVisitor.pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.And);
            num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 35 : 20;
            continue;
label_27:
            ExpressionCompiler.EmittingVisitor.pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Or);
            num2 = 27;
            continue;
label_30:
            ExpressionCompiler.EmittingVisitor.pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Rem);
            num2 = 78;
            continue;
label_50:
            if (exprNodeType > ExpressionType.ExclusiveOr)
            {
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 11 : 64;
              continue;
            }
            goto label_81;
label_65:
            ((ILGenerator) il).Emit(OpCodes.Div);
            num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 14 : 33;
            continue;
label_84:
            ExpressionCompiler.EmittingVisitor.pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Shl);
            num2 = 60;
            continue;
label_89:
            ExpressionCompiler.EmittingVisitor.pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Shr);
            num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 49 : 66;
            continue;
label_97:
            ExpressionCompiler.EmittingVisitor.pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Mul);
            num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 40 : 73;
            continue;
label_110:
            ExpressionCompiler.EmittingVisitor.pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Xor);
            num2 = 30;
            continue;
label_120:
            str = (string) obj;
            num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 26 : 58;
            continue;
label_124:
            ExpressionCompiler.EmittingVisitor.pO5qbK8vj7kF4Bx0nVcJ(il, !ExpressionCompiler.EmittingVisitor.vfkSi3884O8weMQFqJZm(exprType) ? OpCodes.Add_Ovf : OpCodes.Add_Ovf_Un);
            num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 23 : 70;
            continue;
label_126:
            ExpressionCompiler.EmittingVisitor.pO5qbK8vj7kF4Bx0nVcJ(il, ExpressionCompiler.EmittingVisitor.vfkSi3884O8weMQFqJZm(exprType) ? OpCodes.Sub_Ovf_Un : OpCodes.Sub_Ovf);
            num2 = 68;
            continue;
label_128:
            ExpressionCompiler.EmittingVisitor.pO5qbK8vj7kF4Bx0nVcJ(il, ExpressionCompiler.EmittingVisitor.vfkSi3884O8weMQFqJZm(exprType) ? OpCodes.Mul_Ovf_Un : OpCodes.Mul_Ovf);
            num2 = 39;
          }
label_3:
          ++index1;
          num1 = 36;
          continue;
label_37:
          num1 = 49;
          continue;
label_55:
          num1 = 2;
          continue;
label_59:
          methodInfo1 = methodInfo2;
          num1 = 45;
          continue;
label_86:
          num1 = 71;
        }
label_14:
        return true;
label_18:
        return true;
label_26:
        return true;
label_29:
        return true;
label_34:
        return true;
label_35:
        return false;
label_49:
        return true;
label_64:
        return true;
label_74:
        return true;
label_83:
        return true;
label_88:
        return true;
label_96:
        return true;
label_109:
        return true;
label_121:
        return false;
label_123:
        return true;
label_125:
        return true;
label_127:
        return true;
      }

      private static bool TryEmitLogicalOperator(
        object expr,
        IReadOnlyList<ParameterExpression> paramExprs,
        object il,
        ref ExpressionCompiler.ClosureInfo closure,
        ExpressionCompiler.ParentFlags parent)
      {
        if (!ExpressionCompiler.EmittingVisitor.TryEmit((object) ((BinaryExpression) expr).Left, paramExprs, il, ref closure, parent))
          return false;
        Label label1 = ((ILGenerator) il).DefineLabel();
        ((ILGenerator) il).Emit(((Expression) expr).NodeType == ExpressionType.AndAlso ? OpCodes.Brfalse : OpCodes.Brtrue, label1);
        if (!ExpressionCompiler.EmittingVisitor.TryEmit((object) ((BinaryExpression) expr).Right, paramExprs, il, ref closure, parent))
          return false;
        Label label2 = ((ILGenerator) il).DefineLabel();
        ((ILGenerator) il).Emit(OpCodes.Br, label2);
        ((ILGenerator) il).MarkLabel(label1);
        ((ILGenerator) il).Emit(((Expression) expr).NodeType == ExpressionType.AndAlso ? OpCodes.Ldc_I4_0 : OpCodes.Ldc_I4_1);
        ((ILGenerator) il).MarkLabel(label2);
        return true;
      }

      private static bool TryEmitConditional(
        object expr,
        IReadOnlyList<ParameterExpression> paramExprs,
        object il,
        ref ExpressionCompiler.ClosureInfo closure,
        ExpressionCompiler.ParentFlags parent)
      {
        Expression expr1 = ExpressionCompiler.EmittingVisitor.TryReduceCondition((object) ((ConditionalExpression) expr).Test);
        bool flag = false;
        if (expr1 is BinaryExpression binaryExpression && (binaryExpression.NodeType == ExpressionType.Equal || binaryExpression.NodeType == ExpressionType.NotEqual || !binaryExpression.Left.Type.IsNullable() && !binaryExpression.Right.Type.IsNullable()))
        {
          if (binaryExpression.Right is ConstantExpression right && right.Value == null)
          {
            if (binaryExpression.Left.Type.IsNullable())
              parent |= ExpressionCompiler.ParentFlags.MemberAccess;
            flag = ExpressionCompiler.EmittingVisitor.TryEmit((object) binaryExpression.Left, paramExprs, il, ref closure, parent & ~ExpressionCompiler.ParentFlags.IgnoreResult);
          }
          else if (binaryExpression.Left is ConstantExpression left && left.Value == null)
          {
            if (binaryExpression.Right.Type.IsNullable())
              parent |= ExpressionCompiler.ParentFlags.MemberAccess;
            flag = ExpressionCompiler.EmittingVisitor.TryEmit((object) binaryExpression.Right, paramExprs, il, ref closure, parent & ~ExpressionCompiler.ParentFlags.IgnoreResult);
          }
        }
        if (!flag && !ExpressionCompiler.EmittingVisitor.TryEmit((object) expr1, paramExprs, il, ref closure, parent & ~ExpressionCompiler.ParentFlags.IgnoreResult))
          return false;
        Label label1 = ((ILGenerator) il).DefineLabel();
        ((ILGenerator) il).Emit(!flag || expr1.NodeType != ExpressionType.Equal ? OpCodes.Brfalse : OpCodes.Brtrue, label1);
        if (!ExpressionCompiler.EmittingVisitor.TryEmit((object) ((ConditionalExpression) expr).IfTrue, paramExprs, il, ref closure, parent & ExpressionCompiler.ParentFlags.IgnoreResult))
          return false;
        Expression ifFalse = ((ConditionalExpression) expr).IfFalse;
        if (ifFalse.NodeType == ExpressionType.Default && ifFalse.Type == typeof (void))
        {
          ((ILGenerator) il).MarkLabel(label1);
          return true;
        }
        Label label2 = ((ILGenerator) il).DefineLabel();
        ((ILGenerator) il).Emit(OpCodes.Br, label2);
        ((ILGenerator) il).MarkLabel(label1);
        if (!ExpressionCompiler.EmittingVisitor.TryEmit((object) ifFalse, paramExprs, il, ref closure, parent & ExpressionCompiler.ParentFlags.IgnoreResult))
          return false;
        ((ILGenerator) il).MarkLabel(label2);
        return true;
      }

      private static Expression TryReduceCondition(object testExpr)
      {
        int num1 = 5;
        while (true)
        {
          int num2 = num1;
          bool flag1;
          while (true)
          {
            object obj;
            bool flag2;
            bool flag3;
            bool flag4;
            int num3;
            switch (num2)
            {
              case 1:
                goto label_22;
              case 2:
                if (binaryExpression.Right is ConstantExpression right)
                  goto case 14;
                else
                  goto label_29;
              case 3:
                if ((obj = constantExpression2.Value) is bool)
                {
                  num2 = 16;
                  continue;
                }
                goto case 2;
              case 4:
                if (ExpressionCompiler.EmittingVisitor.Y0Yi9m8863JbP6luaq0W((object) binaryExpression) != ExpressionType.OrElse)
                {
                  num2 = 6;
                  continue;
                }
                goto case 9;
              case 5:
                if (testExpr is BinaryExpression binaryExpression)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 4 : 4;
                  continue;
                }
                goto label_25;
              case 6:
                if (ExpressionCompiler.EmittingVisitor.Y0Yi9m8863JbP6luaq0W((object) binaryExpression) != ExpressionType.Or)
                {
                  if (ExpressionCompiler.EmittingVisitor.Y0Yi9m8863JbP6luaq0W((object) binaryExpression) != ExpressionType.AndAlso)
                  {
                    num2 = 15;
                    continue;
                  }
                  goto case 19;
                }
                else
                {
                  num2 = 9;
                  continue;
                }
              case 7:
                if ((obj = ExpressionCompiler.EmittingVisitor.xVh8Zv88HC6mNl7BAaL0((object) constantExpression1)) is bool)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 21 : 21;
                  continue;
                }
                break;
              case 8:
              case 10:
                goto label_25;
              case 9:
                if (ExpressionCompiler.EmittingVisitor.HG4E25881F3PGheegRQI((object) binaryExpression) is ConstantExpression constantExpression1)
                {
                  num2 = 7;
                  continue;
                }
                break;
              case 11:
                goto label_5;
              case 12:
                if (!((obj = ExpressionCompiler.EmittingVisitor.xVh8Zv88HC6mNl7BAaL0((object) constantExpression3)) is bool))
                {
                  num2 = 10;
                  continue;
                }
                goto case 24;
              case 13:
                flag4 = (bool) obj;
                num2 = 22;
                continue;
              case 14:
                if ((obj = ExpressionCompiler.EmittingVisitor.xVh8Zv88HC6mNl7BAaL0((object) right)) is bool)
                  goto case 13;
                else
                  goto label_35;
              case 15:
                if (ExpressionCompiler.EmittingVisitor.Y0Yi9m8863JbP6luaq0W((object) binaryExpression) == ExpressionType.And)
                {
                  num2 = 19;
                  continue;
                }
                goto label_25;
              case 16:
                flag2 = (bool) obj;
                num2 = 18;
                continue;
              case 17:
                goto label_24;
              case 18:
                if (flag2)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 0 : 0;
                  continue;
                }
                goto label_27;
              case 19:
                if (!(ExpressionCompiler.EmittingVisitor.HG4E25881F3PGheegRQI((object) binaryExpression) is ConstantExpression constantExpression2))
                {
                  num2 = 2;
                  continue;
                }
                goto case 3;
              case 20:
                num3 = 0;
                goto label_49;
              case 21:
                flag3 = (bool) obj;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 26 : 22;
                continue;
              case 22:
                num3 = 1;
                goto label_49;
              case 23:
                goto label_44;
              case 24:
                flag1 = (bool) obj;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 1 : 0;
                continue;
              case 25:
                goto label_45;
              case 26:
                if (flag3)
                {
                  num2 = 25;
                  continue;
                }
                goto label_44;
              case 27:
                num3 = 0;
                goto label_49;
              default:
                goto label_26;
            }
            if (ExpressionCompiler.EmittingVisitor.vGqfcq883GxgYQw8sWuO((object) binaryExpression) is ConstantExpression constantExpression3)
            {
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 12 : 7;
              continue;
            }
            goto label_25;
label_49:
            int num4 = flag4 ? 1 : 0;
            if ((num3 & num4) != 0)
              num2 = 17;
            else
              goto label_25;
          }
label_22:
          if (flag1)
          {
            num1 = 8;
            continue;
          }
          break;
label_29:
          num1 = 20;
          continue;
label_35:
          num1 = 27;
        }
label_5:
        return (Expression) ExpressionCompiler.EmittingVisitor.jLpj7J88AETGFMXf5kR6(ExpressionCompiler.EmittingVisitor.HG4E25881F3PGheegRQI((object) binaryExpression));
label_24:
        return (Expression) ExpressionCompiler.EmittingVisitor.jLpj7J88AETGFMXf5kR6(ExpressionCompiler.EmittingVisitor.HG4E25881F3PGheegRQI((object) binaryExpression));
label_25:
        return (Expression) testExpr;
label_26:
        return (Expression) ExpressionCompiler.EmittingVisitor.jLpj7J88AETGFMXf5kR6((object) binaryExpression.Right);
label_27:
        return (Expression) ExpressionCompiler.EmittingVisitor.HG4E25881F3PGheegRQI((object) binaryExpression);
label_44:
        return (Expression) ExpressionCompiler.EmittingVisitor.jLpj7J88AETGFMXf5kR6(ExpressionCompiler.EmittingVisitor.vGqfcq883GxgYQw8sWuO((object) binaryExpression));
label_45:
        return (Expression) ExpressionCompiler.EmittingVisitor.HG4E25881F3PGheegRQI((object) binaryExpression);
      }

      private static bool EmitMethodCall(
        object il,
        object method,
        ExpressionCompiler.ParentFlags parent = ExpressionCompiler.ParentFlags.Empty)
      {
        int num = 4;
        while (true)
        {
          switch (num)
          {
            case 1:
              // ISSUE: type reference
              if (!(ExpressionCompiler.EmittingVisitor.ecKKQm8877KnuCCgvTdn(method) != ExpressionCompiler.EmittingVisitor.U4TPVi8vg9UgNc6Skdyl(__typeref (void))))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 4 : 7;
                continue;
              }
              break;
            case 2:
              goto label_10;
            case 3:
              ExpressionCompiler.EmittingVisitor.cr9PXh88BxyHDixSqTcC(il, !ExpressionCompiler.EmittingVisitor.wl8EMB88kTNmCG4OyVv6(method) ? OpCodes.Call : OpCodes.Callvirt, method);
              num = 6;
              continue;
            case 4:
              if (!ExpressionCompiler.EmittingVisitor.cqpyYd88wuAuE70gaROo(method, (object) null))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 3 : 1;
                continue;
              }
              goto label_10;
            case 5:
            case 7:
              goto label_2;
            case 6:
              if ((parent & ExpressionCompiler.ParentFlags.IgnoreResult) != ExpressionCompiler.ParentFlags.Empty)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 1;
                continue;
              }
              goto label_2;
          }
          ExpressionCompiler.EmittingVisitor.pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Pop);
          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 2 : 5;
        }
label_2:
        return true;
label_10:
        return false;
      }

      private static void EmitLoadConstantInt(object il, int i)
      {
        int num1 = 2;
        while (true)
        {
          int num2 = num1;
          while (true)
          {
            switch (num2)
            {
              case 0:
                goto label_14;
              case 1:
                if (i <= -129)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 5 : 12;
                  continue;
                }
                goto case 10;
              case 2:
                switch (i)
                {
                  case -1:
                    goto label_19;
                  case 0:
                    ExpressionCompiler.EmittingVisitor.pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Ldc_I4_0);
                    num2 = 14;
                    continue;
                  case 1:
                    ExpressionCompiler.EmittingVisitor.pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Ldc_I4_1);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 7 : 16;
                    continue;
                  case 2:
                    ExpressionCompiler.EmittingVisitor.pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Ldc_I4_2);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 5 : 0;
                    continue;
                  case 3:
                    ExpressionCompiler.EmittingVisitor.pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Ldc_I4_3);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 6;
                    continue;
                  case 4:
                    ExpressionCompiler.EmittingVisitor.pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Ldc_I4_4);
                    num2 = 17;
                    continue;
                  case 5:
                    ExpressionCompiler.EmittingVisitor.pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Ldc_I4_5);
                    num2 = 3;
                    continue;
                  case 6:
                    ExpressionCompiler.EmittingVisitor.pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Ldc_I4_6);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 0 : 0;
                    continue;
                  case 7:
                    ExpressionCompiler.EmittingVisitor.pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Ldc_I4_7);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 7 : 6;
                    continue;
                  case 8:
                    goto label_8;
                  default:
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 1 : 1;
                    continue;
                }
              case 3:
                goto label_3;
              case 4:
                goto label_12;
              case 5:
                goto label_26;
              case 6:
                goto label_7;
              case 7:
                goto label_5;
              case 8:
              case 12:
                ExpressionCompiler.EmittingVisitor.SXGK2j880HQ732F9TT4x(il, OpCodes.Ldc_I4, i);
                num2 = 15;
                continue;
              case 9:
                goto label_17;
              case 10:
                if (i >= 128)
                {
                  num2 = 8;
                  continue;
                }
                goto case 13;
              case 11:
                goto label_9;
              case 13:
                ExpressionCompiler.EmittingVisitor.H9Mvr888xXRCxpXMtDAi(il, OpCodes.Ldc_I4_S, (sbyte) i);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 9 : 5;
                continue;
              case 14:
                goto label_23;
              case 15:
                goto label_32;
              case 16:
                goto label_30;
              case 17:
                goto label_28;
              case 18:
label_19:
                ExpressionCompiler.EmittingVisitor.pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Ldc_I4_M1);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 1 : 11;
                continue;
              default:
                goto label_20;
            }
          }
label_8:
          ExpressionCompiler.EmittingVisitor.pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Ldc_I4_8);
          num1 = 4;
        }
label_14:
        return;
label_3:
        return;
label_12:
        return;
label_26:
        return;
label_7:
        return;
label_5:
        return;
label_17:
        return;
label_9:
        return;
label_23:
        return;
label_32:
        return;
label_30:
        return;
label_28:
        return;
label_20:;
      }

      private static void EmitLoadLocalVariableAddress(object il, int location)
      {
        int num = 3;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_6;
            case 1:
              goto label_7;
            case 2:
              ((ILGenerator) il).Emit(OpCodes.Ldloca, location);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 1 : 1;
              continue;
            case 3:
              if (location >= 256)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 2 : 0;
                continue;
              }
              goto case 4;
            case 4:
              ((ILGenerator) il).Emit(OpCodes.Ldloca_S, (byte) location);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 0;
              continue;
            default:
              goto label_2;
          }
        }
label_6:
        return;
label_7:
        return;
label_2:;
      }

      private static void EmitLoadLocalVariable(object il, int location)
      {
        int num1 = 1;
        while (true)
        {
          int num2 = num1;
          while (true)
          {
            switch (num2)
            {
              case 1:
                if (location != 0)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 0 : 0;
                  continue;
                }
                goto case 2;
              case 2:
                ((ILGenerator) il).Emit(OpCodes.Ldloc_0);
                num2 = 12;
                continue;
              case 3:
                goto label_18;
              case 4:
                ExpressionCompiler.EmittingVisitor.pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Ldloc_2);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 6 : 3;
                continue;
              case 5:
                ExpressionCompiler.EmittingVisitor.pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Ldloc_1);
                num2 = 11;
                continue;
              case 6:
                goto label_3;
              case 7:
                goto label_5;
              case 8:
                ExpressionCompiler.EmittingVisitor.pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Ldloc_3);
                num2 = 7;
                continue;
              case 9:
                goto label_20;
              case 10:
                ExpressionCompiler.EmittingVisitor.w0Y04p88mj7xKRBHeHnB(il, OpCodes.Ldloc_S, (byte) location);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 2 : 9;
                continue;
              case 11:
                goto label_15;
              case 12:
                goto label_12;
              default:
                switch (location)
                {
                  case 1:
                    num2 = 5;
                    continue;
                  case 2:
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 4 : 3;
                    continue;
                  case 3:
                    num2 = 8;
                    continue;
                  default:
                    if (location >= 256)
                    {
                      ((ILGenerator) il).Emit(OpCodes.Ldloc, location);
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 3 : 1;
                      continue;
                    }
                    goto label_14;
                }
            }
          }
label_14:
          num1 = 10;
        }
label_18:
        return;
label_3:
        return;
label_5:
        return;
label_20:
        return;
label_15:
        return;
label_12:;
      }

      private static void EmitStoreLocalVariable(object il, int location)
      {
        int num1 = 8;
        while (true)
        {
          int num2 = num1;
          while (true)
          {
            switch (num2)
            {
              case 0:
                goto label_11;
              case 1:
                goto label_21;
              case 2:
                goto label_9;
              case 3:
                ExpressionCompiler.EmittingVisitor.pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Stloc_2);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 12 : 2;
                continue;
              case 4:
                ExpressionCompiler.EmittingVisitor.w0Y04p88mj7xKRBHeHnB(il, OpCodes.Stloc_S, (byte) location);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 0 : 0;
                continue;
              case 5:
                ExpressionCompiler.EmittingVisitor.pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Stloc_3);
                num2 = 6;
                continue;
              case 6:
                goto label_19;
              case 7:
                ExpressionCompiler.EmittingVisitor.pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Stloc_0);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 1 : 1;
                continue;
              case 8:
                if (location != 0)
                {
                  if (location != 1)
                  {
                    if (location == 2)
                    {
                      num2 = 3;
                      continue;
                    }
                    if (location == 3)
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 5 : 3;
                      continue;
                    }
                    if (location >= 256)
                    {
                      num2 = 9;
                      continue;
                    }
                    goto case 4;
                  }
                  else
                  {
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 10 : 1;
                    continue;
                  }
                }
                else
                  goto label_16;
              case 9:
                ((ILGenerator) il).Emit(OpCodes.Stloc, location);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 11 : 1;
                continue;
              case 10:
                ExpressionCompiler.EmittingVisitor.pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Stloc_1);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 2 : 2;
                continue;
              case 11:
                goto label_5;
              case 12:
                goto label_8;
              default:
                goto label_3;
            }
          }
label_16:
          num1 = 7;
        }
label_11:
        return;
label_21:
        return;
label_9:
        return;
label_19:
        return;
label_5:
        return;
label_8:
        return;
label_3:;
      }

      private static int EmitStoreLocalVariableAndLoadItsAddress(object il, Type type)
      {
        int num1 = 9;
        int nextLocalVarIndex;
        while (true)
        {
          int num2 = num1;
          while (true)
          {
            switch (num2)
            {
              case 1:
                ExpressionCompiler.EmittingVisitor.w0Y04p88mj7xKRBHeHnB(il, OpCodes.Ldloca_S, (byte) 2);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 5 : 10;
                continue;
              case 2:
                goto label_8;
              case 3:
                if (nextLocalVarIndex >= 256)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 0 : 0;
                  continue;
                }
                goto case 18;
              case 4:
                ExpressionCompiler.EmittingVisitor.SXGK2j880HQ732F9TT4x(il, OpCodes.Ldloca, nextLocalVarIndex);
                num2 = 20;
                continue;
              case 5:
                if (nextLocalVarIndex == 3)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 13 : 13;
                  continue;
                }
                goto case 3;
              case 6:
                ExpressionCompiler.EmittingVisitor.pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Stloc_0);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 7 : 5;
                continue;
              case 7:
                ((ILGenerator) il).Emit(OpCodes.Ldloca_S, (byte) 0);
                num2 = 19;
                continue;
              case 8:
                if (nextLocalVarIndex != 0)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 11 : 21;
                  continue;
                }
                goto case 6;
              case 9:
                nextLocalVarIndex = ((ILGenerator) il).GetNextLocalVarIndex(type);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 8 : 5;
                continue;
              case 10:
              case 12:
              case 15:
              case 19:
              case 20:
              case 22:
                goto label_21;
              case 11:
                ExpressionCompiler.EmittingVisitor.w0Y04p88mj7xKRBHeHnB(il, OpCodes.Ldloca_S, (byte) nextLocalVarIndex);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 15 : 4;
                continue;
              case 13:
                ((ILGenerator) il).Emit(OpCodes.Stloc_3);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 23 : 18;
                continue;
              case 16:
                ExpressionCompiler.EmittingVisitor.pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Stloc_1);
                num2 = 2;
                continue;
              case 17:
              case 21:
                if (nextLocalVarIndex == 1)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 16 : 16;
                  continue;
                }
                goto case 25;
              case 18:
                ((ILGenerator) il).Emit(OpCodes.Stloc_S, (byte) nextLocalVarIndex);
                num2 = 11;
                continue;
              case 23:
                goto label_5;
              case 24:
                ExpressionCompiler.EmittingVisitor.pO5qbK8vj7kF4Bx0nVcJ(il, OpCodes.Stloc_2);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 1 : 1;
                continue;
              case 25:
                if (nextLocalVarIndex == 2)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 9 : 24;
                  continue;
                }
                goto case 5;
              default:
                ExpressionCompiler.EmittingVisitor.SXGK2j880HQ732F9TT4x(il, OpCodes.Stloc, nextLocalVarIndex);
                num2 = 4;
                continue;
            }
          }
label_5:
          ExpressionCompiler.EmittingVisitor.w0Y04p88mj7xKRBHeHnB(il, OpCodes.Ldloca_S, (byte) 3);
          num1 = 12;
          continue;
label_8:
          ExpressionCompiler.EmittingVisitor.w0Y04p88mj7xKRBHeHnB(il, OpCodes.Ldloca_S, (byte) 1);
          num1 = 22;
        }
label_21:
        return nextLocalVarIndex;
      }

      static EmittingVisitor()
      {
        int num1 = 4;
        while (true)
        {
          switch (num1)
          {
            case 1:
              goto label_2;
            case 2:
              ExpressionCompiler.EmittingVisitor._decimalCtor = new Lazy<ConstructorInfo>((Func<ConstructorInfo>) (() =>
              {
                int num2 = 2;
                IEnumerator<ConstructorInfo> enumerator;
                while (true)
                {
                  switch (num2)
                  {
                    case 1:
                      goto label_4;
                    case 2:
                      enumerator = IntrospectionExtensions.GetTypeInfo(typeof (Decimal)).DeclaredConstructors.GetEnumerator();
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 1 : 1;
                      continue;
                    default:
                      goto label_2;
                  }
                }
label_2:
                return (ConstructorInfo) null;
label_4:
                ConstructorInfo constructorInfo;
                try
                {
label_6:
                  // ISSUE: reference to a compiler-generated method
                  if (ExpressionCompiler.EmittingVisitor.\u003C\u003Ec.exjDw8ZOtOVleXT9U3X5((object) enumerator))
                    goto label_9;
                  else
                    goto label_7;
label_5:
                  ConstructorInfo current;
                  int num3;
                  while (true)
                  {
                    switch (num3)
                    {
                      case 1:
                        goto label_9;
                      case 2:
                        constructorInfo = current;
                        num3 = 3;
                        continue;
                      case 3:
                        goto label_3;
                      case 4:
                        if (current.GetParameters().Length == 5)
                        {
                          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 2 : 0;
                          continue;
                        }
                        goto label_6;
                      case 5:
                        goto label_2;
                      default:
                        goto label_6;
                    }
                  }
label_7:
                  num3 = 5;
                  goto label_5;
label_9:
                  current = enumerator.Current;
                  num3 = 4;
                  goto label_5;
                }
                finally
                {
                  if (enumerator != null)
                  {
                    int num4 = 0;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
                      num4 = 0;
                    while (true)
                    {
                      switch (num4)
                      {
                        case 1:
                          goto label_17;
                        default:
                          // ISSUE: reference to a compiler-generated method
                          ExpressionCompiler.EmittingVisitor.\u003C\u003Ec.eit1wvZOwEaG5UfHcZjY((object) enumerator);
                          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 1 : 1;
                          continue;
                      }
                    }
                  }
label_17:;
                }
label_3:
                return constructorInfo;
              }));
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 1 : 1;
              continue;
            case 3:
              ExpressionCompiler.EmittingVisitor._getTypeFromHandleMethod = ExpressionCompiler.EmittingVisitor.GBShgY88Mvw21FLi6O4B((object) new Func<RuntimeTypeHandle, Type>(Type.GetTypeFromHandle));
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 0 : 0;
              continue;
            case 4:
              ExpressionCompiler.EmittingVisitor.kuP2yh88ytbBD3rvZgIa();
              num1 = 3;
              continue;
            default:
              ExpressionCompiler.EmittingVisitor._objectEqualsMethod = ExpressionCompiler.EmittingVisitor.GBShgY88Mvw21FLi6O4B((object) new Func<object, object, bool>(object.Equals));
              num1 = 2;
              continue;
          }
        }
label_2:;
      }

      internal static object GNKm9i8vrhrfeYTW9WQI([In] Type obj0) => (object) IntrospectionExtensions.GetTypeInfo(obj0);

      internal static Type U4TPVi8vg9UgNc6Skdyl([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

      internal static bool fXH2wl8v53gf6fwkZ1cA([In] Type obj0, [In] Type obj1) => obj0 == obj1;

      internal static void pO5qbK8vj7kF4Bx0nVcJ([In] object obj0, [In] OpCode obj1) => ((ILGenerator) obj0).Emit(obj1);

      internal static void knkv2X8vYB8jrNg6F4Ng([In] object obj0, [In] OpCode obj1, [In] double obj2) => ((ILGenerator) obj0).Emit(obj1, obj2);

      internal static int iZFBo28vLdpJZ0EgaTu9([In] object obj0, Type exprType) => ExpressionCompiler.EmittingVisitor.InitValueTypeVariable(obj0, exprType);

      internal static bool v09wKt8vdkMs9RK4cdbw() => ExpressionCompiler.EmittingVisitor.KMULmi8v997Yn3cUEGre == null;

      internal static ExpressionCompiler.EmittingVisitor RsWPEa8vljDaDYU1WWXW() => (ExpressionCompiler.EmittingVisitor) ExpressionCompiler.EmittingVisitor.KMULmi8v997Yn3cUEGre;

      internal static void J2osBm8vUaIa3b3WwLmF([In] object obj0, [In] OpCode obj1, [In] Type obj2) => ((ILGenerator) obj0).Emit(obj1, obj2);

      internal static bool FmvXlm8vsuRxLNJZHiE0([In] object obj0, [In] object obj1) => ExpressionCompiler.IsClosureBoundConstant(obj0, (TypeInfo) obj1);

      internal static void sAHEtL8vcqrjhyn5Thl8([In] object obj0, int location) => ExpressionCompiler.EmittingVisitor.EmitLoadLocalVariable(obj0, location);

      internal static bool PjFnO38vzkxjGZ63tFdS(Type type) => type.IsValueType();

      internal static void UviTP688Flh13scInDsp([In] object obj0, [In] OpCode obj1, [In] object obj2) => ((ILGenerator) obj0).Emit(obj1, (string) obj2);

      internal static void cr9PXh88BxyHDixSqTcC([In] object obj0, [In] OpCode obj1, [In] object obj2) => ((ILGenerator) obj0).Emit(obj1, (MethodInfo) obj2);

      internal static bool fokGig88WnZPreE4vi54([In] object obj0, [In] object obj1, Type constValueType) => ExpressionCompiler.EmittingVisitor.TryEmitNumberConstant(obj0, obj1, constValueType);

      internal static Type Y3ZBnF88oFL48nB4EbDT([In] Type obj0) => Nullable.GetUnderlyingType(obj0);

      internal static bool aiU5Py88bf4bvp4KvZlA([In] Type obj0, [In] Type obj1) => obj0 != obj1;

      internal static void EeScqP88h5wEXIWJQdtf([In] object obj0, [In] OpCode obj1, [In] object obj2) => ((ILGenerator) obj0).Emit(obj1, (ConstructorInfo) obj2);

      internal static void xSvlU588GkZCQcYNHxR9([In] object obj0, int i) => ExpressionCompiler.EmittingVisitor.EmitLoadConstantInt(obj0, i);

      internal static void cM3sss88EePhWUr2IKkE([In] object obj0, [In] OpCode obj1, [In] long obj2) => ((ILGenerator) obj0).Emit(obj1, obj2);

      internal static void W7pcad88fNEKh1EdX85b(Decimal value, [In] object obj1) => ExpressionCompiler.EmittingVisitor.EmitDecimalConstant(value, obj1);

      internal static void wCQlP088QNaoX0PDRj9h([In] object obj0, [In] OpCode obj1, [In] float obj2) => ((ILGenerator) obj0).Emit(obj1, obj2);

      internal static void sRdP0O88C2XPgBIGfmr9([In] object obj0, [In] OpCode obj1, [In] object obj2) => ((ILGenerator) obj0).Emit(obj1, (FieldInfo) obj2);

      internal static int biffFd88v5EVI03AcKVJ([In] object obj0, Type t) => ((ILGenerator) obj0).GetNextLocalVarIndex(t);

      internal static void n5iKim888ZeKefyA2HBg([In] object obj0, int location) => ExpressionCompiler.EmittingVisitor.EmitStoreLocalVariable(obj0, location);

      internal static Decimal xafoql88ZtB6XHGZK6dR([In] Decimal obj0, [In] Decimal obj1) => obj0 % obj1;

      internal static bool e7eD7j88uPJ67KFlpEWt([In] Decimal obj0, [In] Decimal obj1) => obj0 == obj1;

      internal static bool fqmiM488Il8d7HP1lXaU([In] Decimal obj0, [In] Decimal obj1) => obj0 >= obj1;

      internal static int BQ35wh88VnygI3LvNAkj([In] Decimal obj0) => Decimal.ToInt32(obj0);

      internal static object w6M2Rh88SoDltf7X7pW3(Type type, Type paramType) => (object) type.FindSingleParamConstructor(paramType);

      internal static long oVcLfh88iS6O3DRXOoA1([In] Decimal obj0) => Decimal.ToInt64(obj0);

      internal static object m3LAa488ReLmpwmaDB7T([In] object obj0, [In] object obj1) => (object) ((TypeInfo) obj0).GetDeclaredField((string) obj1);

      internal static object Fn0VLG88qZFRYO4uCytV(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static void zd5dF088K7mOoR6NMGKO([In] object obj0, int location) => ExpressionCompiler.EmittingVisitor.EmitLoadLocalVariableAddress(obj0, location);

      internal static Type Nc9dVJ88XPZkULo3u0Bi([In] object obj0) => ((MemberInfo) obj0).DeclaringType;

      internal static object fBt6Va88T9YSt8ARF6Or(Type propHolderType, [In] object obj1) => (object) propHolderType.FindPropertySetMethod((string) obj1);

      internal static bool wl8EMB88kTNmCG4OyVv6([In] object obj0) => ((MethodBase) obj0).IsVirtual;

      internal static bool deLCCA88neVcu5oRhSLo([In] object obj0) => ((FieldInfo) obj0).IsStatic;

      internal static object JBBhye88OM33sBK79Znn([In] object obj0) => (object) ((IndexExpression) obj0).Indexer;

      internal static object uoSAA2882sdDqJKDnujY(Type type, [In] object obj1) => (object) type.FindMethod((string) obj1);

      internal static Type otgWhy88e6vv3pdqxkCd([In] object obj0) => ((ParameterInfo) obj0).ParameterType;

      internal static bool R9kTwj88PSmNdg9VwAeW(Type type) => type.IsPrimitive();

      internal static object HG4E25881F3PGheegRQI([In] object obj0) => (object) ((BinaryExpression) obj0).Left;

      internal static Type XTROpG88NXfDY02TA2TM([In] object obj0) => ((Expression) obj0).Type;

      internal static object vGqfcq883GxgYQw8sWuO([In] object obj0) => (object) ((BinaryExpression) obj0).Right;

      internal static object gsLJHN88pa2A268EfMbs([In] object obj0) => (object) ((MemberInfo) obj0).Name;

      internal static bool n6g7oS88aQ3OpAmxEDgB([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

      internal static object ld8c6R88DVMhn1v9af95([In] object obj0) => (object) ((MethodBase) obj0).GetParameters();

      internal static bool C53Pi688tdxbqC7lWMQv([In] object obj0) => ((MethodBase) obj0).IsSpecialName;

      internal static bool cqpyYd88wuAuE70gaROo([In] object obj0, [In] object obj1) => (MethodInfo) obj0 == (MethodInfo) obj1;

      internal static bool vfkSi3884O8weMQFqJZm(Type type) => type.IsUnsigned();

      internal static ExpressionType Y0Yi9m8863JbP6luaq0W([In] object obj0) => ((Expression) obj0).NodeType;

      internal static object xVh8Zv88HC6mNl7BAaL0([In] object obj0) => ((ConstantExpression) obj0).Value;

      internal static object jLpj7J88AETGFMXf5kR6([In] object obj0) => (object) ExpressionCompiler.EmittingVisitor.TryReduceCondition(obj0);

      internal static Type ecKKQm8877KnuCCgvTdn([In] object obj0) => ((MethodInfo) obj0).ReturnType;

      internal static void H9Mvr888xXRCxpXMtDAi([In] object obj0, [In] OpCode obj1, [In] sbyte obj2) => ((ILGenerator) obj0).Emit(obj1, obj2);

      internal static void SXGK2j880HQ732F9TT4x([In] object obj0, [In] OpCode obj1, [In] int obj2) => ((ILGenerator) obj0).Emit(obj1, obj2);

      internal static void w0Y04p88mj7xKRBHeHnB([In] object obj0, [In] OpCode obj1, [In] byte obj2) => ((ILGenerator) obj0).Emit(obj1, obj2);

      internal static void kuP2yh88ytbBD3rvZgIa() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static object GBShgY88Mvw21FLi6O4B([In] object obj0) => (object) ((Delegate) obj0).Method;
    }
  }
}
