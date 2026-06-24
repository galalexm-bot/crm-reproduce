// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Threading.ThreadStarter
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Diagnostics;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime.Context;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;

namespace EleWise.ELMA.Threading
{
  /// <summary>Класс, для запуска потоковых операций</summary>
  public static class ThreadStarter
  {
    internal static ThreadStarter Q8XGkUBRuCT0nBV5DRnu;

    /// <summary>
    /// Запускает поток с использованием <see cref="M:System.Threading.ThreadPool.QueueUserWorkItem(System.Threading.WaitCallback,System.Object)" />
    /// </summary>
    /// <param name="callback">Функция для запуска</param>
    /// <exception cref="T:System.ArgumentNullException">Если <c>callback</c> равен <c>null</c></exception>
    /// <returns>true, если добавлено в очередь удачно</returns>
    public static bool QueueThread(WaitCallback callback) => ThreadStarter.SEdVkgBRSrp8E3ufh8gG((object) callback, (object) null);

    /// <summary>
    /// Запускает поток с использованием <see cref="M:System.Threading.ThreadPool.QueueUserWorkItem(System.Threading.WaitCallback,System.Object)" />
    /// </summary>
    /// <param name="callback">Функция для запуска</param>
    /// <exception cref="T:System.ArgumentNullException">Если <c>callback</c> равен <c>null</c></exception>
    /// <returns>true, если добавлено в очередь удачно</returns>
    public static bool QueueThread(ThreadStart callback)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            ThreadStarter.YnAkxYBRRfepxk4cgu7x((object) callback, ThreadStarter.V73cDsBRixbJhg6WZESH(-1867198571 ^ -1867131751));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return ThreadStarter.dGkRulBRTrgfBtM98DHe((object) new ThreadStarter.PrivateThreadStarter(callback, 0, (CultureInfo) ThreadStarter.br6hZRBRXbUTpJHmMxVy(ThreadStarter.MQBxKMBRKanwTb8Jt7VL(ThreadStarter.I3GWVSBRqjuIGCCeplLG())), (object) null, (Action<Thread>) null));
    }

