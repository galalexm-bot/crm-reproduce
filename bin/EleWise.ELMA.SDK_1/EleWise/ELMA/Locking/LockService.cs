// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Locking.LockService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Configuration;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Concurrent;
using System.Configuration.Provider;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace EleWise.ELMA.Locking
{
  /// <summary>Cервис блокировок</summary>
  public abstract class LockService : ProviderBase, ILockService, IAsyncLockService
  {
    protected readonly TimeSpan DEFAULT_VALID_FOR;
    protected readonly TimeSpan DEFAULT_REPEAT_INTERVAL;
    private readonly ConcurrentDictionary<IDisposable, Lock> locks;
    protected static TimeSpan InfiniteTimeSpan;
    internal static LockService EGJHU2hrvh3ZDlpJuh7n;

    /// <inheritdoc />
    public virtual Task<ILock> TryAcquireLockAsync(
      string name,
      TimeSpan? maxValidFor,
      TimeSpan? timeout,
      CancellationToken token = default (CancellationToken))
    {
      return this.TryAcquireLockAsync(name, token, maxValidFor, timeout, new TimeSpan?());
    }

    /// <inheritdoc />
    public virtual Task<ILock> AcquireLockAsync(
      string name,
      TimeSpan? maxValidFor,
      TimeSpan? timeout,
      CancellationToken token = default (CancellationToken))
    {
      return this.AcquireLockAsync(name, token, maxValidFor, timeout, new TimeSpan?());
    }

    /// <summary>
    /// Захват блокировки с возможностью дополнительно указать интервал опроса
    /// </summary>
    /// <param name="name">Имя блокировки</param>
    /// <param name="token">Токен отмены</param>
    /// <param name="maxValidFor">Время жизни блокировки</param>
    /// <param name="timeout">Таймаут блокировки</param>
    /// <param name="repeatInterval">Время опроса повторного захвата блокировки</param>
    /// <returns>Блокировка</returns>
    protected virtual Task<ILock> AcquireLockAsync(
      string name,
      CancellationToken token,
      TimeSpan? maxValidFor,
      TimeSpan? timeout,
      TimeSpan? repeatInterval)
    {
      return this.AcquireLockInternalAsync(name, token, maxValidFor, timeout, new TimeSpan?(), true, true).AsTask().ContinueWith<ILock>((Func<Task<ILock>, ILock>) (t =>
      {
        if (t.IsFaulted)
        {
          this.Logger.Error((Exception) t.Exception, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1581325282 << 3 ^ -234141884), (object) name);
          throw t.Exception;
        }
        this.Logger.Debug((object) string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1925118608 << 2 ^ -889687474), (object) name));
        return t.Result;
      }));
    }

    /// <summary>
    /// Попытка захвата блокировки с возможностью дополнительно указать интервал опроса
    /// </summary>
    /// <param name="name">Имя блокировки</param>
    /// <param name="token">Токен отмены</param>
    /// <param name="maxValidFor">Время жизни блокировки</param>
    /// <param name="timeout">Таймаут блокировки</param>
    /// <param name="repeatInterval">Время опроса повторного захвата блокировки</param>
    /// <returns>True - в случае успеха</returns>
    protected virtual Task<ILock> TryAcquireLockAsync(
      string name,
      CancellationToken token,
      TimeSpan? maxValidFor,
      TimeSpan? timeout,
      TimeSpan? repeatInterval)
    {
      return this.AcquireLockInternalAsync(name, token, maxValidFor, timeout, new TimeSpan?(), false, true).AsTask().ContinueWith<ILock>((Func<Task<ILock>, ILock>) (t =>
      {
        if (t.IsFaulted)
        {
          this.Logger.Error((Exception) t.Exception, z2jc63fLkugS1X8Q9N.tE1kD1vbB(132912447 ^ 133139819), (object) name);
        }
        else
        {
          if (t.Result != null)
          {
            this.Logger.Debug((object) string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(993438473 ^ 993342215), (object) name));
            return t.Result;
          }
          this.Logger.Warn((object) string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1178210108 ^ 1178179478), (object) name, (object) timeout));
        }
        return (ILock) null;
      }));
    }

    /// <summary>
    /// Базовая блокировка с предварительной блокировкой только на локальной ноде
    /// </summary>
    /// <param name="name">Имя блокировки</param>
    /// <param name="token">Токен блокировки</param>
    /// <param name="maxValidFor">Время жизни блокировки</param>
    /// <param name="timeout">Таймаут блокировки</param>
    /// <param name="repeatInterval">Время опроса повторного захвата блокировки</param>
    /// <param name="throwOnTimeout">Кидать исключение в случае таймаута?</param>
    /// <param name="isAsync">Запускаем асинхронный код</param>
    /// <returns>Блокировка</returns>
    private ValueTask<ILock> AcquireLockInternalAsync(
      string name,
      CancellationToken token,
      TimeSpan? maxValidFor,
      TimeSpan? timeout,
      TimeSpan? repeatInterval,
      bool throwOnTimeout,
      bool isAsync)
    {
      string internalLockName = this.GetInternalLockName(name);
      this.Logger.Debug((object) string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1487388570 ^ -1487153386), (object) internalLockName, (object) timeout));
      IDisposable disposable = this.LockKeyFactory.Get(this.ApplicationEnvironment.GetEnvironmentId() + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1669371371 ^ 1669448873) + internalLockName);
      LockService.ThreadSafeSemaphoreSlim semaphore = LockService.ThreadSafeSemaphoreSlim.Get((object) disposable);
      return this.AcquireLockInternalAsync(internalLockName, token, maxValidFor, timeout, repeatInterval, throwOnTimeout, isAsync, disposable, semaphore);
    }

    private async ValueTask<ILock> AcquireLockInternalAsync(
      string internalName,
      CancellationToken token,
      TimeSpan? maxValidFor,
      TimeSpan? timeout,
      TimeSpan? repeatInterval,
      bool throwOnTimeout,
      bool isAsync,
      IDisposable monitorObj,
      LockService.ThreadSafeSemaphoreSlim semaphore)
    {
      int num1 = 1;
      int num2;
      ILock result1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            num2 = (^this).\u003C\u003E1__state;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 0;
            continue;
          case 2:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003Et__builder.SetResult(result1);
            num1 = 4;
            continue;
          case 3:
            try
            {
              int num3;
              if (num2 == 0)
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 0 : 0;
              else
                goto label_8;
label_5:
              // ISSUE: variable of a compiler-generated type
              LockService.\u003C\u003Ec__DisplayClass6_0 cDisplayClass60;
              TimeSpan semaphoreTimeout;
              TimeSpan? nullable;
              while (true)
              {
                int num4;
                switch (num3)
                {
                  case 1:
                    result1 = (ILock) null;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 3 : 3;
                    continue;
                  case 2:
                    if (!throwOnTimeout)
                    {
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 1;
                      continue;
                    }
                    goto label_48;
                  case 3:
                    goto label_120;
                  case 4:
                    // ISSUE: reference to a compiler-generated field
                    cDisplayClass60.semaphore = semaphore;
                    num3 = 5;
                    continue;
                  case 5:
                    nullable = timeout;
                    semaphoreTimeout = !nullable.HasValue ? TimeSpan.FromMilliseconds(-1.0) : nullable.GetValueOrDefault();
                    num3 = 8;
                    continue;
                  case 6:
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated method
                    LockService.\u003CAcquireLockInternalAsync\u003Ed__6.XqygPev7vIn7CF72RRad((object) cDisplayClass60.monitorObj);
                    num4 = 17;
                    break;
                  case 7:
                    // ISSUE: reference to a compiler-generated field
                    cDisplayClass60.monitorObj = monitorObj;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 2 : 13;
                    continue;
                  case 8:
                    if (isAsync)
                    {
                      num3 = 15;
                      continue;
                    }
                    goto case 18;
                  case 9:
                  case 10:
label_39:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated method
                    LockService.\u003CAcquireLockInternalAsync\u003Ed__6.NyYxcev7ZIySeKSZRcbR((object) this.Logger, (object) string.Format((string) LockService.\u003CAcquireLockInternalAsync\u003Ed__6.pXfVlov7ujl2VIeKrd27(1199946765 ^ 1199598835), (object) cDisplayClass60.internalName));
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 5 : 14;
                    continue;
                  case 11:
                    goto label_53;
                  case 12:
                    goto label_48;
                  case 13:
                    // ISSUE: reference to a compiler-generated field
                    cDisplayClass60.internalName = internalName;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 3 : 4;
                    continue;
                  case 14:
                    goto label_41;
                  case 16:
                    // ISSUE: object of a compiler-generated type is created
                    cDisplayClass60 = new LockService.\u003C\u003Ec__DisplayClass6_0();
                    num3 = 19;
                    continue;
                  case 17:
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    LockService.\u003CAcquireLockInternalAsync\u003Ed__6.NyYxcev7ZIySeKSZRcbR((object) this.Logger, LockService.\u003CAcquireLockInternalAsync\u003Ed__6.WG2Vv2v782rs6MQxA0Qh((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1470440286 ^ 1470165764), (object) cDisplayClass60.internalName, (object) timeout));
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 2 : 2;
                    continue;
                  case 18:
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated method
                    if (LockService.\u003CAcquireLockInternalAsync\u003Ed__6.H2DGSIv7IhrHPFodLb3h((object) cDisplayClass60.semaphore, semaphoreTimeout))
                    {
                      num3 = 10;
                      continue;
                    }
                    goto case 6;
                  case 19:
                    // ISSUE: reference to a compiler-generated field
                    cDisplayClass60.\u003C\u003E4__this = this;
                    num4 = 7;
                    break;
                  case 20:
                    try
                    {
                      int num5;
                      if (num2 != 0)
                        num5 = 11;
                      else
                        goto label_24;
label_15:
                      TaskAwaiter<bool> taskAwaiter;
                      TaskAwaiter<bool> awaiter;
                      while (true)
                      {
                        switch (num5)
                        {
                          case 1:
                            taskAwaiter = new TaskAwaiter<bool>();
                            num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 4 : 1;
                            continue;
                          case 2:
                            goto label_28;
                          case 3:
                            goto label_114;
                          case 4:
                            // ISSUE: explicit reference operation
                            // ISSUE: reference to a compiler-generated field
                            (^this).\u003C\u003E1__state = num2 = -1;
                            num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 6 : 6;
                            continue;
                          case 5:
                          case 7:
                            goto label_39;
                          case 6:
                          case 13:
                            if (awaiter.GetResult())
                            {
                              num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 1 : 5;
                              continue;
                            }
                            goto case 10;
                          case 8:
                            if (!throwOnTimeout)
                            {
                              result1 = (ILock) null;
                              num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 15 : 3;
                              continue;
                            }
                            num5 = 2;
                            continue;
                          case 9:
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated method
                            // ISSUE: reference to a compiler-generated method
                            LockService.\u003CAcquireLockInternalAsync\u003Ed__6.NyYxcev7ZIySeKSZRcbR((object) this.Logger, LockService.\u003CAcquireLockInternalAsync\u003Ed__6.WG2Vv2v782rs6MQxA0Qh((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1921443943), (object) cDisplayClass60.internalName, (object) timeout));
                            num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 8 : 3;
                            continue;
                          case 10:
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated method
                            LockService.\u003CAcquireLockInternalAsync\u003Ed__6.XqygPev7vIn7CF72RRad((object) cDisplayClass60.monitorObj);
                            num5 = 9;
                            continue;
                          case 11:
                            // ISSUE: reference to a compiler-generated field
                            awaiter = cDisplayClass60.semaphore.WaitAsync(semaphoreTimeout, token).GetAwaiter();
                            num5 = 16;
                            continue;
                          case 12:
                            goto label_24;
                          case 14:
                            taskAwaiter = awaiter;
                            num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 0;
                            continue;
                          case 15:
                            goto label_120;
                          case 16:
                            if (awaiter.IsCompleted)
                            {
                              num5 = 13;
                              continue;
                            }
                            goto case 17;
                          case 17:
                            // ISSUE: explicit reference operation
                            // ISSUE: reference to a compiler-generated field
                            (^this).\u003C\u003E1__state = num2 = 0;
                            num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 14 : 14;
                            continue;
                          default:
                            // ISSUE: explicit reference operation
                            // ISSUE: reference to a compiler-generated field
                            (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, LockService.\u003CAcquireLockInternalAsync\u003Ed__6>(ref awaiter, this);
                            num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 3 : 0;
                            continue;
                        }
                      }
label_114:
                      return;
label_28:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated field
                      // ISSUE: reference to a compiler-generated method
                      throw new TimeoutException((string) LockService.\u003CAcquireLockInternalAsync\u003Ed__6.WG2Vv2v782rs6MQxA0Qh(LockService.\u003CAcquireLockInternalAsync\u003Ed__6.pXfVlov7ujl2VIeKrd27(1253244298 - 1829393894 ^ -575979762), (object) cDisplayClass60.internalName, (object) timeout));
label_24:
                      awaiter = taskAwaiter;
                      num5 = 1;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
                      {
                        num5 = 0;
                        goto label_15;
                      }
                      else
                        goto label_15;
                    }
                    catch (OperationCanceledException ex)
                    {
                      int num6 = 1;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
                        num6 = 1;
                      while (true)
                      {
                        switch (num6)
                        {
                          case 1:
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated method
                            LockService.\u003CAcquireLockInternalAsync\u003Ed__6.XqygPev7vIn7CF72RRad((object) cDisplayClass60.monitorObj);
                            num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 2 : 0;
                            continue;
                          case 2:
                            result1 = (ILock) null;
                            num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 0 : 0;
                            continue;
                          default:
                            goto label_120;
                        }
                      }
                    }
                  case 21:
                    goto label_8;
                  default:
                    num3 = 20;
                    continue;
                }
                num3 = num4;
              }
label_48:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              throw new TimeoutException((string) LockService.\u003CAcquireLockInternalAsync\u003Ed__6.WG2Vv2v782rs6MQxA0Qh((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(323422137 << 2 ^ 1293911630), (object) cDisplayClass60.internalName, (object) timeout));
label_53:
              try
              {
                int num7;
                if (num2 != 1)
                  num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 13 : 0;
                else
                  goto label_88;
label_56:
                // ISSUE: variable of a compiler-generated type
                LockService.\u003C\u003Ec__DisplayClass6_1 cDisplayClass61;
                TaskAwaiter<Lock> taskAwaiter;
                TaskAwaiter<Lock> awaiter;
                while (true)
                {
                  int num8;
                  TimeSpan maxValidFor1;
                  TimeSpan repeatInterval1;
                  Lock result2;
                  TimeSpan timeSpan1;
                  TimeSpan timeSpan2;
                  switch (num7)
                  {
                    case 1:
                      // ISSUE: reference to a compiler-generated field
                      cDisplayClass61.dLock = result2;
                      num7 = 22;
                      continue;
                    case 2:
                    case 34:
                      result2 = awaiter.GetResult();
                      num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 1 : 1;
                      continue;
                    case 3:
                    case 15:
                      nullable = maxValidFor;
                      num7 = 18;
                      continue;
                    case 4:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<Lock>, LockService.\u003CAcquireLockInternalAsync\u003Ed__6>(ref awaiter, this);
                      num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 3 : 7;
                      continue;
                    case 5:
                    case 29:
                      // ISSUE: reference to a compiler-generated field
                      result1 = (ILock) cDisplayClass61.dLock;
                      num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 12 : 2;
                      continue;
                    case 6:
                      // ISSUE: reference to a compiler-generated field
                      // ISSUE: reference to a compiler-generated field
                      // ISSUE: reference to a compiler-generated field
                      if (!this.locks.TryGetValue(cDisplayClass61.CS\u0024\u003C\u003E8__locals1.monitorObj, out cDisplayClass61.dLock))
                      {
                        num7 = 15;
                        continue;
                      }
                      goto case 38;
                    case 7:
                      goto label_108;
                    case 8:
                      timeSpan1 = this.DEFAULT_REPEAT_INTERVAL;
                      goto label_103;
                    case 9:
                      // ISSUE: reference to a compiler-generated field
                      // ISSUE: reference to a compiler-generated field
                      // ISSUE: reference to a compiler-generated method
                      LockService.\u003CAcquireLockInternalAsync\u003Ed__6.XqygPev7vIn7CF72RRad((object) cDisplayClass61.CS\u0024\u003C\u003E8__locals1.monitorObj);
                      num7 = 29;
                      continue;
                    case 10:
                    case 28:
                      // ISSUE: reference to a compiler-generated field
                      // ISSUE: reference to a compiler-generated field
                      // ISSUE: reference to a compiler-generated field
                      cDisplayClass61.dLock = this.AcquireLockInternalImpl(cDisplayClass61.CS\u0024\u003C\u003E8__locals1.internalName, maxValidFor1, semaphoreTimeout, repeatInterval1);
                      num7 = 25;
                      continue;
                    case 11:
                      goto label_88;
                    case 12:
                    case 35:
                      goto label_120;
                    case 13:
                      // ISSUE: object of a compiler-generated type is created
                      cDisplayClass61 = new LockService.\u003C\u003Ec__DisplayClass6_1();
                      num7 = 23;
                      continue;
                    case 14:
                      // ISSUE: reference to a compiler-generated field
                      // ISSUE: reference to a compiler-generated field
                      // ISSUE: reference to a compiler-generated method
                      LockService.\u003CAcquireLockInternalAsync\u003Ed__6.PZpPONv7iRYmYjg5UtAA((object) cDisplayClass61.CS\u0024\u003C\u003E8__locals1.semaphore);
                      num7 = 36;
                      continue;
                    case 16:
                      // ISSUE: reference to a compiler-generated field
                      // ISSUE: reference to a compiler-generated method
                      LockService.\u003CAcquireLockInternalAsync\u003Ed__6.ygOEkbv7S3pkHIQWx2XO((object) cDisplayClass61.dLock);
                      num7 = 9;
                      continue;
                    case 17:
                      if (!throwOnTimeout)
                      {
                        num7 = 14;
                        continue;
                      }
                      goto label_81;
                    case 18:
                      if (nullable.HasValue)
                      {
                        num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 41 : 16;
                        continue;
                      }
                      goto case 31;
                    case 19:
                      goto label_81;
                    case 20:
                      // ISSUE: reference to a compiler-generated field
                      Lock dLock = cDisplayClass61.dLock;
                      // ISSUE: method pointer
                      // ISSUE: reference to a compiler-generated method
                      dLock.Disposing = (EventHandler) LockService.\u003CAcquireLockInternalAsync\u003Ed__6.e7bvqcv7Rnx6n4gc6Pnh((object) dLock.Disposing, (object) new EventHandler((object) cDisplayClass61, __methodptr(\u003CAcquireLockInternalAsync\u003Eg__OnDisposing\u007C0)));
                      num8 = 32;
                      break;
                    case 21:
                      taskAwaiter = awaiter;
                      num8 = 4;
                      break;
                    case 22:
                    case 25:
                      // ISSUE: reference to a compiler-generated field
                      if (cDisplayClass61.dLock == null)
                      {
                        num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 7 : 26;
                        continue;
                      }
                      goto case 20;
                    case 23:
                      // ISSUE: reference to a compiler-generated field
                      cDisplayClass61.CS\u0024\u003C\u003E8__locals1 = cDisplayClass60;
                      num7 = 24;
                      continue;
                    case 24:
                      // ISSUE: reference to a compiler-generated field
                      cDisplayClass61.dLock = (Lock) null;
                      num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 1 : 6;
                      continue;
                    case 26:
                      // ISSUE: reference to a compiler-generated field
                      // ISSUE: reference to a compiler-generated field
                      // ISSUE: reference to a compiler-generated method
                      LockService.\u003CAcquireLockInternalAsync\u003Ed__6.XqygPev7vIn7CF72RRad((object) cDisplayClass61.CS\u0024\u003C\u003E8__locals1.monitorObj);
                      num7 = 40;
                      continue;
                    case 27:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003E1__state = num2 = -1;
                      num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 29 : 34;
                      continue;
                    case 30:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003E1__state = num2 = 1;
                      num7 = 21;
                      continue;
                    case 31:
                      timeSpan2 = this.DEFAULT_VALID_FOR;
                      goto label_101;
                    case 32:
                      // ISSUE: reference to a compiler-generated field
                      // ISSUE: reference to a compiler-generated field
                      // ISSUE: reference to a compiler-generated field
                      this.locks[cDisplayClass61.CS\u0024\u003C\u003E8__locals1.monitorObj] = cDisplayClass61.dLock;
                      num8 = 5;
                      break;
                    case 33:
                      nullable = repeatInterval;
                      num7 = 43;
                      continue;
                    case 36:
                      result1 = (ILock) null;
                      num7 = 35;
                      continue;
                    case 37:
                      // ISSUE: reference to a compiler-generated field
                      // ISSUE: reference to a compiler-generated field
                      awaiter = this.AcquireLockInternalAsyncImpl(cDisplayClass61.CS\u0024\u003C\u003E8__locals1.internalName, token, maxValidFor1, semaphoreTimeout, repeatInterval1).GetAwaiter();
                      num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 39 : 18;
                      continue;
                    case 38:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated field
                      // ISSUE: reference to a compiler-generated field
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      LockService.\u003CAcquireLockInternalAsync\u003Ed__6.NyYxcev7ZIySeKSZRcbR((object) this.Logger, LockService.\u003CAcquireLockInternalAsync\u003Ed__6.wF07i3v7VV6FTRqG44tY(LockService.\u003CAcquireLockInternalAsync\u003Ed__6.pXfVlov7ujl2VIeKrd27(964881585 - -1459193222 ^ -1871076527), (object) cDisplayClass61.CS\u0024\u003C\u003E8__locals1.internalName));
                      num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 7 : 16;
                      continue;
                    case 39:
                      if (awaiter.IsCompleted)
                      {
                        num7 = 2;
                        continue;
                      }
                      goto case 30;
                    case 40:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated field
                      // ISSUE: reference to a compiler-generated field
                      // ISSUE: reference to a compiler-generated method
                      LockService.\u003CAcquireLockInternalAsync\u003Ed__6.NyYxcev7ZIySeKSZRcbR((object) this.Logger, (object) string.Format((string) LockService.\u003CAcquireLockInternalAsync\u003Ed__6.pXfVlov7ujl2VIeKrd27(-1317790512 ^ -1317941964), (object) cDisplayClass61.CS\u0024\u003C\u003E8__locals1.internalName, (object) timeout));
                      num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 17 : 12;
                      continue;
                    case 41:
                      timeSpan2 = nullable.GetValueOrDefault();
                      goto label_101;
                    case 42:
                      if (!isAsync)
                      {
                        num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 6 : 10;
                        continue;
                      }
                      goto case 37;
                    case 43:
                      if (!nullable.HasValue)
                      {
                        num7 = 8;
                        continue;
                      }
                      timeSpan1 = nullable.GetValueOrDefault();
                      goto label_103;
                    default:
                      taskAwaiter = new TaskAwaiter<Lock>();
                      num7 = 27;
                      continue;
                  }
label_55:
                  num7 = num8;
                  continue;
label_101:
                  maxValidFor1 = timeSpan2;
                  num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 33 : 0;
                  continue;
label_103:
                  repeatInterval1 = timeSpan1;
                  num8 = 42;
                  goto label_55;
                }
label_108:
                return;
label_81:
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                throw new TimeoutException(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~1767720452 ^ -1767825071), (object) cDisplayClass61.CS\u0024\u003C\u003E8__locals1.internalName, (object) timeout));
label_88:
                awaiter = taskAwaiter;
                num7 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
                {
                  num7 = 0;
                  goto label_56;
                }
                else
                  goto label_56;
              }
              catch (Exception ex)
              {
                int num9 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
                  num9 = 0;
                while (true)
                {
                  switch (num9)
                  {
                    case 1:
                      goto label_110;
                    default:
                      // ISSUE: reference to a compiler-generated field
                      this.Logger.Error(ex, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1199946765 ^ 1199599257), (object) cDisplayClass60.internalName);
                      num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 1 : 1;
                      continue;
                  }
                }
label_110:
                throw;
              }
label_8:
              if (num2 != 1)
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 9 : 16;
                goto label_5;
              }
