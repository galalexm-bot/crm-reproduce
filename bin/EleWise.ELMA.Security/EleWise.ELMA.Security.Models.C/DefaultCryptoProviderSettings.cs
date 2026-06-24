using System;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Model.Attributes;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Security.Models.Crypto;

[DisplayName(typeof(DefaultCryptoProviderSettingsSR), "DefaultCryptoProviderSettings")]
public class DefaultCryptoProviderSettings
{
	internal static DefaultCryptoProviderSettings adeqKeFtAtq0AAAwUd2;

	[DisplayName(typeof(DefaultCryptoProviderSettingsSR), "CryptoProviderUid")]
	public Guid CryptoProviderUid
	{
		[CompilerGenerated]
		get
		{
			return _003CCryptoProviderUid_003Ek__BackingField;
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
					_003CCryptoProviderUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_7fbc19cae8c8414894251bb8ae24a12e == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DisplayName(typeof(DefaultCryptoProviderSettingsSR), "DigitalSignatureTypeUid")]
	public Guid DigitalSignatureTypeUid
	{
		[CompilerGenerated]
		get
		{
			return _003CDigitalSignatureTypeUid_003Ek__BackingField;
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
					_003CDigitalSignatureTypeUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2f11eccd7e8f4339a0b03ad9fe1eb947 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public DefaultCryptoProviderSettings()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		iGlrtYFq02yYtJKnvIf();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6b49024d17a94a69b2948ac938d43b7c != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public DefaultCryptoProviderSettings(Guid providerUid)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		iGlrtYFq02yYtJKnvIf();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6e35a1cd804541a884550671c71dbb1c == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				CryptoProviderUid = providerUid;
				num = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_66aae9daa3f84bb5931ed90b4759f85c == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public DefaultCryptoProviderSettings(Guid providerUid, Guid signatureUid)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		iGlrtYFq02yYtJKnvIf();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b6bf1b70a8924e789fc4be8e9aadc953 != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 2:
				DigitalSignatureTypeUid = signatureUid;
				num = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_77bfde1a0739446782f0bda00c988550 == 0)
				{
					num = 0;
				}
				break;
			case 1:
				CryptoProviderUid = providerUid;
				num = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1c9893e65c104705bb8b228f8a38d9cd == 0)
				{
					num = 1;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static void iGlrtYFq02yYtJKnvIf()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}

	internal static bool oqip8yFhyOGuEdRqrfL()
	{
		return adeqKeFtAtq0AAAwUd2 == null;
	}

	internal static DefaultCryptoProviderSettings hPgRxoFOHk4TvonN8Q0()
	{
		return adeqKeFtAtq0AAAwUd2;
	}
}
