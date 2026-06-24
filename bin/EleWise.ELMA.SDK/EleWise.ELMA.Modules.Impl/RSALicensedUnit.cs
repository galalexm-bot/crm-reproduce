using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using EleWise.ELMA.Licensing;
using EleWise.ELMA.Licensing.Impl;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Modules.Impl;

public class RSALicensedUnit : ILicensedUnit, IActivationTokenContainer
{
	private RSALicense _impl;

	internal static RSALicensedUnit Oqo2H312pGEYmWRSCZy;

	public Guid RegistrationKeyMethodUid => new Guid((string)LNqh2b11rPG4Ue9hd4l(0x3A6135BE ^ 0x3A61478A));

	public RSALicensedUnit(Guid moduleUid, string id, string version, IEnumerable<X509Certificate2> certificates, Func<DateTime?> getMainUnitExpiration)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		_impl = new RSALicense(moduleUid, id, version, certificates, getMainUnitExpiration);
	}

	public string GetRegistrationKey()
	{
		return _impl.GetRegistrationKey();
	}

	public void ApplyActivationKey(string key)
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
				WMtmMT1NT0t4vtaXfOG(_impl, key);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void CompleteLicensingInitialize()
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
				seu7P213AcS9W96JtpG(_impl);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public ILicenseInfo GetLicenseInfo()
	{
		int num = 1;
		int num2 = num;
		ComponentLicenseInfo componentLicenseInfo = default(ComponentLicenseInfo);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return null;
			case 1:
				componentLicenseInfo = (ComponentLicenseInfo)dF1vAq1pQLW8XVqxNOL(_impl);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			if (componentLicenseInfo == null)
			{
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
				{
					num2 = 1;
				}
				continue;
			}
			LicenseInfo licenseInfo = new LicenseInfo(null);
			UxAaHN1D78RxhCKCrfq(licenseInfo, ViwrUI1aHWT4ohgPva5(componentLicenseInfo));
			MyjXud1wja0Xu0m6sRo(licenseInfo, ConvertStatus(E7W3wP1tmt7yaE8fsY7(componentLicenseInfo)));
			licenseInfo.TrialExpiration = componentLicenseInfo.TrialExpiration;
			return licenseInfo;
		}
	}

	public void UpdateLicenseInfo()
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
				Es7Zlu149xSTcJVkbTa(_impl);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public byte[] GetActivationToken()
	{
		return (byte[])bsqLhU16CE7G2EPdoib(_impl);
	}

	ActivationToken IActivationTokenContainer.GetActivationToken()
	{
		int num = 2;
		int num2 = num;
		byte[] activationTokenV = default(byte[]);
		while (true)
		{
			switch (num2)
			{
			case 2:
				activationTokenV = _impl.GetActivationTokenV2();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				if (activationTokenV == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return new ActivationToken
				{
					Token = activationTokenV
				};
			default:
				return null;
			}
		}
	}

	private LicenseStatus ConvertStatus(ComponentLicenseStatus status)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (status != 0)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
					{
						num2 = 0;
					}
					break;
				}
				return LicenseStatus.Activated;
			case 3:
				return LicenseStatus.NotActivated;
			default:
				if (status == ComponentLicenseStatus.NeedRestart)
				{
					return LicenseStatus.NeedRestart;
				}
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
				{
					num2 = 3;
				}
				break;
			case 1:
				if (status == ComponentLicenseStatus.DateExpired)
				{
					return LicenseStatus.DateExpired;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object LNqh2b11rPG4Ue9hd4l(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool dFgKIU1e7LRQ2Hb9s07()
	{
		return Oqo2H312pGEYmWRSCZy == null;
	}

	internal static RSALicensedUnit rTkSNk1Phb0uZVARsak()
	{
		return Oqo2H312pGEYmWRSCZy;
	}

	internal static void WMtmMT1NT0t4vtaXfOG(object P_0, object P_1)
	{
		((RSALicense)P_0).ApplyActivationKey((string)P_1);
	}

	internal static void seu7P213AcS9W96JtpG(object P_0)
	{
		((RSALicense)P_0).CompleteLicensingInitialize();
	}

	internal static object dF1vAq1pQLW8XVqxNOL(object P_0)
	{
		return ((RSALicense)P_0).GetLicenseInfo();
	}

	internal static byte ViwrUI1aHWT4ohgPva5(object P_0)
	{
		return ((ComponentLicenseInfo)P_0).LicenseType;
	}

	internal static void UxAaHN1D78RxhCKCrfq(object P_0, byte value)
	{
		((LicenseInfo)P_0).LicenseType = value;
	}

	internal static ComponentLicenseStatus E7W3wP1tmt7yaE8fsY7(object P_0)
	{
		return ((ComponentLicenseInfo)P_0).Status;
	}

	internal static void MyjXud1wja0Xu0m6sRo(object P_0, LicenseStatus value)
	{
		((LicenseInfo)P_0).Status = value;
	}

	internal static void Es7Zlu149xSTcJVkbTa(object P_0)
	{
		((RSALicense)P_0).UpdateLicenseInfo();
	}

	internal static object bsqLhU16CE7G2EPdoib(object P_0)
	{
		return ((RSALicense)P_0).GetActivationToken();
	}
}
