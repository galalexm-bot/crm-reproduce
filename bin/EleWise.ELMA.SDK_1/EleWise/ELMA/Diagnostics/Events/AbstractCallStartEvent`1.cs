// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Events.AbstractCallStartEvent`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Extensions;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Diagnostics.Events
{
  /// <summary>Событие, сигнализирующее о начале вызова</summary>
  /// <typeparam name="T">Тип события</typeparam>
  public class AbstractCallStartEvent<T> : DiagnosticsEvent, IDiagnosticsCallInfoEvent where T : AbstractCallInfo
  {
    internal static object xeOb5tET1H1YCWKG1dOH;

    /// <summary>Ctor</summary>
    /// <param name="info">Информация о текущем вызове</param>
    public AbstractCallStartEvent(T info)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      this.\u002Ector(info.ContextInfo, info, info.Description);
    }

    /// <summary>Ctor</summary>
    /// <param name="callContextInfo">Информация о текущем потоке обработки</param>
    /// <param name="info">Информация о вызове</param>
    public AbstractCallStartEvent(CallContextInfo callContextInfo, T info)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      this.\u002Ector(callContextInfo, info, info.Description);
    }

    /// <summary>Ctor</summary>
    /// <param name="callContextInfo">Информация о текущем потоке обработки</param>
    /// <param name="info">Информация о вызове</param>
    /// <param name="message">Сообщение</param>
    public AbstractCallStartEvent(CallContextInfo callContextInfo, T info, string message)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(callContextInfo, string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1251470110 >> 2 ^ 312582853), (object) info.StartTime.ConvertUtcToLocal().ToString(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1242972401 >> 4 ^ 77950385)), (object) info.CallType, (object) info.Id, message.IsNullOrEmpty() ? (object) "" : (object) message, (object) SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2107730902), true)));
      this.Info = info;
    }

    /// <summary>Информация о вызове</summary>
    public T Info { get; private set; }

    /// <inheritdoc />
    AbstractCallInfo IDiagnosticsCallInfoEvent.Info => (AbstractCallInfo) this.Info;

    internal static bool LOvFE6ETNkgrB5BO8hGv() => AbstractCallStartEvent<T>.xeOb5tET1H1YCWKG1dOH == null;

    internal static object MlCACBET3KxvOe0TK3kq() => AbstractCallStartEvent<T>.xeOb5tET1H1YCWKG1dOH;
  }
}
