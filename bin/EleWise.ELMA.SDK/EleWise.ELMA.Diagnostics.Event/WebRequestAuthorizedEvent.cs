using System.Runtime.CompilerServices;
using System.Web;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Security;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Diagnostics.Events;

public class WebRequestAuthorizedEvent : DiagnosticsEvent
{
	internal static WebRequestAuthorizedEvent vK4SCIETloeT35TDgg6M;

	public HttpContext Context
	{
		[CompilerGenerated]
		get
		{
			return _003CContext_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					_003CContext_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public IUser User
	{
		[CompilerGenerated]
		get
		{
			return _003CUser_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					_003CUser_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public WebRequestAuthorizedEvent(CallContextInfo callContextInfo, HttpContext context, IUser user)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		mgE54FET5VWq9fs005j9();
		base._002Ector(callContextInfo);
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				return;
			case 4:
				base.Level = LogLevel.Information;
				num = 3;
				break;
			case 1:
				Context = context;
				num = 4;
				break;
			case 3:
				User = user;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
				{
					num = 0;
				}
				break;
			default:
				base.Message = SR.T(true, (string)oGTZOnETjeZQfjMsny5A(0xE1229CF ^ 0xE1671BD), M3Di37ETYc26FmKndTRX(user));
				num = 2;
				break;
			}
		}
	}

	internal static void mgE54FET5VWq9fs005j9()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object oGTZOnETjeZQfjMsny5A(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object M3Di37ETYc26FmKndTRX(object P_0)
	{
		return ((IIdentified)P_0).GetId();
	}

	internal static bool FmK19TETrwB5UE4BuuCE()
	{
		return vK4SCIETloeT35TDgg6M == null;
	}

	internal static WebRequestAuthorizedEvent r7VOcLETgh7FJGOKiVJR()
	{
		return vK4SCIETloeT35TDgg6M;
	}
}
