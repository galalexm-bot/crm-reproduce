using System;
using EleWise.ELMA.Logging;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Cache.Attributes;

public class CacheAttribute : Attribute
{
	private readonly string duration;

	private TimeSpan? durationTime;

	internal static CacheAttribute bMGOpwfXuY6ONyjXVUZU;

	public string Duration => duration;

	public TimeSpan? DurationTime => durationTime;

	public CacheAttribute()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		X8OBX2fXSwigRlqWy0jS();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public CacheAttribute(string duration)
	{
		//Discarded unreachable code: IL_001a, IL_001f, IL_009d, IL_00ac
		X8OBX2fXSwigRlqWy0jS();
		base._002Ector();
		int num = 6;
		TimeSpan result = default(TimeSpan);
		while (true)
		{
			switch (num)
			{
			case 3:
				durationTime = null;
				num = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
				{
					num = 6;
				}
				break;
			case 7:
				if (!Kr8G6ifXi8eSdJjhsWP5(duration))
				{
					num = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
					{
						num = 1;
					}
					break;
				}
				return;
			case 1:
				lxASlnfXqTdcl5dFghrs(nsBn4QfXRH0Ne6Lu4O7A(), SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x35C0467B ^ 0x35C5037D), duration));
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
				{
					num = 0;
				}
				break;
			default:
				durationTime = result;
				num = 5;
				break;
			case 6:
				this.duration = duration;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
				{
					num = 3;
				}
				break;
			case 5:
				return;
			case 2:
				if (TimeSpan.TryParse(duration, out result))
				{
					num = 4;
					break;
				}
				goto case 1;
			}
		}
	}

	internal static void X8OBX2fXSwigRlqWy0jS()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool hIxIW5fXI0xvBKWGLMaW()
	{
		return bMGOpwfXuY6ONyjXVUZU == null;
	}

	internal static CacheAttribute AojofVfXVtCZ72UQlbtT()
	{
		return bMGOpwfXuY6ONyjXVUZU;
	}

	internal static bool Kr8G6ifXi8eSdJjhsWP5(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static object nsBn4QfXRH0Ne6Lu4O7A()
	{
		return Logger.Log;
	}

	internal static void lxASlnfXqTdcl5dFghrs(object P_0, object P_1)
	{
		((ILogger)P_0).Error(P_1);
	}
}
