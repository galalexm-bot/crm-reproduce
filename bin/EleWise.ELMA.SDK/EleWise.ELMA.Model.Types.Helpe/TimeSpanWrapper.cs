using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Helpers;

[Component]
[XmlRoot("TimespanValue")]
public class TimeSpanWrapper : IXsiType
{
	private static TimeSpanWrapper gTAUOqbbKW8gwYGA6hYL;

	[XmlElement("TimeSpanUTC")]
	public long TimeSpanTicks
	{
		[CompilerGenerated]
		get
		{
			return _003CTimeSpanTicks_003Ek__BackingField;
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
					_003CTimeSpanTicks_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
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

	[XmlIgnore]
	public TimeSpan? Value
	{
		get
		{
			if (TimeSpanTicks > 0)
			{
				return new TimeSpan(TimeSpanTicks);
			}
			return null;
		}
		set
		{
			if (value.HasValue)
			{
				TimeSpanTicks = value.Value.Ticks;
			}
		}
	}

	public TimeSpanWrapper()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		gLTURqbbk0H91sFYD2sB();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public TimeSpanWrapper(TimeSpan? time)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		Value = time;
	}

	internal static void gLTURqbbk0H91sFYD2sB()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool rpKcWWbbXF3ntYS5gMaA()
	{
		return gTAUOqbbKW8gwYGA6hYL == null;
	}

	internal static TimeSpanWrapper q9I3K0bbTNHYujqW6E0h()
	{
		return gTAUOqbbKW8gwYGA6hYL;
	}
}
