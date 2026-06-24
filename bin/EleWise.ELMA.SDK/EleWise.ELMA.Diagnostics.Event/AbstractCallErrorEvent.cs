using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Diagnostics.Events;

public class AbstractCallErrorEvent<T> : DiagnosticsEvent, IDiagnosticsCallInfoEvent where T : AbstractCallInfo
{
	internal static object hfgADgETGcDLoQVO0yP4;

	public T Info { get; private set; }

	AbstractCallInfo IDiagnosticsCallInfoEvent.Info => Info;

	public AbstractCallErrorEvent(T info)
	{
		SingletonReader.JJCZtPuTvSt();
		this._002Ector(info.ContextInfo, info, info.Description);
	}

	public AbstractCallErrorEvent(CallContextInfo callContextInfo, T info)
	{
		SingletonReader.JJCZtPuTvSt();
		this._002Ector(callContextInfo, info, info.Description);
	}

	public AbstractCallErrorEvent(CallContextInfo callContextInfo, T info, string message)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(callContextInfo, SR.T(true, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x57A5235E ^ 0x57A17538), (int)info.TotalTime.TotalMilliseconds, info.CallType, info.Id, message.IsNullOrEmpty() ? "" : message, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099510839), ignoreTranslationMode: true)));
		Info = info;
		base.Level = LogLevel.Error;
		base.Exception = info.Exception;
	}

	internal static bool pTL2wSETElRRkjK0CVR3()
	{
		return hfgADgETGcDLoQVO0yP4 == null;
	}

	internal static object M5FJRnETfDrvHBHjOEw9()
	{
		return hfgADgETGcDLoQVO0yP4;
	}
}
