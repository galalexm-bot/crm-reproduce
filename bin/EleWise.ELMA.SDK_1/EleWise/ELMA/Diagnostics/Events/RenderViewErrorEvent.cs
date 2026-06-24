// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Events.RenderViewErrorEvent
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Diagnostics.Events
{
  /// <summary>
  /// Событие, сигнализирующее об ошибке в процессе рендера представления
  /// </summary>
  public class RenderViewErrorEvent : AbstractCallErrorEvent<RenderViewInfo>
  {
    private static RenderViewErrorEvent cTALcpEXw3LM3aUNYdVJ;

    /// <summary>Ctor</summary>
    /// <param name="info">Информация о рендере представления</param>
    public RenderViewErrorEvent(RenderViewInfo info)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(info);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="callContextInfo">Информация о текущем потоке выполнения</param>
    /// <param name="info">Информация о рендере представления</param>
    public RenderViewErrorEvent(CallContextInfo callContextInfo, RenderViewInfo info)
    {
      RenderViewErrorEvent.cqeDfQEXHqWoWmtXLdJC();
      // ISSUE: explicit constructor call
      base.\u002Ector(callContextInfo, info);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool YEM7MMEX4c8YTYOHi47d() => RenderViewErrorEvent.cTALcpEXw3LM3aUNYdVJ == null;

    internal static RenderViewErrorEvent WY4u27EX6WOckyy3Qfxa() => RenderViewErrorEvent.cTALcpEXw3LM3aUNYdVJ;

    internal static void cqeDfQEXHqWoWmtXLdJC() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
