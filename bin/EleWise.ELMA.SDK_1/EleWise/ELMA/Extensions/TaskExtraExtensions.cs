// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.TaskExtraExtensions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace EleWise.ELMA.Extensions
{
  /// <summary>
  /// Методы расширения системных задач для асинхронных операций (Task и Task&lt;TResult&gt;)
  /// </summary>
  /// <remarks>
  /// Код позаимстован из Samples for Parallel Programming with the .NET Framework 4
  /// </remarks>
  public static class TaskExtraExtensions
  {
    internal static TaskExtraExtensions mdBI3PGpYqbnKQZ5YyG7;

    /// <summary>
    /// Подавить исключения, возникшие в системной задаче.
    /// В противном случае стандартный механизм обработки исключений поднимет их в потоке финализатора при сборке мусора.
    /// </summary>
    /// <param name="task">Задача, за которой нужно проследить.</param>
    /// <returns>Оригинальная системная задача.</returns>
    public static Task IgnoreExceptions(this Task task)
    {
      int num1 = 1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            task.ContinueWith((Action<Task>) (t =>
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    TaskExtraExtensions.\u003C\u003Ec.f4NmlS8BSgcPs18b6t18((object) t);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }), CancellationToken.None, TaskContinuationOptions.OnlyOnFaulted, TaskScheduler.Current);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return task;
    }

    /// <summary>
    /// Подавить исключения, возникшие в системной задаче.
    /// В противном случае стандартный механизм обработки исключений поднимет их в потоке финализатора при сборке мусора.
    /// </summary>
    /// <param name="task">Задача, за которой нужно проследить.</param>
    /// <returns>Оригинальная системная задача.</returns>
    public static Task<T> IgnoreExceptions<T>(this Task<T> task) => (Task<T>) task.IgnoreExceptions();

    /// <summary>
    /// Распространить исключения, которые возникли в ходе работы указанной задачи.
    /// </summary>
    /// <param name="task">Задача, чьи исключения необходимо передать.</param>
    public static void PropagateExceptions(this Task task)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (TaskExtraExtensions.EJbTGVGpsyeqM2XlYJGL((object) task))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          case 2:
            goto label_5;
          case 3:
            task.Wait();
            num = 4;
            continue;
          case 4:
            goto label_4;
          default:
            if (TaskExtraExtensions.nGnJ1xGaFqFPlt6Ock6V((object) task))
            {
              num = 3;
              continue;
            }
            goto label_2;
        }
      }
label_4:
      return;
label_5:
      throw new InvalidOperationException((string) TaskExtraExtensions.rOSp8tGpzkpvUh6CgakS(TaskExtraExtensions.morL7eGpcaIdMcKF19f2(1505778440 - 1981636111 ^ -475985349)));
label_2:;
    }

    /// <summary>
    /// Распространить исключения, которые возникли в ходе работы указанного массива задач.
    /// </summary>
    /// <param name="tasks">Массив системных задач, чьи исключения нужно распространить.</param>
    public static void PropagateExceptions(this Task[] tasks)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            Task[] source1 = tasks;
            // ISSUE: reference to a compiler-generated field
            Func<Task, bool> func1 = TaskExtraExtensions.\u003C\u003Ec.\u003C\u003E9__3_0;
            Func<Task, bool> predicate1;
            if (func1 == null)
            {
              // ISSUE: reference to a compiler-generated field
              TaskExtraExtensions.\u003C\u003Ec.\u003C\u003E9__3_0 = predicate1 = (Func<Task, bool>) (t => t != null);
            }
            else
              goto label_2;
label_8:
            Contract.Check<ArgumentException>(((IEnumerable<Task>) source1).All<Task>(predicate1), (string) TaskExtraExtensions.morL7eGpcaIdMcKF19f2(--1360331293 ^ 1360459145));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 4 : 4;
            continue;
label_2:
            predicate1 = func1;
            goto label_8;
          case 2:
            Contract.ArgumentNotNull((object) tasks, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461825605 - 1531863589 ^ -70207066));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 1;
            continue;
          case 3:
            goto label_10;
          case 4:
            Task[] source2 = tasks;
            // ISSUE: reference to a compiler-generated field
            Func<Task, bool> func2 = TaskExtraExtensions.\u003C\u003Ec.\u003C\u003E9__3_1;
            Func<Task, bool> predicate2;
            if (func2 == null)
            {
              // ISSUE: reference to a compiler-generated field
              TaskExtraExtensions.\u003C\u003Ec.\u003C\u003E9__3_1 = predicate2 = (Func<Task, bool>) (t => !t.IsCompleted);
            }
            else
              goto label_14;
