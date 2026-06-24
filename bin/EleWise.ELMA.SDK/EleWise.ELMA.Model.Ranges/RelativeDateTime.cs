using System;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Helpers;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Ranges;

public class RelativeDateTime
{
	internal static RelativeDateTime o4kOmAWz8LOMG9KUo2Pi;

	public bool IsRelative
	{
		[CompilerGenerated]
		get
		{
			return _003CIsRelative_003Ek__BackingField;
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
					_003CIsRelative_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string RelativeFrom
	{
		[CompilerGenerated]
		get
		{
			return _003CRelativeFrom_003Ek__BackingField;
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
					_003CRelativeFrom_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
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

	public string RelativeTo
	{
		[CompilerGenerated]
		get
		{
			return _003CRelativeTo_003Ek__BackingField;
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
					_003CRelativeTo_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
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

	public DateTimeRange DateTimeRange
	{
		[CompilerGenerated]
		get
		{
			return _003CDateTimeRange_003Ek__BackingField;
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
					_003CDateTimeRange_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public DateTime? FromValue
	{
		get
		{
			if (IsRelative)
			{
				RelativeDateTimeParser.TryParseFromDate(RelativeFrom, out var result);
				return result;
			}
			return DateTimeRange.From;
		}
	}

	public DateTime? ToValue
	{
		get
		{
			if (IsRelative)
			{
				RelativeDateTimeParser.TryParseToDate(RelativeTo, out var result);
				return result;
			}
			return DateTimeRange.To;
		}
	}

	public RelativeDateTime()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public RelativeDateTime(DateTime? from, DateTime? to)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		IsRelative = false;
		RelativeFrom = null;
		RelativeTo = null;
		DateTimeRange = new DateTimeRange(from, to);
	}

	public RelativeDateTime(string from, string to)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		b2eoQNWzIK6xkGCR4PdF();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				return;
			case 1:
				IsRelative = true;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
				{
					num = 0;
				}
				break;
			default:
				RelativeFrom = from;
				num = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
				{
					num = 3;
				}
				break;
			case 3:
				RelativeTo = to;
				num = 2;
				break;
			}
		}
	}

	public static explicit operator DateTimeRange(RelativeDateTime rdt)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!WykNQgWzVyydCgYJcUeU(rdt))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return new DateTimeRange(rdt.FromValue, rdt.ToValue);
			default:
				return rdt.DateTimeRange;
			}
		}
	}

	internal static bool PKg7lxWzZhVk0AJ1LWek()
	{
		return o4kOmAWz8LOMG9KUo2Pi == null;
	}

	internal static RelativeDateTime B2JOIrWzu1FjNpWURqQA()
	{
		return o4kOmAWz8LOMG9KUo2Pi;
	}

	internal static void b2eoQNWzIK6xkGCR4PdF()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool WykNQgWzVyydCgYJcUeU(object P_0)
	{
		return ((RelativeDateTime)P_0).IsRelative;
	}
}
