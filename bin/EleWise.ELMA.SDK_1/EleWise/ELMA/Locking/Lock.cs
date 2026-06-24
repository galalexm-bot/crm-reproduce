// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Locking.Lock
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Extensions;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Locking
{
  /// <summary>Базовая блокировка</summary>
  public class Lock : ILock, IDisposable
  {
    private readonly string name;
    private readonly System.Action releaseLockAction;
    private int count;
    private int totalCount;
    protected readonly TimeSpan ttl;
    protected bool disposed;
    /// <summary>Действия выполняемые перед освобождением</summary>
    public EventHandler Disposing;
    internal static Lock rLACYbhrl2vZLKnMpbto;

    /// <summary>Ctor</summary>
    /// <param name="name">Имя блокировки</param>
    /// <param name="ttl">Время жизни блокировки</param>
    /// <param name="releaseLockAction">Действие при освобождении блокировки</param>
    public Lock(string name, TimeSpan ttl, System.Action releaseLockAction)
    {
      Lock.F5EmBchr5YSjmiKlACZW();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.releaseLockAction = releaseLockAction;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 0 : 0;
            continue;
          case 2:
            this.ttl = ttl;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 1 : 1;
            continue;
          case 3:
            this.name = name;
            num = 2;
            continue;
          case 4:
            goto label_2;
          case 5:
            this.totalCount = 1;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 4 : 3;
            continue;
          default:
            this.count = 1;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 4 : 5;
            continue;
        }
      }
label_2:;
    }

    /// <inheritdoc />
    public virtual string Name => this.name;

    /// <summary>Увеличить счетчик блокировок</summary>
    internal void Increment()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            ++this.count;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            ++this.totalCount;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 2 : 0;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Получить текущее значение счетчика блокировок</summary>
    public int Count => this.count;

    /// <summary>Получить общее значение счетчика блокировок</summary>
    public int TotalCount => this.totalCount;

    /// <summary>Освободить блокировку</summary>
    public virtual void Dispose()
    {
      int num = 8;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 5:
            this.OnDisposing();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 0 : 0;
            continue;
          case 2:
            if (this.releaseLockAction == null)
            {
              num = 5;
              continue;
            }
            goto case 9;
          case 3:
            this.Disposing = (EventHandler) null;
            num = 10;
            continue;
          case 4:
            goto label_11;
          case 6:
            if (this.count != 0)
            {
              num = 4;
              continue;
            }
            goto case 2;
          case 7:
            goto label_9;
          case 8:
            if (this.disposed)
            {
              num = 7;
              continue;
            }
            --this.count;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 3 : 6;
            continue;
          case 9:
            this.releaseLockAction();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 1 : 1;
            continue;
          case 10:
            goto label_6;
          default:
            this.disposed = true;
            num = 3;
            continue;
        }
      }
label_11:
      return;
label_9:
      return;
label_6:;
    }

    private void OnDisposing()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            Lock.NZZjKthrjf38s8eO8VSG((object) this.Disposing, (object) this, (object) EventArgs.Empty);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    internal static void F5EmBchr5YSjmiKlACZW() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool CmteD0hrrklyIJkwpuht() => Lock.rLACYbhrl2vZLKnMpbto == null;

    internal static Lock MpJbeGhrgE2B1tQmJWTD() => Lock.rLACYbhrl2vZLKnMpbto;

    internal static void NZZjKthrjf38s8eO8VSG([In] object obj0, [In] object obj1, [In] object obj2) => ((EventHandler) obj0).Raise(obj1, (EventArgs) obj2);
  }
}
