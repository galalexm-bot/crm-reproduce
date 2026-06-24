using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Enums;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Settings;

[Serializable]
public class ExceptionDataSettings : SimpleTypeSettings
{
	private static ExceptionDataSettings nrV48mosdUl3g7nEgN3Y;

	[XmlIgnore]
	[PublicationBehaviour(PublicationType.Delta)]
	public long? DefaultValue { get; set; }

	[DefaultValue(ExceptionDataDisplayType.simple)]
	[XmlElement("DisplayType")]
	public ExceptionDataDisplayType DisplayType
	{
		[CompilerGenerated]
		get
		{
			return _003CDisplayType_003Ek__BackingField;
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
					_003CDisplayType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
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

	public ExceptionDataSettings()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	protected ExceptionDataSettings(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		SqBthUosg96JKxStHkKG();
		base._002Ector(info, context);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool dTA5mJoslNbJF7Vm7ROt()
	{
		return nrV48mosdUl3g7nEgN3Y == null;
	}

	internal static ExceptionDataSettings hEwfxJosrmvhHn77n3BP()
	{
		return nrV48mosdUl3g7nEgN3Y;
	}

	internal static void SqBthUosg96JKxStHkKG()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
