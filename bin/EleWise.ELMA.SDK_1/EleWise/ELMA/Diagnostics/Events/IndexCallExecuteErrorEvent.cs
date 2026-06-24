// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Events.IndexCallExecuteErrorEvent
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Diagnostics.Events
{
  /// <summary>
  /// Событие, сигнализирующее об ошибке в процессе обращения к индексу
  /// </summary>
  public class IndexCallExecuteErrorEvent : AbstractCallErrorEvent<IndexCallInfo>
  {
    internal static IndexCallExecuteErrorEvent qXOsGKEXjXS5e8IRVagH;

    /// <summary>Ctor</summary>
    /// <param name="info">Информация о обращении к индексу</param>
    public IndexCallExecuteErrorEvent(IndexCallInfo info)
    {
      IndexCallExecuteErrorEvent.lV2AVKEXUCfMThwJ3JTR();
      // ISSUE: explicit constructor call
      base.\u002Ector(info);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="callContextInfo">Информация о текущем потоке выполнения</param>
    /// <param name="info">Информация о обращении к индексу</param>
    public IndexCallExecuteErrorEvent(CallContextInfo callContextInfo, IndexCallInfo info)
    {
      IndexCallExecuteErrorEvent.lV2AVKEXUCfMThwJ3JTR();
      // ISSUE: explicit constructor call
      base.\u002Ector(callContextInfo, info);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="callContextInfo">Информация о текущем потоке выполнения</param>
    /// <param name="info">Информация о обращении к индексу</param>
    /// <param name="message">Сообщение</param>
    public IndexCallExecuteErrorEvent(
      CallContextInfo callContextInfo,
      IndexCallInfo info,
      string message)
    {
      IndexCallExecuteErrorEvent.lV2AVKEXUCfMThwJ3JTR();
      // ISSUE: explicit constructor call
      base.\u002Ector(callContextInfo, info, message);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void lV2AVKEXUCfMThwJ3JTR() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool L6s0gqEXYqpM6r8UZNQZ() => IndexCallExecuteErrorEvent.qXOsGKEXjXS5e8IRVagH == null;

    internal static IndexCallExecuteErrorEvent TZZ7HHEXL6tMtFdROyLk() => IndexCallExecuteErrorEvent.qXOsGKEXjXS5e8IRVagH;
  }
}
