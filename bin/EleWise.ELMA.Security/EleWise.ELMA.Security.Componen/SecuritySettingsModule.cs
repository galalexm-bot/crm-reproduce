using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Runtime.Settings;
using EleWise.ELMA.Security.Extensions;
using EleWise.ELMA.Security.Models.Crypto;
using EleWise.ELMA.Security.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Components;

[Component]
public class SecuritySettingsModule : GlobalSettingsModuleBase<SecuritySettings>
{
	public const string UID_S = "488050EC-3057-41DC-A7A5-29B01590DA68";

	private static SecuritySettingsModule F6XY1lzEtDuhn40YVvs;

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

	public override string ModuleNamespace => (string)TsQJK8zsvcARhrmPMkA(-1687496463 ^ -1687501415);

	public override Guid ModuleGuid => new Guid((string)TsQJK8zsvcARhrmPMkA(0x22A54A05 ^ 0x22A449B9));

	public override string ModuleName => SR.T((string)TsQJK8zsvcARhrmPMkA(0x9D1442B ^ 0x9D17283));

	public override void SaveSettings()
	{
		//Discarded unreachable code: IL_00b8, IL_017e, IL_01cf, IL_01de
		int num = 7;
		IEnumerable<IDigitalSignatureType> digitalSignatureTypesByProviderUid = default(IEnumerable<IDigitalSignatureType>);
		Guid guid = default(Guid);
		_003C_003Ec__DisplayClass11_0 _003C_003Ec__DisplayClass11_ = default(_003C_003Ec__DisplayClass11_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 2:
					if (QrCF7izYGkUIWiXPNhq(Settings) == null)
					{
						num2 = 14;
						break;
					}
					goto case 11;
				case 10:
					throw new Exception((string)blS7PDz40U8ItfQZVDr(TsQJK8zsvcARhrmPMkA(0x65F93013 ^ 0x65F81277)));
				case 9:
				case 12:
					m16DoPzVNpSowBUOkTx(this);
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_488725796a2e487f95c022f5056d8a88 != 0)
					{
						num2 = 0;
					}
					break;
				case 3:
				case 14:
					digitalSignatureTypesByProviderUid = AuthCryptoProviderService.GetDigitalSignatureTypesByProviderUid(guid);
					num2 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a9bad31b2eb24bb9b571e9b822d133bf == 0)
					{
						num2 = 13;
					}
					break;
				case 0:
					return;
				case 13:
					if (!GOwlxczIT25578rNjtd(guid, Guid.Empty))
					{
						num2 = 4;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_01fd90314ba945f0a4ee79d2372961e2 != 0)
						{
							num2 = 12;
						}
						break;
					}
					goto case 5;
				case 11:
					guid = ((DefaultCryptoProviderSettings)QrCF7izYGkUIWiXPNhq(Settings)).CryptoProviderUid;
					num2 = 4;
					break;
				case 8:
					if (Settings != null)
					{
						num2 = 2;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c78060c4cac8419092e4610bf7a03750 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 3;
				case 4:
					_003C_003Ec__DisplayClass11_.digitalSignatureTypeUid = ((DefaultCryptoProviderSettings)QrCF7izYGkUIWiXPNhq(Settings)).DigitalSignatureTypeUid;
					num2 = 3;
					break;
				case 6:
					guid = Guid.Empty;
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fc5e0189a7f447a7b93cd505b96d5f05 != 0)
					{
						num2 = 1;
					}
					break;
				case 7:
					_003C_003Ec__DisplayClass11_ = new _003C_003Ec__DisplayClass11_0();
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6c7be8ec8b6749dcb0601e062f5515fa == 0)
					{
						num2 = 6;
					}
					break;
				case 1:
					_003C_003Ec__DisplayClass11_.digitalSignatureTypeUid = Guid.Empty;
					num2 = 8;
					break;
				case 5:
					if (digitalSignatureTypesByProviderUid.Any(_003C_003Ec__DisplayClass11_._003CSaveSettings_003Eb__0))
					{
						goto end_IL_0012;
					}
					goto case 10;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 9;
		}
	}

	public SecuritySettingsModule()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		wpVh2rzQhiTSJPuKvdq();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c537c1b3b4be444086af51f6e9112d23 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool w9xdyozDK9DgXkpDcUB()
	{
		return F6XY1lzEtDuhn40YVvs == null;
	}

	internal static SecuritySettingsModule Nm6PBxzMaXcxyEtUW2A()
	{
		return F6XY1lzEtDuhn40YVvs;
	}

	internal static object TsQJK8zsvcARhrmPMkA(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object QrCF7izYGkUIWiXPNhq(object P_0)
	{
		return ((SecuritySettings)P_0).DefaultAuthCryptoProviderSettings;
	}

	internal static bool GOwlxczIT25578rNjtd(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static object blS7PDz40U8ItfQZVDr(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static void m16DoPzVNpSowBUOkTx(object P_0)
	{
		((GlobalSettingsModuleBase<SecuritySettings>)P_0).SaveSettings();
	}

	internal static void wpVh2rzQhiTSJPuKvdq()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}
}
