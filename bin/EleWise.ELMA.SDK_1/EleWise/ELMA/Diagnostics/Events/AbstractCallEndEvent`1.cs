// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Events.AbstractCallEndEvent`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Extensions;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Diagnostics.Events
{
  /// <summary>Событие, сигнализирующее об окончании вызова</summary>
  /// <typeparam name="T">Тип вызова</typeparam>
  public class AbstractCallEndEvent<T> : DiagnosticsEvent, IDiagnosticsCallInfoEvent where T : AbstractCallInfo
  {
    internal static object OtY49aETo3oAPY5tDeEW;

    /// <summary>Ctor</summary>
    /// <param name="info">Информация о текущем вызове</param>
    public AbstractCallEndEvent(T info)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      this.\u002Ector(info.ContextInfo, info, info.Description);
    }

    /// <summary>Ctor</summary>
    /// <param name="callContextInfo">Информация о текущем потоке обработки</param>
    /// <param name="info">Информация о вызове</param>
    public AbstractCallEndEvent(CallContextInfo callContextInfo, T info)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      this.\u002Ector(callContextInfo, info, info.Description);
    }

    /// <summary>Ctor</summary>
    /// <param name="callContextInfo">Информация о текущем потоке обработки</param>
    /// <param name="info">Информация о вызове</param>
    /// <param name="message">Сообщение</param>
    public AbstractCallEndEvent(CallContextInfo callContextInfo, T info, string message)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(callContextInfo, SR.T(true, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1470440286 ^ 1470199096), (object) (int) info.TotalTime.TotalMilliseconds, (object) info.CallType, (object) info.Id, message.IsNullOrEmpty() ? (object) "" : (object) message, (object) SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1426456882 ^ 2009939514 ^ -583585290), true)));
      this.Info = info;
    }

    /// <summary>Информация о вызове</summary>
    public T Info { get; private set; }

    /// <inheritdoc />
    AbstractCallInfo IDiagnosticsCallInfoEvent.Info => (AbstractCallInfo) this.Info;

    internal static bool FDXcnsETbcAsXXpQGGRR() => AbstractCallEndEvent<T>.OtY49aETo3oAPY5tDeEW == null;

    internal static object RUZxyrETh9nyYF7Bjmtj() => AbstractCallEndEvent<T>.OtY49aETo3oAPY5tDeEW;
  }
}
