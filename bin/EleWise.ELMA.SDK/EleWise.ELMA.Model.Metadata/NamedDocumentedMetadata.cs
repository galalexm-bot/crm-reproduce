using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Types.Settings;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Metadata;

[Serializable]
[DataContract]
public class NamedDocumentedMetadata : NamedMetadata
{
	internal static NamedDocumentedMetadata M7CgZybAmLtc9M02TUMx;

	[Uid("{4B8DA303-082A-4CBE-8862-91266AC51F11}")]
	[XmlElement("XmlComments")]
	[Property("{9B9AAC17-22BB-425C-AA93-9C02C5146965}")]
	[DefaultValue("")]
	[EntityProperty]
	[StringSettings(FieldName = "XmlComments")]
	public virtual string XmlComments
	{
		[CompilerGenerated]
		get
		{
			return _003CXmlComments_003Ek__BackingField;
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
					_003CXmlComments_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
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

	public NamedDocumentedMetadata()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		BmQWsAbAJeXlnn9nTePZ();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				l8wX4LbA9kF7BtSMyNyW(this, "");
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static void BmQWsAbAJeXlnn9nTePZ()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static void l8wX4LbA9kF7BtSMyNyW(object P_0, object P_1)
	{
		((NamedDocumentedMetadata)P_0).XmlComments = (string)P_1;
	}

	internal static bool jQhHOfbAyhgbq6X18Ata()
	{
		return M7CgZybAmLtc9M02TUMx == null;
	}

	internal static NamedDocumentedMetadata NaSRPJbAMHNLXWnX63ZA()
	{
		return M7CgZybAmLtc9M02TUMx;
	}
}
