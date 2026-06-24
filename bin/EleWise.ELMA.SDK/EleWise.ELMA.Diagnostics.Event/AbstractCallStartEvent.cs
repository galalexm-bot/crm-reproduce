using EleWise.ELMA.Extensions;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Diagnostics.Events;

public class AbstractCallStartEvent<T> : DiagnosticsEvent, IDiagnosticsCallInfoEvent where T : AbstractCallInfo
{
	internal static object xeOb5tET1H1YCWKG1dOH;

	public T Info { get; private set; }

	AbstractCallInfo IDiagnosticsCallInfoEvent.Info => Info;

	public AbstractCallStartEvent(T info)
	{
		SingletonReader.JJCZtPuTvSt();
		this._002Ector(info.ContextInfo, info, info.Description);
	}

	public AbstractCallStartEvent(CallContextInfo callContextInfo, T info)
	{
		SingletonReader.JJCZtPuTvSt();
		this._002Ector(callContextInfo, info, info.Description);
	}

	public AbstractCallStartEvent(CallContextInfo callContextInfo, T info, string message)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(callContextInfo, string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12A5FAC7 ^ 0x12A1A2C5), info.StartTime.ConvertUtcToLocal().ToString(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4A1640F ^ 0x4A56DB1)), info.CallType, info.Id, message.IsNullOrEmpty() ? "" : message, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2107730902), ignoreTranslationMode: true)));
		Info = info;
	}

	internal static bool LOvFE6ETNkgrB5BO8hGv()
	{
		return xeOb5tET1H1YCWKG1dOH == null;
	}

	internal static object MlCACBET3KxvOe0TK3kq()
	{
		return xeOb5tET1H1YCWKG1dOH;
	}
}
