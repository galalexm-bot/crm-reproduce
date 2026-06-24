// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Threading.ProcessThreadInfo
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Threading
{
  /// <summary>Хелпер для получения информации о текущем потоке.</summary>
  internal static class ProcessThreadInfo
  {
    private static readonly Process CurrentProcess;
    private static ProcessThreadInfo pWj3ReBitwTvpLyk9UUE;

    /// <summary>Получить текущий поток операционной системы</summary>
    /// <returns></returns>
    public static ProcessThread GetCurrentProcessThread()
    {
      int num1 = 3;
      IEnumerator enumerator;
      int currentThreadId;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_19;
          case 2:
            enumerator = (IEnumerator) ProcessThreadInfo.axypKvBiH1ocZSqGdQGf(ProcessThreadInfo.hvXs7aBi6VGVSQLTLMgo((object) ProcessThreadInfo.CurrentProcess));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 0 : 0;
            continue;
          case 3:
            currentThreadId = AppDomain.GetCurrentThreadId();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 2 : 1;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      ProcessThread currentProcessThread;
      try
      {
label_9:
        if (enumerator.MoveNext())
          goto label_11;
        else
          goto label_10;
label_5:
        ProcessThread processThread;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_20;
            case 2:
              currentProcessThread = processThread;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 1 : 1;
              continue;
            case 3:
              goto label_19;
            case 4:
              goto label_11;
            case 5:
              if (ProcessThreadInfo.Fmxtb5Bi7RND6eFLRI2n((object) processThread) == currentThreadId)
              {
                num2 = 2;
                continue;
              }
              goto label_9;
            default:
              goto label_9;
          }
        }
label_10:
        num2 = 3;
        goto label_5;
label_11:
        processThread = (ProcessThread) ProcessThreadInfo.zEFtGhBiAS7TcNAjVag0((object) enumerator);
        num2 = 5;
        goto label_5;
      }
      finally
      {
        IDisposable disposable = enumerator as IDisposable;
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
          num3 = 0;
        while (true)
        {
          switch (num3)
          {
            case 1:
            case 3:
              goto label_18;
            case 2:
              disposable.Dispose();
              num3 = 3;
              continue;
            default:
              if (disposable == null)
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 1 : 1;
                continue;
              }
              goto case 2;
          }
        }
label_18:;
      }
label_20:
      return currentProcessThread;
