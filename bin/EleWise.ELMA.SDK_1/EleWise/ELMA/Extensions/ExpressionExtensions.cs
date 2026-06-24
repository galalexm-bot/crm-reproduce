// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.ExpressionExtensions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Extensions
{
  /// <summary>Расширения для работы с выражениями</summary>
  public static class ExpressionExtensions
  {
    internal static ExpressionExtensions hBgJUNG6hRyaPtDdvXxo;

    public static void InvokeGenericMethod<T>(
      this T target,
      Expression<Action<T>> expression,
      Type genericParametr)
      where T : class
    {
      MethodInfo methodInfo1;
      object[] arguments;
      ExpressionExtensions.GetInvokeMethodInfo((LambdaExpression) expression, out object _, out methodInfo1, out arguments);
      MethodInfo methodInfo2 = methodInfo1.IsGenericMethod ? methodInfo1.GetGenericMethodDefinition().MakeGenericMethod(genericParametr) : throw new ArgumentException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1886646897 ^ -1886650229), z2jc63fLkugS1X8Q9N.tE1kD1vbB(901793403 ^ 902055449));
      if (methodInfo1.IsStatic)
      {
        if (arguments.Length != 0)
          arguments[0] = (object) target;
        target = default (T);
      }
      // ISSUE: variable of a boxed type
      __Boxed<T> local = (object) target;
      object[] parameters = arguments;
      methodInfo2.Invoke((object) local, parameters);
    }

    public static object InvokeGenericFunction<T>(
      this T target,
      Expression<Func<T, object>> expression,
      Type genericParametr)
      where T : class
    {
      MethodInfo methodInfo1;
      object[] arguments;
      ExpressionExtensions.GetInvokeMethodInfo((LambdaExpression) expression, out object _, out methodInfo1, out arguments);
      MethodInfo methodInfo2 = methodInfo1.IsGenericMethod ? methodInfo1.GetGenericMethodDefinition().MakeGenericMethod(genericParametr) : throw new ArgumentException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1360331293 ^ 1360334617), z2jc63fLkugS1X8Q9N.tE1kD1vbB(2008901894 << 3 ^ -1108391854));
      if (methodInfo1.IsStatic)
      {
        if (arguments.Length != 0)
          arguments[0] = (object) target;
        target = default (T);
      }
      // ISSUE: variable of a boxed type
      __Boxed<T> local = (object) target;
      object[] parameters = arguments;
      return methodInfo2.Invoke((object) local, parameters);
    }

    public static MethodInfo GetGenericMethod<T>(
      this T target,
      Expression<Action<T>> expression,
      Type genericParametr)
      where T : class
    {
      MethodInfo methodInfo;
      ExpressionExtensions.GetInvokeMethodInfo((LambdaExpression) expression, out object _, out methodInfo, out object[] _);
      return methodInfo.IsGenericMethod ? methodInfo.GetGenericMethodDefinition().MakeGenericMethod(genericParametr) : throw new ArgumentException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1033719030 - 2012070891 ^ -978353137), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-398663332 ^ -398925506));
    }

    public static object GetValue(this Expression expression, bool causeError)
    {
      int num = 5;
      MemberExpression memberExpression;
      ConstantExpression constantExpression;
      while (true)
      {
        switch (num)
        {
          case 1:
            memberExpression = expression as MemberExpression;
            num = 3;
            continue;
          case 2:
            goto label_5;
          case 3:
            if (memberExpression == null)
            {
              num = 6;
              continue;
            }
            goto label_4;
          case 4:
            if (constantExpression == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 1 : 0;
              continue;
            }
            goto label_5;
          case 5:
            constantExpression = expression as ConstantExpression;
            num = 4;
            continue;
          case 6:
            if (causeError)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      throw new ArgumentException((string) ExpressionExtensions.nUVtq0G6Qb1uiPIc3to9((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-710283084 ^ -537863435 ^ 173878001), (object) expression.GetType()));
label_3:
      return (object) null;
label_4:
      return ExpressionExtensions.SKo2hJG6vojs2KWI4aOK(ExpressionExtensions.fNYETkG6C4ZXOGZlsWaV((object) memberExpression), causeError);
label_5:
      return ExpressionExtensions.G29n4JG6fPrjp0PE4SE7((object) constantExpression);
    }

    public static void GetInvokeMethodInfo(
      LambdaExpression expression,
      out object target,
      out MethodInfo methodInfo,
      out object[] arguments)
    {
      int num1 = 2;
      while (true)
      {
        int num2 = num1;
        MethodCallExpression body;
        object[] array;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_12;
            case 1:
              goto label_4;
            case 2:
              body = expression.Body as MethodCallExpression;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 1 : 1;
              continue;
            case 3:
              arguments = array;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 0 : 0;
              continue;
            case 4:
              methodInfo = body.Method;
              num2 = 5;
              continue;
            case 5:
              ReadOnlyCollection<Expression> arguments1 = body.Arguments;
              // ISSUE: reference to a compiler-generated field
              Func<Expression, object> func = ExpressionExtensions.\u003C\u003Ec.\u003C\u003E9__4_0;
              Func<Expression, object> selector;
              if (func == null)
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                ExpressionExtensions.\u003C\u003Ec.\u003C\u003E9__4_0 = selector = (Func<Expression, object>) (ae => ExpressionExtensions.\u003C\u003Ec.SJSW5q8hIkyGB02iDEYQ((object) ae, false));
              }
              else
                goto label_15;
label_14:
              array = arguments1.Select<Expression, object>(selector).ToArray<object>();
              num2 = 3;
              continue;
label_15:
              selector = func;
              goto label_14;
            case 6:
              target = (object) body.Object;
              num2 = 4;
              continue;
            case 7:
              goto label_9;
            default:
              goto label_6;
          }
        }
label_4:
        if (body != null)
          num1 = 6;
        else
          goto label_9;
      }
label_12:
      return;
label_6:
      return;
label_9:
      throw new ArgumentException((string) ExpressionExtensions.DJ6HUQG68ndUg1JeTkCn(1470440286 ^ 1470178230), (string) ExpressionExtensions.DJ6HUQG68ndUg1JeTkCn(-1867198571 ^ -1867201903));
    }

    internal static object G29n4JG6fPrjp0PE4SE7([In] object obj0) => ((ConstantExpression) obj0).Value;

    internal static object nUVtq0G6Qb1uiPIc3to9([In] object obj0, [In] object obj1) => (object) (obj0.ToString() + obj1);

    internal static object fNYETkG6C4ZXOGZlsWaV([In] object obj0) => (object) ((MemberExpression) obj0).Expression;

    internal static object SKo2hJG6vojs2KWI4aOK([In] object obj0, bool causeError) => ((Expression) obj0).GetValue(causeError);

    internal static bool nBXA8VG6G9LHScKGpN7H() => ExpressionExtensions.hBgJUNG6hRyaPtDdvXxo == null;

    internal static ExpressionExtensions dxGVSBG6EgfRaXPTnne9() => ExpressionExtensions.hBgJUNG6hRyaPtDdvXxo;

    internal static object DJ6HUQG68ndUg1JeTkCn(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
  }
}
