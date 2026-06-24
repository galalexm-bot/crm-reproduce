using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Metadata;

[Serializable]
public class EnumMetadataAdditionalAttribute
{
	internal static EnumMetadataAdditionalAttribute BcsPwIbDjGyxXBxv7ERR;

	[XmlAttribute]
	public string AddtibuteName
	{
		[CompilerGenerated]
		get
		{
			return _003CAddtibuteName_003Ek__BackingField;
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
					_003CAddtibuteName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
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

	[XmlElement("Parameter")]
	public EnumParameter[] Parameters
	{
		[CompilerGenerated]
		get
		{
			return _003CParameters_003Ek__BackingField;
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
					_003CParameters_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
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

	public EnumMetadataAdditionalAttribute()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool E1wBqSbDYammT2Pf4URE()
	{
		return BcsPwIbDjGyxXBxv7ERR == null;
	}

	internal static EnumMetadataAdditionalAttribute HYiED6bDL3XAC9Vd05eU()
	{
		return BcsPwIbDjGyxXBxv7ERR;
	}
}
