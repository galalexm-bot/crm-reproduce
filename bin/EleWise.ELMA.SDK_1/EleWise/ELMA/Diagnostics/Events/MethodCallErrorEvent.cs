// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Events.MethodCallErrorEvent
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Diagnostics.Events
{
  /// <summary>
  /// Событие, сигнализирующее об ошибке в процессе выполнения метода
  /// </summary>
  public class MethodCallErrorEvent : AbstractCallErrorEvent<MethodCallInfo>
  {
    internal static MethodCallErrorEvent ScB3icET4OAT8o48JZcQ;

    /// <summary>Ctor</summary>
    /// <param name="info">Информация о вызове метода</param>
    public MethodCallErrorEvent(MethodCallInfo info)
    {
      MethodCallErrorEvent.AM7aM1ETAeig60SXoeqT();
      // ISSUE: explicit constructor call
      this.\u002Ector(info.ContextInfo, info);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="callContextInfo">Информация о текущем потоке выполнения</param>
    /// <param name="info">Информация о вызове метода</param>
    public MethodCallErrorEvent(CallContextInfo callContextInfo, MethodCallInfo info)
    {
      MethodCallErrorEvent.AM7aM1ETAeig60SXoeqT();
      // ISSUE: explicit constructor call
      base.\u002Ector(callContextInfo, info);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void AM7aM1ETAeig60SXoeqT() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool qN4uBRET6sWLrZ0PmaDO() => MethodCallErrorEvent.ScB3icET4OAT8o48JZcQ == null;

    internal static MethodCallErrorEvent Vby8iOETHjiWupkqjfga() => MethodCallErrorEvent.ScB3icET4OAT8o48JZcQ;
  }
}
