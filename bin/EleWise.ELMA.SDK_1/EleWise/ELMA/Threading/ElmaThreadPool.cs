// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Threading.ElmaThreadPool
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagnostics;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime.Context;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;

namespace EleWise.ELMA.Threading
{
  /// <summary>Пул потоков</summary>
  internal class ElmaThreadPool
  {
    private static ElmaThreadPool.IThreadPoolPerfomanceCounter poolPerfomanceCounter;
    private readonly PerformanceCounter counter;
    private readonly Queue<ElmaThreadPool.WorkItem> queue;
    private readonly IDictionary<Thread, CancellationTokenSource> threadList;
    private int minThreadCount;
    private readonly string appSettingsKey;
    private readonly string threadTimeoutAppSettingsKey;
    private readonly string systemThreadTimeoutAppSettingsKey;
    private int threadsCount;
    private static ElmaThreadPool ygfZcfBSUaDevN6NB6Zo;

    /// <summary>Ctor</summary>
    /// <param name="name">Название пула</param>
    /// <param name="appSettingsKey">Ключ настройки приложения, содержащей размер пула (максимальное количество потоков)</param>
    /// <param name="minThreadCount">Минимальное количество потоков</param>
    public ElmaThreadPool(string name, string appSettingsKey, int minThreadCount)
    {
      ElmaThreadPool.jr23MtBSzMaWd3dkqKwl();
      this.queue = new Queue<ElmaThreadPool.WorkItem>();
      this.threadList = (IDictionary<Thread, CancellationTokenSource>) new Dictionary<Thread, CancellationTokenSource>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 8;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
        num = 5;
      while (true)
      {
        switch (num)
        {
          case 1:
            ElmaThreadPool.TJYZcQBiBjmZw0SjTef0((object) appSettingsKey, ElmaThreadPool.RbiDJ4BiF2DPweZIfDdM(694673736 ^ -23604109 ^ -672059585));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 0 : 0;
            continue;
          case 2:
            this.systemThreadTimeoutAppSettingsKey = (string) ElmaThreadPool.HSY71CBiWKn7AUqAgjqn((object) name, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606721224));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 4 : 0;
            continue;
          case 3:
            goto label_3;
          case 4:
            this.appSettingsKey = appSettingsKey;
            num = 9;
            continue;
          case 5:
            new Thread(new ParameterizedThreadStart(ElmaThreadPool.ElmaThreadPoolSystem)).Start((object) this);
            num = 3;
            continue;
          case 6:
            this.threadTimeoutAppSettingsKey = (string) ElmaThreadPool.HSY71CBiWKn7AUqAgjqn((object) name, ElmaThreadPool.RbiDJ4BiF2DPweZIfDdM(--1418440330 ^ 1418376202));
            num = 2;
            continue;
          case 7:
            this.counter = (PerformanceCounter) ElmaThreadPool.NE36VdBibEcxK72ntGEq(ElmaThreadPool.LL8t9MBiogYVq7MvdYgH(), (object) name);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 3 : 5;
            continue;
          case 8:
            ElmaThreadPool.TJYZcQBiBjmZw0SjTef0((object) name, ElmaThreadPool.RbiDJ4BiF2DPweZIfDdM(-87337865 ^ -87336863));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 0 : 1;
            continue;
          case 9:
            this.minThreadCount = minThreadCount;
            num = 7;
            continue;
          default:
            this.Name = name;
            num = 6;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Название пула</summary>
    public string Name
    {
      get => this.\u003CName\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>Поместить элемент в очередь на исполнение</summary>
    /// <param name="callback">Действие, которое необходимо выполнить</param>
    /// <returns></returns>
    public IElmaThreadPoolWorkItem Push(ThreadStart callback)
    {
      int num1 = 4;
      ElmaThreadPool.WorkItem workItem;
      Queue<ElmaThreadPool.WorkItem> queue;
      bool lockTaken;
      while (true)
      {
        switch (num1)
        {
          case 1:
            lockTaken = false;
            num1 = 2;
            continue;
          case 2:
            goto label_3;
          case 3:
            queue = this.queue;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 1 : 1;
            continue;
          case 4:
            workItem = new ElmaThreadPool.WorkItem(callback, this);
            num1 = 3;
            continue;
          default:
            goto label_15;
        }
      }
label_3:
      try
      {
        Monitor.Enter((object) queue, ref lockTaken);
        int num2 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
          num2 = 1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              this.queue.Enqueue(workItem);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 0;
              continue;
            default:
              goto label_15;
          }
        }
      }
      finally
      {
        if (lockTaken)
        {
          int num3 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
            num3 = 0;
          while (true)
          {
            switch (num3)
            {
              case 1:
                ElmaThreadPool.vyn5RSBihWcgTPEbNkjD((object) queue);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 0;
                continue;
              default:
                goto label_12;
            }
          }
        }
label_12:;
      }
label_15:
      return (IElmaThreadPoolWorkItem) workItem;
    }

    /// <summary>Получить количество потоков пула</summary>
    /// <returns>Количество потоков</returns>
    internal int GetThreadsCount() => this.threadsCount;

    /// <summary>Системный поток</summary>
    /// <param name="state">Параметры</param>
    private static void ElmaThreadPoolSystem(object state)
    {
      int num1 = 1;
      ElmaThreadPool elmaThreadPool1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            elmaThreadPool1 = (ElmaThreadPool) null;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_53;
          default:
            goto label_2;
        }
      }
label_53:
      return;
label_2:
      try
      {
        elmaThreadPool1 = (ElmaThreadPool) state;
        int num2 = 19;
        while (true)
        {
          int num3;
          int count;
          int setting;
          Thread key;
          CancellationTokenSource cancellationTokenSource;
          IEnumerator<KeyValuePair<Thread, CancellationTokenSource>> enumerator;
          int num4;
          switch (num2)
          {
            case 1:
              if (count > 0)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 18 : 5;
                continue;
              }
              goto case 16;
            case 2:
              elmaThreadPool1.threadsCount += -count;
              num2 = 7;
              continue;
            case 3:
            case 10:
              key = new Thread(new ParameterizedThreadStart(ElmaThreadPool.ExecuteInThread))
              {
                IsBackground = true
              };
              num2 = 5;
              continue;
            case 4:
              key.Start((object) new object[2]
              {
                (object) elmaThreadPool1,
                (object) cancellationTokenSource
              });
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 15 : 0;
              continue;
            case 5:
              cancellationTokenSource = new CancellationTokenSource();
              num3 = 4;
              break;
            case 7:
              PerformanceCounter counter = elmaThreadPool1.counter;
              if (counter == null)
              {
                num2 = 6;
                continue;
              }
              ElmaThreadPool.sc45sLBif78cu89csyjQ((object) counter, (long) -count);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 0 : 0;
              continue;
            case 8:
label_7:
              elmaThreadPool1.threadsCount -= count;
              num3 = 23;
              break;
            case 9:
              try
              {
label_23:
                if (enumerator.MoveNext())
                  goto label_19;
                else
                  goto label_24;
label_18:
                KeyValuePair<Thread, CancellationTokenSource> current;
                int num5;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                      goto label_19;
                    case 2:
                      goto label_23;
                    case 3:
                      elmaThreadPool1.threadList.Remove(current.Key);
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 0 : 0;
                      continue;
                    case 4:
                      goto label_7;
                    default:
                      ElmaThreadPool.fiqipXBiGGAIOW6vvMGB((object) current.Value);
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 2;
                      continue;
                  }
                }
label_19:
                current = enumerator.Current;
                num5 = 3;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
                {
                  num5 = 1;
                  goto label_18;
                }
                else
                  goto label_18;
label_24:
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 4 : 1;
                goto label_18;
              }
              finally
              {
                int num6;
                if (enumerator == null)
                  num6 = 2;
                else
                  goto label_29;
label_28:
                switch (num6)
                {
                  case 1:
                  case 2:
                }
label_29:
                ElmaThreadPool.E2FJZwBiESNcRYti3r6k((object) enumerator);
                num6 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
                {
                  num6 = 0;
                  goto label_28;
                }
                else
                  goto label_28;
              }
            case 11:
              ElmaThreadPool.GMAu3WBiQCVIjSEIfO4x(EleWise.ELMA.SR.GetSetting<int>(elmaThreadPool1.systemThreadTimeoutAppSettingsKey, 50));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 14 : 4;
              continue;
            case 12:
              ++num4;
              num2 = 13;
              continue;
            case 13:
            case 17:
              if (num4 < -count)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 10 : 6;
                continue;
              }
              goto case 2;
            case 14:
            case 19:
              setting = EleWise.ELMA.SR.GetSetting<int>(elmaThreadPool1.appSettingsKey, elmaThreadPool1.minThreadCount);
              num2 = 20;
              continue;
            case 15:
              elmaThreadPool1.threadList.Add(key, cancellationTokenSource);
              num2 = 12;
              continue;
            case 16:
              if (count >= 0)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 22 : 22;
                continue;
              }
              goto case 21;
            case 18:
              enumerator = elmaThreadPool1.threadList.Take<KeyValuePair<Thread, CancellationTokenSource>>(count).GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 9 : 6;
              continue;
            case 20:
              count = elmaThreadPool1.threadsCount - setting;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 1 : 1;
              continue;
            case 21:
              num4 = 0;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 17 : 14;
              continue;
            default:
              ElmaThreadPool elmaThreadPool2 = elmaThreadPool1;
              int threadsCount = elmaThreadPool2.threadsCount;
              IDictionary<Thread, CancellationTokenSource> threadList = elmaThreadPool1.threadList;
              // ISSUE: reference to a compiler-generated field
              Func<KeyValuePair<Thread, CancellationTokenSource>, bool> func = ElmaThreadPool.\u003C\u003Ec.\u003C\u003E9__19_0;
              Func<KeyValuePair<Thread, CancellationTokenSource>, bool> match;
              if (func == null)
              {
                // ISSUE: reference to a compiler-generated field
                ElmaThreadPool.\u003C\u003Ec.\u003C\u003E9__19_0 = match = (Func<KeyValuePair<Thread, CancellationTokenSource>, bool>) (t => t.Key.ThreadState.HasFlag((Enum) System.Threading.ThreadState.Aborted) || t.Key.ThreadState.HasFlag((Enum) System.Threading.ThreadState.Stopped));
              }
              else
                goto label_25;
