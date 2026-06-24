// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Helpers.CompletedTask`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System.Threading.Tasks;

namespace EleWise.ELMA.Helpers
{
  /// <summary>
  /// Класс-помощник по асинхронным задачам - предоставляет уже выполненную задачу.
  /// </summary>
  /// <remarks>
  /// Код позаимстован из Samples for Parallel Programming with the .NET Framework 4
  /// </remarks>
  public static class CompletedTask<TResult>
  {
    /// <summary>Получить уже выполненную задачу.</summary>
    public static readonly Task<TResult> Default;
    internal static object EY3i2JhYHMkAphMWRY7M;

    /// <summary>Ctor - инициализация выполненной задачи.</summary>
    static CompletedTask()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            TaskCompletionSource<TResult> completionSource = new TaskCompletionSource<TResult>();
            completionSource.TrySetResult(default (TResult));
            CompletedTask<TResult>.Default = completionSource.Task;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 0 : 0;
            continue;
          case 2:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static bool mrlZCfhYAo1tvBKr6ao9() => CompletedTask<TResult>.EY3i2JhYHMkAphMWRY7M == null;

    internal static object a2beBohY7oGWFPoyHa83() => CompletedTask<TResult>.EY3i2JhYHMkAphMWRY7M;
  }
}