label_12:
            if (!((IEnumerable<Task>) source2).Any<Task>(predicate2))
            {
              TaskExtraExtensions.ycpewgGaBfRswHPdDa2x((object) tasks);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 1 : 3;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 0;
            continue;
label_14:
            predicate2 = func2;
            goto label_12;
          default:
            goto label_3;
        }
      }
label_10:
      return;
label_3:
      throw new InvalidOperationException((string) TaskExtraExtensions.rOSp8tGpzkpvUh6CgakS(TaskExtraExtensions.morL7eGpcaIdMcKF19f2(-1837662597 ^ -1837856335)));
    }

    /// <summary>
    /// Создать задачу, которая представляет завершение действия-продолжения после закончившейся задачи.
    /// </summary>
    /// <param name="task">Асинхронная задача.</param>
    /// <param name="next">Действие, которое следует запустить после успешного завершения асинхронной задачи.</param>
    /// <returns>Задачу, которая представляет собой завершение как асинхронной задачи, так и действия.</returns>
    public static Task Then(this Task task, System.Action next) => (Task) TaskExtraExtensions.kBq5DgGaovnpLhHc7Anm((object) task, (object) next, TaskExtraExtensions.LbTmM1GaW7JZFvDd4nvk());

    /// <summary>
    /// Создать задачу, которая представляет завершение действия-продолжения после закончившейся задачи.
    /// </summary>
    /// <param name="task">Асинхронная задача.</param>
    /// <param name="next">Действие, которое следует запустить после успешного завершения асинхронной задачи.</param>
    /// <param name="token">Токен отмены.</param>
    /// <returns>Задачу, которая представляет собой завершение как асинхронной задачи, так и действия.</returns>
    public static Task Then(this Task task, System.Action next, CancellationToken token)
    {
      int num1 = 1;
      TaskCompletionSource<object> tcs;
      while (true)
      {
        int num2 = num1;
        System.Action next1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_5;
            case 3:
              Contract.ArgumentNotNull((object) next1, (string) TaskExtraExtensions.morL7eGpcaIdMcKF19f2(901793403 ^ 902020723));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 2 : 2;
              continue;
            case 4:
              TaskExtraExtensions.APIKqAGab0DpwlGFnDHy((object) task, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-397266137 ^ 397203246));
              num2 = 3;
              continue;
            case 5:
              task.ContinueWith((Action<Task>) (parentTask =>
              {
                int num3 = 4;
                while (true)
                {
                  switch (num3)
                  {
                    case 0:
                      goto label_21;
                    case 1:
                      goto label_20;
                    case 2:
                      goto label_9;
                    case 3:
                      // ISSUE: reference to a compiler-generated method
                      if (TaskExtraExtensions.\u003C\u003Ec__DisplayClass5_0.zWRrWK8BTYy2P1eJQoWD((object) parentTask))
                      {
                        num3 = 6;
                        continue;
                      }
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 2 : 0;
                      continue;
                    case 4:
                      if (!parentTask.IsFaulted)
                      {
                        num3 = 3;
                        continue;
                      }
                      goto case 7;
                    case 5:
                      goto label_2;
                    case 6:
                      tcs.TrySetCanceled();
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 5 : 5;
                      continue;
                    case 7:
                      // ISSUE: reference to a compiler-generated method
                      tcs.TrySetException((IEnumerable<Exception>) ((AggregateException) TaskExtraExtensions.\u003C\u003Ec__DisplayClass5_0.VcNcVg8BXGYXDxHxlfL3((object) parentTask)).InnerExceptions);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 1;
                      continue;
                    default:
                      goto label_18;
                  }
                }
label_21:
                return;
label_20:
                return;
label_2:
                return;
label_18:
                return;
label_9:
                try
                {
                  next1();
                  int num4 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0)
                    num4 = 0;
                  while (true)
                  {
                    switch (num4)
                    {
                      case 1:
                        goto label_14;
                      default:
                        tcs.TrySetResult((object) null);
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 1 : 1;
                        continue;
                    }
                  }
label_14:;
                }
                catch (Exception ex)
                {
                  int num5 = 1;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0)
                    num5 = 0;
                  while (true)
                  {
                    switch (num5)
                    {
                      case 0:
                        goto label_12;
                      case 1:
                        // ISSUE: reference to a compiler-generated method
                        TaskExtraExtensions.\u003C\u003Ec__DisplayClass5_0.LaHjk88BkPKSrXPLHdjp((object) tcs, (object) ex);
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_5;
                    }
                  }
label_12:
                  return;
label_5:;
                }
              }), token);
              num2 = 6;
              continue;
            case 6:
              goto label_3;
            default:
              next1 = next;
              num2 = 4;
              continue;
          }
        }