label_41:
              num3 = 11;
              goto label_5;
            }
            catch (Exception ex)
            {
              int num10 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0)
                num10 = 2;
              while (true)
              {
                switch (num10)
                {
                  case 1:
                    goto label_104;
                  case 2:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = -2;
                    num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 0 : 0;
                    continue;
                  default:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.SetException(ex);
                    num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 1;
                    continue;
                }
              }
label_104:
              return;
            }
          case 4:
            goto label_117;
          case 5:
label_120:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003E1__state = -2;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 2 : 1;
            continue;
          default:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 1 : 3;
            continue;
        }
      }
label_117:;
    }

    /// <summary>Реально выполняемая асинхронная блокировка</summary>
    /// <param name="name">Имя блокировки</param>
    /// <param name="token">Токен отмены</param>
    /// <param name="maxValidFor">Время жизни блокировки</param>
    /// <param name="timeout">Таймаут блокировки</param>
    /// <param name="repeatInterval">Время опроса повторного захвата блокировки</param>
    /// <returns>Блокировка</returns>
    protected abstract Task<Lock> AcquireLockInternalAsyncImpl(
      string name,
      CancellationToken token,
      TimeSpan maxValidFor,
      TimeSpan timeout,
      TimeSpan repeatInterval);

    /// <summary>Сервис окружения приложения</summary>
    public IApplicationEnvironmentService ApplicationEnvironment
    {
      get => this.\u003CApplicationEnvironment\u003Ek__BackingField;
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
              this.\u003CApplicationEnvironment\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 0 : 0;
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

    /// <summary>Логгер</summary>
    public ILogger Logger
    {
      get => this.\u003CLogger\u003Ek__BackingField;
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
              this.\u003CLogger\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 0 : 0;
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

    /// <summary>Фабрика ключей блокировок</summary>
    public ILockKeyFactory LockKeyFactory
    {
      get => this.\u003CLockKeyFactory\u003Ek__BackingField;
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
              this.\u003CLockKeyFactory\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 0 : 0;
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
    public virtual ILock AcquireLock(string name, TimeSpan? maxValidFor, TimeSpan? timeout) => this.AcquireLock(name, maxValidFor, timeout, new TimeSpan?());

    /// <inheritdoc />
    public virtual bool TryAcquireLock(
      string name,
      TimeSpan? maxValidFor,
      TimeSpan? timeout,
      out ILock @lock)
    {
      return this.TryAcquireLock(name, maxValidFor, timeout, new TimeSpan?(), out @lock);
    }

    /// <summary>Выполнить конфигурирование</summary>
    /// <param name="settings">Настройки провадера</param>
    /// <param name="configuration">Конфигурация</param>
    public abstract void Configure(
      ProviderSettingsSection settings,
      RuntimeConfiguration configuration);

    /// <summary>
    /// Захват блокировки с возможностью дополнительно указать интервал опроса
    /// </summary>
    /// <param name="name">Имя блокировки</param>
    /// <param name="maxValidFor">Время жизни блокировки</param>
    /// <param name="timeout">Таймаут блокировки</param>
    /// <param name="repeatInterval">Время опроса повторного захвата блокировки</param>
    /// <returns>Блокировка</returns>
    protected virtual ILock AcquireLock(
      string name,
      TimeSpan? maxValidFor,
      TimeSpan? timeout,
      TimeSpan? repeatInterval)
    {
      try
      {
        ILock @lock = this.AcquireLockInternal(name, maxValidFor, timeout, new TimeSpan?(), true);
        this.Logger.Debug((object) string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1998538950 ^ -1998377164), (object) name));
        return @lock;
      }
      catch (Exception ex)
      {
        this.Logger.Error(ex, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606820024), (object) name);
        throw;
      }
    }

    /// <summary>
    /// Попытка захвата блокировки с возможностью дополнительно указать интервал опроса
    /// </summary>
    /// <param name="name">Имя блокировки</param>
    /// <param name="maxValidFor">Время жизни блокировки</param>
    /// <param name="timeout">Таймаут блокировки</param>
    /// <param name="repeatInterval">Время опроса повторного захвата блокировки</param>
    /// <param name="lock">Блокировка</param>
    /// <returns>True - в случае успеха</returns>
    protected virtual bool TryAcquireLock(
      string name,
      TimeSpan? maxValidFor,
      TimeSpan? timeout,
      TimeSpan? repeatInterval,
      out ILock @lock)
    {
      try
      {
        @lock = this.AcquireLockInternal(name, maxValidFor, timeout, new TimeSpan?(), false);
        if (@lock != null)
        {
          this.Logger.Debug((object) string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(874012245 ^ 874235483), (object) name));
          return true;
        }
        this.Logger.Warn((object) string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-244066886 - -48452443 ^ -195776065), (object) name, (object) timeout));
      }
      catch (Exception ex)
      {
        this.Logger.Error(ex, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1445902765 ^ -1980277732 ^ 539329051), (object) name);
      }
      @lock = (ILock) null;
      return false;
    }

    /// <summary>
    /// Базовая блокировка с предварительной блокировкой только на локальной ноде
    /// </summary>
    /// <param name="name">Имя блокировки</param>
    /// <param name="maxValidFor">Время жизни блокировки</param>
    /// <param name="timeout">Таймаут блокировки</param>
    /// <param name="repeatInterval">Время опроса повторного захвата блокировки</param>
    /// <param name="throwOnTimeout">Кидать исключение в случае таймаута?</param>
    /// <returns>Блокировка</returns>
    protected virtual ILock AcquireLockInternal(
      string name,
      TimeSpan? maxValidFor,
      TimeSpan? timeout,
      TimeSpan? repeatInterval,
      bool throwOnTimeout)
    {
      return this.AcquireLockInternalAsync(name, CancellationToken.None, maxValidFor, timeout, repeatInterval, throwOnTimeout, false).GetAwaiter().GetResult();
    }

    /// <summary>Реально выполняемая блокировка</summary>
    /// <param name="name">Имя блокировки</param>
    /// <param name="maxValidFor">Время жизни блокировки</param>
    /// <param name="timeout">Таймаут блокировки</param>
    /// <param name="repeatInterval">Время опроса повторного захвата блокировки</param>
    /// <returns>Блокировка</returns>
    protected abstract Lock AcquireLockInternalImpl(
      string name,
      TimeSpan maxValidFor,
      TimeSpan timeout,
      TimeSpan repeatInterval);

    protected virtual string GetInternalLockName(string name) => (string) LockService.KG22hDhruneBH8lvPMfx((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1886646897 ^ -1886415711), (object) name);

    protected LockService()
    {
      LockService.uvZarnhrIcMDRyHFEdMS();
      this.DEFAULT_VALID_FOR = LockService.ix1d8QhrVwhBofT4Apuo(1.0);
      this.DEFAULT_REPEAT_INTERVAL = LockService.mVGmRyhrSh05JeABNbQx(500.0);
      this.locks = new ConcurrentDictionary<IDisposable, Lock>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static LockService()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            LockService.uvZarnhrIcMDRyHFEdMS();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            LockService.InfiniteTimeSpan = new TimeSpan(0, 0, 0, 0, -1);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 2 : 0;
            continue;
        }
      }
