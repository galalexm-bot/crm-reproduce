// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Managers.LockManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Locking;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace EleWise.ELMA.Model.Managers
{
  /// <summary>Менеджер блокировок</summary>
  [Service(Type = ComponentType.Server)]
  public class LockManager : NHManager, ILockManager
  {
    private ILockService DistributedLockServicePrivate;
    private IAsyncLockService distributedAsyncLockServicePrivate;
    internal static LockManager SJRSsNhQvnYCEoOyYiuX;

    public IUnitOfWorkManager UnitOfWorkManager
    {
      get => this.\u003CUnitOfWorkManager\u003Ek__BackingField;
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
              this.\u003CUnitOfWorkManager\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 0;
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
    /// <see cref="T:EleWise.ELMA.Locking.ILockService" />
    /// </summary>
    [Obsolete]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public ILockService DistributedLockService
    {
      get
      {
        int num = 1;
        ILockService serviceNotNull;
        ILockService lockServicePrivate;
        while (true)
        {
          switch (num)
          {
            case 1:
              lockServicePrivate = this.DistributedLockServicePrivate;
              if (lockServicePrivate == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            case 2:
              goto label_6;
            default:
              this.DistributedLockServicePrivate = serviceNotNull = Locator.GetServiceNotNull<ILockService>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 1 : 2;
              continue;
          }
        }
label_2:
        return lockServicePrivate;
label_6:
        return serviceNotNull;
      }
    }

    /// <summary>
    /// Сервис блокировки, поддерживающий асинхронную блокировку <see cref="T:EleWise.ELMA.Locking.IAsyncLockService" />
    /// </summary>
    public IAsyncLockService DistributedAsyncLockService
    {
      get
      {
        int num = 1;
        IAsyncLockService serviceNotNull;
        IAsyncLockService lockServicePrivate;
        while (true)
        {
          switch (num)
          {
            case 1:
              lockServicePrivate = this.distributedAsyncLockServicePrivate;
              if (lockServicePrivate == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            case 2:
              goto label_6;
            default:
              this.distributedAsyncLockServicePrivate = serviceNotNull = Locator.GetServiceNotNull<IAsyncLockService>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 2 : 0;
              continue;
          }
        }
label_2:
        return lockServicePrivate;
label_6:
        return serviceNotNull;
      }
    }

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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 0 : 0;
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
    /// Получить именованную блокировку на уровне БД. Лучше использовать метод Lock.
    /// </summary>
    /// <param name="lockName">Имя блокировки</param>
    /// <param name="timeout">Ограничение по времени (в секундах)</param>
    [Obsolete("Устарел, используйте метод Lock")]
    public void ObtainLock(string lockName, int timeout)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!this.DistributedLockService.TryAcquireLock(lockName, new TimeSpan?(), new TimeSpan?(TimeSpan.FromSeconds((double) timeout)), out ILock _))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          default:
            goto label_3;
        }
      }
label_3:
      throw new ObtainLockException(lockName);
label_2:;
    }

    /// <summary>
    /// Получить именованную блокировку на уровне БД. Лучше использовать метод Lock.
    /// </summary>
    /// <param name="lockName">Имя блокировки</param>
    [Obsolete("Устарел, используйте метод Lock")]
    public void ObtainLock(string lockName)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            if (this.DistributedLockService.TryAcquireLock(lockName, new TimeSpan?(), new TimeSpan?(), out ILock _))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 1 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_3;
        }
      }
label_2:
      return;
