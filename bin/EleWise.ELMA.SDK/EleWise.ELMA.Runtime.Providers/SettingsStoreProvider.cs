using System;
using System.Collections.Generic;
using System.Configuration.Provider;
using EleWise.ELMA.Runtime.Managers;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Runtime.Providers;

public abstract class SettingsStoreProvider : ProviderBase, ISettingsManager
{
	internal static SettingsStoreProvider sTVwwOWE80o472SovhTn;

	protected SettingsStoreProvider()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		bnWprEWEIIGVgbaFQVMb();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public abstract void SetString(Guid uid, string key, string value);

	public abstract void SetStrings(Guid uid, IDictionary<string, string> strings);

	public abstract string GetString(Guid uid, string key);

	public abstract IDictionary<string, string> GetAllStrings(Guid uid);

	public abstract void RemoveString(Guid uid, string key);

	public abstract void RemoveAllStrings(Guid uid);

	internal static void bnWprEWEIIGVgbaFQVMb()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool zcrRQMWEZo0V6QYXYBI0()
	{
		return sTVwwOWE80o472SovhTn == null;
	}

	internal static SettingsStoreProvider OdHl7CWEuQkXxRFq3UVc()
	{
		return sTVwwOWE80o472SovhTn;
	}
}
