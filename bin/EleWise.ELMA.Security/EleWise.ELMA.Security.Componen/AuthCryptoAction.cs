using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Extensions;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Components;

[Component]
public class AuthCryptoAction : ICertificateCryptoAction, ICryptoAction
{
	public const string UID_S = "AE3F60E4-2D0A-437D-AAE3-3E1F7F1E35D6";

	public static Guid UID;

	internal static AuthCryptoAction sChDpi90Asr2UlPsLPr;

	public IAuthenticationService AuthenticationService
	{
		[CompilerGenerated]
		get
		{
			return _003CAuthenticationService_003Ek__BackingField;
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
					_003CAuthenticationService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e2203cd019614c439eaf162fdd0eb05d == 0)
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

	public TrustedDeviceService TrustedDeviceService
	{
		[CompilerGenerated]
		get
		{
			return _003CTrustedDeviceService_003Ek__BackingField;
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
					_003CTrustedDeviceService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_01fd90314ba945f0a4ee79d2372961e2 == 0)
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

	public UserPublicKeyTokenManager UserPublicKeyTokenManager
	{
		[CompilerGenerated]
		get
		{
			return _003CUserPublicKeyTokenManager_003Ek__BackingField;
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
					_003CUserPublicKeyTokenManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_73b92e1f752f422d899693d4318e4486 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public UserCertificateManager UserCertificateManager
	{
		[CompilerGenerated]
		get
		{
			return _003CUserCertificateManager_003Ek__BackingField;
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
					_003CUserCertificateManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a9bad31b2eb24bb9b571e9b822d133bf != 0)
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

	public AuthCryptoProviderService AuthCryptoProviderService
	{
		[CompilerGenerated]
		get
		{
			return _003CAuthCryptoProviderService_003Ek__BackingField;
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
					_003CAuthCryptoProviderService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_615d1cac86f847c090f528929d6310c2 != 0)
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

	protected SecuritySettingsModule Module => Locator.GetServiceNotNull<SecuritySettingsModule>();

	protected ISecurityService SecurityService => Locator.GetServiceNotNull<ISecurityService>();

	public ICryptoProviderServiceBase CryptoService => AuthCryptoProviderService;

	public bool SupportOnlyDefaultCertificate => mPhQjF9MPkUiZ3rsq2A(Module.Settings);

	public bool SupportOtherDevices => true;

	public Guid ActionUid => UID;

	public string Description => SR.T((string)LtBV2B9sWTD7G9L27Ry(--553267277 ^ 0x20FB3E4B));

	public bool HasPermission(EleWise.ELMA.Security.Models.IUser user)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			string msg;
			switch (num2)
			{
			case 1:
				msg = null;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_56bc39e908f44451b3cdd0d68828e324 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return HasPermission(user, out msg);
			}
		}
	}

	public bool HasPermission(EleWise.ELMA.Security.Models.IUser user, out string msg)
	{
		//Discarded unreachable code: IL_00b5, IL_0118
		int num = 10;
		int num2 = num;
		IUser user2 = default(IUser);
		bool flag = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 2:
				msg = (string)rJrDip94vMhWwRgsEnn(LtBV2B9sWTD7G9L27Ry(-95913524 ^ -95848570));
				num2 = 12;
				break;
			case 6:
				msg = (string)rJrDip94vMhWwRgsEnn(LtBV2B9sWTD7G9L27Ry(0x6AA79E0 ^ 0x6AAF14E));
				num2 = 14;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a33ec05b36714591b0adf150b655c9a8 == 0)
				{
					num2 = 1;
				}
				break;
			case 13:
				return true;
			case 1:
				return false;
			case 7:
				msg = (string)rJrDip94vMhWwRgsEnn(LtBV2B9sWTD7G9L27Ry(-225736894 ^ -225801904));
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6f96338790994363b52cd5c55eb1342f == 0)
				{
					num2 = 0;
				}
				break;
			case 10:
				user2 = (IUser)LhHL549YpfqNAfwjXWl(AuthenticationService);
				num2 = 9;
				break;
			case 4:
				if (flag)
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_bed74a20bc6648fab6800acd64e4559d == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 6;
			case 14:
				return false;
			default:
				if (user2 == user)
				{
					num2 = 11;
					break;
				}
				goto IL_00c3;
			case 11:
				if (!flag)
				{
					num2 = 5;
					break;
				}
				goto IL_00c3;
			case 5:
				if (MMvyM69VgvRXgk7L2cX(Module.Settings))
				{
					num2 = 7;
					break;
				}
				goto IL_00c3;
			case 9:
				flag = RF2BrF9IXTwnM3n3SNM(SecurityService, user2, PermissionProvider.UserManagmentPermission);
				num2 = 7;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a53a06d0e4134332947f6164df41fb0f == 0)
				{
					num2 = 8;
				}
				break;
			case 8:
				if (user2 != user)
				{
					num2 = 4;
					break;
				}
				goto default;
			case 12:
				return false;
			case 3:
				{
					msg = null;
					num2 = 13;
					break;
				}
				IL_00c3:
				if (SecurityService.HasPermission(PermissionProvider.TrustedDevicesManagementPermission))
				{
					num2 = 3;
					break;
				}
				goto case 2;
			}
		}
	}

	public bool CanRegisterCertificate(out string msg)
	{
		//Discarded unreachable code: IL_0087
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				return true;
			default:
				return false;
			case 3:
				msg = null;
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8dab57df677749fba2d5364cf752799f == 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				msg = (string)rJrDip94vMhWwRgsEnn(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2119527672 ^ -2119459396));
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d689f5970f6345a7af332e1f7092123f == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				if (XQNnju9QtCS8sucYkJf(Module.Settings))
				{
					num2 = 3;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d133bac4622e4b5596f3c44ee791169d == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	public bool CanUnregisterCertificate(IUserCertificate cert, out string msg)
	{
		//Discarded unreachable code: IL_004d, IL_00a9, IL_010a, IL_0114
		int num = 3;
		bool flag = default(bool);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num3;
				switch (num2)
				{
				case 10:
					if (!UserPublicKeyTokenManager.Exists((IUser)Pd02sV9d8u87l1hkego(cert)))
					{
						num2 = 9;
						break;
					}
					goto case 1;
				default:
					return false;
				case 2:
					if (!TrustedDeviceService.TrustedLogonEnabled())
					{
						num2 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8176869ecaf44a0b8819db51e9ec5eb4 == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto case 8;
				case 7:
					msg = (string)rJrDip94vMhWwRgsEnn(LtBV2B9sWTD7G9L27Ry(-1076846736 ^ -1076784700));
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_06e91bc1320c425bb120c2fac8d1e3be == 0)
					{
						num2 = 0;
					}
					break;
				case 9:
					num3 = ((DKPRZs9g9bjaJC45i31(UserCertificateManager, Pd02sV9d8u87l1hkego(cert), ActionUid) > 1) ? 1 : 0);
					goto IL_016b;
				case 3:
					if (XQNnju9QtCS8sucYkJf(Module.Settings))
					{
						goto end_IL_0012;
					}
					goto case 7;
				case 4:
					return flag;
				case 8:
					if (qFcrFY9T4WS1w0THUwR(TrustedDeviceService.GetDevices((IUser)Pd02sV9d8u87l1hkego(cert))) > 0)
					{
						num2 = 5;
						break;
					}
					goto case 10;
				case 1:
				case 5:
					num3 = 1;
					goto IL_016b;
				case 6:
					{
						msg = (string)(flag ? null : rJrDip94vMhWwRgsEnn(LtBV2B9sWTD7G9L27Ry(0x61EAE816 ^ 0x61EA519C)));
						num2 = 4;
						break;
					}
					IL_016b:
					flag = (byte)num3 != 0;
					num2 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_562220c988b04dea969b2dc6cde52015 != 0)
					{
						num2 = 6;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 2;
		}
	}

	public void EnableTrusted(EleWise.ELMA.Security.Models.IUser user, bool enabled)
	{
		//Discarded unreachable code: IL_0081, IL_00d2, IL_00e1, IL_0121, IL_0130
		int num = 2;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					if (UserCertificateManager.Exists(user, ActionUid))
					{
						num2 = 8;
						continue;
					}
					throw new Exception((string)rJrDip94vMhWwRgsEnn(LtBV2B9sWTD7G9L27Ry(0xD946FDB ^ 0xD95612B)));
				case 4:
					return;
				case 2:
					if (!enabled)
					{
						num2 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f0c2bdf066b1416088266cd84d9c3be2 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 5;
				case 5:
					if (TrustedDeviceService.GetDevices(user).Any())
					{
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0a82cc1379bc48bbb836c94da8cb8564 != 0)
						{
							num2 = 6;
						}
						continue;
					}
					goto case 7;
				case 7:
					if (UserPublicKeyTokenManager.Exists(user))
					{
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8dab57df677749fba2d5364cf752799f == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 3;
				}
				break;
			}
			TrustedDeviceService.SetTrustedLogon(user, enabled);
			num = 4;
		}
	}

	public AuthCryptoAction()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c08b0b4e9ab14bedb2a2c7a0048ab814 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static AuthCryptoAction()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				UID = new Guid((string)LtBV2B9sWTD7G9L27Ry(0x397B0322 ^ 0x397A0C1E));
				num2 = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c78060c4cac8419092e4610bf7a03750 == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				YYodwR98sRliTHRJbSU();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5c3c41b36b4846e0b1701d4e56408883 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			}
		}
	}

	internal static bool CQ8d6L9E0N2BC9D4pfX()
	{
		return sChDpi90Asr2UlPsLPr == null;
	}

	internal static AuthCryptoAction J8wPHK9DgO60Y3XIf6q()
	{
		return sChDpi90Asr2UlPsLPr;
	}

	internal static bool mPhQjF9MPkUiZ3rsq2A(object P_0)
	{
		return ((SecuritySettings)P_0).AllowLoginOnlyByDefaultCertificate;
	}

	internal static object LtBV2B9sWTD7G9L27Ry(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object LhHL549YpfqNAfwjXWl(object P_0)
	{
		return ((IAuthenticationService)P_0).GetCurrentUser();
	}

	internal static bool RF2BrF9IXTwnM3n3SNM(object P_0, object P_1, object P_2)
	{
		return ((ISecurityService)P_0).HasPermission((IUser)P_1, (Permission)P_2);
	}

	internal static object rJrDip94vMhWwRgsEnn(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool MMvyM69VgvRXgk7L2cX(object P_0)
	{
		return ((SecuritySettings)P_0).DenyEditSecurityUserProfile;
	}

	internal static bool XQNnju9QtCS8sucYkJf(object P_0)
	{
		return ((SecuritySettings)P_0).AllowLoginByCertificate;
	}

	internal static object Pd02sV9d8u87l1hkego(object P_0)
	{
		return ((IUserCertificate)P_0).User;
	}

	internal static int qFcrFY9T4WS1w0THUwR(object P_0)
	{
		return ((List<DeviceToken>)P_0).Count;
	}

	internal static long DKPRZs9g9bjaJC45i31(object P_0, object P_1, Guid cryptoActionUid)
	{
		return ((UserCertificateManager)P_0).Count((IUser)P_1, cryptoActionUid);
	}

	internal static void YYodwR98sRliTHRJbSU()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}
}
