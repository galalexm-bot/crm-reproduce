// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Events.AbstractCallErrorEvent`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Diagnostics.Events
{
  /// <summary>Событие, сигнализирующее об ошибке во время вызова</summary>
  /// <typeparam name="T">Тип вызова</typeparam>
  public class AbstractCallErrorEvent<T> : DiagnosticsEvent, IDiagnosticsCallInfoEvent where T : AbstractCallInfo
  {
    internal static object hfgADgETGcDLoQVO0yP4;

    /// <summary>Ctor</summary>
    /// <param name="info">Информация о текущем вызове</param>
    public AbstractCallErrorEvent(T info)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      this.\u002Ector(info.ContextInfo, info, info.Description);
    }

    /// <summary>Ctor</summary>
    /// <param name="callContextInfo">Информация о текущем потоке обработки</param>
    /// <param name="info">Информация о вызове</param>
    public AbstractCallErrorEvent(CallContextInfo callContextInfo, T info)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      this.\u002Ector(callContextInfo, info, info.Description);
    }

    /// <summary>Ctor</summary>
    /// <param name="callContextInfo">Информация о текщем потоке обработки</param>
    /// <param name="info">Информация о вызове</param>
    /// <param name="message">Сообщение</param>
    public AbstractCallErrorEvent(CallContextInfo callContextInfo, T info, string message)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(callContextInfo, SR.T(true, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1470440286 ^ 1470199096), (object) (int) info.TotalTime.TotalMilliseconds, (object) info.CallType, (object) info.Id, message.IsNullOrEmpty() ? (object) "" : (object) message, (object) SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099510839), true)));
      this.Info = info;
      this.Level = LogLevel.Error;
      this.Exception = info.Exception;
    }

    /// <summary>Информация о вызове</summary>
    public T Info { get; private set; }

    /// <inheritdoc />
    AbstractCallInfo IDiagnosticsCallInfoEvent.Info => (AbstractCallInfo) this.Info;

    internal static bool pTL2wSETElRRkjK0CVR3() => AbstractCallErrorEvent<T>.hfgADgETGcDLoQVO0yP4 == null;

    internal static object M5FJRnETfDrvHBHjOEw9() => AbstractCallErrorEvent<T>.hfgADgETGcDLoQVO0yP4;
  }
}
