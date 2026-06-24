using System;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.Serialization;
using System.Threading;
using System.Xml.Serialization;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Enums;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Settings;

[Serializable]
public class WorkTimeSettings : SimpleTypeSettings, IHasDefaultValue<long?>
{
	private long _minValue;

	private long _maxValue;

	private static WorkTimeSettings NYhpxPocwuQ5ShBML005;

	[DefaultValue(long.MinValue)]
	[PublicationBehaviour(PublicationType.Restart)]
	[XmlElement("MinValue")]
	public long MinValue
	{
		get
		{
			return _minValue;
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
					_minValue = ((value < _minValue) ? long.MinValue : value);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[XmlElement("MaxValue")]
	[PublicationBehaviour(PublicationType.Restart)]
	[DefaultValue(long.MaxValue)]
	public long MaxValue
	{
		get
		{
			return _maxValue;
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
					_maxValue = ((value > _maxValue) ? long.MaxValue : value);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[PublicationBehaviour(PublicationType.Delta)]
	[XmlIgnore]
	public long? DefaultValue { get; set; }

	[XmlElement("DefaultValue")]
	[PublicationBehaviour(PublicationType.Delta)]
	[DefaultValue(null)]
	public string DefaultValueStr
	{
		get
		{
			int num = 4;
			int num2 = num;
			long value = default(long);
			long? defaultValue = default(long?);
			while (true)
			{
				switch (num2)
				{
				default:
					return value.ToString();
				case 3:
					if (!defaultValue.HasValue)
					{
						num2 = 2;
						break;
					}
					defaultValue = DefaultValue;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
					{
						num2 = 1;
					}
					break;
				case 4:
					defaultValue = DefaultValue;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
					{
						num2 = 3;
					}
					break;
				case 2:
					return null;
				case 1:
					value = defaultValue.Value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
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
					if (!lUsHVaocATYfjNX5drPf(value))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
						{
							num2 = 1;
						}
						break;
					}
					DefaultValue = null;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					return;
				case 0:
					return;
				case 1:
					DefaultValue = wsEaSXocxuMs2duuZ2Ux(value, AQDVbyoc7BneGVT7dkDg(Thread.CurrentThread.CurrentCulture));
					num2 = 3;
					break;
				}
			}
		}
	}

	public WorkTimeSettings()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		WY80syocHHQuCLGm6sKj();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	protected WorkTimeSettings(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		WY80syocHHQuCLGm6sKj();
		base._002Ector(info, context);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void WY80syocHHQuCLGm6sKj()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool vqI8fpoc4VNZBqIZwM29()
	{
		return NYhpxPocwuQ5ShBML005 == null;
	}

	internal static WorkTimeSettings F4tvpkoc6AOi148sqZty()
	{
		return NYhpxPocwuQ5ShBML005;
	}

	internal static bool lUsHVaocATYfjNX5drPf(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object AQDVbyoc7BneGVT7dkDg(object P_0)
	{
		return ((CultureInfo)P_0).NumberFormat;
	}

	internal static long wsEaSXocxuMs2duuZ2Ux(object P_0, object P_1)
	{
		return long.Parse((string)P_0, (IFormatProvider)P_1);
	}
}
