// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Logging.PeriodicBufferFlusher
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Threading;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Concurrent;
using System.Runtime.InteropServices;
using System.Threading;

namespace EleWise.ELMA.Logging
{
  /// <summary>Класс для периодической записи логов в файл</summary>
  internal sealed class PeriodicBufferFlusher
  {
    private readonly BlockingCollection<IPeriodicBufferingAppender> queue;
    internal static PeriodicBufferFlusher ij7iNOhJ4GZfXoASy0Kk;

    /// <summary>Экземпляр сервиса записи логов</summary>
    public static PeriodicBufferFlusher Instance { get; }

    /// <summary>Ctor</summary>
    private PeriodicBufferFlusher()
    {
      PeriodicBufferFlusher.t3dbIWhJAkuRUrLSqivp();
      this.queue = new BlockingCollection<IPeriodicBufferingAppender>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num1 = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
        num1 = 0;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_4;
          default:
            ThreadStart start = new ThreadStart(this.ProcessQueue);
            // ISSUE: reference to a compiler-generated field
            Action<Thread> action = PeriodicBufferFlusher.\u003C\u003Ec.\u003C\u003E9__4_0;
            Action<Thread> beforeStart;
            if (action == null)
            {
              // ISSUE: reference to a compiler-generated field
              PeriodicBufferFlusher.\u003C\u003Ec.\u003C\u003E9__4_0 = beforeStart = (Action<Thread>) (t =>
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
                      PeriodicBufferFlusher.\u003C\u003Ec.sdL1cGvHWkvuPltPyxTP((object) t, true);
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_4;
                  }
                }
label_2:
                return;
label_4:;
              });
            }
            else
              goto label_7;
label_6:
            ThreadStarter.StartNewThread(start, beforeStart);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 1 : 1;
            continue;
label_7:
            beforeStart = action;
            goto label_6;
        }
      }
label_4:;
    }

    /// <inheritdoc />
    public void Register(IPeriodicBufferingAppender appender)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.queue.Add(appender);
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

    /// <summary>Обработка очереди аппендеров</summary>
    private void ProcessQueue()
    {
      int num1 = 1;
      while (true)
      {
        switch (num1)
        {
          case 1:
label_14:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_13;
          default:
            try
            {
              this.queue.Take().Save();
              int num2 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
                num2 = 0;
              switch (num2)
              {
                default:
                  goto label_14;
              }
            }
            catch (ThreadAbortException ex)
            {
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
                num3 = 0;
              switch (num3)
              {
                default:
                  goto label_14;
              }
            }
            catch (Exception ex)
            {
              int num4 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
                num4 = 0;
              while (true)
              {
                switch (num4)
                {
                  case 1:
                    goto label_14;
                  default:
                    PeriodicBufferFlusher.aLXxVChJxSAuALkS93H8(PeriodicBufferFlusher.rT5AZwhJ7Hi2D0cK0xUH(), (object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-675505729 ^ -675345419), (object) ex));
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 1 : 1;
                    continue;
                }
              }
            }
        }
      }
label_13:;
    }

    static PeriodicBufferFlusher()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            PeriodicBufferFlusher.t3dbIWhJAkuRUrLSqivp();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            PeriodicBufferFlusher.Instance = new PeriodicBufferFlusher();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 2 : 1;
            continue;
        }
      }
label_2:;
    }

    internal static void t3dbIWhJAkuRUrLSqivp() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool h19aMkhJ6cXMqLXcnIqC() => PeriodicBufferFlusher.ij7iNOhJ4GZfXoASy0Kk == null;

    internal static PeriodicBufferFlusher yWPNPFhJHyKaFmw97w13() => PeriodicBufferFlusher.ij7iNOhJ4GZfXoASy0Kk;

    internal static object rT5AZwhJ7Hi2D0cK0xUH() => (object) Logger.Log;

    internal static void aLXxVChJxSAuALkS93H8([In] object obj0, [In] object obj1) => ((ILogger) obj0).Error(obj1);
  }
}
