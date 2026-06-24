// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Events.ControllerActionCallEndEvent
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Diagnostics.Events
{
  /// <summary>
  /// Событие, сигнализирующее об окончании выполнения метода контроллера
  /// </summary>
  public class ControllerActionCallEndEvent : AbstractCallEndEvent<ControllerActionCallInfo>
  {
    internal static ControllerActionCallEndEvent HtXgkiEKUYclC7QpGX88;

    /// <summary>Ctor</summary>
    /// <param name="info">Информация о вызове метода контроллера</param>
    public ControllerActionCallEndEvent(ControllerActionCallInfo info)
    {
      ControllerActionCallEndEvent.kMYteZEKzS6fWtiEGuGd();
      // ISSUE: explicit constructor call
      this.\u002Ector((CallContextInfo) ControllerActionCallEndEvent.D2Iq0kEXF5Xhesiy2jYa((object) info), info);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="callContextInfo">Информация о текущем потоке выполнения</param>
    /// <param name="info">Информация о вызове метода контроллера</param>
    public ControllerActionCallEndEvent(
      CallContextInfo callContextInfo,
      ControllerActionCallInfo info)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(callContextInfo, info);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void kMYteZEKzS6fWtiEGuGd() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object D2Iq0kEXF5Xhesiy2jYa([In] object obj0) => (object) ((AbstractCallInfo) obj0).ContextInfo;

    internal static bool LX6hKLEKsYC6moeO1EoR() => ControllerActionCallEndEvent.HtXgkiEKUYclC7QpGX88 == null;

    internal static ControllerActionCallEndEvent KCXdiREKcdlKOgALBvqT() => ControllerActionCallEndEvent.HtXgkiEKUYclC7QpGX88;
  }
}
