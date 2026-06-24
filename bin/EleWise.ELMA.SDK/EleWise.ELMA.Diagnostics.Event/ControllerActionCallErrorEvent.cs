using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Diagnostics.Events;

public class ControllerActionCallErrorEvent : AbstractCallErrorEvent<ControllerActionCallInfo>
{
	internal static ControllerActionCallErrorEvent aBjPS0EXBw2ymEJdsBUM;

	public ControllerActionCallErrorEvent(ControllerActionCallInfo info)
	{
		//Discarded unreachable code: IL_0031, IL_0036
		gOBwE1EXb9oyInE9fCjX();
		this._002Ector((CallContextInfo)Pb3SBEEXhYDvqxliRFMO(info), info);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public ControllerActionCallErrorEvent(CallContextInfo callContextInfo, ControllerActionCallInfo info)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		gOBwE1EXb9oyInE9fCjX();
		base._002Ector(callContextInfo, info);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void gOBwE1EXb9oyInE9fCjX()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object Pb3SBEEXhYDvqxliRFMO(object P_0)
	{
		return ((AbstractCallInfo)P_0).ContextInfo;
	}

	internal static bool dyWsrmEXWgrQwttN9aKs()
	{
		return aBjPS0EXBw2ymEJdsBUM == null;
	}

	internal static ControllerActionCallErrorEvent FXBai0EXoZTfC8K0tbv5()
	{
		return aBjPS0EXBw2ymEJdsBUM;
	}
}