label_2:;
    }

    internal static bool aYV7LRhr8NoLAkCO9Hqe() => LockService.EGJHU2hrvh3ZDlpJuh7n == null;

    internal static LockService o5ZYZOhrZV3L3YAmrwC4() => LockService.EGJHU2hrvh3ZDlpJuh7n;

    internal static object KG22hDhruneBH8lvPMfx([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static void uvZarnhrIcMDRyHFEdMS() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static TimeSpan ix1d8QhrVwhBofT4Apuo([In] double obj0) => TimeSpan.FromHours(obj0);

    internal static TimeSpan mVGmRyhrSh05JeABNbQx([In] double obj0) => TimeSpan.FromMilliseconds(obj0);

    /// <summary>Семафор с защитой от повторной блокировки в потоке</summary>
    private class ThreadSafeSemaphoreSlim : IDisposable
    {
      private static readonly ConditionalWeakTable<object, LockService.ThreadSafeSemaphoreSlim> Semaphores;
      private static readonly AsyncLocal<LockService.ThreadSafeSemaphoreSlim[]> TreadSemaphores;
      private readonly object semaphore;
      private readonly object key;
      private bool disposed;
      internal static object W4vlkyvAwIFejZX2FV1E;

      /// <summary>Получить экземпляр семафора по ключу</summary>
      /// <param name="key">Ключ</param>
      /// <returns>Семафор</returns>
      public static LockService.ThreadSafeSemaphoreSlim Get(object key)
      {
        LockService.ThreadSafeSemaphoreSlim safeSemaphoreSlim = LockService.ThreadSafeSemaphoreSlim.Semaphores.GetValue(key, (ConditionalWeakTable<object, LockService.ThreadSafeSemaphoreSlim>.CreateValueCallback) (k => new LockService.ThreadSafeSemaphoreSlim(k)));
        LockService.ThreadSafeSemaphoreSlim.d4l3xgvAHdZYjDoXrUqR();
        return safeSemaphoreSlim;
      }

      private ThreadSafeSemaphoreSlim(object key)
      {
        LockService.ThreadSafeSemaphoreSlim.Yn7yvvvAAxgqHeJ9jyrf();
        this.semaphore = (object) new SemaphoreSlim(1, 1);
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
          num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_3;
            case 1:
              this.key = (object) new WeakReference(key);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 0;
              continue;
            default:
              goto label_5;
          }
        }
label_3:
        return;
label_5:;
      }

      /// <summary>Ожидать асинхронно освобождения критической секции</summary>
      /// <param name="cancellationToken">Токен отмены</param>
      /// <param name="timeout">Таймаут блокировки</param>
      /// <returns><see langword="true" />, если вошли в критическую секцию, иначе <see langword="false" /></returns>
      public async Task<bool> WaitAsync(TimeSpan timeout, CancellationToken cancellationToken)
      {
        int num1 = 3;
        int num2;
        bool result;
        while (true)
        {
          switch (num1)
          {
            case 1:
              try
              {
                int num3;
                if (num2 != 0)
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 9 : 11;
                else
                  goto label_15;
label_7:
                TaskAwaiter<bool> taskAwaiter;
                TaskAwaiter<bool> awaiter;
                while (true)
                {
                  int num4;
                  bool flag;
                  bool entered;
                  switch (num3)
                  {
                    case 1:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003E1__state = num2 = -1;
                      num3 = 5;
                      continue;
                    case 2:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, LockService.ThreadSafeSemaphoreSlim.\u003CWaitAsync\u003Ed__7>(ref awaiter, this);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 13 : 3;
                      continue;
                    case 3:
                      result = entered;
                      num4 = 12;
                      break;
                    case 4:
                      if (!flag)
                      {
                        num3 = 10;
                        continue;
                      }
                      goto default;
                    case 5:
                      flag = awaiter.GetResult();
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 0 : 0;
                      continue;
                    case 6:
                      if (!awaiter.IsCompleted)
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 7 : 2;
                        continue;
                      }
                      goto case 5;
                    case 7:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003E1__state = num2 = 0;
                      num3 = 9;
                      continue;
                    case 8:
                      this.SaveLockTread(entered);
                      num4 = 3;
                      break;
                    case 9:
                      taskAwaiter = awaiter;
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 2 : 0;
                      continue;
                    case 10:
                      awaiter = ((SemaphoreSlim) this.semaphore).WaitAsync(timeout, cancellationToken).GetAwaiter();
                      num3 = 6;
                      continue;
                    case 11:
                      flag = this.CheckLockTread();
                      num3 = 4;
                      continue;
                    case 12:
                      goto label_3;
                    case 13:
                      goto label_29;
                    case 14:
                      goto label_15;
                    case 15:
                      taskAwaiter = new TaskAwaiter<bool>();
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 1 : 0;
                      continue;
                    default:
                      entered = flag;
                      num3 = 8;
                      continue;
                  }
                  num3 = num4;
                }
label_29:
                return;
label_15:
                awaiter = taskAwaiter;
                num3 = 15;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0)
                {
                  num3 = 14;
                  goto label_7;
                }
                else
                  goto label_7;
              }
              catch (Exception ex)
              {
                int num5 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
                  num5 = 0;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003E1__state = -2;
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 0;
                      continue;
                    case 2:
                      goto label_25;
                    default:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003Et__builder.SetException(ex);
                      num5 = 2;
                      continue;
                  }
                }
label_25:
                return;
              }
            case 2:
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 0 : 1;
              continue;
            case 3:
              // ISSUE: explicit reference operation
              // ISSUE: reference to a compiler-generated field
              num2 = (^this).\u003C\u003E1__state;
              num1 = 2;
              continue;
            case 4:
label_3:
              // ISSUE: explicit reference operation
              // ISSUE: reference to a compiler-generated field
              (^this).\u003C\u003E1__state = -2;
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 0 : 0;
              continue;
            case 5:
              goto label_32;
            default:
              // ISSUE: explicit reference operation
              // ISSUE: reference to a compiler-generated field
              (^this).\u003C\u003Et__builder.SetResult(result);
              num1 = 5;
              continue;
          }
        }
label_32:;
      }

      /// <summary>Ожидать освобождения критической секции</summary>
      /// <param name="timeout">Таймаут блокировки</param>
      /// <returns><see langword="true" />, если вошли в критическую секцию, иначе <see langword="false" /></returns>
      public bool Wait(TimeSpan timeout)
      {
        int num1 = 1;
        bool entered;
        while (true)
        {
          int num2;
          switch (num1)
          {
            case 1:
              if (!this.CheckLockTread())
              {
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 0 : 0;
                continue;
              }
              num2 = 1;
              break;
            case 2:
              goto label_6;
            case 3:
              this.SaveLockTread(entered);
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 1 : 2;
              continue;
            default:
              num2 = LockService.ThreadSafeSemaphoreSlim.dZ7QRwvA7iR2HsFTslEp(this.semaphore, timeout) ? 1 : 0;
              break;
          }
          entered = num2 != 0;
          num1 = 3;
        }
label_6:
        return entered;
      }

      /// <summary>Освободить критическую сессию</summary>
      public void Release()
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_5;
            case 1:
              if (this.ClearLockTread())
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 0 : 0;
                continue;
              }
              goto case 2;
            case 2:
              LockService.ThreadSafeSemaphoreSlim.ONWHBBvAxkylHBBlbSG0(this.semaphore);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 3 : 2;
              continue;
            case 3:
              goto label_2;
            default:
              goto label_7;
          }
        }