label_44:
              int num7 = threadList.RemoveAll<KeyValuePair<Thread, CancellationTokenSource>>(match);
              elmaThreadPool2.threadsCount = threadsCount - num7;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 11 : 8;
              continue;
label_25:
              match = func;
              goto label_44;
          }
          num2 = num3;
        }
      }
      catch
      {
        int num8 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0)
          num8 = 0;
        while (true)
        {
          switch (num8)
          {
            case 1:
              ElmaThreadPool.Hp3RA4BiCvgLA6keVt0j((object) new Thread(new ParameterizedThreadStart(ElmaThreadPool.ElmaThreadPoolSystem)), (object) elmaThreadPool1);
              num8 = 3;
              continue;
            case 2:
              goto label_51;
            case 3:
              goto label_48;
            default:
              if (elmaThreadPool1 == null)
              {
                num8 = 2;
                continue;
              }
              goto case 1;
          }
        }
label_51:
        return;
label_48:;
      }
    }

    /// <summary>Выполнить в отдельном потоке</summary>
    /// <param name="state">Параметры</param>
    private static void ExecuteInThread(object state)
    {
      int num1 = 2;
      bool flag;
      CancellationTokenSource cancellationTokenSource;
      ElmaThreadPool elmaThreadPool;
      ElmaThreadPool.WorkItem workItem1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            elmaThreadPool = (ElmaThreadPool) null;
            num1 = 3;
            continue;
          case 2:
            workItem1 = (ElmaThreadPool.WorkItem) null;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 1 : 0;
            continue;
          case 3:
            cancellationTokenSource = (CancellationTokenSource) null;
            num1 = 5;
            continue;
          case 4:
            goto label_67;
          case 5:
            flag = false;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_67:
      return;
label_4:
      try
      {
        object[] objArray = (object[]) state;
        elmaThreadPool = (ElmaThreadPool) objArray[0];
        cancellationTokenSource = (CancellationTokenSource) objArray[1];
        int num2 = 4;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
          num2 = 9;
        IDisposable disposable;
        Queue<ElmaThreadPool.WorkItem> queue;
        bool lockTaken;
        while (true)
        {
          switch (num2)
          {
            case 2:
label_24:
              if (workItem1 == null)
              {
                num2 = 4;
                continue;
              }
              goto case 11;
            case 3:
              ElmaThreadPool.GMAu3WBiQCVIjSEIfO4x(EleWise.ELMA.SR.GetSetting<int>(elmaThreadPool.threadTimeoutAppSettingsKey, 50));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 0 : 0;
              continue;
            case 4:
              if (cancellationTokenSource.IsCancellationRequested)
              {
                num2 = 6;
                continue;
              }
              goto case 3;
            case 5:
              try
              {
                Monitor.Enter((object) queue, ref lockTaken);
                int num3 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
                  num3 = 0;
                while (true)
                {
                  ElmaThreadPool.WorkItem workItem2;
                  switch (num3)
                  {
                    case 1:
                      workItem2 = elmaThreadPool.queue.Dequeue();
                      break;
                    case 2:
                      workItem2 = (ElmaThreadPool.WorkItem) null;
                      break;
                    case 3:
                      goto label_24;
                    default:
                      if (ElmaThreadPool.l1oVjBBivQgvjjUInVjF((object) elmaThreadPool.queue) > 0)
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 1 : 1;
                        continue;
                      }
                      goto case 2;
                  }
                  workItem1 = workItem2;
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 1 : 3;
                }
              }
              finally
              {
                if (lockTaken)
                {
                  int num4 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
                    num4 = 1;
                  while (true)
                  {
                    switch (num4)
                    {
                      case 1:
                        ElmaThreadPool.vyn5RSBihWcgTPEbNkjD((object) queue);
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_39;
                    }
                  }
                }
label_39:;
              }
            case 6:
              goto label_62;
            case 7:
              disposable = (IDisposable) ElmaThreadPool.gThV3vBiI7OiJ7dmutoj();
              num2 = 12;
              continue;
            case 8:
              lockTaken = false;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 0 : 5;
              continue;
            case 10:
              ElmaThreadPool.rM3urjBiuU1H6K5S9ho9(ElmaThreadPool.TuOpMmBiZKwbPjIiowmG((object) workItem1));
              num2 = 7;
              continue;
            case 11:
              ElmaThreadPool.Q8YKOIBi8po5poNjQf9f((object) workItem1, (object) Thread.CurrentThread);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 10 : 7;
              continue;
            case 12:
              try
              {
                ElmaThreadPool.xBFgWxBiStOYDOkh18yr(ElmaThreadPool.oop7ZbBiVhRUbVWVkQP2((object) workItem1));
                int num5 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
                  num5 = 0;
                switch (num5)
                {
                  default:
                    goto label_21;
                }
              }
              finally
              {
                if (disposable != null)
                {
                  int num6 = 1;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
                    num6 = 1;
                  while (true)
                  {
                    switch (num6)
                    {
                      case 1:
                        ElmaThreadPool.E2FJZwBiESNcRYti3r6k((object) disposable);
                        num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_16;
                    }
                  }
                }
label_16:;
              }
            case 13:
label_21:
              workItem1.WaitExecuteEvent.Set();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 1 : 1;
              continue;
            default:
              queue = elmaThreadPool.queue;
              num2 = 8;
              continue;
          }
        }
label_62:;
      }
      catch (Exception ex)
      {
        int num7 = 4;
        while (true)
        {
          switch (num7)
          {
            case 1:
              goto label_58;
            case 2:
              goto label_53;
            case 3:
              flag = ex is ThreadAbortException;
              num7 = 6;
              continue;
            case 4:
              ElmaThreadPool.QUy40IBiRTiIdtJlWskl(ElmaThreadPool.N4WpBpBiisGfoGUkoMYc(), ElmaThreadPool.RbiDJ4BiF2DPweZIfDdM(813604817 ^ 813663557), (object) ex);
              num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 0 : 3;
              continue;
            case 5:
              ElmaThreadPool.rM3urjBiuU1H6K5S9ho9((object) workItem1.WaitExecuteEvent);
              num7 = 2;
              continue;
            case 6:
              if (workItem1 != null)
              {
                num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 3 : 8;
                continue;
              }
              goto label_57;
            case 7:
              workItem1.WorkerThread = (Thread) null;
              num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 0 : 0;
              continue;
            case 8:
              if (flag)
              {
                num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 1 : 0;
                continue;
              }
              goto case 7;
            default:
              workItem1.WaitThreadEvent.Set();
              num7 = 5;
              continue;
          }
        }
label_58:
        return;
label_53:
        return;
label_57:;
      }
      finally
      {
        int num8;
        if (flag)
          num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 3 : 5;
        else
          goto label_63;
label_56:
        while (true)
        {
          switch (num8)
          {
            case 1:
            case 5:
              goto label_70;
            case 3:
              goto label_65;
            case 4:
              goto label_63;
            case 6:
              ElmaThreadPool.JB8OD4BiKlr0T1Dg2YH4((object) cancellationTokenSource);
              num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 1 : 1;
              continue;
            default:
              if (cancellationTokenSource != null)
              {
                num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 6 : 2;
                continue;
              }
              goto label_70;
          }
        }
label_70:
label_63:
        if (elmaThreadPool == null)
        {
          num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 0;
          goto label_56;
        }
label_65:
        PerformanceCounter counter = elmaThreadPool.counter;
        if (counter == null)
        {
          num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 7 : 7;
          goto label_56;
        }
        else
        {
          ElmaThreadPool.rUfqTkBiq4j6mgmINX5u((object) counter);
          num8 = 2;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
          {
            num8 = 2;
            goto label_56;
          }
          else
            goto label_56;
        }
      }
    }

    /// <summary>Прекратить работу потока</summary>
    /// <param name="thread">Поток</param>
    private void AbortThread(Thread thread)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (thread == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 1 : 1;
              continue;
            }
            goto case 3;
          case 3:
            if (!thread.ThreadState.HasFlag((Enum) System.Threading.ThreadState.Aborted))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 4:
            goto label_10;
          case 5:
            goto label_13;
          case 6:
            ElmaThreadPool.WmAEdqBiT1dwClDOONFx((object) thread);
            num = 4;
            continue;
          default:
            if (!ElmaThreadPool.pFLsHIBiXLt3q0LwXXk2((object) thread).HasFlag((Enum) System.Threading.ThreadState.Stopped))
            {
              thread.Abort();
              num = 6;
              continue;
            }
            num = 5;
            continue;
        }
      }
