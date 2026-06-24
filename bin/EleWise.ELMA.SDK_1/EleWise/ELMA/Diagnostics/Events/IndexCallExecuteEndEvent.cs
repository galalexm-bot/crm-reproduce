// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Events.IndexCallExecuteEndEvent
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Diagnostics.Events
{
  /// <summary>
  /// Событие, сигнализирующее об окончании обращения к индексу
  /// </summary>
  public class IndexCallExecuteEndEvent : AbstractCallEndEvent<IndexCallInfo>
  {
    internal static IndexCallExecuteEndEvent H1do6XEXmS29Z2Iej3Hs;

    /// <summary>Ctor</summary>
    /// <param name="info">Информация о обращении к индексу</param>
    public IndexCallExecuteEndEvent(IndexCallInfo info)
    {
      IndexCallExecuteEndEvent.mGXrGsEXJqpr6csLxpJV();
      // ISSUE: explicit constructor call
      base.\u002Ector(info);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="callContextInfo">Информация о текущем потоке выполнения</param>
    /// <param name="info">Информация о обращении к индексу</param>
    public IndexCallExecuteEndEvent(CallContextInfo callContextInfo, IndexCallInfo info)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(callContextInfo, info);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="callContextInfo">Информация о текущем потоке выполнения</param>
    /// <param name="info">Информация о обращении к индексу</param>
    /// <param name="message">Сообщение</param>
    public IndexCallExecuteEndEvent(
      CallContextInfo callContextInfo,
      IndexCallInfo info,
      string message)
    {
      IndexCallExecuteEndEvent.mGXrGsEXJqpr6csLxpJV();
      // ISSUE: explicit constructor call
      base.\u002Ector(callContextInfo, info, message);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void mGXrGsEXJqpr6csLxpJV() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool ByxCYYEXy2jrj4MyWa45() => IndexCallExecuteEndEvent.H1do6XEXmS29Z2Iej3Hs == null;

    internal static IndexCallExecuteEndEvent Apex2YEXM0fU9WBby8nd() => IndexCallExecuteEndEvent.H1do6XEXmS29Z2Iej3Hs;
  }
}