label_5:
        tcs = new TaskCompletionSource<object>(TaskCreationOptions.RunContinuationsAsynchronously);
        num1 = 5;
      }
label_3:
      return (Task) tcs.Task;
    }

    /// <summary>
    /// Создать задачу, которая представляет завершение функции-продолжения после закончившейся задачи.
    /// </summary>
    /// <typeparam name="TResult">Тип результата функции-продолжения.</typeparam>
    /// <param name="task">Асинхронная задача.</param>
    /// <param name="next">Функция, которую следует запустить после успешного завершения асинхронной задачи.</param>
    /// <returns>Задачу, которая представляет собой завершение как асинхронной задачи, так и функции.</returns>
    public static Task<TResult> Then<TResult>(this Task task, Func<TResult> next) => task.Then<TResult>(next, CancellationToken.None);

    /// <summary>
    /// Создать задачу, которая представляет завершение функции-продолжения после закончившейся задачи.
    /// </summary>
    /// <typeparam name="TResult">Тип результата функции-продолжения.</typeparam>
    /// <param name="task">Асинхронная задача.</param>
    /// <param name="next">Функция, которую следует запустить после успешного завершения асинхронной задачи.</param>
    /// <param name="token">Токен отмены.</param>
    /// <returns>Задачу, которая представляет собой завершение как асинхронной задачи, так и функции.</returns>
    public static Task<TResult> Then<TResult>(
      this Task task,
      Func<TResult> next,
      CancellationToken token)
    {
      Contract.ArgumentNotNull((object) task, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-345420348 ^ -345483726));
      Contract.ArgumentNotNull((object) next, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1859102295));
      TaskCompletionSource<TResult> tcs = new TaskCompletionSource<TResult>(TaskCreationOptions.RunContinuationsAsynchronously);
      task.ContinueWith((Action<Task>) (parentTask =>
      {
        int num1 = 6;
        while (true)
        {
          switch (num1)
          {
            case 1:
              goto label_10;
            case 2:
              tcs.TrySetException((IEnumerable<Exception>) parentTask.Exception.InnerExceptions);
              num1 = 4;
              continue;
            case 3:
              tcs.TrySetCanceled();
              num1 = 8;
              continue;
            case 4:
              goto label_3;
            case 5:
              if (!parentTask.IsCanceled)
              {
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
                continue;
              }
              goto case 3;
            case 6:
              if (!parentTask.IsFaulted)
              {
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 1 : 5;
                continue;
              }
              goto case 2;
            case 7:
              goto label_21;
            case 8:
              goto label_2;
            default:
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 1 : 1;
              continue;
          }
        }
label_3:
        return;
label_21:
        return;
label_2:
        return;
label_10:
        try
        {
          TResult result = next();
          int num2 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0)
            num2 = 1;
          while (true)
          {
            switch (num2)
            {
              case 0:
                goto label_19;
              case 1:
                tcs.TrySetResult(result);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 0 : 0;
                continue;
              default:
                goto label_15;
            }
          }
label_19:
          return;
label_15:;
        }
        catch (Exception ex)
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
            num3 = 0;
          while (true)
          {
            switch (num3)
            {
              case 1:
                goto label_13;
              default:
                tcs.TrySetException(ex);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 1 : 1;
                continue;
            }
          }
label_13:;
        }
      }), token);
      return tcs.Task;
    }

    /// <summary>
    /// Создать задачу, которая представляет завершение действия-продолжения после закончившейся задачи.
    /// </summary>
    /// <typeparam name="TResult">Тип результата завершённой задачи.</typeparam>
    /// <param name="task">Асинхронная задача.</param>
    /// <param name="next">Действие, которое следует запустить после успешного завершения асинхронной задачи.</param>
    /// <returns>Задачу, которая представляет собой завершение как асинхронной задачи, так и действия.</returns>
    public static Task Then<TResult>(this Task<TResult> task, Action<TResult> next) => task.Then<TResult>(next, CancellationToken.None);

    /// <summary>
    /// Создать задачу, которая представляет завершение действия-продолжения после закончившейся задачи.
    /// </summary>
    /// <typeparam name="TResult">Тип результата завершённой задачи.</typeparam>
    /// <param name="task">Асинхронная задача.</param>
    /// <param name="next">Действие, которое следует запустить после успешного завершения асинхронной задачи.</param>
    /// <param name="token">Токен отмены.</param>
    /// <returns>Задачу, которая представляет собой завершение как асинхронной задачи, так и действия.</returns>
    public static Task Then<TResult>(
      this Task<TResult> task,
      Action<TResult> next,
      CancellationToken token)
    {
      Contract.ArgumentNotNull((object) task, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105199646 ^ -105128940));
      Contract.ArgumentNotNull((object) next, z2jc63fLkugS1X8Q9N.tE1kD1vbB(87862435 ^ 88036523));
      TaskCompletionSource<object> tcs = new TaskCompletionSource<object>();
      task.ContinueWith((Action<Task<TResult>>) (parentTask =>
      {
        if (parentTask.IsFaulted)
          tcs.TrySetException((IEnumerable<Exception>) parentTask.Exception.InnerExceptions);
        else if (parentTask.IsCanceled)
        {
          tcs.TrySetCanceled();
        }
        else
        {
          try
          {
            next(parentTask.Result);
            tcs.TrySetResult((object) null);
          }
          catch (Exception ex)
          {
            tcs.TrySetException(ex);
          }
        }
      }), token);
      return (Task) tcs.Task;
    }

    /// <summary>
    /// Создать задачу, которая представляет завершение функции-продолжения после закончившейся задачи.
    /// </summary>
    /// <typeparam name="TResult">Тип результата завершённой задачи.</typeparam>
    /// <typeparam name="TNewResult">Тип результата функции-продолжения.</typeparam>
    /// <param name="task">Асинхронная задача.</param>
    /// <param name="next">Функция, которую следует запустить после успешного завершения асинхронной задачи.</param>
    /// <returns>Задачу, которая представляет собой завершение как асинхронной задачи, так и функции.</returns>
    public static Task<TNewResult> Then<TResult, TNewResult>(
      this Task<TResult> task,
      Func<TResult, TNewResult> next)
    {
      return task.Then<TResult, TNewResult>(next, CancellationToken.None);
    }

    /// <summary>
    /// Создать задачу, которая представляет завершение функции-продолжения после закончившейся задачи.
    /// </summary>
    /// <typeparam name="TResult">Тип результата завершённой задачи.</typeparam>
    /// <typeparam name="TNewResult">Тип результата функции-продолжения.</typeparam>
    /// <param name="task">Асинхронная задача.</param>
    /// <param name="next">Функция, которую следует запустить после успешного завершения асинхронной задачи.</param>
    /// <param name="token">Токен отмены.</param>
    /// <returns>Задачу, которая представляет собой завершение как асинхронной задачи, так и функции.</returns>
    public static Task<TNewResult> Then<TResult, TNewResult>(
      this Task<TResult> task,
      Func<TResult, TNewResult> next,
      CancellationToken token)
    {
      Contract.ArgumentNotNull((object) task, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1253244298 - 1829393894 ^ -576078766));
      Contract.ArgumentNotNull((object) next, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1839087379 - 334718690 ^ 2121114115));
      TaskCompletionSource<TNewResult> tcs = new TaskCompletionSource<TNewResult>(TaskCreationOptions.RunContinuationsAsynchronously);
      task.ContinueWith((Action<Task<TResult>>) (parentTask =>
      {
        if (parentTask.IsFaulted)
          tcs.TrySetException((IEnumerable<Exception>) parentTask.Exception.InnerExceptions);
        else if (parentTask.IsCanceled)
        {
          tcs.TrySetCanceled();
        }
        else
        {
          try
          {
            tcs.TrySetResult(next(parentTask.Result));
          }
          catch (Exception ex)
          {
            tcs.TrySetException(ex);
          }
        }
      }), token);
      return tcs.Task;
    }

    /// <summary>
    /// Создать задачу, которая представляет завершение второй задачи после завершения первой.
    /// </summary>
    /// <param name="task">Первая задача.</param>
    /// <param name="next">Функция, которая создаёт вторую задачу.</param>
    /// <returns>Задачу, которая представляет собой завершение обоих задач.</returns>
    public static Task Then(this Task task, Func<Task> next) => task.Then(next, CancellationToken.None);

    /// <summary>
    /// Создать задачу, которая представляет завершение второй задачи после завершения первой.
    /// </summary>
    /// <param name="task">Первая задача.</param>
    /// <param name="next">Функция, которая создаёт вторую задачу.</param>
    /// <param name="token">Токен отмены.</param>
    /// <returns>Задачу, которая представляет собой завершение обоих задач.</returns>
    public static Task Then(this Task task, Func<Task> next, CancellationToken token)
    {
      Contract.ArgumentNotNull((object) task, z2jc63fLkugS1X8Q9N.tE1kD1vbB(964881585 - -1459193222 ^ -1870829119));
      Contract.ArgumentNotNull((object) next, z2jc63fLkugS1X8Q9N.tE1kD1vbB(813604817 ^ 813524953));
      TaskCompletionSource<object> tcs = new TaskCompletionSource<object>(TaskCreationOptions.RunContinuationsAsynchronously);
      Func<Task, bool> func;
      task.ContinueWith((Action<Task>) (parentTask =>
      {
        int num1 = 3;
        while (true)
        {
          switch (num1)
          {
            case 1:
              goto label_19;
            case 2:
              // ISSUE: reference to a compiler-generated method
              tcs.TrySetException((IEnumerable<Exception>) ((AggregateException) TaskExtraExtensions.\u003C\u003Ec__DisplayClass13_0.X5LbbP8B4Sxqa4AThdUh((object) parentTask)).InnerExceptions);
              num1 = 6;
              continue;
            case 3:
              // ISSUE: reference to a compiler-generated method
              if (!TaskExtraExtensions.\u003C\u003Ec__DisplayClass13_0.SslZHy8BwEWKSpQTD5X4((object) parentTask))
              {
                // ISSUE: reference to a compiler-generated method
                if (!TaskExtraExtensions.\u003C\u003Ec__DisplayClass13_0.k3g4eC8B6BuhhQWQIhau((object) parentTask))
                {
                  num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 0;
                  continue;
                }
                goto case 7;
              }
              else
              {
                num1 = 2;
                continue;
              }
            case 4:
              goto label_3;
            case 5:
              goto label_16;
            case 6:
              goto label_15;
            case 7:
              // ISSUE: reference to a compiler-generated method
              TaskExtraExtensions.\u003C\u003Ec__DisplayClass13_0.mcH0B58BHkqxgtFmyxs0((object) tcs);
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 1 : 0;
              continue;
            default:
              num1 = 4;
              continue;
          }
        }
label_19:
        return;
label_16:
        return;
label_15:
        return;
label_3:
        try
        {
          Task task1 = next();
          Func<Task, bool> func1 = func;
          Func<Task, bool> continuationFunction = func1 == null ? (func = (Func<Task, bool>) (t => tcs.TrySetFromTask<object>(t))) : func1;
          CancellationToken cancellationToken = token;
          task1.ContinueWith<bool>(continuationFunction, cancellationToken);
          int num2 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
            num2 = 0;
          switch (num2)
          {
          }
        }
        catch (Exception ex)
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
            num3 = 1;
          while (true)
          {
            switch (num3)
            {
              case 0:
                goto label_7;
              case 1:
                // ISSUE: reference to a compiler-generated method
                TaskExtraExtensions.\u003C\u003Ec__DisplayClass13_0.oQSLmy8BAPleIr5WxfCX((object) tcs, (object) ex);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 0;
                continue;
              default:
                goto label_6;
            }
          }
label_7:
          return;
label_6:;
        }
      }), token);
      return (Task) tcs.Task;
    }

    /// <summary>
    /// Создать задачу, которая представляет завершение второй задачи после завершения первой.
    /// </summary>
    /// <typeparam name="TResult">Тип результата первой задачи.</typeparam>
    /// <param name="task">Первая задача.</param>
    /// <param name="next">Функция, которая создаёт вторую задачу.</param>
    /// <returns>Задачу, которая представляет собой завершение обоих задач.</returns>
    public static Task Then<TResult>(this Task<TResult> task, Func<TResult, Task> next) => task.Then<TResult>(next, CancellationToken.None);

    /// <summary>
    /// Создать задачу, которая представляет завершение второй задачи после завершения первой.
    /// </summary>
    /// <typeparam name="TResult">Тип результата первой задачи.</typeparam>
    /// <param name="task">Первая задача.</param>
    /// <param name="next">Функция, которая создаёт вторую задачу.</param>
    /// <param name="token">Токен отмены.</param>
    /// <returns>Задачу, которая представляет собой завершение обоих задач.</returns>
    public static Task Then<TResult>(
      this Task<TResult> task,
      Func<TResult, Task> next,
      CancellationToken token)
    {
      Contract.ArgumentNotNull((object) task, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-53329496 >> 4 ^ -3391508));
      Contract.ArgumentNotNull((object) next, z2jc63fLkugS1X8Q9N.tE1kD1vbB(381945751 ^ 1158627804 ^ 1405664835));
      TaskCompletionSource<object> tcs = new TaskCompletionSource<object>(TaskCreationOptions.RunContinuationsAsynchronously);
      task.ContinueWith((Action<Task<TResult>>) (parentTask =>
      {
        if (parentTask.IsFaulted)
          tcs.TrySetException((IEnumerable<Exception>) parentTask.Exception.InnerExceptions);
        else if (parentTask.IsCanceled)
        {
          tcs.TrySetCanceled();
        }
        else
        {
          try
          {
            next(parentTask.Result).ContinueWith<bool>((Func<Task, bool>) (t => tcs.TrySetFromTask<object>(t)), token);
          }
          catch (Exception ex)
          {
            tcs.TrySetException(ex);
          }
        }
      }), token);
      return (Task) tcs.Task;
    }

    /// <summary>
    /// Создать задачу, которая представляет завершение второй задачи после завершения первой.
    /// </summary>
    /// <typeparam name="TResult">Тип результата второй задачи.</typeparam>
    /// <param name="task">Первая задача.</param>
    /// <param name="next">Функция, которая создаёт вторую задачу.</param>
    /// <returns>Задачу, которая представляет собой завершение обоих задач.</returns>
    public static Task<TResult> Then<TResult>(this Task task, Func<Task<TResult>> next) => task.Then<TResult>(next, CancellationToken.None);

    /// <summary>
    /// Создать задачу, которая представляет завершение второй задачи после завершения первой.
    /// </summary>
    /// <typeparam name="TResult">Тип результата второй задачи.</typeparam>
    /// <param name="task">Первая задача.</param>
    /// <param name="next">Функция, которая создаёт вторую задачу.</param>
    /// <param name="token">Токен отмены.</param>
    /// <returns>Задачу, которая представляет собой завершение обоих задач.</returns>
    public static Task<TResult> Then<TResult>(
      this Task task,
      Func<Task<TResult>> next,
      CancellationToken token)
    {
      Contract.ArgumentNotNull((object) task, z2jc63fLkugS1X8Q9N.tE1kD1vbB(825385222 ^ 825457392));
      Contract.ArgumentNotNull((object) next, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1514961705 ^ 1515160353));
      TaskCompletionSource<TResult> tcs = new TaskCompletionSource<TResult>(TaskCreationOptions.RunContinuationsAsynchronously);
      task.ContinueWith((Action<Task>) (parentTask =>
      {
        int num1 = 7;
        while (true)
        {
          switch (num1)
          {
            case 0:
              goto label_14;
            case 1:
              goto label_17;
            case 2:
              tcs.TrySetException((IEnumerable<Exception>) parentTask.Exception.InnerExceptions);
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 1 : 1;
              continue;
            case 3:
              tcs.TrySetCanceled();
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 0;
              continue;
            case 4:
              goto label_3;
            case 5:
              goto label_21;
            case 6:
              num1 = !parentTask.IsCanceled ? 4 : 3;
              continue;
            case 7:
              if (!parentTask.IsFaulted)
              {
                num1 = 6;
                continue;
              }
              goto case 2;
            default:
              goto label_2;
          }
        }
label_14:
        return;
label_17:
        return;
label_21:
        return;
label_2:
        return;
label_3:
        try
        {
          next().ContinueWith<bool>((Func<Task<TResult>, bool>) (t => tcs.TrySetFromTask<TResult>(t)), token);
          int num2 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
            num2 = 0;
          switch (num2)
          {
          }
        }
        catch (Exception ex)
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
            num3 = 1;
          while (true)
          {
            switch (num3)
            {
              case 0:
                goto label_7;
              case 1:
                tcs.TrySetException(ex);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 0;
                continue;
              default:
                goto label_6;
            }
          }
label_7:
          return;
label_6:;
        }
      }), token);
      return tcs.Task;
    }

    /// <summary>
    /// Создать задачу, которая представляет завершение второй задачи после завершения первой.
    /// </summary>
    /// <typeparam name="TResult">Тип результата первой задачи.</typeparam>
    /// <typeparam name="TNewResult">Тип результата второй задачи.</typeparam>
    /// <param name="task">Первая задача.</param>
    /// <param name="next">Функция, которая создаёт вторую задачу.</param>
    /// <returns>Задачу, которая представляет собой завершение обоих задач.</returns>
    public static Task<TNewResult> Then<TResult, TNewResult>(
      this Task<TResult> task,
      Func<TResult, Task<TNewResult>> next)
    {
      return task.Then<TResult, TNewResult>(next, CancellationToken.None);
    }

    /// <summary>
    /// Создать задачу, которая представляет завершение второй задачи после завершения первой.
    /// </summary>
    /// <typeparam name="TResult">Тип результата первой задачи.</typeparam>
    /// <typeparam name="TNewResult">Тип результата второй задачи.</typeparam>
    /// <param name="task">Первая задача.</param>
    /// <param name="next">Функция, которая создаёт вторую задачу.</param>
    /// <param name="token">Токен отмены.</param>
    /// <returns>Задачу, которая представляет собой завершение обоих задач.</returns>
    public static Task<TNewResult> Then<TResult, TNewResult>(
      this Task<TResult> task,
      Func<TResult, Task<TNewResult>> next,
      CancellationToken token)
    {
      Contract.ArgumentNotNull((object) task, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-675505729 ^ -675446199));
      Contract.ArgumentNotNull((object) next, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1217523399 ^ -1217533647));
      TaskCompletionSource<TNewResult> tcs = new TaskCompletionSource<TNewResult>(TaskCreationOptions.RunContinuationsAsynchronously);
      task.ContinueWith((Action<Task<TResult>>) (parentTask =>
      {
        if (parentTask.IsFaulted)
          tcs.TrySetException((IEnumerable<Exception>) parentTask.Exception.InnerExceptions);
        else if (task.IsCanceled)
        {
          tcs.TrySetCanceled();
        }
        else
        {
          try
          {
            next(parentTask.Result).ContinueWith<bool>((Func<Task<TNewResult>, bool>) (t => tcs.TrySetFromTask<TNewResult>(t)), token);
          }
          catch (Exception ex)
          {
            tcs.TrySetException(ex);
          }
        }
      }), token);
      return tcs.Task;
    }

    internal static bool jvc7ShGpLLfc16JgHJwv() => TaskExtraExtensions.mdBI3PGpYqbnKQZ5YyG7 == null;

    internal static TaskExtraExtensions b2Sj36GpUWbS0x1VvTtA() => TaskExtraExtensions.mdBI3PGpYqbnKQZ5YyG7;

    internal static bool EJbTGVGpsyeqM2XlYJGL([In] object obj0) => ((Task) obj0).IsCompleted;

    internal static object morL7eGpcaIdMcKF19f2(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object rOSp8tGpzkpvUh6CgakS([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool nGnJ1xGaFqFPlt6Ock6V([In] object obj0) => ((Task) obj0).IsFaulted;

    internal static void ycpewgGaBfRswHPdDa2x([In] object obj0) => Task.WaitAll((Task[]) obj0);

    internal static CancellationToken LbTmM1GaW7JZFvDd4nvk() => CancellationToken.None;

    internal static object kBq5DgGaovnpLhHc7Anm([In] object obj0, [In] object obj1, CancellationToken token) => (object) ((Task) obj0).Then((System.Action) obj1, token);

    internal static void APIKqAGab0DpwlGFnDHy([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);
  }
}
