using System;
using System.Collections.Generic;
using System.Text;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Templates;
using EleWise.TemplateGenerator;
using EleWise.TemplateGenerator.Functions;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Extensions;

[Component]
public class TimeSpanTemplateGeneratorFunctions : ITemplateGeneratorFunctionsContainer
{
	private static TimeSpanTemplateGeneratorFunctions tZen7aGwa7G25lJSYvPm;

	public static FormatedValue ИнтервалВремениВСтроку(FunctionEvaluationContext context)
	{
		return (FormatedValue)gMNdQXGwwDbe5Cv9HhYE(context);
	}

	public static FormatedValue TimeSpanToString(FunctionEvaluationContext context)
	{
		//Discarded unreachable code: IL_0191, IL_01a0, IL_01be
		int num = 1;
		int num2 = num;
		StringBuilder stringBuilder = default(StringBuilder);
		TimeSpan timeSpan = default(TimeSpan);
		while (true)
		{
			switch (num2)
			{
			case 6:
				m2KUxCGwAZZYnZYpjh2v(Q9yUovGwHoFZ5rRoR2Ze(stringBuilder, timeSpan.Hours), x8ffhiGw6YK3axDfkQ2f(-583745292 ^ -583582094));
				num2 = 11;
				break;
			case 1:
				if (hWpiosGw4P3hFggVVZ4h(context.Parameters) < 1)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
					{
						num2 = 0;
					}
					break;
				}
				stringBuilder = new StringBuilder();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
				{
					num2 = 7;
				}
				break;
			default:
				return null;
			case 9:
				stringBuilder.Append(timeSpan.Minutes).Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-957824448 ^ -957661998));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
				{
					num2 = 8;
				}
				break;
			case 5:
			case 8:
				if (timeSpan.Seconds <= 0)
				{
					num2 = 12;
					break;
				}
				goto case 13;
			case 3:
				if (timeSpan.Hours > 0)
				{
					num2 = 6;
					break;
				}
				goto case 11;
			case 4:
				stringBuilder.Append(timeSpan.Days).Append((string)x8ffhiGw6YK3axDfkQ2f(-29254301 ^ -29203687));
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
				{
					num2 = 1;
				}
				break;
			case 2:
			case 12:
				return new FormatedValue(stringBuilder.ToString());
			case 10:
				if (timeSpan.Days > 0)
				{
					num2 = 4;
					break;
				}
				goto case 3;
			case 7:
				timeSpan = TimeSpan.Parse(context.Parameters[0].ToString());
				num2 = 10;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
				{
					num2 = 9;
				}
				break;
			case 13:
				m2KUxCGwAZZYnZYpjh2v(Q9yUovGwHoFZ5rRoR2Ze(stringBuilder, timeSpan.Seconds), x8ffhiGw6YK3axDfkQ2f(-1921202237 ^ -1921042079));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
				{
					num2 = 2;
				}
				break;
			case 11:
				if (timeSpan.Minutes <= 0)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
					{
						num2 = 5;
					}
					break;
				}
				goto case 9;
			}
		}
	}

	public static FormatedValue ПолучитьДниИнтервала(FunctionEvaluationContext context)
	{
		return GetTimeSpanDays(context);
	}

	public static FormatedValue GetTimeSpanDays(FunctionEvaluationContext context)
	{
		//Discarded unreachable code: IL_0082, IL_0091
		int num = 3;
		int num2 = num;
		int days = default(int);
		TimeSpan timeSpan = default(TimeSpan);
		while (true)
		{
			switch (num2)
			{
			default:
				return new FormatedValue(days.ToString());
			case 2:
				return null;
			case 1:
				timeSpan = xMHNUsGw74tk7WwGeW6b(context.Parameters[0].ToString());
				num2 = 4;
				break;
			case 3:
				if (hWpiosGw4P3hFggVVZ4h(context.Parameters) < 1)
				{
					num2 = 2;
					break;
				}
				goto case 1;
			case 4:
				days = timeSpan.Days;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static FormatedValue ПолучитьЧасыИнтервала(FunctionEvaluationContext context)
	{
		return (FormatedValue)uepJKPGwxU46u3ksfQZG(context);
	}

	public static FormatedValue GetTimeSpanHours(FunctionEvaluationContext context)
	{
		//Discarded unreachable code: IL_0095, IL_00a4
		int num = 2;
		int num2 = num;
		TimeSpan timeSpan = default(TimeSpan);
		int hours = default(int);
		while (true)
		{
			switch (num2)
			{
			default:
				timeSpan = xMHNUsGw74tk7WwGeW6b(context.Parameters[0].ToString());
				num2 = 4;
				break;
			case 4:
				hours = timeSpan.Hours;
				num2 = 3;
				break;
			case 2:
				if (hWpiosGw4P3hFggVVZ4h(context.Parameters) < 1)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			case 3:
				return new FormatedValue(hours.ToString());
			case 1:
				return null;
			}
		}
	}

	public static FormatedValue ПолучитьМинутыИнтервала(FunctionEvaluationContext context)
	{
		return GetTimeSpanMinutes(context);
	}

	public static FormatedValue GetTimeSpanMinutes(FunctionEvaluationContext context)
	{
		//Discarded unreachable code: IL_0057, IL_0066
		int num = 1;
		int num2 = num;
		TimeSpan timeSpan = default(TimeSpan);
		int minutes = default(int);
		while (true)
		{
			switch (num2)
			{
			case 3:
				timeSpan = TimeSpan.Parse(context.Parameters[0].ToString());
				num2 = 4;
				break;
			case 1:
				if (hWpiosGw4P3hFggVVZ4h(context.Parameters) < 1)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			case 4:
				minutes = timeSpan.Minutes;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return new FormatedValue(minutes.ToString());
			default:
				return null;
			}
		}
	}

	public static FormatedValue ПолучитьСекундыИнтервала(FunctionEvaluationContext context)
	{
		return (FormatedValue)BlELDNGw0b08KMgkTjuF(context);
	}

	public static FormatedValue GetTimeSpanSeconds(FunctionEvaluationContext context)
	{
		//Discarded unreachable code: IL_0083, IL_0092
		int num = 4;
		int num2 = num;
		int seconds = default(int);
		TimeSpan timeSpan = default(TimeSpan);
		while (true)
		{
			switch (num2)
			{
			case 4:
				if (hWpiosGw4P3hFggVVZ4h(context.Parameters) < 1)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			default:
				seconds = timeSpan.Seconds;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				timeSpan = TimeSpan.Parse(context.Parameters[0].ToString());
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return new FormatedValue(seconds.ToString());
			case 3:
				return null;
			}
		}
	}

	[Obsolete("Используйте TimeSpanToString")]
	public static FormatedValue ИНТЕРВАЛ(FunctionEvaluationContext context)
	{
		return (FormatedValue)gMNdQXGwwDbe5Cv9HhYE(context);
	}

	[Obsolete("Используйте GetTimeSpanDays")]
	public static FormatedValue ИНТЕРВАЛ_ДНИ(FunctionEvaluationContext context)
	{
		return (FormatedValue)UMnHBLGwmsLhw40MNehm(context);
	}

	[Obsolete("Используйте GetTimeSpanHours")]
	public static FormatedValue ИНТЕРВАЛ_ЧАСЫ(FunctionEvaluationContext context)
	{
		return (FormatedValue)uepJKPGwxU46u3ksfQZG(context);
	}

	[Obsolete("Используйте GetTimeSpanMinutes")]
	public static FormatedValue ИНТЕРВАЛ_МИНУТЫ(FunctionEvaluationContext context)
	{
		return (FormatedValue)AS7hRuGwyblE00EiHG5X(context);
	}

	[Obsolete("Используйте GetTimeSpanSeconds")]
	public static FormatedValue ИНТЕРВАЛ_СЕКУНДЫ(FunctionEvaluationContext context)
	{
		return (FormatedValue)BlELDNGw0b08KMgkTjuF(context);
	}

	public TimeSpanTemplateGeneratorFunctions()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object gMNdQXGwwDbe5Cv9HhYE(object P_0)
	{
		return TimeSpanToString((FunctionEvaluationContext)P_0);
	}

	internal static int hWpiosGw4P3hFggVVZ4h(object P_0)
	{
		return ((List<FormatedValue>)P_0).Count;
	}

	internal static object x8ffhiGw6YK3axDfkQ2f(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object Q9yUovGwHoFZ5rRoR2Ze(object P_0, int P_1)
	{
		return ((StringBuilder)P_0).Append(P_1);
	}

	internal static object m2KUxCGwAZZYnZYpjh2v(object P_0, object P_1)
	{
		return ((StringBuilder)P_0).Append((string)P_1);
	}

	internal static bool kK4YMqGwDTJ2lSjZsDQ8()
	{
		return tZen7aGwa7G25lJSYvPm == null;
	}

	internal static TimeSpanTemplateGeneratorFunctions MbvIm8Gwt4lMCDaEKSW8()
	{
		return tZen7aGwa7G25lJSYvPm;
	}

	internal static TimeSpan xMHNUsGw74tk7WwGeW6b(object P_0)
	{
		return TimeSpan.Parse((string)P_0);
	}

	internal static object uepJKPGwxU46u3ksfQZG(object P_0)
	{
		return GetTimeSpanHours((FunctionEvaluationContext)P_0);
	}

	internal static object BlELDNGw0b08KMgkTjuF(object P_0)
	{
		return GetTimeSpanSeconds((FunctionEvaluationContext)P_0);
	}

	internal static object UMnHBLGwmsLhw40MNehm(object P_0)
	{
		return GetTimeSpanDays((FunctionEvaluationContext)P_0);
	}

	internal static object AS7hRuGwyblE00EiHG5X(object P_0)
	{
		return GetTimeSpanMinutes((FunctionEvaluationContext)P_0);
	}
}
