using System;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Enums;
using EleWise.ELMA.Model.Mappings;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Metadata;

[Serializable]
[ClassMap(typeof(EntityPropertyMetadataMap))]
[EleWise.ELMA.Model.Attributes.DisplayName(typeof(EntityPropertyMetadata_Resources), "DisplayName")]
[MetadataType(typeof(EntityMetadata))]
[Entity("MD_ENTITY_PROPERTY")]
[DataContract]
[Uid("{D5B79720-FBBF-489B-9AA6-49E1C5DA50E4}")]
public class EntityPropertyMetadata : PropertyMetadata, IEntityPropertyMetadata, IPropertyMetadata, INamedMetadata, IOrderedMetadata, IMetadata, IXsiType, IValidatableMetadata
{
	public const string UID_S = "{D5B79720-FBBF-489B-9AA6-49E1C5DA50E4}";

	private static EntityPropertyMetadata noFdjybmjw4SJfjJBXHI;

	[Uid("{787F7299-01F7-4075-9BDB-6AA1039FEF51}")]
	[EntitySettings(RelationType = RelationType.OneToOne, FieldName = "OwnerId")]
	[XmlIgnore]
	[EntityProperty]
	[Property("{72ED98CA-F260-4671-9BCD-FF1D80235F47}", "{C40FD1D3-F5D9-4323-9E51-42EBFA77E6DC}")]
	public virtual EntityMetadata Owner
	{
		[CompilerGenerated]
		get
		{
			return _003COwner_003Ek__BackingField;
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
					_003COwner_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
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

	[Uid("{CFA9D44F-A49E-42D5-BA31-70D4A31B2EB8}")]
	[Property("{9CD56A40-6192-4D8A-840C-C4BD4DFB88EB}")]
	[XmlElement("InFastSearch")]
	[EntityProperty]
	[BoolSettings(FieldName = "InFastSearch")]
	[DataMember]
	[DefaultValue(false)]
	public virtual bool InFastSearch
	{
		[CompilerGenerated]
		get
		{
			return _003CInFastSearch_003Ek__BackingField;
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
					_003CInFastSearch_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DefaultValue(false)]
	[DataMember]
	[EntityProperty]
	[Uid("{B7D9B398-4053-44F9-B85A-753A3A56A612}")]
	[XmlElement("ShowInTable")]
	[BoolSettings(FieldName = "ShowInTable")]
	[Property("{9CD56A40-6192-4D8A-840C-C4BD4DFB88EB}")]
	public virtual bool ShowInTable
	{
		[CompilerGenerated]
		get
		{
			return _003CShowInTable_003Ek__BackingField;
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
					_003CShowInTable_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
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

	[DefaultValue(false)]
	[XmlElement("Input")]
	[BoolSettings(FieldName = "Input")]
	[Property("{9CD56A40-6192-4D8A-840C-C4BD4DFB88EB}")]
	[Uid("{2C8A643A-B745-407A-95A5-482D6A00E205}")]
	[EntityProperty]
	public virtual bool Input
	{
		[CompilerGenerated]
		get
		{
			return _003CInput_003Ek__BackingField;
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
					_003CInput_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
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

	[EntityProperty]
	[DefaultValue(false)]
	[BoolSettings(FieldName = "Output")]
	[Property("{9CD56A40-6192-4D8A-840C-C4BD4DFB88EB}")]
	[Uid("{C2CF1D4F-9E1F-4FBA-9B1D-8341960F4794}")]
	[XmlElement("Output")]
	public virtual bool Output
	{
		[CompilerGenerated]
		get
		{
			return _003COutput_003Ek__BackingField;
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
					_003COutput_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[EntityProperty]
	[PublicationBehaviour(PublicationType.Restart)]
	[DefaultValue(0)]
	[Int32Settings(FieldName = "TableNumber")]
	[Uid("{4C3A170A-7EBC-4204-AFC6-1F6633FB5EFA}")]
	[Property("{C1D5FC22-B8ED-4CFA-8029-82EC19E17B7F}")]
	[XmlElement("TableNumber")]
	public virtual int TableNumber
	{
		[CompilerGenerated]
		get
		{
			return _003CTableNumber_003Ek__BackingField;
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
					_003CTableNumber_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[XmlElement("Filterable")]
	[Uid("{4A355272-B6F2-46D8-ACCA-2AB0E27453D9}")]
	[PublicationBehaviour(typeof(EntityPropertyFilterableBehaviour))]
	[DataMember]
	[Property("{9CD56A40-6192-4D8A-840C-C4BD4DFB88EB}")]
	[BoolSettings(FieldName = "Filterable")]
	[EntityProperty]
	[DefaultValue(false)]
	public virtual bool Filterable
	{
		[CompilerGenerated]
		get
		{
			return _003CFilterable_003Ek__BackingField;
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
					_003CFilterable_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
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

	[EntityProperty]
	[DefaultValue(null)]
	[Uid("{2344839C-8F49-4B60-B0D1-4D1E4E9B03FA}")]
	[XmlIgnore]
	[StringSettings(MaxValueString = "2000", FieldName = "RelationTableName")]
	[Property("{9B9AAC17-22BB-425C-AA93-9C02C5146965}")]
	public virtual string RelationTableName
	{
		get
		{
			//Discarded unreachable code: IL_0046, IL_0055
			int num = 2;
			EntitySettings entitySettings = default(EntitySettings);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 1:
						if (entitySettings != null)
						{
							goto end_IL_0012;
						}
						goto default;
					default:
						return null;
					case 3:
						return (string)voWDyHbmUyUZQRGVUCGV(entitySettings);
					case 2:
						entitySettings = Settings as EntitySettings;
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
						{
							num2 = 1;
						}
						break;
					}
					continue;
					end_IL_0012:
					break;
				}
				num = 3;
			}
		}
		set
		{
		}
	}

	[XmlIgnore]
	public virtual SimpleTypeSettings SimpleTypeSettings => (SimpleTypeSettings)Settings;

	public virtual string GetTableName(EntityMetadata entityMetadata)
	{
		return GetTableName((string)Ie9timbmshZ84hZF4KTP(entityMetadata), wmpkhBbmcSgRqB20y1nL(this));
	}

	public static string GetTableName(string tableName, int tableNumber)
	{
		return (string)oDI9pqbyB0xNRCd8vk5s(tableName, (tableNumber > 0) ? v0HBFUbyFw3sU7ZJSsIg(EReq5XbmzhdAqY4RkA1F(-87337865 ^ -87336947), tableNumber) : "");
	}

	public virtual MetadataItemValidationError[] Validate()
	{
		//Discarded unreachable code: IL_0094
		int num = 1;
		int num2 = num;
		IValidatableTypeDescriptor validatableTypeDescriptor = default(IValidatableTypeDescriptor);
		while (true)
		{
			switch (num2)
			{
			case 1:
				validatableTypeDescriptor = MetadataServiceContext.Service.GetTypeDescriptor(FGTAl9byWCFYhv2ON7Mf(this), K5hUGPbyo6SyCsuVGqsg(this)) as IValidatableTypeDescriptor;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				return null;
			case 2:
				return (MetadataItemValidationError[])qgCvijbybK5tilopwS7u(validatableTypeDescriptor, this);
			default:
				if (validatableTypeDescriptor != null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			}
		}
	}

	public override void LoadFromPropertyInfo(PropertyInfo propertyInfo, PropertyMetadata filterTargetPropertyMetadata)
	{
		//Discarded unreachable code: IL_00f2, IL_0101
		int num = 9;
		int num2 = num;
		EntityPropertyAttribute attribute3 = default(EntityPropertyAttribute);
		FilterableAttribute attribute6 = default(FilterableAttribute);
		OutputAttribute attribute = default(OutputAttribute);
		ShowInTableAttribute attribute2 = default(ShowInTableAttribute);
		InputAttribute attribute4 = default(InputAttribute);
		FastSearchAttribute attribute5 = default(FastSearchAttribute);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 3:
				attribute3 = AttributeHelper<EntityPropertyAttribute>.GetAttribute(propertyInfo, inherited: true);
				num2 = 2;
				break;
			case 13:
				opkNdwbySXP5EeQjikWC(this, jr9fu4byVeGN3xKebX0A(attribute3));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
				{
					num2 = 0;
				}
				break;
			case 9:
				base.LoadFromPropertyInfo(propertyInfo, filterTargetPropertyMetadata);
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
				{
					num2 = 8;
				}
				break;
			case 10:
				attribute6 = AttributeHelper<FilterableAttribute>.GetAttribute(propertyInfo, inherited: true);
				num2 = 10;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
				{
					num2 = 15;
				}
				break;
			case 2:
				if (attribute3 == null)
				{
					num2 = 14;
					break;
				}
				goto case 13;
			case 0:
				return;
			case 14:
				return;
			case 11:
				attribute = AttributeHelper<OutputAttribute>.GetAttribute(propertyInfo, inherited: true);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				attribute2 = AttributeHelper<ShowInTableAttribute>.GetAttribute(propertyInfo, inherited: true);
				num2 = 6;
				break;
			case 12:
				attribute4 = AttributeHelper<InputAttribute>.GetAttribute(propertyInfo, inherited: true);
				num2 = 4;
				break;
			case 8:
				attribute5 = AttributeHelper<FastSearchAttribute>.GetAttribute(propertyInfo, inherited: true);
				num2 = 7;
				break;
			case 7:
				InFastSearch = ((attribute5 != null) ? vwtVQMbyGoBJptBjl5X3(attribute5) : chIl3PbyhOEvikhwjIKT(this));
				num2 = 5;
				break;
			case 6:
				WrCtJ5byQf7yn6f0ehyP(this, (attribute2 != null) ? NYNfa7byflSKM7FcDk1w(attribute2) : LDncGRbyEujnAIbsNZ8Z(this));
				num2 = 10;
				break;
			case 15:
				O9iAOqbyvfn8suDJpXZx(this, attribute6 != null && mspm0PbyCpyKn7oGoJKB(attribute6));
				num2 = 11;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
				{
					num2 = 12;
				}
				break;
			case 4:
				KH6KiTbyZ0AKiA6HhBJv(this, attribute4 != null && vMGvA2by8XWMuPUqtta3(attribute4));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
				{
					num2 = 11;
				}
				break;
			case 1:
				QKOhjSbyItd8lBPWSchH(this, attribute != null && Lsajn8byua9vorkJ0VmS(attribute));
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public EntityPropertyMetadata()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool Tsi8IZbmYcAcIw5uZ0Kc()
	{
		return noFdjybmjw4SJfjJBXHI == null;
	}

	internal static EntityPropertyMetadata Q9s9vKbmLthVhXdTGx4A()
	{
		return noFdjybmjw4SJfjJBXHI;
	}

	internal static object voWDyHbmUyUZQRGVUCGV(object P_0)
	{
		return ((EntitySettings)P_0).RelationTableName;
	}

	internal static object Ie9timbmshZ84hZF4KTP(object P_0)
	{
		return ((EntityMetadata)P_0).TableName;
	}

	internal static int wmpkhBbmcSgRqB20y1nL(object P_0)
	{
		return ((EntityPropertyMetadata)P_0).TableNumber;
	}

	internal static object EReq5XbmzhdAqY4RkA1F(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object v0HBFUbyFw3sU7ZJSsIg(object P_0, object P_1)
	{
		return string.Concat(P_0, P_1);
	}

	internal static object oDI9pqbyB0xNRCd8vk5s(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static Guid FGTAl9byWCFYhv2ON7Mf(object P_0)
	{
		return ((PropertyMetadata)P_0).TypeUid;
	}

	internal static Guid K5hUGPbyo6SyCsuVGqsg(object P_0)
	{
		return ((PropertyMetadata)P_0).SubTypeUid;
	}

	internal static object qgCvijbybK5tilopwS7u(object P_0, object P_1)
	{
		return ((IValidatableTypeDescriptor)P_0).Validate((IPropertyMetadata)P_1);
	}

	internal static bool chIl3PbyhOEvikhwjIKT(object P_0)
	{
		return ((EntityPropertyMetadata)P_0).InFastSearch;
	}

	internal static bool vwtVQMbyGoBJptBjl5X3(object P_0)
	{
		return ((FastSearchAttribute)P_0).Value;
	}

	internal static bool LDncGRbyEujnAIbsNZ8Z(object P_0)
	{
		return ((EntityPropertyMetadata)P_0).ShowInTable;
	}

	internal static bool NYNfa7byflSKM7FcDk1w(object P_0)
	{
		return ((ShowInTableAttribute)P_0).Value;
	}

	internal static void WrCtJ5byQf7yn6f0ehyP(object P_0, bool value)
	{
		((EntityPropertyMetadata)P_0).ShowInTable = value;
	}

	internal static bool mspm0PbyCpyKn7oGoJKB(object P_0)
	{
		return ((FilterableAttribute)P_0).Filterable;
	}

	internal static void O9iAOqbyvfn8suDJpXZx(object P_0, bool value)
	{
		((EntityPropertyMetadata)P_0).Filterable = value;
	}

	internal static bool vMGvA2by8XWMuPUqtta3(object P_0)
	{
		return ((InputAttribute)P_0).Value;
	}

	internal static void KH6KiTbyZ0AKiA6HhBJv(object P_0, bool value)
	{
		((EntityPropertyMetadata)P_0).Input = value;
	}

	internal static bool Lsajn8byua9vorkJ0VmS(object P_0)
	{
		return ((OutputAttribute)P_0).Value;
	}

	internal static void QKOhjSbyItd8lBPWSchH(object P_0, bool value)
	{
		((EntityPropertyMetadata)P_0).Output = value;
	}

	internal static int jr9fu4byVeGN3xKebX0A(object P_0)
	{
		return ((EntityPropertyAttribute)P_0).TableNumber;
	}

	internal static void opkNdwbySXP5EeQjikWC(object P_0, int value)
	{
		((EntityPropertyMetadata)P_0).TableNumber = value;
	}
}
