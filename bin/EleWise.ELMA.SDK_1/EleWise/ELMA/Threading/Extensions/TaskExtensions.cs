// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Threading.Extensions.TaskExtensions
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
  /// Методы расширения для <see cref="T:System.Threading.Tasks.Task" />
  /// </summary>
  public static class TaskExtensions
  {
    private static readonly MethodInfo FromResultGenericInfo;
    private static readonly ConcurrentDictionary<Type, MethodInfo> FromResultGenericConstructedMethodCache;
    internal static TaskExtensions yD7KbuBRgdJqZ8uBiXm7;

    /// <summary>
    /// Сформировать объект <see cref="T:System.Threading.Tasks.Task`1" />
    /// </summary>
    /// <param name="result">Результат, который надо привести к задаче</param>
    /// <param name="returnType">Тип вовзращаемого результата</param>
    /// <returns>Объект со сформированной задачей</returns>
    public static object FromResult(object result, Type returnType)
    {
      int num = 1;
      Type returnType1;
      while (true)
      {
        switch (num)
        {
          case 1:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 0;
            continue;
          case 2:
            TaskExtensions.gkkajfBRLidsHQlM3MKT((object) returnType1, TaskExtensions.pVWlgoBRYTligrTpcLdl(1470998129 - 231418599 ^ 1239639578));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 1 : 3;
            continue;
          case 3:
            goto label_3;
          default:
            returnType1 = returnType;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 2 : 2;
            continue;
        }
      }
label_3:
      // ISSUE: reference to a compiler-generated method
      return TaskExtensions.cK0SPABRUyL68bTvSsFO((object) TaskExtensions.FromResultGenericConstructedMethodCache.GetOrAdd(returnType1, (Func<Type, MethodInfo>) (type => (MethodInfo) TaskExtensions.\u003C\u003Ec__DisplayClass2_0.dR4GajQ8CTySE1sgjbhT((object) TaskExtensions.FromResultGenericInfo, (object) new Type[1]
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
    private static Task<TResult> FromResultGeneric<TResult>(object result) => Task.FromResult<TResult>((TResult) result);

    static TaskExtensions()
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            TaskExtensions.FromResultGenericInfo = typeof (TaskExtensions).GetMethod((string) TaskExtensions.pVWlgoBRYTligrTpcLdl(-138018305 ^ -137946025), BindingFlags.Static | BindingFlags.NonPublic);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 0 : 0;
            continue;
          case 3:
            TaskExtensions.QbOa3yBRsH6Anb5xofnF();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 2 : 1;
            continue;
          default:
            TaskExtensions.FromResultGenericConstructedMethodCache = new ConcurrentDictionary<Type, MethodInfo>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 1 : 1;
            continue;
        }
      }
label_2:;
    }

    internal static object pVWlgoBRYTligrTpcLdl(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void gkkajfBRLidsHQlM3MKT([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static object cK0SPABRUyL68bTvSsFO([In] object obj0, [In] object obj1, [In] object obj2) => ((MethodBase) obj0).Invoke(obj1, (object[]) obj2);

    internal static bool MFiHKvBR5CurWeSxLTZ6() => TaskExtensions.yD7KbuBRgdJqZ8uBiXm7 == null;

    internal static TaskExtensions XlehtxBRjW4IoRR10YNh() => TaskExtensions.yD7KbuBRgdJqZ8uBiXm7;

    internal static void QbOa3yBRsH6Anb5xofnF() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
