using System;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Model.Common;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Messaging;

[Serializable]
public class CustomMessage
{
	private static CustomMessage UkkGJ7hmrK28JYNb3Bml;

	public Pair<string, string> Key { get; set; }

	public string Content
	{
		[CompilerGenerated]
		get
		{
			return _003CContent_003Ek__BackingField;
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
					_003CContent_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
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

	public CustomMessage()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		r2yhCVhmjPCNvCljXLG8();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool p8oE8GhmgMMRBUiCFuku()
	{
		return UkkGJ7hmrK28JYNb3Bml == null;
	}

	internal static CustomMessage EmqIpVhm5JryBZqsyN6o()
	{
		return UkkGJ7hmrK28JYNb3Bml;
	}

	internal static void r2yhCVhmjPCNvCljXLG8()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
