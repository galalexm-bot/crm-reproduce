using System;
using System.Xml.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Scheduling;

[Serializable]
public class RepeatSettings
{
	public bool Enabled;

	[XmlIgnore]
	public TimeSpan RepeatEvery;

	[XmlIgnore]
	public TimeSpan RepeatTo;

	internal static RepeatSettings lXiWd0BK4qvdd0CrrEQ5;

	public string RepeatEveryXml
	{
		get
		{
			return RepeatEvery.ToString();
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
					RepeatEvery = jET3Q8BKATILVZWqmI0j(value);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string RepeatToXml
	{
		get
		{
			return RepeatTo.ToString();
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
					RepeatTo = jET3Q8BKATILVZWqmI0j(value);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public RepeatSettings()
	{
		//Discarded unreachable code: IL_005c, IL_0061
		ewn8OLBK7nm67wJFbi5A();
		RepeatEvery = Kv08S2BKxoFgNcyY2WOq(10.0);
		RepeatTo = TimeSpan.FromHours(23.0);
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool ghQxgCBK6NMhb4GBcKqm()
	{
		return lXiWd0BK4qvdd0CrrEQ5 == null;
	}

	internal static RepeatSettings XNuWihBKH8nAISQeJnlo()
	{
		return lXiWd0BK4qvdd0CrrEQ5;
	}

	internal static TimeSpan jET3Q8BKATILVZWqmI0j(object P_0)
	{
		return TimeSpan.Parse((string)P_0);
	}

	internal static void ewn8OLBK7nm67wJFbi5A()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static TimeSpan Kv08S2BKxoFgNcyY2WOq(double P_0)
	{
		return TimeSpan.FromMinutes(P_0);
	}
}
