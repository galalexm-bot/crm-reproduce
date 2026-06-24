using System;
using System.Data;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Attributes;

[AttributeUsage(AttributeTargets.Method, Inherited = true, AllowMultiple = false)]
public class TransactionAttribute : Attribute
{
	internal static TransactionAttribute yfIHmkoILjCMP51pgiqP;

	public IsolationLevel IsolationLevel
	{
		[CompilerGenerated]
		get
		{
			return _003CIsolationLevel_003Ek__BackingField;
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
					_003CIsolationLevel_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public TransactionAttribute()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		sVcHIGoIcgOD4dNyKJbg();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			IsolationLevel = IsolationLevel.Unspecified;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
			{
				num = 0;
			}
		}
	}

	internal static void sVcHIGoIcgOD4dNyKJbg()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool squ2J8oIUCpjm5t3mLws()
	{
		return yfIHmkoILjCMP51pgiqP == null;
	}

	internal static TransactionAttribute wD9w8foIseCiAd1KJ7fR()
	{
		return yfIHmkoILjCMP51pgiqP;
	}
}
