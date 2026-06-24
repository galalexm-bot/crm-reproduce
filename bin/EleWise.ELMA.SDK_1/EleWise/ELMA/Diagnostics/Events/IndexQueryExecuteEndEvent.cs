// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Events.IndexQueryExecuteEndEvent
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Diagnostics.Events
{
  /// <summary>
  /// Событие, сигнализирующее об окончании запроса в индекс
  /// </summary>
  public class IndexQueryExecuteEndEvent : AbstractCallEndEvent<IndexQueryInfo>
  {
    internal static IndexQueryExecuteEndEvent RirOcQEXn6RLy46QJ3cg;

    /// <summary>Ctor</summary>
    /// <param name="info">Информация о запросе в индекс</param>
    public IndexQueryExecuteEndEvent(IndexQueryInfo info)
    {
      IndexQueryExecuteEndEvent.ixrencEXeR5vnJxSOmc9();
      // ISSUE: explicit constructor call
      base.\u002Ector(info);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="callContextInfo">Информация о текущем потоке выполнения</param>
    /// <param name="info">Информация о запросе в индекс</param>
    public IndexQueryExecuteEndEvent(CallContextInfo callContextInfo, IndexQueryInfo info)
    {
      IndexQueryExecuteEndEvent.ixrencEXeR5vnJxSOmc9();
      // ISSUE: explicit constructor call
      base.\u002Ector(callContextInfo, info);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="callContextInfo">Информация о текущем потоке выполнения</param>
    /// <param name="info">Информация о запросе в индекс</param>
    /// <param name="message">Сообщение</param>
    public IndexQueryExecuteEndEvent(
      CallContextInfo callContextInfo,
      IndexQueryInfo info,
      string message)
    {
      IndexQueryExecuteEndEvent.ixrencEXeR5vnJxSOmc9();
      // ISSUE: explicit constructor call
      base.\u002Ector(callContextInfo, info, message);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void ixrencEXeR5vnJxSOmc9() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool RFKqR8EXOsJGfY55K02c() => IndexQueryExecuteEndEvent.RirOcQEXn6RLy46QJ3cg == null;

    internal static IndexQueryExecuteEndEvent xrDJHoEX2pfPt3jWSfKM() => IndexQueryExecuteEndEvent.RirOcQEXn6RLy46QJ3cg;
  }
}
