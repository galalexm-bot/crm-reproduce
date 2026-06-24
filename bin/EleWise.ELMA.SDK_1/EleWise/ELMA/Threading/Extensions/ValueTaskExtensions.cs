// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Threading.Extensions.ValueTaskExtensions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Concurrent;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace EleWise.ELMA.Threading.Extensions
{
  /// <summary>
  /// Методы расширения для <see cref="T:System.Threading.Tasks.ValueTask" /> и <see cref="T:System.Threading.Tasks.ValueTask`1" />
  /// </summary>
  public static class ValueTaskExtensions
  {
    private static readonly MethodInfo FromResultGenericInfo;
    private static readonly ConcurrentDictionary<Type, MethodInfo> FromResultGenericConstructedMethodCache;
    internal static ValueTaskExtensions ebbqkwBRcGcTP2aSZ824;

    /// <summary>
    /// Сформировать объект <see cref="T:System.Threading.Tasks.ValueTask`1" />
    /// </summary>
    /// <param name="result">Результат, который надо привести к задаче</param>
    /// <param name="returnType">Тип вовзращаемого результата</param>
    /// <returns>Объект со сформированной задачей</returns>
    public static object FromResult(object result, Type returnType)
    {
      int num = 2;
      Type returnType1;
      while (true)
      {
        switch (num)
        {
          case 1:
            returnType1 = returnType;
            num = 3;
            continue;
          case 2:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 1 : 1;
            continue;
          case 3:
            ValueTaskExtensions.imattcBqWBxSrrwnQA5V((object) returnType1, ValueTaskExtensions.TRsQxOBqB5qaOWHwGUMO(1925118608 << 2 ^ -889522224));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      // ISSUE: reference to a compiler-generated method
      return ValueTaskExtensions.STpe4RBqonEFC8uDxRAX((object) ValueTaskExtensions.FromResultGenericConstructedMethodCache.GetOrAdd(returnType1, (Func<Type, MethodInfo>) (type => (MethodInfo) ValueTaskExtensions.\u003C\u003Ec__DisplayClass2_0.tXBoIeQ8I2NyxpE1f0TN((object) ValueTaskExtensions.FromResultGenericInfo, (object) new Type[1]
      {
        returnType1
      }))), (object) null, (object) new object[1]{ result });
    }

    /// <summary>
    /// Получить завершенную задачу с указанным типом результата
    /// </summary>
    /// <typeparam name="TResult">Тип результата</typeparam>
    /// <param name="result">Результата</param>
    /// <returns>Завершенная задача</returns>
    private static ValueTask<TResult> FromResultGeneric<TResult>(object result) => new ValueTask<TResult>((TResult) result);

    static ValueTaskExtensions()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            ValueTaskExtensions.FromResultGenericConstructedMethodCache = new ConcurrentDictionary<Type, MethodInfo>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 2 : 1;
            continue;
          default:
            ValueTaskExtensions.FromResultGenericInfo = typeof (ValueTaskExtensions).GetMethod((string) ValueTaskExtensions.TRsQxOBqB5qaOWHwGUMO(1669212571 ^ 1669280819), BindingFlags.Static | BindingFlags.NonPublic);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 3;
            continue;
        }
      }
label_2:;
    }

    internal static object TRsQxOBqB5qaOWHwGUMO(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void imattcBqWBxSrrwnQA5V([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static object STpe4RBqonEFC8uDxRAX([In] object obj0, [In] object obj1, [In] object obj2) => ((MethodBase) obj0).Invoke(obj1, (object[]) obj2);

    internal static bool B0uhirBRzSJyZtsI3QAB() => ValueTaskExtensions.ebbqkwBRcGcTP2aSZ824 == null;

    internal static ValueTaskExtensions XJeljIBqFfFntOlWgZoE() => ValueTaskExtensions.ebbqkwBRcGcTP2aSZ824;
  }
}
