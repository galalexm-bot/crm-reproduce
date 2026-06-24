// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.ActionExtensions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Logging;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Threading;

namespace EleWise.ELMA.Extensions
{
  /// <summary>Методы для различных действий</summary>
  public static class ActionExtensions
  {
    private static ActionExtensions rHy7wMGweFDxZYLyWP4A;

    /// <summary>
    /// Выполнить действие. В случае ошибки сделать еще указанное число попыток через указанный интервал времени.
    /// </summary>
    /// <param name="action">Действие</param>
    /// <param name="interval">Интервал между попытками</param>
    /// <param name="attemptCount">Максимальное число попыток</param>
    public static void ExecuteWithAttempts(System.Action action, TimeSpan interval, int attemptCount)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ActionExtensions.ExecuteWithAttempts(action, interval, attemptCount, (Func<Exception, bool>) null);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>
    /// Выполнить действие. В случае ошибки сделать еще указанное число попыток через указанный интервал времени.
    /// </summary>
    /// <param name="action">Действие</param>
    /// <param name="interval">Интервал между попытками</param>
    /// <param name="attemptCount">Максимальное число попыток</param>
    /// <param name="canRetry">Функция, которая возвращает True, если действие можно повторить после указанного исключения</param>
    public static void ExecuteWithAttempts(
      System.Action action,
      TimeSpan interval,
      int attemptCount,
      Func<Exception, bool> canRetry)
    {
      Contract.ArgumentNotNull((object) action, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1232639661 >> 3 ^ 154012449));
      int num = 0;
      bool flag = false;
      int millisecondsTimeout = (int) interval.TotalMilliseconds;
      if (millisecondsTimeout <= 0)
        millisecondsTimeout = 1;
      while (!flag && num < attemptCount)
      {
        ++num;
        try
        {
          action();
          flag = true;
        }
        catch (Exception ex)
        {
          if (num >= attemptCount || canRetry != null && !canRetry(ex))
          {
            throw;
          }
          else
          {
            Logger.Log.Warn((object) ex);
            Thread.Sleep(millisecondsTimeout);
          }
        }
      }
    }

    internal static bool NaUjMxGwPXINfRh82dMl() => ActionExtensions.rHy7wMGweFDxZYLyWP4A == null;

    internal static ActionExtensions Vvin4fGw1t1jg8y6rEG9() => ActionExtensions.rHy7wMGweFDxZYLyWP4A;
  }
}