label_5:
        return;
label_2:
        return;
label_7:;
      }

      /// <summary>Проверить, что находимся во вложенной блокировке</summary>
      /// <returns><see langword="true" />, если блокировка вложенная</returns>
      private bool CheckLockTread()
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (LockService.ThreadSafeSemaphoreSlim.TreadSemaphores.Value != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 0 : 0;
                continue;
              }
              goto label_3;
            default:
              goto label_2;
          }
        }
label_2:
        return Array.IndexOf<LockService.ThreadSafeSemaphoreSlim>(LockService.ThreadSafeSemaphoreSlim.TreadSemaphores.Value, this) >= 0;
label_3:
        return false;
      }

      private static void PrepareLockTread()
      {
        int num1 = 1;
        while (true)
        {
          int num2 = num1;
          LockService.ThreadSafeSemaphoreSlim[] array;
          int num3;
          LockService.ThreadSafeSemaphoreSlim[] safeSemaphoreSlimArray;
          while (true)
          {
            switch (num2)
            {
              case 1:
                array = LockService.ThreadSafeSemaphoreSlim.TreadSemaphores.Value;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 0 : 0;
                continue;
              case 2:
                LockService.ThreadSafeSemaphoreSlim.TreadSemaphores.Value = new LockService.ThreadSafeSemaphoreSlim[1];
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 4 : 3;
                continue;
              case 3:
                safeSemaphoreSlimArray = new LockService.ThreadSafeSemaphoreSlim[array.Length + num3];
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 7 : 4;
                continue;
              case 4:
                goto label_7;
              case 5:
                goto label_3;
              case 6:
                if (Array.IndexOf<LockService.ThreadSafeSemaphoreSlim>(array, (LockService.ThreadSafeSemaphoreSlim) null) != -1)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 5 : 5;
                  continue;
                }
                goto label_15;
              case 7:
                goto label_13;
              case 8:
                goto label_8;
              case 9:
                LockService.ThreadSafeSemaphoreSlim.TreadSemaphores.Value = safeSemaphoreSlimArray;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 8 : 7;
                continue;
              default:
                if (array != null)
                {
                  num2 = 6;
                  continue;
                }
                goto case 2;
            }
          }
label_3:
          int num4 = 0;
          goto label_16;
label_13:
          LockService.ThreadSafeSemaphoreSlim.Pwrov4vA0YZvMhlMDS6c((object) array, 0, (object) safeSemaphoreSlimArray, num3, array.Length);
          num1 = 9;
          continue;
label_15:
          num4 = 1;
label_16:
          num3 = num4;
          num1 = 3;
        }
