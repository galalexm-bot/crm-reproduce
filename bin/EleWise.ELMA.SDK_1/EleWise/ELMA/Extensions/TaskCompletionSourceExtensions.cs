// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.TaskCompletionSourceExtensions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EleWise.ELMA.Extensions
{
  /// <summary>Методы расширения для TaskCompletionSource.</summary>
  /// <remarks>
  /// Код позаимстован из Samples for Parallel Programming with the .NET Framework 4
  /// </remarks>
  public static class TaskCompletionSourceExtensions
  {
    /// <summary>
    /// Перенести результат системной асинхронной задачи в TaskCompletionSource.
    /// </summary>
    /// <typeparam name="TResult">Тип результата.</typeparam>
    /// <param name="resultSetter">TaskCompletionSource.</param>
    /// <param name="task">Задача, результаты которой требуется перенести.</param>
    public static void SetFromTask<TResult>(
      this TaskCompletionSource<TResult> resultSetter,
      Task task)
    {
      switch (task.Status)
      {
        case TaskStatus.RanToCompletion:
          resultSetter.SetResult(task is Task<TResult> ? ((Task<TResult>) task).Result : default (TResult));
          break;
        case TaskStatus.Canceled:
          resultSetter.SetCanceled();
          break;
        case TaskStatus.Faulted:
          resultSetter.SetException((IEnumerable<Exception>) task.Exception.InnerExceptions);
          break;
        default:
          throw new InvalidOperationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1051802738 - -1831968059 ^ -1411305617)));
      }
    }

    /// <summary>
    /// Перенести результат системной асинхронной задачи в TaskCompletionSource.
    /// </summary>
    /// <typeparam name="TResult">Тип результата.</typeparam>
    /// <param name="resultSetter">TaskCompletionSource.</param>
    /// <param name="task">Задача, результаты которой требуется перенести.</param>
    public static void SetFromTask<TResult>(
      this TaskCompletionSource<TResult> resultSetter,
      Task<TResult> task)
    {
      resultSetter.SetFromTask<TResult>((Task) task);
    }

    /// <summary>
    /// Попытаться перенести результат системной асинхронной задачи в TaskCompletionSource.
    /// </summary>
    /// <typeparam name="TResult">Тип результата.</typeparam>
    /// <param name="resultSetter">TaskCompletionSource.</param>
    /// <param name="task">Задача, результаты которой требуется перенести.</param>
    /// <returns>Удалось ли перенести результаты (true - удалось, false - нет).</returns>
    public static bool TrySetFromTask<TResult>(
      this TaskCompletionSource<TResult> resultSetter,
      Task task)
    {
      switch (task.Status)
      {
        case TaskStatus.RanToCompletion:
          return resultSetter.TrySetResult(task is Task<TResult> ? ((Task<TResult>) task).Result : default (TResult));
        case TaskStatus.Canceled:
          return resultSetter.TrySetCanceled();
        case TaskStatus.Faulted:
          return resultSetter.TrySetException((IEnumerable<Exception>) task.Exception.InnerExceptions);
        default:
          throw new InvalidOperationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1470440286 ^ 1470551452)));
      }
    }

    /// <summary>
    /// Попытаться перенести результат системной асинхронной задачи в TaskCompletionSource.
    /// </summary>
    /// <typeparam name="TResult">Тип результата.</typeparam>
    /// <param name="resultSetter">TaskCompletionSource.</param>
    /// <param name="task">Задача, результаты которой требуется перенести.</param>
    /// <returns>Удалось ли перенести результаты (true - удалось, false - нет).</returns>
    public static bool TrySetFromTask<TResult>(
      this TaskCompletionSource<TResult> resultSetter,
      Task<TResult> task)
    {
      return resultSetter.TrySetFromTask<TResult>((Task) task);
    }
  }
}
