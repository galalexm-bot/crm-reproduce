using EleWise.ELMA.Extensions;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Diagnostics.Events;

public class AbstractCallEndEvent<T> : DiagnosticsEvent, IDiagnosticsCallInfoEvent where T : AbstractCallInfo
{
	internal static object OtY49aETo3oAPY5tDeEW;

	public T Info { get; private set; }

	AbstractCallInfo IDiagnosticsCallInfoEvent.Info => Info;

	public AbstractCallEndEvent(T info)
	{
		SingletonReader.JJCZtPuTvSt();
		this._002Ector(info.ContextInfo, info, info.Description);
	}

	public AbstractCallEndEvent(CallContextInfo callContextInfo, T info)
	{
		SingletonReader.JJCZtPuTvSt();
		this._002Ector(callContextInfo, info, info.Description);
	}

	public AbstractCallEndEvent(CallContextInfo callContextInfo, T info, string message)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(callContextInfo, SR.T(true, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x57A5235E ^ 0x57A17538), (int)info.TotalTime.TotalMilliseconds, info.CallType, info.Id, message.IsNullOrEmpty() ? "" : message, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-583745292 ^ -583585290), ignoreTranslationMode: true)));
		Info = info;
	}

	internal static bool FDXcnsETbcAsXXpQGGRR()
	{
		return OtY49aETo3oAPY5tDeEW == null;
	}

	internal static object RUZxyrETh9nyYF7Bjmtj()
	{
		return OtY49aETo3oAPY5tDeEW;
	}
}