label_3:
      throw new ObtainLockException(lockName);
    }

    /// <summary>
    /// Попытаться выполнить блокировку. Если удалось - возвращается true, иначе - false. Лучше использовать метод TryLock.
    /// </summary>
    /// <param name="lockName">Имя блокировки</param>
    /// <param name="timeout">Ограничение по времени (в секундах)</param>
    /// <returns>true - в случае успеха</returns>
    [Obsolete("Устарел, используйте метод TryLock")]
    public bool TryObtainLock(string lockName, int timeout) => this.DistributedLockService.TryAcquireLock(lockName, new TimeSpan?(), new TimeSpan?(LockManager.INBbUXhQuIAlgBjgEWom((double) timeout)), out ILock _);

    /// <summary>
    /// Попытаться выполнить блокировку. Если удалось - возвращается true, иначе - false. Лучше использовать метод TryLock.
    /// </summary>
    /// <param name="lockName">Имя блокировки</param>
    /// <returns>true - в случае успеха</returns>
    [Obsolete("Устарел, используйте метод TryLock")]
    public bool TryObtainLock(string lockName) => this.DistributedLockService.TryAcquireLock(lockName, new TimeSpan?(), new TimeSpan?(), out ILock _);

    /// <summary>
    /// Возвращает объект для работы с блокировкой базы, реализующей интерфейс IDisposable
    /// </summary>
    /// <param name="lockName">Имя блокировки</param>
    /// <returns>Блокировка</returns>
    public IDisposable Lock(string lockName) => (IDisposable) LockManager.X1ytPShQISAc0cB2C7nA((object) this.DistributedLockService, (object) lockName);

    /// <summary>
    /// Возвращает объект для работы с блокировкой базы, реализующей интерфейс IDisposable
    /// </summary>
    /// <param name="lockName">Имя блокировки</param>
    /// <param name="timeout">Таймаут в секундах</param>
    /// <returns>Блокировка</returns>
    public IDisposable Lock(string lockName, int timeout) => (IDisposable) this.DistributedLockService.AcquireLock(lockName, new TimeSpan?(), new TimeSpan?(LockManager.INBbUXhQuIAlgBjgEWom((double) timeout)));

    /// <summary>
    /// Попытаться выполнить блокировку. Если удалось - возвращается true, иначе - false
    /// </summary>
    /// <param name="lockName">Имя блокировки</param>
    /// <param name="timeout">Ограничение по времени (в секундах)</param>
    /// <param name="lock">Блокировка</param>
    /// <returns>true - в случае успеха</returns>
    public bool TryLock(string lockName, int timeout, out IDisposable @lock)
    {
      ILock lock1;
      int num = this.DistributedLockService.TryAcquireLock(lockName, new TimeSpan?(), new TimeSpan?(LockManager.INBbUXhQuIAlgBjgEWom((double) timeout)), out lock1) ? 1 : 0;
      @lock = (IDisposable) lock1;
      return num != 0;
    }

    /// <summary>
    /// Попытаться выполнить блокировку. Если удалось - возвращается true, иначе - false
    /// </summary>
    /// <param name="lockName">Имя блокировки</param>
    /// <param name="lock">Блокировка</param>
    /// <returns>true - в случае успеха</returns>
    public bool TryLock(string lockName, out IDisposable @lock)
    {
      ILock lock1;
      int num = this.DistributedLockService.TryAcquireLock(lockName, new TimeSpan?(), new TimeSpan?(), out lock1) ? 1 : 0;
      @lock = (IDisposable) lock1;
      return num != 0;
    }

    /// <summary>
    /// Возвращает объект для работы с блокировкой базы, реализующей интерфейс IDisposable
    /// </summary>
    /// <param name="lockName">Имя блокировки</param>
    /// <returns>Блокировка</returns>
    [Obsolete("Используйте Lock. Будет удален в будущих версиях.")]
    public IDisposable HardLock(string lockName) => (IDisposable) LockManager.X1ytPShQISAc0cB2C7nA((object) this.DistributedLockService, (object) lockName);

    /// <summary>
    /// Возвращает объект для работы с блокировкой базы, реализующей интерфейс IDisposable
    /// </summary>
    /// <param name="lockName">Имя блокировки</param>
    /// <returns></returns>
    [Obsolete("Используйте Lock. Будет удален в будущих версиях.")]
    public IDisposable HardLock(string lockName, int timeout) => (IDisposable) LockManager.X1ytPShQISAc0cB2C7nA((object) this.DistributedLockService, (object) lockName);

    /// <summary>
    /// Отменить блокировку (вызов только в том же потоке, в котором был выполнен захват!)
    /// </summary>
    /// <param name="lockName">Имя блокировки</param>
    [Obsolete("Устарел, не используется")]
    public void ReleaseLock(string lockName)
    {
      switch (1)
      {
        case 1:
          try
          {
            ILock @lock = this.DistributedLockService.AcquireLock(lockName, new TimeSpan?(), new TimeSpan?(TimeSpan.Zero));
            int num1 = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
              num1 = 0;
            switch (num1)
            {
              case 1:
                return;
              default:
                try
                {
                  LockManager.wi2eshhQVyxlaZawteJO((object) @lock);
                  int num2 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
                    num2 = 0;
                  switch (num2)
                  {
                    case 0:
                      return;
                    default:
                      return;
                  }
                }
                finally
                {
                  if (@lock != null)
                  {
                    int num3 = 0;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0)
                      num3 = 0;
                    while (true)
                    {
                      switch (num3)
                      {
                        case 1:
                          goto label_16;
                        default:
                          @lock.Dispose();
                          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 1 : 1;
                          continue;
                      }
                    }
                  }
label_16:;
                }
            }
          }
          catch (TimeoutException ex)
          {
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0)
              num = 0;
            while (true)
            {
              switch (num)
              {
                case 1:
                  goto label_8;
                default:
                  LockManager.z4xltBhQiXCVgw6LLAiS((object) this.Logger, LockManager.ncwbh9hQS1IXoNBOV1XN((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1839087379 - 334718690 ^ 2121100471), (object) lockName), (object) ex);
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 1 : 1;
                  continue;
              }
            }
label_8:
            break;
          }
      }
    }

    /// <summary>Проверить наличие блокировки (не используется)</summary>
    /// <param name="lockName"></param>
    /// <returns></returns>
    [Obsolete("Don't use this method. Always returns null.")]
    public bool? HasLock(string lockName) => new bool?();

    /// <inheritdoc />
    public async Task<IDisposable> LockAsync(string lockName, CancellationToken token = default (CancellationToken))
    {
      int num1 = 3;
      int num2;
      IDisposable result;
      while (true)
      {
        switch (num1)
        {
          case 1:
            try
            {
              int num3;
              if (num2 == 0)
                num3 = 2;
              else
                goto label_13;
label_7:
              TaskAwaiter<ILock> taskAwaiter;
              TaskAwaiter<ILock> awaiter;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    goto label_13;
                  case 2:
                  case 12:
                    awaiter = taskAwaiter;
                    num3 = 5;
                    continue;
                  case 3:
                    if (awaiter.IsCompleted)
                    {
                      num3 = 4;
                      continue;
                    }
                    goto case 6;
                  case 4:
                  case 10:
                    result = (IDisposable) awaiter.GetResult();
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 0 : 0;
                    continue;
                  case 5:
                    taskAwaiter = new TaskAwaiter<ILock>();
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 8 : 2;
                    continue;
                  case 6:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = 0;
                    num3 = 9;
                    continue;
                  case 7:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<ILock>, LockManager.\u003CLockAsync\u003Ed__26>(ref awaiter, this);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 11 : 5;
                    continue;
                  case 8:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = -1;
                    num3 = 10;
                    continue;
                  case 9:
                    taskAwaiter = awaiter;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 7 : 4;
                    continue;
                  case 11:
                    goto label_24;
                  default:
                    goto label_4;
                }
              }
label_24:
              return;
label_13:
              awaiter = this.DistributedAsyncLockService.AcquireLockAsync(lockName, token).GetAwaiter();
              num3 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
              {
                num3 = 3;
                goto label_7;
              }
              else
                goto label_7;
            }
            catch (Exception ex)
            {
              int num4 = 2;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
                num4 = 2;
              while (true)
              {
                switch (num4)
                {
                  case 0:
                    goto label_20;
                  case 1:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.SetException(ex);
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 0 : 0;
                    continue;
                  case 2:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = -2;
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 1 : 1;
                    continue;
                  default:
                    goto label_19;
                }
              }
label_20:
              return;
label_19:
              return;
            }
          case 2:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 1 : 0;
            continue;
          case 3:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            num2 = (^this).\u003C\u003E1__state;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 1 : 2;
            continue;
          case 4:
label_4:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003E1__state = -2;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 0 : 0;
            continue;
          case 5:
            goto label_27;
          default:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003Et__builder.SetResult(result);
            num1 = 5;
            continue;
        }
      }
