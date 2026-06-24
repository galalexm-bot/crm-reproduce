// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.TaskFactoryExtensions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace EleWise.ELMA.Extensions
{
  /// <summary>
  /// Методы расширения для <see cref="T:System.Threading.Tasks.TaskFactory" />.
  /// </summary>
  /// <remarks>
  /// Код позаимстован из Samples for Parallel Programming with the .NET Framework 4
  /// </remarks>
  public static class TaskFactoryExtensions
  {
    internal static TaskFactoryExtensions u6uF3HGpx6vIndwsr78w;

    /// <summary>
    /// Получить экземпляр планировщика, который надлежит использовать для планирования выполнения задач.
    /// </summary>
    /// <param name="factory">Целевая фабрика системных задач.</param>
    /// <returns>Экземпляр планировщика, который надлежит использовать для планирования выполнения задач.</returns>
    public static TaskScheduler GetTargetScheduler(this TaskFactory factory)
    {
      int num = 2;
      object targetScheduler;
      while (true)
      {
        switch (num)
        {
          case 1:
            targetScheduler = TaskFactoryExtensions.TjlkkgGpJ2xNIev6uOs5((object) factory);
            if (targetScheduler == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 2:
            TaskFactoryExtensions.NXJ5uuGpMoxWJpYhDeQU((object) factory, TaskFactoryExtensions.Prdn6nGpymd6C9J7dvs0(993438473 ^ 993305461));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 1 : 0;
            continue;
          default:
            goto label_6;
        }
      }
label_2:
      return (TaskScheduler) targetScheduler;
label_6:
      return (TaskScheduler) TaskFactoryExtensions.gwRs6JGp93wULZs4bjUu();
    }

    /// <summary>
    /// Создаёт задачу продолжения, которая завершится, когда все предъявленные задачи завершатся.
    /// </summary>
    /// <param name="factory">Целевая фабрика задач.</param>
    /// <param name="tasks">Набор задач, к которым делать продолжение.</param>
    /// <returns>Системную задачу, которая завершится, когда все задачи из массива завершатся.</returns>
    public static Task<Task[]> WhenAll(this TaskFactory factory, params Task[] tasks) => factory.ContinueWhenAll<Task[]>(tasks, (Func<Task[], Task[]>) (completedTasks => completedTasks));

    /// <summary>
    /// Асинхронно выполнить итерацию по перечислению системных задач.
    /// </summary>
    /// <param name="factory">Целевая фабрика задач.</param>
    /// <param name="source">Перечисление итерируемых задач.</param>
    /// <returns>Системная задача, которая представляет выполнение итерации по всем задачам.</returns>
    public static Task Iterate(this TaskFactory factory, IEnumerable<object> source)
    {
      Contract.ArgumentNotNull((object) factory, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-398663332 ^ -398530272));
      return factory.Iterate(source, (object) null, factory.CancellationToken, factory.CreationOptions, factory.GetTargetScheduler());
    }

    /// <summary>
    /// Асинхронно выполнить итерацию по перечислению системных задач.
    /// </summary>
    /// <param name="factory">Целевая фабрика задач.</param>
    /// <param name="source">Перечисление итерируемых задач.</param>
    /// <param name="cancellationToken">Токен отмены итерации.</param>
    /// <returns>Системная задача, которая представляет выполнение итерации по всем задачам.</returns>
    public static Task Iterate(
      this TaskFactory factory,
      IEnumerable<object> source,
      CancellationToken cancellationToken)
    {
      Contract.ArgumentNotNull((object) factory, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1669212571 ^ 1669079527));
      return factory.Iterate(source, (object) null, cancellationToken, factory.CreationOptions, factory.GetTargetScheduler());
    }

    /// <summary>
    /// Асинхронно выполнить итерацию по перечислению системных задач.
    /// </summary>
    /// <param name="factory">Целевая фабрика задач.</param>
    /// <param name="source">Перечисление итерируемых задач.</param>
    /// <param name="creationOptions">Опции создания системных задач.</param>
    /// <returns>Системная задача, которая представляет выполнение итерации по всем задачам.</returns>
    public static Task Iterate(
      this TaskFactory factory,
      IEnumerable<object> source,
      TaskCreationOptions creationOptions)
    {
      Contract.ArgumentNotNull((object) factory, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1669212571 ^ 1669079527));
      return factory.Iterate(source, (object) null, factory.CancellationToken, creationOptions, factory.GetTargetScheduler());
    }

    /// <summary>
    /// Асинхронно выполнить итерацию по перечислению системных задач.
    /// </summary>
    /// <param name="factory">Целевая фабрика задач.</param>
    /// <param name="source">Перечисление итерируемых задач.</param>
    /// <param name="scheduler">Планировщик задач.</param>
    /// <returns>Системная задача, которая представляет выполнение итерации по всем задачам.</returns>
    public static Task Iterate(
      this TaskFactory factory,
      IEnumerable<object> source,
      TaskScheduler scheduler)
    {
      Contract.ArgumentNotNull((object) factory, z2jc63fLkugS1X8Q9N.tE1kD1vbB(874012245 ^ 874141225));
      return factory.Iterate(source, (object) null, factory.CancellationToken, factory.CreationOptions, scheduler);
    }

    /// <summary>
    /// Асинхронно выполнить итерацию по перечислению системных задач.
    /// </summary>
    /// <param name="factory">Целевая фабрика задач.</param>
    /// <param name="source">Перечисление итерируемых задач.</param>
    /// <param name="cancellationToken">Токен отмены итерации.</param>
    /// <param name="creationOptions">Опции создания системных задач.</param>
    /// <param name="scheduler">Планировщик задач.</param>
    /// <returns>Системная задача, которая представляет выполнение итерации по всем задачам.</returns>
    public static Task Iterate(
      this TaskFactory factory,
      IEnumerable<object> source,
      CancellationToken cancellationToken,
      TaskCreationOptions creationOptions,
      TaskScheduler scheduler)
    {
      return factory.Iterate(source, (object) null, cancellationToken, creationOptions, scheduler);
    }

    /// <summary>
    /// Асинхронно выполнить итерацию по перечислению системных задач.
    /// </summary>
    /// <param name="factory">Целевая фабрика задач.</param>
    /// <param name="source">Перечисление итерируемых задач.</param>
    /// <param name="state">Пользовательский объект состояния для возвращаемой задачи.</param>
    /// <returns>Системная задача, которая представляет выполнение итерации по всем задачам.</returns>
    public static Task Iterate(this TaskFactory factory, IEnumerable<object> source, object state)
    {
      Contract.ArgumentNotNull((object) factory, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1872275253 >> 6 ^ -29125345));
      return factory.Iterate(source, state, factory.CancellationToken, factory.CreationOptions, factory.GetTargetScheduler());
    }

    /// <summary>
    /// Асинхронно выполнить итерацию по перечислению системных задач.
    /// </summary>
    /// <param name="factory">Целевая фабрика задач.</param>
    /// <param name="source">Перечисление итерируемых задач.</param>
    /// <param name="state">Пользовательский объект состояния для возвращаемой задачи.</param>
    /// <param name="cancellationToken">Токен отмены итерации.</param>
    /// <returns>Системная задача, которая представляет выполнение итерации по всем задачам.</returns>
    public static Task Iterate(
      this TaskFactory factory,
      IEnumerable<object> source,
      object state,
      CancellationToken cancellationToken)
    {
      Contract.ArgumentNotNull((object) factory, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978607474));
      return factory.Iterate(source, state, cancellationToken, factory.CreationOptions, factory.GetTargetScheduler());
    }

    /// <summary>
    /// Асинхронно выполнить итерацию по перечислению системных задач.
    /// </summary>
    /// <param name="factory">Целевая фабрика задач.</param>
    /// <param name="source">Перечисление итерируемых задач.</param>
    /// <param name="state">Пользовательский объект состояния для возвращаемой задачи.</param>
    /// <param name="creationOptions">Опции создания системных задач.</param>
    /// <returns>Системная задача, которая представляет выполнение итерации по всем задачам.</returns>
    public static Task Iterate(
      this TaskFactory factory,
      IEnumerable<object> source,
      object state,
      TaskCreationOptions creationOptions)
    {
      Contract.ArgumentNotNull((object) factory, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1917256330 ^ 1917127414));
      return factory.Iterate(source, state, factory.CancellationToken, creationOptions, factory.GetTargetScheduler());
    }

    /// <summary>
    /// Асинхронно выполнить итерацию по перечислению системных задач.
    /// </summary>
    /// <param name="factory">Целевая фабрика задач.</param>
    /// <param name="source">Перечисление итерируемых задач.</param>
    /// <param name="state">Пользовательский объект состояния для возвращаемой задачи.</param>
    /// <param name="scheduler">Планировщик задач.</param>
    /// <returns>Системная задача, которая представляет выполнение итерации по всем задачам.</returns>
    public static Task Iterate(
      this TaskFactory factory,
      IEnumerable<object> source,
      object state,
      TaskScheduler scheduler)
    {
      Contract.ArgumentNotNull((object) factory, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1710575414 ^ -1710704458));
      return factory.Iterate(source, state, factory.CancellationToken, factory.CreationOptions, scheduler);
    }

    /// <summary>
    /// Асинхронно выполнить итерацию по перечислению системных задач.
    /// </summary>
    /// <param name="factory">Целевая фабрика задач.</param>
    /// <param name="source">Перечисление итерируемых задач.</param>
    /// <param name="state">Пользовательский объект состояния для возвращаемой задачи.</param>
    /// <param name="cancellationToken">Токен отмены итерации.</param>
    /// <param name="creationOptions">Опции создания системных задач.</param>
    /// <param name="scheduler">Планировщик задач.</param>
    /// <returns>Системная задача, которая представляет выполнение итерации по всем задачам.</returns>
    public static Task Iterate(
      this TaskFactory factory,
      IEnumerable<object> source,
      object state,
      CancellationToken cancellationToken,
      TaskCreationOptions creationOptions,
      TaskScheduler scheduler)
    {
      Contract.ArgumentNotNull((object) factory, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1824388195 ^ -1824521247));
      Contract.ArgumentNotNull((object) source, z2jc63fLkugS1X8Q9N.tE1kD1vbB(2045296739 + 1688595713 ^ -561076286));
      Contract.ArgumentNotNull((object) scheduler, z2jc63fLkugS1X8Q9N.tE1kD1vbB(2008901894 << 3 ^ -1108820280));
      IEnumerator<object> enumerator = source.GetEnumerator();
      if (enumerator == null)
        throw new InvalidOperationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(44884861 ^ 45028467)));
      TaskCompletionSource<object> trs = new TaskCompletionSource<object>(state, creationOptions);
      trs.Task.ContinueWith((Action<Task<object>>) (_ => enumerator.Dispose()));
      Action<Task> recursiveBody = (Action<Task>) null;
      System.Action action;
      recursiveBody = (Action<Task>) (antecedent =>
      {
        switch (1)
        {
          case 1:
            try
            {
              int num1;
              if (enumerator.MoveNext())
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 4 : 0;
              else
                goto label_13;
label_3:
              object current;
              while (true)
              {
                switch (num1)
                {
                  case 1:
                    if (current is Task)
                    {
                      num1 = 11;
                      continue;
                    }
                    goto case 5;
                  case 2:
                    goto label_21;
                  case 3:
                  case 6:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    TaskFactoryExtensions.\u003C\u003Ec__DisplayClass11_0.P3BwQU8BQ3w66t7RiMS8((object) trs, (object) new InvalidOperationException((string) TaskFactoryExtensions.\u003C\u003Ec__DisplayClass11_0.tIbqqB8BfiFsVTGjajXq(TaskFactoryExtensions.\u003C\u003Ec__DisplayClass11_0.ev4K3Y8BE92S87gOWXfi(--1360331293 ^ 1360058981))));
                    num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 2 : 2;
                    continue;
                  case 4:
                    current = enumerator.Current;
                    num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 1 : 0;
                    continue;
                  case 5:
                    if (!(current is TaskScheduler))
                    {
                      num1 = 6;
                      continue;
                    }
                    goto case 9;
                  case 7:
                    goto label_18;
                  case 8:
                    goto label_17;
                  case 9:
                    TaskFactory factory1 = Task.Factory;
                    System.Action action1 = action;
                    System.Action action2 = action1 == null ? (action = (System.Action) (() =>
                    {
                      int num2 = 1;
                      while (true)
                      {
                        switch (num2)
                        {
                          case 0:
                            goto label_2;
                          case 1:
                            recursiveBody((Task) null);
                            num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 0 : 0;
                            continue;
                          default:
                            goto label_4;
                        }
                      }
label_2:
                      return;
label_4:;
                    })) : action1;
                    // ISSUE: reference to a compiler-generated method
                    CancellationToken cancellationToken1 = TaskFactoryExtensions.\u003C\u003Ec__DisplayClass11_0.YGh8se8Bh2LsBJpwIiWC();
                    TaskScheduler taskScheduler = (TaskScheduler) current;
                    // ISSUE: reference to a compiler-generated method
                    ((Task) TaskFactoryExtensions.\u003C\u003Ec__DisplayClass11_0.zYaa2n8BGipfxfqJaTak((object) factory1, (object) action2, cancellationToken1, TaskCreationOptions.None, (object) taskScheduler)).IgnoreExceptions();
                    num1 = 7;
                    continue;
                  case 10:
                    goto label_15;
                  case 11:
                    Task task = (Task) current;
                    // ISSUE: reference to a compiler-generated method
                    TaskFactoryExtensions.\u003C\u003Ec__DisplayClass11_0.H5NlfK8Bb9q2h0kiBbRQ((object) task);
                    task.ContinueWith(recursiveBody).IgnoreExceptions();
                    num1 = 10;
                    continue;
                  default:
                    goto label_13;
                }
              }
label_21:
              break;
label_18:
              break;
label_17:
              break;
label_15:
              break;
label_13:
              trs.TrySetResult((object) null);
              num1 = 8;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
              {
                num1 = 8;
                goto label_3;
              }
              else
                goto label_3;
            }
            catch (Exception ex)
            {
              int num = 3;
              OperationCanceledException canceledException;
              while (true)
              {
                switch (num)
                {
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    TaskFactoryExtensions.\u003C\u003Ec__DisplayClass11_0.P3BwQU8BQ3w66t7RiMS8((object) trs, (object) ex);
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 4 : 1;
                    continue;
                  case 2:
                    // ISSUE: reference to a compiler-generated method
                    TaskFactoryExtensions.\u003C\u003Ec__DisplayClass11_0.HXgjbF8B8qqJLPaKFUUY((object) trs);
                    num = 6;
                    continue;
                  case 3:
                    canceledException = ex as OperationCanceledException;
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 5 : 2;
                    continue;
                  case 4:
                    goto label_9;
                  case 5:
                    if (canceledException != null)
                    {
                      num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 0 : 0;
                      continue;
                    }
                    goto case 1;
                  case 6:
                    goto label_6;
                  default:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    if (TaskFactoryExtensions.\u003C\u003Ec__DisplayClass11_0.GH80Jw8BvqCBql7MX6Q6(TaskFactoryExtensions.\u003C\u003Ec__DisplayClass11_0.KZaRwu8BCLrDoA33yo3U((object) canceledException), cancellationToken))
                    {
                      num = 2;
                      continue;
                    }
                    goto case 1;
                }
              }
label_9:
              break;
label_6:
              break;
            }
        }
      });
      factory.StartNew((System.Action) (() =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              recursiveBody((Task) null);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }), CancellationToken.None, TaskCreationOptions.None, scheduler).IgnoreExceptions();
      return (Task) trs.Task;
    }

    internal static object Prdn6nGpymd6C9J7dvs0(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void NXJ5uuGpMoxWJpYhDeQU([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static object TjlkkgGpJ2xNIev6uOs5([In] object obj0) => (object) ((TaskFactory) obj0).Scheduler;

    internal static object gwRs6JGp93wULZs4bjUu() => (object) TaskScheduler.Current;

    internal static bool qsi4s6Gp0taemHqyaUbe() => TaskFactoryExtensions.u6uF3HGpx6vIndwsr78w == null;

    internal static TaskFactoryExtensions sSuwKcGpmWbGHV8lWWoY() => TaskFactoryExtensions.u6uF3HGpx6vIndwsr78w;
  }
}
