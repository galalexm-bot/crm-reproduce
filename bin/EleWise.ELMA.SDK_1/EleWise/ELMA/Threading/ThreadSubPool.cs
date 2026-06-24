// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Threading.ThreadSubPool
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagnostics;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime.Context;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;

namespace EleWise.ELMA.Threading
{
  /// <summary>
  /// Пул потоков, использующий основной пул потоков приложения с заданным ограничением на количество потоков
  /// </summary>
  public class ThreadSubPool : IThreadSubPool, IThreadPool, IElmaThreadPool
  {
    private readonly System.Collections.Generic.Queue<ThreadSubPool.TaskInfo> queue;
    private readonly string logPrefix;
    private readonly string appSettingsKey;
    private readonly ElmaThreadPool threadPool;
    private readonly bool useElmaThreadPool;
    private int threadCount;
    private int maxThreadCount;
    internal static ThreadSubPool y3jgQHBRe6Lww5n3Z7lk;

    /// <summary>Создать пул</summary>
    /// <param name="maxThreadCount">Максимальное количество потоков</param>
    public ThreadSubPool(int maxThreadCount)
    {
      ThreadSubPool.XeQJHfBRN0fqVRE1D3dt();
      // ISSUE: explicit constructor call
      this.\u002Ector(maxThreadCount, (string) null);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Создать пул</summary>
    /// <param name="maxThreadCount">Максимальное количество потоков</param>
    /// <param name="logPrefix">Префикс для логирования</param>
    public ThreadSubPool(int maxThreadCount, string logPrefix)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.queue = new System.Collections.Generic.Queue<ThreadSubPool.TaskInfo>();
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
            this.maxThreadCount = maxThreadCount;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 0 : 0;
            continue;
          default:
            this.logPrefix = !ThreadSubPool.cs8q8gBR3jkMxXNSCAWV((object) logPrefix) ? logPrefix : z2jc63fLkugS1X8Q9N.tE1kD1vbB(694673736 ^ -23604109 ^ -672059899);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 1 : 0;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Создать пул</summary>
    /// <param name="appSettingsKey">Ключ настройки приложения, содержащей размер пула (максимальное количество потоков)</param>
    /// <param name="minThreadCount">Минимальное количество потоков</param>
    public ThreadSubPool(string appSettingsKey, int minThreadCount)
    {
      ThreadSubPool.XeQJHfBRN0fqVRE1D3dt();
      // ISSUE: explicit constructor call
      this.\u002Ector(ThreadSubPool.eNkHXfBRpDtwZQmovukb((object) appSettingsKey, minThreadCount), (string) null);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.appSettingsKey = appSettingsKey;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Создать пул</summary>
    /// <param name="appSettingsKey">Ключ настройки приложения, содержащей размер пула (максимальное количество потоков)</param>
    /// <param name="minThreadCount">Минимальное количество потоков</param>
    /// <param name="logPrefix">Префикс для логирования</param>
    public ThreadSubPool(string appSettingsKey, int minThreadCount, string logPrefix)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      this.\u002Ector(ThreadSubPool.eNkHXfBRpDtwZQmovukb((object) appSettingsKey, minThreadCount), logPrefix);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.appSettingsKey = appSettingsKey;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Сохдать пул</summary>
    /// <param name="appSettingsKey">Ключ настройки приложения, содержащей размер пула (максимальное количество потоков)</param>
    /// <param name="minThreadCount">Минимальное количество потоков</param>
    /// <param name="logPrefix">Префикс для логирования</param>
    /// <param name="useElmaThreadPool">Использовать пул потоков ELMA</param>
    /// <param name="elmaThreadPoolName">Название пула потоков ELMA</param>
    public ThreadSubPool(
      string appSettingsKey,
      int minThreadCount,
      string logPrefix,
      bool useElmaThreadPool,
      string elmaThreadPoolName)
    {
      ThreadSubPool.XeQJHfBRN0fqVRE1D3dt();
      // ISSUE: explicit constructor call
      this.\u002Ector(appSettingsKey, minThreadCount, logPrefix);
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.useElmaThreadPool = useElmaThreadPool;
            num = 2;
            continue;
          case 2:
            if (useElmaThreadPool)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 0 : 0;
              continue;
            }
            goto label_8;
          case 3:
            goto label_3;
          default:
            this.threadPool = new ElmaThreadPool(elmaThreadPoolName, appSettingsKey, minThreadCount);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 3 : 0;
            continue;
        }
      }
label_3:
      return;
label_8:;
    }

