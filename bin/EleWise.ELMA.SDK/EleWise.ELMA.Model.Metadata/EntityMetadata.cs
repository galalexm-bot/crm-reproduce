using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using EleWise.ELMA.Common;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Enums;
using EleWise.ELMA.Model.Mappings;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Metadata.PublicationBehaviours;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Metadata;
using Iesi.Collections.Generic;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Metadata;

[Serializable]
[ClassMap(typeof(EntityMetadataMap))]
[EleWise.ELMA.Model.Attributes.DisplayName(typeof(EntityMetadata_Resources), "DisplayName")]
[Entity("MD_ENTITY")]
[DataContract]
[XmlRoot("Entity")]
[MetadataType(typeof(EntityMetadata))]
[AllowCreateHeirs(true)]
[Uid("{C40FD1D3-F5D9-4323-9E51-42EBFA77E6DC}")]
public class EntityMetadata : ClassMetadata, IEntityMetadata, IRootMetadata, IMetadata, IXsiType, ICodeItemMetadata, IGroupedMetadata, ICompositeMetadata, IEntityCatalog, IEntityIdentifier, ITablePartContainer, IDeltaRootMetadata
{
	[Component]
	private class Info : IMetadataTypeInfo
	{
		internal static object NCLwuYCAtYOGNCT0ixnW;

		public string Name => (string)c9oyEDCA6iooNYua68iP(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3630F361 ^ 0x3635E797));

		public string Description => (string)c9oyEDCA6iooNYua68iP(z745QuCAHFmEVm25HC1J(-2099751081 ^ -2099382171));

		public Type MetadataType => eRtlTYCAAZIupB8y7hZA(typeof(EntityMetadata).TypeHandle);

		public Type GeneratorType => eRtlTYCAAZIupB8y7hZA(typeof(WrapperEntityGenerator).TypeHandle);

