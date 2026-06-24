using System;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Attributes;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Models;

public class UserSecurityProfileActions : DefaultEntityActions
{
	[Uid("58e59b2b-fd5b-4f36-a2e2-d48ff5cdcaf7")]
	[DisplayName(typeof(__Resources_UserSecurityProfileActions), "P_DisallowLogon_DisplayName")]
	public const string DisallowLogon = "58e59b2b-fd5b-4f36-a2e2-d48ff5cdcaf7";

	private static Guid _disallowLogonGuid;

	[DisplayName(typeof(__Resources_UserSecurityProfileActions), "P_AllowLogon_DisplayName")]
	[Uid("2635ac67-8011-4f05-9d77-ee701271227a")]
	public const string AllowLogon = "2635ac67-8011-4f05-9d77-ee701271227a";

	private static Guid _allowLogonGuid;

	[DisplayName(typeof(__Resources_UserSecurityProfileActions), "P_SetForcedChangePassword_DisplayName")]
	[Uid("cc9044e1-4e2c-46a6-9ed7-6b42aa14daf7")]
	public const string SetForcedChangePassword = "cc9044e1-4e2c-46a6-9ed7-6b42aa14daf7";

	private static Guid _setForcedChangePasswordGuid;

	[DisplayName(typeof(__Resources_UserSecurityProfileActions), "P_ResetForcedChangePassword_DisplayName")]
	[Uid("d1ef7b26-1d49-408d-a5c4-f204fca7c132")]
	public const string ResetForcedChangePassword = "d1ef7b26-1d49-408d-a5c4-f204fca7c132";

	private static Guid _resetForcedChangePasswordGuid;

	[DisplayName(typeof(__Resources_UserSecurityProfileActions), "P_ResetCountFailedLogon_DisplayName")]
	[Uid("9b776346-d67c-4e66-93e5-4de53e6846eb")]
	public const string ResetCountFailedLogon = "9b776346-d67c-4e66-93e5-4de53e6846eb";

	private static Guid _resetCountFailedLogonGuid;

	internal static UserSecurityProfileActions vhQvsAKXMFx3peYo80s;

	public static Guid DisallowLogonGuid => _disallowLogonGuid;

	public static Guid AllowLogonGuid => _allowLogonGuid;

	public static Guid SetForcedChangePasswordGuid => _setForcedChangePasswordGuid;

	public static Guid ResetForcedChangePasswordGuid => _resetForcedChangePasswordGuid;

	public static Guid ResetCountFailedLogonGuid => _resetCountFailedLogonGuid;

	protected UserSecurityProfileActions()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1e79fb186de547eaaa37d66745fc7b90 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static UserSecurityProfileActions()
	{
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				_disallowLogonGuid = new Guid((string)BrRAXTK6gmRNtQ2JIyU(-1957236745 ^ -1957258665));
				num2 = 6;
				break;
			default:
				_resetCountFailedLogonGuid = new Guid((string)BrRAXTK6gmRNtQ2JIyU(-730071140 ^ -730101428));
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b54421a4e10b4c2fa10cef566e462fbd != 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				_setForcedChangePasswordGuid = new Guid(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-179348817 ^ -179360617));
				num2 = 5;
				break;
			case 5:
				_resetForcedChangePasswordGuid = new Guid((string)BrRAXTK6gmRNtQ2JIyU(0x74C28149 ^ 0x74C2F7CD));
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fe0eedb8ce484402a5c9a74346556b9f != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				return;
			case 4:
				AtPgMJK7bdtooTnhrDe();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_94a7beb9ab90455caa18ecaa3b17b19c == 0)
				{
					num2 = 3;
				}
				break;
			case 6:
				_allowLogonGuid = new Guid((string)BrRAXTK6gmRNtQ2JIyU(0x28EBA022 ^ 0x28EBD5CE));
				num2 = 2;
				break;
			}
		}
	}

	internal static bool ovXCs8Kn0is3yFBYA7Z()
	{
		return vhQvsAKXMFx3peYo80s == null;
	}

	internal static UserSecurityProfileActions BPWNpkKiG6kWyP0PKHv()
	{
		return vhQvsAKXMFx3peYo80s;
	}

	internal static void AtPgMJK7bdtooTnhrDe()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}

	internal static object BrRAXTK6gmRNtQ2JIyU(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}