    /// <summary>Максимальное количество потоков</summary>
    public int MaxThreadCount
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (this.appSettingsKey == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 0 : 0;
                continue;
              }
              goto case 2;
            case 2:
              this.maxThreadCount = EleWise.ELMA.SR.GetSetting<int>(this.appSettingsKey, this.maxThreadCount);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 3 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return this.maxThreadCount;
      }
    }

    /// <summary>Количество активных потоков</summary>
    public int ActiveThreadCount => this.threadCount;

    /// <summary>Поставить операцию в очередь</summary>
    /// <param name="task">Выполняемая операция</param>
    /// <exception cref="T:System.ArgumentNullException">Если <c>task</c> равно <c>null</c></exception>
    public void Queue([NotNull] ThreadStart task)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.QueueInternal(task, (string) null, (Action<Exception>) null, (System.Action) null);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Поставить операцию в очередь</summary>
    /// <param name="task">Выполняемая операция</param>
    /// <param name="exceptionHandler">Обработчик ошибок</param>
    /// <param name="finallyHandler">Обработчик секции finally</param>
    /// <exception cref="T:System.ArgumentNullException">Если <c>task</c> равно <c>null</c></exception>
    public void Queue(ThreadStart task, Action<Exception> exceptionHandler, System.Action finallyHandler) => this.QueueInternal(task, (string) null, exceptionHandler, finallyHandler);

    /// <summary>Поставить операцию в очередь</summary>
    /// <param name="task">Выполняемая операция</param>
    /// <param name="taskName">Имя операции</param>
    /// <exception cref="T:System.ArgumentNullException">Если <c>task</c> равно <c>null</c></exception>
    public void Queue([NotNull] ThreadStart task, string taskName)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.QueueInternal(task, taskName, (Action<Exception>) null, (System.Action) null);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <inheritdoc />
    IElmaThreadPoolWorkItem IElmaThreadPool.Push(ThreadStart callback)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.useElmaThreadPool)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 0 : 0;
              continue;
            }
            goto label_4;
          case 2:
            goto label_4;
          default:
            goto label_5;
        }
      }
label_4:
      throw new InvalidOperationException((string) ThreadSubPool.l0UyYVBRDBSvVguMcVp0(ThreadSubPool.XdIKDPBRaXn0TYsEsF5l(-710283084 ^ -537863435 ^ 173551901)));
