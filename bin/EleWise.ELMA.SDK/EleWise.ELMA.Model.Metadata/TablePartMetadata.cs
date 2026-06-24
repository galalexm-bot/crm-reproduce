using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Enums;
using EleWise.ELMA.Model.Mappings;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Metadata;

[Serializable]
[Entity("TablePartMetadata")]
[Uid("{99D587AC-0574-4ACF-B332-66B4490CAA66}")]
[BaseClass("{C40FD1D3-F5D9-4323-9E51-42EBFA77E6DC}")]
[PartialMetadataType]
[MetadataType(typeof(EntityMetadata))]
[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources_TablePartMetadata), "DisplayName")]
[ClassMap(typeof(TablePartMetadataMap))]
public class TablePartMetadata : EntityMetadata, IEntityPropertyMetadata, IPropertyMetadata, INamedMetadata, IOrderedMetadata, IMetadata, IXsiType, ITablePartMetadata, ITablePartExtension
{
	public new const string UID_S = "{99D587AC-0574-4ACF-B332-66B4490CAA66}";

	public new static readonly Guid UID;

	[NonSerialized]
	private TablePartSettings _settings;

	private static TablePartMetadata wiuF14bHs2ReJGq0RkLK;

	[Property("{72ED98CA-F260-4671-9BCD-FF1D80235F47}", "{C40FD1D3-F5D9-4323-9E51-42EBFA77E6DC}")]
	[EntityProperty]
	[EntitySettings(RelationType = RelationType.OneToOne, FieldName = "TablePartOwner")]
	[XmlIgnore]
	[Uid("{2533367F-35E0-4B19-9ACD-BEAAE0F0B2CA}")]
	public virtual EntityMetadata TablePartOwner
	{
		[CompilerGenerated]
		get
		{
			return _003CTablePartOwner_003Ek__BackingField;
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
					_003CTablePartOwner_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[Uid("{62FC7EA7-A56B-4CFB-9CE6-A3F09519C1AE}")]
	[PublicationBehaviour(PublicationType.Restart)]
	[Property("{EB6E8DDC-FAFE-4E0E-9018-1A7667012579}")]
	[GuidSettings(FieldName = "TablePartPropertyUid")]
	[EntityProperty]
	public virtual Guid TablePartPropertyUid
	{
		[CompilerGenerated]
		get
		{
			return _003CTablePartPropertyUid_003Ek__BackingField;
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
					_003CTablePartPropertyUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[StringSettings(FieldName = "TablePartPropertyName")]
	[EntityProperty]
	[PublicationBehaviour(PublicationType.Restart)]
	[Uid("{628CE3E7-113C-4B07-843F-DDC32038A07D}")]
	[Property("{9B9AAC17-22BB-425C-AA93-9C02C5146965}")]
	public virtual string TablePartPropertyName
	{
		[CompilerGenerated]
		get
		{
			return _003CTablePartPropertyName_003Ek__BackingField;
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
					_003CTablePartPropertyName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[Property("{D6B44BCE-B236-424D-AA74-D80DA3C8DB75}")]
	[Int32Settings(FieldName = "Order")]
	[EntityProperty]
	[XmlElement("Order")]
	[Uid("{441F73D9-D24C-43AA-AF83-B43DB09C67A6}")]
	public virtual int Order
	{
		[CompilerGenerated]
		get
		{
			return _003COrder_003Ek__BackingField;
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
					_003COrder_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
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

	[BoolSettings(FieldName = "Required")]
	[EntityProperty]
	[DefaultValue(false)]
	[XmlElement("Required")]
	[Uid("{A055F817-3192-4ABD-88D2-ABFFEA842783}")]
	[Property("{9CD56A40-6192-4D8A-840C-C4BD4DFB88EB}")]
	public virtual bool Required
	{
		[CompilerGenerated]
		get
		{
			return _003CRequired_003Ek__BackingField;
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
					_003CRequired_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
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
	[XmlElement("Input")]
	[BoolSettings(FieldName = "Input")]
	[Uid("{52F7C948-A505-4E35-A6E9-4A62675D5A5F}")]
	[Property("{9CD56A40-6192-4D8A-840C-C4BD4DFB88EB}")]
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
				case 0:
					return;
				case 1:
					_003CInput_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[XmlElement("Output")]
	[DefaultValue(false)]
	[EntityProperty]
	[Uid("{76AA518E-08FA-407E-BDE9-10AFA18B7010}")]
	[Property("{9CD56A40-6192-4D8A-840C-C4BD4DFB88EB}")]
	[BoolSettings(FieldName = "Output")]
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
				case 1:
					_003COutput_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
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

	[XmlIgnore]
	public virtual Type DeclaringType
	{
		[CompilerGenerated]
		get
		{
			return _003CDeclaringType_003Ek__BackingField;
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
					_003CDeclaringType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
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
	[EntityProperty]
	[Property("{9B9AAC17-22BB-425C-AA93-9C02C5146965}")]
	[StringSettings(FieldName = "OnChangeScriptName", MaxValueString = "2147483647")]
	[XmlElement("OnChangeScriptName")]
	[Uid("{F065AF85-2F3A-40BD-B1F1-6CF50DF34FAE}")]
	public virtual string OnChangeScriptName
	{
		[CompilerGenerated]
		get
		{
			return _003COnChangeScriptName_003Ek__BackingField;
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
					_003COnChangeScriptName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[XmlIgnore]
	public override CopyAction CopyAction
	{
		get
		{
			return CopyAction.Clone;
		}
		set
		{
		}
	}

	IEntityMetadata ITablePartExtension.TablePartOwner
	{
		get
		{
			return (IEntityMetadata)tjXHMrbAXdpBaPCX38IG(this);
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
					UylupTbATOlHB8av3QUl(this, value as EntityMetadata);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	string INamedMetadata.Name
	{
		get
		{
			return (string)RlSI1WbA1N0ULRjyvI77(this);
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
					j7d1SibANZnFZVQPIoEs(this, value);
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

	string ITablePartMetadata.Name
	{
		get
		{
			return (string)hiBpKrbA3NXVcXocWPNl(this);
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
					Name = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	string IPropertyMetadata.Name
	{
		get
		{
			return (string)RlSI1WbA1N0ULRjyvI77(this);
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
					TablePartPropertyName = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
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

	Guid IPropertyMetadata.PropertyUid
	{
		get
		{
			return TablePartPropertyUid;
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
					TablePartPropertyUid = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
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

	Guid IPropertyMetadata.TypeUid
	{
		get
		{
			return UID;
		}
		set
		{
		}
	}

	Guid IPropertyMetadata.SubTypeUid
	{
		get
		{
			return Guid.Empty;
		}
		set
		{
		}
	}

	[XmlIgnore]
	TypeSettings IPropertyMetadata.Settings
	{
		get
		{
			//Discarded unreachable code: IL_0083
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return _settings;
				case 3:
					_settings = new TablePartSettings(this);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					if (_settings != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto case 3;
				}
			}
		}
		set
		{
		}
	}

	public override void InitNew()
	{
		int num = 1;
		PropertyMetadata propertyMetadata = default(PropertyMetadata);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					AQZ8CObAG9MBiU2PHuFf(propertyMetadata, EntityDescriptor.UID);
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
					{
						num2 = 4;
					}
					continue;
				case 6:
					propertyMetadata.Name = (string)tsxMBObAofSuGgsARpd9(-309639236 ^ -309602422);
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
				{
					List<ViewAttribute> attributes = ((PropertyViewSettings)WXQTO5bACVxBWj510Nxx(propertyMetadata)).Attributes;
					ViewAttribute viewAttribute = new ViewAttribute();
					eZO9kRbAvedus4pnByRJ(viewAttribute, ViewType.All);
					Nkuo0YbA89W8vT5vaNQS(viewAttribute, Visibility.ForceHidden);
					XbaY3ibAZoDiK4We8b1s(viewAttribute, true);
					attributes.Add(viewAttribute);
					num2 = 8;
					continue;
				}
				case 4:
					cr4UX8bAhdmwTOWlQADq(propertyMetadata, SaF3r5bAbnoPUn2M1Zjs(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1824388195 ^ -1824457005)));
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
					{
						num2 = 3;
					}
					continue;
				case 1:
					base.InitNew();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					propertyMetadata.IsSystem = true;
					num2 = 6;
					continue;
				case 8:
					Properties.Add(propertyMetadata);
					num = 9;
					break;
				case 9:
					return;
				case 12:
					TuycSkbAWdpG5Z2sijdW(this, propertyMetadata.Uid);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
					{
						num2 = 3;
					}
					continue;
				case 11:
				{
					PropertyMetadata propertyMetadata2 = propertyMetadata;
					EntitySettings entitySettings = new EntitySettings();
					SfR4yHbAEQR822Tklqr8(entitySettings, RelationType.OneToOne);
					entitySettings.FieldName = (string)tsxMBObAofSuGgsARpd9(-2112703338 ^ -2112740192);
					pmJDfubAfceXJ18ObMet(entitySettings, CascadeMode.SaveUpdate);
					propertyMetadata2.Settings = entitySettings;
					num = 10;
					break;
				}
				case 10:
					zbccrubAQvLrmIDCAQYP(propertyMetadata.ViewSettings.Attributes);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
					{
						num2 = 2;
					}
					continue;
				default:
					LCS848bABUNk8VPMLw84(this, tELUbRbAFeQINSoYT8jJ());
					num2 = 7;
					continue;
				case 7:
					propertyMetadata = CreateProperty(initNew: true);
					num = 12;
					break;
				}
				break;
			}
		}
	}

	public override void AfterLoad()
	{
		//Discarded unreachable code: IL_00f1, IL_0100, IL_0110
		int num = 2;
		PropertyMetadata propertyMetadata = default(PropertyMetadata);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					propertyMetadata = Properties.FirstOrDefault((PropertyMetadata p) => GNXsC4bADGZScQ6WmadF(w3UjGybApydZS2gGZoxC(p), dsA3KrbAaJW2hHBtHdk4(this)));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					return;
				case 5:
					return;
				case 7:
					return;
				case 2:
					base.AfterLoad();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
					{
						num2 = 1;
					}
					continue;
				case 6:
					if (!(wPUeElbAuY17d11oIyoF(propertyMetadata) is EntitySettings))
					{
						num2 = 3;
						continue;
					}
					break;
				case 4:
					break;
				default:
					if (propertyMetadata == null)
					{
						goto end_IL_0012;
					}
					goto case 6;
				}
				((EntitySettings)wPUeElbAuY17d11oIyoF(propertyMetadata)).CascadeMode = CascadeMode.SaveUpdate;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
				{
					num2 = 5;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 7;
		}
	}

	public override PropertyMetadata CreateProperty(bool initNew = false)
	{
		//Discarded unreachable code: IL_0067
		int num = 2;
		int num2 = num;
		PropertyMetadata propertyMetadata = default(PropertyMetadata);
		while (true)
		{
			switch (num2)
			{
			case 3:
			{
				List<ViewAttribute> attributes = ((PropertyViewSettings)WXQTO5bACVxBWj510Nxx(propertyMetadata)).Attributes;
				ViewAttribute viewAttribute = new ViewAttribute();
				eZO9kRbAvedus4pnByRJ(viewAttribute, ViewType.List);
				viewAttribute.Visibility = Visibility.Visible;
				attributes.Add(viewAttribute);
				num2 = 4;
				break;
			}
			case 5:
				zbccrubAQvLrmIDCAQYP(((PropertyViewSettings)WXQTO5bACVxBWj510Nxx(propertyMetadata)).Attributes);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return propertyMetadata;
			case 2:
				propertyMetadata = base.CreateProperty(initNew);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				if (!initNew)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 5;
			}
		}
	}

	public override void LoadFromType(Type type, bool inherit = true)
	{
		//Discarded unreachable code: IL_00dd
		int num = 9;
		TablePartInfoAttribute attribute2 = default(TablePartInfoAttribute);
		OrderAttribute attribute4 = default(OrderAttribute);
		OnChangeScriptNameAttribute attribute = default(OnChangeScriptNameAttribute);
		RequiredAttribute attribute3 = default(RequiredAttribute);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 13:
					LCS848bABUNk8VPMLw84(this, attribute2.TablePartPropertyUid);
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
					{
						num2 = 2;
					}
					continue;
				case 7:
					ParentPropertyUid = attribute2.ParentPropertyUid;
					num2 = 13;
					continue;
				case 2:
				case 4:
					attribute4 = AttributeHelper<OrderAttribute>.GetAttribute(type, inherited: false);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
					{
						num2 = 1;
					}
					continue;
				case 8:
					attribute2 = AttributeHelper<TablePartInfoAttribute>.GetAttribute(type, inherited: true);
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
					{
						num2 = 1;
					}
					continue;
				case 10:
					if (attribute2 == null)
					{
						num2 = 2;
						continue;
					}
					goto case 7;
				case 12:
					attribute = AttributeHelper<OnChangeScriptNameAttribute>.GetAttribute(type, inherited: true);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
					{
						num2 = 0;
					}
					continue;
				case 11:
					TablePartPropertyName = (string)LvITXLbAIhcqWs8pSnxv(attribute2);
					num2 = 4;
					continue;
				case 9:
					break;
				case 3:
					attribute3 = AttributeHelper<RequiredAttribute>.GetAttribute(type, inherited: false);
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
					{
						num2 = 2;
					}
					continue;
				case 6:
					return;
				case 1:
					GDcsbjbAVvcJAH8DX7il(this, attribute4?.Order ?? 0);
					num2 = 3;
					continue;
				case 5:
					AfEgyxbARNN5ZEk02i8P(this, (attribute3 != null) ? XPkYeObAi0mpvfapHBxt(attribute3) : YpJ7aHbASfZMYU2Mdphj(this));
					num2 = 12;
					continue;
				default:
					YkOFrMbAK4TPYZFWits9(this, (attribute != null) ? QcPeHIbAqC8LdFUOMQ5N(attribute) : "");
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
					{
						num2 = 6;
					}
					continue;
				}
				break;
			}
			base.LoadFromType(type, inherit);
			num = 8;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual bool ShouldSerializeNamespace()
	{
		return false;
	}

	protected override TableView CreateDefaultTableView()
	{
		TableView tableView = base.CreateDefaultTableView();
		mW7ehDbAkR4rxKaKwriU(tableView, true);
		f0Cys8bAnVSiW9DUITyA(tableView, true);
		suHe86bAOxeicXygxOkG(tableView, false);
		vKfUY7bA2a3DRfp5mLNF(tableView, true);
		XsFDMUbAeVkxmW9U74oW(tableView, true);
		UV5pY7bAPkYBt8ave9wQ(tableView, true);
		return tableView;
	}

	public TablePartMetadata()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static TablePartMetadata()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				SingletonReader.JJCZtPuTvSt();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
				{
					num2 = 0;
				}
				break;
			default:
				UID = new Guid((string)tsxMBObAofSuGgsARpd9(-29254301 ^ -29100721));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	internal static bool iiJlZkbHcZv4Wjic7YLg()
	{
		return wiuF14bHs2ReJGq0RkLK == null;
	}

	internal static TablePartMetadata eLaLwjbHzYZe6YSgkqZ0()
	{
		return wiuF14bHs2ReJGq0RkLK;
	}

	internal static Guid tELUbRbAFeQINSoYT8jJ()
	{
		return Guid.NewGuid();
	}

	internal static void LCS848bABUNk8VPMLw84(object P_0, Guid value)
	{
		((TablePartMetadata)P_0).TablePartPropertyUid = value;
	}

	internal static void TuycSkbAWdpG5Z2sijdW(object P_0, Guid value)
	{
		((EntityMetadata)P_0).ParentPropertyUid = value;
	}

	internal static object tsxMBObAofSuGgsARpd9(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object SaF3r5bAbnoPUn2M1Zjs(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static void cr4UX8bAhdmwTOWlQADq(object P_0, object P_1)
	{
		((NamedMetadata)P_0).DisplayName = (string)P_1;
	}

	internal static void AQZ8CObAG9MBiU2PHuFf(object P_0, Guid value)
	{
		((PropertyMetadata)P_0).TypeUid = value;
	}

	internal static void SfR4yHbAEQR822Tklqr8(object P_0, RelationType value)
	{
		((EntitySettings)P_0).RelationType = value;
	}

	internal static void pmJDfubAfceXJ18ObMet(object P_0, CascadeMode value)
	{
		((EntitySettings)P_0).CascadeMode = value;
	}

	internal static void zbccrubAQvLrmIDCAQYP(object P_0)
	{
		((List<ViewAttribute>)P_0).Clear();
	}

	internal static object WXQTO5bACVxBWj510Nxx(object P_0)
	{
		return ((PropertyMetadata)P_0).ViewSettings;
	}

	internal static void eZO9kRbAvedus4pnByRJ(object P_0, ViewType value)
	{
		((ViewAttribute)P_0).ViewType = value;
	}

	internal static void Nkuo0YbA89W8vT5vaNQS(object P_0, Visibility value)
	{
		((ViewAttribute)P_0).Visibility = value;
	}

	internal static void XbaY3ibAZoDiK4We8b1s(object P_0, bool value)
	{
		((ViewAttribute)P_0).ReadOnly = value;
	}

	internal static object wPUeElbAuY17d11oIyoF(object P_0)
	{
		return ((PropertyMetadata)P_0).Settings;
	}

	internal static object LvITXLbAIhcqWs8pSnxv(object P_0)
	{
		return ((TablePartInfoAttribute)P_0).TablePartPropertyName;
	}

	internal static void GDcsbjbAVvcJAH8DX7il(object P_0, int value)
	{
		((TablePartMetadata)P_0).Order = value;
	}

	internal static bool YpJ7aHbASfZMYU2Mdphj(object P_0)
	{
		return ((TablePartMetadata)P_0).Required;
	}

	internal static bool XPkYeObAi0mpvfapHBxt(object P_0)
	{
		return ((RequiredAttribute)P_0).Required;
	}

	internal static void AfEgyxbARNN5ZEk02i8P(object P_0, bool value)
	{
		((TablePartMetadata)P_0).Required = value;
	}

	internal static object QcPeHIbAqC8LdFUOMQ5N(object P_0)
	{
		return ((OnChangeScriptNameAttribute)P_0).ScriptName;
	}

	internal static void YkOFrMbAK4TPYZFWits9(object P_0, object P_1)
	{
		((TablePartMetadata)P_0).OnChangeScriptName = (string)P_1;
	}

	internal static object tjXHMrbAXdpBaPCX38IG(object P_0)
	{
		return ((TablePartMetadata)P_0).TablePartOwner;
	}

	internal static void UylupTbATOlHB8av3QUl(object P_0, object P_1)
	{
		((TablePartMetadata)P_0).TablePartOwner = (EntityMetadata)P_1;
	}

	internal static void mW7ehDbAkR4rxKaKwriU(object P_0, bool value)
	{
		((TableView)P_0).Resizeable = value;
	}

	internal static void f0Cys8bAnVSiW9DUITyA(object P_0, bool value)
	{
		((TableView)P_0).Groupable = value;
	}

	internal static void suHe86bAOxeicXygxOkG(object P_0, bool value)
	{
		((TableView)P_0).GroupableExpand = value;
	}

	internal static void vKfUY7bA2a3DRfp5mLNF(object P_0, bool value)
	{
		((TableView)P_0).CanAdd = value;
	}

	internal static void XsFDMUbAeVkxmW9U74oW(object P_0, bool value)
	{
		((TableView)P_0).CanEdit = value;
	}

	internal static void UV5pY7bAPkYBt8ave9wQ(object P_0, bool value)
	{
		((TableView)P_0).CanDelete = value;
	}

	internal static object RlSI1WbA1N0ULRjyvI77(object P_0)
	{
		return ((TablePartMetadata)P_0).TablePartPropertyName;
	}

	internal static void j7d1SibANZnFZVQPIoEs(object P_0, object P_1)
	{
		((TablePartMetadata)P_0).TablePartPropertyName = (string)P_1;
	}

	internal static object hiBpKrbA3NXVcXocWPNl(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static Guid w3UjGybApydZS2gGZoxC(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static Guid dsA3KrbAaJW2hHBtHdk4(object P_0)
	{
		return ((TablePartMetadata)P_0).TablePartPropertyUid;
	}

	internal static bool GNXsC4bADGZScQ6WmadF(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}
}