label_19:
      return (ProcessThread) null;
    }

    /// <summary>
    /// Общее количество времени, которое потратил поток на обработку процессором
    /// </summary>
    public static TimeSpan TotalProcessorTime
    {
      get
      {
        int num1 = 4;
        ProcessThread processThread1;
        ProcessThread processThread2;
        while (true)
        {
          switch (num1)
          {
            case 1:
            case 2:
              goto label_5;
            case 3:
              if (processThread1 == null)
              {
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 1 : 1;
                continue;
              }
              break;
            case 4:
              processThread1 = (ProcessThread) ProcessThreadInfo.G5XX76BixWtdk4eOGSQ5();
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 1 : 3;
              continue;
            case 5:
              goto label_7;
          }
          processThread2 = processThread1;
          num1 = 5;
        }
label_5:
        return TimeSpan.Zero;
label_7:
        TimeSpan totalProcessorTime;
        try
        {
          totalProcessorTime = ProcessThreadInfo.oDsqQ9Bi0UuXUlpmAYTD((object) processThread1);
          int num2 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
            num2 = 0;
          switch (num2)
          {
          }
        }
        finally
        {
          int num3;
          if (processThread2 == null)
            num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 1 : 0;
          else
            goto label_13;
label_12:
          switch (num3)
          {
            case 1:
            case 2:
          }
label_13:
          ProcessThreadInfo.ftddWCBimE4j1FHMcZLM((object) processThread2);
          num3 = 2;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0)
          {
            num3 = 1;
            goto label_12;
          }
          else
            goto label_12;
        }
        return totalProcessorTime;
      }
    }

    /// <summary>
    /// Общее количество времени, которое поток потратил на выполнение кода внутри приложения
    /// </summary>
    public static TimeSpan UserProcessorTime
    {
      get
      {
        int num1 = 3;
        ProcessThread processThread1;
        ProcessThread processThread2;
        while (true)
        {
          int num2 = num1;
          while (true)
          {
            switch (num2)
            {
              case 1:
                goto label_7;
              case 2:
                if (processThread1 != null)
                  goto case 4;
                else
                  goto label_17;
              case 3:
                processThread1 = (ProcessThread) ProcessThreadInfo.G5XX76BixWtdk4eOGSQ5();
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 2 : 0;
                continue;
              case 4:
                processThread2 = processThread1;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 1 : 1;
                continue;
              default:
                goto label_5;
            }
          }
label_17:
          num1 = 5;
        }
label_5:
        return TimeSpan.Zero;
label_7:
        TimeSpan userProcessorTime;
        try
        {
          userProcessorTime = ProcessThreadInfo.eRpFttBiysmjAqXrVa21((object) processThread1);
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0)
            num3 = 0;
          switch (num3)
          {
          }
        }
        finally
        {
          if (processThread2 != null)
          {
            int num4 = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
              num4 = 0;
            while (true)
            {
              switch (num4)
              {
                case 1:
                  goto label_15;
                default:
                  processThread2.Dispose();
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 1 : 1;
                  continue;
              }
            }
          }
label_15:;
        }
        return userProcessorTime;
      }
    }

    /// <summary>
    /// Общее количество времени, которое поток потратил на выполнение кода внутри ядра ОС
    /// </summary>
    public static TimeSpan PrivilegedProcessorTime
    {
      get
      {
        int num1 = 1;
        ProcessThread processThread1;
        ProcessThread processThread2;
        while (true)
        {
          switch (num1)
          {
            case 1:
              processThread1 = (ProcessThread) ProcessThreadInfo.G5XX76BixWtdk4eOGSQ5();
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 0;
              continue;
            case 2:
            case 5:
              goto label_14;
            case 3:
              processThread2 = processThread1;
              num1 = 4;
              continue;
            case 4:
              goto label_5;
            default:
              if (processThread1 == null)
              {
                num1 = 5;
                continue;
              }
              goto case 3;
          }
        }
label_5:
        TimeSpan privilegedProcessorTime;
        try
        {
          privilegedProcessorTime = ProcessThreadInfo.SX56oDBiMK55SvrayuXM((object) processThread1);
          int num2 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
            num2 = 0;
          switch (num2)
          {
          }
        }
        finally
        {
          int num3;
          if (processThread2 == null)
            num3 = 2;
          else
            goto label_11;
label_10:
          switch (num3)
          {
            case 1:
              break;
            default:
          }
label_11:
          processThread2.Dispose();
          num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
          {
            num3 = 0;
            goto label_10;
          }
          else
            goto label_10;
        }
        return privilegedProcessorTime;
label_14:
        return TimeSpan.Zero;
      }
    }

    static ProcessThreadInfo()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            ProcessThreadInfo.CurrentProcess = Process.GetCurrentProcess();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static object hvXs7aBi6VGVSQLTLMgo([In] object obj0) => (object) ((Process) obj0).Threads;

    internal static object axypKvBiH1ocZSqGdQGf([In] object obj0) => (object) ((ReadOnlyCollectionBase) obj0).GetEnumerator();

    internal static object zEFtGhBiAS7TcNAjVag0([In] object obj0) => ((IEnumerator) obj0).Current;

    internal static int Fmxtb5Bi7RND6eFLRI2n([In] object obj0) => ((ProcessThread) obj0).Id;

    internal static bool E9y61BBiwxJifGZ4P4wO() => ProcessThreadInfo.pWj3ReBitwTvpLyk9UUE == null;

    internal static ProcessThreadInfo Q3goFFBi45GdSxcQGYdk() => ProcessThreadInfo.pWj3ReBitwTvpLyk9UUE;

    internal static object G5XX76BixWtdk4eOGSQ5() => (object) ProcessThreadInfo.GetCurrentProcessThread();

    internal static TimeSpan oDsqQ9Bi0UuXUlpmAYTD([In] object obj0) => ((ProcessThread) obj0).TotalProcessorTime;

    internal static void ftddWCBimE4j1FHMcZLM([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static TimeSpan eRpFttBiysmjAqXrVa21([In] object obj0) => ((ProcessThread) obj0).UserProcessorTime;

    internal static TimeSpan SX56oDBiMK55SvrayuXM([In] object obj0) => ((ProcessThread) obj0).PrivilegedProcessorTime;
  }
}