    /// <summary>
    /// Запускает поток с использованием <see cref="M:System.Threading.ThreadPool.QueueUserWorkItem(System.Threading.WaitCallback,System.Object)" />
    /// </summary>
    /// <param name="callback">Функция для запуска</param>
    /// <param name="state">Данные состояния</param>
    /// <exception cref="T:System.ArgumentNullException">Если <c>callback</c> равен <c>null</c></exception>
    /// <returns>true, если добавлено в очередь удачно</returns>
    public static bool QueueThread(WaitCallback callback, object state)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            Contract.ArgumentNotNull((object) callback, (string) ThreadStarter.V73cDsBRixbJhg6WZESH(-1872275253 >> 6 ^ -29325713));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return ThreadStarter.dGkRulBRTrgfBtM98DHe((object) new ThreadStarter.PrivateThreadStarter(callback, (CultureInfo) ThreadStarter.br6hZRBRXbUTpJHmMxVy((object) Thread.CurrentThread.CurrentCulture), state));
    }

    /// <summary>Выполнить в отдельном потоке</summary>
    /// <param name="start">Метод, выполняющийся в потоке</param>
    /// <exception cref="T:System.ArgumentNullException">Если <c>start</c> равен <c>null</c></exception>
    /// <returns>Поток</returns>
    public static Thread StartNewThread(ParameterizedThreadStart start) => (Thread) ThreadStarter.ySpRIpBRkHBJJibwE2Ub((object) start, (object) null);

    /// <summary>Выполнить в отдельном потоке</summary>
    /// <param name="start">Метод, выполняющийся в потоке</param>
    /// <param name="state">Состояние</param>
    /// <exception cref="T:System.ArgumentNullException">Если <c>start</c> равен <c>null</c></exception>
    /// <returns>Поток</returns>
    public static Thread StartNewThread(ParameterizedThreadStart start, object state) => ThreadStarter.StartNewThread(start, 0, state, (Action<Thread>) null);

    /// <summary>Запустить в отдельном потоке</summary>
    /// <param name="start">Метод, выполняющийся в потоке</param>
    /// <param name="state">Состояние</param>
    /// <param name="beforeStart">Действие, которое необходимо выполнить перед запуском потока</param>
    /// <exception cref="T:System.ArgumentNullException">Если <c>start</c> равен <c>null</c></exception>
    /// <returns>Поток</returns>
    public static Thread StartNewThread(
      ParameterizedThreadStart start,
      object state,
      Action<Thread> beforeStart)
    {
      return ThreadStarter.StartNewThread(start, 0, state, beforeStart);
    }

    /// <summary>Запустить в отдельном потоке</summary>
    /// <param name="start">Метод, выполняющийся в потоке</param>
    /// <param name="maxStackSize">Максимальный размер стека</param>
    /// <param name="state">Состояние</param>
    /// <param name="beforeStart">Действие, которое необходимо выполнить перед запуском потока</param>
    /// <exception cref="T:System.ArgumentNullException">Если <c>start</c> равен <c>null</c></exception>
    /// <returns>Поток</returns>
    public static Thread StartNewThread(
      ParameterizedThreadStart start,
      int maxStackSize,
      object state,
      Action<Thread> beforeStart)
    {
      Contract.ArgumentNotNull((object) start, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105199646 ^ -105128766));
      return new ThreadStarter.PrivateThreadStarter(start, maxStackSize, (CultureInfo) Thread.CurrentThread.CurrentCulture.Clone(), state, beforeStart).StartThread();
    }

    /// <summary>Запустить в отдельном потоке</summary>
    /// <param name="start">Метод, выполняющийся в потоке</param>
    /// <exception cref="T:System.ArgumentNullException">Если <c>start</c> равен <c>null</c></exception>
    /// <returns>Поток</returns>
    public static Thread StartNewThread(ThreadStart start) => ThreadStarter.StartNewThread(start, (Action<Thread>) null);

    /// <summary>Запустить в отдельном потоке</summary>
    /// <param name="start">Метод, выполняющийся в потоке</param>
    /// <param name="beforeStart">Действие, которое необходимо выполнить перед запуском потока</param>
    /// <exception cref="T:System.ArgumentNullException">Если <c>start</c> равен <c>null</c></exception>
    /// <returns>Потоко</returns>
    public static Thread StartNewThread(ThreadStart start, Action<Thread> beforeStart) => ThreadStarter.StartNewThread(start, 0, beforeStart);

    /// <summary>Запустить в отдельном потоке</summary>
    /// <param name="start">Метод, выполняющийся в потоке</param>
    /// <param name="maxStackSize">Максимальный размер стека</param>
    /// <param name="beforeStart">Действие, которое необходимо выполнить перед запуском потока</param>
    /// <exception cref="T:System.ArgumentNullException">Если <c>start</c> равен <c>null</c></exception>
    /// <returns>Поток</returns>
    public static Thread StartNewThread(
      ThreadStart start,
      int maxStackSize,
      Action<Thread> beforeStart)
    {
      Contract.ArgumentNotNull((object) start, z2jc63fLkugS1X8Q9N.tE1kD1vbB(322893104 - -1992822529 ^ -1979310319));
      return new ThreadStarter.PrivateThreadStarter(start, maxStackSize, (CultureInfo) Thread.CurrentThread.CurrentCulture.Clone(), (object) null, beforeStart).StartThread();
    }

    /// <summary>
    /// Блокирует вызывающий поток до завершения потока, продолжая отправлять стандартные сообщения COM и SendMessage.
    /// </summary>
    /// <exception cref="T:System.ArgumentNullException">Если <c>thread</c> равен <c>null</c></exception>
    /// <param name="thread">Поток</param>
    public static void JoinThread(this Thread thread)
    {
      int num = 2;
      Thread thread1;
      while (true)
      {
        switch (num)
        {
          case 1:
            thread1 = thread;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 0 : 0;
            continue;
          case 2:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 1 : 1;
            continue;
          case 3:
            goto label_2;
          case 4:
            DiagnosticsManager.StartCall<ThreadJoinCallInfo>((Func<ThreadJoinCallInfo>) (() => new ThreadJoinCallInfo(thread1)), new System.Action(thread1.Join));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 0 : 3;
            continue;
          default:
            ThreadStarter.YnAkxYBRRfepxk4cgu7x((object) thread1, ThreadStarter.V73cDsBRixbJhg6WZESH(-1088304168 ^ -1088368394));
            num = 4;
            continue;
        }
      }
label_2:;
    }

    /// <summary>
    /// Блокирует вызывающий поток до завершения потока или истечения указанного времени, продолжая отправлять стандартные сообщения COM и SendMessage.
    /// </summary>
    /// <param name="thread">Поток</param>
    /// <param name="millisecondsTimeout">Время ожидания в мс</param>
    /// <exception cref="T:System.ArgumentNullException">Если <c>thread</c> равен <c>null</c></exception>
    /// <returns><c>true</c> - если поток завершился</returns>
    public static bool JoinThread(this Thread thread, int millisecondsTimeout)
    {
      int num1 = 5;
      ThreadJoinCallInfo threadJoinCallInfo;
      Thread thread1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            ThreadStarter.YnAkxYBRRfepxk4cgu7x((object) thread1, ThreadStarter.V73cDsBRixbJhg6WZESH(-138018305 ^ -137946415));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 2 : 1;
            continue;
          case 2:
            threadJoinCallInfo = DiagnosticsManager.StartCall<ThreadJoinCallInfo>((Func<ThreadJoinCallInfo>) (() => new ThreadJoinCallInfo(thread1)));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 0 : 0;
            continue;
          case 3:
            goto label_2;
          case 4:
            thread1 = thread;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 1 : 0;
            continue;
          case 5:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 4 : 1;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      bool flag;
      return flag;
label_4:
      try
      {
        flag = ThreadStarter.rJ1OhXBRn3DX0JZAVsSu((object) thread1, millisecondsTimeout);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
          num2 = 0;
        switch (num2)
        {
          default:
            goto label_2;
        }
      }
      finally
      {
        int num3;
        if (threadJoinCallInfo == null)
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 0 : 0;
        else
          goto label_11;
label_10:
        switch (num3)
        {
          case 2:
            break;
          default:
        }
label_11:
        ThreadStarter.REF558BROKjYWofJ6tId((object) threadJoinCallInfo);
        num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
        {
          num3 = 1;
          goto label_10;
        }
        else
          goto label_10;
      }
    }

    /// <summary>
    /// Блокирует вызывающий поток до завершения потока или истечения указанного времени, продолжая отправлять стандартные сообщения COM и SendMessage.
    /// </summary>
    /// <param name="thread">Поток</param>
    /// <param name="timeout">Время ожидания</param>
    /// <exception cref="T:System.ArgumentNullException">Если <c>thread</c> равен <c>null</c></exception>
    /// <returns><c>true</c> - если поток завершился</returns>
    public static bool JoinThread(this Thread thread, TimeSpan timeout)
    {
      int num1 = 4;
      ThreadJoinCallInfo threadJoinCallInfo;
      Thread thread1;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_6;
            case 2:
              Contract.ArgumentNotNull((object) thread1, (string) ThreadStarter.V73cDsBRixbJhg6WZESH(-867826612 ^ -867754142));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 0;
              continue;
            case 3:
              goto label_3;
            case 4:
              goto label_15;
            case 5:
              goto label_5;
            default:
              threadJoinCallInfo = DiagnosticsManager.StartCall<ThreadJoinCallInfo>((Func<ThreadJoinCallInfo>) (() => new ThreadJoinCallInfo(thread1)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 1;
              continue;
          }
        }
label_3:
        thread1 = thread;
        num1 = 2;
        continue;
label_15:
        num1 = 3;
      }
