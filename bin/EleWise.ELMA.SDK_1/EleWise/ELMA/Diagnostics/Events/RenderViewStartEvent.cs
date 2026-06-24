// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Events.RenderViewStartEvent
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Diagnostics.Events
{
  /// <summary>
  /// Событие, сигнализирующее о начале рендера представления
  /// </summary>
  public class RenderViewStartEvent : AbstractCallStartEvent<RenderViewInfo>
  {
    internal static RenderViewStartEvent ji0wgWEXABsCUUvgEMxk;

    /// <summary>Ctor</summary>
    /// <param name="info">Информация о рендере представления</param>
    public RenderViewStartEvent(RenderViewInfo info)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(info);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="callContextInfo">Информация о текущем потоке выполнения</param>
    /// <param name="info">Информация о рендере представления</param>
    public RenderViewStartEvent(CallContextInfo callContextInfo, RenderViewInfo info)
    {
      RenderViewStartEvent.dE1SEnEX0T58OMAjkbt4();
      // ISSUE: explicit constructor call
      base.\u002Ector(callContextInfo, info);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool jpTvmEEX7y4mbnSfmw80() => RenderViewStartEvent.ji0wgWEXABsCUUvgEMxk == null;

    internal static RenderViewStartEvent Y3SkuLEXxBRZdnAUWcY9() => RenderViewStartEvent.ji0wgWEXABsCUUvgEMxk;

    internal static void dE1SEnEX0T58OMAjkbt4() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
