using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.FullTextSearch.ExtensionPoints;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Runtime.Settings;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.FullTextSearch;

public class FullTextSearchSettings : GlobalSettingsBase
{
	internal static FullTextSearchSettings GhmSP6GQb7OHOhTTbL0I;

	[DisplayName(typeof(FullTextSearchSettings_SR), "P_ProviderUid")]
	public Guid ProviderUid
	{
		[CompilerGenerated]
		get
		{
			return _003CProviderUid_003Ek__BackingField;
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
					_003CProviderUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public FullTextSearchSettings()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		t04hwGGQEwHC4UiBjd6H();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public static Dictionary<Guid, string> GetProviders()
	{
		return ComponentManager.Current.GetExtensionPoints<IFullTextSearchProvider>().ToDictionary((IFullTextSearchProvider provider) => _003C_003Ec.mPOxAGv5LRR2YZvKHCoa(provider), (IFullTextSearchProvider provider) => (string)_003C_003Ec.u7ik2dv5UKfTGDCfRm06(provider));
	}

	public static string GetProviderName(Guid providerGuid)
	{
		int num = 1;
		int num2 = num;
		IFullTextSearchProvider fullTextSearchProvider = default(IFullTextSearchProvider);
		_003C_003Ec__DisplayClass6_0 _003C_003Ec__DisplayClass6_ = default(_003C_003Ec__DisplayClass6_0);
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (fullTextSearchProvider != null)
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return (string)fgqj6IGQQqTMHMaMK7y4(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1859100187));
			case 1:
				_003C_003Ec__DisplayClass6_ = new _003C_003Ec__DisplayClass6_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				return (string)Fe2oc6GQf3pKrH0uEhhr(fullTextSearchProvider);
			default:
				_003C_003Ec__DisplayClass6_.providerGuid = providerGuid;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				fullTextSearchProvider = ComponentManager.Current.GetExtensionPoints<IFullTextSearchProvider>().FirstOrDefault(_003C_003Ec__DisplayClass6_._003CGetProviderName_003Eb__0);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
				{
					num2 = 3;
				}
				break;
			}
		}
	}

	public void BindAndSaveToGlobalSettings()
	{
		//Discarded unreachable code: IL_005f, IL_006e
		int num = 5;
		int num2 = num;
		FullTextSearchSettingsModule serviceNotNull = default(FullTextSearchSettingsModule);
		while (true)
		{
			switch (num2)
			{
			case 5:
				serviceNotNull = Locator.GetServiceNotNull<FullTextSearchSettingsModule>();
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
				{
					num2 = 3;
				}
				continue;
			case 2:
				return;
			case 4:
				if (serviceNotNull.Settings != null)
				{
					num2 = 3;
					continue;
				}
				return;
			case 6:
				return;
			case 3:
				if (serviceNotNull.Settings != this)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			case 1:
				bP6s6wGQCtS9vDB6O2uu(serviceNotNull.Settings, ProviderUid);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			O7tcmZGQv7uupoaixB1V(serviceNotNull);
			num2 = 2;
		}
	}

	internal static void t04hwGGQEwHC4UiBjd6H()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool ztINFiGQhgXumMG4MAIx()
	{
		return GhmSP6GQb7OHOhTTbL0I == null;
	}

	internal static FullTextSearchSettings cFtREiGQGxflVoMWuaEM()
	{
		return GhmSP6GQb7OHOhTTbL0I;
	}

	internal static object Fe2oc6GQf3pKrH0uEhhr(object P_0)
	{
		return ((IFullTextSearchProvider)P_0).ProviderName;
	}

	internal static object fgqj6IGQQqTMHMaMK7y4(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static void bP6s6wGQCtS9vDB6O2uu(object P_0, Guid value)
	{
		((FullTextSearchSettings)P_0).ProviderUid = value;
	}

	internal static void O7tcmZGQv7uupoaixB1V(object P_0)
	{
		((GlobalSettingsModuleBase<FullTextSearchSettings>)P_0).SaveSettings();
	}
}