label_27:;
    }

    /// <inheritdoc />
    public async Task<IDisposable> LockAsync(string lockName, int timeout, CancellationToken token = default (CancellationToken))
    {
      int num1 = 5;
      IDisposable result;
      int num2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003Et__builder.SetResult(result);
            num1 = 3;
            continue;
          case 2:
label_28:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003E1__state = -2;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 1;
            continue;
          case 3:
            goto label_26;
          case 4:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 0 : 0;
            continue;
          case 5:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            num2 = (^this).\u003C\u003E1__state;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 4 : 4;
            continue;
          default:
            try
            {
              int num3;
              if (num2 != 0)
                num3 = 4;
              else
                goto label_9;
label_6:
              TaskAwaiter<ILock> taskAwaiter;
              TaskAwaiter<ILock> awaiter;
              while (true)
              {
                switch (num3)
                {
                  case 0:
                    goto label_23;
                  case 1:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<ILock>, LockManager.\u003CLockAsync\u003Ed__27>(ref awaiter, this);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 0 : 0;
                    continue;
                  case 2:
                  case 6:
                    result = (IDisposable) awaiter.GetResult();
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 5 : 8;
                    continue;
                  case 3:
                    goto label_9;
                  case 4:
                    // ISSUE: reference to a compiler-generated method
                    awaiter = this.DistributedAsyncLockService.AcquireLockAsync(lockName, new TimeSpan?(LockManager.\u003CLockAsync\u003Ed__27.wUEjjfCjhNcb3aClkT8i((double) timeout)), token).GetAwaiter();
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 9 : 9;
                    continue;
                  case 5:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = 0;
                    num3 = 11;
                    continue;
                  case 7:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = -1;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 1 : 2;
                    continue;
                  case 8:
                    goto label_28;
                  case 9:
                    if (awaiter.IsCompleted)
                    {
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 2 : 6;
                      continue;
                    }
                    goto case 5;
                  case 10:
                    taskAwaiter = new TaskAwaiter<ILock>();
                    num3 = 7;
                    continue;
                  case 11:
                    taskAwaiter = awaiter;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 1;
                    continue;
                  default:
                    goto label_19;
                }
              }
label_23:
              return;
label_19:
              return;
label_9:
              awaiter = taskAwaiter;
              num3 = 6;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
              {
                num3 = 10;
                goto label_6;
              }
              else
                goto label_6;
            }
            catch (Exception ex)
            {
              int num4 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
                num4 = 0;
              while (true)
              {
                switch (num4)
                {
                  case 1:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.SetException(ex);
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 2 : 2;
                    continue;
                  case 2:
                    goto label_17;
                  default:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = -2;
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 0 : 1;
                    continue;
                }
              }
label_17:
              return;
            }
        }
      }
