// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Events.MethodCallStartEvent
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Diagnostics.Events
{
  /// <summary>Событие, сигнализирующее о начале выполнения метода</summary>
  public class MethodCallStartEvent : AbstractCallStartEvent<MethodCallInfo>
  {
    internal static MethodCallStartEvent l3Z8PtET7nSpmML0O5F1;

    /// <summary>Ctor</summary>
    /// <param name="info">Информация о вызове функции</param>
    public MethodCallStartEvent(MethodCallInfo info)
    {
      MethodCallStartEvent.iXZNmwETma3ehaG5mFPT();
      // ISSUE: explicit constructor call
      base.\u002Ector(info);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (MethodCallStartEvent.FIg07ZETy5vKHdpPUXqQ((object) info).Length == 0)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 2 : 3;
              continue;
            }
            goto case 4;
          case 2:
            goto label_10;
          case 3:
            goto label_9;
          case 4:
            this.Message = (string) MethodCallStartEvent.CQFEKNETdrLPle6MVaRe((object) this.Message, MethodCallStartEvent.vHTRqRETJVyTnCkR5Ng3(MethodCallStartEvent.KRrT7gETMSS9cg6IuqFh(95909607 + 343705423 ^ 439854706), true), MethodCallStartEvent.e0RuF5ET9WBj8WWvs3sW(MethodCallStartEvent.KRrT7gETMSS9cg6IuqFh(-1146510045 ^ -1146509023), MethodCallStartEvent.FIg07ZETy5vKHdpPUXqQ((object) info)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 2 : 2;
            continue;
          case 5:
            goto label_3;
          default:
            if (info.Arguments == null)
            {
              num = 5;
              continue;
            }
            goto case 1;
        }
      }
label_10:
      return;
label_9:
      return;
label_3:;
    }

    /// <summary>Ctor</summary>
    /// <param name="callContextInfo">Информация о текущем потоке выполнения</param>
    /// <param name="info">Информация о вызове функции</param>
    public MethodCallStartEvent(CallContextInfo callContextInfo, MethodCallInfo info)
    {
      MethodCallStartEvent.iXZNmwETma3ehaG5mFPT();
      // ISSUE: explicit constructor call
      base.\u002Ector(callContextInfo, info);
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            if (MethodCallStartEvent.FIg07ZETy5vKHdpPUXqQ((object) info) != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 0;
              continue;
            }
            goto label_9;
          case 3:
            this.Message = this.Message + SR.T((string) MethodCallStartEvent.KRrT7gETMSS9cg6IuqFh(-1876063057 ^ -1876306709), true) + (string) MethodCallStartEvent.e0RuF5ET9WBj8WWvs3sW(MethodCallStartEvent.KRrT7gETMSS9cg6IuqFh(~210725948 ^ -210722879), MethodCallStartEvent.FIg07ZETy5vKHdpPUXqQ((object) info));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 1 : 0;
            continue;
          default:
            if (MethodCallStartEvent.FIg07ZETy5vKHdpPUXqQ((object) info).Length != 0)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 3;
              continue;
            }
            goto label_8;
        }
      }
label_2:
      return;
label_8:
      return;
label_9:;
    }

    internal static void iXZNmwETma3ehaG5mFPT() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object FIg07ZETy5vKHdpPUXqQ([In] object obj0) => (object) ((MethodCallInfo) obj0).Arguments;

    internal static object KRrT7gETMSS9cg6IuqFh(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object vHTRqRETJVyTnCkR5Ng3([In] object obj0, bool ignoreTranslationMode) => (object) SR.T((string) obj0, ignoreTranslationMode);

    internal static object e0RuF5ET9WBj8WWvs3sW([In] object obj0, [In] object obj1) => (object) string.Join((string) obj0, (object[]) obj1);

    internal static object CQFEKNETdrLPle6MVaRe([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);

    internal static bool YXflAhETxfRhp0D99U93() => MethodCallStartEvent.l3Z8PtET7nSpmML0O5F1 == null;

    internal static MethodCallStartEvent Q8AyaEET02fBw5GBU5XA() => MethodCallStartEvent.l3Z8PtET7nSpmML0O5F1;
  }
}
