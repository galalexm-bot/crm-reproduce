// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Events.IndexQueryExecuteErrorEvent
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Diagnostics.Events
{
  /// <summary>
  /// Событие, сигнализирующее об ошибке в процессе запроса в индекс
  /// </summary>
  public class IndexQueryExecuteErrorEvent : AbstractCallErrorEvent<IndexQueryInfo>
  {
    private static IndexQueryExecuteErrorEvent uaA08JEXPvJ7VB5UHOZh;

    /// <summary>Ctor</summary>
    /// <param name="info">Информация о запросе в индекс</param>
    public IndexQueryExecuteErrorEvent(IndexQueryInfo info)
    {
      IndexQueryExecuteErrorEvent.XQuYCjEX3omeuvDutwmH();
      // ISSUE: explicit constructor call
      base.\u002Ector(info);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="callContextInfo">Информация о текущем потоке выполнения</param>
    /// <param name="info">Информация и запросе в индекс</param>
    public IndexQueryExecuteErrorEvent(CallContextInfo callContextInfo, IndexQueryInfo info)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(callContextInfo, info);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="callContextInfo">Информация о текущем потоке выполнения</param>
    /// <param name="info">Информация о запросе в индекс</param>
    /// <param name="message">Сообщение</param>
    public IndexQueryExecuteErrorEvent(
      CallContextInfo callContextInfo,
      IndexQueryInfo info,
      string message)
    {
      IndexQueryExecuteErrorEvent.XQuYCjEX3omeuvDutwmH();
      // ISSUE: explicit constructor call
      base.\u002Ector(callContextInfo, info, message);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void XQuYCjEX3omeuvDutwmH() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool GQ7kYGEX1Ks7Z4reuCo1() => IndexQueryExecuteErrorEvent.uaA08JEXPvJ7VB5UHOZh == null;

    internal static IndexQueryExecuteErrorEvent rbk1BxEXNI1CI3njLVmF() => IndexQueryExecuteErrorEvent.uaA08JEXPvJ7VB5UHOZh;
  }
}
