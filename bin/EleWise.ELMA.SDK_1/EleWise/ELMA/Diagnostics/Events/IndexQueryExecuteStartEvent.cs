// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Events.IndexQueryExecuteStartEvent
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Diagnostics.Events
{
  /// <summary>Событие, сигнализирующее о начале запроса в индекс</summary>
  public class IndexQueryExecuteStartEvent : AbstractCallStartEvent<IndexQueryInfo>
  {
    private static IndexQueryExecuteStartEvent e9xj9qEKM1CHX9dLpYSE;

    /// <summary>Ctor</summary>
    /// <param name="info">Информация о запросе в индекс</param>
    public IndexQueryExecuteStartEvent(IndexQueryInfo info)
    {
      IndexQueryExecuteStartEvent.MfXObIEKdRNEuXe4Bwqt();
      // ISSUE: explicit constructor call
      base.\u002Ector(info);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="callContextInfo">Информация о текущем потоке выполнения</param>
    /// <param name="info">Информация о запросе в индекс</param>
    public IndexQueryExecuteStartEvent(CallContextInfo callContextInfo, IndexQueryInfo info)
    {
      IndexQueryExecuteStartEvent.MfXObIEKdRNEuXe4Bwqt();
      // ISSUE: explicit constructor call
      base.\u002Ector(callContextInfo, info);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void MfXObIEKdRNEuXe4Bwqt() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool HhyQCnEKJGMhxwxrGYdw() => IndexQueryExecuteStartEvent.e9xj9qEKM1CHX9dLpYSE == null;

    internal static IndexQueryExecuteStartEvent cgDo0REK9knNnUgLseTE() => IndexQueryExecuteStartEvent.e9xj9qEKM1CHX9dLpYSE;
  }
}
