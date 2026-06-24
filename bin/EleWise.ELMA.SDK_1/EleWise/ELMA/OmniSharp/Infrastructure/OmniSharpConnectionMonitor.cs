// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.OmniSharp.Infrastructure.OmniSharpConnectionMonitor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Logging;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace EleWise.ELMA.OmniSharp.Infrastructure
{
  /// <summary>Монитор статуса соединения с OmniSharp</summary>
  internal class OmniSharpConnectionMonitor : IConnectionMonitor, IDisposable
  {
    private System.Threading.Timer pingTimer;
    private readonly int isAliveCheckPeriod;
    private readonly ILogger logger;
    private readonly SimpleWebClient client;
    private volatile bool isOffline;
    private bool lastStatus;
    internal static OmniSharpConnectionMonitor ewO0LdWrQeRTelyv6iph;

    /// <summary>Ctor</summary>
    /// <param name="client">Простой веб-клиент, нацеленный на веб-службу OmniSharp</param>
    /// <param name="logger">Логгер</param>
    /// <param name="isAliveCheckPeriod">Период проверки соединения в секундах</param>
    public OmniSharpConnectionMonitor(
      SimpleWebClient client,
      ILogger logger,
      int isAliveCheckPeriod = 2)
    {
      OmniSharpConnectionMonitor.lP66HFWr8GkZums7qhvG();
      this.isOffline = true;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 6;
      while (true)
      {
        switch (num)
        {
          case 1:
            Contract.CheckArgument(isAliveCheckPeriod > 0, (string) OmniSharpConnectionMonitor.TgUXDEWrZI3MAffxWSTr(95909607 + 343705423 ^ 439471020));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 2;
            continue;
          case 2:
            this.logger = logger;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 0 : 0;
            continue;
          case 3:
            goto label_2;
          case 4:
            OmniSharpConnectionMonitor.Cxg4gxWru5og9uSkZZBD((object) logger, OmniSharpConnectionMonitor.TgUXDEWrZI3MAffxWSTr(--1867379187 ^ 1867498617));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 1 : 1;
            continue;
          case 5:
            this.pingTimer = new System.Threading.Timer(new TimerCallback(this.Ping), (object) null, OmniSharpConnectionMonitor.mrClaxWrIkgHVXUiiVdH((double) isAliveCheckPeriod), Timeout.InfiniteTimeSpan);
            num = 3;
            continue;
          case 6:
            OmniSharpConnectionMonitor.Cxg4gxWru5og9uSkZZBD((object) client, OmniSharpConnectionMonitor.TgUXDEWrZI3MAffxWSTr(-867826612 ^ -867946186));
            num = 4;
            continue;
          case 7:
            this.client = client;
            num = 5;
            continue;
          default:
            this.isAliveCheckPeriod = isAliveCheckPeriod;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 2 : 7;
            continue;
        }
      }
label_2:;
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
            goto label_6;
          case 1:
          case 3:
            this.pingTimer = (System.Threading.Timer) null;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 0 : 0;
            continue;
          case 2:
            System.Threading.Timer pingTimer = this.pingTimer;
            if (pingTimer == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 1 : 1;
              continue;
            }
            OmniSharpConnectionMonitor.GvtJmZWrV5vk8x9AR9Rb((object) pingTimer);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 3 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_6:
      return;
label_2:;
    }

    /// <summary>OmniSharp сейчас офлайн?</summary>
    public bool IsOffline => this.isOffline;

    private void Ping(object state)
    {
      int num1 = 4;
      while (true)
      {
        int num2 = num1;
        AsyncVoidMethodBuilder tBuilder;
        // ISSUE: variable of a compiler-generated type
        OmniSharpConnectionMonitor.\u003CPing\u003Ed__11 stateMachine;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_3;
            case 2:
              tBuilder.Start<OmniSharpConnectionMonitor.\u003CPing\u003Ed__11>(ref stateMachine);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 1 : 0;
              continue;
            case 3:
              // ISSUE: reference to a compiler-generated field
              stateMachine.\u003C\u003Et__builder = OmniSharpConnectionMonitor.luqT68WrSQLgmNZCH3o4();
              num2 = 5;
              continue;
            case 4:
              goto label_7;
            case 5:
              // ISSUE: reference to a compiler-generated field
              stateMachine.\u003C\u003E1__state = -1;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 0 : 0;
              continue;
            default:
              // ISSUE: reference to a compiler-generated field
              tBuilder = stateMachine.\u003C\u003Et__builder;
              num2 = 2;
              continue;
          }
        }
label_7:
        // ISSUE: reference to a compiler-generated field
        stateMachine.\u003C\u003E4__this = this;
        num1 = 3;
      }
label_3:;
    }

    private async Task<bool> IsAlive()
    {
      int num1 = 2;
      int num2;
      bool ghd;
      while (true)
      {
        switch (num1)
        {
          case 1:
            num1 = 3;
            continue;
          case 2:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            num2 = (^this).\u003C\u003E1__state;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 1 : 1;
            continue;
          case 3:
            try
            {
              int num3;
              if (num2 == 0)
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 2 : 3;
              else
                goto label_32;
label_5:
              string isAlive;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    goto label_32;
                  case 2:
label_6:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    ghd = OmniSharpConnectionMonitor.\u003CIsAlive\u003Ed__12.gycppXQcqHRybX1ToGhd((object) isAlive, OmniSharpConnectionMonitor.\u003CIsAlive\u003Ed__12.sasywbQciFvVWh2lwH7V(-1487388570 ^ -1487381912));
                    num3 = 5;
                    continue;
                  case 4:
                    try
                    {
                      int num4;
                      if (num2 == 0)
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 1 : 1;
                      else
                        goto label_20;
label_9:
                      TaskAwaiter<string> taskAwaiter;
                      TaskAwaiter<string> awaiter;
                      string result;
                      while (true)
                      {
                        switch (num4)
                        {
                          case 1:
                          case 6:
                            awaiter = taskAwaiter;
                            num4 = 7;
                            continue;
                          case 2:
                            // ISSUE: explicit reference operation
                            // ISSUE: reference to a compiler-generated field
                            (^this).\u003C\u003E1__state = num2 = 0;
                            num4 = 8;
                            continue;
                          case 3:
                            isAlive = result;
                            num4 = 4;
                            continue;
                          case 4:
                            goto label_6;
                          case 5:
                            goto label_37;
                          case 7:
                            taskAwaiter = new TaskAwaiter<string>();
                            num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 4 : 13;
                            continue;
                          case 8:
                            taskAwaiter = awaiter;
                            num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 6 : 10;
                            continue;
                          case 9:
                            goto label_20;
                          case 10:
                            // ISSUE: explicit reference operation
                            // ISSUE: reference to a compiler-generated field
                            (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, OmniSharpConnectionMonitor.\u003CIsAlive\u003Ed__12>(ref awaiter, this);
                            num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 0 : 5;
                            continue;
                          case 12:
                            if (awaiter.IsCompleted)
                            {
                              num4 = 11;
                              continue;
                            }
                            goto case 2;
                          case 13:
                            // ISSUE: explicit reference operation
                            // ISSUE: reference to a compiler-generated field
                            (^this).\u003C\u003E1__state = num2 = -1;
                            num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 0 : 0;
                            continue;
                          default:
                            result = awaiter.GetResult();
                            num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 1 : 3;
                            continue;
                        }
                      }
label_37:
                      return;
label_20:
                      SimpleWebClient client = this.client;
                      string endpoint = z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-397266137 ^ 396902978);
                      // ISSUE: reference to a compiler-generated field
                      Action<WebRequest> action = OmniSharpConnectionMonitor.\u003C\u003Ec.\u003C\u003E9__12_0;
                      Action<WebRequest> requestSetup;
                      if (action == null)
                      {
                        // ISSUE: reference to a compiler-generated field
                        OmniSharpConnectionMonitor.\u003C\u003Ec.\u003C\u003E9__12_0 = requestSetup = (Action<WebRequest>) (r =>
                        {
                          int num5 = 1;
                          while (true)
                          {
                            switch (num5)
                            {
                              case 0:
                                goto label_2;
                              case 1:
                                // ISSUE: reference to a compiler-generated method
                                OmniSharpConnectionMonitor.\u003C\u003Ec.goDpGYQcu6emI22ATNuX((object) r, 1000);
                                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 0;
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
                        goto label_44;
label_22:
                      awaiter = client.Get(endpoint, requestSetup).GetAwaiter();
                      num4 = 7;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
                      {
                        num4 = 12;
                        goto label_9;
                      }
                      else
                        goto label_9;
label_44:
                      requestSetup = action;
                      goto label_22;
                    }
                    catch (WebException ex)
                    {
                      int num6 = 0;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
                        num6 = 0;
                      switch (num6)
                      {
                        default:
                          goto label_6;
                      }
                    }
                    catch (Exception ex)
                    {
                      int num7 = 0;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
                        num7 = 0;
                      while (true)
                      {
                        switch (num7)
                        {
                          case 1:
                            goto label_6;
                          default:
                            // ISSUE: reference to a compiler-generated method
                            // ISSUE: reference to a compiler-generated method
                            OmniSharpConnectionMonitor.\u003CIsAlive\u003Ed__12.XspupcQcRfyEMBD7WmHV((object) this.logger, OmniSharpConnectionMonitor.\u003CIsAlive\u003Ed__12.sasywbQciFvVWh2lwH7V(-53329496 >> 4 ^ -3626332), (object) ex);
                            num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 1 : 1;
                            continue;
                        }
                      }
                    }
                  case 5:
                    goto label_41;
                  default:
                    num3 = 4;
                    continue;
                }
              }
label_32:
              isAlive = string.Empty;
              num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
              {
                num3 = 0;
                goto label_5;
              }
              else
                goto label_5;
            }
            catch (Exception ex)
            {
              int num8 = 2;
              while (true)
              {
                switch (num8)
                {
                  case 1:
                    goto label_34;
                  case 2:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = -2;
                    num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 0 : 0;
                    continue;
                  default:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.SetException(ex);
                    num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 1 : 1;
                    continue;
                }
              }
label_34:
              return;
            }
          case 4:
label_41:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003E1__state = -2;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 0 : 0;
            continue;
          case 5:
            goto label_40;
          default:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003Et__builder.SetResult(ghd);
            num1 = 5;
            continue;
        }
      }
label_40:;
    }

    internal static void lP66HFWr8GkZums7qhvG() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object TgUXDEWrZI3MAffxWSTr(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void Cxg4gxWru5og9uSkZZBD([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static TimeSpan mrClaxWrIkgHVXUiiVdH([In] double obj0) => TimeSpan.FromSeconds(obj0);

    internal static bool HU50CpWrCiyg8sDFEwqD() => OmniSharpConnectionMonitor.ewO0LdWrQeRTelyv6iph == null;

    internal static OmniSharpConnectionMonitor yEirvLWrvRo6e58AHZQf() => OmniSharpConnectionMonitor.ewO0LdWrQeRTelyv6iph;

    internal static void GvtJmZWrV5vk8x9AR9Rb([In] object obj0) => ((System.Threading.Timer) obj0).Dispose();

    internal static AsyncVoidMethodBuilder luqT68WrSQLgmNZCH3o4() => AsyncVoidMethodBuilder.Create();
  }
}
