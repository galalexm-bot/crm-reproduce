using System;
using System.ComponentModel;
using System.Text;
using EleWise.ELMA.Scheduling;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Common.Models;

[TypeConverter(typeof(WorkTimeTypeConverter))]
public struct WorkTime
{
	private long value;

	private bool hasValue;

	private static object FJTLK4fimRVCCo5G6wOp;

	public long Value
	{
		get
		{
			return value;
		}
		set
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 2:
					this.value = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
					{
						num2 = 1;
					}
					break;
				case 0:
					return;
				case 1:
					hasValue = true;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public long MinutesInDay => CLUGwkfidZmHOdRF97hH();

	private static long minutesInDay
	{
		get
		{
			//Discarded unreachable code: IL_006f, IL_0107, IL_011e, IL_012d
			int num = 1;
			int num2 = num;
			long num3 = default(long);
			long result = default(long);
			while (true)
			{
				switch (num2)
				{
				case 2:
					return num3;
				case 1:
					num3 = 1440L;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
					{
						num2 = 0;
					}
					continue;
				}
				try
				{
					TimeSpan timeSpan = BaJA3wfir5WxYPQW6L0N(mJgMZBfilVRfdK0FqubA(Locator.GetServiceNotNull<IProductionCalendarService>()));
					int num4 = 4;
					int num5 = num4;
					while (true)
					{
						switch (num5)
						{
						case 4:
							num3 = (long)Math.Floor(timeSpan.TotalMinutes);
							num5 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
							{
								num5 = 0;
							}
							continue;
						case 1:
							result = 1440L;
							num5 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
							{
								num5 = 2;
							}
							continue;
						case 3:
							return num3;
						case 2:
							return result;
						}
						if (num3 <= 0)
						{
							num5 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
							{
								num5 = 1;
							}
							continue;
						}
						return num3;
					}
				}
				catch (Exception)
				{
					int num6 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
					{
						num6 = 0;
					}
					return num6 switch
					{
						0 => num3, 
						_ => num3, 
					};
				}
			}
		}
	}

	public long Days => TotalDays;

	public long Hours => (long)ycqrV7fig0Ofwi6BkdOJ((double)(value - TotalDays * MinutesInDay) / 60.0);

	public long Minutes => value - TotalHours * 60;

	public long TotalDays => (long)Math.Floor((double)value / (double)MinutesInDay);

	public long TotalHours => (long)Math.Floor((double)value / 60.0);

	public long TotalMinutes => value;

	public bool HasValue
	{
		get
		{
			return hasValue;
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
					hasValue = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public WorkTime(int minutes)
	{
		//Discarded unreachable code: IL_0005
		YF58OMfiJUPq3Ku3yXVn();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
		{
			num = 0;
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
				value = minutes;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
				{
					num = 2;
				}
				break;
			case 2:
				hasValue = true;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public WorkTime(long minutes)
	{
		//Discarded unreachable code: IL_0005
		YF58OMfiJUPq3Ku3yXVn();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				value = minutes;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
				{
					num = 0;
				}
				break;
			default:
				hasValue = true;
				num = 2;
				break;
			case 2:
				return;
			}
		}
	}

	public WorkTime(long days, long hours, long minutes)
	{
		//Discarded unreachable code: IL_0005
		SingletonReader.JJCZtPuTvSt();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				return;
			default:
				value = days * minutesInDay + hours * 60 + minutes;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
				{
					num = 1;
				}
				break;
			case 1:
				hasValue = true;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
				{
					num = 2;
				}
				break;
			}
		}
	}

	public WorkTime(long hours, long minutes)
	{
		//Discarded unreachable code: IL_0005
		YF58OMfiJUPq3Ku3yXVn();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
		{
			num = 2;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			case 2:
				value = hours * 60 + minutes;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
				{
					num = 0;
				}
				break;
			default:
				hasValue = true;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	public WorkTime(int? minutes)
	{
		SingletonReader.JJCZtPuTvSt();
		if (!minutes.HasValue)
		{
			value = 0L;
		}
		else
		{
			value = minutes.Value;
		}
		hasValue = true;
	}

	public WorkTime(long? minutes)
	{
		SingletonReader.JJCZtPuTvSt();
		if (!minutes.HasValue)
		{
			value = 0L;
		}
		else
		{
			value = minutes.Value;
		}
		hasValue = true;
	}

	public WorkTime(string minutes)
	{
		//Discarded unreachable code: IL_0005, IL_00ab, IL_00ba, IL_00cb
		YF58OMfiJUPq3Ku3yXVn();
		int num = 3;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
		{
			num = 2;
		}
		while (true)
		{
			switch (num)
			{
			case 3:
				if (!q6w0xxfi9ra1GmHXrSx5(minutes))
				{
					num = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
					{
						num = 4;
					}
					break;
				}
				goto case 4;
			case 2:
			case 5:
				hasValue = true;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
				{
					num = 1;
				}
				break;
			case 4:
				value = 0L;
				num = 2;
				break;
			case 1:
				return;
			default:
			{
				value = (long.TryParse(minutes, out var result) ? result : 0);
				num = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
				{
					num = 0;
				}
				break;
			}
			}
		}
	}

	public override string ToString()
	{
		return FormatString(shortValue: true);
	}

	public string ToShortFormat()
	{
		return FormatString(shortValue: true);
	}

	public string ToFormatString()
	{
		return FormatString();
	}

	private string FormatString(bool shortValue = false)
	{
		//Discarded unreachable code: IL_01da, IL_0228
		int num = 10;
		int num2 = num;
		Action<long, string> action = default(Action<long, string>);
		_003C_003Ec__DisplayClass32_0 _003C_003Ec__DisplayClass32_ = default(_003C_003Ec__DisplayClass32_0);
		while (true)
		{
			switch (num2)
			{
			case 7:
				action(Hours, (string)PxrklnfiYeBb0590C9Ap(zr3PCffi5IQ82InUTEQU(0x6A81B9B4 ^ 0x6A85B0F2)));
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
				{
					num2 = 6;
				}
				break;
			case 11:
				return (string)jfSi9hfijuiuauMo1Kvo(zr3PCffi5IQ82InUTEQU(-1487388570 ^ -1487076712), SR.T((string)zr3PCffi5IQ82InUTEQU(0x5DD55050 ^ 0x5DD0135C)));
			case 5:
				if (!shortValue)
				{
					num2 = 12;
					break;
				}
				goto case 3;
			case 4:
				return _003C_003Ec__DisplayClass32_.text.ToString();
			default:
				if (TotalMinutes != 0L)
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
					{
						num2 = 4;
					}
					break;
				}
				goto case 11;
			case 1:
			case 8:
				action(Minutes, SR.T((string)zr3PCffi5IQ82InUTEQU(0x68BBB53E ^ 0x68BEF632)));
				num2 = 4;
				break;
			case 2:
				if (HasValue)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 11;
			case 3:
				action(TotalHours, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2112703338 ^ -2112438832)));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
				{
					num2 = 1;
				}
				break;
			case 10:
				_003C_003Ec__DisplayClass32_ = new _003C_003Ec__DisplayClass32_0();
				num2 = 9;
				break;
			case 12:
				action(Days, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53FA00CE ^ 0x53FF43D8)));
				num2 = 7;
				break;
			case 9:
				_003C_003Ec__DisplayClass32_.text = new StringBuilder();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
				{
					num2 = 6;
				}
				break;
			case 6:
				action = _003C_003Ec__DisplayClass32_._003CFormatString_003Eb__0;
				num2 = 2;
				break;
			}
		}
	}

	public override bool Equals(object obj)
	{
		//Discarded unreachable code: IL_0041, IL_0050
		int num = 3;
		int num2 = num;
		WorkTime workTime = default(WorkTime);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return workTime.TotalMinutes == TotalMinutes;
			default:
				return false;
			case 2:
				workTime = (WorkTime)obj;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				if (obj is WorkTime)
				{
					num2 = 2;
					break;
				}
				goto default;
			}
		}
	}

	public override int GetHashCode()
	{
		int num = 1;
		int num2 = num;
		long totalMinutes = default(long);
		while (true)
		{
			switch (num2)
			{
			default:
				return totalMinutes.GetHashCode();
			case 1:
				totalMinutes = TotalMinutes;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static implicit operator long(WorkTime m)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return 0L;
			case 1:
				if (m.HasValue)
				{
					return m.Value;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static implicit operator WorkTime(long l)
	{
		int num = 1;
		int num2 = num;
		WorkTime result = default(WorkTime);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return result;
			case 1:
				result = default(WorkTime);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				result.Value = l;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static implicit operator long?(WorkTime m)
	{
		if (!m.HasValue)
		{
			return null;
		}
		return m.Value;
	}

	public static implicit operator WorkTime(long? l)
	{
		WorkTime result;
		if (!l.HasValue)
		{
			result = default(WorkTime);
			result.HasValue = false;
			return result;
		}
		result = default(WorkTime);
		result.Value = l.Value;
		result.HasValue = true;
		return result;
	}

	public static WorkTime operator -(WorkTime left, WorkTime right)
	{
		return new WorkTime(left.TotalMinutes - right.TotalMinutes);
	}

	public static WorkTime operator +(WorkTime left, WorkTime right)
	{
		return new WorkTime(left.TotalMinutes + right.TotalMinutes);
	}

	public static bool operator ==(WorkTime left, WorkTime right)
	{
		return left.TotalMinutes == right.TotalMinutes;
	}

	public static bool operator !=(WorkTime left, WorkTime right)
	{
		return left.TotalMinutes != right.TotalMinutes;
	}

	public static bool operator >(WorkTime left, WorkTime right)
	{
		return left.TotalMinutes > right.TotalMinutes;
	}

	public static bool operator <(WorkTime left, WorkTime right)
	{
		return left.TotalMinutes < right.TotalMinutes;
	}

	public static bool operator >=(WorkTime left, WorkTime right)
	{
		return left.TotalMinutes >= right.TotalMinutes;
	}

	public static bool operator <=(WorkTime left, WorkTime right)
	{
		return left.TotalMinutes <= right.TotalMinutes;
	}

	internal static void YF58OMfiJUPq3Ku3yXVn()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool aOOko2fiyAkSI8D7dvxo()
	{
		return FJTLK4fimRVCCo5G6wOp == null;
	}

	internal static object GkPrnUfiMjD4OdNDGZ92()
	{
		return FJTLK4fimRVCCo5G6wOp;
	}

	internal static bool q6w0xxfi9ra1GmHXrSx5(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static long CLUGwkfidZmHOdRF97hH()
	{
		return minutesInDay;
	}

	internal static object mJgMZBfilVRfdK0FqubA(object P_0)
	{
		return ((IProductionCalendarService)P_0).GetGlobalProductionSchedule();
	}

	internal static TimeSpan BaJA3wfir5WxYPQW6L0N(object P_0)
	{
		return ((IProductionSchedule)P_0).GetWorkTimeInDay();
	}

	internal static double ycqrV7fig0Ofwi6BkdOJ(double P_0)
	{
		return Math.Floor(P_0);
	}

	internal static object zr3PCffi5IQ82InUTEQU(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object jfSi9hfijuiuauMo1Kvo(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static object PxrklnfiYeBb0590C9Ap(object P_0)
	{
		return SR.T((string)P_0);
	}
}