label_7:
        return;
label_8:;
      }

      private void SaveLockTread(bool entered)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (entered)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 0 : 0;
                continue;
              }
              goto label_6;
            case 2:
              goto label_2;
            default:
              LockService.ThreadSafeSemaphoreSlim[] array = LockService.ThreadSafeSemaphoreSlim.TreadSemaphores.Value;
              array[Array.IndexOf<LockService.ThreadSafeSemaphoreSlim>(array, (LockService.ThreadSafeSemaphoreSlim) null)] = this;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 2 : 2;
              continue;
          }
        }
label_2:
        return;
label_6:;
      }

      /// <summary>Удалить ссылку на блокироку</summary>
      /// <returns>Осталась ли еще ссылка на блокировку</returns>
      private bool ClearLockTread()
      {
        int num1 = 2;
        LockService.ThreadSafeSemaphoreSlim[] array;
        int index;
        while (true)
        {
          int num2 = num1;
          while (true)
          {
            switch (num2)
            {
              case 1:
                goto label_5;
              case 2:
                array = LockService.ThreadSafeSemaphoreSlim.TreadSemaphores.Value;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 1 : 1;
                continue;
              case 3:
                index = Array.IndexOf<LockService.ThreadSafeSemaphoreSlim>(array, this);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 1 : 4;
                continue;
              case 4:
                if (index != -1)
                {
                  if (array.Length != 1)
                  {
                    array[index] = (LockService.ThreadSafeSemaphoreSlim) null;
                    num2 = 5;
                    continue;
                  }
                  goto label_9;
                }
                else
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 0 : 0;
                  continue;
                }
              case 5:
                goto label_12;
              case 6:
                LockService.ThreadSafeSemaphoreSlim.TreadSemaphores.Value = (LockService.ThreadSafeSemaphoreSlim[]) null;
                num2 = 8;
                continue;
              case 7:
                goto label_3;
              case 8:
                goto label_15;
              default:
                goto label_7;
            }
          }
label_5:
          if (array != null)
          {
            num1 = 3;
            continue;
          }
          break;
label_9:
          num1 = 6;
        }
