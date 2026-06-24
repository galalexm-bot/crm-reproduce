// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Threading.Extensions.MethodInfoExtensions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Concurrent;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace EleWise.ELMA.Threading.Extensions
{
  /// <summary>
  /// Методы расширения для <see cref="T:System.Reflection.MethodInfo" />
  /// </summary>
  public static class MethodInfoExtensions
  {
    private static readonly MethodInfo InvokeAsyncGenericInfo;
    private static readonly ConcurrentDictionary<Type, MethodInfo> InvokeAsyncGenericConstructedMethodCache;
    private static readonly MethodInfo InvokeValueAsyncGenericInfo;
    private static readonly ConcurrentDictionary<Type, MethodInfo> InvokeValueAsyncGenericConstructedMethodCache;
    internal static MethodInfoExtensions Hkk2XMBRJZUpEygOnNGA;

    /// <summary>Выполнить метод асинхронно</summary>
    /// <param name="method">Информация о методе</param>
    /// <param name="target">Экземпляр владельца вызываемого метода</param>
    /// <param name="arguments">Список аргументов</param>
    public static Task InvokeActionAsync(
      this MethodInfo method,
      object target,
      params object[] arguments)
    {
      int num = 4;
      // ISSUE: variable of a compiler-generated type
      MethodInfoExtensions.\u003CInvokeActionAsync\u003Ed__4 stateMachine;
      AsyncTaskMethodBuilder tBuilder;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            tBuilder.Start<MethodInfoExtensions.\u003CInvokeActionAsync\u003Ed__4>(ref stateMachine);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 1 : 1;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated field
            stateMachine.target = target;
            num = 5;
            continue;
          case 4:
            // ISSUE: reference to a compiler-generated field
            stateMachine.method = method;
            num = 3;
            continue;
          case 5:
            // ISSUE: reference to a compiler-generated field
            stateMachine.arguments = arguments;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 0;
            continue;
          case 6:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E1__state = -1;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 4 : 7;
            continue;
          case 7:
            // ISSUE: reference to a compiler-generated field
            tBuilder = stateMachine.\u003C\u003Et__builder;
            num = 2;
            continue;
          default:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003Et__builder = AsyncTaskMethodBuilder.Create();
            num = 6;
            continue;
        }
      }
label_5:
      // ISSUE: reference to a compiler-generated field
      return stateMachine.\u003C\u003Et__builder.Task;
    }

    /// <summary>Выполнить метод асинхронно</summary>
    /// <param name="method">Информация о методе</param>
    /// <param name="target">Экземпляр владельца вызываемого метода</param>
    /// <param name="arguments">Список аргументов</param>
    public static ValueTask InvokeValueActionAsync(
      this MethodInfo method,
      object target,
      params object[] arguments)
    {
      int num = 5;
      // ISSUE: variable of a compiler-generated type
      MethodInfoExtensions.\u003CInvokeValueActionAsync\u003Ed__5 stateMachine;
      AsyncValueTaskMethodBuilder tBuilder;
      while (true)
      {
        switch (num)
        {
          case 1:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003Et__builder = AsyncValueTaskMethodBuilder.Create();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 0;
            continue;
          case 2:
            tBuilder.Start<MethodInfoExtensions.\u003CInvokeValueActionAsync\u003Ed__5>(ref stateMachine);
            num = 7;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated field
            tBuilder = stateMachine.\u003C\u003Et__builder;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 2 : 2;
            continue;
          case 4:
            // ISSUE: reference to a compiler-generated field
            stateMachine.target = target;
            num = 6;
            continue;
          case 5:
            // ISSUE: reference to a compiler-generated field
            stateMachine.method = method;
            num = 4;
            continue;
          case 6:
            // ISSUE: reference to a compiler-generated field
            stateMachine.arguments = arguments;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 1 : 1;
            continue;
          case 7:
            goto label_9;
          default:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E1__state = -1;
            num = 3;
            continue;
        }
      }
label_9:
      // ISSUE: reference to a compiler-generated field
      return stateMachine.\u003C\u003Et__builder.Task;
    }

    /// <summary>Выполнить метод асинхронно</summary>
    /// <param name="method">Информация о методе</param>
    /// <param name="target">Экземпляр владельца вызываемого метода</param>
    /// <param name="arguments">Список аргументов</param>
    /// <returns>Результат</returns>
    public static Task<object> InvokeFunctionAsync(
      this MethodInfo method,
      object target,
      params object[] arguments)
    {
      Contract.ArgumentNotNull((object) method, z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1360331293 ^ 1360273163));
      Contract.ArgumentNotNull(target, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138160520 ^ -2138087586));
      Type resultType = method.ReturnType.IsAsync() ? method.ReturnType.GetGenericArguments()[0] : method.ReturnType;
      // ISSUE: reference to a compiler-generated method
      return (Task<object>) MethodInfoExtensions.InvokeAsyncGenericConstructedMethodCache.GetOrAdd(resultType, (Func<Type, MethodInfo>) (type => (MethodInfo) MethodInfoExtensions.\u003C\u003Ec__DisplayClass6_0.QeipL3QvYD4QfKaeW0St((object) MethodInfoExtensions.InvokeAsyncGenericInfo, (object) new Type[1]
      {
        resultType
      }))).Invoke((object) null, new object[3]
      {
        (object) method,
        target,
        (object) arguments
      });
    }

    /// <summary>Выполнить метод асинхронно</summary>
    /// <param name="method">Информация о методе</param>
    /// <param name="target">Экземпляр владельца вызываемого метода</param>
    /// <param name="arguments">Список аргументов</param>
    /// <returns>Результат</returns>
    public static ValueTask<object> InvokeValueFunctionAsync(
      this MethodInfo method,
      object target,
      params object[] arguments)
    {
      Contract.ArgumentNotNull((object) method, z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-122002947 ^ 121930516));
      Contract.ArgumentNotNull(target, z2jc63fLkugS1X8Q9N.tE1kD1vbB(901793403 ^ 901864285));
      Type resultType = method.ReturnType.IsAsync() ? method.ReturnType.GetGenericArguments()[0] : method.ReturnType;
      // ISSUE: reference to a compiler-generated method
      return (ValueTask<object>) MethodInfoExtensions.InvokeValueAsyncGenericConstructedMethodCache.GetOrAdd(resultType, (Func<Type, MethodInfo>) (type => (MethodInfo) MethodInfoExtensions.\u003C\u003Ec__DisplayClass7_0.Q7foIdQvz6har2fiDvH5((object) MethodInfoExtensions.InvokeValueAsyncGenericInfo, (object) new Type[1]
      {
        resultType
      }))).Invoke((object) null, new object[3]
      {
        (object) method,
        target,
        (object) arguments
      });
    }

    private static Task<object> InvokeAsyncGeneric<TResult>(
      object method,
      object target,
      params object[] arguments)
    {
      // ISSUE: variable of a compiler-generated type
      MethodInfoExtensions.\u003CInvokeAsyncGeneric\u003Ed__8<TResult> stateMachine;
      // ISSUE: reference to a compiler-generated field
      stateMachine.method = (MethodInfo) method;
      // ISSUE: reference to a compiler-generated field
      stateMachine.target = target;
      // ISSUE: reference to a compiler-generated field
      stateMachine.arguments = arguments;
      // ISSUE: reference to a compiler-generated field
      stateMachine.\u003C\u003Et__builder = AsyncTaskMethodBuilder<object>.Create();
      // ISSUE: reference to a compiler-generated field
      stateMachine.\u003C\u003E1__state = -1;
      // ISSUE: reference to a compiler-generated field
      stateMachine.\u003C\u003Et__builder.Start<MethodInfoExtensions.\u003CInvokeAsyncGeneric\u003Ed__8<TResult>>(ref stateMachine);
      // ISSUE: reference to a compiler-generated field
      return stateMachine.\u003C\u003Et__builder.Task;
    }

    private static ValueTask<object> InvokeValueAsyncGeneric<TResult>(
      object method,
      object target,
      params object[] arguments)
    {
      // ISSUE: variable of a compiler-generated type
      MethodInfoExtensions.\u003CInvokeValueAsyncGeneric\u003Ed__9<TResult> stateMachine;
      // ISSUE: reference to a compiler-generated field
      stateMachine.method = (MethodInfo) method;
      // ISSUE: reference to a compiler-generated field
      stateMachine.target = target;
      // ISSUE: reference to a compiler-generated field
      stateMachine.arguments = arguments;
      // ISSUE: reference to a compiler-generated field
      stateMachine.\u003C\u003Et__builder = AsyncValueTaskMethodBuilder<object>.Create();
      // ISSUE: reference to a compiler-generated field
      stateMachine.\u003C\u003E1__state = -1;
      // ISSUE: reference to a compiler-generated field
      stateMachine.\u003C\u003Et__builder.Start<MethodInfoExtensions.\u003CInvokeValueAsyncGeneric\u003Ed__9<TResult>>(ref stateMachine);
      // ISSUE: reference to a compiler-generated field
      return stateMachine.\u003C\u003Et__builder.Task;
    }

    static MethodInfoExtensions()
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
              MethodInfoExtensions.lBjR9kBRlPThsRLyLyet();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 0;
              continue;
            case 2:
              MethodInfoExtensions.InvokeValueAsyncGenericConstructedMethodCache = new ConcurrentDictionary<Type, MethodInfo>();
              num2 = 3;
              continue;
            case 3:
              goto label_3;
            case 4:
              MethodInfoExtensions.InvokeAsyncGenericConstructedMethodCache = new ConcurrentDictionary<Type, MethodInfo>();
              num2 = 5;
              continue;
            case 5:
              MethodInfoExtensions.InvokeValueAsyncGenericInfo = typeof (MethodInfoExtensions).GetMethod((string) MethodInfoExtensions.QxmKduBRrugaqDMFRVkC(647913418 ^ 647971476), BindingFlags.Static | BindingFlags.NonPublic);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 2;
              continue;
            default:
              goto label_7;
          }
        }
label_7:
        MethodInfoExtensions.InvokeAsyncGenericInfo = typeof (MethodInfoExtensions).GetMethod((string) MethodInfoExtensions.QxmKduBRrugaqDMFRVkC(1514961705 ^ 1515021855), BindingFlags.Static | BindingFlags.NonPublic);
        num1 = 4;
      }
label_3:;
    }

    internal static bool qmMocbBR9NrYlygGJT4b() => MethodInfoExtensions.Hkk2XMBRJZUpEygOnNGA == null;

    internal static MethodInfoExtensions Pt3edKBRddNSElu0ikOI() => MethodInfoExtensions.Hkk2XMBRJZUpEygOnNGA;

    internal static void lBjR9kBRlPThsRLyLyet() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object QxmKduBRrugaqDMFRVkC(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
  }
}
