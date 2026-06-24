using System;
using System.Collections.Generic;
using System.Threading;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime;

public class WebStartControl : BaseStartControl
{
	private static readonly AutoResetEvent continueExecutionEvent;

	private static readonly Dictionary<StartStatus, string> statusToMessage;

	private static WebStartControl Y2Xx1tWW2TI0YlULVEmn;

	public override void Continue()
	{
		//Discarded unreachable code: IL_00d8
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				StartInformation.Root.Errors = string.Empty;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
				{
					num2 = 5;
				}
				break;
			case 3:
				return;
			default:
				throw new InvalidOperationException((string)ox4bhtWWpmh9tjBT1P3X(xUmCntWW3fSSfNlx3sfI(-1876063057 ^ -1876161551)));
			case 1:
			{
				if (!statusToMessage.TryGetValue(wQxueYWWNCx03dsmtbke(oWZlTgWW1SFUDn2XvmRI()), out var _))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 4;
			}
			case 4:
				StartInformation.Root.Status = StartStatus.Running;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
				{
					num2 = 1;
				}
				break;
			case 5:
				continueExecutionEvent.Set();
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
				{
					num2 = 3;
				}
				break;
			}
		}
	}

	public override void Suspend(StartStatus suspendReason, string suspendMessage)
	{
		int num = 3;
		int num2 = num;
		string value = default(string);
		while (true)
		{
			switch (num2)
			{
			case 5:
				return;
			case 2:
				dBN4UUWWa0mlSad6QFTw(oWZlTgWW1SFUDn2XvmRI(), suspendMessage);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				IT9vB6WWtnKwCgYGcKXx(oWZlTgWW1SFUDn2XvmRI(), suspendReason);
				num2 = 4;
				break;
			case 3:
				if (!statusToMessage.TryGetValue(suspendReason, out value))
				{
					throw new InvalidOperationException((string)ox4bhtWWpmh9tjBT1P3X(xUmCntWW3fSSfNlx3sfI(0x48A7E34A ^ 0x48A664A6)));
				}
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
				{
					num2 = 2;
				}
				break;
			case 4:
				v3nnd3WWwlOrX49YuXmn(continueExecutionEvent);
				num2 = 5;
				break;
			default:
				WpfStRWWDtkoZ1INGLnh(oWZlTgWW1SFUDn2XvmRI(), value);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public WebStartControl()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		AlNupjWW4LGgPSf6xT4h();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static WebStartControl()
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				AlNupjWW4LGgPSf6xT4h();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
				{
					num2 = 2;
				}
				continue;
			case 1:
				return;
			case 2:
				continueExecutionEvent = new AutoResetEvent(initialState: false);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
				{
					num2 = 0;
				}
				continue;
			}
			statusToMessage = new Dictionary<StartStatus, string>
			{
				{
					StartStatus.BackupNeeded,
					(string)ox4bhtWWpmh9tjBT1P3X(xUmCntWW3fSSfNlx3sfI(0x4785BC0D ^ 0x4784348F))
				},
				{
					StartStatus.NotActivated,
					(string)ox4bhtWWpmh9tjBT1P3X(xUmCntWW3fSSfNlx3sfI(-675505729 ^ -675475097))
				},
				{
					StartStatus.PrerequisitesCheckFault,
					(string)ox4bhtWWpmh9tjBT1P3X(xUmCntWW3fSSfNlx3sfI(0x31326106 ^ 0x3133E828))
				}
			};
			num2 = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
			{
				num2 = 1;
			}
		}
	}

	internal static object oWZlTgWW1SFUDn2XvmRI()
	{
		return StartInformation.Root;
	}

	internal static StartStatus wQxueYWWNCx03dsmtbke(object P_0)
	{
		return ((StartInformation)P_0).Status;
	}

	internal static object xUmCntWW3fSSfNlx3sfI(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object ox4bhtWWpmh9tjBT1P3X(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool dLAiCmWWe9bbTUiTpe1s()
	{
		return Y2Xx1tWW2TI0YlULVEmn == null;
	}

	internal static WebStartControl RLEJgwWWPyt5ItpPqtgd()
	{
		return Y2Xx1tWW2TI0YlULVEmn;
	}

	internal static void dBN4UUWWa0mlSad6QFTw(object P_0, object P_1)
	{
		((StartInformation)P_0).Errors = (string)P_1;
	}

	internal static void WpfStRWWDtkoZ1INGLnh(object P_0, object P_1)
	{
		((StartInformation)P_0).Message = (string)P_1;
	}

	internal static void IT9vB6WWtnKwCgYGcKXx(object P_0, StartStatus value)
	{
		((StartInformation)P_0).Status = value;
	}

	internal static bool v3nnd3WWwlOrX49YuXmn(object P_0)
	{
		return ((WaitHandle)P_0).WaitOne();
	}

	internal static void AlNupjWW4LGgPSf6xT4h()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