label_5:
      return;
label_10:
      return;
label_13:
      return;
label_2:;
    }

    /// <summary>Счетчик производительности</summary>
    private static ElmaThreadPool.IThreadPoolPerfomanceCounter PoolPerfomanceCounter
    {
      get
      {
        int num = 1;
        ElmaThreadPool.IThreadPoolPerfomanceCounter perfomanceCounter;
        while (true)
        {
          switch (num)
          {
            case 1:
              perfomanceCounter = ElmaThreadPool.poolPerfomanceCounter;
              if (perfomanceCounter == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            default:
              goto label_5;
          }
        }
label_2:
        return perfomanceCounter;
label_5:
        return ElmaThreadPool.poolPerfomanceCounter = Locator.GetServiceNotNull<ElmaThreadPool.IThreadPoolPerfomanceCounter>();
      }
    }

    internal static void jr23MtBSzMaWd3dkqKwl() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object RbiDJ4BiF2DPweZIfDdM(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void TJYZcQBiBjmZw0SjTef0([In] object obj0, [In] object obj1) => Contract.ArgumentNotNullOrEmpty((string) obj0, (string) obj1);

    internal static object HSY71CBiWKn7AUqAgjqn([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static object LL8t9MBiogYVq7MvdYgH() => (object) ElmaThreadPool.PoolPerfomanceCounter;

    internal static object NE36VdBibEcxK72ntGEq([In] object obj0, [In] object obj1) => (object) ((ElmaThreadPool.IThreadPoolPerfomanceCounter) obj0).AddCounter((string) obj1);

    internal static bool xfnTsmBSsHfjGnljrhEd() => ElmaThreadPool.ygfZcfBSUaDevN6NB6Zo == null;

    internal static ElmaThreadPool VPDR3kBScIfy2WsbUNmd() => ElmaThreadPool.ygfZcfBSUaDevN6NB6Zo;

    internal static void vyn5RSBihWcgTPEbNkjD([In] object obj0) => Monitor.Exit(obj0);

    internal static void fiqipXBiGGAIOW6vvMGB([In] object obj0) => ((CancellationTokenSource) obj0).Cancel();

    internal static void E2FJZwBiESNcRYti3r6k([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static long sc45sLBif78cu89csyjQ([In] object obj0, [In] long obj1) => ((PerformanceCounter) obj0).IncrementBy(obj1);

    internal static void GMAu3WBiQCVIjSEIfO4x([In] int obj0) => Thread.Sleep(obj0);

    internal static void Hp3RA4BiCvgLA6keVt0j([In] object obj0, [In] object obj1) => ((Thread) obj0).Start(obj1);

    internal static int l1oVjBBivQgvjjUInVjF([In] object obj0) => ((Queue<ElmaThreadPool.WorkItem>) obj0).Count;

    internal static void Q8YKOIBi8po5poNjQf9f([In] object obj0, [In] object obj1) => ((ElmaThreadPool.WorkItem) obj0).WorkerThread = (Thread) obj1;

    internal static object TuOpMmBiZKwbPjIiowmG([In] object obj0) => (object) ((ElmaThreadPool.WorkItem) obj0).WaitThreadEvent;

    internal static bool rM3urjBiuU1H6K5S9ho9([In] object obj0) => ((EventWaitHandle) obj0).Set();

    internal static object gThV3vBiI7OiJ7dmutoj() => (object) ELMAContext.Create();

    internal static object oop7ZbBiVhRUbVWVkQP2([In] object obj0) => (object) ((ElmaThreadPool.WorkItem) obj0).Callback;

    internal static void xBFgWxBiStOYDOkh18yr([In] object obj0) => ((ThreadStart) obj0)();

    internal static object N4WpBpBiisGfoGUkoMYc() => (object) Logger.Log;

    internal static void QUy40IBiRTiIdtJlWskl([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Error(obj1, (Exception) obj2);

    internal static long rUfqTkBiq4j6mgmINX5u([In] object obj0) => ((PerformanceCounter) obj0).Decrement();

    internal static void JB8OD4BiKlr0T1Dg2YH4([In] object obj0) => __nonvirtual (((CancellationTokenSource) obj0).Dispose());

    internal static System.Threading.ThreadState pFLsHIBiXLt3q0LwXXk2([In] object obj0) => ((Thread) obj0).ThreadState;

    internal static void WmAEdqBiT1dwClDOONFx([In] object obj0) => ((Thread) obj0).Join();

    /// <summary>Элемент очереди обработки</summary>
    internal class WorkItem : IElmaThreadPoolWorkItem, IDisposable
    {
      /// <summary>Пул, в котором обрабатывается элемент</summary>
      private readonly ElmaThreadPool pool;
      private bool disposed;
      private static ElmaThreadPool.WorkItem zpB1AUQCV6S51vHASFFs;

      /// <summary>Ctor</summary>
      /// <param name="callback">Действие, которое необходимо выполнить</param>
      /// <param name="pool">Пул</param>
      public WorkItem(ThreadStart callback, ElmaThreadPool pool)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 3;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
          num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_3;
            case 1:
              this.WaitThreadEvent = new ManualResetEvent(false);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 0 : 4;
              continue;
            case 2:
              this.pool = pool;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 0 : 0;
              continue;
            case 3:
              this.Callback = callback;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 1 : 0;
              continue;
            case 4:
              this.WaitExecuteEvent = new ManualResetEvent(false);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 2 : 2;
              continue;
            default:
              goto label_8;
          }
        }
label_3:
        return;
label_8:;
      }

      /// <summary>Finalize</summary>
      ~WorkItem()
      {
        switch (1)
        {
          case 1:
            try
            {
              this.Dispose();
              int num = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
                num = 0;
              switch (num)
              {
                case 0:
                  return;
                default:
                  return;
              }
            }
            finally
            {
              ElmaThreadPool.WorkItem.YFxq3cQCRjbE95bX9LsR((object) this);
              int num = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
                num = 0;
              switch (num)
              {
                default:
              }
            }
        }
      }

      /// <summary>Действие, которое необходимо выполнить</summary>
      public ThreadStart Callback
      {
        get => this.\u003CCallback\u003Ek__BackingField;
        private set
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                this.\u003CCallback\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }
      }

      /// <summary>
      /// Событие, сигнализирующее о том, что поток взял элемент в обработку
      /// </summary>
      public ManualResetEvent WaitThreadEvent
      {
        get => this.\u003CWaitThreadEvent\u003Ek__BackingField;
        private set
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                this.\u003CWaitThreadEvent\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }
      }

      /// <summary>
      /// Событие, сигнализирующее о том, что поток завершил обработку элемента
      /// </summary>
      public ManualResetEvent WaitExecuteEvent
      {
        get => this.\u003CWaitExecuteEvent\u003Ek__BackingField;
        private set
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                this.\u003CWaitExecuteEvent\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }
      }

      /// <summary>Поток, обрабатывающий элемент очереди</summary>
      public Thread WorkerThread
      {
        get => this.\u003CWorkerThread\u003Ek__BackingField;
        set
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                this.\u003CWorkerThread\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }
      }

      /// <inheritdoc />
      public void Dispose()
      {
        int num = 3;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_6;
            case 2:
            case 6:
              ElmaThreadPool.WorkItem.SbBGhwQCK8fqt3tAx0Hx((object) this);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 1 : 1;
              continue;
            case 3:
              if (this.disposed)
              {
                num = 2;
                continue;
              }
              break;
            case 4:
              ElmaThreadPool.WorkItem.UhpBxDQCqAxpGBWjG5pj((object) this.WaitThreadEvent);
              num = 5;
              continue;
            case 5:
              this.disposed = true;
              num = 6;
              continue;
          }
          ElmaThreadPool.WorkItem.UhpBxDQCqAxpGBWjG5pj((object) this.WaitExecuteEvent);
          num = 4;
        }
label_6:;
      }

      /// <inheritdoc />
      public void WaitThread()
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.WaitThreadEvent.WaitOne();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 0 : 0;
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
      public bool WaitExecute(TimeSpan timeout) => ElmaThreadPool.WorkItem.or3yZ1QCXrVy4Y42qTy1((object) this.WaitExecuteEvent, timeout);

      /// <inheritdoc />
      public void AbortWorkerThread()
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              ElmaThreadPool.WorkItem.x9R3S0QCTaQl6Zp0FIjI((object) this.pool, (object) this.WorkerThread);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }

      internal static bool cJTfSOQCSm9XOwd91dGS() => ElmaThreadPool.WorkItem.zpB1AUQCV6S51vHASFFs == null;

      internal static ElmaThreadPool.WorkItem qXQdZCQCi1a4bV0BFl8r() => ElmaThreadPool.WorkItem.zpB1AUQCV6S51vHASFFs;

      internal static void YFxq3cQCRjbE95bX9LsR([In] object obj0) => __nonvirtual (obj0.Finalize());

      internal static void UhpBxDQCqAxpGBWjG5pj([In] object obj0) => ((WaitHandle) obj0).Close();

      internal static void SbBGhwQCK8fqt3tAx0Hx([In] object obj0) => GC.SuppressFinalize(obj0);

      internal static bool or3yZ1QCXrVy4Y42qTy1([In] object obj0, [In] TimeSpan obj1) => ((WaitHandle) obj0).WaitOne(obj1);

      internal static void x9R3S0QCTaQl6Zp0FIjI([In] object obj0, [In] object obj1) => ((ElmaThreadPool) obj0).AbortThread((Thread) obj1);
    }

    /// <summary>Интерфейс счетчика производительности пула потоков</summary>
    internal interface IThreadPoolPerfomanceCounter
    {
      /// <summary>Добавить счетчик производительности</summary>
      /// <param name="counterName">Название счетчика</param>
      PerformanceCounter AddCounter(string counterName);
    }

    /// <summary>Сервис счетчика производительности пула потоков</summary>
    [Service]
    private class ThreadPoolPerfomanceCounter : ElmaThreadPool.IThreadPoolPerfomanceCounter
    {
      private readonly object registrar;
      internal static object AVRsLLQC2KYFs0EPh2ur;

      /// <summary>Ctor</summary>
      /// <param name="registrar">Регистратор категорий производительности</param>
      public ThreadPoolPerfomanceCounter(IPerformanceCategoryRegistrar registrar)
      {
        ElmaThreadPool.ThreadPoolPerfomanceCounter.HglekMQC1gNg8mdGhNj2();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
          num = 0;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_3;
            default:
              this.registrar = (object) registrar;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 1 : 1;
              continue;
          }
        }
