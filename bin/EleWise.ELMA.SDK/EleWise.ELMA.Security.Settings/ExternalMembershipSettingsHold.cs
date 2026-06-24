using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Extensions;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Security.Settings;

[Serializable]
public class ExternalMembershipSettingsHolder : List<ExternalMembershipSettingsHolderItem>
{
	private static ExternalMembershipSettingsHolder PdOaJMBYdJuddtFDAKU2;

	public static ExternalMembershipSettingsHolder DictionaryToHolder(IDictionary<string, string> dict)
	{
		_003C_003Ec__DisplayClass0_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass0_0();
		CS_0024_003C_003E8__locals0.holder = new ExternalMembershipSettingsHolder();
		dict.ForEach(delegate(KeyValuePair<string, string> p)
		{
			CS_0024_003C_003E8__locals0.holder.Add(new ExternalMembershipSettingsHolderItem
			{
				Key = p.Key,
				Value = p.Value
			});
		});
		return CS_0024_003C_003E8__locals0.holder;
	}

	public static IDictionary<string, string> HolderToDictionary(ExternalMembershipSettingsHolder holder)
	{
		_003C_003Ec__DisplayClass1_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass1_0();
		CS_0024_003C_003E8__locals0.dict = new Dictionary<string, string>();
		holder.ForEach(delegate(ExternalMembershipSettingsHolderItem p)
		{
			//Discarded unreachable code: IL_0052, IL_0061
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 2:
					CS_0024_003C_003E8__locals0.dict.Add((string)_003C_003Ec__DisplayClass1_0.AQoWmFQPPLFIlmbk1E7m(p), (string)_003C_003Ec__DisplayClass1_0.qKuwClQP1XJBJgRnFBJg(p));
					num2 = 3;
					break;
				case 0:
					return;
				case 1:
					if (CS_0024_003C_003E8__locals0.dict.ContainsKey(p.Key))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				case 3:
					return;
				}
			}
		});
		return CS_0024_003C_003E8__locals0.dict;
	}

	public ExternalMembershipSettingsHolder()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		JE2G1YBYgXe8iePMaUba();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void JE2G1YBYgXe8iePMaUba()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool FlmHyMBYlPjtsEjWfQ34()
	{
		return PdOaJMBYdJuddtFDAKU2 == null;
	}

	internal static ExternalMembershipSettingsHolder Y4Y4c4BYrg3dS2QxwEmL()
	{
		return PdOaJMBYdJuddtFDAKU2;
	}
}
[Serializable]
public class ExternalMembershipSettingsHolderItem
{
	internal static ExternalMembershipSettingsHolderItem aKZiqLBY56R7ePwTVeBL;

	public string Key
	{
		[CompilerGenerated]
		get
		{
			return _003CKey_003Ek__BackingField;
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
					_003CKey_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string Value
	{
		[CompilerGenerated]
		get
		{
			return _003CValue_003Ek__BackingField;
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
					_003CValue_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public ExternalMembershipSettingsHolderItem()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool QnZYkABYjh0CWCSaPCns()
	{
		return aKZiqLBY56R7ePwTVeBL == null;
	}

	internal static ExternalMembershipSettingsHolderItem THkCJWBYYS3mO8yIiQWL()
	{
		return aKZiqLBY56R7ePwTVeBL;
	}
}
