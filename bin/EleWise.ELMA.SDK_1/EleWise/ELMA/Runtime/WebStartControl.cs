// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.WebStartControl
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;

namespace EleWise.ELMA.Runtime
{
  /// <summary>Центр управления запуском веб-сервера ELMA</summary>
  public class WebStartControl : BaseStartControl
  {
    private static readonly AutoResetEvent continueExecutionEvent;
    private static readonly Dictionary<StartStatus, string> statusToMessage;
    private static WebStartControl Y2Xx1tWW2TI0YlULVEmn;

    /// <summary>Продолжить запуск сервера</summary>
    public override void Continue()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!WebStartControl.statusToMessage.TryGetValue(WebStartControl.wQxueYWWNCx03dsmtbke(WebStartControl.oWZlTgWW1SFUDn2XvmRI()), out string _))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 0 : 0;
              continue;
            }
            goto case 4;
          case 2:
            StartInformation.Root.Errors = string.Empty;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 3 : 5;
            continue;
          case 3:
            goto label_7;
          case 4:
            StartInformation.Root.Status = StartStatus.Running;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 2 : 1;
            continue;
          case 5:
            WebStartControl.continueExecutionEvent.Set();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 3 : 3;
            continue;
          default:
            goto label_3;
        }
      }
label_7:
      return;
label_3:
      throw new InvalidOperationException((string) WebStartControl.ox4bhtWWpmh9tjBT1P3X(WebStartControl.xUmCntWW3fSSfNlx3sfI(-1876063057 ^ -1876161551)));
    }

    /// <summary>Приостановить запуск сервера</summary>
    /// <param name="suspendReason">Код причины приостановки запуска сервера</param>
    /// <param name="suspendMessage">Сообщение, поясняющее причину приостановки</param>
    public override void Suspend(StartStatus suspendReason, string suspendMessage)
    {
      int num = 3;
      string str;
      while (true)
      {
        switch (num)
        {
          case 1:
            WebStartControl.IT9vB6WWtnKwCgYGcKXx(WebStartControl.oWZlTgWW1SFUDn2XvmRI(), suspendReason);
            num = 4;
            continue;
          case 2:
            WebStartControl.dBN4UUWWa0mlSad6QFTw(WebStartControl.oWZlTgWW1SFUDn2XvmRI(), (object) suspendMessage);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 0 : 0;
            continue;
          case 3:
            if (WebStartControl.statusToMessage.TryGetValue(suspendReason, out str))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 2 : 2;
              continue;
            }
            goto label_3;
          case 4:
            WebStartControl.v3nnd3WWwlOrX49YuXmn((object) WebStartControl.continueExecutionEvent);
            num = 5;
            continue;
          case 5:
            goto label_2;
          default:
            WebStartControl.WpfStRWWDtkoZ1INGLnh(WebStartControl.oWZlTgWW1SFUDn2XvmRI(), (object) str);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 1 : 0;
            continue;
        }
      }
label_2:
      return;
label_3:
      throw new InvalidOperationException((string) WebStartControl.ox4bhtWWpmh9tjBT1P3X(WebStartControl.xUmCntWW3fSSfNlx3sfI(1218962250 ^ 1218864294)));
    }

    public WebStartControl()
    {
      WebStartControl.AlNupjWW4LGgPSf6xT4h();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static WebStartControl()
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            WebStartControl.continueExecutionEvent = new AutoResetEvent(false);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 0 : 0;
            continue;
          case 3:
            WebStartControl.AlNupjWW4LGgPSf6xT4h();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 2 : 2;
            continue;
          default:
            WebStartControl.statusToMessage = new Dictionary<StartStatus, string>()
            {
              {
                StartStatus.BackupNeeded,
                (string) WebStartControl.ox4bhtWWpmh9tjBT1P3X(WebStartControl.xUmCntWW3fSSfNlx3sfI(1199946765 ^ 1199846543))
              },
              {
                StartStatus.NotActivated,
                (string) WebStartControl.ox4bhtWWpmh9tjBT1P3X(WebStartControl.xUmCntWW3fSSfNlx3sfI(-675505729 ^ -675475097))
              },
              {
                StartStatus.PrerequisitesCheckFault,
                (string) WebStartControl.ox4bhtWWpmh9tjBT1P3X(WebStartControl.xUmCntWW3fSSfNlx3sfI(825385222 ^ 825485352))
              }
            };
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 1 : 1;
            continue;
        }
      }
label_2:;
    }

    internal static object oWZlTgWW1SFUDn2XvmRI() => (object) StartInformation.Root;

    internal static StartStatus wQxueYWWNCx03dsmtbke([In] object obj0) => ((StartInformation) obj0).Status;

    internal static object xUmCntWW3fSSfNlx3sfI(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object ox4bhtWWpmh9tjBT1P3X([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool dLAiCmWWe9bbTUiTpe1s() => WebStartControl.Y2Xx1tWW2TI0YlULVEmn == null;

    internal static WebStartControl RLEJgwWWPyt5ItpPqtgd() => WebStartControl.Y2Xx1tWW2TI0YlULVEmn;

    internal static void dBN4UUWWa0mlSad6QFTw([In] object obj0, [In] object obj1) => ((StartInformation) obj0).Errors = (string) obj1;

    internal static void WpfStRWWDtkoZ1INGLnh([In] object obj0, [In] object obj1) => ((StartInformation) obj0).Message = (string) obj1;

    internal static void IT9vB6WWtnKwCgYGcKXx([In] object obj0, StartStatus value) => ((StartInformation) obj0).Status = value;

    internal static bool v3nnd3WWwlOrX49YuXmn([In] object obj0) => ((WaitHandle) obj0).WaitOne();

    internal static void AlNupjWW4LGgPSf6xT4h() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