label_3:
        return false;
label_7:
        return false;
label_12:
        return Array.IndexOf<LockService.ThreadSafeSemaphoreSlim>(array, this, index + 1) != -1;
label_15:
        return false;
      }

      /// <summary>Dctor</summary>
      ~ThreadSafeSemaphoreSlim()
      {
        switch (1)
        {
          case 1:
            try
            {
              this.Dispose(false);
              int num = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0)
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
              LockService.ThreadSafeSemaphoreSlim.uYq7bTvAmdl1yXVMfiYK((object) this);
              int num = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
                num = 0;
              switch (num)
              {
                default:
              }
            }
        }
      }

      /// <inheritdoc />
      public void Dispose()
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              LockService.ThreadSafeSemaphoreSlim.RE0prrvAyTIkG3KnbXGx((object) this);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 0;
              continue;
            case 2:
              this.Dispose(true);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 1 : 1;
              continue;
            default:
              goto label_5;
          }
        }
label_2:
        return;
label_5:;
      }

      private void Dispose(bool disposing)
      {
        int num = 7;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_13;
            case 1:
              goto label_3;
            case 2:
            case 4:
              if (LockService.ThreadSafeSemaphoreSlim.GkTgCHvAJN7ZN4OOILE7(this.key))
              {
                num = 3;
                continue;
              }
              goto case 5;
            case 3:
              LockService.ThreadSafeSemaphoreSlim.Semaphores.Remove(LockService.ThreadSafeSemaphoreSlim.FXSIiEvA9R6hr3eInCW3(this.key));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 5 : 0;
              continue;
            case 5:
              this.disposed = true;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 1 : 1;
              continue;
            case 6:
              object semaphore = this.semaphore;
              if (semaphore == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 2 : 2;
                continue;
              }
              LockService.ThreadSafeSemaphoreSlim.IqXwamvAMxjn1rlkl5EX(semaphore);
              num = 4;
              continue;
            case 7:
              if (!this.disposed)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 6 : 0;
                continue;
              }
              goto label_12;
            default:
              goto label_2;
          }
        }
