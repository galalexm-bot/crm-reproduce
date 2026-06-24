using System;
using System.Text.RegularExpressions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Security.Components;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security;

public static class PasswordChangeHelper
{
	private static Regex pattern;

	internal static PasswordChangeHelper JAbHGh5SOd1NC3komoX;

	static PasswordChangeHelper()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				Hv3fmP51claQHHnLNhh();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6370a8f224e7416eb3575ae34b77f5e3 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				pattern = new Regex((string)aS2eI15zlWQZ93S9thf(0x51BB29A6 ^ 0x51BB3DC4));
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6370a8f224e7416eb3575ae34b77f5e3 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static bool NeedCurrentPassword(EleWise.ELMA.Security.Models.IUser user, EleWise.ELMA.Security.Models.IUser currentUser)
	{
		//Discarded unreachable code: IL_0031, IL_0040
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				return !Locator.GetServiceNotNull<SecurityService>().HasPermission(PermissionProvider.UserManagmentPermission);
			case 1:
				return true;
			case 2:
				if (currentUser == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_31b4b139e534452696f4bfdfc16f1b03 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			default:
				if (user.Id != currentUser.Id)
				{
					num2 = 3;
					break;
				}
				goto case 1;
			}
		}
	}

	public static Pair<bool, string> ValidatePassword(EleWise.ELMA.Security.Models.IUser user, string curPassword, string newPassword, string confirmPassword)
	{
		_003C_003Ec__DisplayClass3_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass3_0();
		CS_0024_003C_003E8__locals0.user = user;
		if (!CS_0024_003C_003E8__locals0.user.IsActive())
		{
			return new Pair<bool, string>(first: false, SR.NoTrueLogin);
		}
		EleWise.ELMA.Security.Models.IUser currentUser = Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
		CS_0024_003C_003E8__locals0.error = string.Empty;
		CS_0024_003C_003E8__locals0.isAllow = true;
		if (currentUser == null)
		{
			Locator.GetServiceNotNull<ISecurityService>().RunByUser(CS_0024_003C_003E8__locals0.user, delegate
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
						CS_0024_003C_003E8__locals0.isAllow = CS_0024_003C_003E8__locals0.user.AllowChangePassword(out CS_0024_003C_003E8__locals0.error);
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_73b92e1f752f422d899693d4318e4486 != 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			});
		}
		else
		{
			CS_0024_003C_003E8__locals0.isAllow = CS_0024_003C_003E8__locals0.user.AllowChangePassword(out CS_0024_003C_003E8__locals0.error);
		}
		if (!CS_0024_003C_003E8__locals0.isAllow)
		{
			return new Pair<bool, string>(first: false, CS_0024_003C_003E8__locals0.error);
		}
		IMembershipService service = Locator.GetService<IMembershipService>();
		bool flag = NeedCurrentPassword(CS_0024_003C_003E8__locals0.user, currentUser);
		if (flag && service.ValidateUser(CS_0024_003C_003E8__locals0.user.UserName, curPassword) == null)
		{
			return new Pair<bool, string>(first: false, SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x116C2699 ^ 0x116C325D)));
		}
		if (flag && curPassword.Equals(newPassword))
		{
			return new Pair<bool, string>(first: false, SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xCDF201B ^ 0xCDF34ED)));
		}
		if (!newPassword.Equals(confirmPassword))
		{
			return new Pair<bool, string>(first: false, SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xFD0849E ^ 0xFD091D4)));
		}
		SecuritySettings settings = Locator.GetServiceNotNull<SecuritySettingsModule>().Settings;
		int passwordMinLength = settings.PasswordMinLength;
		if (newPassword.Length < passwordMinLength)
		{
			return new Pair<bool, string>(first: false, SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2104667969 ^ -2104670771), passwordMinLength));
		}
		if (settings.IsComplexPassword && !pattern.IsMatch(newPassword))
		{
			return new Pair<bool, string>(first: false, SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2E78F5A0 ^ 0x2E78E066)));
		}
		return new Pair<bool, string>(first: true, "");
	}

	public static Pair<bool, string> ChangePassword(EleWise.ELMA.Security.Models.IUser user, string curPassword, string newPassword, string confirmPassword)
	{
		Pair<bool, string> pair = ValidatePassword(user, curPassword, newPassword, confirmPassword);
		if (!pair.First)
		{
			return new Pair<bool, string>(first: false, pair.Second);
		}
		try
		{
			Locator.GetService<IMembershipService>().SetPassword(user, newPassword);
			EleWise.ELMA.Security.Models.IUser currentUser = Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
			if (currentUser == null || currentUser.Id == user.Id)
			{
				UserSecurityProfileManager.Instance.ResetForcedChangePassword(user);
			}
			return new Pair<bool, string>(first: true, "");
		}
		catch (Exception ex)
		{
			return new Pair<bool, string>(first: false, ex.Message);
		}
	}

	internal static void Hv3fmP51claQHHnLNhh()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}

	internal static object aS2eI15zlWQZ93S9thf(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool nc3wBv59SCWhaPy1XKi()
	{
		return JAbHGh5SOd1NC3komoX == null;
	}

	internal static PasswordChangeHelper qhTYCa5f5VbiBIKRsQF()
	{
		return JAbHGh5SOd1NC3komoX;
	}
}
