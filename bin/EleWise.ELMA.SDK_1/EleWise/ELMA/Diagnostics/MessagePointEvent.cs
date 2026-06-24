// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.MessagePointEvent
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Diagnostics
{
  public class MessagePointEvent : DiagnosticsEvent
  {
    internal static MessagePointEvent PgPRmeEF0XAeM8rtRCKk;

    public MessagePointEvent(CallContextInfo callContextInfo, string message)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(callContextInfo, message);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.TimeStamp = DateTime.UtcNow;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    internal static bool eQ4WVVEFmS8G6DlHM8rp() => MessagePointEvent.PgPRmeEF0XAeM8rtRCKk == null;

    internal static MessagePointEvent VUvCnZEFyxGmt7C9IBO8() => MessagePointEvent.PgPRmeEF0XAeM8rtRCKk;
  }
}