label_13:
        return;
label_3:
        return;
label_2:
        return;
label_12:;
      }

      static ThreadSafeSemaphoreSlim()
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              LockService.ThreadSafeSemaphoreSlim.Yn7yvvvAAxgqHeJ9jyrf();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_2;
            case 3:
              LockService.ThreadSafeSemaphoreSlim.TreadSemaphores = new AsyncLocal<LockService.ThreadSafeSemaphoreSlim[]>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 2 : 2;
              continue;
            default:
              LockService.ThreadSafeSemaphoreSlim.Semaphores = new ConditionalWeakTable<object, LockService.ThreadSafeSemaphoreSlim>();
              num = 3;
              continue;
          }
        }
label_2:;
      }

      internal static void d4l3xgvAHdZYjDoXrUqR() => LockService.ThreadSafeSemaphoreSlim.PrepareLockTread();

      internal static bool PZmhkOvA4waRucyumvbG() => LockService.ThreadSafeSemaphoreSlim.W4vlkyvAwIFejZX2FV1E == null;

      internal static LockService.ThreadSafeSemaphoreSlim DDTop1vA641YfXsIU5Ax() => (LockService.ThreadSafeSemaphoreSlim) LockService.ThreadSafeSemaphoreSlim.W4vlkyvAwIFejZX2FV1E;

      internal static void Yn7yvvvAAxgqHeJ9jyrf() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool dZ7QRwvA7iR2HsFTslEp([In] object obj0, [In] TimeSpan obj1) => ((SemaphoreSlim) obj0).Wait(obj1);

      internal static int ONWHBBvAxkylHBBlbSG0([In] object obj0) => ((SemaphoreSlim) obj0).Release();

      internal static void Pwrov4vA0YZvMhlMDS6c(
        [In] object obj0,
        [In] int obj1,
        [In] object obj2,
        [In] int obj3,
        [In] int obj4)
      {
        Array.Copy((Array) obj0, obj1, (Array) obj2, obj3, obj4);
      }

      internal static void uYq7bTvAmdl1yXVMfiYK([In] object obj0) => __nonvirtual (obj0.Finalize());

      internal static void RE0prrvAyTIkG3KnbXGx([In] object obj0) => GC.SuppressFinalize(obj0);

      internal static void IqXwamvAMxjn1rlkl5EX([In] object obj0) => __nonvirtual (((SemaphoreSlim) obj0).Dispose());

      internal static bool GkTgCHvAJN7ZN4OOILE7([In] object obj0) => ((WeakReference) obj0).IsAlive;

      internal static object FXSIiEvA9R6hr3eInCW3([In] object obj0) => ((WeakReference) obj0).Target;
    }
  }
}
