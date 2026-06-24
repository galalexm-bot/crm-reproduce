using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Helpers;

[XmlRoot("DateTimeValue")]
[Component]
public class DateTimeWrapper : IXsiType
{
	private static DateTimeWrapper yRZEC3bQEgdD2bPR1nYx;

	[XmlElement("DateTimeUTC")]
	public long DateTimeTicks
	{
		[CompilerGenerated]
		get
		{
			return _003CDateTimeTicks_003Ek__BackingField;
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
					_003CDateTimeTicks_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
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
	public DateTime? Value
	{
		get
		{
			if (DateTimeTicks > 0)
			{
				return new DateTime(DateTimeTicks).ToLocalTime();
			}
			return null;
		}
		set
		{
			if (value.HasValue && value.HasValue)
			{
				DateTimeTicks = value.Value.ToUniversalTime().Ticks;
			}
		}
	}

	public DateTimeWrapper()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		VRZ19mbQCp6vEPVFMbKf();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public DateTimeWrapper(DateTime? source)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		Value = source;
	}

	internal static void VRZ19mbQCp6vEPVFMbKf()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool zcNyLxbQfUid6Wf2xopF()
	{
		return yRZEC3bQEgdD2bPR1nYx == null;
	}

	internal static DateTimeWrapper qVg0jvbQQePM5tJDNgTP()
	{
		return yRZEC3bQEgdD2bPR1nYx;
	}
}