label_3:;
      }

      /// <inheritdoc />
      public PerformanceCounter AddCounter(string counterName)
      {
        int num = 1;
        string categoryName;
        while (true)
        {
          switch (num)
          {
            case 1:
              categoryName = (string) ElmaThreadPool.ThreadPoolPerfomanceCounter.ESCAGLQCN7RKoG0JeGof(95909607 + 343705423 ^ 439783160) + counterName;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 0 : 0;
              continue;
            case 2:
            case 4:
              goto label_6;
            case 3:
              ((IPerformanceCategoryRegistrar) this.registrar).CreateCategory(categoryName, (string) ElmaThreadPool.ThreadPoolPerfomanceCounter.uNmLMLQCpHgyADJaTHSg(ElmaThreadPool.ThreadPoolPerfomanceCounter.ESCAGLQCN7RKoG0JeGof(1470440286 ^ 1470124930)), PerformanceCounterCategoryType.SingleInstance, (IEnumerable<CounterCreationData>) new CounterCreationData[1]
              {
                new CounterCreationData(counterName, "", PerformanceCounterType.NumberOfItems32)
              });
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 4 : 3;
              continue;
            default:
              if (ElmaThreadPool.ThreadPoolPerfomanceCounter.XHymDJQC3Fx9VIKawFNA((object) categoryName))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 1 : 2;
                continue;
              }
              goto case 3;
          }
        }
