using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Ranges;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Helpers;

[XmlRoot("RelativeDateTimeValue")]
[Component]
public class RelativeDateTimeWrapper : IXsiType
{
	internal static RelativeDateTimeWrapper C4RHiKbbybbdVl5J192A;

	[XmlElement("DateTimeRange")]
	public DateTimeRangeWrapper DateTimeRange
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[XmlElement("IsRelative")]
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
				case 1:
					_003CIsRelative_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
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

	[XmlElement("RelativeFrom")]
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
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

	[XmlElement("RelativeTo")]
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
				case 0:
					return;
				case 1:
					_003CRelativeTo_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[XmlElement("From")]
	public DateTime? From { get; set; }

	[XmlElement("To")]
	public DateTime? To { get; set; }

	public RelativeDateTimeWrapper()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		hesuwabb9IKCcC4Hrxvv();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public RelativeDateTimeWrapper(RelativeDateTime source)
	{
		//Discarded unreachable code: IL_001a, IL_001f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				IsRelative = YdpJVYbbdZCRQQmPcY4a(source);
				num = 3;
				break;
			case 4:
				RelativeTo = (string)V5Eyp9bbg0f52YwymTDM(source);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
				{
					num = 0;
				}
				break;
			case 1:
				RelativeFrom = (string)esQx1obbry76tDWZT4NC(source);
				num = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
				{
					num = 0;
				}
				break;
			case 3:
				DateTimeRange = new DateTimeRangeWrapper(h4O8VBbblPBbapeIrLnx(source));
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	internal static void hesuwabb9IKCcC4Hrxvv()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool Bjh2XabbMr2Xh84M0to6()
	{
		return C4RHiKbbybbdVl5J192A == null;
	}

	internal static RelativeDateTimeWrapper MuUq5DbbJDx25o1gBKXP()
	{
		return C4RHiKbbybbdVl5J192A;
	}

	internal static bool YdpJVYbbdZCRQQmPcY4a(object P_0)
	{
		return ((RelativeDateTime)P_0).IsRelative;
	}

	internal static DateTimeRange h4O8VBbblPBbapeIrLnx(object P_0)
	{
		return ((RelativeDateTime)P_0).DateTimeRange;
	}

	internal static object esQx1obbry76tDWZT4NC(object P_0)
	{
		return ((RelativeDateTime)P_0).RelativeFrom;
	}

	internal static object V5Eyp9bbg0f52YwymTDM(object P_0)
	{
		return ((RelativeDateTime)P_0).RelativeTo;
	}
}
