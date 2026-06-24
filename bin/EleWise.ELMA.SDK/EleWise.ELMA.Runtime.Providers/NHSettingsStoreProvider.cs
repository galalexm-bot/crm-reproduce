using System;
using System.Collections.Generic;
using EleWise.ELMA.Runtime.Settings.Impl;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Runtime.Providers.Impl;

public class NHSettingsStoreProvider : SettingsStoreProvider
{
	internal static NHSettingsStoreProvider axQllIWQPVyGNo0nNLLL;

	protected SystemSettingsManager Manager => Locator.GetServiceNotNull<SystemSettingsManager>();

	public override void SetString(Guid uid, string key, string value)
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
				AsfG04WQ3CJl76pkX3K9(Manager, uid, key, value);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override void SetStrings(Guid uid, IDictionary<string, string> strings)
	{
		Manager.SetStrings(uid, strings);
	}

	public override string GetString(Guid uid, string key)
	{
		return (string)c0ehSQWQpeA2GcndmIiA(Manager, uid, key);
	}

	public override IDictionary<string, string> GetAllStrings(Guid uid)
	{
		return Manager.GetAllStrings(uid);
	}

	public override void RemoveString(Guid uid, string key)
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
				wr6sF2WQafflnAWZuqbt(Manager, uid, key);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public override void RemoveAllStrings(Guid uid)
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
				Manager.RemoveAllStrings(uid);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public NHSettingsStoreProvider()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		U03Q2YWQDmRX2BvAh4nf();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void AsfG04WQ3CJl76pkX3K9(object P_0, Guid uid, object P_2, object P_3)
	{
		((SystemSettingsManager)P_0).SetString(uid, (string)P_2, (string)P_3);
	}

	internal static bool PYMJ8SWQ1WVj3S6UjH3K()
	{
		return axQllIWQPVyGNo0nNLLL == null;
	}

	internal static NHSettingsStoreProvider QBc774WQNUpxepHjCNin()
	{
		return axQllIWQPVyGNo0nNLLL;
	}

	internal static object c0ehSQWQpeA2GcndmIiA(object P_0, Guid uid, object P_2)
	{
		return ((SystemSettingsManager)P_0).GetString(uid, (string)P_2);
	}

	internal static void wr6sF2WQafflnAWZuqbt(object P_0, Guid uid, object P_2)
	{
		((SystemSettingsManager)P_0).RemoveString(uid, (string)P_2);
	}

	internal static void U03Q2YWQDmRX2BvAh4nf()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
