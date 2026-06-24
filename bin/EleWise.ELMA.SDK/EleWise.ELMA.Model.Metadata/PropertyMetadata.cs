using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Enums;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Metadata;

[Serializable]
[DataContract]
[KnownType(typeof(EntityPropertyMetadata))]
[XmlInclude(typeof(EntityPropertyMetadata))]
public class PropertyMetadata : NamedDocumentedMetadata, IPropertyMetadata, INamedMetadata, IOrderedMetadata, IMetadata, IXsiType
{
	private TypeSettings _settings;

	private bool? _nullable;

	[NonSerialized]
	[XmlIgnore]
	private Guid? _Settings_LastTypeUid;

	[NonSerialized]
	[XmlIgnore]
	private Guid? _Settings_LastSubTypeUid;

	[NonSerialized]
	[XmlIgnore]
	private ITypeDescriptor _Settings_LastTypeDescriptor;

	private static PropertyMetadata RtDDbHbdHOOTiNsN1s9l;

	[GuidSettings(FieldName = "TypeUid")]
	[XmlElement("TypeUid")]
	[Uid("{A9A34502-A707-4A65-BF5C-07CA0DE01B35}")]
	[EntityProperty]
	[Property("{EB6E8DDC-FAFE-4E0E-9018-1A7667012579}")]
	[PublicationBehaviour(PublicationType.Restart)]
	[DataMember]
	public virtual Guid TypeUid
	{
		[CompilerGenerated]
		get
		{
			return _003CTypeUid_003Ek__BackingField;
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
					_003CTypeUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
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

	[DefaultValue(typeof(Guid), "{00000000-0000-0000-0000-000000000000}")]
	[DataMember]
	[GuidSettings(FieldName = "SubTypeUid")]
	[Property("{EB6E8DDC-FAFE-4E0E-9018-1A7667012579}")]
	[Uid("{41C51647-927A-48CD-84CD-74B4E2A5C228}")]
	[XmlElement("SubTypeUid")]
	[EntityProperty]
	[PublicationBehaviour(PublicationType.Restart)]
	public virtual Guid SubTypeUid
	{
		[CompilerGenerated]
		get
		{
			return _003CSubTypeUid_003Ek__BackingField;
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
					_003CSubTypeUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
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

	[TypeSettingsSettings(FieldName = "Settings")]
	[EntityProperty]
	[PublicationBehaviour(PublicationType.Restart)]
	[XmlElement("Settings")]
	[Uid("{5706615A-FB8F-4C02-BC06-48648F5866AD}")]
	[Property("{6B39BAB6-1274-477B-A4E1-4C699EAB4C75}")]
	[DataMember]
	public virtual TypeSettings Settings
	{
		get
		{
			//Discarded unreachable code: IL_0099, IL_00d4, IL_0118, IL_0127, IL_0156, IL_0165, IL_02ce, IL_02dd, IL_0329, IL_03c6, IL_03d5, IL_03e5
			int num = 24;
			int num2 = num;
			ITypeDescriptor typeDescriptor = default(ITypeDescriptor);
			TypeSettings settings = default(TypeSettings);
			IMetadataService metadataService = default(IMetadataService);
			while (true)
			{
				switch (num2)
				{
				case 15:
					typeDescriptor = _Settings_LastTypeDescriptor;
					num2 = 18;
					break;
				case 4:
					if (!_Settings_LastSubTypeUid.HasValue)
					{
						num2 = 21;
						break;
					}
					goto case 19;
				case 6:
					iKgalfbdLfPKKByIghjw(_settings, settings);
					num2 = 14;
					break;
				case 20:
					if (!_Settings_LastTypeUid.HasValue)
					{
						num2 = 26;
						break;
					}
					goto case 4;
				case 24:
					if (!Sttb6CbdrsqkJZcqv0ny(XB9a8Mbdlrsi2mSJAfx6(this), Guid.Empty))
					{
						num2 = 23;
						break;
					}
					goto case 17;
				case 7:
				case 8:
				case 21:
				case 26:
					metadataService = (IMetadataService)iV1QhTbd5Jge5ylo0ekY();
					num2 = 9;
					break;
				case 29:
					if (cnn4VnbdY1UmKrJBPCnZ(_settings.GetType(), eyKRH3bdjvxPJ0j0SX42(typeDescriptor)))
					{
						num2 = 11;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
						{
							num2 = 11;
						}
						break;
					}
					goto case 13;
				case 3:
					_settings = (TypeSettings)Activator.CreateInstance(eyKRH3bdjvxPJ0j0SX42(typeDescriptor));
					num2 = 10;
					break;
				case 13:
				case 14:
				case 16:
				case 23:
					return _settings;
				case 27:
					_Settings_LastTypeDescriptor = typeDescriptor;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
					{
						num2 = 0;
					}
					break;
				default:
					_Settings_LastTypeUid = XB9a8Mbdlrsi2mSJAfx6(this);
					num2 = 28;
					break;
				case 25:
					if (_settings == null)
					{
						num2 = 12;
						break;
					}
					goto case 29;
				case 2:
				case 18:
					if (typeDescriptor != null)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
						{
							num2 = 5;
						}
						break;
					}
					goto case 13;
				case 19:
					if (rCCDC2bdgC2FndbXDFva(_Settings_LastTypeUid.Value, XB9a8Mbdlrsi2mSJAfx6(this)))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
						{
							num2 = 1;
						}
						break;
					}
					goto case 7;
				case 10:
					if (settings == null)
					{
						num2 = 16;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
						{
							num2 = 14;
						}
						break;
					}
					goto case 6;
				case 9:
					if (metadataService != null)
					{
						num2 = 17;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
						{
							num2 = 22;
						}
						break;
					}
					goto case 2;
				case 17:
					typeDescriptor = null;
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
					{
						num2 = 20;
					}
					break;
				case 22:
					typeDescriptor = metadataService.GetTypeDescriptor(XB9a8Mbdlrsi2mSJAfx6(this), k8YeRXbddlj7vTXEikPu(this));
					num2 = 27;
					break;
				case 5:
					if (!cnn4VnbdY1UmKrJBPCnZ(eyKRH3bdjvxPJ0j0SX42(typeDescriptor), null))
					{
						num2 = 13;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto case 25;
				case 1:
					if (!rCCDC2bdgC2FndbXDFva(_Settings_LastSubTypeUid.Value, k8YeRXbddlj7vTXEikPu(this)))
					{
						num2 = 7;
						break;
					}
					goto case 15;
				case 11:
				case 12:
					settings = _settings;
					num2 = 3;
					break;
				case 28:
					_Settings_LastSubTypeUid = k8YeRXbddlj7vTXEikPu(this);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
					{
						num2 = 1;
					}
					break;
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
					_settings = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
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
	[XmlElement("Nullable")]
	[Uid("{874E6155-524A-4AF2-83C0-01CB2BFA7395}")]
	[Property("{9CD56A40-6192-4D8A-840C-C4BD4DFB88EB}")]
	[EntityProperty]
	[BoolSettings(FieldName = "Nullable")]
	public virtual bool Nullable
	{
		get
		{
			//Discarded unreachable code: IL_0055, IL_007e, IL_008d, IL_009d, IL_00ac, IL_00d2, IL_0198, IL_01a7
			int num = 11;
			IMetadataService metadataService = default(IMetadataService);
			bool? defaultNullableValue = default(bool?);
			ITypeDescriptor typeDescriptor = default(ITypeDescriptor);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					object obj;
					switch (num2)
					{
					case 11:
						if (!_nullable.HasValue)
						{
							num2 = 10;
							continue;
						}
						goto case 4;
					case 5:
						if (metadataService != null)
						{
							goto end_IL_0012;
						}
						goto case 2;
					case 2:
						obj = null;
						break;
					case 7:
						defaultNullableValue = typeDescriptor.DefaultNullableValue;
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
						{
							num2 = 0;
						}
						continue;
					case 4:
						return _nullable.Value;
					case 10:
						metadataService = (IMetadataService)iV1QhTbd5Jge5ylo0ekY();
						num2 = 5;
						continue;
					case 9:
						if (!defaultNullableValue.HasValue)
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
							{
								num2 = 1;
							}
							continue;
						}
						goto case 7;
					default:
						if (typeDescriptor == null)
						{
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
							{
								num2 = 6;
							}
							continue;
						}
						goto case 8;
					case 3:
						return defaultNullableValue.Value;
					case 1:
					case 6:
						return !oC1a5dbdsicAI5cjWyGq(this);
					case 8:
						defaultNullableValue = typeDescriptor.DefaultNullableValue;
						num2 = 9;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
						{
							num2 = 3;
						}
						continue;
					case 12:
						obj = CJnD7KbdUSO69p6RYexl(metadataService, TypeUid, k8YeRXbddlj7vTXEikPu(this));
						break;
					}
					typeDescriptor = (ITypeDescriptor)obj;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
					{
						num2 = 0;
					}
					continue;
					end_IL_0012:
					break;
				}
				num = 12;
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
					_nullable = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
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

	[Uid("{1F411BCF-E8D7-441D-9542-11CB185CB721}")]
	[XmlElement("Required")]
	[Property("{9CD56A40-6192-4D8A-840C-C4BD4DFB88EB}")]
	[EntityProperty]
	[BoolSettings(FieldName = "Required")]
	[DefaultValue(false)]
	[DataMember]
	[PublicationBehaviour(PublicationType.Delta)]
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

	[Uid("{DD6F5099-21D1-40F1-B711-D066687491C4}")]
	[Property("{849C1AC9-4D46-4194-8CBB-43F84ADF9C17}", "{EFE13E18-65B4-4ABE-8D27-53C94571DE75}")]
	[XmlElement("CalculateType")]
	[EntityProperty]
	[PublicationBehaviour(PublicationType.Delta)]
	[DefaultValue(PropertyCalculateType.None)]
	[DataMember]
	[EnumSettings(FieldName = "CalculateType")]
	public virtual PropertyCalculateType CalculateType
	{
		[CompilerGenerated]
		get
		{
			return _003CCalculateType_003Ek__BackingField;
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
					_003CCalculateType_003Ek__BackingField = value;
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

	[DefaultValue("")]
	[PublicationBehaviour(PublicationType.Restart)]
	[EntityProperty]
	[Property("{9B9AAC17-22BB-425C-AA93-9C02C5146965}")]
	[StringSettings(FieldName = "SQLFormula", MaxValueString = "2147483647")]
	[XmlElement("SQLFormula")]
	[Uid("{79E1F179-10D5-461E-A2A0-A048D709642F}")]
	public virtual string SQLFormula
	{
		[CompilerGenerated]
		get
		{
			return _003CSQLFormula_003Ek__BackingField;
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
					_003CSQLFormula_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
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
	[StringSettings(FieldName = "CalculateScript", MaxValueString = "2147483647")]
	[DefaultValue("")]
	[PublicationBehaviour(PublicationType.Delta)]
	[EditingExtensibleClass]
	[Uid("{0700898A-667A-47A9-8F59-01C1F2AD89A0}")]
	[XmlElement("CalculateScript")]
	[Property("{9B9AAC17-22BB-425C-AA93-9C02C5146965}")]
	public virtual string CalculateScript
	{
		[CompilerGenerated]
		get
		{
			return _003CCalculateScript_003Ek__BackingField;
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
					_003CCalculateScript_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
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

	[BoolSettings(FieldName = "IsSystem")]
	[DefaultValue(false)]
	[Property("{9CD56A40-6192-4D8A-840C-C4BD4DFB88EB}")]
	[Uid("{E88609C0-4E54-4D4D-8A58-CB3398C02A0C}")]
	[EntityProperty]
	[XmlElement("IsSystem")]
	[DataMember]
	public virtual bool IsSystem
	{
		[CompilerGenerated]
		get
		{
			return _003CIsSystem_003Ek__BackingField;
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
					_003CIsSystem_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
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
	[GuidSettings(FieldName = "OwnerPropertyUid")]
	[DataMember]
	[XmlElement("OwnerPropertyUid")]
	[Uid("{5B27FFB7-C2CB-4A7E-8D9E-AED8140A6589}")]
	[Property("{EB6E8DDC-FAFE-4E0E-9018-1A7667012579}")]
	public virtual Guid OwnerPropertyUid
	{
		[CompilerGenerated]
		get
		{
			return _003COwnerPropertyUid_003Ek__BackingField;
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
					_003COwnerPropertyUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[XmlElement("ViewSettings")]
	[SimpleTypeSettings(FieldName = "ViewSettings")]
	[Property("{66C7898B-E56B-49E0-BFB8-9F9C4A7A0C52}")]
	[EntityProperty]
	[Uid("{7B4310DE-EF68-4057-93CA-6C4301DB0B8C}")]
	public virtual PropertyViewSettings ViewSettings
	{
		[CompilerGenerated]
		get
		{
			return _003CViewSettings_003Ek__BackingField;
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
					_003CViewSettings_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
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

	[Uid("{8D4B9B4A-B06C-42DB-87CC-09FD659EB912}")]
	[EntityProperty]
	[Int32Settings(FieldName = "Order")]
	[Property("{D6B44BCE-B236-424D-AA74-D80DA3C8DB75}")]
	[XmlElement("Order")]
	[DataMember]
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
				case 0:
					return;
				case 1:
					_003COrder_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[EntityProperty]
	[Int32Settings(FieldName = "TableColumnWidth")]
	[Property("{D6B44BCE-B236-424D-AA74-D80DA3C8DB75}")]
	[DefaultValue(200)]
	[Uid("{C038252D-3F3F-4CD0-AE21-02C505BB8EC2}")]
	[XmlElement("TableColumnWidth")]
	public virtual int TableColumnWidth
	{
		[CompilerGenerated]
		get
		{
			return _003CTableColumnWidth_003Ek__BackingField;
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
					_003CTableColumnWidth_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[EnumSettings(FieldName = "TableCellAlignment")]
	[Property("{849C1AC9-4D46-4194-8CBB-43F84ADF9C17}", "fd854dfc-44d7-4232-9408-d193a30c7d6d")]
	[Uid("{3F6C72BB-0851-4C8C-8CF3-D9775DFDBC5E}")]
	[XmlElement("TableCellAlignment")]
	[DefaultValue(LineAlignment.Left)]
	[EntityProperty]
	public virtual LineAlignment TableCellAlignment
	{
		[CompilerGenerated]
		get
		{
			return _003CTableCellAlignment_003Ek__BackingField;
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
					_003CTableCellAlignment_003Ek__BackingField = value;
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

	[Property("{9CD56A40-6192-4D8A-840C-C4BD4DFB88EB}")]
	[DataMember]
	[EntityProperty]
	[BoolSettings(FieldName = "Sortable")]
	[DefaultValue(true)]
	[Uid("{0D2E132A-6E97-4E9A-BDAB-6119B5BEAE6E}")]
	[XmlElement("Sortable")]
	public virtual bool Sortable
	{
		[CompilerGenerated]
		get
		{
			return _003CSortable_003Ek__BackingField;
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
					_003CSortable_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[Uid("{55B6659D-BC65-496B-9841-66EC93E4B586}")]
	[Property("{9CD56A40-6192-4D8A-840C-C4BD4DFB88EB}")]
	[EntityProperty]
	[DefaultValue(true)]
	[DataMember]
	[XmlElement("Groupable")]
	[BoolSettings(FieldName = "Groupable")]
	public virtual bool Groupable
	{
		[CompilerGenerated]
		get
		{
			return _003CGroupable_003Ek__BackingField;
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
					_003CGroupable_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[PublicationBehaviour(PublicationType.Restart)]
	public virtual List<PropertyHandlerInfo> Handlers { get; set; }

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
				case 0:
					return;
				case 1:
					_003CDeclaringType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[Uid("{47062245-AA79-44A8-84C2-B3E14DBDDBF6}")]
	[StringSettings(FieldName = "OnChangeScriptName", MaxValueString = "2147483647")]
	[DefaultValue("")]
	[Property("{9B9AAC17-22BB-425C-AA93-9C02C5146965}")]
	[XmlElement("OnChangeScriptName")]
	[EntityProperty]
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
				case 1:
					_003COnChangeScriptName_003Ek__BackingField = value;
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

	[Uid("{256EE072-B1FD-44D7-B678-B7FDF36FA0E8}")]
	[PublicationBehaviour(PublicationType.Restart)]
	[XmlElement("TypeResolver")]
	[DataMember]
	[Property("{EB6E8DDC-FAFE-4E0E-9018-1A7667012579}")]
	[GuidSettings(FieldName = "TypeResolver")]
	[EntityProperty]
	public virtual Guid TypeResolver
	{
		[CompilerGenerated]
		get
		{
			return _003CTypeResolver_003Ek__BackingField;
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
					_003CTypeResolver_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
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

	public virtual PropertyMetadataAdditionalAttribute[] AdditionalAttributes
	{
		[CompilerGenerated]
		get
		{
			return _003CAdditionalAttributes_003Ek__BackingField;
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
					_003CAdditionalAttributes_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
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
			return Uid;
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
					Uid = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public PropertyMetadata()
	{
		//Discarded unreachable code: IL_001a
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 6;
		while (true)
		{
			switch (num)
			{
			case 3:
				DofdHtbdyn4mLdvxsRCZ(this, new PropertyViewSettings());
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
				{
					num = 1;
				}
				break;
			case 7:
				Groupable = true;
				num = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
				{
					num = 8;
				}
				break;
			case 1:
			{
				Handlers = new List<PropertyHandlerInfo>();
				int num2 = 2;
				num = num2;
				break;
			}
			default:
				DVslkBbdmvC4Y9EDq70X(this, "");
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
				{
					num = 3;
				}
				break;
			case 8:
				N8hqX8bd9jHfG1ud0vX7(this, 200);
				num = 5;
				break;
			case 5:
				return;
			case 6:
				CfAjJ5bdxPrJXhdgMfv9(this, "");
				num = 9;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
				{
					num = 3;
				}
				break;
			case 2:
				ftrRYGbdMsl1veLo6xt2(this, LineAlignment.Left);
				num = 4;
				break;
			case 4:
				Ut8UOwbdJBbPTONoDuAo(this, true);
				num = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
				{
					num = 4;
				}
				break;
			case 9:
				CxQNHHbd0iWcqWKsKsPC(this, "");
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual bool ShouldSerializeSubTypeUid()
	{
		return k8YeRXbddlj7vTXEikPu(this) != Guid.Empty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual bool ShouldSerializeOwnerPropertyUid()
	{
		return Sttb6CbdrsqkJZcqv0ny(Mjh5gCbdcea0Vm6rJGUi(this), Guid.Empty);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual bool ShouldSerializeHandlers()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (Handlers != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
					{
						num2 = 0;
					}
					break;
				}
				return false;
			default:
				return KpwIv9bdzGlBQ8RJcjeR(Handlers) > 0;
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual bool ShouldSerializeTypeResolver()
	{
		return Sttb6CbdrsqkJZcqv0ny(TypeResolver, Guid.Empty);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual bool ShouldSerializeAdditionalAttributes()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return ((Array)zPYPnfblFZARgZ4kisr4(this)).Length != 0;
			case 1:
				if (zPYPnfblFZARgZ4kisr4(this) == null)
				{
					return false;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public virtual void LoadFromPropertyInfo(PropertyInfo propertyInfo, PropertyMetadata filterTargetPropertyMetadata)
	{
		//Discarded unreachable code: IL_01b6, IL_01c5, IL_01d0, IL_0279, IL_02b1, IL_02d7, IL_02e6, IL_031c, IL_0386, IL_03be, IL_03cd, IL_04a4, IL_05a9, IL_0632, IL_0641, IL_0651, IL_0660, IL_0670, IL_067f, IL_06d6, IL_09b6, IL_09c5, IL_09d0, IL_0a74, IL_0a93, IL_0aa2, IL_0acf, IL_0b05, IL_0b4b, IL_0b5a, IL_0bf3, IL_0c25, IL_0c96, IL_0ca5
		int num = 91;
		IEnumerator<ViewAttribute> enumerator2 = default(IEnumerator<ViewAttribute>);
		ViewAttribute current2 = default(ViewAttribute);
		PropertyAttribute attribute12 = default(PropertyAttribute);
		XmlReader xmlReader = default(XmlReader);
		ITypeDescriptor typeDescriptor = default(ITypeDescriptor);
		IEnumerable<ViewAttribute> enumerable2 = default(IEnumerable<ViewAttribute>);
		ITypeDescriptor typeDescriptor2 = default(ITypeDescriptor);
		PropertyDeclarationTypeAttribute attribute5 = default(PropertyDeclarationTypeAttribute);
		OwnerPropertyUidAttribute attribute6 = default(OwnerPropertyUidAttribute);
		PropertyInfo reflectionProperty = default(PropertyInfo);
		RequiredAttribute attribute18 = default(RequiredAttribute);
		TypeSettings attribute17 = default(TypeSettings);
		PropertyMetadataAdditionalAttributesAttribute attribute9 = default(PropertyMetadataAdditionalAttributesAttribute);
		CalculateTypeAttribute attribute13 = default(CalculateTypeAttribute);
		OrderAttribute attribute11 = default(OrderAttribute);
		IEnumerable<PropertyHandlerAttribute> enumerable = default(IEnumerable<PropertyHandlerAttribute>);
		GroupableAttribute attribute4 = default(GroupableAttribute);
		TableColumnWidthAttribute attribute14 = default(TableColumnWidthAttribute);
		TypeFilterPropertyResolverAttribute attribute = default(TypeFilterPropertyResolverAttribute);
		EleWise.ELMA.Model.Attributes.DescriptionAttribute attribute3 = default(EleWise.ELMA.Model.Attributes.DescriptionAttribute);
		TableCellAlignmentAttribute attribute10 = default(TableCellAlignmentAttribute);
		SystemPropertyAttribute attribute20 = default(SystemPropertyAttribute);
		SQLFormulaAttribute attribute16 = default(SQLFormulaAttribute);
		EleWise.ELMA.Model.Attributes.DisplayNameAttribute attribute15 = default(EleWise.ELMA.Model.Attributes.DisplayNameAttribute);
		IEnumerator<PropertyHandlerAttribute> enumerator = default(IEnumerator<PropertyHandlerAttribute>);
		PropertyHandlerAttribute current = default(PropertyHandlerAttribute);
		UidAttribute attribute19 = default(UidAttribute);
		SortableAttribute attribute7 = default(SortableAttribute);
		CalculateScriptAttribute attribute8 = default(CalculateScriptAttribute);
		OnChangeScriptNameAttribute attribute2 = default(OnChangeScriptNameAttribute);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 54:
					try
					{
						while (true)
						{
							IL_022d:
							int num7;
							if (!ptKDqiblw0kRcFxLCu62(enumerator2))
							{
								num7 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
								{
									num7 = 1;
								}
								goto IL_01d4;
							}
							goto IL_01ee;
							IL_01ee:
							current2 = enumerator2.Current;
							num7 = 2;
							goto IL_01d4;
							IL_01d4:
							while (true)
							{
								switch (num7)
								{
								case 2:
									((PropertyViewSettings)Qk5wv0blRchur0eYcmoh(this)).Attributes.Add(current2);
									num7 = 3;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
									{
										num7 = 3;
									}
									continue;
								case 3:
									goto IL_022d;
								case 1:
									goto end_IL_022d;
								}
								break;
							}
							goto IL_01ee;
							continue;
							end_IL_022d:
							break;
						}
					}
					finally
					{
						if (enumerator2 != null)
						{
							int num8 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
							{
								num8 = 0;
							}
							while (true)
							{
								switch (num8)
								{
								default:
									enumerator2.Dispose();
									num8 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
									{
										num8 = 1;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
					}
					goto case 37;
				case 20:
					NfNQDfblZSur5w0i9KLF(this, attribute12.SubTypeUid);
					num2 = 28;
					continue;
				case 59:
					try
					{
						XmlSerializer xmlSerializer = new XmlSerializer(typeof(PropertyMetadataAdditionalAttribute[]));
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
						{
							num3 = 0;
						}
						while (true)
						{
							switch (num3)
							{
							case 1:
								return;
							}
							tPFg5Ebldha3iyvagQfW(this, (PropertyMetadataAdditionalAttribute[])xmlSerializer.Deserialize(xmlReader));
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
							{
								num3 = 1;
							}
						}
					}
					finally
					{
						if (xmlReader != null)
						{
							int num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
							{
								num4 = 0;
							}
							while (true)
							{
								switch (num4)
								{
								default:
									XYbmwCblyM9GqsvOL1Yw(xmlReader);
									num4 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
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
					TeSmPPblXcgDYO1Oyqi7(this, false);
					num2 = 75;
					continue;
				case 17:
					typeDescriptor = (ITypeDescriptor)CJnD7KbdUSO69p6RYexl(MetadataServiceContext.Service, XB9a8Mbdlrsi2mSJAfx6(filterTargetPropertyMetadata), k8YeRXbddlj7vTXEikPu(filterTargetPropertyMetadata));
					num2 = 2;
					continue;
				case 55:
					enumerable2 = propertyInfo.GetCustomAttributes(dacJG2blthOeJH9Shm78(typeof(ViewAttribute).TypeHandle), inherit: true).Cast<ViewAttribute>();
					num2 = 5;
					continue;
				case 69:
					ERJUA8bl24cg2Ck5C6wE(this, ErxgSHblOmDn5iSXROPj(typeDescriptor2, filterTargetPropertyMetadata));
					num2 = 38;
					continue;
				case 50:
					if (attribute5 == null)
					{
						num2 = 13;
						continue;
					}
					goto case 94;
				case 90:
					CM5jl9bloDp5wShAlCJh(this, cU2yhCblWBhshxUvaIgJ(propertyInfo));
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
					{
						num2 = 8;
					}
					continue;
				case 47:
					attribute6 = AttributeHelper<OwnerPropertyUidAttribute>.GetAttribute(propertyInfo, inherited: true);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
					{
						num2 = 1;
					}
					continue;
				case 81:
					if (AttributeHelper<NotNullAttribute>.GetAttribute(propertyInfo, inherited: true) == null)
					{
						num2 = 19;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
						{
							num2 = 84;
						}
						continue;
					}
					goto case 76;
				case 23:
					if (!string.IsNullOrEmpty(DisplayName))
					{
						num2 = 41;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
						{
							num2 = 20;
						}
						continue;
					}
					goto case 52;
				case 22:
					if (!(tobuk8blkthVLZtEyS3h(typeDescriptor, filterTargetPropertyMetadata, null) != Guid.Empty))
					{
						num2 = 27;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
						{
							num2 = 57;
						}
						continue;
					}
					goto case 78;
				case 97:
					akCAI2blSBV8IgyC4qq9(this, Y4w1OWblVUmYvx7Fkfvn(filterTargetPropertyMetadata));
					num2 = 58;
					continue;
				case 63:
					if (reflectionProperty != null)
					{
						num2 = 39;
						continue;
					}
					goto case 13;
				case 80:
				case 89:
					attribute18 = AttributeHelper<RequiredAttribute>.GetAttribute(propertyInfo, inherited: true);
					num2 = 48;
					continue;
				case 26:
					attribute17 = AttributeHelper<TypeSettings>.GetAttribute(propertyInfo, inherited: true);
					num2 = 14;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
					{
						num2 = 1;
					}
					continue;
				case 95:
					if (attribute9 != null)
					{
						num2 = 29;
						continue;
					}
					return;
				case 65:
					attribute13 = AttributeHelper<CalculateTypeAttribute>.GetAttribute(propertyInfo, inherited: true);
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
					{
						num2 = 10;
					}
					continue;
				case 60:
					attribute11 = AttributeHelper<OrderAttribute>.GetAttribute(propertyInfo, inherited: false);
					num2 = 35;
					continue;
				case 18:
					if (enumerable != null)
					{
						num2 = 31;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
						{
							num2 = 18;
						}
						continue;
					}
					goto case 21;
				case 43:
					attribute4 = AttributeHelper<GroupableAttribute>.GetAttribute(propertyInfo, inherited: true);
					num2 = 32;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
					{
						num2 = 71;
					}
					continue;
				case 78:
					t1yg9Ebl8bZhQno9yLg3(this, tobuk8blkthVLZtEyS3h(typeDescriptor, filterTargetPropertyMetadata, null));
					num2 = 34;
					continue;
				case 94:
					reflectionProperty = qq5E1PblbpPIlmiuA9Kg(attribute5).GetReflectionProperty(propertyInfo.Name);
					num2 = 63;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
					{
						num2 = 14;
					}
					continue;
				case 37:
				case 42:
				case 85:
					attribute14 = AttributeHelper<TableColumnWidthAttribute>.GetAttribute(propertyInfo, inherited: true);
					num2 = 16;
					continue;
				case 21:
				case 88:
					attribute = AttributeHelper<TypeFilterPropertyResolverAttribute>.GetAttribute(propertyInfo, inherited: true);
					num2 = 65;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
					{
						num2 = 93;
					}
					continue;
				case 61:
					xwICvmbl1nZ8bPVF7P70(this, LbbTnfbleFgAqkDFDW4o(attribute3));
					num2 = 26;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
					{
						num2 = 19;
					}
					continue;
				case 77:
					if (enumerable2.Count() <= 0)
					{
						num2 = 41;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
						{
							num2 = 42;
						}
						continue;
					}
					goto case 99;
				case 91:
					Contract.ArgumentNotNull(propertyInfo, (string)uKIF68blBFSbGeAxV0N0(-1978478350 ^ -1978652424));
					num2 = 88;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
					{
						num2 = 90;
					}
					continue;
				case 72:
					return;
				case 8:
				case 56:
					attribute10 = AttributeHelper<TableCellAlignmentAttribute>.GetAttribute(propertyInfo, inherited: true);
					num2 = 44;
					continue;
				case 86:
					attribute20 = AttributeHelper<SystemPropertyAttribute>.GetAttribute(propertyInfo, inherited: true);
					num2 = 66;
					continue;
				case 75:
					EJtUmqblTqcr04jHdGtq(this, true);
					num = 17;
					break;
				case 32:
					zhn1jIblImS7fnZ9Lfpa(this, v6XqQWbluDDI8dnWhnWK(filterTargetPropertyMetadata));
					num2 = 97;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
					{
						num2 = 21;
					}
					continue;
				case 51:
					Nullable = true;
					num2 = 42;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
					{
						num2 = 89;
					}
					continue;
				case 52:
					zhn1jIblImS7fnZ9Lfpa(this, Name);
					num2 = 68;
					continue;
				case 66:
					kQ4S1YblaZrTnwYUNf97(this, attribute20 != null);
					num2 = 47;
					continue;
				case 28:
				case 87:
					if (filterTargetPropertyMetadata != null)
					{
						num = 32;
						break;
					}
					goto case 38;
				case 53:
					if (attribute3 != null)
					{
						num2 = 61;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
						{
							num2 = 33;
						}
						continue;
					}
					goto case 26;
				default:
					if (attribute12 == null)
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 73;
				case 5:
					if (enumerable2 == null)
					{
						num2 = 85;
						continue;
					}
					goto case 77;
				case 99:
					enumerator2 = enumerable2.GetEnumerator();
					num2 = 54;
					continue;
				case 40:
				case 84:
					if (AttributeHelper<CanBeNullAttribute>.GetAttribute(propertyInfo, inherited: true) == null)
					{
						num2 = 80;
						continue;
					}
					goto case 51;
				case 70:
					attribute16 = AttributeHelper<SQLFormulaAttribute>.GetAttribute(propertyInfo, inherited: true);
					num2 = 36;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
					{
						num2 = 64;
					}
					continue;
				case 4:
				case 30:
					LoadPropertyTypeWithoutMetadata(propertyInfo);
					num = 87;
					break;
				case 34:
					typeDescriptor2 = ((IMetadataService)b7LItJblnsg3LB0XDpow()).GetTypeDescriptor(tobuk8blkthVLZtEyS3h(typeDescriptor, filterTargetPropertyMetadata, null), filterTargetPropertyMetadata.SubTypeUid);
					num2 = 69;
					continue;
				case 24:
					enumerable = ((IEnumerable)ro8eX3blxfApR1IHL1qp(propertyInfo, dacJG2blthOeJH9Shm78(typeof(PropertyHandlerAttribute).TypeHandle), true)).Cast<PropertyHandlerAttribute>();
					num2 = 18;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
					{
						num2 = 3;
					}
					continue;
				case 36:
					if (attribute15 != null)
					{
						num2 = 3;
						continue;
					}
					goto case 23;
				case 38:
				case 45:
				case 57:
					attribute15 = AttributeHelper<EleWise.ELMA.Model.Attributes.DisplayNameAttribute>.GetAttribute(propertyInfo, inherited: true);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
					{
						num2 = 36;
					}
					continue;
				case 31:
					if (enumerable.Count() <= 0)
					{
						num2 = 21;
						continue;
					}
					goto case 27;
				case 62:
					try
					{
						while (true)
						{
							IL_09ee:
							int num5;
							if (!ptKDqiblw0kRcFxLCu62(enumerator))
							{
								num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
								{
									num5 = 0;
								}
								goto IL_09d4;
							}
							goto IL_0a4b;
							IL_0a4b:
							current = enumerator.Current;
							num5 = 2;
							goto IL_09d4;
							IL_09d4:
							while (true)
							{
								switch (num5)
								{
								case 3:
									goto IL_09ee;
								case 2:
								{
									List<PropertyHandlerInfo> handlers = Handlers;
									PropertyHandlerInfo propertyHandlerInfo = new PropertyHandlerInfo();
									wBwaVwblmrsEtjmNaBlv(propertyHandlerInfo, Y50q3Pbl0ATVwYQjKIeX(current));
									handlers.Add(propertyHandlerInfo);
									num5 = 2;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
									{
										num5 = 3;
									}
									continue;
								}
								case 1:
									goto IL_0a4b;
								case 0:
									break;
								}
								break;
							}
							break;
						}
					}
					finally
					{
						int num6;
						if (enumerator == null)
						{
							num6 = 2;
							goto IL_0a78;
						}
						goto IL_0aad;
						IL_0a78:
						switch (num6)
						{
						default:
							goto end_IL_0a63;
						case 2:
							goto end_IL_0a63;
						case 1:
							break;
						case 0:
							goto end_IL_0a63;
						}
						goto IL_0aad;
						IL_0aad:
						XYbmwCblyM9GqsvOL1Yw(enumerator);
						num6 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
						{
							num6 = 0;
						}
						goto IL_0a78;
						end_IL_0a63:;
					}
					goto case 21;
				case 3:
					KgI8eYblPsisvjq4uNM6(this, LbbTnfbleFgAqkDFDW4o(attribute15));
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
					{
						num2 = 67;
					}
					continue;
				case 39:
					LiYEqxblhX6cY3bFHDb8(this, reflectionProperty, null);
					num2 = 83;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
					{
						num2 = 12;
					}
					continue;
				case 83:
					return;
				case 13:
					attribute19 = AttributeHelper<UidAttribute>.GetAttribute(propertyInfo, inherited: false);
					num2 = 74;
					continue;
				case 49:
					attribute12 = AttributeHelper<PropertyAttribute>.GetAttribute(propertyInfo, inherited: false);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
					{
						num2 = 0;
					}
					continue;
				case 6:
					attribute7 = AttributeHelper<SortableAttribute>.GetAttribute(propertyInfo, inherited: true);
					num2 = 25;
					continue;
				case 27:
					enumerator = enumerable.GetEnumerator();
					num2 = 62;
					continue;
				case 33:
					attribute8 = AttributeHelper<CalculateScriptAttribute>.GetAttribute(propertyInfo, inherited: true);
					num2 = 82;
					continue;
				case 29:
					xmlReader = XmlReader.Create(new StringReader((string)wu8okhbl9U002GSbGDbv(attribute9)));
					num2 = 59;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
					{
						num2 = 48;
					}
					continue;
				case 9:
					attribute5 = AttributeHelper<PropertyDeclarationTypeAttribute>.GetAttribute(propertyInfo, inherited: false);
					num2 = 50;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
					{
						num2 = 37;
					}
					continue;
				case 2:
					if (typeDescriptor == null)
					{
						num2 = 45;
						continue;
					}
					goto case 22;
				case 73:
					t1yg9Ebl8bZhQno9yLg3(this, lFMWMDblvIdTaTlErDXR(attribute12));
					num2 = 20;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
					{
						num2 = 4;
					}
					continue;
				case 41:
				case 67:
				case 68:
					attribute3 = AttributeHelper<EleWise.ELMA.Model.Attributes.DescriptionAttribute>.GetAttribute(propertyInfo, inherited: true);
					num2 = 53;
					continue;
				case 96:
					attribute2 = AttributeHelper<OnChangeScriptNameAttribute>.GetAttribute(propertyInfo, inherited: true);
					num2 = 11;
					continue;
				case 76:
					EJtUmqblTqcr04jHdGtq(this, false);
					num2 = 40;
					continue;
				case 7:
					N8hqX8bd9jHfG1ud0vX7(this, 200);
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
					{
						num2 = 0;
					}
					continue;
				case 15:
					Name = (string)Dji1a9blCUR273JFvF1Z(propertyInfo);
					num2 = 49;
					continue;
				case 100:
					attribute9 = AttributeHelper<PropertyMetadataAdditionalAttributesAttribute>.GetAttribute(propertyInfo, inherited: true);
					num2 = 80;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
					{
						num2 = 95;
					}
					continue;
				case 10:
					if (PKu8Shbl6ywo1lKj1bfc(this) != 0)
					{
						num = 56;
						break;
					}
					goto case 7;
				case 74:
					pB1MhjblEGA9cj2s3n7s(this, (attribute19 != null) ? wwDLwcblGfdP87rhIulF(attribute19) : propertyInfo.Name.GetDeterministicGuid());
					num2 = 60;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
					{
						num2 = 1;
					}
					continue;
				case 35:
					kYU9DyblfgsHys65FoVv(this, 100000 - (attribute11?.Order ?? 0) - 1000000);
					num2 = 79;
					continue;
				case 79:
					kYU9DyblfgsHys65FoVv(this, (attribute11 != null) ? mtTRkvblQxSjJc0KlTiP(attribute11) : 0);
					num2 = 15;
					continue;
				case 58:
					Settings = ((filterTargetPropertyMetadata.Settings != null) ? ((TypeSettings)vkqC1VblilZiBQnEvSYu(filterTargetPropertyMetadata)).Clone() : null);
					num2 = 92;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
					{
						num2 = 61;
					}
					continue;
				case 92:
					ViewSettings = ((Qk5wv0blRchur0eYcmoh(filterTargetPropertyMetadata) != null) ? ClassSerializationHelper.CloneObject((PropertyViewSettings)Qk5wv0blRchur0eYcmoh(filterTargetPropertyMetadata)) : null);
					num2 = 46;
					continue;
				case 46:
					pB1MhjblEGA9cj2s3n7s(this, (attribute19 != null) ? wwDLwcblGfdP87rhIulF(attribute19) : TVWqIbblqUIdGsKrTGRA(filterTargetPropertyMetadata));
					num2 = 98;
					continue;
				case 98:
					kYU9DyblfgsHys65FoVv(this, attribute11?.Order ?? LGhBoWblKoy8w7AqMlrW(filterTargetPropertyMetadata));
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
					{
						num2 = 19;
					}
					continue;
				case 14:
					Settings = (TypeSettings)(attribute17 ?? vkqC1VblilZiBQnEvSYu(this));
					num2 = 81;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
					{
						num2 = 0;
					}
					continue;
				case 48:
					TeSmPPblXcgDYO1Oyqi7(this, (attribute18 != null) ? J67jLCblNpgHlNSJSvw5(attribute18) : Required);
					num2 = 65;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
					{
						num2 = 52;
					}
					continue;
				case 12:
					CalculateType = attribute13?.CalculateType ?? PropertyCalculateType.None;
					num2 = 33;
					continue;
				case 82:
					CxQNHHbd0iWcqWKsKsPC(this, (attribute8 != null) ? obakw7bl3TPBqYYnUdTF(attribute8) : null);
					num2 = 70;
					continue;
				case 64:
					CfAjJ5bdxPrJXhdgMfv9(this, (attribute16 != null) ? PyVJe9blp5001mFXOtZQ(attribute16) : null);
					num2 = 86;
					continue;
				case 1:
					OwnerPropertyUid = ((attribute6 != null) ? xNQ6g9blDH17H0RpXreM(attribute6) : Guid.Empty);
					num2 = 55;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
					{
						num2 = 39;
					}
					continue;
				case 16:
					N8hqX8bd9jHfG1ud0vX7(this, (attribute14 != null) ? mXPRygbl4qrpHZvFuLmB(attribute14) : 0);
					num2 = 10;
					continue;
				case 44:
					TableCellAlignment = ((attribute10 != null) ? anI0R2blHbrCGSl2LFjh(attribute10) : LineAlignment.Left);
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
					{
						num2 = 6;
					}
					continue;
				case 25:
					Sortable = attribute7?.Sortable ?? true;
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
					{
						num2 = 43;
					}
					continue;
				case 71:
					yDtOVMbl7nJAuXbShXGt(this, attribute4 == null || UwnPuCblA0c8UaNiKYaU(attribute4));
					num2 = 96;
					continue;
				case 11:
					DVslkBbdmvC4Y9EDq70X(this, (attribute2 != null) ? attribute2.ScriptName : "");
					num2 = 24;
					continue;
				case 93:
					nFJKdablJ1ljdkbDWEtO(this, (attribute != null) ? wXJf1VblMT9Mig2JuanI(attribute) : Guid.Empty);
					num2 = 100;
					continue;
				}
				break;
			}
		}
	}

	protected bool CheckSimpleType(Type type)
	{
		//Discarded unreachable code: IL_005d, IL_006c, IL_007c, IL_008b, IL_00e9
		int num = 5;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				if (type.IsPrimitive)
				{
					num2 = 2;
					break;
				}
				goto case 3;
			case 3:
				return type.IsValueType;
			case 1:
			case 2:
				return true;
			case 4:
				return false;
			case 5:
				if (!cnn4VnbdY1UmKrJBPCnZ(type, typeof(object)))
				{
					num2 = 4;
					break;
				}
				goto case 6;
			case 6:
				if (yXfTQGbllR5w3whLu9Q7(type, dacJG2blthOeJH9Shm78(typeof(string).TypeHandle)))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			}
		}
	}

	protected virtual void LoadPropertyTypeWithoutMetadata(PropertyInfo propertyInfo)
	{
		int num = 1;
		int num2 = num;
		Type type = default(Type);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			default:
				LoadPropertyTypeWithoutMetadata(type);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				type = JQmCCtblrRxkcqdKpafD(propertyInfo);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected void LoadPropertyTypeWithoutMetadata(Type type)
	{
		int num = 4;
		int num2 = num;
		TypeHeaderInfo typeInfoByTypeOrNull = default(TypeHeaderInfo);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				NfNQDfblZSur5w0i9KLF(this, ksGU4Rbl5K9x9f3A4JPe(typeInfoByTypeOrNull));
				num2 = 2;
				break;
			case 5:
				EJtUmqblTqcr04jHdGtq(this, dQXOgyblYAVqMaYivor3(typeInfoByTypeOrNull));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 4:
				typeInfoByTypeOrNull = ModelHelper.GetTypeInfoByTypeOrNull(type);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				t1yg9Ebl8bZhQno9yLg3(this, wujvkmblgB7Rxnou7vDP(typeInfoByTypeOrNull));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				ERJUA8bl24cg2Ck5C6wE(this, FsbKHCbljkHbHFVGLnek(typeInfoByTypeOrNull));
				num2 = 5;
				break;
			}
		}
	}

	internal static void CfAjJ5bdxPrJXhdgMfv9(object P_0, object P_1)
	{
		((PropertyMetadata)P_0).SQLFormula = (string)P_1;
	}

	internal static void CxQNHHbd0iWcqWKsKsPC(object P_0, object P_1)
	{
		((PropertyMetadata)P_0).CalculateScript = (string)P_1;
	}

	internal static void DVslkBbdmvC4Y9EDq70X(object P_0, object P_1)
	{
		((PropertyMetadata)P_0).OnChangeScriptName = (string)P_1;
	}

	internal static void DofdHtbdyn4mLdvxsRCZ(object P_0, object P_1)
	{
		((PropertyMetadata)P_0).ViewSettings = (PropertyViewSettings)P_1;
	}

	internal static void ftrRYGbdMsl1veLo6xt2(object P_0, LineAlignment value)
	{
		((PropertyMetadata)P_0).TableCellAlignment = value;
	}

	internal static void Ut8UOwbdJBbPTONoDuAo(object P_0, bool value)
	{
		((PropertyMetadata)P_0).Sortable = value;
	}

	internal static void N8hqX8bd9jHfG1ud0vX7(object P_0, int value)
	{
		((PropertyMetadata)P_0).TableColumnWidth = value;
	}

	internal static bool BDYk6NbdAwdorkB7Tf06()
	{
		return RtDDbHbdHOOTiNsN1s9l == null;
	}

	internal static PropertyMetadata LL5NFrbd7JEqZhD9CSud()
	{
		return RtDDbHbdHOOTiNsN1s9l;
	}

	internal static Guid k8YeRXbddlj7vTXEikPu(object P_0)
	{
		return ((PropertyMetadata)P_0).SubTypeUid;
	}

	internal static Guid XB9a8Mbdlrsi2mSJAfx6(object P_0)
	{
		return ((PropertyMetadata)P_0).TypeUid;
	}

	internal static bool Sttb6CbdrsqkJZcqv0ny(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static bool rCCDC2bdgC2FndbXDFva(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static object iV1QhTbd5Jge5ylo0ekY()
	{
		return MetadataServiceContext.ServiceOrNull;
	}

	internal static Type eyKRH3bdjvxPJ0j0SX42(object P_0)
	{
		return ((ITypeDescriptor)P_0).SettingsType;
	}

	internal static bool cnn4VnbdY1UmKrJBPCnZ(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static void iKgalfbdLfPKKByIghjw(object P_0, object P_1)
	{
		((TypeSettings)P_0).CopyFrom((TypeSettings)P_1);
	}

	internal static object CJnD7KbdUSO69p6RYexl(object P_0, Guid typeUid, Guid subTypeUid)
	{
		return ((IMetadataService)P_0).GetTypeDescriptor(typeUid, subTypeUid);
	}

	internal static bool oC1a5dbdsicAI5cjWyGq(object P_0)
	{
		return ((PropertyMetadata)P_0).Required;
	}

	internal static Guid Mjh5gCbdcea0Vm6rJGUi(object P_0)
	{
		return ((PropertyMetadata)P_0).OwnerPropertyUid;
	}

	internal static int KpwIv9bdzGlBQ8RJcjeR(object P_0)
	{
		return ((List<PropertyHandlerInfo>)P_0).Count;
	}

	internal static object zPYPnfblFZARgZ4kisr4(object P_0)
	{
		return ((PropertyMetadata)P_0).AdditionalAttributes;
	}

	internal static object uKIF68blBFSbGeAxV0N0(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static Type cU2yhCblWBhshxUvaIgJ(object P_0)
	{
		return ((MemberInfo)P_0).DeclaringType;
	}

	internal static void CM5jl9bloDp5wShAlCJh(object P_0, Type value)
	{
		((PropertyMetadata)P_0).DeclaringType = value;
	}

	internal static Type qq5E1PblbpPIlmiuA9Kg(object P_0)
	{
		return ((PropertyDeclarationTypeAttribute)P_0).Type;
	}

	internal static void LiYEqxblhX6cY3bFHDb8(object P_0, object P_1, object P_2)
	{
		((PropertyMetadata)P_0).LoadFromPropertyInfo((PropertyInfo)P_1, (PropertyMetadata)P_2);
	}

	internal static Guid wwDLwcblGfdP87rhIulF(object P_0)
	{
		return ((UidAttribute)P_0).Uid;
	}

	internal static void pB1MhjblEGA9cj2s3n7s(object P_0, Guid value)
	{
		((AbstractMetadata)P_0).Uid = value;
	}

	internal static void kYU9DyblfgsHys65FoVv(object P_0, int value)
	{
		((PropertyMetadata)P_0).Order = value;
	}

	internal static int mtTRkvblQxSjJc0KlTiP(object P_0)
	{
		return ((OrderAttribute)P_0).Order;
	}

	internal static object Dji1a9blCUR273JFvF1Z(object P_0)
	{
		return ((MemberInfo)P_0).Name;
	}

	internal static Guid lFMWMDblvIdTaTlErDXR(object P_0)
	{
		return ((PropertyAttribute)P_0).TypeUid;
	}

	internal static void t1yg9Ebl8bZhQno9yLg3(object P_0, Guid value)
	{
		((PropertyMetadata)P_0).TypeUid = value;
	}

	internal static void NfNQDfblZSur5w0i9KLF(object P_0, Guid value)
	{
		((PropertyMetadata)P_0).SubTypeUid = value;
	}

	internal static object v6XqQWbluDDI8dnWhnWK(object P_0)
	{
		return ((NamedMetadata)P_0).DisplayName;
	}

	internal static void zhn1jIblImS7fnZ9Lfpa(object P_0, object P_1)
	{
		((NamedMetadata)P_0).DisplayName = (string)P_1;
	}

	internal static object Y4w1OWblVUmYvx7Fkfvn(object P_0)
	{
		return ((NamedMetadata)P_0).Description;
	}

	internal static void akCAI2blSBV8IgyC4qq9(object P_0, object P_1)
	{
		((NamedMetadata)P_0).Description = (string)P_1;
	}

	internal static object vkqC1VblilZiBQnEvSYu(object P_0)
	{
		return ((PropertyMetadata)P_0).Settings;
	}

	internal static object Qk5wv0blRchur0eYcmoh(object P_0)
	{
		return ((PropertyMetadata)P_0).ViewSettings;
	}

	internal static Guid TVWqIbblqUIdGsKrTGRA(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static int LGhBoWblKoy8w7AqMlrW(object P_0)
	{
		return ((PropertyMetadata)P_0).Order;
	}

	internal static void TeSmPPblXcgDYO1Oyqi7(object P_0, bool value)
	{
		((PropertyMetadata)P_0).Required = value;
	}

	internal static void EJtUmqblTqcr04jHdGtq(object P_0, bool value)
	{
		((PropertyMetadata)P_0).Nullable = value;
	}

	internal static Guid tobuk8blkthVLZtEyS3h(object P_0, object P_1, object P_2)
	{
		return ((ITypeDescriptor)P_0).GetFilterType((PropertyMetadata)P_1, (IMetadata)P_2);
	}

	internal static object b7LItJblnsg3LB0XDpow()
	{
		return MetadataServiceContext.Service;
	}

	internal static object ErxgSHblOmDn5iSXROPj(object P_0, object P_1)
	{
		return ((ITypeDescriptor)P_0).CreateSettingsForFilterProperty((PropertyMetadata)P_1);
	}

	internal static void ERJUA8bl24cg2Ck5C6wE(object P_0, object P_1)
	{
		((PropertyMetadata)P_0).Settings = (TypeSettings)P_1;
	}

	internal static object LbbTnfbleFgAqkDFDW4o(object P_0)
	{
		return ((LocalizedStringAttribute)P_0).LocalizedString;
	}

	internal static void KgI8eYblPsisvjq4uNM6(object P_0, object P_1)
	{
		NamedMetadata.SetDisplayName((NamedMetadata)P_0, (SR.LocalizableString)P_1);
	}

	internal static void xwICvmbl1nZ8bPVF7P70(object P_0, object P_1)
	{
		NamedMetadata.SetDescription((NamedMetadata)P_0, (SR.LocalizableString)P_1);
	}

	internal static bool J67jLCblNpgHlNSJSvw5(object P_0)
	{
		return ((RequiredAttribute)P_0).Required;
	}

	internal static object obakw7bl3TPBqYYnUdTF(object P_0)
	{
		return ((CalculateScriptAttribute)P_0).Script;
	}

	internal static object PyVJe9blp5001mFXOtZQ(object P_0)
	{
		return ((SQLFormulaAttribute)P_0).Formula;
	}

	internal static void kQ4S1YblaZrTnwYUNf97(object P_0, bool value)
	{
		((PropertyMetadata)P_0).IsSystem = value;
	}

	internal static Guid xNQ6g9blDH17H0RpXreM(object P_0)
	{
		return ((OwnerPropertyUidAttribute)P_0).Value;
	}

	internal static Type dacJG2blthOeJH9Shm78(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool ptKDqiblw0kRcFxLCu62(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static int mXPRygbl4qrpHZvFuLmB(object P_0)
	{
		return ((TableColumnWidthAttribute)P_0).Value;
	}

	internal static int PKu8Shbl6ywo1lKj1bfc(object P_0)
	{
		return ((PropertyMetadata)P_0).TableColumnWidth;
	}

	internal static LineAlignment anI0R2blHbrCGSl2LFjh(object P_0)
	{
		return ((TableCellAlignmentAttribute)P_0).Value;
	}

	internal static bool UwnPuCblA0c8UaNiKYaU(object P_0)
	{
		return ((GroupableAttribute)P_0).Groupable;
	}

	internal static void yDtOVMbl7nJAuXbShXGt(object P_0, bool value)
	{
		((PropertyMetadata)P_0).Groupable = value;
	}

	internal static object ro8eX3blxfApR1IHL1qp(object P_0, Type P_1, bool P_2)
	{
		return ((MemberInfo)P_0).GetCustomAttributes(P_1, P_2);
	}

	internal static Guid Y50q3Pbl0ATVwYQjKIeX(object P_0)
	{
		return ((PropertyHandlerAttribute)P_0).HandlerUid;
	}

	internal static void wBwaVwblmrsEtjmNaBlv(object P_0, Guid value)
	{
		((PropertyHandlerInfo)P_0).HandlerUid = value;
	}

	internal static void XYbmwCblyM9GqsvOL1Yw(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static Guid wXJf1VblMT9Mig2JuanI(object P_0)
	{
		return ((TypeFilterPropertyResolverAttribute)P_0).Value;
	}

	internal static void nFJKdablJ1ljdkbDWEtO(object P_0, Guid value)
	{
		((PropertyMetadata)P_0).TypeResolver = value;
	}

	internal static object wu8okhbl9U002GSbGDbv(object P_0)
	{
		return ((PropertyMetadataAdditionalAttributesAttribute)P_0).AdditionalAttributes;
	}

	internal static void tPFg5Ebldha3iyvagQfW(object P_0, object P_1)
	{
		((PropertyMetadata)P_0).AdditionalAttributes = (PropertyMetadataAdditionalAttribute[])P_1;
	}

	internal static bool yXfTQGbllR5w3whLu9Q7(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static Type JQmCCtblrRxkcqdKpafD(object P_0)
	{
		return ((PropertyInfo)P_0).PropertyType;
	}

	internal static Guid wujvkmblgB7Rxnou7vDP(object P_0)
	{
		return ((TypeHeaderInfo)P_0).TypeUid;
	}

	internal static Guid ksGU4Rbl5K9x9f3A4JPe(object P_0)
	{
		return ((TypeHeaderInfo)P_0).SubTypeUid;
	}

	internal static object FsbKHCbljkHbHFVGLnek(object P_0)
	{
		return ((TypeHeaderInfo)P_0).Settings;
	}

	internal static bool dQXOgyblYAVqMaYivor3(object P_0)
	{
		return ((TypeHeaderInfo)P_0).Nullable;
	}
}
