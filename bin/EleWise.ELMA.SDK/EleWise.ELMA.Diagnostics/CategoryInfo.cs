using System.Collections.Generic;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Diagnostics;

internal sealed class CategoryInfo
{
	private static CategoryInfo JH38EwGzFrrBs65iA7Rn;

	public string CategoryName
	{
		[CompilerGenerated]
		get
		{
			return _003CCategoryName_003Ek__BackingField;
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
					_003CCategoryName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string CategoryHelp
	{
		[CompilerGenerated]
		get
		{
			return _003CCategoryHelp_003Ek__BackingField;
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
					_003CCategoryHelp_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public List<CounterInfo> CountersData { get; set; }

	public CategoryInfo()
	{
		//Discarded unreachable code: IL_003a, IL_003f
		dw6xJ1Gzo1hJQwjUfww0();
		CountersData = new List<CounterInfo>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool ojbp4lGzB9mS7AseF6ov()
	{
		return JH38EwGzFrrBs65iA7Rn == null;
	}

	internal static CategoryInfo rmVov9GzWMoEbFJMA5b9()
	{
		return JH38EwGzFrrBs65iA7Rn;
	}

	internal static void dw6xJ1Gzo1hJQwjUfww0()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
