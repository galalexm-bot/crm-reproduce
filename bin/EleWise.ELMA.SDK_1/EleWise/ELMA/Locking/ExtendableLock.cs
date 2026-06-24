// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Locking.ExtendableLock
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Logging;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace EleWise.ELMA.Locking
{
  /// <summary>Блокировка с возможностью продления</summary>
  public class ExtendableLock : Lock
  {
    private int extend;
    private Timer extendTimer;
    private readonly System.Action extendLockAction;
    private static ExtendableLock NuGaRChgCDhiYmjm0lQd;

    /// <summary>Ctor</summary>
    /// <param name="name">Имя блокировки</param>
    /// <param name="ttl">Время жизни блокировки</param>
    /// <param name="extendLockAction">Действие для продления блокировки</param>
    /// <param name="releaseLockAction">Действие при освобождении блокировки</param>
    public ExtendableLock(
      string name,
      TimeSpan ttl,
      System.Action extendLockAction,
      System.Action releaseLockAction)
    {
      ExtendableLock.jSSuZFhgZswU0g1WgYf6();
      // ISSUE: explicit constructor call
      base.\u002Ector(name, ttl, releaseLockAction);
      int num = 5;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.Start();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 2 : 0;
            continue;
          case 2:
            goto label_7;
          case 3:
            goto label_3;
          case 4:
            this.extendLockAction = extendLockAction;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 0 : 0;
            continue;
          case 5:
            this.extend = 0;
            num = 4;
            continue;
          default:
            if (extendLockAction == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 2 : 3;
              continue;
            }
            goto case 1;
        }
      }
label_7:
      return;
label_3:;
    }

    /// <summary>Кол-во продлений блокировки</summary>
    public virtual int ExtendCount => this.extend;

    /// <inheritdoc />
    public override void Dispose()
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_4;
          case 1:
          case 4:
            base.Dispose();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 0;
            continue;
          case 2:
            if (this.Count == 1)
            {
              num = 5;
              continue;
            }
            goto case 1;
          case 3:
            if (!this.disposed)
            {
              num = 2;
              continue;
            }
            goto label_3;
          case 5:
            if (this.extendTimer == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 1 : 4;
              continue;
            }
            goto case 9;
          case 6:
            goto label_10;
          case 7:
            this.extendTimer = (Timer) null;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 1 : 0;
            continue;
          case 8:
            this.extendTimer.Dispose();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 7 : 1;
            continue;
          case 9:
            this.extendTimer.Change(-1, -1);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 4 : 8;
            continue;
          default:
            goto label_2;
        }
      }
label_4:
      return;
label_10:
      return;
label_2:
      return;
label_3:;
    }

    private void Start()
    {
      int num1 = 1;
      double num2;
      TimeSpan ttl;
      while (true)
      {
        switch (num1)
        {
          case 1:
            ttl = this.ttl;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            this.extendTimer = new Timer((TimerCallback) (state =>
            {
              switch (1)
              {
                case 1:
                  try
                  {
                    int num3;
                    if (this.extendLockAction != null)
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 0;
                    else
                      goto label_6;
label_4:
                    while (true)
                    {
                      switch (num3)
                      {
                        case 1:
                          goto label_6;
                        case 2:
                          goto label_8;
                        default:
                          ExtendableLock.oZjXvEhguD5HHTaIljkp((object) this.extendLockAction);
                          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 1 : 1;
                          continue;
                      }
                    }
label_8:
                    break;
label_6:
                    ++this.extend;
                    num3 = 2;
                    goto label_4;
                  }
                  catch (Exception ex)
                  {
                    int num4 = 1;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
                      num4 = 1;
                    while (true)
                    {
                      switch (num4)
                      {
                        case 0:
                          goto label_5;
                        case 1:
                          ExtendableLock.H7wxKHhgSCZlnW8Bksmx(ExtendableLock.Ai7vHdhgIY3btg1L39ii(), ExtendableLock.Q8MmpThgVDkKEL0G4q9Z((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138160520 ^ -2138186070), (object) this.Name), (object) ex);
                          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 0 : 0;
                          continue;
                        default:
                          goto label_1;
                      }
                    }
label_5:
                    break;
label_1:
                    break;
                  }
              }
            }), (object) null, (int) num2, (int) num2);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 2 : 0;
            continue;
          default:
            num2 = ttl.TotalMilliseconds / 2.0;
            num1 = 3;
            continue;
        }
      }
label_2:;
    }

    internal static void jSSuZFhgZswU0g1WgYf6() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool iDwJ2yhgvJO1j2IJxByd() => ExtendableLock.NuGaRChgCDhiYmjm0lQd == null;

    internal static ExtendableLock AauHYghg8oHnWpixopcf() => ExtendableLock.NuGaRChgCDhiYmjm0lQd;

    internal static void oZjXvEhguD5HHTaIljkp([In] object obj0) => ((System.Action) obj0)();

    internal static object Ai7vHdhgIY3btg1L39ii() => (object) Logger.Log;

    internal static object Q8MmpThgVDkKEL0G4q9Z([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static void H7wxKHhgSCZlnW8Bksmx([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Warn(obj1, (Exception) obj2);
  }
}