label_5:
      return this.QueueInternal(callback, (string) null, (Action<Exception>) null, (System.Action) null);
    }

    /// <inheritdoc />
    IElmaThreadPoolWorkItem IElmaThreadPool.Push(
      ThreadStart callback,
      Action<Exception> exceptionHandler,
      System.Action finallyHandler)
    {
      if (!this.useElmaThreadPool)
        throw new InvalidOperationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1199946765 ^ 1199875921)));
      return this.QueueInternal(callback, (string) null, exceptionHandler, finallyHandler);
    }

    /// <summary>Поставить операцию в очередь</summary>
    /// <param name="task">Выполняемая операция</param>
    /// <param name="taskName">Имя операции</param>
    /// <param name="exceptionHandler">Обработчик ошибок</param>
    /// <param name="finallyHandler">Обработчик секции finally</param>
    /// <exception cref="T:System.ArgumentNullException">Если <c>task</c> равно <c>null</c></exception>
    public void Queue(
      ThreadStart task,
      string taskName,
      Action<Exception> exceptionHandler,
      System.Action finallyHandler)
    {
      this.QueueInternal(task, taskName, exceptionHandler, finallyHandler);
    }

    /// <summary>Поставить операцию в очередь</summary>
    /// <param name="task">Выполняемая операция</param>
    /// <param name="taskName">Имя операции</param>
    /// <param name="exceptionHandler">Обработчик ошибок</param>
    /// <param name="finallyHandler">Обработчик секции finally</param>
    /// <exception cref="T:System.ArgumentNullException">Если <c>task</c> равно <c>null</c></exception>
    /// <returns>Элемент очереди обработки пула потоков</returns>
    public IElmaThreadPoolWorkItem QueueInternal(
      ThreadStart task,
      string taskName,
      Action<Exception> exceptionHandler,
      System.Action finallyHandler)
    {
      Contract.ArgumentNotNull((object) task, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461825605 - 1531863589 ^ -70101546));
      int count;
      lock (this.queue)
      {
        this.queue.Enqueue(new ThreadSubPool.TaskInfo()
        {
          Task = task,
          TaskName = !string.IsNullOrEmpty(taskName) ? taskName : task.ToString(),
          ExceptionHandler = exceptionHandler,
          FinallyHandler = finallyHandler
        });
        count = this.queue.Count;
      }
      int num = Interlocked.CompareExchange(ref this.threadCount, this.MaxThreadCount, this.MaxThreadCount);
      bool flag = num < this.MaxThreadCount;
      if (Logger.Log.IsDebugEnabled())
        Logger.Log.Debug((object) (this.logPrefix + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-342626196 - 1290888215 ^ -1633447849) + (object) count + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70067419) + flag.ToString() + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1886646897 ^ -1886580281) + (object) num));
      if (flag)
      {
        Interlocked.Increment(ref this.threadCount);
        if (this.useElmaThreadPool)
          return this.threadPool.Push(new ThreadStart(this.ExecuteInThread));
        ThreadStarter.QueueThread(new ThreadStart(this.ExecuteInThread));
      }
      return (IElmaThreadPoolWorkItem) null;
    }

    private static int LoadAppSettingsValue(object key, int minThreadCount) => EleWise.ELMA.SR.GetSetting<int>((string) key, minThreadCount);

    /// <summary>Достать элемент испольнение из очереди</summary>
    /// <returns>Информация о задаче</returns>
    private ThreadSubPool.TaskInfo Dequeue()
    {
      int num1 = 6;
      bool lockTaken;
      ThreadSubPool.TaskInfo taskInfo1;
      System.Collections.Generic.Queue<ThreadSubPool.TaskInfo> queue;
      int count;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (!((ILogger) ThreadSubPool.HZqrJbBR4CIyLcHpxuJh()).IsDebugEnabled())
            {
              num1 = 2;
              continue;
            }
            goto case 3;
          case 3:
            ThreadSubPool.JGGlvyBR6f8hwi9cVHIs(ThreadSubPool.HZqrJbBR4CIyLcHpxuJh(), (object) (this.logPrefix + ThreadSubPool.XdIKDPBRaXn0TYsEsF5l(-1426456882 ^ 2009939514 ^ -583672676) + (object) count));
            num1 = 8;
            continue;
          case 4:
            try
            {
              Monitor.Enter((object) queue, ref lockTaken);
              int num2 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
                num2 = 0;
              while (true)
              {
                ThreadSubPool.TaskInfo taskInfo2;
                switch (num2)
                {
                  case 1:
                    goto label_6;
                  case 2:
                    count = this.queue.Count;
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 1 : 1;
                    continue;
                  case 3:
                    taskInfo2 = ThreadSubPool.TaskInfo.Empty;
                    break;
                  default:
                    if (ThreadSubPool.zo3OhsBRtjG4ie9UESuD((object) this.queue) <= 0)
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 2 : 3;
                      continue;
                    }
                    taskInfo2 = this.queue.Dequeue();
                    break;
                }
                taskInfo1 = taskInfo2;
                num2 = 2;
              }
            }
            finally
            {
              int num3;
              if (!lockTaken)
                num3 = 2;
              else
                goto label_20;
label_19:
              switch (num3)
              {
                case 1:
                  break;
                default:
              }
label_20:
              ThreadSubPool.IXHOSpBRwutDgNayqCkh((object) queue);
              num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
              {
                num3 = 0;
                goto label_19;
              }
              else
                goto label_19;
            }
          case 5:
            lockTaken = false;
            num1 = 4;
            continue;
          case 6:
            queue = this.queue;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 5 : 1;
            continue;
          case 7:
