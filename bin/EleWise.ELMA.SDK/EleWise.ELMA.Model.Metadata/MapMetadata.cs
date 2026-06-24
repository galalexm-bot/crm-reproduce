using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Metadata;

[Serializable]
public class MapMetadata : NamedMetadata
{
	private static MapMetadata OCJ7sjb7scR4UeBxtdbd;

	[XmlElement("PropertyLeftUid")]
	public Guid PropertyLeftUid
	{
		[CompilerGenerated]
		get
		{
			return _003CPropertyLeftUid_003Ek__BackingField;
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
					_003CPropertyLeftUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
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

	[XmlElement("PropertyRightUid")]
	public Guid PropertyRightUid
	{
		[CompilerGenerated]
		get
		{
			return _003CPropertyRightUid_003Ek__BackingField;
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
					_003CPropertyRightUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[XmlElement("ClassPropertyRightUid")]
	public Guid ClassPropertyRightUid
	{
		[CompilerGenerated]
		get
		{
			return _003CClassPropertyRightUid_003Ek__BackingField;
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
					_003CClassPropertyRightUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
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

	public virtual void LoadFromPropertyInfo(PropertyInfo propertyInfo)
	{
		//Discarded unreachable code: IL_0147, IL_0156
		int num = 4;
		int num2 = num;
		MapAttribute attribute2 = default(MapAttribute);
		UidAttribute attribute = default(UidAttribute);
		while (true)
		{
			switch (num2)
			{
			case 8:
				ClassPropertyRightUid = S1UcKpbxosqeidFr3mwp(attribute2);
				num2 = 6;
				break;
			case 1:
				return;
			case 6:
				return;
			case 9:
				PropertyLeftUid = QMWTnpbxBdO0bMTDsD65(attribute);
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
				{
					num2 = 4;
				}
				break;
			case 3:
				attribute2 = AttributeHelper<MapAttribute>.GetAttribute(propertyInfo, inherited: true);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
				{
					num2 = 5;
				}
				break;
			case 2:
				if (attribute2 == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			case 7:
				PropertyRightUid = wY12ZObxWsbndRcERQwi(attribute2);
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
				{
					num2 = 8;
				}
				break;
			case 4:
				DYhouQbxFlpi2QurpZyt(propertyInfo, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-35995181 ^ -36161063));
				num2 = 3;
				break;
			default:
				if (attribute == null)
				{
					return;
				}
				num2 = 9;
				break;
			case 5:
				attribute = AttributeHelper<UidAttribute>.GetAttribute(propertyInfo, inherited: false);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public MapMetadata()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		kXkgvGbxb124oZb5Sivc();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool EyAAUpb7cAGt35rjtsIY()
	{
		return OCJ7sjb7scR4UeBxtdbd == null;
	}

	internal static MapMetadata P2Edpkb7zXM1459E7VeK()
	{
		return OCJ7sjb7scR4UeBxtdbd;
	}

	internal static void DYhouQbxFlpi2QurpZyt(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static Guid QMWTnpbxBdO0bMTDsD65(object P_0)
	{
		return ((UidAttribute)P_0).Uid;
	}

	internal static Guid wY12ZObxWsbndRcERQwi(object P_0)
	{
		return ((MapAttribute)P_0).PropertyUid;
	}

	internal static Guid S1UcKpbxosqeidFr3mwp(object P_0)
	{
		return ((MapAttribute)P_0).ClassTypeUid;
	}

	internal static void kXkgvGbxb124oZb5Sivc()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
