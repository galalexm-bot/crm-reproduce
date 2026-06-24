using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Events;

public static class EventSettings
{
	private static readonly ContextVars.Local<bool?> EnabledLocal;

	internal static EventSettings UqsnwJGYqUewK7H1y5th;

	public static bool Enabled
	{
		get
		{
			//Discarded unreachable code: IL_0047, IL_0056
			int num = 3;
			int num2 = num;
			bool? value = default(bool?);
			while (true)
			{
				switch (num2)
				{
				case 3:
					value = EnabledLocal.Value;
					num2 = 2;
					break;
				case 1:
					return true;
				default:
					return value.GetValueOrDefault();
				case 2:
					if (value.HasValue)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 1;
				}
			}
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
					EnabledLocal.Value = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	static EventSettings()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				EnabledLocal = new ContextVars.Local<bool?>();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 2:
				l4nmUsGYT94CfuI0cVD3();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool zHE1WmGYK1mwDQYtYlub()
	{
		return UqsnwJGYqUewK7H1y5th == null;
	}

	internal static EventSettings oZeTtuGYX1EMp8hxgH1n()
	{
		return UqsnwJGYqUewK7H1y5th;
	}

	internal static void l4nmUsGYT94CfuI0cVD3()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