label_6:
            if (taskInfo1.Equals(ThreadSubPool.TaskInfo.Empty))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 0;
              continue;
            }
            goto case 1;
          default:
            goto label_5;
        }
      }
label_5:
      return taskInfo1;
    }

    /// <summary>Метод, выполняющийся в потоке</summary>
    private void ExecuteInThread()
    {
      switch (1)
      {
        case 1:
          try
          {
            int num1;
            if (!ThreadSubPool.QfB08MBRHf7m2RxGGQal(ThreadSubPool.HZqrJbBR4CIyLcHpxuJh()))
              num1 = 6;
            else
              goto label_4;
label_3:
            ThreadSubPool.TaskInfo taskInfo1;
            ThreadSubPoolCallInfo threadSubPoolCallInfo;
            ThreadSubPool.TaskInfo taskInfo2;
            while (true)
            {
              switch (num1)
              {
                case 0:
                  goto label_41;
                case 1:
                  if (taskInfo2.Equals(ThreadSubPool.TaskInfo.Empty))
                  {
                    num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 0 : 0;
                    continue;
                  }
                  goto case 2;
                case 2:
                  ThreadSubPool.TaskInfo info = taskInfo1;
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  threadSubPoolCallInfo = DiagnosticsManager.StartCall<ThreadSubPoolCallInfo>((Func<ThreadSubPoolCallInfo>) (() => new ThreadSubPoolCallInfo(ThreadSubPool.\u003C\u003Ec__DisplayClass26_0.p1HBv0QvDNW85gadOc7m(ThreadSubPool.\u003C\u003Ec__DisplayClass26_0.OpQ4NqQvaXOP6picUqSu((object) info.Task)), info.Task.Method)));
                  num1 = 5;
                  continue;
                case 3:
                  goto label_4;
                case 4:
                case 6:
                case 7:
label_36:
                  taskInfo2 = taskInfo1 = this.Dequeue();
                  num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 1 : 0;
                  continue;
                case 5:
                  try
                  {
                    try
                    {
                      ThreadSubPool.DkPRJVBRAnKGrPVFhAbi((object) taskInfo1.Task);
                      int num2 = 0;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
                        num2 = 0;
                      switch (num2)
                      {
                        default:
                          goto label_36;
                      }
                    }
                    catch (Exception ex)
                    {
                      int num3 = 3;
                      while (true)
                      {
                        switch (num3)
                        {
                          case 1:
                          case 2:
                            if (threadSubPoolCallInfo != null)
                            {
                              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 0 : 0;
                              continue;
                            }
                            goto case 4;
                          case 3:
                            if (taskInfo1.ExceptionHandler == null)
                            {
                              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 1 : 1;
                              continue;
                            }
                            goto case 5;
                          case 4:
                            ThreadSubPool.a5UZFNBRxeCl57YrcAEi(ThreadSubPool.HZqrJbBR4CIyLcHpxuJh(), ThreadSubPool.SIq9SqBR7cM6Dyw9eA7N((object) this.logPrefix, ThreadSubPool.XdIKDPBRaXn0TYsEsF5l(-2099751081 ^ -2099757309), (object) string.Format((string) ThreadSubPool.XdIKDPBRaXn0TYsEsF5l(-342626196 - 1290888215 ^ -1633447705), (object) taskInfo1.TaskName)), (object) ex);
                            num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 6 : 3;
                            continue;
                          case 5:
                            taskInfo1.ExceptionHandler(ex);
                            num3 = 2;
                            continue;
                          case 6:
                            goto label_36;
                          default:
                            threadSubPoolCallInfo.Exception = ex;
                            num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 0 : 4;
                            continue;
                        }
                      }
                    }
                    finally
                    {
                      int num4;
                      if (taskInfo1.FinallyHandler == null)
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 1 : 3;
                      else
                        goto label_23;
label_20:
                      while (true)
                      {
                        switch (num4)
                        {
                          case 1:
                          case 3:
                            IDictionary<string, object> items = ELMAContext.Items;
                            if (items == null)
                            {
                              num4 = 2;
                              continue;
                            }
                            ThreadSubPool.HBpWmnBRmhIdF1VTood4((object) items);
                            num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 3 : 4;
                            continue;
                          case 2:
                          case 4:
                            goto label_26;
                          default:
                            goto label_23;
                        }
                      }
label_26:
label_23:
                      ThreadSubPool.jqhwEmBR0ltigXc39tK6((object) taskInfo1.FinallyHandler);
                      num4 = 1;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
                      {
                        num4 = 0;
                        goto label_20;
                      }
                      else
                        goto label_20;
                    }
                  }
                  finally
                  {
                    int num5;
                    if (threadSubPoolCallInfo == null)
                      num5 = 2;
                    else
                      goto label_30;
label_29:
                    switch (num5)
                    {
                      case 1:
                        break;
                      default:
                    }
label_30:
                    ThreadSubPool.WSIoYoBRyKRokbWZN6ya((object) threadSubPoolCallInfo);
                    num5 = 0;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
                    {
                      num5 = 0;
                      goto label_29;
                    }
                    else
                      goto label_29;
                  }
                default:
                  goto label_37;
              }
            }
label_41:
            break;
label_37:
            break;
label_4:
            ThreadSubPool.JGGlvyBR6f8hwi9cVHIs(ThreadSubPool.HZqrJbBR4CIyLcHpxuJh(), (object) (this.logPrefix + (string) ThreadSubPool.XdIKDPBRaXn0TYsEsF5l(--1867379187 ^ 1867312509)));
            num1 = 4;
            goto label_3;
          }
          catch (Exception ex)
          {
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
              num = 0;
            while (true)
            {
              switch (num)
              {
                case 1:
                  goto label_33;
                default:
                  ThreadSubPool.a5UZFNBRxeCl57YrcAEi(ThreadSubPool.HZqrJbBR4CIyLcHpxuJh(), (object) this.logPrefix, (object) ex);
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 0 : 1;
                  continue;
              }
            }
label_33:
            break;
          }
          finally
          {
            Interlocked.Decrement(ref this.threadCount);
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0)
              num = 0;
            while (true)
            {
              switch (num)
              {
                case 1:
                  ThreadSubPool.JGGlvyBR6f8hwi9cVHIs(ThreadSubPool.HZqrJbBR4CIyLcHpxuJh(), ThreadSubPool.ojEJONBRMt47gVgB2Nfx((object) this.logPrefix, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1178210108 ^ 1178276810)));
                  num = 2;
                  continue;
                case 2:
                  goto label_51;
                default:
                  if (ThreadSubPool.QfB08MBRHf7m2RxGGQal(ThreadSubPool.HZqrJbBR4CIyLcHpxuJh()))
                  {
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 0 : 1;
                    continue;
                  }
                  goto label_51;
              }
            }
label_51:;
          }
      }
    }

    internal static void XeQJHfBRN0fqVRE1D3dt() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool nQ6SdXBRPB4Qk7hNXWcO() => ThreadSubPool.y3jgQHBRe6Lww5n3Z7lk == null;

    internal static ThreadSubPool CgOU6QBR15MHcx4ibwtP() => ThreadSubPool.y3jgQHBRe6Lww5n3Z7lk;

    internal static bool cs8q8gBR3jkMxXNSCAWV([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static int eNkHXfBRpDtwZQmovukb([In] object obj0, int minThreadCount) => ThreadSubPool.LoadAppSettingsValue(obj0, minThreadCount);

    internal static object XdIKDPBRaXn0TYsEsF5l(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object l0UyYVBRDBSvVguMcVp0([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static int zo3OhsBRtjG4ie9UESuD([In] object obj0) => ((System.Collections.Generic.Queue<ThreadSubPool.TaskInfo>) obj0).Count;

    internal static void IXHOSpBRwutDgNayqCkh([In] object obj0) => Monitor.Exit(obj0);

    internal static object HZqrJbBR4CIyLcHpxuJh() => (object) Logger.Log;

    internal static void JGGlvyBR6f8hwi9cVHIs([In] object obj0, [In] object obj1) => ((ILogger) obj0).Debug(obj1);

    internal static bool QfB08MBRHf7m2RxGGQal([In] object obj0) => ((ILogger) obj0).IsDebugEnabled();

    internal static void DkPRJVBRAnKGrPVFhAbi([In] object obj0) => ((ThreadStart) obj0)();

    internal static object SIq9SqBR7cM6Dyw9eA7N([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);

    internal static void a5UZFNBRxeCl57YrcAEi([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Error(obj1, (Exception) obj2);

    internal static void jqhwEmBR0ltigXc39tK6([In] object obj0) => ((System.Action) obj0)();

    internal static void HBpWmnBRmhIdF1VTood4([In] object obj0) => ((ICollection<KeyValuePair<string, object>>) obj0).Clear();

    internal static void WSIoYoBRyKRokbWZN6ya([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object ojEJONBRMt47gVgB2Nfx([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    /// <summary>Информация о задаче выполняемой в потоке</summary>
    private struct TaskInfo
    {
      /// <summary>"Пустая" информация о задаче</summary>
      public static ThreadSubPool.TaskInfo Empty;
      /// <summary>Метод, выполняющийся в потоке</summary>
      public ThreadStart Task;
      /// <summary>Название метода</summary>
      public string TaskName;
      /// <summary>Действие, выполняемое при ошибке (в секции catch)</summary>
      public Action<Exception> ExceptionHandler;
      /// <summary>Действие, выполняемое в секции finally</summary>
      public System.Action FinallyHandler;
      private static object cXonJdQvOaH6nKoW2NKU;

      /// <summary>Сравнить два объекта</summary>
      /// <param name="info">Объект для сравнения</param>
      /// <returns><c>true</c> - если объекты эквиваленты</returns>
      public bool Equals(ThreadSubPool.TaskInfo info)
      {
        int num = 4;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_5;
            case 2:
              if (!ThreadSubPool.TaskInfo.H0t3M1QvPXd6OIoxwikd((object) this.ExceptionHandler, (object) info.ExceptionHandler))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 0 : 1;
                continue;
              }
              goto label_4;
            case 3:
              if (this.TaskName == info.TaskName)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 2 : 1;
                continue;
              }
              goto label_5;
            case 4:
              if (ThreadSubPool.TaskInfo.H0t3M1QvPXd6OIoxwikd((object) this.Task, (object) info.Task))
              {
                num = 3;
                continue;
              }
              goto label_5;
            default:
              goto label_4;
          }
        }
label_4:
        return ThreadSubPool.TaskInfo.H0t3M1QvPXd6OIoxwikd((object) this.FinallyHandler, (object) info.FinallyHandler);
label_5:
        return false;
      }

      static TaskInfo()
      {
        int num = 6;
        ThreadSubPool.TaskInfo taskInfo;
        while (true)
        {
          switch (num)
          {
            case 1:
              taskInfo.FinallyHandler = (System.Action) null;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 2 : 0;
              continue;
            case 2:
              ThreadSubPool.TaskInfo.Empty = taskInfo;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 3 : 4;
              continue;
            case 3:
              taskInfo.Task = (ThreadStart) null;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 1 : 7;
              continue;
            case 4:
              goto label_2;
            case 5:
              taskInfo = new ThreadSubPool.TaskInfo();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 1 : 3;
              continue;
            case 6:
              TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
              num = 5;
              continue;
            case 7:
              taskInfo.TaskName = (string) null;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 0 : 0;
              continue;
            default:
              taskInfo.ExceptionHandler = (Action<Exception>) null;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 1;
              continue;
          }
        }
label_2:;
      }

      internal static bool H0t3M1QvPXd6OIoxwikd([In] object obj0, [In] object obj1) => (Delegate) obj0 == (Delegate) obj1;

      internal static bool CVFkfYQv2PePZVhMNomE() => ThreadSubPool.TaskInfo.cXonJdQvOaH6nKoW2NKU == null;

      internal static object BLjfx9Qve3GXuG9XBEko() => ThreadSubPool.TaskInfo.cXonJdQvOaH6nKoW2NKU;
    }
  }
}