label_26:;
    }

    /// <inheritdoc />
    public async Task<IDisposable> TryLockAsync(string lockName, CancellationToken token = default (CancellationToken))
    {
      int num1 = 3;
      int num2;
      IDisposable result;
      while (true)
      {
        switch (num1)
        {
          case 1:
label_26:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003E1__state = -2;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 0 : 0;
            continue;
          case 2:
            num1 = 4;
            continue;
          case 3:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            num2 = (^this).\u003C\u003E1__state;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 2 : 0;
            continue;
          case 4:
            try
            {
              int num3;
              if (num2 == 0)
                num3 = 10;
              else
                goto label_14;
label_4:
              TaskAwaiter<ILock> awaiter;
              while (true)
              {
                TaskAwaiter<ILock> taskAwaiter;
                switch (num3)
                {
                  case 1:
                    goto label_26;
                  case 2:
                    taskAwaiter = awaiter;
                    num3 = 3;
                    continue;
                  case 3:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<ILock>, LockManager.\u003CTryLockAsync\u003Ed__28>(ref awaiter, this);
                    num3 = 11;
                    continue;
                  case 4:
                  case 10:
                    awaiter = taskAwaiter;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 9 : 0;
                    continue;
                  case 5:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = 0;
                    num3 = 2;
                    continue;
                  case 6:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = -1;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 0 : 0;
                    continue;
                  case 7:
                    if (!awaiter.IsCompleted)
                    {
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 1 : 5;
                      continue;
                    }
                    break;
                  case 8:
                    goto label_14;
                  case 9:
                    taskAwaiter = new TaskAwaiter<ILock>();
                    num3 = 6;
                    continue;
                  case 11:
                    goto label_20;
                }
                result = (IDisposable) awaiter.GetResult();
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 1 : 0;
              }
label_20:
              return;
label_14:
              awaiter = this.DistributedAsyncLockService.TryAcquireLockAsync(lockName, token).GetAwaiter();
              num3 = 7;
              goto label_4;
            }
            catch (Exception ex)
            {
              int num4 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
                num4 = 1;
              while (true)
              {
                switch (num4)
                {
                  case 0:
                    goto label_16;
                  case 1:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = -2;
                    num4 = 2;
                    continue;
                  case 2:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.SetException(ex);
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_12;
                }
              }
label_16:
              return;
label_12:
              return;
            }
          case 5:
            goto label_23;
          default:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003Et__builder.SetResult(result);
            num1 = 5;
            continue;
        }
      }
label_23:;
    }

    /// <inheritdoc />
    public async Task<IDisposable> TryLockAsync(
      string lockName,
      int timeout,
      CancellationToken token = default (CancellationToken))
    {
      int num1 = 4;
      int num2;
      IDisposable result;
      while (true)
      {
        switch (num1)
        {
          case 1:
            try
            {
              int num3;
              if (num2 == 0)
                num3 = 9;
              else
                goto label_6;
label_4:
              TaskAwaiter<ILock> awaiter;
              while (true)
              {
                TaskAwaiter<ILock> taskAwaiter;
                switch (num3)
                {
                  case 1:
                    goto label_24;
                  case 2:
                    taskAwaiter = new TaskAwaiter<ILock>();
                    num3 = 11;
                    continue;
                  case 3:
                    goto label_6;
                  case 4:
                    taskAwaiter = awaiter;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 7 : 7;
                    continue;
                  case 5:
                    if (!awaiter.IsCompleted)
                    {
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 9 : 10;
                      continue;
                    }
                    break;
                  case 6:
                  case 9:
                    awaiter = taskAwaiter;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 2 : 2;
                    continue;
                  case 7:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<ILock>, LockManager.\u003CTryLockAsync\u003Ed__29>(ref awaiter, this);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 1 : 8;
                    continue;
                  case 8:
                    goto label_20;
                  case 10:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = 0;
                    num3 = 4;
                    continue;
                  case 11:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = -1;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 0;
                    continue;
                }
                result = (IDisposable) awaiter.GetResult();
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 1;
              }
label_20:
              return;
label_6:
              // ISSUE: reference to a compiler-generated method
              awaiter = this.DistributedAsyncLockService.TryAcquireLockAsync(lockName, new TimeSpan?(LockManager.\u003CTryLockAsync\u003Ed__29.rhshKOCj8NjegDktDK8L((double) timeout)), token).GetAwaiter();
              num3 = 5;
              goto label_4;
            }
            catch (Exception ex)
            {
              int num4 = 2;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
                num4 = 0;
              while (true)
              {
                switch (num4)
                {
                  case 0:
                    goto label_16;
                  case 1:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.SetException(ex);
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 0;
                    continue;
                  case 2:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = -2;
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 1 : 1;
                    continue;
                  default:
                    goto label_10;
                }
              }
label_16:
              return;
label_10:
              return;
            }
          case 2:
label_24:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003E1__state = -2;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 0;
            continue;
          case 3:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 1;
            continue;
          case 4:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            num2 = (^this).\u003C\u003E1__state;
            num1 = 3;
            continue;
          case 5:
            goto label_23;
          default:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003Et__builder.SetResult(result);
            num1 = 5;
            continue;
        }
      }
label_23:;
    }

    public LockManager()
    {
      LockManager.JeDlSGhQRI8nqHDr2a6S();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool SfmnQPhQ8fLKRLT2am31() => LockManager.SJRSsNhQvnYCEoOyYiuX == null;

    internal static LockManager XFa4I5hQZMetWsqnr90o() => LockManager.SJRSsNhQvnYCEoOyYiuX;

    internal static TimeSpan INBbUXhQuIAlgBjgEWom([In] double obj0) => TimeSpan.FromSeconds(obj0);

    internal static object X1ytPShQISAc0cB2C7nA([In] object obj0, [In] object obj1) => (object) ((ILockService) obj0).AcquireLock((string) obj1);

    internal static void wi2eshhQVyxlaZawteJO([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object ncwbh9hQS1IXoNBOV1XN([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static void z4xltBhQiXCVgw6LLAiS([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Warn(obj1, (Exception) obj2);

    internal static void JeDlSGhQRI8nqHDr2a6S() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
