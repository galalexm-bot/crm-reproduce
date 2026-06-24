using System;
using System.Data;
using System.Text;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Groups;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH.CustomTypes;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Types;

public class XmlSerializableObjectTypeDescriptor : CLRTypeDescriptor<object, XmlSerializableObjectSettings>, IMappingTypeDescriptor
{
	public const string UID_S = "{66C7898B-E56B-49E0-BFB8-9F9C4A7A0C52}";

	public static readonly Guid UID;

	internal static XmlSerializableObjectTypeDescriptor I16KrYoHC7LEnposYXuf;

	public override Guid Uid => UID;

	public override string Name => (string)KiPPFUoHukbZjA2tY8QT(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1334993905 ^ -1334895381));

	public override Guid ParentUid => SystemTypesDescriptor.UID;

	public override bool Visible
	{
		get
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return MetadataAccessInfo.EnvironmentType == MetadataEnvironmentType.DevServer;
				default:
					if (MetadataAccessInfo.EnvironmentType == MetadataEnvironmentType.VisualStudio)
					{
						return true;
					}
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					if (!base.Visible)
					{
						return false;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	protected override void ExtendSimplePropertyMapping(INHibernatePropertyTypeMapper mapper, EntityPropertyMetadata propertyMetadata)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				RfL6uaoHZv7u33vl7Cnp(this, mapper, propertyMetadata);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			default:
				mapper.Type<XmlObjectSerializableType>();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public override object SerializeSimple(object value, Type valueType, EntitySerializationSettings settings)
	{
		//Discarded unreachable code: IL_0118, IL_0127
		int num = 7;
		int num2 = num;
		string text = default(string);
		string assemblyQualifiedName = default(string);
		while (true)
		{
			switch (num2)
			{
			case 2:
				text = (string)cjLtt6oHSsqqV66Ddk9X(assemblyQualifiedName, text);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				text = (string)qp2p2uoHV9BrYZsnQmVJ(text, 0, JFvE7UoHIQAJtK556K7K(text, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138160520 ^ -2138174024)) + 1);
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
				{
					num2 = 4;
				}
				break;
			case 4:
				assemblyQualifiedName = value.GetType().AssemblyQualifiedName;
				num2 = 3;
				break;
			default:
				return text;
			case 3:
				if (assemblyQualifiedName == null)
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
					{
						num2 = 8;
					}
					break;
				}
				goto case 2;
			case 5:
				return null;
			case 6:
				text = ClassSerializationHelper.SerializeObjectByXml(value);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
				{
					num2 = 1;
				}
				break;
			case 7:
				if (value != null)
				{
					num2 = 6;
					break;
				}
				goto case 5;
			}
		}
	}

	public override object DeserializeSimple(object value, Type deserializeToType)
	{
		int num = 1;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 1:
				text = value as string;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
				{
					num2 = 0;
				}
				break;
			default:
			{
				Type tp = O87gaboHqZUfAvhWo4oi(dxukJ1oHRO0l2PIULuQr(text, 0, JFvE7UoHIQAJtK556K7K(text, EcUZRmoHiC5sLVKy3Lsl(0x2ACE37D ^ 0x2ACACBB))));
				text = (string)qp2p2uoHV9BrYZsnQmVJ(text, 0, text.IndexOf((string)EcUZRmoHiC5sLVKy3Lsl(0x18A6761F ^ 0x18A639D9)));
				StringBuilder stringBuilder = new StringBuilder((string)EcUZRmoHiC5sLVKy3Lsl(-538519530 ^ -538683122));
				Tg0ERIoHKi6c9E5kMMUT(stringBuilder, text);
				string xml = stringBuilder.ToString();
				return ClassSerializationHelper.DeserializeObjectByXml(tp, xml);
			}
			}
		}
	}

	protected override ColumnType GetDbColumnType(EntityMetadata entityMetadata, EntityPropertyMetadata propertyMetadata)
	{
		return new ColumnType(DbType.Binary);
	}

	public XmlSerializableObjectTypeDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static XmlSerializableObjectTypeDescriptor()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			default:
				UID = new Guid((string)EcUZRmoHiC5sLVKy3Lsl(-1765851862 ^ -1765950398));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				cfjRPboHXJe5RIbCxwky();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void RfL6uaoHZv7u33vl7Cnp(object P_0, object P_1, object P_2)
	{
		((SimpleTypeDescriptor<object>)P_0).ExtendSimplePropertyMapping((INHibernatePropertyTypeMapper)P_1, (EntityPropertyMetadata)P_2);
	}

	internal static bool MsIoEioHv4jTCg88S31B()
	{
		return I16KrYoHC7LEnposYXuf == null;
	}

	internal static XmlSerializableObjectTypeDescriptor lCmSsPoH84ycEnV4lLEw()
	{
		return I16KrYoHC7LEnposYXuf;
	}

	internal static object KiPPFUoHukbZjA2tY8QT(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static int JFvE7UoHIQAJtK556K7K(object P_0, object P_1)
	{
		return ((string)P_0).IndexOf((string)P_1);
	}

	internal static object qp2p2uoHV9BrYZsnQmVJ(object P_0, int P_1, int P_2)
	{
		return ((string)P_0).Remove(P_1, P_2);
	}

	internal static object cjLtt6oHSsqqV66Ddk9X(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object EcUZRmoHiC5sLVKy3Lsl(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object dxukJ1oHRO0l2PIULuQr(object P_0, int P_1, int P_2)
	{
		return ((string)P_0).Substring(P_1, P_2);
	}

	internal static Type O87gaboHqZUfAvhWo4oi(object P_0)
	{
		return Type.GetType((string)P_0);
	}

	internal static object Tg0ERIoHKi6c9E5kMMUT(object P_0, object P_1)
	{
		return ((StringBuilder)P_0).AppendLine((string)P_1);
	}

	internal static void cfjRPboHXJe5RIbCxwky()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