label_5:
      bool flag;
      return flag;
label_6:
      try
      {
        flag = ThreadStarter.cnH65ZBR2ihNPEtO5Wbv((object) thread1, timeout);
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
          num3 = 0;
        switch (num3)
        {
          default:
            goto label_5;
        }
      }
      finally
      {
        int num4;
        if (threadJoinCallInfo == null)
          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 0 : 0;
        else
          goto label_12;
label_11:
        switch (num4)
        {
          case 2:
            break;
          default:
        }
label_12:
        ThreadStarter.REF558BROKjYWofJ6tId((object) threadJoinCallInfo);
        num4 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
        {
          num4 = 0;
          goto label_11;
        }
        else
          goto label_11;
      }
    }

    internal static bool SEdVkgBRSrp8E3ufh8gG([In] object obj0, [In] object obj1) => ThreadStarter.QueueThread((WaitCallback) obj0, obj1);

    internal static bool HeA0yMBRImLH8twty4u9() => ThreadStarter.Q8XGkUBRuCT0nBV5DRnu == null;

    internal static ThreadStarter hdOjVLBRVRnH7vJ3pVVF() => ThreadStarter.Q8XGkUBRuCT0nBV5DRnu;

    internal static object V73cDsBRixbJhg6WZESH(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void YnAkxYBRRfepxk4cgu7x([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static object I3GWVSBRqjuIGCCeplLG() => (object) Thread.CurrentThread;

    internal static object MQBxKMBRKanwTb8Jt7VL([In] object obj0) => (object) ((Thread) obj0).CurrentCulture;

    internal static object br6hZRBRXbUTpJHmMxVy([In] object obj0) => ((CultureInfo) obj0).Clone();

    internal static bool dGkRulBRTrgfBtM98DHe([In] object obj0) => ((ThreadStarter.PrivateThreadStarter) obj0).QueueThread();

    internal static object ySpRIpBRkHBJJibwE2Ub([In] object obj0, [In] object obj1) => (object) ThreadStarter.StartNewThread((ParameterizedThreadStart) obj0, obj1);

    internal static bool rJ1OhXBRn3DX0JZAVsSu([In] object obj0, [In] int obj1) => ((Thread) obj0).Join(obj1);

    internal static void REF558BROKjYWofJ6tId([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static bool cnH65ZBR2ihNPEtO5Wbv([In] object obj0, [In] TimeSpan obj1) => ((Thread) obj0).Join(obj1);

    /// <summary>Класс хелпера для запуска потоков</summary>
    private class PrivateThreadStarter
    {
      private Guid createdParentContextInfoUid;
      internal static ThreadStarter.PrivateThreadStarter uiB9t6QCMlivvHrMg4Px;

      /// <summary>Ctor</summary>
      /// <param name="start">Метод, выполняющийся в потоке</param>
      /// <param name="maxStackSize">Максимальный размер стека</param>
      /// <param name="currentCulture">Текущая культура</param>
      /// <param name="state">Состояние</param>
      /// <param name="beforeThreadStart">Действие, которое необходимо выполнить перед запуском потока</param>
      public PrivateThreadStarter(
        ThreadStart start,
        int maxStackSize,
        CultureInfo currentCulture,
        object state,
        Action<Thread> beforeThreadStart)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        this.Start = start;
        this.MaxStackSize = maxStackSize;
        this.CurrentCulture = currentCulture;
        this.State = state;
        this.BeforeThreadStart = beforeThreadStart;
      }

      /// <summary>Ctor</summary>
      /// <param name="parametrizedStart">Метод, выполняющийся в потоке</param>
      /// <param name="maxStackSize">Максимальный размер стека</param>
      /// <param name="currentCulture">Текущая культура</param>
      /// <param name="state">Состояние</param>
      /// <param name="beforeThreadStart">Действие, которое необходимо выполнить перед запуском потока</param>
      public PrivateThreadStarter(
        ParameterizedThreadStart parametrizedStart,
        int maxStackSize,
        CultureInfo currentCulture,
        object state,
        Action<Thread> beforeThreadStart)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        this.ParametrizedStart = parametrizedStart;
        this.MaxStackSize = maxStackSize;
        this.CurrentCulture = currentCulture;
        this.State = state;
        this.BeforeThreadStart = beforeThreadStart;
      }

      /// <summary>Ctor</summary>
      /// <param name="callback">Метод, выполняющийся в потоке</param>
      /// <param name="cultureInfo">Текущая культура</param>
      /// <param name="state">Состояние</param>
      public PrivateThreadStarter(WaitCallback callback, CultureInfo cultureInfo, object state)
      {
        ThreadStarter.PrivateThreadStarter.C9yB4oQCdRpBBmw1g66a();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 3;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.State = state;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 0 : 0;
              continue;
            case 2:
              this.CurrentCulture = cultureInfo;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 1;
              continue;
            case 3:
              this.Callback = callback;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 2 : 2;
              continue;
            default:
              goto label_6;
          }
        }
label_2:
        return;
label_6:;
      }

      /// <summary>Поместить для выполнения в системный пул потоков</summary>
      /// <returns><c>true</c> - метод размещен в пуле потоков</returns>
      public bool QueueThread()
      {
        bool flag;
        switch (1)
        {
          case 1:
            try
            {
              int num;
              if (ThreadStarter.PrivateThreadStarter.HNNs93QClGC4h7sgBr9a())
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 1 : 1;
              else
                goto label_7;
label_3:
              CallContextInfo diagnosticSession;
              while (true)
              {
                switch (num)
                {
                  case 1:
                    diagnosticSession = ((DiagnosticsManager) ThreadStarter.PrivateThreadStarter.h8GfXhQCry9p3IUe6Try()).GetCurrentDiagnosticSession();
                    num = 4;
                    continue;
                  case 2:
                    this.createdParentContextInfoUid = ThreadStarter.PrivateThreadStarter.LD9HqnQCgrjfWh12JmAq((object) diagnosticSession);
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 0;
                    continue;
                  case 3:
                    goto label_15;
                  case 4:
                    if (diagnosticSession != null)
                    {
                      num = 2;
                      continue;
                    }
                    goto label_7;
                  default:
                    goto label_7;
                }
              }
label_7:
              flag = ThreadPool.QueueUserWorkItem(new WaitCallback(ThreadStarter.PrivateThreadStarter.InternalThread), (object) this);
              num = 3;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
              {
                num = 3;
                goto label_3;
              }
              else
                goto label_3;
            }
            catch (Exception ex)
            {
              int num = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
                num = 0;
              while (true)
              {
                switch (num)
                {
                  case 1:
                    goto label_14;
                  default:
                    ThreadStarter.PrivateThreadStarter.eigeFTQCjqRvdBQK97Pj(ThreadStarter.PrivateThreadStarter.VYwLpNQC5ZJRLcHGaE7i(), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1925118608 << 2 ^ -889283718), (object) ex);
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 1 : 1;
                    continue;
                }
              }
label_14:
              throw;
            }
        }
label_15:
        return flag;
      }

      /// <summary>Выполнить в отдельном потоке</summary>
      /// <returns>Поток</returns>
      public Thread StartThread()
      {
        Thread thread1;
        switch (1)
        {
          case 1:
            try
            {
              int num;
              if (!ThreadStarter.PrivateThreadStarter.HNNs93QClGC4h7sgBr9a())
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 4 : 5;
              else
                goto label_7;
label_3:
              Thread thread2;
              CallContextInfo callContextInfo;
              while (true)
              {
                switch (num)
                {
                  case 1:
                    thread1 = thread2;
                    num = 6;
                    continue;
                  case 2:
                    this.createdParentContextInfoUid = ThreadStarter.PrivateThreadStarter.LD9HqnQCgrjfWh12JmAq((object) callContextInfo);
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 0 : 3;
                    continue;
                  case 3:
                  case 5:
                  case 7:
                    thread2 = new Thread(new ParameterizedThreadStart(ThreadStarter.PrivateThreadStarter.InternalThread), this.MaxStackSize);
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 11 : 5;
                    continue;
                  case 4:
                  case 10:
                    ThreadStarter.PrivateThreadStarter.e6LG42QvBtTUaNCvsqKW((object) thread2, (object) this);
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 0 : 1;
                    continue;
                  case 6:
                    goto label_22;
                  case 8:
                    ThreadStarter.PrivateThreadStarter.VIxL4yQvFfIfBqjSD9TF((object) thread2, (object) (CultureInfo) ThreadStarter.PrivateThreadStarter.TenrktQCsQA9SLMak92l(ThreadStarter.PrivateThreadStarter.t6C4yUQCzZjTPQGyHvGQ((object) Thread.CurrentThread)));
                    num = 9;
                    continue;
                  case 9:
                    if (this.BeforeThreadStart == null)
                    {
                      num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 1 : 4;
                      continue;
                    }
                    goto case 12;
                  case 11:
                    ThreadStarter.PrivateThreadStarter.tjSlc8QCcRp71XbL9OtG((object) thread2, (object) (CultureInfo) ThreadStarter.PrivateThreadStarter.TenrktQCsQA9SLMak92l(ThreadStarter.PrivateThreadStarter.XF7UqWQCUKaYZXCEEpAG(ThreadStarter.PrivateThreadStarter.wVlqhcQCLbI7q9ds6rU9())));
                    num = 8;
                    continue;
                  case 12:
                    this.BeforeThreadStart(thread2);
                    num = 10;
                    continue;
                  case 13:
                    if (callContextInfo == null)
                    {
                      num = 7;
                      continue;
                    }
                    goto case 2;
                  default:
                    goto label_7;
                }
              }
label_7:
              callContextInfo = (CallContextInfo) ThreadStarter.PrivateThreadStarter.Lbics8QCY2jZqYE4ra3A(ThreadStarter.PrivateThreadStarter.h8GfXhQCry9p3IUe6Try());
              num = 13;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
              {
                num = 12;
                goto label_3;
              }
              else
                goto label_3;
            }
            catch (Exception ex)
            {
              int num = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
                num = 0;
              while (true)
              {
                switch (num)
                {
                  case 1:
                    goto label_21;
                  default:
                    ((ILogger) ThreadStarter.PrivateThreadStarter.VYwLpNQC5ZJRLcHGaE7i()).Error((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1218962250 ^ 1218613816), ex);
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 1;
                    continue;
                }
              }
label_21:
              throw;
            }
        }
label_22:
        return thread1;
      }

      /// <summary>Метод, выполняющийся в потоке</summary>
      /// <param name="state">Состояние</param>
      private static void InternalThread(object state)
      {
        int num1 = 3;
        ThreadStarter.PrivateThreadStarter privateThreadStarter;
        IDisposable disposable;
        while (true)
        {
          switch (num1)
          {
            case 1:
              disposable = (IDisposable) ThreadStarter.PrivateThreadStarter.pKDxBVQvWRCgStSj2KUp(false);
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 0 : 0;
              continue;
            case 2:
              if (privateThreadStarter != null)
              {
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 1;
                continue;
              }
              goto label_45;
            case 3:
              privateThreadStarter = state as ThreadStarter.PrivateThreadStarter;
              num1 = 2;
              continue;
            case 4:
              goto label_48;
            default:
              goto label_6;
          }
        }
label_48:
        return;
label_45:
        return;
label_6:
        try
        {
          int num2;
          if (ThreadStarter.PrivateThreadStarter.vnmxJEQvo2Q1yYe55wY2((object) privateThreadStarter) != null)
            num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 0 : 0;
          else
            goto label_10;
label_9:
          while (true)
          {
            switch (num2)
            {
              case 1:
              case 7:
              case 19:
              case 20:
                if (!ThreadStarter.PrivateThreadStarter.HNNs93QClGC4h7sgBr9a())
                {
                  num2 = 18;
                  continue;
                }
                goto case 12;
              case 2:
              case 13:
                ThreadStarter.PrivateThreadStarter.Y7tqKTQvE5U55ppuJo4k(ThreadStarter.PrivateThreadStarter.D4G9Y4QvbN3qqdDnFjAr((object) privateThreadStarter));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 20 : 3;
                continue;
              case 3:
                if (!ThreadStarter.PrivateThreadStarter.HNNs93QClGC4h7sgBr9a())
                {
                  num2 = 10;
                  continue;
                }
                goto case 15;
              case 4:
                goto label_27;
              case 5:
                ((DiagnosticsManager) ThreadStarter.PrivateThreadStarter.h8GfXhQCry9p3IUe6Try()).BackgroundThreadStart((MethodInfo) ThreadStarter.PrivateThreadStarter.xypiSGQvh2oEupPqSUwN(ThreadStarter.PrivateThreadStarter.ISZlYTQvvdmBBSm3UTiS((object) privateThreadStarter)), privateThreadStarter.createdParentContextInfoUid, (string) ThreadStarter.PrivateThreadStarter.mMVC9xQvGAk1Vst91HkY(92412609 - 1050237057 ^ -957501362));
                num2 = 4;
                continue;
              case 6:
                goto label_19;
              case 8:
              case 10:
                ThreadStarter.PrivateThreadStarter.aP2EiWQvCNLnjqDVA9Xu(ThreadStarter.PrivateThreadStarter.muJ52JQvfvmUDwyYBQ0r((object) privateThreadStarter), ThreadStarter.PrivateThreadStarter.cyPLu9QvQjRD9PLT6oxu((object) privateThreadStarter));
                num2 = 19;
                continue;
              case 9:
                goto label_10;
              case 11:
                goto label_24;
              case 12:
                ((DiagnosticsManager) ThreadStarter.PrivateThreadStarter.h8GfXhQCry9p3IUe6Try()).BackgroundThreadEnd();
                num2 = 16;
                continue;
              case 14:
                if (!ThreadStarter.PrivateThreadStarter.HNNs93QClGC4h7sgBr9a())
                {
                  num2 = 2;
                  continue;
                }
                goto case 21;
              case 15:
                ((DiagnosticsManager) ThreadStarter.PrivateThreadStarter.h8GfXhQCry9p3IUe6Try()).BackgroundThreadStart(privateThreadStarter.ParametrizedStart.Method, privateThreadStarter.createdParentContextInfoUid, (string) ThreadStarter.PrivateThreadStarter.mMVC9xQvGAk1Vst91HkY(-1204263869 ^ -1341583247 ^ 137627134));
                num2 = 8;
                continue;
              case 16:
                goto label_41;
              case 17:
                goto label_31;
              case 18:
                goto label_36;
              case 21:
                ((DiagnosticsManager) ThreadStarter.PrivateThreadStarter.h8GfXhQCry9p3IUe6Try()).BackgroundThreadStart((MethodInfo) ThreadStarter.PrivateThreadStarter.xypiSGQvh2oEupPqSUwN((object) privateThreadStarter.Start), privateThreadStarter.createdParentContextInfoUid, (string) ThreadStarter.PrivateThreadStarter.mMVC9xQvGAk1Vst91HkY(-542721635 ^ -542914497));
                num2 = 13;
                continue;
              default:
                object obj = ThreadStarter.PrivateThreadStarter.wVlqhcQCLbI7q9ds6rU9();
                CultureInfo cultureInfo1;
                ThreadStarter.PrivateThreadStarter.tjSlc8QCcRp71XbL9OtG(ThreadStarter.PrivateThreadStarter.wVlqhcQCLbI7q9ds6rU9(), (object) (cultureInfo1 = (CultureInfo) ThreadStarter.PrivateThreadStarter.vnmxJEQvo2Q1yYe55wY2((object) privateThreadStarter)));
                CultureInfo cultureInfo2 = cultureInfo1;
                ThreadStarter.PrivateThreadStarter.VIxL4yQvFfIfBqjSD9TF(obj, (object) cultureInfo2);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 9 : 7;
                continue;
            }
          }
label_41:
          return;
label_36:
          return;
label_10:
          if (ThreadStarter.PrivateThreadStarter.D4G9Y4QvbN3qqdDnFjAr((object) privateThreadStarter) != null)
          {
            num2 = 14;
            goto label_9;
          }
          else
            goto label_24;
label_19:
          if (ThreadStarter.PrivateThreadStarter.HNNs93QClGC4h7sgBr9a())
          {
            num2 = 5;
            goto label_9;
          }
          else
            goto label_27;
label_24:
          if (ThreadStarter.PrivateThreadStarter.muJ52JQvfvmUDwyYBQ0r((object) privateThreadStarter) != null)
          {
            num2 = 3;
            goto label_9;
          }
          else
            goto label_31;
label_27:
          ThreadStarter.PrivateThreadStarter.FBcg0nQv8HBQH2J2Yu5k(ThreadStarter.PrivateThreadStarter.ISZlYTQvvdmBBSm3UTiS((object) privateThreadStarter), ThreadStarter.PrivateThreadStarter.cyPLu9QvQjRD9PLT6oxu((object) privateThreadStarter));
          num2 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
          {
            num2 = 0;
            goto label_9;
          }
          else
            goto label_9;
label_31:
          if (privateThreadStarter.Callback == null)
          {
            num2 = 7;
            goto label_9;
          }
          else
            goto label_19;
        }
        catch (Exception ex)
        {
          int num3 = 2;
          while (true)
          {
            switch (num3)
            {
              case 1:
                goto label_33;
              case 2:
                if (ThreadStarter.PrivateThreadStarter.HNNs93QClGC4h7sgBr9a())
                {
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 0 : 0;
                  continue;
                }
                goto case 3;
              case 3:
                ThreadStarter.PrivateThreadStarter.eigeFTQCjqRvdBQK97Pj(ThreadStarter.PrivateThreadStarter.VYwLpNQC5ZJRLcHGaE7i(), ThreadStarter.PrivateThreadStarter.mMVC9xQvGAk1Vst91HkY(-342626196 - 1290888215 ^ -1633157525), (object) ex);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 1 : 1;
                continue;
              default:
                ((DiagnosticsManager) ThreadStarter.PrivateThreadStarter.h8GfXhQCry9p3IUe6Try()).BackgroundThreadEnd(ex);
                num3 = 3;
                continue;
            }
          }
label_33:;
        }
        finally
        {
          int num4;
          if (disposable == null)
            num4 = 2;
          else
            goto label_46;
label_44:
          switch (num4)
          {
            case 1:
              break;
            default:
          }
label_46:
          ThreadStarter.PrivateThreadStarter.myrsVWQvZwDWKUSi7RGU((object) disposable);
          num4 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
          {
            num4 = 0;
            goto label_44;
          }
          else
            goto label_44;
        }
      }

      private ThreadStart Start
      {
        get => this.\u003CStart\u003Ek__BackingField;
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
                this.\u003CStart\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 0 : 0;
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

      private ParameterizedThreadStart ParametrizedStart
      {
        get => this.\u003CParametrizedStart\u003Ek__BackingField;
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
                this.\u003CParametrizedStart\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 0 : 0;
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

      private WaitCallback Callback
      {
        get => this.\u003CCallback\u003Ek__BackingField;
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
                this.\u003CCallback\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 0;
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

      private int MaxStackSize
      {
        get => this.\u003CMaxStackSize\u003Ek__BackingField;
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
                this.\u003CMaxStackSize\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 0 : 0;
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

      private CultureInfo CurrentCulture
      {
        get => this.\u003CCurrentCulture\u003Ek__BackingField;
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
                this.\u003CCurrentCulture\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 0 : 0;
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

      private object State
      {
        get => this.\u003CState\u003Ek__BackingField;
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
                this.\u003CState\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 0 : 0;
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

      private Action<Thread> BeforeThreadStart { get; set; }

      internal static void C9yB4oQCdRpBBmw1g66a() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool iZ0CpYQCJxgi8t9PudDo() => ThreadStarter.PrivateThreadStarter.uiB9t6QCMlivvHrMg4Px == null;

      internal static ThreadStarter.PrivateThreadStarter N8msX9QC9XTN50GEPfYr() => ThreadStarter.PrivateThreadStarter.uiB9t6QCMlivvHrMg4Px;

      internal static bool HNNs93QClGC4h7sgBr9a() => DiagnosticsManager.Enabled;

      internal static object h8GfXhQCry9p3IUe6Try() => (object) DiagnosticsManager.Instance;

      internal static Guid LD9HqnQCgrjfWh12JmAq([In] object obj0) => ((CallContextInfo) obj0).Uid;

      internal static object VYwLpNQC5ZJRLcHGaE7i() => (object) Logger.Log;

      internal static void eigeFTQCjqRvdBQK97Pj([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Error(obj1, (Exception) obj2);

      internal static object Lbics8QCY2jZqYE4ra3A([In] object obj0) => (object) ((DiagnosticsManager) obj0).GetCurrentDiagnosticSession();

      internal static object wVlqhcQCLbI7q9ds6rU9() => (object) Thread.CurrentThread;

      internal static object XF7UqWQCUKaYZXCEEpAG([In] object obj0) => (object) ((Thread) obj0).CurrentUICulture;

      internal static object TenrktQCsQA9SLMak92l([In] object obj0) => ((CultureInfo) obj0).Clone();

      internal static void tjSlc8QCcRp71XbL9OtG([In] object obj0, [In] object obj1) => ((Thread) obj0).CurrentUICulture = (CultureInfo) obj1;

      internal static object t6C4yUQCzZjTPQGyHvGQ([In] object obj0) => (object) ((Thread) obj0).CurrentCulture;

      internal static void VIxL4yQvFfIfBqjSD9TF([In] object obj0, [In] object obj1) => ((Thread) obj0).CurrentCulture = (CultureInfo) obj1;

      internal static void e6LG42QvBtTUaNCvsqKW([In] object obj0, [In] object obj1) => ((Thread) obj0).Start(obj1);

      internal static object pKDxBVQvWRCgStSj2KUp(bool isolatedContext) => (object) ELMAContext.Create(isolatedContext);

      internal static object vnmxJEQvo2Q1yYe55wY2([In] object obj0) => (object) ((ThreadStarter.PrivateThreadStarter) obj0).CurrentCulture;

      internal static object D4G9Y4QvbN3qqdDnFjAr([In] object obj0) => (object) ((ThreadStarter.PrivateThreadStarter) obj0).Start;

      internal static object xypiSGQvh2oEupPqSUwN([In] object obj0) => (object) ((Delegate) obj0).Method;

      internal static object mMVC9xQvGAk1Vst91HkY(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static void Y7tqKTQvE5U55ppuJo4k([In] object obj0) => ((ThreadStart) obj0)();

      internal static object muJ52JQvfvmUDwyYBQ0r([In] object obj0) => (object) ((ThreadStarter.PrivateThreadStarter) obj0).ParametrizedStart;

      internal static object cyPLu9QvQjRD9PLT6oxu([In] object obj0) => ((ThreadStarter.PrivateThreadStarter) obj0).State;

      internal static void aP2EiWQvCNLnjqDVA9Xu([In] object obj0, [In] object obj1) => ((ParameterizedThreadStart) obj0)(obj1);

      internal static object ISZlYTQvvdmBBSm3UTiS([In] object obj0) => (object) ((ThreadStarter.PrivateThreadStarter) obj0).Callback;

      internal static void FBcg0nQv8HBQH2J2Yu5k([In] object obj0, [In] object obj1) => ((WaitCallback) obj0)(obj1);

      internal static void myrsVWQvZwDWKUSi7RGU([In] object obj0) => ((IDisposable) obj0).Dispose();
    }
  }
}
