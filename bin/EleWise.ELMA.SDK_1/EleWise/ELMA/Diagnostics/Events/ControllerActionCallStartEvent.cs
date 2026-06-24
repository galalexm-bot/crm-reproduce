// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Events.ControllerActionCallStartEvent
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Diagnostics.Events
{
  /// <summary>
  /// Событие, сигнализирующее о начале выполнения метода контроллера
  /// </summary>
  public class ControllerActionCallStartEvent : AbstractCallStartEvent<ControllerActionCallInfo>
  {
    internal static ControllerActionCallStartEvent y9bjHeEXGKGNX95WnHUp;

    /// <summary>Ctor</summary>
    /// <param name="info">Информация о вызове метода контроллера</param>
    public ControllerActionCallStartEvent(ControllerActionCallInfo info)
    {
      ControllerActionCallStartEvent.GluDxDEXQRRkBdurdfUT();
      // ISSUE: explicit constructor call
      base.\u002Ector(info);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="callContextInfo">Информация о текущем потоке выполнения</param>
    /// <param name="info">Информация о вызове метода контроллера</param>
    public ControllerActionCallStartEvent(
      CallContextInfo callContextInfo,
      ControllerActionCallInfo info)
    {
      ControllerActionCallStartEvent.GluDxDEXQRRkBdurdfUT();
      // ISSUE: explicit constructor call
      base.\u002Ector(callContextInfo, info);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void GluDxDEXQRRkBdurdfUT() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool IMCX1TEXEeuDjEmR08ka() => ControllerActionCallStartEvent.y9bjHeEXGKGNX95WnHUp == null;

    internal static ControllerActionCallStartEvent hF9XHrEXfhyGGnuvSuFd() => ControllerActionCallStartEvent.y9bjHeEXGKGNX95WnHUp;
  }
}
