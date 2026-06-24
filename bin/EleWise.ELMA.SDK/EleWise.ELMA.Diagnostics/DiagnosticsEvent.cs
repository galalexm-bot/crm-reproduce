using System;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Logging;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Diagnostics;

public abstract class DiagnosticsEvent
{
	private static DiagnosticsEvent Mx8GI6EWNUimnUAPyEpR;

	public long CallContextInfoId
	{
		[CompilerGenerated]
		get
		{
			return _003CCallContextInfoId_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
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
					_003CCallContextInfoId_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
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

	public LogLevel Level
	{
		[CompilerGenerated]
		get
		{
			return _003CLevel_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
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
					_003CLevel_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
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

	public DateTime TimeStamp
	{
		[CompilerGenerated]
		get
		{
			return _003CTimeStamp_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
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
					_003CTimeStamp_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
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

	public CallContextInfo CallContextInfo
	{
		[CompilerGenerated]
		get
		{
			return _003CCallContextInfo_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
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
					_003CCallContextInfo_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
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

	public string Message
	{
		[CompilerGenerated]
		get
		{
			return _003CMessage_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
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
					_003CMessage_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
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

	public Exception Exception
	{
		[CompilerGenerated]
		get
		{
			return _003CException_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
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
					_003CException_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	protected DiagnosticsEvent(CallContextInfo callContextInfo)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		RgULxAEWa08CKBjn7ApT();
		base._002Ector();
		int num = 2;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
		{
			num = 4;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			case 2:
				throw new ArgumentNullException((string)tgee1GEWDlWsFHpAiLAZ(-1767720453 ^ -1767468129));
			case 5:
				Exception = (Exception)MnKJlEEWwBNaYm8KBU69(callContextInfo);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
				{
					num = 1;
				}
				break;
			case 3:
				CallContextInfo = callContextInfo;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
				{
					num = 0;
				}
				break;
			default:
				Level = LogLevel.Debug;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
				{
					num = 5;
				}
				break;
			case 4:
				if (callContextInfo != null)
				{
					CallContextInfoId = LVouAgEWtwTgQeDvq9Ea(callContextInfo);
					num = 3;
				}
				else
				{
					num = 2;
				}
				break;
			}
		}
	}

	protected DiagnosticsEvent(CallContextInfo callContextInfo, string message)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		RgULxAEWa08CKBjn7ApT();
		this._002Ector(callContextInfo);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			Message = message;
			num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
			{
				num = 1;
			}
		}
	}

	internal static void RgULxAEWa08CKBjn7ApT()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object tgee1GEWDlWsFHpAiLAZ(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static long LVouAgEWtwTgQeDvq9Ea(object P_0)
	{
		return ((CallContextInfo)P_0).Id;
	}

	internal static object MnKJlEEWwBNaYm8KBU69(object P_0)
	{
		return ((CallContextInfo)P_0).Exception;
	}

	internal static bool xHFvtEEW3CpKdwIiXvQt()
	{
		return Mx8GI6EWNUimnUAPyEpR == null;
	}

	internal static DiagnosticsEvent EW0WLGEWpO4NFAN98vVA()
	{
		return Mx8GI6EWNUimnUAPyEpR;
	}
}