label_6:
        PerformanceCounter performanceCounter = new PerformanceCounter();
        performanceCounter.CategoryName = categoryName;
        ElmaThreadPool.ThreadPoolPerfomanceCounter.BRI1nsQCawZ2pPc8vdIo((object) performanceCounter, (object) counterName);
        ElmaThreadPool.ThreadPoolPerfomanceCounter.kxJVHhQCDN3basBMeCGf((object) performanceCounter, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1217523399 ^ -1217524739));
        ElmaThreadPool.ThreadPoolPerfomanceCounter.dRdB9mQCtXbR3idTcPJq((object) performanceCounter, false);
        ElmaThreadPool.ThreadPoolPerfomanceCounter.S0XuE9QCw3EWgMuQX6IZ((object) performanceCounter, 0L);
        return performanceCounter;
      }

      internal static void HglekMQC1gNg8mdGhNj2() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool FS8VnqQCeIeY9GbHOLgQ() => ElmaThreadPool.ThreadPoolPerfomanceCounter.AVRsLLQC2KYFs0EPh2ur == null;

      internal static ElmaThreadPool.ThreadPoolPerfomanceCounter K8jT2gQCPt2OvgUIIIKP() => (ElmaThreadPool.ThreadPoolPerfomanceCounter) ElmaThreadPool.ThreadPoolPerfomanceCounter.AVRsLLQC2KYFs0EPh2ur;

      internal static object ESCAGLQCN7RKoG0JeGof(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static bool XHymDJQC3Fx9VIKawFNA([In] object obj0) => PerformanceCounterCategory.Exists((string) obj0);

      internal static object uNmLMLQCpHgyADJaTHSg([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

      internal static void BRI1nsQCawZ2pPc8vdIo([In] object obj0, [In] object obj1) => ((PerformanceCounter) obj0).CounterName = (string) obj1;

      internal static void kxJVHhQCDN3basBMeCGf([In] object obj0, [In] object obj1) => ((PerformanceCounter) obj0).MachineName = (string) obj1;

      internal static void dRdB9mQCtXbR3idTcPJq([In] object obj0, [In] bool obj1) => ((PerformanceCounter) obj0).ReadOnly = obj1;

      internal static void S0XuE9QCw3EWgMuQX6IZ([In] object obj0, [In] long obj1) => ((PerformanceCounter) obj0).RawValue = obj1;
    }
  }
}
