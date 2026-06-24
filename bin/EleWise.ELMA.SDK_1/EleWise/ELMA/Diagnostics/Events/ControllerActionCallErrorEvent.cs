// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Events.ControllerActionCallErrorEvent
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Diagnostics.Events
{
  /// <summary>
  /// Событие, сигнализирующее об ошибке во время выполнения метода контроллера
  /// </summary>
  public class ControllerActionCallErrorEvent : AbstractCallErrorEvent<ControllerActionCallInfo>
  {
    internal static ControllerActionCallErrorEvent aBjPS0EXBw2ymEJdsBUM;

    /// <summary>Ctor</summary>
    /// <param name="info">Информация о вызове метода контроллера</param>
    public ControllerActionCallErrorEvent(ControllerActionCallInfo info)
    {
      ControllerActionCallErrorEvent.gOBwE1EXb9oyInE9fCjX();
      // ISSUE: explicit constructor call
      this.\u002Ector((CallContextInfo) ControllerActionCallErrorEvent.Pb3SBEEXhYDvqxliRFMO((object) info), info);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="callContextInfo">Информация о текущем потоке выполнения</param>
    /// <param name="info">Информация о вызове метода контроллера</param>
    public ControllerActionCallErrorEvent(
      CallContextInfo callContextInfo,
      ControllerActionCallInfo info)
    {
      ControllerActionCallErrorEvent.gOBwE1EXb9oyInE9fCjX();
      // ISSUE: explicit constructor call
      base.\u002Ector(callContextInfo, info);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void gOBwE1EXb9oyInE9fCjX() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object Pb3SBEEXhYDvqxliRFMO([In] object obj0) => (object) ((AbstractCallInfo) obj0).ContextInfo;

    internal static bool dyWsrmEXWgrQwttN9aKs() => ControllerActionCallErrorEvent.aBjPS0EXBw2ymEJdsBUM == null;

    internal static ControllerActionCallErrorEvent FXBai0EXoZTfC8K0tbv5() => ControllerActionCallErrorEvent.aBjPS0EXBw2ymEJdsBUM;
  }
}
