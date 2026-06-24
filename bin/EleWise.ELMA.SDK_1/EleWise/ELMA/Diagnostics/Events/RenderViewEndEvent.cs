// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Events.RenderViewEndEvent
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Diagnostics.Events
{
  /// <summary>
  /// Событие, сигнализирующее об окончании рендера представления
  /// </summary>
  public class RenderViewEndEvent : AbstractCallEndEvent<RenderViewInfo>
  {
    private static RenderViewEndEvent W2sQ7MEXptetHfHVxK0b;

    /// <summary>Ctor</summary>
    /// <param name="info">Информация о рендере представления</param>
    public RenderViewEndEvent(RenderViewInfo info)
    {
      RenderViewEndEvent.AKkfwnEXtYXqy9cxFTyM();
      // ISSUE: explicit constructor call
      base.\u002Ector(info);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="callContextInfo">Информация о текущем потоке выполнения</param>
    /// <param name="info">Информация о рендере представления</param>
    public RenderViewEndEvent(CallContextInfo callContextInfo, RenderViewInfo info)
    {
      RenderViewEndEvent.AKkfwnEXtYXqy9cxFTyM();
      // ISSUE: explicit constructor call
      base.\u002Ector(callContextInfo, info);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void AKkfwnEXtYXqy9cxFTyM() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool sPq5EEEXagasZ6JpJmbi() => RenderViewEndEvent.W2sQ7MEXptetHfHVxK0b == null;

    internal static RenderViewEndEvent E3xs0CEXD8KRKGPIeyAF() => RenderViewEndEvent.W2sQ7MEXptetHfHVxK0b;
  }
}