		public Info()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			XT3IMcCA7HvTJStUSmhR();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static object c9oyEDCA6iooNYua68iP(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static bool UFtNTeCAwuv5ebc0Misa()
		{
			return NCLwuYCAtYOGNCT0ixnW == null;
		}

		internal static Info q4Cd0dCA4NbrbYvIv39U()
		{
			return (Info)NCLwuYCAtYOGNCT0ixnW;
		}

		internal static object z745QuCAHFmEVm25HC1J(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static Type eRtlTYCAAZIupB8y7hZA(RuntimeTypeHandle P_0)
		{
			return System.Type.GetTypeFromHandle(P_0);
		}

		internal static void XT3IMcCA7HvTJStUSmhR()
		{
			SingletonReader.JJCZtPuTvSt();
		}
	}

	public static readonly Guid UID;

	public const string PARENT_PROPERTY_NAME = "Parent";

	public const string ISGROUP_PROPERTY_NAME = "IsGroup";

	public const string TYPEUID_PROPERTY_NAME = "TypeUid";

	public const string UID_S = "{C40FD1D3-F5D9-4323-9E51-42EBFA77E6DC}";

	public const int MAX_TABLE_NAME_LENGTH = 28;

	public const string ModelPropertyName = "Model";

	public const string ViewModelContext = "ViewModelContext";

	[NonSerialized]
	private ISet<EntityPropertyMetadata> entityProperties;

	[NonSerialized]
	private ISet<TablePartMetadata> entityTableParts;

	private EntityMetadataType _type;

	private List<TablePartMetadata> tableParts;

	[NonSerialized]
	private IEnumerator<TablePartMetadata> tablePartsEnumerator;

	private static EntityMetadata eFWmq3b9FDeoybGQB57N;

	[PublicationBehaviour(PublicationType.Restart)]
	[DefaultValue(EntityMetadataType.Entity)]
	[DataMember]
	public virtual EntityMetadataType Type
	{
		get
		{
			return _type;
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					OnTypeChanged();
					num2 = 4;
					continue;
				case 1:
					if (value == EntityMetadataType.InterfaceImplementation)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				case 3:
					N11SS9b9oURMEiShgfm2(this, null);
					num2 = 5;
					continue;
				default:
					if (_type != EntityMetadataType.InterfaceImplementation)
					{
						num2 = 3;
						continue;
					}
					break;
				case 4:
					return;
				case 5:
					break;
				}
				_type = value;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
				{
					num2 = 2;
				}
			}
		}
	}

	[PublicationBehaviour(PublicationType.Restart)]
	[DataMember]
	public virtual Guid ImplementationUid
	{
		[CompilerGenerated]
		get
		{
			return _003CImplementationUid_003Ek__BackingField;
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
					_003CImplementationUid_003Ek__BackingField = value;
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

	[DefaultValue(true)]
	[PublicationBehaviour(PublicationType.Restart)]
	[DataMember]
	[XmlElement("IsUnique")]
	public virtual bool IsUnique
	{
		[CompilerGenerated]
		get
		{
			return _003CIsUnique_003Ek__BackingField;
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
					_003CIsUnique_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
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

	[XmlElement("IdTypeUid")]
	[DataMember]
	[PublicationBehaviour(PublicationType.Restart)]
	public virtual Guid IdTypeUid
	{
		[CompilerGenerated]
		get
		{
			return _003CIdTypeUid_003Ek__BackingField;
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
					_003CIdTypeUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
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

	[PublicationBehaviour(PublicationType.Restart)]
	[DataMember]
	[StringSettings(MaxValueString = "2000", FieldName = "TableName")]
	[EntityProperty]
	[Property("{9B9AAC17-22BB-425C-AA93-9C02C5146965}")]
	[Uid("{7FC83360-EC31-4E35-9694-4A9F136DC6E0}")]
	[XmlElement("TableName")]
	public virtual string TableName
	{
		[CompilerGenerated]
		get
		{
			return _003CTableName_003Ek__BackingField;
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
					_003CTableName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[EntityProperty]
	[DefaultValue(0)]
	[PublicationBehaviour(PublicationType.Restart)]
	[Int16Settings(FieldName = "LastTableNumber")]
	[XmlElement("LastTableNumber")]
	[Uid("{A4CDAFD6-38C0-4793-ABF6-B3D923EB2A59}")]
	[Property("{C1D5FC22-B8ED-4CFA-8029-82EC19E17B7F}")]
	[DataMember]
	public virtual short LastTableNumber
	{
		[CompilerGenerated]
		get
		{
			return _003CLastTableNumber_003Ek__BackingField;
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
					_003CLastTableNumber_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[XmlElement("IsSoftDeletable")]
	[DataMember]
	[PublicationBehaviour(PublicationType.Restart)]
	public virtual bool IsSoftDeletable
	{
		[CompilerGenerated]
		get
		{
			return _003CIsSoftDeletable_003Ek__BackingField;
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
					_003CIsSoftDeletable_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[XmlElement("SaveHistory")]
	[DataMember]
	[DefaultValue(false)]
	[PublicationBehaviour(PublicationType.Restart)]
	public virtual bool SaveHistory
	{
		[CompilerGenerated]
		get
		{
			return _003CSaveHistory_003Ek__BackingField;
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
					_003CSaveHistory_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DefaultValue(CopyAction.Default)]
	[XmlElement("CopyAction")]
	[Property("{849C1AC9-4D46-4194-8CBB-43F84ADF9C17}", "ded50eaa-8f9d-4457-b083-60b8b721705b")]
	[EnumSettings(FieldName = "CopyAction")]
	public virtual CopyAction CopyAction
	{
		[CompilerGenerated]
		get
		{
			return _003CCopyAction_003Ek__BackingField;
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
					_003CCopyAction_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
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

	[XmlElement("CacheEntity")]
	[EntityProperty]
	[DefaultValue(false)]
	[PublicationBehaviour(PublicationType.Restart)]
	[Uid("{A975D52C-D261-4AE4-8013-097A97A4EA62}")]
	[Property("{9CD56A40-6192-4D8A-840C-C4BD4DFB88EB}")]
	[BoolSettings(FieldName = "CacheEntity")]
	public virtual bool CacheEntity
	{
		[CompilerGenerated]
		get
		{
			return _003CCacheEntity_003Ek__BackingField;
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
					_003CCacheEntity_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
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

	[XmlElement("ShowInCatalogList")]
	[DefaultValue(false)]
	[DataMember]
	[EntityProperty]
	[Uid("{FBC0B869-468A-4BE3-B49E-6789072C93D2}")]
	[Property("{9CD56A40-6192-4D8A-840C-C4BD4DFB88EB}")]
	[BoolSettings(FieldName = "ShowInCatalogList")]
	public virtual bool ShowInCatalogList
	{
		[CompilerGenerated]
		get
		{
			return _003CShowInCatalogList_003Ek__BackingField;
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
					_003CShowInCatalogList_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[EntityProperty]
	[BoolSettings(FieldName = "Filterable")]
	[Property("{9CD56A40-6192-4D8A-840C-C4BD4DFB88EB}")]
	[DefaultValue(false)]
	[Uid("{D450CAC0-1DBB-4965-A3F5-35827F29BD98}")]
	[XmlElement("Filterable")]
	[PublicationBehaviour(PublicationType.Delta)]
	[DataMember]
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
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

	[DefaultValue(null)]
	[XmlElement("FilterImplementedInterfaces")]
	[PublicationBehaviour(PublicationType.Restart)]
	public virtual List<string> FilterImplementedInterfaces { get; set; }

	[BoolSettings(FieldName = "Hierarchical")]
	[Property("{9CD56A40-6192-4D8A-840C-C4BD4DFB88EB}")]
	[EntityProperty]
	[DataMember]
	[PublicationBehaviour(PublicationType.Restart)]
	[DefaultValue(false)]
	[XmlElement("Hierarchical")]
	[Uid("{4116F9CD-D92E-4387-93F5-456C92734EC4}")]
	public virtual bool Hierarchical
	{
		[CompilerGenerated]
		get
		{
			return _003CHierarchical_003Ek__BackingField;
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
					_003CHierarchical_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
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

	[XmlElement("HierarchyType")]
	[Property("{849C1AC9-4D46-4194-8CBB-43F84ADF9C17}", "6bca7871-a483-4db7-bbbe-1ba839df0cbc")]
	[EnumSettings(FieldName = "HierarchyType")]
	[EntityProperty]
	[PublicationBehaviour(PublicationType.Restart)]
	[DataMember]
	[Uid("{5CBF580D-FE24-4B6C-958B-F6D24ECC1EEA}")]
	[DefaultValue(HierarchyType.GroupAndElements)]
	public virtual HierarchyType HierarchyType
	{
		[CompilerGenerated]
		get
		{
			return _003CHierarchyType_003Ek__BackingField;
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
					_003CHierarchyType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
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
	[DataMember]
	[GuidSettings(FieldName = "ParentPropertyUid")]
	[Uid("{BDF533BF-936B-4C9F-BBF1-C28FEBA32CAD}")]
	[XmlElement("ParentPropertyUid")]
	[Property("{EB6E8DDC-FAFE-4E0E-9018-1A7667012579}")]
	public virtual Guid ParentPropertyUid
	{
		[CompilerGenerated]
		get
		{
			return _003CParentPropertyUid_003Ek__BackingField;
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
					_003CParentPropertyUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
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

	[BoolSettings(FieldName = "HideChildItemsTab")]
	[DefaultValue(false)]
	[DataMember]
	[Uid("{EA3218DA-7028-4FD8-83A9-D1023A73F025}")]
	[XmlElement("HideChildItemsTab")]
	[Property("{9CD56A40-6192-4D8A-840C-C4BD4DFB88EB}")]
	public virtual bool HideChildItemsTab
	{
		[CompilerGenerated]
		get
		{
			return _003CHideChildItemsTab_003Ek__BackingField;
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
					_003CHideChildItemsTab_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
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

	[GuidSettings(FieldName = "IsGroupPropertyUid")]
	[EntityProperty]
	[PublicationBehaviour(PublicationType.Restart)]
	[Property("{EB6E8DDC-FAFE-4E0E-9018-1A7667012579}")]
	[Uid("{F41506A0-0103-4377-9A22-71DB6F8D15B7}")]
	[DataMember]
	[XmlElement("IsGroupPropertyUid")]
	public virtual Guid IsGroupPropertyUid
	{
		[CompilerGenerated]
		get
		{
			return _003CIsGroupPropertyUid_003Ek__BackingField;
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
					_003CIsGroupPropertyUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
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

	[PublicationBehaviour(PublicationType.Delta)]
	public virtual EntityFilterMetadata Filter
	{
		[CompilerGenerated]
		get
		{
			return _003CFilter_003Ek__BackingField;
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
					_003CFilter_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[PublicationBehaviour(PublicationType.Restart)]
	public virtual List<Guid> ImplementedExtensionUids { get; set; }

	[DefaultValue("")]
	[XmlElement("PermissionsPropertyName")]
	[DataMember]
	[Uid("{80C9EB2E-A795-4249-AC27-0B05100E4380}")]
	[Property("{9B9AAC17-22BB-425C-AA93-9C02C5146965}")]
	[StringSettings(FieldName = "PermissionsPropertyName")]
	public virtual string PermissionsPropertyName
	{
		[CompilerGenerated]
		get
		{
			return _003CPermissionsPropertyName_003Ek__BackingField;
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
					_003CPermissionsPropertyName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
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

	[DataMember]
	[PublicationBehaviour(PublicationType.Restart)]
	[DefaultValue(false)]
	[XmlElement("InstancePermissionsSupport")]
	[Property("{9CD56A40-6192-4D8A-840C-C4BD4DFB88EB}")]
	[Uid("{C0705251-9EF6-47FD-A6C4-3CA0DAF0E6BA}")]
	[BoolSettings(FieldName = "InstancePermissionsSupport")]
	public virtual bool InstancePermissionsSupport
	{
		[CompilerGenerated]
		get
		{
			return _003CInstancePermissionsSupport_003Ek__BackingField;
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
					_003CInstancePermissionsSupport_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
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

	[DefaultValue("")]
	[StringSettings(FieldName = "PermissionsMetadataName")]
	[DataMember]
	[XmlElement("PermissionsMetadataName")]
	[Uid("{B7087D28-5FBD-4535-984E-D9B2A62D9320}")]
	[Property("{9B9AAC17-22BB-425C-AA93-9C02C5146965}")]
	public virtual string PermissionsMetadataName
	{
		[CompilerGenerated]
		get
		{
			return _003CPermissionsMetadataName_003Ek__BackingField;
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
					_003CPermissionsMetadataName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
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

	[PublicationBehaviour(PublicationType.Restart)]
	public virtual EntityActionsMetadata Actions
	{
		[CompilerGenerated]
		get
		{
			return _003CActions_003Ek__BackingField;
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
					_003CActions_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
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

	[XmlArray("TableParts")]
	[Uid("{CD1CBFBE-B671-444A-AFA4-D45FE4BEC966}")]
	[PublicationBehaviour(typeof(NotRestartIfCollectionItemAddBehaviour))]
	public virtual List<TablePartMetadata> TableParts
	{
		get
		{
			try
			{
				(tablePartsEnumerator ?? (tablePartsEnumerator = tableParts?.GetEnumerator()))?.Reset();
			}
			catch (InvalidOperationException)
			{
				tableParts.ForEach(delegate(TablePartMetadata p)
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
							p.Namespace = (string)y54tYUb9HRDqD1yuI3TS(this);
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
							{
								num2 = 0;
							}
							break;
						case 0:
							return;
						}
					}
				});
				tablePartsEnumerator = tableParts.GetEnumerator();
			}
			return tableParts;
		}
		set
		{
			tableParts = value;
			tableParts?.ForEach(delegate(TablePartMetadata p)
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
						p.Namespace = (string)y54tYUb9HRDqD1yuI3TS(this);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			});
			tablePartsEnumerator = tableParts?.GetEnumerator();
		}
	}

	ICollection<ITablePartMetadata> ITablePartContainer.TableParts
	{
		get
		{
			return TableParts.Cast<ITablePartMetadata>().ToList();
		}
		set
		{
			TableParts = value.Cast<TablePartMetadata>().ToList();
		}
	}

	[Uid("{C4B53CE9-1697-4F72-A154-096885069AD1}")]
	[XmlSerializableObjectSettings(FieldName = "ViewModelMetadata")]
	[Property("{66C7898B-E56B-49E0-BFB8-9F9C4A7A0C52}")]
	[XmlElement("ViewModelMetadata")]
	[EntityProperty]
	public virtual DataClassMetadata ViewModelMetadata
	{
		[CompilerGenerated]
		get
		{
			return _003CViewModelMetadata_003Ek__BackingField;
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
					_003CViewModelMetadata_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public override bool IsInterfaceType
	{
		get
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (Type != EntityMetadataType.Interface)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
						{
							num2 = 0;
						}
						break;
					}
					return true;
				default:
					return u9181Tb9uKSltlGfBVHS(this) == EntityMetadataType.InterfaceExtension;
				}
			}
		}
	}

	public override string TypeName
	{
		get
		{
			//Discarded unreachable code: IL_002d, IL_003c, IL_005c
			int num = 2;
			int num2 = num;
			string text;
			while (true)
			{
				switch (num2)
				{
				default:
					text = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1876063057 ^ -1875938711);
					break;
				case 2:
					if (!MwvFZob9IeSSvNL1DMg8(this))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto default;
				case 1:
					text = string.Empty;
					break;
				}
				break;
			}
			return (string)PHyYiEb9SSaAJUBVCAYB(text, L0eoFnb9VOa5jPxqCHeG(this));
		}
	}

	[XmlIgnore]
	public virtual AssemblyModelsMetadata Assembly
	{
		[CompilerGenerated]
		get
		{
			return _003CAssembly_003Ek__BackingField;
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
					_003CAssembly_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[XmlIgnore]
	public virtual Guid TypeUid
	{
		get
		{
			return UID;
		}
		set
		{
		}
	}

	[Uid("{212818F7-A0C4-40AA-A7EE-EDD40E46A4EB}")]
	[XmlIgnore]
	[EntityProperty]
	[EntitySettings(RelationType = RelationType.OneToMany, KeyColumnUidStr = "{787F7299-01F7-4075-9BDB-6AA1039FEF51}", CascadeMode = CascadeMode.All)]
	[Property("{72ED98CA-F260-4671-9BCD-FF1D80235F47}", "{D5B79720-FBBF-489B-9AA6-49E1C5DA50E4}")]
	public virtual ISet<EntityPropertyMetadata> EntityProperties
	{
		get
		{
			if (entityProperties == null)
			{
				entityProperties = (ISet<EntityPropertyMetadata>)(object)new HashedSet<EntityPropertyMetadata>();
			}
			return entityProperties;
		}
		set
		{
			entityProperties = value;
		}
	}

	[EntitySettings(RelationType = RelationType.OneToMany, KeyColumnUidStr = "{787F7299-01F7-4075-9BDB-6AA1039FEF51}", CascadeMode = CascadeMode.All)]
	[Property("{72ED98CA-F260-4671-9BCD-FF1D80235F47}", "{D5B79720-FBBF-489B-9AA6-49E1C5DA50E4}")]
	[Uid("{22923FDF-4E29-4D56-9DCC-BB294F27BF0C}")]
	[XmlIgnore]
	[EntityProperty]
	public virtual ISet<TablePartMetadata> EntityTableParts
	{
		get
		{
			if (entityTableParts == null)
			{
				entityTableParts = (ISet<TablePartMetadata>)(object)new HashedSet<TablePartMetadata>();
			}
			return entityTableParts;
		}
		set
		{
			entityTableParts = value;
		}
	}

	public override ClassDefaultForms DefaultForms
	{
		get
		{
			//Discarded unreachable code: IL_0076, IL_0085
			int num = 3;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					if (base.DefaultForms != null)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
						{
							num2 = 2;
						}
						break;
					}
					goto case 1;
				case 1:
					cbCwSdbdtHSPulP8HTqR(this);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
					{
						num2 = 0;
					}
					break;
				default:
					return base.DefaultForms;
				}
			}
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
				case 1:
					base.DefaultForms = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
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

	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual bool ShouldSerializeParentPropertyUid()
	{
		return qefXcqb9hAjwEVDPpQRp(lqhap5b9bdMAR1MQaMPm(this), Guid.Empty);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual bool ShouldSerializeIsGroupPropertyUid()
	{
		return qefXcqb9hAjwEVDPpQRp(fXq5Etb9Gah8L83xNNAu(this), Guid.Empty);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual bool ShouldSerializeFilter()
	{
		return PaOtoHb9E3CwqyjLdxE5(this);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual bool ShouldSerializeImplementedExtensionUids()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (ImplementedExtensionUids != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
					{
						num2 = 0;
					}
					break;
				}
				return false;
			default:
				return qBGDwOb9fiX3pH6jfTOG(ImplementedExtensionUids) > 0;
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual bool ShouldSerializeTableParts()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return NBP8txb9QO9i1sO5C5ks(TableParts) > 0;
			case 1:
				if (TableParts == null)
				{
					return false;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public virtual IEnumerable<IPropertyMetadata> GetPropertiesAndTableParts()
	{
		return ContextVars.GetOrAdd(string.Concat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7E6E5A0B ^ 0x7E6CA485), Uid, SR.CurrentLCID), GetPropertiesAndTablePartsWhithoutCache);
	}

	public virtual IEnumerable<IPropertyMetadata> GetPropertiesAndTablePartsWithoutSort()
	{
		return Enumerable.Empty<IPropertyMetadata>().Concat(Properties).Concat(TableParts);
	}

	private void ClearPropertiesAndTablePartsCache()
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
				TOyAxrb9Z8qREYNOj16V(string.Concat(MSCsnub9C12rHGsiMtFQ(-70037984 ^ -70143826), J7Gxqcb9vHIMg9692ytg(this), oadomhb98ijCXwOTXsRE()));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public virtual IEnumerable<IPropertyMetadata> GetPropertiesAndTablePartsWhithoutCache()
	{
		List<IPropertyMetadata> list = new List<IPropertyMetadata>();
		if (Properties != null)
		{
			list.AddRange(Properties);
		}
		if (TableParts != null)
		{
			list.AddRange(TableParts);
		}
		list.Sort(delegate(IPropertyMetadata p1, IPropertyMetadata p2)
		{
			//Discarded unreachable code: IL_00ae, IL_00bd, IL_013e, IL_014d
			int num = 8;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 1:
						return 1;
					case 3:
						return -1;
					case 5:
					case 7:
						if (_003C_003Ec.YWwWWkCA92EAly0P5TJC(p1) == _003C_003Ec.YWwWWkCA92EAly0P5TJC(p2))
						{
							return 0;
						}
						goto end_IL_0012;
					default:
						if (!_003C_003Ec.jk0fmxCAJZA57Rfp8pq8(p1.DeclaringType, null))
						{
							num2 = 6;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
							{
								num2 = 6;
							}
							break;
						}
						goto case 5;
					case 6:
						if (_003C_003Ec.jk0fmxCAJZA57Rfp8pq8(_003C_003Ec.wojuqfCAMDfhKcqU9gqp(p2), null))
						{
							num2 = 5;
							break;
						}
						if (p1.DeclaringType.IsAssignableFrom(_003C_003Ec.wojuqfCAMDfhKcqU9gqp(p2)))
						{
							num2 = 3;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
							{
								num2 = 3;
							}
							break;
						}
						goto case 1;
					case 4:
						return 1;
					case 8:
						if (_003C_003Ec.jk0fmxCAJZA57Rfp8pq8(_003C_003Ec.wojuqfCAMDfhKcqU9gqp(p1), _003C_003Ec.wojuqfCAMDfhKcqU9gqp(p2)))
						{
							num2 = 7;
							break;
						}
						goto default;
					case 2:
						if (p1.Order < _003C_003Ec.YWwWWkCA92EAly0P5TJC(p2))
						{
							return -1;
						}
						num2 = 4;
						break;
					}
					continue;
					end_IL_0012:
					break;
				}
				num = 2;
			}
		});
		return list;
	}

	public virtual IEnumerable<IPropertyMetadata> GetAllPropertiesAndTableParts()
	{
		IEnumerable<TablePartMetadata> allTableParts = GetAllTableParts();
		return Properties.Concat(allTableParts.SelectMany((TablePartMetadata tp) => tp.Properties)).Concat(allTableParts.OfType<IPropertyMetadata>());
	}

	public virtual IEnumerable<TablePartMetadata> GetAllTableParts()
	{
		return TableParts.SelectRecursive((TablePartMetadata tp) => tp.TableParts);
	}

	public virtual IEnumerable<PropertyMetadata> GetAllProperties()
	{
		return Properties.Concat(GetAllTableParts().SelectMany((TablePartMetadata tp) => tp.Properties));
	}

	public override PropertyMetadata CreateProperty(bool initNew = false)
	{
		int num = 1;
		int num2 = num;
		EntityPropertyMetadata entityPropertyMetadata = default(EntityPropertyMetadata);
		while (true)
		{
			switch (num2)
			{
			case 2:
				lPF5ZBb9ifiYo8kCSAXA(entityPropertyMetadata);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
				{
					num2 = 3;
				}
				break;
			case 3:
				return entityPropertyMetadata;
			default:
				if (initNew)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 3;
			case 1:
				entityPropertyMetadata = new EntityPropertyMetadata();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public virtual TablePartMetadata CreateTablePart()
	{
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass132_0 _003C_003Ec__DisplayClass132_ = default(_003C_003Ec__DisplayClass132_0);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return _003C_003Ec__DisplayClass132_.tp;
			case 1:
				_003C_003Ec__DisplayClass132_ = new _003C_003Ec__DisplayClass132_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				lPF5ZBb9ifiYo8kCSAXA(_003C_003Ec__DisplayClass132_.tp);
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				_003C_003Ec__DisplayClass132_.tp.Properties.First(_003C_003Ec__DisplayClass132_._003CCreateTablePart_003Eb__0).SubTypeUid = Uid;
				num2 = 3;
				break;
			default:
				_003C_003Ec__DisplayClass132_.tp = new TablePartMetadata();
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
				{
					num2 = 2;
				}
				break;
			case 4:
				oIgoITb9RViQbgYAReRL(_003C_003Ec__DisplayClass132_.tp, MwvFZob9IeSSvNL1DMg8(this) ? EntityMetadataType.Interface : Type);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public virtual EntityPropertyMetadata CreateUidProperty()
	{
		//Discarded unreachable code: IL_02b8, IL_02c8, IL_0315
		int num = 26;
		EntityPropertyMetadata entityPropertyMetadata = default(EntityPropertyMetadata);
		PropertyMetadata propertyMetadata = default(PropertyMetadata);
		int num4 = default(int);
		int index = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num5;
				switch (num2)
				{
				case 11:
					AWB1Jfb9OTSd0Tm9X2uR(((PropertyViewSettings)yGx9M3b9poYb02kSUB7r(entityPropertyMetadata)).Attributes);
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
					{
						num2 = 3;
					}
					continue;
				case 2:
					g2fiOOb9PyTZjcDlU9Ag(entityPropertyMetadata, b1ufNYb9K4idafNcePoK(MSCsnub9C12rHGsiMtFQ(0x3630F361 ^ 0x363015C5)));
					num2 = 3;
					continue;
				case 10:
					V7Vepwb9nDPbbk7y64VT(entityPropertyMetadata, false);
					num2 = 18;
					continue;
				case 14:
					if (propertyMetadata == null)
					{
						num2 = 15;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
						{
							num2 = 19;
						}
						continue;
					}
					num5 = Properties.IndexOf(propertyMetadata) + 1;
					goto IL_04eb;
				default:
				{
					EntityPropertyMetadata entityPropertyMetadata2 = entityPropertyMetadata;
					GuidSettings guidSettings = new GuidSettings();
					NNeqY5b9Ndm2DB1YGjSx(guidSettings, MSCsnub9C12rHGsiMtFQ(-2107978722 ^ -2107989108));
					vnLabEb93VkFKvrto4Q8(entityPropertyMetadata2, guidSettings);
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
					{
						num2 = 11;
					}
					continue;
				}
				case 7:
				case 22:
					return entityPropertyMetadata;
				case 13:
					Properties.Remove(entityPropertyMetadata);
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
					{
						num2 = 6;
					}
					continue;
				case 1:
				case 17:
					BnubhCb9kbqvLIeQlx1u(entityPropertyMetadata, true);
					num2 = 10;
					continue;
				case 24:
					V7Vepwb9nDPbbk7y64VT(entityPropertyMetadata, false);
					num = 21;
					break;
				case 12:
					BnubhCb9kbqvLIeQlx1u(entityPropertyMetadata, true);
					num2 = 24;
					continue;
				case 16:
					return entityPropertyMetadata;
				case 21:
					entityPropertyMetadata.Name = (string)MSCsnub9C12rHGsiMtFQ(0x3C5338FF ^ 0x3C53576D);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
					{
						num2 = 0;
					}
					continue;
				case 8:
					if (qefXcqb9hAjwEVDPpQRp(hA3Rycb9q2I5RhZxCxYD(entityPropertyMetadata), GuidDescriptor.UID))
					{
						num2 = 23;
						continue;
					}
					if (gYPuP4b9T0mpf93rLLAH(entityPropertyMetadata))
					{
						num2 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 9;
				case 18:
					AWB1Jfb9OTSd0Tm9X2uR(entityPropertyMetadata.ViewSettings.Attributes);
					num2 = 20;
					continue;
				case 25:
					if (entityPropertyMetadata == null)
					{
						entityPropertyMetadata = (EntityPropertyMetadata)CreateProperty(initNew: true);
						num2 = 9;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
						{
							num2 = 12;
						}
					}
					else
					{
						num2 = 8;
					}
					continue;
				case 5:
				{
					List<ViewAttribute> attributes2 = ((PropertyViewSettings)yGx9M3b9poYb02kSUB7r(entityPropertyMetadata)).Attributes;
					ViewAttribute viewAttribute2 = new ViewAttribute();
					fDRrvkb929508rMJxgN0(viewAttribute2, ViewType.All);
					OQqFrWb9ekqUafT8xCPG(viewAttribute2, Visibility.Hidden);
					attributes2.Add(viewAttribute2);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
					{
						num2 = 4;
					}
					continue;
				}
				case 6:
					Properties.Insert(num4, entityPropertyMetadata);
					num2 = 17;
					continue;
				case 19:
					num5 = 0;
					goto IL_04eb;
				case 3:
					w7OViVb91h3XMINgZWZj(entityPropertyMetadata, GuidDescriptor.UID);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
					{
						num2 = 0;
					}
					continue;
				case 15:
					Properties.Insert(index, entityPropertyMetadata);
					num = 16;
					break;
				case 20:
				{
					List<ViewAttribute> attributes = entityPropertyMetadata.ViewSettings.Attributes;
					ViewAttribute viewAttribute = new ViewAttribute();
					fDRrvkb929508rMJxgN0(viewAttribute, ViewType.All);
					OQqFrWb9ekqUafT8xCPG(viewAttribute, Visibility.Hidden);
					attributes.Add(viewAttribute);
					num2 = 22;
					continue;
				}
				case 23:
					throw new MetadataException((string)kCmmwvb9XTupj8fvNH47(SR.T((string)MSCsnub9C12rHGsiMtFQ(-195614443 ^ -195700775)), MSCsnub9C12rHGsiMtFQ(0x49E27B8A ^ 0x49E21418), b1ufNYb9K4idafNcePoK(MSCsnub9C12rHGsiMtFQ(0x57A5235E ^ 0x57A5C5FA))));
				case 26:
					entityPropertyMetadata = (EntityPropertyMetadata)Properties.FirstOrDefault((PropertyMetadata p1) => (string)_003C_003Ec.GGYkN3CAd3wqJB9NGQDp(p1) == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-281842504 ^ -281869526));
					num2 = 25;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
					{
						num2 = 3;
					}
					continue;
				case 9:
				{
					int num3 = Properties.IndexOf(entityPropertyMetadata);
					PropertyMetadata propertyMetadata2 = Properties.LastOrDefault((PropertyMetadata p1) => _003C_003Ec.N6xDBnCAla31u5hR2x1g(p1));
					num4 = ((propertyMetadata2 != null) ? (Properties.IndexOf(propertyMetadata2) + 1) : 0);
					if (num3 <= num4)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 13;
				}
				case 4:
					{
						propertyMetadata = Properties.LastOrDefault((PropertyMetadata p1) => p1.IsSystem);
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
						{
							num2 = 14;
						}
						continue;
					}
					IL_04eb:
					index = num5;
					num2 = 15;
					continue;
				}
				break;
			}
		}
	}

	public new virtual EntityPropertyMetadata GetUidProperty()
	{
		return base.GetUidProperty() as EntityPropertyMetadata;
	}

	public virtual EntityPropertyMetadata CreateParentProperty(bool add = true)
	{
		//Discarded unreachable code: IL_0128, IL_0132, IL_0141, IL_01f7, IL_0206, IL_024c, IL_025b
		int num = 11;
		int num2 = num;
		EntityPropertyMetadata entityPropertyMetadata = default(EntityPropertyMetadata);
		PropertyMetadata propertyMetadata = default(PropertyMetadata);
		int index = default(int);
		while (true)
		{
			int num3;
			switch (num2)
			{
			case 7:
			{
				EntityPropertyMetadata entityPropertyMetadata2 = entityPropertyMetadata;
				EntitySettings entitySettings = new EntitySettings();
				NNeqY5b9Ndm2DB1YGjSx(entitySettings, MSCsnub9C12rHGsiMtFQ(0x20261A4F ^ 0x20268A79));
				vnLabEb93VkFKvrto4Q8(entityPropertyMetadata2, entitySettings);
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
				{
					num2 = 1;
				}
				continue;
			}
			case 11:
				entityPropertyMetadata = (EntityPropertyMetadata)CreateProperty(initNew: true);
				num2 = 10;
				continue;
			case 16:
				entityPropertyMetadata.TypeUid = EntityDescriptor.UID;
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
				{
					num2 = 14;
				}
				continue;
			default:
				cVHUUMb9aSBjpFl1k110(entityPropertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1886646897 ^ -1886609991));
				num2 = 8;
				continue;
			case 2:
				if (propertyMetadata != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 13;
			case 13:
				num3 = 0;
				break;
			case 14:
				rQfP93b9D6GkAtUefhfj(entityPropertyMetadata, Uid);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
				{
					num2 = 7;
				}
				continue;
			case 3:
			case 15:
				return entityPropertyMetadata;
			case 9:
				throw new MetadataException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105199646 ^ -105367370), MSCsnub9C12rHGsiMtFQ(-3333094 ^ -3296212)));
			case 6:
				if (!add)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				goto case 4;
			case 10:
				BnubhCb9kbqvLIeQlx1u(entityPropertyMetadata, true);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
				{
					num2 = 0;
				}
				continue;
			case 8:
				g2fiOOb9PyTZjcDlU9Ag(entityPropertyMetadata, SR.T((string)MSCsnub9C12rHGsiMtFQ(0x5DD55050 ^ 0x5DD7A51E)));
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
				{
					num2 = 16;
				}
				continue;
			case 12:
				Properties.Insert(index, entityPropertyMetadata);
				num2 = 15;
				continue;
			case 5:
				if (Properties.FirstOrDefault((PropertyMetadata p1) => _003C_003Ec.jxorCUCAgFwwYEOdnlSU(p1.Name, _003C_003Ec.cMl811CAr7rfBZp3KZEu(0x12441CA4 ^ 0x12448C92))) == null)
				{
					num2 = 6;
					continue;
				}
				goto case 9;
			case 4:
				propertyMetadata = Properties.LastOrDefault((PropertyMetadata p1) => _003C_003Ec.N6xDBnCAla31u5hR2x1g(p1));
				num2 = 2;
				continue;
			case 1:
				num3 = Properties.IndexOf(propertyMetadata) + 1;
				break;
			}
			index = num3;
			num2 = 12;
		}
	}

	public virtual EntityPropertyMetadata CreateIsGroupProperty(bool add = true)
	{
		//Discarded unreachable code: IL_00a3, IL_0123
		int num = 2;
		EntityPropertyMetadata entityPropertyMetadata = default(EntityPropertyMetadata);
		int index = default(int);
		PropertyMetadata propertyMetadata = default(PropertyMetadata);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num3;
				switch (num2)
				{
				case 11:
					w7OViVb91h3XMINgZWZj(entityPropertyMetadata, BoolDescriptor.UID);
					num2 = 12;
					continue;
				case 7:
				{
					EntityPropertyMetadata entityPropertyMetadata2 = entityPropertyMetadata;
					BoolSettings boolSettings = new BoolSettings();
					NNeqY5b9Ndm2DB1YGjSx(boolSettings, MSCsnub9C12rHGsiMtFQ(0x3C5338FF ^ 0x3C518BEF));
					vnLabEb93VkFKvrto4Q8(entityPropertyMetadata2, boolSettings);
					num = 6;
					break;
				}
				case 1:
					BnubhCb9kbqvLIeQlx1u(entityPropertyMetadata, true);
					num = 4;
					break;
				case 8:
					throw new MetadataException(SR.T((string)MSCsnub9C12rHGsiMtFQ(-2107978722 ^ -2108148918), MSCsnub9C12rHGsiMtFQ(0x3A5D5EF ^ 0x3A766FF)));
				case 3:
					num3 = 0;
					goto IL_028e;
				case 5:
				case 10:
					return entityPropertyMetadata;
				case 2:
					entityPropertyMetadata = (EntityPropertyMetadata)CreateProperty(initNew: true);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
					{
						num2 = 1;
					}
					continue;
				case 14:
					Properties.Insert(index, entityPropertyMetadata);
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
					{
						num2 = 10;
					}
					continue;
				default:
					g2fiOOb9PyTZjcDlU9Ag(entityPropertyMetadata, b1ufNYb9K4idafNcePoK(MSCsnub9C12rHGsiMtFQ(-1822890472 ^ -1822811716)));
					num = 11;
					break;
				case 12:
					V7Vepwb9nDPbbk7y64VT(entityPropertyMetadata, false);
					num2 = 7;
					continue;
				case 9:
					if (propertyMetadata == null)
					{
						num2 = 3;
						continue;
					}
					num3 = Properties.IndexOf(propertyMetadata) + 1;
					goto IL_028e;
				case 4:
					cVHUUMb9aSBjpFl1k110(entityPropertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x638095EB ^ 0x638226FB));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
					{
						num2 = 0;
					}
					continue;
				case 6:
					if (Properties.FirstOrDefault((PropertyMetadata p1) => _003C_003Ec.jxorCUCAgFwwYEOdnlSU(_003C_003Ec.GGYkN3CAd3wqJB9NGQDp(p1), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-345420348 ^ -345243948))) == null)
					{
						if (!add)
						{
							num2 = 5;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
							{
								num2 = 1;
							}
							continue;
						}
						goto case 13;
					}
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
					{
						num2 = 7;
					}
					continue;
				case 13:
					{
						propertyMetadata = Properties.LastOrDefault((PropertyMetadata p1) => p1.IsSystem);
						num2 = 9;
						continue;
					}
					IL_028e:
					index = num3;
					num2 = 14;
					continue;
				}
				break;
			}
		}
	}

	public virtual EntityMetadata CreateInterfaceImplementationMetadata(List<EntityMetadata> extensions = null)
	{
		EntityMetadata entityMetadata = ClassSerializationHelper.CloneObjectByXml(this);
		entityMetadata.Uid = ImplementationUid;
		entityMetadata.ImplementationUid = Uid;
		entityMetadata.Type = EntityMetadataType.InterfaceImplementation;
		ReplaceTablePartImplementationUids(entityMetadata);
		List<PropertyMetadata> properties = entityMetadata.Properties;
		int val = ((properties != null && properties.Count > 0) ? entityMetadata.Properties.Max((PropertyMetadata p) => _003C_003Ec.rwLexwCA5C07smdsMUmj(p)) : 0);
		List<TablePartMetadata> list = entityMetadata.TableParts;
		int num = Math.Max(val, (list != null && list.Count > 0) ? entityMetadata.TableParts.Max((TablePartMetadata p) => p.Order) : 0);
		bool flag = false;
		if (extensions != null && extensions.Count > 0)
		{
			entityMetadata.ImplementedExtensionUids = new List<Guid>();
			foreach (EntityMetadata item in extensions.OrderBy((EntityMetadata e) => e.IsConfig()))
			{
				_003C_003Ec__DisplayClass137_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass137_0();
				entityMetadata.ImplementedExtensionUids.Add(item.Uid);
				CS_0024_003C_003E8__locals2.extCloned = ClassSerializationHelper.CloneObjectByXml(item);
				ReplaceTablePartImplementationUids(CS_0024_003C_003E8__locals2.extCloned, entityMetadata.Namespace);
				if (item.ImplementedInterfaces != null && item.ImplementedInterfaces.Any())
				{
					if (entityMetadata.ImplementedInterfaces == null)
					{
						entityMetadata.ImplementedInterfaces = new List<string>();
					}
					foreach (string implementedInterface in item.ImplementedInterfaces)
					{
						if (!entityMetadata.ImplementedInterfaces.Contains(implementedInterface))
						{
							entityMetadata.ImplementedInterfaces.Add(implementedInterface);
						}
					}
				}
				List<PropertyMetadata> properties2 = CS_0024_003C_003E8__locals2.extCloned.Properties;
				int val2 = ((properties2 != null && properties2.Count > 0) ? CS_0024_003C_003E8__locals2.extCloned.Properties.Min((PropertyMetadata p) => _003C_003Ec.rwLexwCA5C07smdsMUmj(p)) : 0);
				List<TablePartMetadata> list2 = CS_0024_003C_003E8__locals2.extCloned.TableParts;
				int num2 = Math.Min(val2, (list2 != null && list2.Count > 0) ? CS_0024_003C_003E8__locals2.extCloned.TableParts.Min((TablePartMetadata p) => _003C_003Ec.wg1mU8CAjd2WyTJ9U6RM(p)) : 0);
				int num3 = num + 1 - num2;
				foreach (PropertyMetadata item2 in CS_0024_003C_003E8__locals2.extCloned.Properties.EmptyIfNull())
				{
					item2.Order += num3;
					if (item2.Order > num)
					{
						num = item2.Order;
					}
					entityMetadata.Properties.Add(item2);
					flag = true;
				}
				foreach (TablePartMetadata item3 in CS_0024_003C_003E8__locals2.extCloned.TableParts.EmptyIfNull())
				{
					item3.Order += num3;
					if (item3.Order > num)
					{
						num = item3.Order;
					}
					entityMetadata.TableParts.Add(item3);
					flag = true;
				}
				PropertiesHelper initializerCache = AbstractMetadata.GetInitializerCache(typeof(PropertyMetadata));
				foreach (PropertyMetadata property in entityMetadata.Properties)
				{
					_003C_003Ec__DisplayClass137_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass137_1();
					CS_0024_003C_003E8__locals0.prop = property;
					PropertiesContainer propertiesContainer = CS_0024_003C_003E8__locals2.extCloned.PropertiesDiffContainer.FirstOrDefault(delegate(PropertiesContainer c)
					{
						int num4 = 1;
						int num5 = num4;
						while (true)
						{
							switch (num5)
							{
							case 1:
								if (!(c.GetPropertyValue((string)_003C_003Ec__DisplayClass137_1.CbyieQC7IGtJRUC3046f(-35995181 ^ -36000191), null) is string))
								{
									return false;
								}
								num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
								{
									num5 = 0;
								}
								break;
							default:
								return _003C_003Ec__DisplayClass137_1.rjYEGsC7imjgQTudQfdi((string)_003C_003Ec__DisplayClass137_1.OLqYjwC7V0AqqWdlC8cV(c, _003C_003Ec__DisplayClass137_1.CbyieQC7IGtJRUC3046f(-1979251663 ^ -1979225181), null), _003C_003Ec__DisplayClass137_1.O6aVAaC7SdgSaQMLs2Uo(CS_0024_003C_003E8__locals0.prop), StringComparison.OrdinalIgnoreCase);
							}
						}
					});
					if (propertiesContainer != null)
					{
						initializerCache.SetValues(propertiesContainer, property);
					}
				}
				if (CS_0024_003C_003E8__locals2.extCloned.Filterable)
				{
					entityMetadata.Filterable = true;
					if (CS_0024_003C_003E8__locals2.extCloned.Filter != null && CS_0024_003C_003E8__locals2.extCloned.Filter.Properties.Any())
					{
						foreach (PropertyMetadata property2 in CS_0024_003C_003E8__locals2.extCloned.Filter.Properties)
						{
							entityMetadata.Filter.Properties.Add(property2);
						}
					}
				}
				if (CS_0024_003C_003E8__locals2.extCloned.FormViews != null)
				{
					using List<FormView>.Enumerator enumerator6 = CS_0024_003C_003E8__locals2.extCloned.FormViews.GetEnumerator();
					while (enumerator6.MoveNext())
					{
						_003C_003Ec__DisplayClass137_2 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass137_2();
						CS_0024_003C_003E8__locals1.formView = enumerator6.Current;
						FormView formView = entityMetadata.FormViews.FirstOrDefault((FormView v) => _003C_003Ec__DisplayClass137_2.HNw0T9C7TpjoAGTgL9OI(v) == _003C_003Ec__DisplayClass137_2.HNw0T9C7TpjoAGTgL9OI(CS_0024_003C_003E8__locals1.formView));
						if (formView == null)
						{
							continue;
						}
						if (formView.CanUseCommonView)
						{
							formView.ViewInCommon = CS_0024_003C_003E8__locals1.formView.ViewInCommon;
							if (formView.CanUseCommonRazorView)
							{
								formView.UseRazorView = CS_0024_003C_003E8__locals1.formView.UseRazorView;
								formView.UseStandartView = CS_0024_003C_003E8__locals1.formView.UseStandartView;
								formView.RazorCommonViewName = CS_0024_003C_003E8__locals1.formView.RazorCommonViewName;
							}
						}
						if (formView.CanUseTabView)
						{
							formView.ViewInTab = CS_0024_003C_003E8__locals1.formView.ViewInTab;
							formView.ViewInTabName = CS_0024_003C_003E8__locals1.formView.ViewInTabName;
							if (formView.CanUseTabRazorView)
							{
								formView.UseRazorView = CS_0024_003C_003E8__locals1.formView.UseRazorView;
								formView.UseStandartView = CS_0024_003C_003E8__locals1.formView.UseStandartView;
								formView.RazorTabViewName = CS_0024_003C_003E8__locals1.formView.RazorTabViewName;
							}
						}
					}
				}
				if (!string.IsNullOrEmpty(CS_0024_003C_003E8__locals2.extCloned.ScriptModuleTypeName))
				{
					entityMetadata.ScriptModuleTypeName = CS_0024_003C_003E8__locals2.extCloned.ScriptModuleTypeName;
				}
				if (!string.IsNullOrEmpty(CS_0024_003C_003E8__locals2.extCloned.OnViewLoadScriptName))
				{
					entityMetadata.OnViewLoadScriptName = CS_0024_003C_003E8__locals2.extCloned.OnViewLoadScriptName;
				}
				if (CS_0024_003C_003E8__locals2.extCloned.TitlePropertyUid != Guid.Empty && CS_0024_003C_003E8__locals2.extCloned.Properties.Exists((PropertyMetadata p) => _003C_003Ec__DisplayClass137_0.YVtsENC7CjROhEynTUqm(_003C_003Ec__DisplayClass137_0.ddtbWyC7fkoHggm6o63N(p), _003C_003Ec__DisplayClass137_0.jxUNg2C7QIr5y5FVOR4S(CS_0024_003C_003E8__locals2.extCloned))))
				{
					entityMetadata.TitlePropertyUid = CS_0024_003C_003E8__locals2.extCloned.TitlePropertyUid;
				}
				if (CS_0024_003C_003E8__locals2.extCloned.CacheEntity)
				{
					entityMetadata.CacheEntity = true;
				}
				if (!entityMetadata.SaveHistory && CS_0024_003C_003E8__locals2.extCloned.SaveHistory)
				{
					entityMetadata.SaveHistory = true;
				}
			}
		}
		if (entityMetadata.BaseClassUid != Guid.Empty)
		{
			EntityMetadata entityMetadata2 = (EntityMetadata)MetadataServiceContext.Service.GetMetadata(entityMetadata.BaseClassUid);
			if (entityMetadata2 != null)
			{
				entityMetadata.BaseClassUid = entityMetadata2.ImplementationUid;
			}
		}
		entityMetadata.Forms = new List<FormViewItem>();
		entityMetadata.FormTransformations = new List<FormViewItemTransformation>();
		if (flag)
		{
			entityMetadata.ClearPropertiesAndTablePartsCache();
		}
		return entityMetadata;
	}

	public virtual DataClassMetadata CreateViewModelMetadata()
	{
		//Discarded unreachable code: IL_0052, IL_0061
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (ocqdN7b9tuUUs37e14Qy(this) == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				throw new MetadataException(SR.T((string)MSCsnub9C12rHGsiMtFQ(-1921202237 ^ -1921107957)));
			default:
			{
				DataClassMetadata dataClassMetadata = new DataClassMetadata(BHxaGSb9wF2CMrJKn4Lg(this));
				ebwKYKb96UFZbo9eMBEK(dataClassMetadata, Jc5v0Bb94pyOyugernvS());
				cVHUUMb9aSBjpFl1k110(dataClassMetadata, MSCsnub9C12rHGsiMtFQ(0x18A6761F ^ 0x18A4C22B));
				sxyCdbb9AGlPxFTYtSP7(dataClassMetadata, y54tYUb9HRDqD1yuI3TS(this));
				cLFuxub9xymhDZViiMHn(dataClassMetadata, yHx0eDb97ZQdEld1Hf8f(this));
				dataClassMetadata.DisplayName = (string)b1ufNYb9K4idafNcePoK(MSCsnub9C12rHGsiMtFQ(-488881205 ^ -488684561));
				ViewModelPropertyMetadata item = CreateModelProperty();
				dataClassMetadata.Properties.Add(item);
				return dataClassMetadata;
			}
			}
		}
	}

	public override void InitNew()
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				psBHYsb90g78LsEp1ucu(this, Guid.NewGuid());
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				base.InitNew();
				num2 = 2;
				break;
			default:
				TableViews.Add((TableView)OJWLMcb9mWy1T2ai3Kdt(this));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				return;
			}
		}
	}

	public override void AfterLoad()
	{
		//Discarded unreachable code: IL_00a2, IL_00b1, IL_00d7, IL_00e1, IL_0173, IL_0186
		int num = 4;
		int num2 = num;
		List<TablePartMetadata>.Enumerator enumerator = default(List<TablePartMetadata>.Enumerator);
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (!ApXtOSb9MLRuRuyVK86M(LAE7Hpb9y5reETi4PX5l(this), Guid.Empty))
				{
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
					{
						num2 = 6;
					}
					break;
				}
				goto case 6;
			case 2:
				if (u9181Tb9uKSltlGfBVHS(this) != EntityMetadataType.Interface)
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
					{
						num2 = 5;
					}
					break;
				}
				goto default;
			case 6:
				if (IsUnique)
				{
					num2 = 2;
					break;
				}
				goto case 7;
			case 8:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
							{
								num3 = 1;
							}
							goto IL_00e5;
						}
						goto IL_0121;
						IL_0121:
						TrDXsSb99aXcKjIghbY7(enumerator.Current);
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
						{
							num3 = 0;
						}
						goto IL_00e5;
						IL_00e5:
						switch (num3)
						{
						case 2:
							goto IL_0121;
						case 1:
							return;
						}
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
			case 4:
				base.AfterLoad();
				num2 = 3;
				break;
			case 1:
				IkDQXwb9JE7bQi6a0nL8(this);
				num2 = 7;
				break;
			case 5:
				if (u9181Tb9uKSltlGfBVHS(this) == EntityMetadataType.Entity)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 7;
			case 7:
			case 10:
				enumerator = TableParts.GetEnumerator();
				num2 = 8;
				break;
			case 9:
				return;
			default:
				if (!Properties.Any(delegate(PropertyMetadata p)
				{
					//Discarded unreachable code: IL_0052, IL_0061
					int num5 = 1;
					int num6 = num5;
					while (true)
					{
						switch (num6)
						{
						case 1:
							if (!_003C_003Ec.N6xDBnCAla31u5hR2x1g(p))
							{
								num6 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
								{
									num6 = 0;
								}
								break;
							}
							goto case 2;
						case 2:
							return _003C_003Ec.jxorCUCAgFwwYEOdnlSU(p.Name, _003C_003Ec.cMl811CAr7rfBZp3KZEu(-1852837372 ^ -1852858986));
						default:
							return false;
						}
					}
				}))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 7;
			}
		}
	}

	public override void LoadFromType(Type type, bool inherit = true)
	{
		//Discarded unreachable code: IL_02fc, IL_0306, IL_0403, IL_043b, IL_0535, IL_0544, IL_054f, IL_05f8, IL_0630, IL_063f, IL_064e, IL_06cd, IL_0713, IL_076e, IL_077d, IL_0820, IL_085b, IL_087d, IL_088c, IL_08ea, IL_08f9, IL_09f4, IL_0a2c, IL_0acc, IL_0b61, IL_0b70, IL_0d19, IL_0d38, IL_0d47, IL_0d64
		int num = 28;
		FilterTypeAttribute attribute9 = default(FilterTypeAttribute);
		Type type3 = default(Type);
		EntityAttribute entityAttribute = default(EntityAttribute);
		IEnumerable<ImplementAttribute> enumerable = default(IEnumerable<ImplementAttribute>);
		CacheEntityAttribute attribute10 = default(CacheEntityAttribute);
		Type type2 = default(Type);
		NonUniqueAttribute attribute11 = default(NonUniqueAttribute);
		IdTypeAttribute attribute7 = default(IdTypeAttribute);
		InstancePermissionAttribute attribute6 = default(InstancePermissionAttribute);
		IEnumerator<InterfaceImplementationAttribute> enumerator2 = default(IEnumerator<InterfaceImplementationAttribute>);
		object[] array = default(object[]);
		IEnumerator<PropertyInfo> enumerator = default(IEnumerator<PropertyInfo>);
		PropertyMetadata propertyMetadata = default(PropertyMetadata);
		PropertyInfo current = default(PropertyInfo);
		ImplementationUidAttribute attribute2 = default(ImplementationUidAttribute);
		ViewModelMetadataAttribute viewModelMetadataAttribute = default(ViewModelMetadataAttribute);
		IEnumerator<TablePartAttribute> enumerator4 = default(IEnumerator<TablePartAttribute>);
		InterfaceImplementationAttribute current3 = default(InterfaceImplementationAttribute);
		EntityActionsMetadata entityActionsMetadata = default(EntityActionsMetadata);
		HierarchicalAttribute attribute = default(HierarchicalAttribute);
		ActionsTypeAttribute attribute3 = default(ActionsTypeAttribute);
		IEnumerator<ImplementAttribute> enumerator3 = default(IEnumerator<ImplementAttribute>);
		CopyActionAttribute attribute5 = default(CopyActionAttribute);
		EntityMetadataTypeAttribute attribute14 = default(EntityMetadataTypeAttribute);
		ShowInCatalogListAttribute attribute4 = default(ShowInCatalogListAttribute);
		TablePartMetadata tablePartMetadata = default(TablePartMetadata);
		TablePartAttribute current4 = default(TablePartAttribute);
		SaveHistoryAttribute attribute13 = default(SaveHistoryAttribute);
		FilterableAttribute attribute12 = default(FilterableAttribute);
		HideChildItemsTabAttribute attribute8 = default(HideChildItemsTabAttribute);
		ImplementAttribute current2 = default(ImplementAttribute);
		UidAttribute attribute16 = default(UidAttribute);
		EntityMetadataTypeAttribute attribute15 = default(EntityMetadataTypeAttribute);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 4:
				case 29:
					attribute9 = AttributeHelper<FilterTypeAttribute>.GetAttribute(type, inherited: false);
					num2 = 76;
					continue;
				case 44:
					type3 = type;
					num2 = 5;
					continue;
				case 42:
					if (entityAttribute != null)
					{
						num2 = 17;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
						{
							num2 = 13;
						}
						continue;
					}
					goto case 46;
				case 73:
					if (enumerable == null)
					{
						num2 = 35;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
						{
							num2 = 59;
						}
						continue;
					}
					goto case 22;
				case 62:
					attribute10 = AttributeHelper<CacheEntityAttribute>.GetAttribute(type, inherited: true);
					num = 63;
					break;
				case 15:
					type2 = G4ppswbdnRCWxyrbf5li(type3.Assembly, PHyYiEb9SSaAJUBVCAYB(type3.FullName, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-281842504 ^ -281858172)));
					num2 = 62;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
					{
						num2 = 65;
					}
					continue;
				case 52:
					enumerable = type.GetReflectionCustomAttributes(kZ2Y2ub9r2rmNOvWuj99(typeof(ImplementAttribute).TypeHandle), inherit: false).Cast<ImplementAttribute>();
					num2 = 73;
					continue;
				case 33:
					attribute11 = AttributeHelper<NonUniqueAttribute>.GetAttribute(type, inherited: false);
					num2 = 37;
					continue;
				case 72:
					FN7c6fb9lpZKsUEgrGJD(this, bsUXS9b9dZsOW9nvqA6r(attribute7));
					num2 = 39;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
					{
						num2 = 13;
					}
					continue;
				case 37:
					m6CfLsbdBG0hbabpsM4T(this, attribute11 == null);
					num2 = 36;
					continue;
				case 39:
				case 41:
					entityAttribute = (EntityAttribute)type.GetReflectionCustomAttributes(kZ2Y2ub9r2rmNOvWuj99(typeof(EntityAttribute).TypeHandle), inherit: false).FirstOrDefault();
					num2 = 42;
					continue;
				case 40:
					aoUZ2Fbdvk8afxpj32lp(this, GCefPVbdC6XrSZW9WgOk(attribute6));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
					{
						num2 = 7;
					}
					continue;
				case 6:
				case 23:
				case 59:
					type2 = null;
					num2 = 44;
					continue;
				case 25:
					enumerator2 = array.Cast<InterfaceImplementationAttribute>().GetEnumerator();
					num2 = 12;
					continue;
				case 10:
					try
					{
						while (true)
						{
							IL_039f:
							int num3;
							if (!KEZQ1pbdSfnpcdDt0W12(enumerator))
							{
								num3 = 2;
								goto IL_030a;
							}
							goto IL_037c;
							IL_030a:
							while (true)
							{
								switch (num3)
								{
								case 4:
									uHu7aXbdVTG2YB83vSFT(propertyMetadata, current, null);
									num3 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
									{
										num3 = 0;
									}
									continue;
								case 1:
									Filter.Properties.Add(propertyMetadata);
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
									{
										num3 = 0;
									}
									continue;
								case 3:
									break;
								default:
									goto IL_039f;
								case 5:
									propertyMetadata = ((ClassMetadata)HRLsL2bdIi4wO66BKjPO(this)).CreateProperty(initNew: false);
									num3 = 4;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
									{
										num3 = 4;
									}
									continue;
								case 2:
									goto end_IL_039f;
								}
								break;
							}
							goto IL_037c;
							IL_037c:
							current = enumerator.Current;
							num3 = 5;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
							{
								num3 = 5;
							}
							goto IL_030a;
							continue;
							end_IL_039f:
							break;
						}
					}
					finally
					{
						if (enumerator != null)
						{
							int num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
							{
								num4 = 0;
							}
							while (true)
							{
								switch (num4)
								{
								default:
									enumerator.Dispose();
									num4 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
									{
										num4 = 1;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
					}
					goto case 26;
				case 67:
					attribute2 = AttributeHelper<ImplementationUidAttribute>.GetAttribute(type, inherited: true);
					num2 = 51;
					continue;
				case 77:
					zSU12RbdPlp5SdyfTrSC(this, viewModelMetadataAttribute.ViewModelMetadata);
					num2 = 68;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
					{
						num2 = 6;
					}
					continue;
				case 48:
				case 60:
					viewModelMetadataAttribute = type.GetReflectionCustomAttributes(kZ2Y2ub9r2rmNOvWuj99(typeof(ViewModelMetadataAttribute).TypeHandle), inherit: false).Cast<ViewModelMetadataAttribute>().FirstOrDefault();
					num = 38;
					break;
				case 22:
					if (!enumerable.Any())
					{
						num2 = 6;
						continue;
					}
					goto case 57;
				case 53:
					if (array != null)
					{
						num2 = 20;
						continue;
					}
					goto case 48;
				case 34:
					attribute6 = AttributeHelper<InstancePermissionAttribute>.GetAttribute(type, inherited: true);
					num2 = 47;
					continue;
				case 16:
					cVHUUMb9aSBjpFl1k110(this, T1RBaZb9jGqJ9pFHRAUO(L0eoFnb9VOa5jPxqCHeG(this), 1));
					num = 67;
					break;
				case 74:
					enumerator4 = ((IEnumerable)AKn3LabdRWww6uyU8Ydd(type, kZ2Y2ub9r2rmNOvWuj99(typeof(TablePartAttribute).TypeHandle), inherit)).Cast<TablePartAttribute>().GetEnumerator();
					num = 70;
					break;
				case 12:
					try
					{
						while (true)
						{
							int num8;
							if (!enumerator2.MoveNext())
							{
								num8 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
								{
									num8 = 1;
								}
								goto IL_0553;
							}
							goto IL_05af;
							IL_05af:
							current3 = enumerator2.Current;
							num8 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
							{
								num8 = 2;
							}
							goto IL_0553;
							IL_0553:
							while (true)
							{
								switch (num8)
								{
								case 3:
									break;
								case 2:
									FilterImplementedInterfaces.Add((string)lOdcPobde3ox0w7WuctH(current3));
									num8 = 3;
									continue;
								default:
									goto IL_05af;
								case 1:
									goto end_IL_056d;
								}
								break;
							}
							continue;
							end_IL_056d:
							break;
						}
					}
					finally
					{
						if (enumerator2 != null)
						{
							int num9 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
							{
								num9 = 0;
							}
							while (true)
							{
								switch (num9)
								{
								default:
									o1gF4NbdXKddorlqXlai(enumerator2);
									num9 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
									{
										num9 = 0;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
					}
					goto case 48;
				case 28:
					base.LoadFromType(type, inherit);
					num2 = 14;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
					{
						num2 = 27;
					}
					continue;
				case 76:
					if (attribute9 == null)
					{
						num = 26;
						break;
					}
					goto case 3;
				case 13:
					F7SfXDbdiaZJrOyaHi7m(this, entityActionsMetadata);
					num2 = 74;
					continue;
				case 65:
					type3 = type3.BaseType;
					num2 = 58;
					continue;
				case 27:
					attribute7 = AttributeHelper<IdTypeAttribute>.GetAttribute(type, inherited: true);
					num2 = 43;
					continue;
				case 11:
					obj = null;
					goto IL_0fcd;
				case 24:
					FilterImplementedInterfaces = new List<string>();
					num2 = 25;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
					{
						num2 = 7;
					}
					continue;
				case 71:
					k8BiJhbd8gvf9BwTNjwN(this, attribute6.PermissionPropertyName);
					num2 = 29;
					continue;
				case 55:
					JQVfpJbdb0Psh84IQk7J(this, attribute != null);
					num2 = 64;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
					{
						num2 = 5;
					}
					continue;
				case 17:
					tAUjRXb95rtqbrPhFU60(this, xWdkZPb9gtNWHU7xREpe(entityAttribute));
					num2 = 46;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
					{
						num2 = 46;
					}
					continue;
				case 18:
					if (attribute3 != null)
					{
						num = 35;
						break;
					}
					goto case 74;
				case 7:
					PermissionsMetadataName = attribute6.PermissionClassName;
					num2 = 71;
					continue;
				case 57:
					enumerator3 = enumerable.GetEnumerator();
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
					{
						num2 = 32;
					}
					continue;
				case 43:
					if (attribute7 == null)
					{
						num2 = 23;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
						{
							num2 = 41;
						}
						continue;
					}
					goto case 72;
				case 2:
					attribute5 = AttributeHelper<CopyActionAttribute>.GetAttribute(type, inherited: true);
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
					{
						num2 = 45;
					}
					continue;
				case 46:
					attribute14 = AttributeHelper<EntityMetadataTypeAttribute>.GetAttribute(type, inherited: true);
					num2 = 75;
					continue;
				case 56:
					entityActionsMetadata.LoadFromType(attribute3.ActionsType);
					num2 = 13;
					continue;
				default:
					attribute4 = AttributeHelper<ShowInCatalogListAttribute>.GetAttribute(type, inherited: false);
					num2 = 14;
					continue;
				case 68:
					return;
				case 8:
				case 66:
					if (!CaiuSJbd2806THtDdLdT(type2, null))
					{
						num2 = 11;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
						{
							num2 = 4;
						}
						continue;
					}
					obj = AKn3LabdRWww6uyU8Ydd(type2, kZ2Y2ub9r2rmNOvWuj99(typeof(InterfaceImplementationAttribute).TypeHandle), inherit: false);
					goto IL_0fcd;
				case 50:
					if (MwvFZob9IeSSvNL1DMg8(this))
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
						{
							num2 = 16;
						}
						continue;
					}
					goto case 67;
				case 70:
					try
					{
						while (true)
						{
							int num10;
							if (!enumerator4.MoveNext())
							{
								num10 = 3;
								goto IL_0908;
							}
							goto IL_095d;
							IL_0908:
							while (true)
							{
								switch (num10)
								{
								case 6:
									tablePartMetadata.LoadFromType(luY4dCbdqdrYeoMnf6IJ(current4));
									num10 = 4;
									continue;
								case 5:
									break;
								default:
									goto IL_095d;
								case 2:
									tablePartMetadata = new TablePartMetadata();
									num10 = 6;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
									{
										num10 = 0;
									}
									continue;
								case 4:
									kAi9VXbdKnTAuSWTm4QJ(tablePartMetadata, type);
									num10 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
									{
										num10 = 1;
									}
									continue;
								case 1:
									TableParts.Add(tablePartMetadata);
									num10 = 5;
									continue;
								case 3:
									goto end_IL_0947;
								}
								break;
							}
							continue;
							IL_095d:
							current4 = enumerator4.Current;
							int num11 = 2;
							num10 = num11;
							goto IL_0908;
							continue;
							end_IL_0947:
							break;
						}
					}
					finally
					{
						if (enumerator4 != null)
						{
							int num12 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
							{
								num12 = 0;
							}
							while (true)
							{
								switch (num12)
								{
								default:
									o1gF4NbdXKddorlqXlai(enumerator4);
									num12 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
									{
										num12 = 1;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
					}
					goto case 52;
				case 5:
				case 58:
					if (!BLVeRwbdO7qvo6d4C1W1(type2, null))
					{
						num2 = 8;
						continue;
					}
					goto case 49;
				case 31:
					attribute13 = AttributeHelper<SaveHistoryAttribute>.GetAttribute(type, inherited: true);
					num2 = 54;
					continue;
				case 20:
					if (array.Length == 0)
					{
						num2 = 60;
						continue;
					}
					goto case 24;
				case 21:
					attribute12 = AttributeHelper<FilterableAttribute>.GetAttribute(type, inherited: true);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
					{
						num2 = 1;
					}
					continue;
				case 47:
					if (attribute6 == null)
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 40;
				case 38:
					if (viewModelMetadataAttribute == null)
					{
						return;
					}
					num2 = 77;
					continue;
				case 35:
					entityActionsMetadata = new EntityActionsMetadata();
					num2 = 56;
					continue;
				case 36:
					attribute8 = AttributeHelper<HideChildItemsTabAttribute>.GetAttribute(type, inherited: false);
					num2 = 27;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
					{
						num2 = 61;
					}
					continue;
				case 26:
				case 69:
					attribute3 = AttributeHelper<ActionsTypeAttribute>.GetAttribute(type, inherited: false);
					num2 = 18;
					continue;
				case 49:
					if (!CaiuSJbd2806THtDdLdT(type3, null))
					{
						num2 = 66;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
						{
							num2 = 14;
						}
						continue;
					}
					goto case 15;
				case 19:
					attribute = AttributeHelper<HierarchicalAttribute>.GetAttribute(type, inherited: false);
					num2 = 55;
					continue;
				case 32:
					try
					{
						while (true)
						{
							IL_0c67:
							int num5;
							if (!KEZQ1pbdSfnpcdDt0W12(enumerator3))
							{
								num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
								{
									num5 = 1;
								}
								goto IL_0b7f;
							}
							goto IL_0bb9;
							IL_0bb9:
							current2 = enumerator3.Current;
							num5 = 11;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
							{
								num5 = 11;
							}
							goto IL_0b7f;
							IL_0b7f:
							while (true)
							{
								switch (num5)
								{
								case 7:
									break;
								case 9:
									if (attribute16 != null)
									{
										num5 = 10;
										continue;
									}
									goto IL_0c67;
								case 11:
									if (current2.InterfaceType != null)
									{
										num5 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
										{
											num5 = 0;
										}
										continue;
									}
									goto IL_0c67;
								default:
									attribute16 = AttributeHelper<UidAttribute>.GetAttribute(current2.InterfaceType, inherited: false);
									num5 = 5;
									continue;
								case 2:
								{
									ImplementedExtensionUids.Add(attribute16.Uid);
									int num6 = 6;
									num5 = num6;
									continue;
								}
								case 3:
									ImplementedExtensionUids = new List<Guid>();
									num5 = 2;
									continue;
								case 6:
									goto IL_0c67;
								case 10:
									if (attribute15 != null)
									{
										num5 = 4;
										continue;
									}
									goto IL_0c67;
								case 8:
									if (ImplementedExtensionUids == null)
									{
										num5 = 3;
										continue;
									}
									goto case 2;
								case 4:
									if (PZdfZcbdkeggfel0yDKp(attribute15) == EntityMetadataType.InterfaceExtension)
									{
										num5 = 8;
										continue;
									}
									goto IL_0c67;
								case 5:
									attribute15 = AttributeHelper<EntityMetadataTypeAttribute>.GetAttribute(UcJxLhbdTKIoRmoAo4Pn(current2), inherited: false);
									num5 = 9;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
									{
										num5 = 3;
									}
									continue;
								case 1:
									goto end_IL_0c67;
								}
								break;
							}
							goto IL_0bb9;
							continue;
							end_IL_0c67:
							break;
						}
					}
					finally
					{
						int num7;
						if (enumerator3 == null)
						{
							num7 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
							{
								num7 = 0;
							}
							goto IL_0d1d;
						}
						goto IL_0d52;
						IL_0d52:
						o1gF4NbdXKddorlqXlai(enumerator3);
						num7 = 2;
						goto IL_0d1d;
						IL_0d1d:
						switch (num7)
						{
						default:
							goto end_IL_0cf8;
						case 0:
							goto end_IL_0cf8;
						case 1:
							break;
						case 2:
							goto end_IL_0cf8;
						}
						goto IL_0d52;
						end_IL_0cf8:;
					}
					goto case 6;
				case 75:
					oIgoITb9RViQbgYAReRL(this, attribute14?.Type ?? EntityMetadataType.Entity);
					num2 = 50;
					continue;
				case 51:
					ImplementationUid = ((attribute2 != null) ? P4eRyHb9YsgKQTZ07iSG(attribute2) : Guid.Empty);
					num2 = 31;
					continue;
				case 54:
					SaveHistory = attribute13?.SaveHistory ?? false;
					num2 = 2;
					continue;
				case 45:
					CopyAction = ((attribute5 != null) ? Ew7sn5b9LHrFHKfpApCg(attribute5) : CopyAction.Default);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
					{
						num2 = 0;
					}
					continue;
				case 14:
					XeQyMHb9sVDtMqpC08oj(this, attribute4 != null && GYXWE4b9UqgouNX1nIkT(attribute4));
					num2 = 21;
					continue;
				case 1:
					vHdbBkb9zEsPIt8PRMco(this, attribute12 != null && a6Sl1Db9cJ8MtAIjDdhJ(attribute12));
					num = 62;
					break;
				case 63:
					CacheEntity = attribute10 != null && hgBftQbdFQTxc8uGuTpE(attribute10);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
					{
						num2 = 33;
					}
					continue;
				case 61:
					LoBFLsbdoNMoMO70VHiT(this, attribute8 != null && fOMykkbdWbMZPLcfdcjX(attribute8));
					num = 19;
					break;
				case 64:
					B7FEYZbdGmNWw4wjp6iy(this, (attribute != null) ? Na4DuRbdhRMFSyVorWOn(attribute) : HierarchyType.GroupAndElements);
					num2 = 14;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
					{
						num2 = 30;
					}
					continue;
				case 30:
					wHlVC2bdEXxCqG659NnF(this, attribute?.ParentPropertyUid ?? Guid.Empty);
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
					{
						num2 = 8;
					}
					continue;
				case 9:
					OmlFbIbdQqXCeMRuOLDH(this, (attribute != null) ? qJVdoSbdfMe9B4oe4tuI(attribute) : Guid.Empty);
					num2 = 34;
					continue;
				case 3:
					{
						enumerator = ((IEnumerable<PropertyInfo>)klJ2Vfbdu0KELvfD4V1D(oBU7eQbdZsE0laKLGO8n(attribute9))).Where((PropertyInfo p) => p.IsDefined(_003C_003Ec.FRkq2fCAYdFmZ5t0pMWi(typeof(CustomFilterPropertyAttribute).TypeHandle), inherit: false)).GetEnumerator();
						num2 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
						{
							num2 = 5;
						}
						continue;
					}
					IL_0fcd:
					array = (object[])obj;
					num2 = 25;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
					{
						num2 = 53;
					}
					continue;
				}
				break;
			}
		}
	}

	public override void ApplyRestartUnrequiredChanges(bool inherit)
	{
		//Discarded unreachable code: IL_0095, IL_00a4, IL_0136, IL_017d, IL_01a5, IL_01b4, IL_01e6, IL_01f5, IL_0270, IL_027f, IL_0325, IL_0338, IL_0397, IL_03ab, IL_03ba, IL_03c5, IL_0488, IL_04c0
		int num = 22;
		int num2 = num;
		_003C_003Ec__DisplayClass155_0 _003C_003Ec__DisplayClass155_ = default(_003C_003Ec__DisplayClass155_0);
		MetadataItemManager metadataItemManager = default(MetadataItemManager);
		EntityMetadata entityMetadata = default(EntityMetadata);
		EntityMetadata entityMetadata4 = default(EntityMetadata);
		List<Guid>.Enumerator enumerator2 = default(List<Guid>.Enumerator);
		Guid current2 = default(Guid);
		EntityMetadata entityMetadata3 = default(EntityMetadata);
		EntityMetadata entityMetadata2 = default(EntityMetadata);
		IEnumerator<IPropertyMetadata> enumerator = default(IEnumerator<IPropertyMetadata>);
		Dictionary<Guid, IPropertyMetadata> dictionary = default(Dictionary<Guid, IPropertyMetadata>);
		IPropertyMetadata current = default(IPropertyMetadata);
		IPropertyMetadata value = default(IPropertyMetadata);
		while (true)
		{
			object obj2;
			object obj;
			List<EntityMetadata> extensions;
			switch (num2)
			{
			case 8:
				if (IN0xpWbdpMAt1cDhitZm(_003C_003Ec__DisplayClass155_.changedExtensions) <= 0)
				{
					num2 = 9;
					continue;
				}
				goto case 17;
			case 21:
				if (!gxA5fpbd1mI5H7HnfHLx())
				{
					num2 = 23;
					continue;
				}
				obj2 = Locator.GetService<MetadataItemManager>();
				goto IL_0570;
			case 1:
				if (metadataItemManager != null)
				{
					num2 = 28;
					continue;
				}
				return;
			default:
				ItvkAkbdaGHmfAu5jPyF(this, entityMetadata);
				num2 = 15;
				continue;
			case 24:
				if (qefXcqb9hAjwEVDPpQRp(LAE7Hpb9y5reETi4PX5l(this), Guid.Empty))
				{
					num2 = 4;
					continue;
				}
				return;
			case 9:
			case 14:
				if (!inherit)
				{
					num2 = 2;
					continue;
				}
				goto case 24;
			case 15:
				DefaultForms = null;
				num2 = 14;
				continue;
			case 25:
				_003C_003Ec__DisplayClass155_.changedExtensions = new List<EntityMetadata>();
				num2 = 13;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
				{
					num2 = 16;
				}
				continue;
			case 23:
				obj2 = null;
				goto IL_0570;
			case 26:
				entityMetadata4 = sMk9Iabd3ltQ9tJG6HDF(metadataItemManager, w8ojd4bdN2h9nP2oNp2p(this)) as EntityMetadata;
				num2 = 25;
				continue;
			case 2:
				return;
			case 11:
				_003C_003Ec__DisplayClass155_ = new _003C_003Ec__DisplayClass155_0();
				num2 = 15;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
				{
					num2 = 26;
				}
				continue;
			case 7:
				try
				{
					while (true)
					{
						IL_02d3:
						int num5;
						if (!enumerator2.MoveNext())
						{
							num5 = 5;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
							{
								num5 = 5;
							}
							goto IL_0204;
						}
						goto IL_0248;
						IL_0248:
						current2 = enumerator2.Current;
						num5 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
						{
							num5 = 2;
						}
						goto IL_0204;
						IL_0204:
						while (true)
						{
							switch (num5)
							{
							case 2:
							{
								entityMetadata3 = sMk9Iabd3ltQ9tJG6HDF(metadataItemManager, current2) as EntityMetadata;
								int num6 = 3;
								num5 = num6;
								continue;
							}
							case 4:
								break;
							case 3:
								if (entityMetadata3 == null)
								{
									num5 = 6;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
									{
										num5 = 5;
									}
									continue;
								}
								goto default;
							default:
								_003C_003Ec__DisplayClass155_.changedExtensions.Add(entityMetadata3);
								num5 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
								{
									num5 = 0;
								}
								continue;
							case 1:
							case 6:
								goto IL_02d3;
							case 5:
								goto end_IL_02d3;
							}
							break;
						}
						goto IL_0248;
						continue;
						end_IL_02d3:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator2).Dispose();
					int num7 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
					{
						num7 = 0;
					}
					switch (num7)
					{
					case 0:
						break;
					}
				}
				goto case 5;
			case 12:
				return;
			case 13:
				return;
			case 18:
				if (entityMetadata2 == null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
					{
						num2 = 12;
					}
					continue;
				}
				break;
			case 4:
				entityMetadata2 = (EntityMetadata)MetadataLoader.LoadMetadata(LAE7Hpb9y5reETi4PX5l(this), inherit: true, loadImplementation: false);
				num2 = 18;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
				{
					num2 = 15;
				}
				continue;
			case 3:
				try
				{
					while (true)
					{
						int num3;
						if (!KEZQ1pbdSfnpcdDt0W12(enumerator))
						{
							num3 = 3;
							goto IL_03c9;
						}
						goto IL_042c;
						IL_03c9:
						while (true)
						{
							switch (num3)
							{
							case 3:
								return;
							case 2:
								if (dictionary.TryGetValue(t8hAWabdDTeMjAp2Scjc(current), out value))
								{
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
									{
										num3 = 1;
									}
									continue;
								}
								break;
							case 4:
								break;
							default:
								goto IL_042c;
							case 1:
								ItvkAkbdaGHmfAu5jPyF(current, value);
								num3 = 4;
								continue;
							}
							break;
						}
						continue;
						IL_042c:
						current = enumerator.Current;
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
						{
							num3 = 2;
						}
						goto IL_03c9;
					}
				}
				finally
				{
					if (enumerator != null)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								o1gF4NbdXKddorlqXlai(enumerator);
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
								{
									num4 = 0;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
			case 19:
				enumerator2 = ImplementedExtensionUids.GetEnumerator();
				num2 = 7;
				continue;
			case 16:
				if (ImplementedExtensionUids != null)
				{
					num2 = 19;
					continue;
				}
				goto case 5;
			case 5:
				if (entityMetadata4 == null)
				{
					num2 = 8;
					continue;
				}
				goto case 17;
			case 10:
				return;
			case 28:
				if (Type == EntityMetadataType.InterfaceImplementation)
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
					{
						num2 = 11;
					}
					continue;
				}
				goto case 9;
			case 20:
				enumerator = ((IEnumerable<IPropertyMetadata>)Properties).EmptyIfNull().Concat(((IEnumerable<IPropertyMetadata>)TableParts).EmptyIfNull()).GetEnumerator();
				num2 = 3;
				continue;
			case 22:
				base.ApplyRestartUnrequiredChanges(inherit);
				num2 = 21;
				continue;
			case 17:
				obj = entityMetadata4;
				if (obj != null)
				{
					goto IL_05c6;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
				{
					num2 = 6;
				}
				continue;
			case 6:
				obj = (EntityMetadata)MetadataLoader.LoadMetadata(w8ojd4bdN2h9nP2oNp2p(this), inherit: false, loadImplementation: false);
				goto IL_05c6;
			case 27:
				break;
				IL_05c6:
				extensions = ((ImplementedExtensionUids != null) ? ImplementedExtensionUids.Select(_003C_003Ec__DisplayClass155_._003CApplyRestartUnrequiredChanges_003Eb__0).ToList() : null);
				entityMetadata = ((EntityMetadata)obj).CreateInterfaceImplementationMetadata(extensions);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
				{
					num2 = 0;
				}
				continue;
				IL_0570:
				metadataItemManager = (MetadataItemManager)obj2;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
				{
					num2 = 1;
				}
				continue;
			}
			dictionary = ((IEnumerable<IPropertyMetadata>)entityMetadata2.Properties).EmptyIfNull().Concat(((IEnumerable<IPropertyMetadata>)entityMetadata2.TableParts).EmptyIfNull()).ToDictionary((IPropertyMetadata p) => _003C_003Ec.K16vuXCALP1bQ71C13xU(p));
			num2 = 11;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
			{
				num2 = 20;
			}
		}
	}

	public virtual IEnumerable<IMetadata> GetCompositeParts()
	{
		return TableParts;
	}

	protected override IEnumerable<PropertyInfo> GetPropertyInfosWithMetadata(Type type, bool inherit)
	{
		List<PropertyInfo> list = new List<PropertyInfo>();
		while (type != null)
		{
			BindingFlags bindingFlags = BindingFlags.Instance | BindingFlags.Public;
			BaseClassAttribute attribute = AttributeHelper<BaseClassAttribute>.GetAttribute(type, inherited: true);
			bool flag = attribute != null && attribute.BaseClassUid != Guid.Empty;
			if (flag)
			{
				bindingFlags |= BindingFlags.DeclaredOnly;
			}
			List<PropertyInfo> list2 = type.GetReflectionProperties(bindingFlags).Where(delegate(PropertyInfo p)
			{
				//Discarded unreachable code: IL_002d, IL_003c
				int num3 = 1;
				int num4 = num3;
				while (true)
				{
					switch (num4)
					{
					case 2:
						return !_003C_003Ec.Fe9RktCAUIvTFqrywH8Z(p, _003C_003Ec.FRkq2fCAYdFmZ5t0pMWi(typeof(TablePartPropertyAttribute).TypeHandle), false);
					default:
						return false;
					case 1:
						if (!_003C_003Ec.Fe9RktCAUIvTFqrywH8Z(p, typeof(EntityPropertyAttribute), false))
						{
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
							{
								num4 = 0;
							}
							break;
						}
						goto case 2;
					}
				}
			}).ToList();
			if (list2.Any((PropertyInfo p) => _003C_003Ec.Fe9RktCAUIvTFqrywH8Z(p, _003C_003Ec.FRkq2fCAYdFmZ5t0pMWi(typeof(OrderAttribute).TypeHandle), true)))
			{
				list2 = list2.OrderBy(delegate(PropertyInfo p)
				{
					//Discarded unreachable code: IL_0075, IL_0084
					int num = 3;
					int num2 = num;
					OrderAttribute attribute2 = default(OrderAttribute);
					while (true)
					{
						switch (num2)
						{
						case 3:
							attribute2 = AttributeHelper<OrderAttribute>.GetAttribute(p, inherited: true);
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
							{
								num2 = 2;
							}
							break;
						case 2:
							if (attribute2 != null)
							{
								num2 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
								{
									num2 = 1;
								}
								break;
							}
							goto default;
						default:
							return 0;
						case 1:
							return _003C_003Ec.Ewv0A3CAssoYwJU8PIo8(attribute2);
						}
					}
				}).ToList();
			}
			list.InsertRange(0, list2);
			if (!inherit || !flag)
			{
				break;
			}
			type = type.BaseType;
		}
		return list;
	}

	protected override void OnNamespaceChanged()
	{
		//Discarded unreachable code: IL_00a3, IL_00b2, IL_00bd, IL_0145, IL_0158
		int num = 2;
		int num2 = num;
		List<TablePartMetadata>.Enumerator enumerator = default(List<TablePartMetadata>.Enumerator);
		while (true)
		{
			switch (num2)
			{
			case 2:
				base.OnNamespaceChanged();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
				{
					num2 = 1;
				}
				continue;
			case 3:
				enumerator = TableParts.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
				{
					num2 = 0;
				}
				continue;
			case 1:
				if (TableParts != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
					{
						num2 = 3;
					}
					continue;
				}
				return;
			case 4:
				return;
			}
			try
			{
				while (true)
				{
					int num3;
					if (!enumerator.MoveNext())
					{
						num3 = 2;
						goto IL_00c1;
					}
					goto IL_00d7;
					IL_00c1:
					switch (num3)
					{
					case 2:
						return;
					case 1:
						break;
					default:
						continue;
					}
					goto IL_00d7;
					IL_00d7:
					sxyCdbb9AGlPxFTYtSP7(enumerator.Current, y54tYUb9HRDqD1yuI3TS(this));
					num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
					{
						num3 = 0;
					}
					goto IL_00c1;
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
				int num4 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
				{
					num4 = 0;
				}
				switch (num4)
				{
				case 0:
					break;
				}
			}
		}
	}

	protected virtual void OnTypeChanged()
	{
		//Discarded unreachable code: IL_0035, IL_0044, IL_007d, IL_008c, IL_0097, IL_0145, IL_0158, IL_0167
		int num = 2;
		int num2 = num;
		List<TablePartMetadata>.Enumerator enumerator = default(List<TablePartMetadata>.Enumerator);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				return;
			case 0:
				return;
			case 3:
				enumerator = TableParts.GetEnumerator();
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
				{
					num2 = 2;
				}
				break;
			case 4:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
							{
								num3 = 0;
							}
							goto IL_009b;
						}
						goto IL_00d7;
						IL_00d7:
						oIgoITb9RViQbgYAReRL(enumerator.Current, MwvFZob9IeSSvNL1DMg8(this) ? EntityMetadataType.Interface : u9181Tb9uKSltlGfBVHS(this));
						num3 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
						{
							num3 = 1;
						}
						goto IL_009b;
						IL_009b:
						switch (num3)
						{
						default:
							return;
						case 0:
							return;
						case 2:
							break;
						case 1:
							goto IL_00d7;
						}
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
			case 2:
				if (TableParts == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			}
		}
	}

	protected override void GetForms(List<FormViewItem> forms, ClassDefaultForms defaultForms)
	{
		if (Type == EntityMetadataType.InterfaceImplementation)
		{
			((BaseClassUid != Guid.Empty) ? ((EntityMetadata)MetadataServiceContext.Service.GetMetadata(BaseClassUid, loadImplementation: false)) : null)?.GetForms(forms, defaultForms);
			EntityMetadata metadata = (EntityMetadata)MetadataServiceContext.Service.GetMetadata(ImplementationUid, loadImplementation: false);
			ClassMetadata.AddForms(forms, metadata, defaultForms);
			ClassMetadata.AddFormsSettings(metadata, defaultForms);
			if (ImplementedExtensionUids == null || ImplementedExtensionUids.Count <= 0)
			{
				return;
			}
			EntityMetadata entityMetadata = null;
			bool flag = MetadataServiceContext.MetadataRuntimeServiceOrNull != null;
			foreach (Guid implementedExtensionUid in ImplementedExtensionUids)
			{
				EntityMetadata entityMetadata2 = (EntityMetadata)MetadataServiceContext.Service.GetMetadata(implementedExtensionUid, loadImplementation: false);
				if (flag && entityMetadata == null && implementedExtensionUid.IsConfigMetadata())
				{
					entityMetadata = entityMetadata2;
					continue;
				}
				ClassMetadata.AddForms(forms, entityMetadata2, defaultForms);
				ClassMetadata.AddFormsSettings(entityMetadata2, defaultForms);
			}
			if (entityMetadata != null)
			{
				ClassMetadata.AddForms(forms, entityMetadata, defaultForms);
				ClassMetadata.AddFormsSettings(entityMetadata, defaultForms);
			}
		}
		else if (Type == EntityMetadataType.InterfaceExtension)
		{
			EntityMetadata entityMetadata3 = (EntityMetadata)MetadataServiceContext.Service.GetMetadata(BaseClassUid, loadImplementation: false);
			forms.AddRange(entityMetadata3.GetForms());
			ClassMetadata.AddForms(forms, this, defaultForms);
			ClassMetadata.AddFormsSettings(this, defaultForms);
		}
		else
		{
			base.GetForms(forms, defaultForms);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public override bool ShouldSerializeDefaultForms()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (Type != EntityMetadataType.InterfaceImplementation)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
					{
						num2 = 0;
					}
					break;
				}
				return false;
			default:
				return base.ShouldSerializeDefaultForms();
			}
		}
	}

	protected internal virtual void InitializeImplDefaultForms()
	{
		int num = 3;
		int num2 = num;
		List<FormViewItem> forms = default(List<FormViewItem>);
		ClassDefaultForms defaultForms = default(ClassDefaultForms);
		ClassDefaultForms classDefaultForms = default(ClassDefaultForms);
		while (true)
		{
			switch (num2)
			{
			case 3:
				forms = new List<FormViewItem>();
				num2 = 2;
				break;
			case 4:
				GetForms(forms, defaultForms);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				classDefaultForms = (DefaultForms = new ClassDefaultForms());
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				defaultForms = classDefaultForms;
				num2 = 4;
				break;
			case 1:
				return;
			}
		}
	}

	protected virtual ViewModelPropertyMetadata CreateModelProperty()
	{
		ViewModelPropertyMetadata viewModelPropertyMetadata = new ViewModelPropertyMetadata();
		ebwKYKb96UFZbo9eMBEK(viewModelPropertyMetadata, Jc5v0Bb94pyOyugernvS());
		cVHUUMb9aSBjpFl1k110(viewModelPropertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638402543 ^ -1638455203));
		viewModelPropertyMetadata.DisplayName = SR.T((string)MSCsnub9C12rHGsiMtFQ(-541731959 ^ -541666325));
		w7OViVb91h3XMINgZWZj(viewModelPropertyMetadata, EntityDescriptor.UID);
		viewModelPropertyMetadata.SubTypeUid = (IsInterfaceType ? J7Gxqcb9vHIMg9692ytg(this) : w8ojd4bdN2h9nP2oNp2p(this));
		BnubhCb9kbqvLIeQlx1u(viewModelPropertyMetadata, true);
		return viewModelPropertyMetadata;
	}

	private void ReplaceTablePartImplementationUids(EntityMetadata metadata, string implNamespace = null)
	{
		//Discarded unreachable code: IL_007e, IL_008d, IL_015a, IL_0169, IL_0214, IL_0227, IL_0236
		int num = 3;
		int num2 = num;
		List<TablePartMetadata>.Enumerator enumerator = default(List<TablePartMetadata>.Enumerator);
		Guid implementationUid = default(Guid);
		TablePartMetadata current = default(TablePartMetadata);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				enumerator = metadata.TableParts.GetEnumerator();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				if (metadata.TableParts != null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
					{
						num2 = 1;
					}
					break;
				}
				return;
			case 1:
				try
				{
					while (true)
					{
						IL_0187:
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 10;
							goto IL_009c;
						}
						goto IL_0174;
						IL_009c:
						while (true)
						{
							switch (num3)
							{
							case 5:
								implementationUid = J7Gxqcb9vHIMg9692ytg(current);
								num3 = 6;
								continue;
							case 4:
							case 9:
								ReplaceTablePartImplementationUids(current);
								num3 = 7;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
								{
									num3 = 5;
								}
								continue;
							case 8:
								if (eItW63bdwOs7L4iR5LUU(implNamespace))
								{
									num3 = 2;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
									{
										num3 = 4;
									}
									continue;
								}
								goto case 2;
							case 1:
								current.Type = EntityMetadataType.InterfaceImplementation;
								num3 = 8;
								continue;
							case 2:
							{
								sxyCdbb9AGlPxFTYtSP7(current, implNamespace);
								int num4 = 9;
								num3 = num4;
								continue;
							}
							case 7:
								goto IL_0187;
							case 3:
								current.ImplementationUid = implementationUid;
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
								{
									num3 = 1;
								}
								continue;
							case 6:
								ebwKYKb96UFZbo9eMBEK(current, w8ojd4bdN2h9nP2oNp2p(current));
								num3 = 3;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
								{
									num3 = 1;
								}
								continue;
							case 10:
								return;
							}
							break;
						}
						goto IL_0174;
						IL_0174:
						current = enumerator.Current;
						num3 = 5;
						goto IL_009c;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
					{
						num5 = 0;
					}
					switch (num5)
					{
					case 0:
						break;
					}
				}
			case 0:
				return;
			}
		}
	}

	PublicationType IDeltaRootMetadata.GetPublicationTypeOnChange(IMetadata oldMetadata)
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (u9181Tb9uKSltlGfBVHS(this) != 0)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto default;
			default:
				return PublicationType.Restart;
			case 1:
				return B36o0Hbd4utvh7tjYrWJ(oldMetadata, this);
			}
		}
	}

	public EntityMetadata()
	{
		//Discarded unreachable code: IL_00b2, IL_00b7
		axqH2Nbd6sTZrLx8YoTp();
		IsUnique = true;
		IdTypeUid = Int64Descriptor.UID;
		IsSoftDeletable = true;
		FilterImplementedInterfaces = new List<string>();
		Filter = new EntityFilterMetadata();
		Actions = new EntityActionsMetadata();
		entityProperties = (ISet<EntityPropertyMetadata>)(object)new HashedSet<EntityPropertyMetadata>();
		entityTableParts = (ISet<TablePartMetadata>)(object)new HashedSet<TablePartMetadata>();
		tableParts = new List<TablePartMetadata>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static EntityMetadata()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				UID = new Guid((string)MSCsnub9C12rHGsiMtFQ(0x1ECE530A ^ 0x1ECD5378));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			case 1:
				axqH2Nbd6sTZrLx8YoTp();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void N11SS9b9oURMEiShgfm2(object P_0, object P_1)
	{
		((ClassMetadata)P_0).DefaultForms = (ClassDefaultForms)P_1;
	}

	internal static bool E3Z17Ab9BxCJrLLg72tk()
	{
		return eFWmq3b9FDeoybGQB57N == null;
	}

	internal static EntityMetadata S25dpdb9W3nAayQ9tOs6()
	{
		return eFWmq3b9FDeoybGQB57N;
	}

	internal static Guid lqhap5b9bdMAR1MQaMPm(object P_0)
	{
		return ((EntityMetadata)P_0).ParentPropertyUid;
	}

	internal static bool qefXcqb9hAjwEVDPpQRp(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static Guid fXq5Etb9Gah8L83xNNAu(object P_0)
	{
		return ((EntityMetadata)P_0).IsGroupPropertyUid;
	}

	internal static bool PaOtoHb9E3CwqyjLdxE5(object P_0)
	{
		return ((EntityMetadata)P_0).Filterable;
	}

	internal static int qBGDwOb9fiX3pH6jfTOG(object P_0)
	{
		return ((List<Guid>)P_0).Count;
	}

	internal static int NBP8txb9QO9i1sO5C5ks(object P_0)
	{
		return ((List<TablePartMetadata>)P_0).Count;
	}

	internal static object MSCsnub9C12rHGsiMtFQ(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static Guid J7Gxqcb9vHIMg9692ytg(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static int oadomhb98ijCXwOTXsRE()
	{
		return SR.CurrentLCID;
	}

	internal static void TOyAxrb9Z8qREYNOj16V(object P_0)
	{
		ContextVars.Remove((string)P_0);
	}

	internal static EntityMetadataType u9181Tb9uKSltlGfBVHS(object P_0)
	{
		return ((EntityMetadata)P_0).Type;
	}

	internal static bool MwvFZob9IeSSvNL1DMg8(object P_0)
	{
		return ((ClassMetadata)P_0).IsInterfaceType;
	}

	internal static object L0eoFnb9VOa5jPxqCHeG(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static object PHyYiEb9SSaAJUBVCAYB(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static void lPF5ZBb9ifiYo8kCSAXA(object P_0)
	{
		((AbstractMetadata)P_0).InitNew();
	}

	internal static void oIgoITb9RViQbgYAReRL(object P_0, EntityMetadataType value)
	{
		((EntityMetadata)P_0).Type = value;
	}

	internal static Guid hA3Rycb9q2I5RhZxCxYD(object P_0)
	{
		return ((PropertyMetadata)P_0).TypeUid;
	}

	internal static object b1ufNYb9K4idafNcePoK(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object kCmmwvb9XTupj8fvNH47(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static bool gYPuP4b9T0mpf93rLLAH(object P_0)
	{
		return ((PropertyMetadata)P_0).IsSystem;
	}

	internal static void BnubhCb9kbqvLIeQlx1u(object P_0, bool value)
	{
		((PropertyMetadata)P_0).IsSystem = value;
	}

	internal static void V7Vepwb9nDPbbk7y64VT(object P_0, bool value)
	{
		((PropertyMetadata)P_0).Nullable = value;
	}

	internal static void AWB1Jfb9OTSd0Tm9X2uR(object P_0)
	{
		((List<ViewAttribute>)P_0).Clear();
	}

	internal static void fDRrvkb929508rMJxgN0(object P_0, ViewType value)
	{
		((ViewAttribute)P_0).ViewType = value;
	}

	internal static void OQqFrWb9ekqUafT8xCPG(object P_0, Visibility value)
	{
		((ViewAttribute)P_0).Visibility = value;
	}

	internal static void g2fiOOb9PyTZjcDlU9Ag(object P_0, object P_1)
	{
		((NamedMetadata)P_0).DisplayName = (string)P_1;
	}

	internal static void w7OViVb91h3XMINgZWZj(object P_0, Guid value)
	{
		((PropertyMetadata)P_0).TypeUid = value;
	}

	internal static void NNeqY5b9Ndm2DB1YGjSx(object P_0, object P_1)
	{
		((SimpleTypeSettings)P_0).FieldName = (string)P_1;
	}

	internal static void vnLabEb93VkFKvrto4Q8(object P_0, object P_1)
	{
		((PropertyMetadata)P_0).Settings = (TypeSettings)P_1;
	}

	internal static object yGx9M3b9poYb02kSUB7r(object P_0)
	{
		return ((PropertyMetadata)P_0).ViewSettings;
	}

	internal static void cVHUUMb9aSBjpFl1k110(object P_0, object P_1)
	{
		((NamedMetadata)P_0).Name = (string)P_1;
	}

	internal static void rQfP93b9D6GkAtUefhfj(object P_0, Guid value)
	{
		((PropertyMetadata)P_0).SubTypeUid = value;
	}

	internal static object ocqdN7b9tuUUs37e14Qy(object P_0)
	{
		return ((EntityMetadata)P_0).ViewModelMetadata;
	}

	internal static Guid BHxaGSb9wF2CMrJKn4Lg(object P_0)
	{
		return ((AbstractMetadata)P_0).ModuleUid;
	}

	internal static Guid Jc5v0Bb94pyOyugernvS()
	{
		return Guid.NewGuid();
	}

	internal static void ebwKYKb96UFZbo9eMBEK(object P_0, Guid value)
	{
		((AbstractMetadata)P_0).Uid = value;
	}

	internal static object y54tYUb9HRDqD1yuI3TS(object P_0)
	{
		return ((ClassMetadata)P_0).Namespace;
	}

	internal static void sxyCdbb9AGlPxFTYtSP7(object P_0, object P_1)
	{
		((ClassMetadata)P_0).Namespace = (string)P_1;
	}

	internal static object yHx0eDb97ZQdEld1Hf8f(object P_0)
	{
		return ((ClassMetadata)P_0).NamespaceForDisplay;
	}

	internal static void cLFuxub9xymhDZViiMHn(object P_0, object P_1)
	{
		((ClassMetadata)P_0).NamespaceForDisplay = (string)P_1;
	}

	internal static void psBHYsb90g78LsEp1ucu(object P_0, Guid value)
	{
		((EntityMetadata)P_0).ImplementationUid = value;
	}

	internal static object OJWLMcb9mWy1T2ai3Kdt(object P_0)
	{
		return ((ClassMetadata)P_0).CreateDefaultTableView();
	}

	internal static Guid LAE7Hpb9y5reETi4PX5l(object P_0)
	{
		return ((ClassMetadata)P_0).BaseClassUid;
	}

	internal static bool ApXtOSb9MLRuRuyVK86M(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static object IkDQXwb9JE7bQi6a0nL8(object P_0)
	{
		return ((EntityMetadata)P_0).CreateUidProperty();
	}

	internal static void TrDXsSb99aXcKjIghbY7(object P_0)
	{
		((AbstractMetadata)P_0).AfterLoad();
	}

	internal static Guid bsUXS9b9dZsOW9nvqA6r(object P_0)
	{
		return ((IdTypeAttribute)P_0).TypeUid;
	}

	internal static void FN7c6fb9lpZKsUEgrGJD(object P_0, Guid value)
	{
		((EntityMetadata)P_0).IdTypeUid = value;
	}

	internal static Type kZ2Y2ub9r2rmNOvWuj99(RuntimeTypeHandle P_0)
	{
		return System.Type.GetTypeFromHandle(P_0);
	}

	internal static object xWdkZPb9gtNWHU7xREpe(object P_0)
	{
		return ((EntityAttribute)P_0).TableName;
	}

	internal static void tAUjRXb95rtqbrPhFU60(object P_0, object P_1)
	{
		((EntityMetadata)P_0).TableName = (string)P_1;
	}

	internal static object T1RBaZb9jGqJ9pFHRAUO(object P_0, int P_1)
	{
		return ((string)P_0).Substring(P_1);
	}

	internal static Guid P4eRyHb9YsgKQTZ07iSG(object P_0)
	{
		return ((ImplementationUidAttribute)P_0).Uid;
	}

	internal static CopyAction Ew7sn5b9LHrFHKfpApCg(object P_0)
	{
		return ((CopyActionAttribute)P_0).CopyAction;
	}

	internal static bool GYXWE4b9UqgouNX1nIkT(object P_0)
	{
		return ((ShowInCatalogListAttribute)P_0).NeedShow;
	}

	internal static void XeQyMHb9sVDtMqpC08oj(object P_0, bool value)
	{
		((EntityMetadata)P_0).ShowInCatalogList = value;
	}

	internal static bool a6Sl1Db9cJ8MtAIjDdhJ(object P_0)
	{
		return ((FilterableAttribute)P_0).Filterable;
	}

	internal static void vHdbBkb9zEsPIt8PRMco(object P_0, bool value)
	{
		((EntityMetadata)P_0).Filterable = value;
	}

	internal static bool hgBftQbdFQTxc8uGuTpE(object P_0)
	{
		return ((CacheEntityAttribute)P_0).Enabled;
	}

	internal static void m6CfLsbdBG0hbabpsM4T(object P_0, bool value)
	{
		((EntityMetadata)P_0).IsUnique = value;
	}

	internal static bool fOMykkbdWbMZPLcfdcjX(object P_0)
	{
		return ((HideChildItemsTabAttribute)P_0).NeedHide;
	}

	internal static void LoBFLsbdoNMoMO70VHiT(object P_0, bool value)
	{
		((EntityMetadata)P_0).HideChildItemsTab = value;
	}

	internal static void JQVfpJbdb0Psh84IQk7J(object P_0, bool value)
	{
		((EntityMetadata)P_0).Hierarchical = value;
	}

	internal static HierarchyType Na4DuRbdhRMFSyVorWOn(object P_0)
	{
		return ((HierarchicalAttribute)P_0).HierarchyType;
	}

	internal static void B7FEYZbdGmNWw4wjp6iy(object P_0, HierarchyType value)
	{
		((EntityMetadata)P_0).HierarchyType = value;
	}

	internal static void wHlVC2bdEXxCqG659NnF(object P_0, Guid value)
	{
		((EntityMetadata)P_0).ParentPropertyUid = value;
	}

	internal static Guid qJVdoSbdfMe9B4oe4tuI(object P_0)
	{
		return ((HierarchicalAttribute)P_0).IsGroupPropertyUid;
	}

	internal static void OmlFbIbdQqXCeMRuOLDH(object P_0, Guid value)
	{
		((EntityMetadata)P_0).IsGroupPropertyUid = value;
	}

	internal static bool GCefPVbdC6XrSZW9WgOk(object P_0)
	{
		return ((InstancePermissionAttribute)P_0).Enabled;
	}

	internal static void aoUZ2Fbdvk8afxpj32lp(object P_0, bool value)
	{
		((EntityMetadata)P_0).InstancePermissionsSupport = value;
	}

	internal static void k8BiJhbd8gvf9BwTNjwN(object P_0, object P_1)
	{
		((EntityMetadata)P_0).PermissionsPropertyName = (string)P_1;
	}

	internal static Type oBU7eQbdZsE0laKLGO8n(object P_0)
	{
		return ((FilterTypeAttribute)P_0).FilterType;
	}

	internal static object klJ2Vfbdu0KELvfD4V1D(Type type)
	{
		return type.GetReflectionProperties();
	}

	internal static object HRLsL2bdIi4wO66BKjPO(object P_0)
	{
		return ((EntityMetadata)P_0).Filter;
	}

	internal static void uHu7aXbdVTG2YB83vSFT(object P_0, object P_1, object P_2)
	{
		((PropertyMetadata)P_0).LoadFromPropertyInfo((PropertyInfo)P_1, (PropertyMetadata)P_2);
	}

	internal static bool KEZQ1pbdSfnpcdDt0W12(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void F7SfXDbdiaZJrOyaHi7m(object P_0, object P_1)
	{
		((EntityMetadata)P_0).Actions = (EntityActionsMetadata)P_1;
	}

	internal static object AKn3LabdRWww6uyU8Ydd(Type type, Type attributeType, bool inherit)
	{
		return type.GetReflectionCustomAttributes(attributeType, inherit);
	}

	internal static Type luY4dCbdqdrYeoMnf6IJ(object P_0)
	{
		return ((TablePartAttribute)P_0).TablePartType;
	}

	internal static void kAi9VXbdKnTAuSWTm4QJ(object P_0, Type value)
	{
		((TablePartMetadata)P_0).DeclaringType = value;
	}

	internal static void o1gF4NbdXKddorlqXlai(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static Type UcJxLhbdTKIoRmoAo4Pn(object P_0)
	{
		return ((ImplementAttribute)P_0).InterfaceType;
	}

	internal static EntityMetadataType PZdfZcbdkeggfel0yDKp(object P_0)
	{
		return ((EntityMetadataTypeAttribute)P_0).Type;
	}

	internal static Type G4ppswbdnRCWxyrbf5li(object P_0, object P_1)
	{
		return ((Assembly)P_0).GetReflectionType((string)P_1);
	}

	internal static bool BLVeRwbdO7qvo6d4C1W1(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static bool CaiuSJbd2806THtDdLdT(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static object lOdcPobde3ox0w7WuctH(object P_0)
	{
		return ((InterfaceImplementationAttribute)P_0).InterfaceTypeName;
	}

	internal static void zSU12RbdPlp5SdyfTrSC(object P_0, object P_1)
	{
		((EntityMetadata)P_0).ViewModelMetadata = (DataClassMetadata)P_1;
	}

	internal static bool gxA5fpbd1mI5H7HnfHLx()
	{
		return Locator.Initialized;
	}

	internal static Guid w8ojd4bdN2h9nP2oNp2p(object P_0)
	{
		return ((EntityMetadata)P_0).ImplementationUid;
	}

	internal static object sMk9Iabd3ltQ9tJG6HDF(object P_0, Guid metadataUid)
	{
		return ((MetadataItemManager)P_0).GetSoftPublishedMetadata(metadataUid);
	}

	internal static int IN0xpWbdpMAt1cDhitZm(object P_0)
	{
		return ((List<EntityMetadata>)P_0).Count;
	}

	internal static void ItvkAkbdaGHmfAu5jPyF(object P_0, object P_1)
	{
		MetadataSoftPublishHelper.CopyChanges((IMetadata)P_0, (IMetadata)P_1);
	}

	internal static Guid t8hAWabdDTeMjAp2Scjc(object P_0)
	{
		return ((IMetadata)P_0).Uid;
	}

	internal static void cbCwSdbdtHSPulP8HTqR(object P_0)
	{
		((EntityMetadata)P_0).InitializeImplDefaultForms();
	}

	internal static bool eItW63bdwOs7L4iR5LUU(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static PublicationType B36o0Hbd4utvh7tjYrWJ(object P_0, object P_1)
	{
		return MetadataSoftPublishHelper.IsEqualsObject(P_0, P_1);
	}

	internal static void axqH2Nbd6sTZrLx8YoTp()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
