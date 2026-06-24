using System;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Attributes;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface)]
public class SaveHistoryAttribute : Attribute
{
	private bool saveHistory;

	internal static SaveHistoryAttribute d7TlbIouwheXsjCdcx41;

	public bool SaveHistory => saveHistory;

	public SaveHistoryAttribute()
	{
		//Discarded unreachable code: IL_0036, IL_003b
		JAqiWgouHj4dkqK6CFWS();
		saveHistory = true;
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public SaveHistoryAttribute(bool saveHistory)
	{
		//Discarded unreachable code: IL_0036, IL_003b
		SingletonReader.JJCZtPuTvSt();
		this.saveHistory = true;
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				this.saveHistory = saveHistory;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	internal static void JAqiWgouHj4dkqK6CFWS()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool vQHxROou4MeVIguCFElw()
	{
		return d7TlbIouwheXsjCdcx41 == null;
	}

	internal static SaveHistoryAttribute N2wFj2ou6XE9fAFq0B5K()
	{
		return d7TlbIouwheXsjCdcx41;
	}
}
