using System.Configuration;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Locking;

public class LockServiceSettingsBase : ConfigurationSection
{
	private static LockServiceSettingsBase bAghp9hgbc4hPKY3fIFf;

	[ConfigurationProperty("validFor", DefaultValue = 30)]
	public int DefaultLockValidFor
	{
		get
		{
			return (int)TB0KsRhgfvfGTBgHmZvZ(this, dTE4SThgEMd4PopHbVXE(0x34A6D230 ^ 0x34A54EAC));
		}
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
					HtYmlVhgQFmt0bVCbddE(this, dTE4SThgEMd4PopHbVXE(-138018305 ^ -138044061), value);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[ConfigurationProperty("timeout", DefaultValue = 30)]
	public int DefaultLockTimeout
	{
		get
		{
			return (int)base[(string)dTE4SThgEMd4PopHbVXE(-740338220 ^ -740505244)];
		}
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
					HtYmlVhgQFmt0bVCbddE(this, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105199646 ^ -105292974), value);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
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

	[ConfigurationProperty("repeat", DefaultValue = 500)]
	public int DefaultLockRepeat
	{
		get
		{
			return (int)base[(string)dTE4SThgEMd4PopHbVXE(0x76DD48E ^ 0x76E484C)];
		}
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
					base[(string)dTE4SThgEMd4PopHbVXE(0x4EDCBA32 ^ 0x4EDF26F0)] = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
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

	public LockServiceSettingsBase()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object dTE4SThgEMd4PopHbVXE(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object TB0KsRhgfvfGTBgHmZvZ(object P_0, object P_1)
	{
		return ((ConfigurationElement)P_0)[(string)P_1];
	}

	internal static bool jOfhQ4hghvya4a5EV0EE()
	{
		return bAghp9hgbc4hPKY3fIFf == null;
	}

	internal static LockServiceSettingsBase A9pQVahgGlnWZlqLtdne()
	{
		return bAghp9hgbc4hPKY3fIFf;
	}

	internal static void HtYmlVhgQFmt0bVCbddE(object P_0, object P_1, object P_2)
	{
		((ConfigurationElement)P_0)[(string)P_1] = P_2;
	}
}
