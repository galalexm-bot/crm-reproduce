// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Events.IndexCallExecuteStartEvent
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Diagnostics.Events
{
  /// <summary>Событие, сигнализирующее о начале обращения к индексу</summary>
  public class IndexCallExecuteStartEvent : AbstractCallStartEvent<IndexCallInfo>
  {
    internal static IndexCallExecuteStartEvent EKoI19EKxbrL7mFILYbw;

    /// <summary>Ctor</summary>
    /// <param name="info">Информация о обращении к индексу</param>
    public IndexCallExecuteStartEvent(IndexCallInfo info)
    {
      IndexCallExecuteStartEvent.tZrg5REKy75MgeAvrrWk();
      // ISSUE: explicit constructor call
      base.\u002Ector(info);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="callContextInfo">Информация о текущем потоке выполнения</param>
    /// <param name="info">Информация о обращении к индексу</param>
    public IndexCallExecuteStartEvent(CallContextInfo callContextInfo, IndexCallInfo info)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(callContextInfo, info);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void tZrg5REKy75MgeAvrrWk() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool zRe9mfEK04aIqNmNe1dp() => IndexCallExecuteStartEvent.EKoI19EKxbrL7mFILYbw == null;

    internal static IndexCallExecuteStartEvent pHAKXpEKmTQnywXaLw8x() => IndexCallExecuteStartEvent.EKoI19EKxbrL7mFILYbw;
  }
}
