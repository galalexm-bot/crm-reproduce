// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Logging.PeriodicBufferingAppender
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using log4net.Appender;
using log4net.Core;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace EleWise.ELMA.Logging
{
  /// <summary>
  /// Аппендер с буферизацией и перенаправлением событий другим аппендерам с отправкой событий с заданным периодом
  /// </summary>
  public sealed class PeriodicBufferingAppender : 
    BufferingForwardingAppender,
    IPeriodicBufferingAppender
  {
    /// <summary>Период по умолчанию</summary>
    private static readonly int DefaultPeriod;
    private TimeSpan timespanPeriod;
    private int period;
    private readonly Timer timer;
    private static PeriodicBufferingAppender JIIO27hJ0AbSoBIUBdvm;

    /// <summary>Ctor</summary>
    public PeriodicBufferingAppender()
    {
      PeriodicBufferingAppender.mhJgLOhJMywaeaLKsx65();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.Period = PeriodicBufferingAppender.DefaultPeriod;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 0;
            continue;
          case 2:
            this.timer = new Timer(new TimerCallback(this.TimerRegister), (object) null, -1, -1);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    /// <summary>Период записи в секундах</summary>
    public int Period
    {
      get => this.period;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (value > 0)
              {
                this.period = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 2 : 2;
                continue;
              }
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 0 : 0;
              continue;
            case 2:
              this.timespanPeriod = TimeSpan.FromSeconds((double) value);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 3 : 0;
              continue;
            case 3:
              goto label_2;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:
        throw new ArgumentOutOfRangeException((string) PeriodicBufferingAppender.RMxJBChJJt9calWIafYE(-1317790512 ^ -1317564852), (string) PeriodicBufferingAppender.xxvyhWhJ9oCAZHGKDt6T(PeriodicBufferingAppender.RMxJBChJJt9calWIafYE(-1867198571 ^ -1867031239)));
      }
    }

    /// <inheritdoc />
    public void Save()
    {
      int num1 = 1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            try
            {
              PeriodicBufferingAppender.jZmmxbhJd1qFdYqgIEf0((object) this, true);
              int num2 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
                num2 = 0;
              switch (num2)
              {
              }
            }
            catch (Exception ex)
            {
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
                num3 = 0;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    goto label_10;
                  default:
                    PeriodicBufferingAppender.MyQLCMhJl5tdgVA4l5PY((object) this.ErrorHandler, PeriodicBufferingAppender.xxvyhWhJ9oCAZHGKDt6T(PeriodicBufferingAppender.RMxJBChJJt9calWIafYE(-1426456882 ^ 2009939514 ^ -583576580)), (object) ex);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 0 : 1;
                    continue;
                }
              }
            }
            break;
          case 2:
            goto label_9;
        }
label_10:
        this.MoveTimer();
        num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 0 : 2;
      }
label_9:;
    }

    /// <inheritdoc />
    public override void ActivateOptions()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.MoveTimer();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 0 : 0;
            continue;
          case 2:
            base.ActivateOptions();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 1 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    /// <inheritdoc />
    protected override void SendBuffer(LoggingEvent[] events)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.MoveTimer();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 0;
            continue;
          case 2:
            base.SendBuffer(events);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    /// <summary>Регистрация аппендера для записи событий</summary>
    /// <param name="obj">Параметр делегата</param>
    private void TimerRegister(object obj)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ((PeriodicBufferFlusher) PeriodicBufferingAppender.TPAg6WhJrPFTTNaaoi6C()).Register((IPeriodicBufferingAppender) this);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 0;
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
    /// Установить следующее срабатывание таймера в соответствии с <see cref="P:EleWise.ELMA.Logging.PeriodicBufferingAppender.Period" />
    /// </summary>
    private void MoveTimer()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            PeriodicBufferingAppender.yJ0gsmhJ5qXggoFoibk7((object) this.timer, this.timespanPeriod, PeriodicBufferingAppender.ARbIo9hJgg3AkFosyJLc(-1.0));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    static PeriodicBufferingAppender()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            PeriodicBufferingAppender.mhJgLOhJMywaeaLKsx65();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            PeriodicBufferingAppender.DefaultPeriod = 10;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 2 : 0;
            continue;
        }
      }
label_2:;
    }

    internal static void mhJgLOhJMywaeaLKsx65() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool KvusXHhJm77qBNPAKYx2() => PeriodicBufferingAppender.JIIO27hJ0AbSoBIUBdvm == null;

    internal static PeriodicBufferingAppender MccYJIhJyFlQfWfaeQFh() => PeriodicBufferingAppender.JIIO27hJ0AbSoBIUBdvm;

    internal static object RMxJBChJJt9calWIafYE(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object xxvyhWhJ9oCAZHGKDt6T([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static void jZmmxbhJd1qFdYqgIEf0([In] object obj0, [In] bool obj1) => ((BufferingAppenderSkeleton) obj0).Flush(obj1);

    internal static void MyQLCMhJl5tdgVA4l5PY([In] object obj0, [In] object obj1, [In] object obj2) => ((IErrorHandler) obj0).Error((string) obj1, (Exception) obj2);

    internal static object TPAg6WhJrPFTTNaaoi6C() => (object) PeriodicBufferFlusher.Instance;

    internal static TimeSpan ARbIo9hJgg3AkFosyJLc([In] double obj0) => TimeSpan.FromMilliseconds(obj0);

    internal static bool yJ0gsmhJ5qXggoFoibk7([In] object obj0, [In] TimeSpan obj1, [In] TimeSpan obj2) => ((Timer) obj0).Change(obj1, obj2);
  }
}
