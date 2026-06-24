using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Serialization;
using EleWise.ELMA.Common;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Enums;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Types.Settings;

[Serializable]
public class EntitySettings : SimpleTypeSettings, IRelationTypeSettings
{
	private static class __Resources
	{
		internal static object xuTCyxCXSHiKqZQo7g6P;

		public static string RelationType => SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1998538950 ^ -1998252038), GetRelationTypeValues());

		public static string ShowOnlyGroups => (string)pVKF9ZCXKbdLIfpaKpH8(COqeEUCXqJAlHAV2m3k3(-234299632 ^ -233996776));

		public static string HierarchyDeep => (string)pVKF9ZCXKbdLIfpaKpH8(COqeEUCXqJAlHAV2m3k3(-1334993905 ^ -1335345715));

		public static string HierarchyIndent => (string)pVKF9ZCXKbdLIfpaKpH8(COqeEUCXqJAlHAV2m3k3(0x63ABA4E8 ^ 0x63AE06F2));

		public static string FilterQuery => SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xD3DEF7E ^ 0xD3EA6AA));

		public static string ComputedEqlQuery => (string)pVKF9ZCXKbdLIfpaKpH8(COqeEUCXqJAlHAV2m3k3(-1998538950 ^ -1998252726));

		public static string IsComputedEqlValue => (string)pVKF9ZCXKbdLIfpaKpH8(COqeEUCXqJAlHAV2m3k3(0x53FA00CE ^ 0x53FFA22E));

		public static string HideCreator => (string)pVKF9ZCXKbdLIfpaKpH8(COqeEUCXqJAlHAV2m3k3(0x57A5235E ^ 0x57A08046));

		public static string CanSortProperty => (string)pVKF9ZCXKbdLIfpaKpH8(COqeEUCXqJAlHAV2m3k3(0x76DD48E ^ 0x7687706));

		public static string SortPropertyUid => SR.T((string)COqeEUCXqJAlHAV2m3k3(-867826612 ^ -867981322));

		public static string SortPropertyOrder => (string)pVKF9ZCXKbdLIfpaKpH8(COqeEUCXqJAlHAV2m3k3(0x4EDCBA32 ^ 0x4ED919DE));

		public static string IsSortProperty => (string)pVKF9ZCXKbdLIfpaKpH8(COqeEUCXqJAlHAV2m3k3(-1852837372 ^ -1853204976));

		public static string DisplayType => (string)pVKF9ZCXKbdLIfpaKpH8(COqeEUCXqJAlHAV2m3k3(0xA592A41 ^ 0xA5C8E2B));

		public static string MaxCount => (string)pVKF9ZCXKbdLIfpaKpH8(COqeEUCXqJAlHAV2m3k3(0x1637C429 ^ 0x163260A5));

		private static string GetRelationTypeValues()
		{
			int num = 1;
			int num2 = num;
			IEnumerable<string> values = default(IEnumerable<string>);
			while (true)
			{
				switch (num2)
				{
				default:
					return string.Join((string)COqeEUCXqJAlHAV2m3k3(0x53FA00CE ^ 0x53FA0CCC), values);
				case 1:
					values = ((EnumMetadata)MetadataLoader.LoadMetadata(KWe0EqCXXSuHsCjPUNeN(typeof(RelationType).TypeHandle))).Values.Select((EnumValueMetadata v) => (string)_003C_003Ec.s2A9mbZV7Wbs7YhUPnUj(v.Name, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1637C429 ^ 0x1637078F), _003C_003Ec.OkqKLUZVA550MvxLLDt8(v)));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		internal static bool FafHfXCXikgelKvqtuBj()
		{
			return xuTCyxCXSHiKqZQo7g6P == null;
		}

		internal static __Resources rtTFbWCXRYMlmPEfsHtV()
		{
			return (__Resources)xuTCyxCXSHiKqZQo7g6P;
		}

		internal static object COqeEUCXqJAlHAV2m3k3(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object pVKF9ZCXKbdLIfpaKpH8(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static Type KWe0EqCXXSuHsCjPUNeN(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}
	}

	private static EntitySettings JrynpibBG6b3pZrngF5Z;

	[XmlElement("RelationType")]
	[DefaultValue(RelationType.OneToOne)]
	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources), "RelationType")]
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
				case 1:
					_003CRelationType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
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

	[JsonSerializationIgnore]
	[DefaultValue("")]
	[PublicationBehaviour(PublicationType.Restart)]
	[XmlElement("RelationTableName")]
	public string RelationTableName
	{
		[CompilerGenerated]
		get
		{
			return _003CRelationTableName_003Ek__BackingField;
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
					_003CRelationTableName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DefaultValue("")]
	[PublicationBehaviour(PublicationType.Restart)]
	[JsonSerializationIgnore]
	[XmlElement("ParentColumnName")]
	public string ParentColumnName
	{
		[CompilerGenerated]
		get
		{
			return _003CParentColumnName_003Ek__BackingField;
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
					_003CParentColumnName_003Ek__BackingField = value;
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

	[JsonSerializationIgnore]
	[XmlElement("ChildColumnName")]
	[PublicationBehaviour(PublicationType.Restart)]
	[DefaultValue("")]
	public string ChildColumnName
	{
		[CompilerGenerated]
		get
		{
			return _003CChildColumnName_003Ek__BackingField;
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
					_003CChildColumnName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[PublicationBehaviour(PublicationType.Restart)]
	[XmlIgnore]
	public Guid KeyColumnUid
	{
		[CompilerGenerated]
		get
		{
			return _003CKeyColumnUid_003Ek__BackingField;
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
					_003CKeyColumnUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
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

	[JsonSerializationIgnore]
	[XmlElement("KeyColumnUid")]
	[DefaultValue("")]
	[PublicationBehaviour(PublicationType.Restart)]
	public string KeyColumnUidStr
	{
		get
		{
			int num = 2;
			int num2 = num;
			Guid keyColumnUid = default(Guid);
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (!TEu9QmbBCqEOmkEVnqfw(KeyColumnUid, Guid.Empty))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
						{
							num2 = 1;
						}
						break;
					}
					keyColumnUid = KeyColumnUid;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
					{
						num2 = 0;
					}
					break;
				default:
					return keyColumnUid.ToString();
				case 1:
					return "";
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
				case 0:
					return;
				case 1:
					KeyColumnUid = ((!string.IsNullOrEmpty(value)) ? new Guid(value) : Guid.Empty);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[PublicationBehaviour(PublicationType.Restart)]
	[DefaultValue(CascadeMode.None)]
	[XmlElement("CascadeMode")]
	[JsonSerializationIgnore]
	public CascadeMode CascadeMode
	{
		[CompilerGenerated]
		get
		{
			return _003CCascadeMode_003Ek__BackingField;
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
					_003CCascadeMode_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
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
	[XmlElement("GenerateListInFilter")]
	[JsonSerializationIgnore]
	[DefaultValue(false)]
	public bool GenerateListInFilter
	{
		[CompilerGenerated]
		get
		{
			return _003CGenerateListInFilter_003Ek__BackingField;
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
					_003CGenerateListInFilter_003Ek__BackingField = value;
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

	[JsonSerializationIgnore]
	[DefaultValue(false)]
	[XmlElement("GenerateFilterInFilter")]
	[PublicationBehaviour(PublicationType.Restart)]
	public bool GenerateFilterInFilter
	{
		[CompilerGenerated]
		get
		{
			return _003CGenerateFilterInFilter_003Ek__BackingField;
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
					_003CGenerateFilterInFilter_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
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

	[XmlElement("ShowOnlyGroups")]
	[DefaultValue(false)]
	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources), "ShowOnlyGroups")]
	public bool ShowOnlyGroups
	{
		[CompilerGenerated]
		get
		{
			return _003CShowOnlyGroups_003Ek__BackingField;
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
					_003CShowOnlyGroups_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
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

	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources), "HierarchyDeep")]
	[XmlElement("HierarchyDeep")]
	[DefaultValue(0)]
	public int HierarchyDeep
	{
		[CompilerGenerated]
		get
		{
			return _003CHierarchyDeep_003Ek__BackingField;
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
					_003CHierarchyDeep_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DefaultValue(0)]
	[XmlElement("HierarchyIndent")]
	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources), "HierarchyIndent")]
	public int HierarchyIndent
	{
		[CompilerGenerated]
		get
		{
			return _003CHierarchyIndent_003Ek__BackingField;
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
					_003CHierarchyIndent_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[XmlIgnore]
	public Guid HierarchyParentUid
	{
		[CompilerGenerated]
		get
		{
			return _003CHierarchyParentUid_003Ek__BackingField;
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
					_003CHierarchyParentUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[XmlElement("HierarchyParentUid")]
	[DefaultValue("")]
	[JsonSerializationIgnore]
	public string HierarchyParentUidStr
	{
		get
		{
			int num = 2;
			int num2 = num;
			Guid hierarchyParentUid = default(Guid);
			while (true)
			{
				switch (num2)
				{
				case 1:
					return "";
				case 2:
					if (TEu9QmbBCqEOmkEVnqfw(HierarchyParentUid, Guid.Empty))
					{
						hierarchyParentUid = HierarchyParentUid;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
						{
							num2 = 0;
						}
					}
					else
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
						{
							num2 = 0;
						}
					}
					break;
				default:
					return hierarchyParentUid.ToString();
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
				case 0:
					return;
				case 1:
					HierarchyParentUid = ((!he8uJNbBvST8GuJxMl2O(value)) ? new Guid(value) : Guid.Empty);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources), "FilterQuery")]
	[XmlElement("FilterQuery")]
	[DefaultValue("")]
	[PublicationBehaviour(PublicationType.Restart)]
	public string FilterQuery
	{
		[CompilerGenerated]
		get
		{
			return _003CFilterQuery_003Ek__BackingField;
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
					_003CFilterQuery_003Ek__BackingField = value;
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

	[XmlElement("IsComputedEqlValue")]
	[DefaultValue(false)]
	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources), "IsComputedEqlValue")]
	public bool IsComputedEqlValue
	{
		[CompilerGenerated]
		get
		{
			return _003CIsComputedEqlValue_003Ek__BackingField;
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
					_003CIsComputedEqlValue_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
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

	[XmlElement("ComputedEqlQuery")]
	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources), "ComputedEqlQuery")]
	[PublicationBehaviour(PublicationType.Restart)]
	[DefaultValue("")]
	public string ComputedEqlQuery
	{
		[CompilerGenerated]
		get
		{
			return _003CComputedEqlQuery_003Ek__BackingField;
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
					_003CComputedEqlQuery_003Ek__BackingField = value;
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

	[XmlElement("CanSortProperty")]
	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources), "CanSortProperty")]
	[PublicationBehaviour(PublicationType.Restart)]
	[DefaultValue(false)]
	public bool CanSortProperty
	{
		[CompilerGenerated]
		get
		{
			return _003CCanSortProperty_003Ek__BackingField;
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
					_003CCanSortProperty_003Ek__BackingField = value;
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

	[XmlElement("SortPropertyUid")]
	[DefaultValue("")]
	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources), "SortPropertyUid")]
	[PublicationBehaviour(PublicationType.Restart)]
	public string SortPropertyUidStr
	{
		get
		{
			int num = 1;
			int num2 = num;
			Guid sortPropertyUid = default(Guid);
			while (true)
			{
				switch (num2)
				{
				default:
					return "";
				case 1:
					if (SortPropertyUid != Guid.Empty)
					{
						sortPropertyUid = SortPropertyUid;
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
						{
							num2 = 2;
						}
					}
					else
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
						{
							num2 = 0;
						}
					}
					break;
				case 2:
					return sortPropertyUid.ToString();
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
				case 0:
					return;
				case 1:
					SortPropertyUid = ((!he8uJNbBvST8GuJxMl2O(value)) ? new Guid(value) : Guid.Empty);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[XmlIgnore]
	public Guid SortPropertyUid
	{
		[CompilerGenerated]
		get
		{
			return _003CSortPropertyUid_003Ek__BackingField;
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
					_003CSortPropertyUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
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

	[XmlElement("SortPropertyOrder")]
	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources), "SortPropertyOrder")]
	[PublicationBehaviour(PublicationType.Restart)]
	[DefaultValue(ListSortDirection.Ascending)]
	public ListSortDirection SortPropertyOrder
	{
		[CompilerGenerated]
		get
		{
			return _003CSortPropertyOrder_003Ek__BackingField;
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
					_003CSortPropertyOrder_003Ek__BackingField = value;
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

	[XmlElement("HideCreator")]
	[PublicationBehaviour(PublicationType.Restart)]
	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources), "HideCreator")]
	[DefaultValue(false)]
	public bool HideCreator
	{
		[CompilerGenerated]
		get
		{
			return _003CHideCreator_003Ek__BackingField;
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
					_003CHideCreator_003Ek__BackingField = value;
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

	[PublicationBehaviour(PublicationType.Restart)]
	[DefaultValue(false)]
	[XmlElement("HideSelect")]
	public bool HideSelect
	{
		[CompilerGenerated]
		get
		{
			return _003CHideSelect_003Ek__BackingField;
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
					_003CHideSelect_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DefaultValue("")]
	[XmlIgnore]
	public string Target
	{
		[CompilerGenerated]
		get
		{
			return _003CTarget_003Ek__BackingField;
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
					_003CTarget_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[XmlElement("CopyAction")]
	[DefaultValue(CopyAction.Default)]
	[Property("{849C1AC9-4D46-4194-8CBB-43F84ADF9C17}", "ded50eaa-8f9d-4457-b083-60b8b721705b")]
	[JsonSerializationIgnore]
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
				case 0:
					return;
				case 1:
					_003CCopyAction_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[XmlElement("DisplayType")]
	[DefaultValue(EntityDisplayType.Standard)]
	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources), "DisplayType")]
	public EntityDisplayType DisplayType
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
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

	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources), "MaxCount")]
	[XmlElement("MaxCount")]
	[DefaultValue(100)]
	public int MaxCount
	{
		[CompilerGenerated]
		get
		{
			return _003CMaxCount_003Ek__BackingField;
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
					_003CMaxCount_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
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

	public EntitySettings()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	protected EntitySettings(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		fXoItGbBQBGExTEQ004B();
		base._002Ector(info, context);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public override string[] GetFieldNames()
	{
		//Discarded unreachable code: IL_0052, IL_0061
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (RelationType != 0)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				return new string[1] { base.FieldName };
			default:
				return new string[0];
			}
		}
	}

	public override bool Equals(object obj)
	{
		//Discarded unreachable code: IL_0195, IL_01a4
		int num = 8;
		EntitySettings entitySettings = default(EntitySettings);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 7:
					if (entitySettings == null)
					{
						num = 11;
						break;
					}
					if (base.Equals(obj))
					{
						num2 = 5;
						continue;
					}
					goto default;
				case 9:
					if (!oDyToZbBIhJMMXWShGUx(KeyColumnUid, gt28T1bBuaGUrCqaLPNe(entitySettings)))
					{
						num2 = 6;
						continue;
					}
					goto case 10;
				case 11:
					return false;
				case 4:
					if (ParentColumnName == entitySettings.ParentColumnName)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto default;
				case 1:
					if (!z3BqmObBZxwPDWHMXRP5(ChildColumnName, entitySettings.ChildColumnName))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 9;
				case 5:
					if (z3BqmObBZxwPDWHMXRP5(RelationTableName, p7Mrn6bB8QF1FtSGi7gd(entitySettings)))
					{
						num2 = 4;
						continue;
					}
					goto default;
				case 10:
					if (CanSortProperty == ghPcFJbBVZbtbUyx54x4(entitySettings))
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto default;
				case 2:
					if (SortPropertyOrder == entitySettings.SortPropertyOrder)
					{
						num2 = 3;
						continue;
					}
					goto default;
				case 8:
					entitySettings = obj as EntitySettings;
					num = 7;
					break;
				case 3:
					return oDyToZbBIhJMMXWShGUx(SortPropertyUid, hxHkNAbBSCWU1WA6P3ai(entitySettings));
				default:
					return false;
				}
				break;
			}
		}
	}

	public static string GenerateRelationTableName(EntityMetadata entityMetadata, string propName)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				tdn4f3bBROrVWiLcAm6W(entityMetadata, n9toJYbBixUCVXXrSR0K(0x2A7797B7 ^ 0x2A751879));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
				{
					num2 = 1;
				}
				continue;
			case 1:
				Contract.ArgumentNotNull(propName, (string)n9toJYbBixUCVXXrSR0K(0x26FFCB59 ^ 0x26FD65BB));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			StringBuilder stringBuilder = new StringBuilder();
			HOfb56bBqvGgGEAMiWn7(stringBuilder, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-309639236 ^ -309728950));
			string text = (string)(zoi2HubBKNMCDw2RWKog(entityMetadata) ?? "");
			string text2 = propName;
			if (Yw182YbBX52iUt6r9K2n(text) + Yw182YbBX52iUt6r9K2n(text2) > 26)
			{
				if (text.Length > 13)
				{
					text = GenerateRelationName13(text, 13);
				}
				int num3 = 26 - Yw182YbBX52iUt6r9K2n(text);
				if (Yw182YbBX52iUt6r9K2n(text2) > num3)
				{
					text2 = (string)bippiGbBTmQjY5KsOhVc(text2, num3);
				}
			}
			HOfb56bBqvGgGEAMiWn7(stringBuilder, text);
			HOfb56bBqvGgGEAMiWn7(stringBuilder, n9toJYbBixUCVXXrSR0K(0x3C5338FF ^ 0x3C533485));
			stringBuilder.Append(text2);
			return stringBuilder.ToString();
		}
	}

	private static string GenerateRelationName13(object name, int maxLength)
	{
		//Discarded unreachable code: IL_00a9, IL_0163, IL_0172, IL_0195, IL_01a4, IL_01b3, IL_0220, IL_0250, IL_0270, IL_02ce
		int num = 7;
		string text = default(string);
		char[] array = default(char[]);
		char c = default(char);
		int num3 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 20:
					return "";
				case 6:
					if (Yw182YbBX52iUt6r9K2n(name) > maxLength)
					{
						num2 = 25;
						continue;
					}
					goto case 2;
				case 26:
					text = (string)hCoApDbBOsTTi2kOvdKh(text, 0, maxLength);
					num2 = 11;
					continue;
				case 14:
					array = (char[])A3kR70bBktLeRpQl2N1a(name);
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
					{
						num2 = 8;
					}
					continue;
				case 4:
					if (c > 'Z')
					{
						num2 = 5;
						continue;
					}
					goto case 22;
				case 3:
				case 11:
					return text;
				case 1:
					if (c > '9')
					{
						num2 = 21;
						continue;
					}
					goto case 22;
				case 13:
					if (c < 'A')
					{
						num2 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
						{
							num2 = 9;
						}
						continue;
					}
					goto case 4;
				case 2:
					return (string)name;
				case 25:
					text = "";
					num2 = 14;
					continue;
				case 7:
					if (!he8uJNbBvST8GuJxMl2O(name))
					{
						num2 = 6;
						continue;
					}
					goto case 20;
				case 5:
				case 9:
					if (c < '0')
					{
						num2 = 10;
						continue;
					}
					goto case 1;
				case 22:
					text = (string)IC530NbBnEPt8MDB25S8(text, c.ToString());
					num = 12;
					break;
				case 15:
				case 16:
					if (num3 < array.Length)
					{
						num = 17;
						break;
					}
					goto case 24;
				case 24:
					if (Yw182YbBX52iUt6r9K2n(text) <= 0)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 19;
				case 17:
				case 23:
					c = array[num3];
					num2 = 13;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
					{
						num2 = 11;
					}
					continue;
				case 8:
					num3 = 0;
					num2 = 16;
					continue;
				default:
					text = (string)hCoApDbBOsTTi2kOvdKh(name, 0, maxLength);
					num2 = 3;
					continue;
				case 19:
					if (Yw182YbBX52iUt6r9K2n(text) > maxLength)
					{
						num2 = 26;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
						{
							num2 = 14;
						}
						continue;
					}
					goto case 3;
				case 10:
				case 12:
				case 21:
					num3++;
					num = 15;
					break;
				}
				break;
			}
		}
	}

	public override void SetTypeSettings(PropertiesContainer dict)
	{
		//Discarded unreachable code: IL_0081
		int num = 3;
		int num2 = num;
		bool? value = default(bool?);
		while (true)
		{
			switch (num2)
			{
			default:
				base.SetTypeSettings(dict);
				num2 = 4;
				break;
			case 4:
				return;
			case 5:
				dict.RemoveProperty((string)n9toJYbBixUCVXXrSR0K(0x4EDCBA32 ^ 0x4EDE14CC));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				if (dict.TryGetValue<bool?>((string)n9toJYbBixUCVXXrSR0K(-210725949 ^ -210617027), out value))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto default;
			case 2:
				if (value.HasValue)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 5;
			}
		}
	}

	internal static bool CkjtsWbBEMtlVL6bcnIH()
	{
		return JrynpibBG6b3pZrngF5Z == null;
	}

	internal static EntitySettings OQxYDDbBf1OYhKPML0kt()
	{
		return JrynpibBG6b3pZrngF5Z;
	}

	internal static void fXoItGbBQBGExTEQ004B()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool TEu9QmbBCqEOmkEVnqfw(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static bool he8uJNbBvST8GuJxMl2O(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object p7Mrn6bB8QF1FtSGi7gd(object P_0)
	{
		return ((EntitySettings)P_0).RelationTableName;
	}

	internal static bool z3BqmObBZxwPDWHMXRP5(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static Guid gt28T1bBuaGUrCqaLPNe(object P_0)
	{
		return ((EntitySettings)P_0).KeyColumnUid;
	}

	internal static bool oDyToZbBIhJMMXWShGUx(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static bool ghPcFJbBVZbtbUyx54x4(object P_0)
	{
		return ((EntitySettings)P_0).CanSortProperty;
	}

	internal static Guid hxHkNAbBSCWU1WA6P3ai(object P_0)
	{
		return ((EntitySettings)P_0).SortPropertyUid;
	}

	internal static object n9toJYbBixUCVXXrSR0K(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void tdn4f3bBROrVWiLcAm6W(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object HOfb56bBqvGgGEAMiWn7(object P_0, object P_1)
	{
		return ((StringBuilder)P_0).Append((string)P_1);
	}

	internal static object zoi2HubBKNMCDw2RWKog(object P_0)
	{
		return ((EntityMetadata)P_0).TableName;
	}

	internal static int Yw182YbBX52iUt6r9K2n(object P_0)
	{
		return ((string)P_0).Length;
	}

	internal static object bippiGbBTmQjY5KsOhVc(object P_0, int maxLength)
	{
		return GenerateRelationName13(P_0, maxLength);
	}

	internal static object A3kR70bBktLeRpQl2N1a(object P_0)
	{
		return ((string)P_0).ToCharArray();
	}

	internal static object IC530NbBnEPt8MDB25S8(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object hCoApDbBOsTTi2kOvdKh(object P_0, int P_1, int P_2)
	{
		return ((string)P_0).Substring(P_1, P_2);
	}
}
