using System;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Components;
using EleWise.ELMA.Security.Extensions;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Models.Crypto;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Security.Services;

[Service]
public class AuthCryptoProviderService : CryptoProviderServiceBase<IAuthCryptoProvider>
{
	internal static AuthCryptoProviderService ixyftswJ0oh19XhlLQq;

	public SecuritySettingsModule Module => Locator.GetServiceNotNull<SecuritySettingsModule>();

	public UserCryptoProfileManager UserCryptoProfileManager
	{
		[CompilerGenerated]
		get
		{
			return _003CUserCryptoProfileManager_003Ek__BackingField;
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
					_003CUserCryptoProfileManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6b49024d17a94a69b2948ac938d43b7c != 0)
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

	public override IAuthCryptoProvider DefaultProvider
	{
		get
		{
			int num = 3;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (G7xEcHwOHMh6SRh30Wb(Module.Settings) == null)
					{
						num2 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_3c78e0d08cb4410a900ca26e4b83108c == 0)
						{
							num2 = 1;
						}
						continue;
					}
					return GetProviderByUid(DTCV5Dwq1HnJ9D84w4k(G7xEcHwOHMh6SRh30Wb(Module.Settings)));
				case 3:
					if (Module != null)
					{
						num2 = 2;
						continue;
					}
					break;
				case 2:
					if (Module.Settings != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5c5fc9a9dec4418fa9513347a116bf27 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				case 1:
					break;
				}
				break;
			}
			return null;
		}
	}

	public override IDigitalSignatureType DefaultDigitalSignatureType
	{
		get
		{
			//Discarded unreachable code: IL_007d, IL_008c
			int num = 5;
			int num2 = num;
			DefaultCryptoProviderSettings defaultCryptoProviderSettings = default(DefaultCryptoProviderSettings);
			while (true)
			{
				switch (num2)
				{
				case 5:
					if (Module != null)
					{
						num2 = 4;
						break;
					}
					goto case 1;
				case 4:
					if (Module.Settings == null)
					{
						num2 = 2;
						break;
					}
					goto default;
				case 3:
					return (IDigitalSignatureType)zEbncKwFjmP5KsFrnWc(this, DTCV5Dwq1HnJ9D84w4k(defaultCryptoProviderSettings), GXNxQrwEsfdMo0Noa2A(defaultCryptoProviderSettings));
				default:
					if (G7xEcHwOHMh6SRh30Wb(Module.Settings) == null)
					{
						num2 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a1d876260ca946cdbdcbec4b9517d613 == 0)
						{
							num2 = 1;
						}
					}
					else
					{
						defaultCryptoProviderSettings = (DefaultCryptoProviderSettings)G7xEcHwOHMh6SRh30Wb(Module.Settings);
						num2 = 3;
					}
					break;
				case 1:
				case 2:
					return null;
				}
			}
		}
	}

	public override IAuthCryptoProvider GetUserProvider(EleWise.ELMA.Security.Models.IUser user, bool onlyProfile)
	{
		//Discarded unreachable code: IL_0039, IL_0048
		int num = 5;
		int num2 = num;
		IAuthCryptoProvider providerByUid = default(IAuthCryptoProvider);
		IAuthCryptoProvider authCryptoProvider;
		Guid providerUid = default(Guid);
		while (true)
		{
			switch (num2)
			{
			default:
				return providerByUid;
			case 3:
				authCryptoProvider = providerByUid;
				if (authCryptoProvider == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f791092a54884ca2ab7376df2d89215c == 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			case 4:
				providerByUid = GetProviderByUid(providerUid);
				num2 = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a1a646659a464f3fa5c9aedc64725d72 == 0)
				{
					num2 = 2;
				}
				continue;
			case 2:
				if (!onlyProfile)
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_dffee0180fb244db9738339fa28792b4 == 0)
					{
						num2 = 3;
					}
					continue;
				}
				goto default;
			case 5:
				providerUid = X1IAE3whugCl7FX0KJY(UserCryptoProfileManager, user);
				num2 = 4;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5c3c41b36b4846e0b1701d4e56408883 != 0)
				{
					num2 = 0;
				}
				continue;
			case 1:
				authCryptoProvider = DefaultProvider;
				break;
			}
			break;
		}
		return authCryptoProvider;
	}

	public override IDigitalSignatureType GetUserDigitalSignatureType(EleWise.ELMA.Security.Models.IUser user, bool onlyProfile)
	{
		//Discarded unreachable code: IL_0070
		int num = 3;
		IDigitalSignatureType digitalSignatureType = default(IDigitalSignatureType);
		IAuthCryptoProvider userProvider = default(IAuthCryptoProvider);
		Guid guid = default(Guid);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				default:
					digitalSignatureType = (IDigitalSignatureType)zEbncKwFjmP5KsFrnWc(this, kjibnOwGO2euZxpEFhd(userProvider), guid);
					num2 = 6;
					continue;
				case 6:
					if (onlyProfile)
					{
						goto end_IL_0012;
					}
					obj = digitalSignatureType;
					if (obj != null)
					{
						break;
					}
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_3c78e0d08cb4410a900ca26e4b83108c != 0)
					{
						num2 = 1;
					}
					continue;
				case 3:
					userProvider = GetUserProvider(user, onlyProfile: false);
					num2 = 2;
					continue;
				case 2:
					if (userProvider != null)
					{
						num2 = 7;
						continue;
					}
					goto case 5;
				case 5:
					return null;
				case 7:
					guid = MWpn47wcIIR9o4VpF4m(UserCryptoProfileManager, user);
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0d00d0d8fcd5481b8bdc09ec82b1ea36 != 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
					return digitalSignatureType;
				case 1:
					obj = PAGdWjw0Djl8Cj7oALY(this);
					break;
				}
				return (IDigitalSignatureType)obj;
				continue;
				end_IL_0012:
				break;
			}
			num = 4;
		}
	}

	public AuthCryptoProviderService()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1bc92e0376794fc182b6e366eee82dbd != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool g5F8KAwKAV22XoIa8V2()
	{
		return ixyftswJ0oh19XhlLQq == null;
	}

	internal static AuthCryptoProviderService qv0CibwtdW3E758Tql3()
	{
		return ixyftswJ0oh19XhlLQq;
	}

	internal static Guid X1IAE3whugCl7FX0KJY(object P_0, object P_1)
	{
		return ((UserCryptoProfileManager)P_0).GetUserAuthCryptoProviderUid((EleWise.ELMA.Security.Models.IUser)P_1);
	}

	internal static object G7xEcHwOHMh6SRh30Wb(object P_0)
	{
		return ((SecuritySettings)P_0).DefaultAuthCryptoProviderSettings;
	}

	internal static Guid DTCV5Dwq1HnJ9D84w4k(object P_0)
	{
		return ((DefaultCryptoProviderSettings)P_0).CryptoProviderUid;
	}

	internal static Guid MWpn47wcIIR9o4VpF4m(object P_0, object P_1)
	{
		return ((UserCryptoProfileManager)P_0).GetUserAuthDigitalSignatureTypeUid((EleWise.ELMA.Security.Models.IUser)P_1);
	}

	internal static Guid kjibnOwGO2euZxpEFhd(object P_0)
	{
		return ((ICryptoProviderBase)P_0).ProviderUid;
	}

	internal static object zEbncKwFjmP5KsFrnWc(object P_0, Guid P_1, Guid P_2)
	{
		return ((CryptoProviderServiceBase<IAuthCryptoProvider>)P_0).GetDigitalSignatureType(P_1, P_2);
	}

	internal static object PAGdWjw0Djl8Cj7oALY(object P_0)
	{
		return ((CryptoProviderServiceBase<IAuthCryptoProvider>)P_0).DefaultDigitalSignatureType;
	}

	internal static Guid GXNxQrwEsfdMo0Noa2A(object P_0)
	{
		return ((DefaultCryptoProviderSettings)P_0).DigitalSignatureTypeUid;
	}
}
