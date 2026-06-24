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
public class DataClassSettings : SimpleTypeSettings, IRelationTypeSettings
{
	internal static DataClassSettings Sqa6TVoU9I33lMBLgHSE;

	[DefaultValue(RelationType.OneToOne)]
	[XmlElement("RelationType")]
	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(_Resources_DataClassSettingsResources), "RelationType")]
	[PublicationBehaviour(PublicationType.Restart)]
	public RelationType RelationType
	{
		[CompilerGenerated]
		get
		{
			return _003CRelationType_003Ek__BackingField;
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
					_003CRelationType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[XmlElement("DisplayType")]
	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(_Resources_DataClassSettingsResources), "DisplayType")]
	[DefaultValue(DataClassDisplayType.Standard)]
	public DataClassDisplayType DisplayType
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
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

	public DataClassSettings()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		mde1PRoUrSTmiHtK9GIi();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	protected DataClassSettings(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		mde1PRoUrSTmiHtK9GIi();
		base._002Ector(info, context);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void mde1PRoUrSTmiHtK9GIi()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool VdJwOEoUdWc6hMf8r4hr()
	{
		return Sqa6TVoU9I33lMBLgHSE == null;
	}

	internal static DataClassSettings a00FD5oUlYoPND65hcG3()
	{
		return Sqa6TVoU9I33lMBLgHSE;
	}
}
