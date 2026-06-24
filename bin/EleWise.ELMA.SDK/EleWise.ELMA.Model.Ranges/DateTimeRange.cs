using System;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Ranges;

public struct DateTimeRange : IRange<DateTime>
{
	internal static object WvE2AqWz0KtvZXcD5em5;

	public DateTime? From { get; set; }

	public DateTime? To { get; set; }

	public DateTimeRange(DateTime? from, DateTime? to)
	{
		SingletonReader.JJCZtPuTvSt();
		this = default(DateTimeRange);
		From = from;
		To = to;
	}

	public DateTimeRange Create(DateTime? from, DateTime? to)
	{
		return new DateTimeRange(from, to);
	}

	public bool Contains(DateTime? date)
	{
		if (date.HasValue && date.HasValue)
		{
			DateTime value = date.Value;
			DateTime? from = From;
			if (value >= from)
			{
				value = date.Value;
				from = To;
				return value <= from;
			}
		}
		return false;
	}

	public override string ToString()
	{
		return (string)kgXufkWzMasNKLbPkmnn(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606767926), From.HasValue ? From.ToString() : "", To.HasValue ? To.ToString() : "");
	}

	public override bool Equals(object obj)
	{
		//Discarded unreachable code: IL_005e, IL_007c, IL_0125, IL_01dc, IL_01eb
		int num = 10;
		int num2 = num;
		DateTime? dateTime2 = default(DateTime?);
		DateTimeRange dateTimeRange = default(DateTimeRange);
		DateTime? dateTime = default(DateTime?);
		while (true)
		{
			switch (num2)
			{
			case 2:
				dateTime2 = dateTimeRange.From;
				num2 = 8;
				continue;
			case 6:
				if (dateTime.HasValue != dateTime2.HasValue)
				{
					num2 = 13;
					continue;
				}
				if (dateTime.HasValue)
				{
					num2 = 4;
					continue;
				}
				goto case 14;
			case 8:
				dateTime = From;
				num2 = 5;
				continue;
			case 12:
				dateTime2 = To;
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
				{
					num2 = 4;
				}
				continue;
			case 10:
				if (obj != null)
				{
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
					{
						num2 = 9;
					}
					continue;
				}
				goto case 1;
			case 14:
				return true;
			case 4:
				return SK01hZWzdhb1tuVR3dmf(dateTime.GetValueOrDefault(), dateTime2.GetValueOrDefault());
			case 11:
				return false;
			case 5:
				if (dateTime2.HasValue == dateTime.HasValue)
				{
					if (!dateTime2.HasValue)
					{
						num2 = 3;
						continue;
					}
					if (SK01hZWzdhb1tuVR3dmf(dateTime2.GetValueOrDefault(), dateTime.GetValueOrDefault()))
					{
						break;
					}
					goto case 11;
				}
				num2 = 11;
				continue;
			case 1:
				return false;
			case 9:
				if (CCahuCWz9cnXlZya7KNv(obj.GetType(), Q8DIfGWzJWNm2WQIKggU(this)))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
					{
						num2 = 0;
					}
				}
				else
				{
					dateTimeRange = (DateTimeRange)obj;
					num2 = 2;
				}
				continue;
			case 7:
				dateTime = dateTimeRange.To;
				num2 = 12;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
				{
					num2 = 0;
				}
				continue;
			case 13:
				return false;
			default:
				return false;
			case 3:
				break;
			}
			num2 = 7;
		}
	}

	public override int GetHashCode()
	{
		//Discarded unreachable code: IL_0095
		int num = 2;
		DateTime? from = default(DateTime?);
		DateTime dateTime = default(DateTime);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				DateTime dateTime2;
				switch (num2)
				{
				case 2:
					from = From;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
					{
						num2 = 1;
					}
					continue;
				case 4:
					dateTime = default(DateTime);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					if (!from.HasValue)
					{
						break;
					}
					dateTime2 = from.GetValueOrDefault();
					goto IL_00a1;
				default:
					dateTime2 = dateTime;
					goto IL_00a1;
				case 3:
					{
						return dateTime.GetHashCode() ^ (To ?? default(DateTime)).GetHashCode();
					}
					IL_00a1:
					dateTime = dateTime2;
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			num = 4;
		}
	}

	internal static object kgXufkWzMasNKLbPkmnn(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static bool ElJXmkWzmhcjNW63qq8V()
	{
		return WvE2AqWz0KtvZXcD5em5 == null;
	}

	internal static object tf7GSlWzyEhw07hnvUlY()
	{
		return WvE2AqWz0KtvZXcD5em5;
	}

	internal static Type Q8DIfGWzJWNm2WQIKggU(object P_0)
	{
		return P_0.GetType();
	}

	internal static bool CCahuCWz9cnXlZya7KNv(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static bool SK01hZWzdhb1tuVR3dmf(DateTime P_0, DateTime P_1)
	{
		return P_0 == P_1;
	}
}
