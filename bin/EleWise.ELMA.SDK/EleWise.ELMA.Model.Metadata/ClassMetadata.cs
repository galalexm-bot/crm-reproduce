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
using EleWise.ELMA.Globalization;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Enums;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Metadata.PublicationBehaviours;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Modules.Attributes;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Metadata;

[Serializable]
[DataContract]
[XmlRoot("Class")]
public class ClassMetadata : NamedDocumentedMetadata, IRootMetadata, IMetadata, IXsiType, ICodeItemMetadata, IGroupedMetadata
{
	[Component]
	private class Info : IMetadataTypeInfo
	{
		internal static object HoFJD5CHZXgSYxw8XXMe;

		public string Name => (string)R8nX7wCHVkg3HQh6A15Z(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-675505729 ^ -675727601));

		public string Description => (string)R8nX7wCHVkg3HQh6A15Z(TdJ7UHCHSxnu8VjReEdQ(0x1C9495B4 ^ 0x1C913B0A));

		public Type MetadataType => JqVaEiCHi7VTR7ajimeZ(typeof(ClassMetadata).TypeHandle);

		public Type GeneratorType => JqVaEiCHi7VTR7ajimeZ(typeof(ClassGenerator).TypeHandle);

		public Info()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static object R8nX7wCHVkg3HQh6A15Z(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static bool v5YLwUCHu4ss8sADDID6()
		{
			return HoFJD5CHZXgSYxw8XXMe == null;
		}

		internal static Info ueu8cCCHIOwhsUNS0foB()
		{
			return (Info)HoFJD5CHZXgSYxw8XXMe;
		}

		internal static object TdJ7UHCHSxnu8VjReEdQ(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static Type JqVaEiCHi7VTR7ajimeZ(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}
	}

	public const string UID_PROPERTY_NAME = "Uid";

	private string fullTypeName;

	private string _namespace;

	[NonSerialized]
	private List<FormViewItem> _allForms;

	private ClassDefaultForms _defaultForms;

	private SR.LocalizableString namespaceForDisplay;

	internal static ClassMetadata S2vmREbyiUOO08f9MM4f;

	[EleWise.ELMA.Globalization.Localizable]
	[XmlElement("NamespaceForDisplay")]
	[DefaultValue("")]
	public virtual string NamespaceForDisplay
	{
		get
		{
			return (string)Kn08mrbyKsMLJwmK2rpA(namespaceForDisplay);
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
					namespaceForDisplay = (SR.LocalizableString)b9hhEWbyXYQdaOrkKXmN(value);
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

	[DefaultValue("")]
	[Uid("{727138AE-897E-429A-BFBA-F2736C78AAED}")]
	[DataMember]
	[StringSettings(MaxValueString = "2000", FieldName = "Namespace")]
	[Property("{9B9AAC17-22BB-425C-AA93-9C02C5146965}")]
	[XmlElement("Namespace")]
	[EntityProperty]
	[PublicationBehaviour(PublicationType.Restart)]
	public virtual string Namespace
	{
		get
		{
			return _namespace;
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
					return;
				case 1:
					_namespace = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
					{
						num2 = 0;
					}
					break;
				default:
					OnNamespaceChanged();
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[Uid("{28D08347-616F-4B53-BFE2-913AA67CF7DC}")]
	[EntityProperty]
	[Int64Settings(FieldName = "GroupId")]
	[XmlElement("GroupId")]
	[Property("{D90A59AF-7E47-48C5-8C4C-DAD04834E6E3}")]
	[DataMember]
	[DefaultValue(0L)]
	public virtual long GroupId
	{
		[CompilerGenerated]
		get
		{
			return _003CGroupId_003Ek__BackingField;
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
					_003CGroupId_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
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

	[XmlElement("ShowInTypeTree")]
	[DataMember]
	[DefaultValue(true)]
	public virtual bool ShowInTypeTree
	{
		[CompilerGenerated]
		get
		{
			return _003CShowInTypeTree_003Ek__BackingField;
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
					_003CShowInTypeTree_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[XmlElement("ShowInDesigner")]
	[DefaultValue(true)]
	[DataMember]
	public virtual bool ShowInDesigner
	{
		[CompilerGenerated]
		get
		{
			return _003CShowInDesigner_003Ek__BackingField;
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
					_003CShowInDesigner_003Ek__BackingField = value;
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

	[Property("{EB6E8DDC-FAFE-4E0E-9018-1A7667012579}")]
	[EntityProperty]
	[DefaultValue(typeof(Guid), "{00000000-0000-0000-0000-000000000000}")]
	[PublicationBehaviour(PublicationType.Restart)]
	[GuidSettings(FieldName = "BaseClassUid")]
	[XmlElement("BaseClassUid")]
	[Uid("{8A4A8E1E-084D-43D7-81C3-8556F6C0F094}")]
	[DataMember]
	public virtual Guid BaseClassUid
	{
		[CompilerGenerated]
		get
		{
			return _003CBaseClassUid_003Ek__BackingField;
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
					_003CBaseClassUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DefaultValue(false)]
	[XmlElement("AllowCreateHeirs")]
	[PublicationBehaviour(PublicationType.Delta)]
	public virtual bool AllowCreateHeirs
	{
		[CompilerGenerated]
		get
		{
			return _003CAllowCreateHeirs_003Ek__BackingField;
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
					_003CAllowCreateHeirs_003Ek__BackingField = value;
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

	[PublicationBehaviour(typeof(NotRestartIfCollectionItemAddBehaviour))]
	[XmlArray("Properties")]
	[Uid("{D4B4BB64-7F91-49D4-9051-B25E4CA74AB2}")]
	[DataMember]
	public virtual List<PropertyMetadata> Properties { get; set; }

	[PublicationBehaviour(PublicationType.Restart)]
	[Uid("{4DB398A9-8063-4535-9BF6-3DEF9537F694}")]
	[DataMember]
	[XmlArray("PropertiesDiffContainer")]
	public virtual List<PropertiesContainer> PropertiesDiffContainer { get; set; }

	[XmlElement("FormsScheme")]
	[DefaultValue(ClassFormsScheme.Simple)]
	public virtual ClassFormsScheme FormsScheme
	{
		[CompilerGenerated]
		get
		{
			return _003CFormsScheme_003Ek__BackingField;
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
					_003CFormsScheme_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[XmlElement("DefaultForms")]
	public virtual ClassDefaultForms DefaultForms
	{
		get
		{
			return _defaultForms;
		}
		set
		{
			//Discarded unreachable code: IL_006c
			int num = 3;
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
					return;
				case 2:
					if (_defaultForms == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				case 3:
					_defaultForms = value;
					num2 = 2;
					continue;
				case 4:
					break;
				}
				VMIB6Xby2I3GWoc4taf9(_defaultForms, this);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
				{
					num2 = 1;
				}
			}
		}
	}

	[XmlElement("InheritForms")]
	[DefaultValue(true)]
	public virtual bool InheritForms
	{
		[CompilerGenerated]
		get
		{
			return _003CInheritForms_003Ek__BackingField;
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
					_003CInheritForms_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
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

	[XmlArray("Forms")]
	public virtual List<FormViewItem> Forms { get; set; }

	[XmlArray("FormTransformations")]
	public virtual List<FormViewItemTransformation> FormTransformations { get; set; }

	[XmlArray("FormViews")]
	public virtual List<FormView> FormViews { get; set; }

	[XmlArray("TableViews")]
	[TableViewsTypeSettings(FieldName = "TableViews")]
	[EntityProperty]
	[Property("{C039DA91-30DE-4681-84D0-842C17D54BD6}")]
	[Uid("{59673B28-A1D7-4DC2-928E-A4E00E3DCA09}")]
	public virtual List<TableView> TableViews { get; set; }

	[XmlElement("DisplayFormat")]
	public virtual string DisplayFormat
	{
		[CompilerGenerated]
		get
		{
			return _003CDisplayFormat_003Ek__BackingField;
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
					_003CDisplayFormat_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[XmlElement("TitlePropertyUid")]
	[Uid("{0731493C-0549-4B96-B16B-FCD8912E3660}")]
	[DataMember]
	[EntityProperty]
	[GuidSettings(FieldName = "TitlePropertyUid")]
	[Property("{EB6E8DDC-FAFE-4E0E-9018-1A7667012579}")]
	public virtual Guid TitlePropertyUid
	{
		[CompilerGenerated]
		get
		{
			return _003CTitlePropertyUid_003Ek__BackingField;
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
					_003CTitlePropertyUid_003Ek__BackingField = value;
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

	[DefaultValue(null)]
	[XmlElement("ImplementedInterfaces")]
	[PublicationBehaviour(typeof(RestartIfCollectionChanged))]
	public virtual List<string> ImplementedInterfaces { get; set; }

	[DefaultValue("")]
	[PublicationBehaviour(PublicationType.Restart)]
	public virtual string CustomCode
	{
		[CompilerGenerated]
		get
		{
			return _003CCustomCode_003Ek__BackingField;
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
					_003CCustomCode_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[PublicationBehaviour(PublicationType.Delta)]
	[DefaultValue("")]
	public virtual string ScriptModuleTypeName
	{
		[CompilerGenerated]
		get
		{
			return _003CScriptModuleTypeName_003Ek__BackingField;
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
					_003CScriptModuleTypeName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
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
	public virtual string OnViewLoadScriptName
	{
		[CompilerGenerated]
		get
		{
			return _003COnViewLoadScriptName_003Ek__BackingField;
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
					_003COnViewLoadScriptName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public virtual string FullTypeName
	{
		get
		{
			int num = 2;
			int num2 = num;
			string text2;
			string text = default(string);
			while (true)
			{
				switch (num2)
				{
				case 2:
					text2 = fullTypeName;
					if (text2 == null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					break;
				case 1:
					text = (fullTypeName = (string)(MFK1rEbyDP45nrajyx0K(Namespace) ? string.Empty : bQXGp5by49UEZfIemyAU(LaN9Ugbyt4xnVB5OkKTf(this), gXxCexbywJ9LUQCUN2yY(-16752921 ^ -16759773))) + (string)BtqGlPby6Uy5jRbNpPO8(this));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
					{
						num2 = 0;
					}
					continue;
				default:
					text2 = text;
					break;
				}
				break;
			}
			return text2;
		}
	}

	public virtual string TypeName => (string)KEu49jbyHyfB5hBPCC2M(this);

	public virtual bool IsInterfaceType => false;

	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual bool ShouldSerializeBaseClassUid()
	{
		return nYidoWbykXsDOoYZarOd(YZA4m6byTq0IaYdXSpsU(this), Guid.Empty);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual bool ShouldSerializeProperties()
	{
		//Discarded unreachable code: IL_0052, IL_0061
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (Properties == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			default:
				return IywOnLbynVbHaOOkjUtM(Properties) > 0;
			case 1:
				return false;
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual bool ShouldSerializePropertiesDiffContainer()
	{
		//Discarded unreachable code: IL_0052, IL_0061
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (PropertiesDiffContainer == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				return zv3efbbyOxN8a7jWq5LT(PropertiesDiffContainer) > 0;
			default:
				return false;
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual bool ShouldSerializeDefaultForms()
	{
		//Discarded unreachable code: IL_0060, IL_006f
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (aaZhMVbyewFSI3wBafF2(this) == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto default;
			default:
				return ((ClassDefaultForms)aaZhMVbyewFSI3wBafF2(this)).ShouldSerialize();
			case 1:
				return false;
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual bool ShouldSerializeForms()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (Forms != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return false;
			default:
				return lsCg6CbyPEcuYaxikCBF(Forms) > 0;
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual bool ShouldSerializeFormTransformations()
	{
		//Discarded unreachable code: IL_0052, IL_0061
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (FormTransformations == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				return FormTransformations.Count > 0;
			default:
				return false;
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual bool ShouldSerializeFormViews()
	{
		//Discarded unreachable code: IL_0063, IL_0072
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (FormViews == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			default:
				return V2bqRoby1Nm0hWDI8urK(FormViews) > 0;
			case 1:
				return false;
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual bool ShouldSerializeTableViews()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (TableViews != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
					{
						num2 = 0;
					}
					break;
				}
				return false;
			default:
				return F2L9YjbyNNDHwyCRbaYc(TableViews) > 0;
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual bool ShouldSerializeTitlePropertyUid()
	{
		return nYidoWbykXsDOoYZarOd(TitlePropertyUid, Guid.Empty);
	}

	public ClassMetadata()
	{
		//Discarded unreachable code: IL_00de, IL_00e3
		mOZYeKby3YBWLnAMYKNC();
		ShowInTypeTree = true;
		ShowInDesigner = true;
		Properties = new List<PropertyMetadata>();
		PropertiesDiffContainer = new List<PropertiesContainer>();
		InheritForms = true;
		Forms = new List<FormViewItem>();
		FormTransformations = new List<FormViewItemTransformation>();
		FormViews = new List<FormView>();
		TableViews = new List<TableView>();
		ImplementedInterfaces = new List<string>();
		CustomCode = "";
		namespaceForDisplay = (SR.LocalizableString)JHYTSLbypH9feifq99H1();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			pXw3FEbya0Fk09o7ZqCo(this, new ClassDefaultForms());
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
			{
				num = 1;
			}
		}
	}

	public virtual PropertyMetadata CreateProperty(bool initNew = false)
	{
		//Discarded unreachable code: IL_0056
		int num = 1;
		int num2 = num;
		PropertyMetadata propertyMetadata = default(PropertyMetadata);
		while (true)
		{
			switch (num2)
			{
			case 4:
				FZrHIAbyAlrXmMCqL2L8(propertyMetadata);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
				{
					num2 = 2;
				}
				break;
			default:
				if (!initNew)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
					{
						num2 = 3;
					}
					break;
				}
				goto case 4;
			case 2:
			case 3:
				return propertyMetadata;
			case 1:
				propertyMetadata = new PropertyMetadata();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override void AfterLoad()
	{
		//Discarded unreachable code: IL_0046, IL_0055, IL_0060, IL_00e2, IL_00f5, IL_0183
		int num = 1;
		int num2 = num;
		List<PropertyMetadata>.Enumerator enumerator = default(List<PropertyMetadata>.Enumerator);
		while (true)
		{
			switch (num2)
			{
			case 2:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 2;
							goto IL_0064;
						}
						goto IL_007a;
						IL_0064:
						switch (num3)
						{
						case 1:
							break;
						default:
							continue;
						case 2:
							return;
						}
						goto IL_007a;
						IL_007a:
						d8Zknoby7Huhd6BcDkFO(enumerator.Current);
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
						{
							num3 = 0;
						}
						goto IL_0064;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
			case 3:
			case 8:
				if (TableViews.Count == 0)
				{
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
					{
						num2 = 7;
					}
					break;
				}
				goto case 5;
			case 6:
				TableViews = new List<TableView>();
				num2 = 8;
				break;
			case 7:
				TableViews.Add(CreateDefaultTableView());
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
				{
					num2 = 5;
				}
				break;
			default:
				if (TableViews != null)
				{
					num2 = 3;
					break;
				}
				goto case 6;
			case 4:
				return;
			case 5:
				enumerator = Properties.GetEnumerator();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				base.AfterLoad();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public virtual IEnumerable<FormViewItem> GetForms()
	{
		if (_allForms != null)
		{
			return _allForms;
		}
		List<FormViewItem> list = new List<FormViewItem>();
		ClassDefaultForms defaultForms = new ClassDefaultForms();
		GetForms(list, defaultForms);
		GetFormsSettings(defaultForms);
		_allForms = list;
		for (int i = 0; i < _allForms.Count; i++)
		{
			_allForms[i] = (FormViewItem)_allForms[i].Clone();
			_allForms[i].MetadataUid = Uid;
		}
		return _allForms;
	}

	public virtual PropertyMetadata GetUidProperty()
	{
		return Properties.FirstOrDefault((PropertyMetadata p1) => _003C_003Ec.bPrnFhCHTMp9qO2qHkat(p1.Name, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638402543 ^ -1638426237)));
	}

	public virtual void LoadFromType(Type type, bool inherit = true)
	{
		//Discarded unreachable code: IL_0240, IL_0278, IL_0287, IL_0316, IL_0349, IL_0391, IL_03a0, IL_03d3, IL_03e2, IL_048a, IL_04a9, IL_04b8, IL_04e5, IL_05bb, IL_05ca, IL_05fe, IL_0608, IL_06c1, IL_06f9, IL_0708, IL_0796, IL_07a5, IL_07b0, IL_0849, IL_0868, IL_0877, IL_0894, IL_08a3, IL_08ea, IL_08f8, IL_09a1, IL_09c0, IL_09cf, IL_09fc, IL_0aa7, IL_0ab7, IL_0ac1, IL_0afc, IL_0b0b, IL_0bbf, IL_0c32, IL_0c45, IL_0d80, IL_0d93, IL_0da2, IL_0dde, IL_0ded, IL_0ebd, IL_0ecc, IL_0ef9, IL_0f76, IL_0f85, IL_10d1, IL_10e1, IL_10eb, IL_10fa, IL_1154, IL_118c, IL_1329, IL_134e, IL_135c, IL_1415, IL_144d, IL_145c, IL_146b, IL_14a3, IL_14c7, IL_14d6, IL_151e, IL_1528, IL_15c1, IL_1601, IL_1610, IL_161c
		int num = 62;
		AssemblyModuleAttribute attribute13 = default(AssemblyModuleAttribute);
		ClassFormsSchemeAttribute attribute15 = default(ClassFormsSchemeAttribute);
		object[] reflectionCustomAttributes = default(object[]);
		object[] array4 = default(object[]);
		IEnumerator<PropertyInfo> enumerator6 = default(IEnumerator<PropertyInfo>);
		NamespaceForDisplayAttribute attribute = default(NamespaceForDisplayAttribute);
		object[] array3 = default(object[]);
		FilterForAttribute attribute7 = default(FilterForAttribute);
		ClassMetadata classMetadata = default(ClassMetadata);
		object[] array6 = default(object[]);
		IEnumerator<FormAttribute> enumerator8 = default(IEnumerator<FormAttribute>);
		FormAttribute current5 = default(FormAttribute);
		object[] array7 = default(object[]);
		ScriptModuleAttribute attribute6 = default(ScriptModuleAttribute);
		TitlePropertyAttribute attribute12 = default(TitlePropertyAttribute);
		ShowInDesignerAttribute attribute8 = default(ShowInDesignerAttribute);
		EleWise.ELMA.Model.Attributes.DisplayNameAttribute attribute17 = default(EleWise.ELMA.Model.Attributes.DisplayNameAttribute);
		IEnumerator<TableViewAttribute> enumerator = default(IEnumerator<TableViewAttribute>);
		TableViewAttribute current7 = default(TableViewAttribute);
		Dictionary<Guid, string> dict = default(Dictionary<Guid, string>);
		List<OverrideExtensibleClassPropertyAttribute>.Enumerator enumerator3 = default(List<OverrideExtensibleClassPropertyAttribute>.Enumerator);
		List<OverrideExtensibleClassPropertyAttribute> list = default(List<OverrideExtensibleClassPropertyAttribute>);
		object[] array = default(object[]);
		IEnumerator<FormTransformationAttribute> enumerator5 = default(IEnumerator<FormTransformationAttribute>);
		FormTransformationAttribute current3 = default(FormTransformationAttribute);
		object[] array5 = default(object[]);
		IEnumerator<FormViewAttribute> enumerator2 = default(IEnumerator<FormViewAttribute>);
		FormViewAttribute current2 = default(FormViewAttribute);
		IEnumerator<InterfaceImplementationAttribute> enumerator4 = default(IEnumerator<InterfaceImplementationAttribute>);
		OverrideExtensibleClassPropertyAttribute current = default(OverrideExtensibleClassPropertyAttribute);
		PropertiesContainer propertiesContainer = default(PropertiesContainer);
		CustomCodeAttribute attribute2 = default(CustomCodeAttribute);
		object[] array2 = default(object[]);
		UidAttribute attribute11 = default(UidAttribute);
		DisplayFormatAttribute attribute9 = default(DisplayFormatAttribute);
		BaseClassAttribute attribute5 = default(BaseClassAttribute);
		GroupIdAttribute attribute4 = default(GroupIdAttribute);
		List<Tuple<ViewType, Guid, Guid, Guid, Guid, bool>> dictionary = default(List<Tuple<ViewType, Guid, Guid, Guid, Guid, bool>>);
		_003C_003Ec__DisplayClass107_0 _003C_003Ec__DisplayClass107_ = default(_003C_003Ec__DisplayClass107_0);
		PropertyMetadata propertyMetadata = default(PropertyMetadata);
		PropertyMetadata propertyMetadata2 = default(PropertyMetadata);
		ShowInTypeTreeAttribute attribute10 = default(ShowInTypeTreeAttribute);
		OnViewLoadScriptNameAttribute attribute3 = default(OnViewLoadScriptNameAttribute);
		EleWise.ELMA.Model.Attributes.DescriptionAttribute attribute16 = default(EleWise.ELMA.Model.Attributes.DescriptionAttribute);
		IEnumerator<ImageAttribute> enumerator7 = default(IEnumerator<ImageAttribute>);
		AllowCreateHeirsAttribute attribute14 = default(AllowCreateHeirsAttribute);
		InterfaceImplementationAttribute current6 = default(InterfaceImplementationAttribute);
		ImageAttribute current4 = default(ImageAttribute);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 32:
					attribute13 = AttributeHelper<AssemblyModuleAttribute>.GetAttribute(type.Assembly);
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
					{
						num2 = 12;
					}
					continue;
				case 3:
					attribute15 = AttributeHelper<ClassFormsSchemeAttribute>.GetAttribute(type, inherited: false);
					num = 72;
					break;
				case 104:
					reflectionCustomAttributes = type.GetReflectionCustomAttributes(typeof(DefaultFormSettingAttribute), inherit: false);
					num2 = 74;
					continue;
				case 83:
					YNajXBbMfAHHjAfVpBX2(this, wctHfXbMEMwOR7XLbkU8(attribute15));
					num2 = 41;
					continue;
				case 105:
					if (array4.Length != 0)
					{
						num2 = 11;
						continue;
					}
					goto case 16;
				case 49:
					enumerator6 = GetPropertyInfosWithMetadata(type, inherit).GetEnumerator();
					num2 = 40;
					continue;
				case 4:
					attribute = AttributeHelper<NamespaceForDisplayAttribute>.GetAttribute(type, inherited: false);
					num = 106;
					break;
				case 73:
					if (array3 == null)
					{
						num2 = 39;
						continue;
					}
					goto case 13;
				case 38:
					attribute7 = AttributeHelper<FilterForAttribute>.GetAttribute(type, inherited: true);
					num2 = 110;
					continue;
				case 45:
					try
					{
						classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(YP2ChHbyzZYUFnYDcocs(attribute7));
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
						{
							num3 = 0;
						}
						switch (num3)
						{
						case 0:
							break;
						}
					}
					catch (Exception ex)
					{
						int num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								rSgql5bMBuZtvR8lwKs9(fLvutabMF8r0auhquvPa(), ex.Message, ex);
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
								{
									num4 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
					goto case 52;
				case 108:
					if (array6.Length == 0)
					{
						num2 = 49;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
						{
							num2 = 90;
						}
						continue;
					}
					goto case 56;
				case 21:
					try
					{
						while (true)
						{
							int num13;
							if (!enumerator8.MoveNext())
							{
								num13 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
								{
									num13 = 1;
								}
								goto IL_03f1;
							}
							goto IL_0431;
							IL_0431:
							current5 = enumerator8.Current;
							int num14 = 2;
							num13 = num14;
							goto IL_03f1;
							IL_03f1:
							while (true)
							{
								switch (num13)
								{
								case 3:
									break;
								default:
									goto IL_0431;
								case 2:
									Forms.Add(current5.Form);
									num13 = 3;
									continue;
								case 1:
									goto end_IL_040b;
								}
								break;
							}
							continue;
							end_IL_040b:
							break;
						}
					}
					finally
					{
						int num15;
						if (enumerator8 == null)
						{
							num15 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
							{
								num15 = 0;
							}
							goto IL_048e;
						}
						goto IL_04c3;
						IL_04c3:
						FvJ0sPbMhu5GbIHDYUmd(enumerator8);
						num15 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
						{
							num15 = 1;
						}
						goto IL_048e;
						IL_048e:
						switch (num15)
						{
						default:
							goto end_IL_0469;
						case 0:
							goto end_IL_0469;
						case 2:
							break;
						case 1:
							goto end_IL_0469;
						}
						goto IL_04c3;
						end_IL_0469:;
					}
					goto case 16;
				case 76:
					if (array7.Length == 0)
					{
						num2 = 25;
						continue;
					}
					goto case 64;
				case 110:
					if (attribute7 == null)
					{
						num2 = 52;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
						{
							num2 = 34;
						}
						continue;
					}
					goto case 85;
				case 68:
					if (classMetadata is EntityMetadata)
					{
						num2 = 109;
						continue;
					}
					return;
				case 77:
					attribute6 = AttributeHelper<ScriptModuleAttribute>.GetAttribute(type, inherited: false);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
					{
						num2 = 1;
					}
					continue;
				case 74:
					if (reflectionCustomAttributes == null)
					{
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
						{
							num2 = 7;
						}
						continue;
					}
					goto case 43;
				case 92:
					attribute12 = AttributeHelper<TitlePropertyAttribute>.GetAttribute(type, inherited: false);
					num = 17;
					break;
				case 59:
					attribute8 = AttributeHelper<ShowInDesignerAttribute>.GetAttribute(type, inherited: true);
					num2 = 13;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
					{
						num2 = 69;
					}
					continue;
				case 80:
					attribute17 = AttributeHelper<EleWise.ELMA.Model.Attributes.DisplayNameAttribute>.GetAttribute(type, inherited: true);
					num2 = 75;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
					{
						num2 = 4;
					}
					continue;
				case 93:
					try
					{
						while (true)
						{
							IL_0626:
							int num18;
							if (!Oh29ewbMbh3pBa5wSCJf(enumerator))
							{
								num18 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
								{
									num18 = 0;
								}
								goto IL_060c;
							}
							goto IL_0678;
							IL_0678:
							current7 = enumerator.Current;
							num18 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
							{
								num18 = 0;
							}
							goto IL_060c;
							IL_060c:
							while (true)
							{
								switch (num18)
								{
								case 3:
									goto IL_0626;
								case 1:
									TableViews.Add(current7.View);
									num18 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
									{
										num18 = 3;
									}
									continue;
								case 2:
									goto IL_0678;
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
						if (enumerator != null)
						{
							int num19 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
							{
								num19 = 1;
							}
							while (true)
							{
								switch (num19)
								{
								case 1:
									FvJ0sPbMhu5GbIHDYUmd(enumerator);
									num19 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
									{
										num19 = 0;
									}
									continue;
								case 0:
									break;
								}
								break;
							}
						}
					}
					goto case 24;
				case 37:
					((ClassDefaultForms)aaZhMVbyewFSI3wBafF2(this)).FormSettingsFromDictionary(dict, reset: true);
					num = 8;
					break;
				case 29:
				case 42:
					if (classMetadata == null)
					{
						num2 = 95;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
						{
							num2 = 26;
						}
						continue;
					}
					goto case 68;
				case 98:
					enumerator3 = list.GetEnumerator();
					num2 = 9;
					continue;
				case 41:
				case 84:
					array = (object[])zK2L0vbMoIPSC44f9DH4(type, typeof(DefaultFormAttribute), inherit: false);
					num2 = 53;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
					{
						num2 = 41;
					}
					continue;
				case 19:
					try
					{
						while (true)
						{
							IL_080d:
							int num9;
							if (!Oh29ewbMbh3pBa5wSCJf(enumerator5))
							{
								num9 = 2;
								goto IL_07b4;
							}
							goto IL_07ce;
							IL_07b4:
							while (true)
							{
								switch (num9)
								{
								case 3:
									FormTransformations.Add((FormViewItemTransformation)kHTFAibMQdGT8HbLOwoD(current3));
									num9 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
									{
										num9 = 1;
									}
									continue;
								case 1:
									goto IL_080d;
								case 2:
									goto end_IL_080d;
								}
								break;
							}
							goto IL_07ce;
							IL_07ce:
							current3 = enumerator5.Current;
							num9 = 3;
							goto IL_07b4;
							continue;
							end_IL_080d:
							break;
						}
					}
					finally
					{
						int num10;
						if (enumerator5 == null)
						{
							num10 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
							{
								num10 = 1;
							}
							goto IL_084d;
						}
						goto IL_0882;
						IL_0882:
						FvJ0sPbMhu5GbIHDYUmd(enumerator5);
						num10 = 2;
						goto IL_084d;
						IL_084d:
						switch (num10)
						{
						case 1:
							goto end_IL_0828;
						case 2:
							goto end_IL_0828;
						}
						goto IL_0882;
						end_IL_0828:;
					}
					goto case 58;
				case 78:
					ImplementedInterfaces = new List<string>();
					num2 = 34;
					continue;
				case 33:
					if (array5 == null)
					{
						num2 = 45;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
						{
							num2 = 55;
						}
						continue;
					}
					goto case 5;
				case 96:
					try
					{
						while (true)
						{
							int num7;
							if (!Oh29ewbMbh3pBa5wSCJf(enumerator2))
							{
								num7 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
								{
									num7 = 1;
								}
								goto IL_08fc;
							}
							goto IL_093c;
							IL_093c:
							current2 = enumerator2.Current;
							num7 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
							{
								num7 = 0;
							}
							goto IL_08fc;
							IL_08fc:
							while (true)
							{
								switch (num7)
								{
								case 3:
									break;
								case 2:
									goto IL_093c;
								default:
									FormViews.Add((FormView)XcQvb4bMCytHmi7dAbOL(current2));
									num7 = 3;
									continue;
								case 1:
									goto end_IL_0916;
								}
								break;
							}
							continue;
							end_IL_0916:
							break;
						}
					}
					finally
					{
						int num8;
						if (enumerator2 == null)
						{
							num8 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
							{
								num8 = 2;
							}
							goto IL_09a5;
						}
						goto IL_09da;
						IL_09da:
						enumerator2.Dispose();
						num8 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
						{
							num8 = 0;
						}
						goto IL_09a5;
						IL_09a5:
						switch (num8)
						{
						default:
							goto end_IL_0980;
						case 2:
							goto end_IL_0980;
						case 1:
							break;
						case 0:
							goto end_IL_0980;
						}
						goto IL_09da;
						end_IL_0980:;
					}
					goto case 50;
				case 89:
					enumerator5 = array6.Cast<FormTransformationAttribute>().GetEnumerator();
					num2 = 19;
					continue;
				case 24:
				case 39:
				case 81:
					Properties = new List<PropertyMetadata>();
					num2 = 23;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
					{
						num2 = 49;
					}
					continue;
				case 70:
					SfmqAPbyJ4GGlNvKL0TY(this, UJoHyvbyMhcA9fsPluGL(type));
					num2 = 102;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
					{
						num2 = 75;
					}
					continue;
				case 31:
					if (array != null)
					{
						num2 = 28;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
						{
							num2 = 18;
						}
						continue;
					}
					goto case 104;
				case 34:
					enumerator4 = array5.Cast<InterfaceImplementationAttribute>().GetEnumerator();
					num2 = 48;
					continue;
				case 9:
					try
					{
						while (true)
						{
							int num5;
							if (!enumerator3.MoveNext())
							{
								num5 = 5;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
								{
									num5 = 8;
								}
								goto IL_0ac5;
							}
							goto IL_0b8e;
							IL_0b8e:
							current = enumerator3.Current;
							num5 = 5;
							goto IL_0ac5;
							IL_0ac5:
							while (true)
							{
								switch (num5)
								{
								case 1:
									PropertiesDiffContainer.Add(propertiesContainer);
									num5 = 4;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
									{
										num5 = 9;
									}
									continue;
								case 5:
									if (!nKWH0DbMIfJucwiyKAw0(tj6SYobMuIHDpy7VsLZL(current)))
									{
										num5 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
										{
											num5 = 0;
										}
										continue;
									}
									break;
								case 3:
								case 4:
								case 9:
									break;
								case 2:
									goto IL_0b8e;
								default:
									propertiesContainer = ClassSerializationHelper.DeserializeObjectByXml<PropertiesContainer>((string)tj6SYobMuIHDpy7VsLZL(current));
									num5 = 7;
									continue;
								case 6:
									if (PropertiesDiffContainer.Contains(propertiesContainer))
									{
										num5 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
										{
											num5 = 3;
										}
										continue;
									}
									goto case 1;
								case 7:
									if (propertiesContainer == null)
									{
										num5 = 4;
										continue;
									}
									goto case 6;
								case 8:
									goto end_IL_0b68;
								}
								break;
							}
							continue;
							end_IL_0b68:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator3).Dispose();
						int num6 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
						{
							num6 = 0;
						}
						switch (num6)
						{
						case 0:
							break;
						}
					}
					goto case 29;
				case 97:
					if (attribute2 != null)
					{
						num = 87;
						break;
					}
					goto case 3;
				case 52:
				case 103:
					array5 = (object[])zK2L0vbMoIPSC44f9DH4(type, kP6cPSbMW61ismYK9DPH(typeof(InterfaceImplementationAttribute).TypeHandle), inherit: false);
					num2 = 33;
					continue;
				case 16:
				case 94:
					array6 = (object[])zK2L0vbMoIPSC44f9DH4(type, kP6cPSbMW61ismYK9DPH(typeof(FormTransformationAttribute).TypeHandle), inherit: false);
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
					{
						num2 = 14;
					}
					continue;
				case 36:
					list = type.GetReflectionCustomAttributes(kP6cPSbMW61ismYK9DPH(typeof(OverrideExtensibleClassPropertyAttribute).TypeHandle), inherit: false).Cast<OverrideExtensibleClassPropertyAttribute>().ToList();
					num2 = 35;
					continue;
				case 20:
					if (array2.Length != 0)
					{
						num2 = 32;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
						{
							num2 = 63;
						}
						continue;
					}
					goto case 50;
				case 67:
					classMetadata = null;
					num2 = 38;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
					{
						num2 = 13;
					}
					continue;
				case 63:
					FormViews = new List<FormView>();
					num2 = 23;
					continue;
				case 62:
					attribute11 = AttributeHelper<UidAttribute>.GetAttribute(type, inherited: false);
					num = 61;
					break;
				case 23:
					enumerator2 = array2.Cast<FormViewAttribute>().GetEnumerator();
					num2 = 96;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
					{
						num2 = 41;
					}
					continue;
				case 101:
					attribute9 = AttributeHelper<DisplayFormatAttribute>.GetAttribute(type, inherited: false);
					num2 = 65;
					continue;
				case 95:
					return;
				case 85:
					if (YP2ChHbyzZYUFnYDcocs(attribute7) != type)
					{
						num2 = 24;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
						{
							num2 = 45;
						}
						continue;
					}
					goto case 52;
				case 7:
				case 8:
					array4 = (object[])zK2L0vbMoIPSC44f9DH4(type, kP6cPSbMW61ismYK9DPH(typeof(FormAttribute).TypeHandle), inherit: false);
					num2 = 15;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
					{
						num2 = 1;
					}
					continue;
				case 35:
					if (list != null)
					{
						num2 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 29;
				case 13:
					if (array3.Length == 0)
					{
						num2 = 64;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
						{
							num2 = 81;
						}
						continue;
					}
					goto case 71;
				case 44:
					attribute5 = AttributeHelper<BaseClassAttribute>.GetAttribute(type, inherited: false);
					num2 = 88;
					continue;
				case 112:
					attribute4 = AttributeHelper<GroupIdAttribute>.GetAttribute(type, inherited: false);
					num2 = 47;
					continue;
				case 6:
				case 25:
				case 91:
					attribute2 = AttributeHelper<CustomCodeAttribute>.GetAttribute(type, inherited: true);
					num2 = 97;
					continue;
				case 18:
					((ClassDefaultForms)aaZhMVbyewFSI3wBafF2(this)).FromDictionary(dictionary);
					num2 = 104;
					continue;
				case 50:
					array3 = (object[])zK2L0vbMoIPSC44f9DH4(type, typeof(TableViewAttribute), inherit: false);
					num2 = 73;
					continue;
				case 57:
					return;
				case 87:
					H5UU5sbMGrbMuLq42iHJ(this, attribute2.GetCode());
					num2 = 3;
					continue;
				case 82:
					if (array2 != null)
					{
						num2 = 20;
						continue;
					}
					goto case 50;
				case 58:
				case 90:
					array2 = (object[])zK2L0vbMoIPSC44f9DH4(type, kP6cPSbMW61ismYK9DPH(typeof(FormViewAttribute).TypeHandle), inherit: false);
					num2 = 82;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
					{
						num2 = 81;
					}
					continue;
				case 30:
					enumerator = array3.Cast<TableViewAttribute>().GetEnumerator();
					num2 = 93;
					continue;
				case 40:
					try
					{
						while (true)
						{
							IL_10b2:
							int num20;
							if (!Oh29ewbMbh3pBa5wSCJf(enumerator6))
							{
								num20 = 4;
								goto IL_0f90;
							}
							goto IL_0fce;
							IL_0f94:
							int num21;
							while (true)
							{
								object obj;
								switch (num21)
								{
								case 5:
									break;
								case 3:
									_003C_003Ec__DisplayClass107_.propertyInfo = enumerator6.Current;
									num21 = 2;
									continue;
								case 7:
									rMYgNYbM84fJvK5BNeTv(propertyMetadata, _003C_003Ec__DisplayClass107_.propertyInfo, propertyMetadata2);
									num21 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
									{
										num21 = 0;
									}
									continue;
								case 2:
									propertyMetadata = CreateProperty();
									num21 = 10;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
									{
										num21 = 0;
									}
									continue;
								case 1:
									Properties.Add(propertyMetadata);
									num21 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
									{
										num21 = 0;
									}
									continue;
								case 10:
									if (classMetadata == null)
									{
										num21 = 8;
										continue;
									}
									goto case 6;
								case 6:
									if (!QbfrH9bMv2h1SgZ2Mylu(_003C_003Ec__DisplayClass107_.propertyInfo, kP6cPSbMW61ismYK9DPH(typeof(PropertyAttribute).TypeHandle), true))
									{
										num21 = 9;
										continue;
									}
									goto case 8;
								default:
									goto IL_10b2;
								case 8:
								case 11:
									obj = null;
									goto IL_111e;
								case 9:
									obj = classMetadata.Properties.FirstOrDefault(_003C_003Ec__DisplayClass107_._003CLoadFromType_003Eb__3);
									goto IL_111e;
								case 4:
									goto end_IL_10b2;
									IL_111e:
									propertyMetadata2 = (PropertyMetadata)obj;
									num20 = 7;
									goto IL_0f90;
								}
								break;
							}
							goto IL_0fce;
							IL_0fce:
							_003C_003Ec__DisplayClass107_ = new _003C_003Ec__DisplayClass107_0();
							num21 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
							{
								num21 = 3;
							}
							goto IL_0f94;
							IL_0f90:
							num21 = num20;
							goto IL_0f94;
							continue;
							end_IL_10b2:
							break;
						}
					}
					finally
					{
						if (enumerator6 != null)
						{
							int num22 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
							{
								num22 = 0;
							}
							while (true)
							{
								switch (num22)
								{
								default:
									FvJ0sPbMhu5GbIHDYUmd(enumerator6);
									num22 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
									{
										num22 = 0;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
					}
					goto case 36;
				case 72:
					if (attribute15 == null)
					{
						num2 = 84;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 83;
				case 64:
					Images = new List<MetadataImage>();
					num2 = 100;
					continue;
				case 26:
					return;
				case 109:
					if (SraP6EbMVJ6NqAkXoRa9((EntityMetadata)classMetadata) == null)
					{
						num2 = 57;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 86;
				case 51:
					attribute10 = AttributeHelper<ShowInTypeTreeAttribute>.GetAttribute(type, inherited: true);
					num2 = 27;
					continue;
				case 71:
					TableViews = new List<TableView>();
					num2 = 30;
					continue;
				case 86:
					t2j4XubMS8Le2no9dSpp(this, ((EntityMetadata)classMetadata).Filter);
					num2 = 26;
					continue;
				case 55:
				case 60:
					array7 = (object[])zK2L0vbMoIPSC44f9DH4(type, typeof(ImageAttribute), inherit: false);
					num2 = 107;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
					{
						num2 = 78;
					}
					continue;
				case 79:
					attribute3 = AttributeHelper<OnViewLoadScriptNameAttribute>.GetAttribute(type, inherited: false);
					num2 = 111;
					continue;
				case 107:
					if (array7 == null)
					{
						num2 = 6;
						continue;
					}
					goto case 76;
				case 66:
					attribute16 = AttributeHelper<EleWise.ELMA.Model.Attributes.DescriptionAttribute>.GetAttribute(type, inherited: true);
					num2 = 2;
					continue;
				case 100:
					enumerator7 = array7.Cast<ImageAttribute>().GetEnumerator();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
					{
						num2 = 0;
					}
					continue;
				case 14:
					if (array6 != null)
					{
						num2 = 108;
						continue;
					}
					goto case 58;
				case 99:
					attribute14 = AttributeHelper<AllowCreateHeirsAttribute>.GetAttribute(type, inherited: false);
					num2 = 46;
					continue;
				case 10:
					if (tZC2KubMZV1JSNcpGHOr(list) <= 0)
					{
						num2 = 42;
						continue;
					}
					goto case 98;
				case 15:
					if (array4 == null)
					{
						num2 = 16;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 105;
				case 56:
					FormTransformations = new List<FormViewItemTransformation>();
					num2 = 89;
					continue;
				case 48:
					try
					{
						while (true)
						{
							int num16;
							if (!Oh29ewbMbh3pBa5wSCJf(enumerator4))
							{
								num16 = 3;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
								{
									num16 = 3;
								}
								goto IL_1360;
							}
							goto IL_13cc;
							IL_13cc:
							current6 = enumerator4.Current;
							num16 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
							{
								num16 = 0;
							}
							goto IL_1360;
							IL_1360:
							while (true)
							{
								switch (num16)
								{
								default:
									ImplementedInterfaces.Add(current6.InterfaceTypeName);
									num16 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
									{
										num16 = 1;
									}
									continue;
								case 1:
									break;
								case 2:
									goto IL_13cc;
								case 3:
									goto end_IL_13a6;
								}
								break;
							}
							continue;
							end_IL_13a6:
							break;
						}
					}
					finally
					{
						if (enumerator4 != null)
						{
							int num17 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
							{
								num17 = 1;
							}
							while (true)
							{
								switch (num17)
								{
								case 1:
									FvJ0sPbMhu5GbIHDYUmd(enumerator4);
									num17 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
									{
										num17 = 0;
									}
									continue;
								case 0:
									break;
								}
								break;
							}
						}
					}
					goto case 55;
				case 54:
					enumerator8 = array4.Cast<FormAttribute>().GetEnumerator();
					num2 = 21;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
					{
						num2 = 0;
					}
					continue;
				case 53:
					DefaultForms = new ClassDefaultForms();
					num2 = 31;
					continue;
				case 11:
					Forms = new List<FormViewItem>();
					num2 = 54;
					continue;
				case 5:
					if (array5.Length != 0)
					{
						num2 = 74;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
						{
							num2 = 78;
						}
						continue;
					}
					goto case 55;
				default:
					try
					{
						while (true)
						{
							IL_1585:
							int num11;
							if (!Oh29ewbMbh3pBa5wSCJf(enumerator7))
							{
								num11 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
								{
									num11 = 1;
								}
								goto IL_152c;
							}
							goto IL_1546;
							IL_1546:
							current4 = enumerator7.Current;
							num11 = 2;
							goto IL_152c;
							IL_152c:
							while (true)
							{
								switch (num11)
								{
								case 3:
									break;
								case 2:
									Images.Add(new MetadataImage(current4));
									num11 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
									{
										num11 = 0;
									}
									continue;
								default:
									goto IL_1585;
								case 1:
									goto end_IL_1585;
								}
								break;
							}
							goto IL_1546;
							continue;
							end_IL_1585:
							break;
						}
					}
					finally
					{
						int num12;
						if (enumerator7 == null)
						{
							num12 = 2;
							goto IL_15c5;
						}
						goto IL_15db;
						IL_15c5:
						switch (num12)
						{
						case 2:
							goto end_IL_15b0;
						case 1:
							goto end_IL_15b0;
						}
						goto IL_15db;
						IL_15db:
						FvJ0sPbMhu5GbIHDYUmd(enumerator7);
						num12 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
						{
							num12 = 1;
						}
						goto IL_15c5;
						end_IL_15b0:;
					}
					goto case 6;
				case 102:
					griiK2by9q0ebIRUYUDx(this, type.Namespace);
					num2 = 112;
					continue;
				case 61:
					Uid = ((attribute11 != null) ? EISJQ3bym6JjVbLfWYPE(attribute11) : ((!mqd2Osbyx93pFPSNb9hC(type.FullName)) ? ekLavlby04OCREvTrY4K(type.FullName) : Guid.Empty));
					num2 = 32;
					continue;
				case 12:
					ModuleUid = attribute13?.Uid ?? Guid.Empty;
					num2 = 22;
					continue;
				case 22:
					yBDwiPbyyKHNYZplbMZ1(this, !type.IsPublic && !type.IsNestedPublic);
					num2 = 70;
					continue;
				case 47:
					cehtqDbydHDxJPxk0Z1m(this, attribute4?.Id ?? 0);
					num2 = 80;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
					{
						num2 = 77;
					}
					continue;
				case 75:
					PyLOGQbyrB3kbuDNooe3(this, (attribute17 != null) ? rE4ehIbyl5D1DGP2phJG(attribute17) : ((SR.LocalizableString)(string)KEu49jbyHyfB5hBPCC2M(this)));
					num2 = 66;
					continue;
				case 2:
					NamedMetadata.SetDescription(this, (SR.LocalizableString)((attribute16 != null) ? rE4ehIbyl5D1DGP2phJG(attribute16) : JHYTSLbypH9feifq99H1()));
					num2 = 44;
					continue;
				case 88:
					e3EvIeby5jB54XLBjmUt(this, (attribute5 != null) ? JtopUwbygG0d4Ws5sm98(attribute5) : Guid.Empty);
					num2 = 58;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
					{
						num2 = 99;
					}
					continue;
				case 46:
					ggpeXNbyYo4DCDxkWS3V(this, attribute14 != null && RiM3PibyjRjTFc0jSHOS(attribute14));
					num2 = 101;
					continue;
				case 65:
					DisplayFormat = attribute9?.Format;
					num2 = 92;
					continue;
				case 17:
					TitlePropertyUid = attribute12?.Uid ?? Guid.Empty;
					num2 = 51;
					continue;
				case 27:
					zRFUiHbyL6did1mTLo8C(this, attribute10?.Visible ?? true);
					num2 = 41;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
					{
						num2 = 59;
					}
					continue;
				case 69:
					ShowInDesigner = attribute8 == null || MWXj1IbyUWQ115eRBQPn(attribute8);
					num2 = 77;
					continue;
				case 1:
					Suv6RDbycSDoaWyDcxSD(this, (attribute6 != null) ? wN6YIhbysWPKGhIlDhd6(attribute6) : null);
					num2 = 79;
					continue;
				case 111:
					OnViewLoadScriptName = attribute3?.ScriptName;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
					{
						num2 = 4;
					}
					continue;
				case 106:
					namespaceForDisplay = (SR.LocalizableString)((attribute != null) ? rE4ehIbyl5D1DGP2phJG(attribute) : JHYTSLbypH9feifq99H1());
					num2 = 67;
					continue;
				case 28:
					dictionary = (from DefaultFormAttribute a in array
						select new Tuple<ViewType, Guid, Guid, Guid, Guid, bool>(a.ViewType, a.ActionUid, a.FormUid, a.GroupUid, a.TargetUid, a.DeletedFromChild)).ToList();
					num2 = 18;
					continue;
				case 43:
					dict = reflectionCustomAttributes.Cast<DefaultFormSettingAttribute>().ToDictionary((DefaultFormSettingAttribute a) => _003C_003Ec.uSA6P6CHk5AT5TIxcD2K(a), (DefaultFormSettingAttribute a) => a.Value);
					num2 = 37;
					continue;
				}
				break;
			}
		}
	}

	protected virtual IEnumerable<PropertyInfo> GetPropertyInfosWithMetadata(Type type, bool inherit)
	{
		BindingFlags bindingFlags = BindingFlags.Instance | BindingFlags.Public;
		if (!inherit)
		{
			bindingFlags |= BindingFlags.DeclaredOnly;
		}
		return type.GetReflectionProperties(bindingFlags);
	}

	public virtual bool IsRestartNeeded(IRootMetadata metadata)
	{
		return xHQqsEbMiVdIiLGIYRP1(this, metadata) == PublicationType.Restart;
	}

	public virtual void ApplyRestartUnrequiredChanges(bool inherit)
	{
		//Discarded unreachable code: IL_0067, IL_00b4, IL_00c3
		int num = 4;
		int num2 = num;
		ClassMetadata classMetadata = default(ClassMetadata);
		MetadataItemManager metadataItemManager = default(MetadataItemManager);
		while (true)
		{
			object obj;
			switch (num2)
			{
			default:
				return;
			case 4:
				_allForms = null;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
				{
					num2 = 1;
				}
				continue;
			case 2:
				obj = null;
				break;
			case 6:
				if (classMetadata == null)
				{
					num2 = 8;
					continue;
				}
				MetadataSoftPublishHelper.CopyChanges(this, classMetadata);
				num2 = 7;
				continue;
			case 0:
				return;
			case 5:
				classMetadata = metadataItemManager.GetSoftPublishedMetadata(xx9TxLbMqoIwN4LkvPlh(this)) as ClassMetadata;
				num2 = 6;
				continue;
			case 8:
				return;
			case 7:
				return;
			case 1:
				if (metadataItemManager == null)
				{
					return;
				}
				num2 = 5;
				continue;
			case 3:
				if (!sFvIoPbMRJ9DGN8orLJP())
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				obj = Locator.GetService<MetadataItemManager>();
				break;
			}
			metadataItemManager = (MetadataItemManager)obj;
			num2 = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
			{
				num2 = 0;
			}
		}
	}

	protected virtual void OnNamespaceChanged()
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
				fullTypeName = null;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected override void OnNameChanged()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				base.OnNameChanged();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			default:
				fullTypeName = null;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	protected virtual TableView CreateDefaultTableView()
	{
		TableView tableView = new TableView();
		s53xmqbMX5xt7NCvhAPh(tableView, Xkdkf3bMKlmJAZQ0XQX5());
		tableView.ViewType = ViewType.List;
		return tableView;
	}

	protected virtual void GetFormsSettings(ClassDefaultForms defaultForms)
	{
		//Discarded unreachable code: IL_0052, IL_0061, IL_0095, IL_00be, IL_00cd
		int num = 7;
		int num2 = num;
		ClassMetadata classMetadata = default(ClassMetadata);
		while (true)
		{
			object obj;
			switch (num2)
			{
			default:
				ephy6DbMnRng3WreyKmb(this, defaultForms);
				num2 = 2;
				continue;
			case 3:
				vYWgHCbMkm50f0OhLvh1(classMetadata, defaultForms);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return;
			case 5:
				obj = null;
				break;
			case 7:
				if (nYidoWbykXsDOoYZarOd(YZA4m6byTq0IaYdXSpsU(this), Guid.Empty))
				{
					num2 = 6;
					continue;
				}
				goto case 5;
			case 4:
				if (classMetadata == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 3;
			case 6:
				obj = (ClassMetadata)((IMetadataService)p8NjsLbMTuhoAu58XjQq()).GetMetadata(YZA4m6byTq0IaYdXSpsU(this), loadImplementation: false);
				break;
			}
			classMetadata = (ClassMetadata)obj;
			num2 = 4;
		}
	}

	protected virtual void GetForms(List<FormViewItem> forms, ClassDefaultForms defaultForms)
	{
		((BaseClassUid != Guid.Empty) ? ((ClassMetadata)MetadataServiceContext.Service.GetMetadata(BaseClassUid, loadImplementation: false)) : null)?.GetForms(forms, defaultForms);
		AddForms(forms, this, defaultForms);
	}

	protected static void AddFormsSettings(ClassMetadata metadata, ClassDefaultForms defaultForms)
	{
		//Discarded unreachable code: IL_002e, IL_003d, IL_0048, IL_00b7, IL_00c6, IL_0204, IL_0217, IL_0226
		int num = 2;
		int num2 = num;
		Dictionary<Guid, string>.Enumerator enumerator = default(Dictionary<Guid, string>.Enumerator);
		_003C_003Ec__DisplayClass116_0 _003C_003Ec__DisplayClass116_ = default(_003C_003Ec__DisplayClass116_0);
		DefaultFormSetting defaultFormSetting = default(DefaultFormSetting);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 4;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
							{
								num3 = 3;
							}
							goto IL_004c;
						}
						goto IL_0167;
						IL_0167:
						_003C_003Ec__DisplayClass116_ = new _003C_003Ec__DisplayClass116_0();
						num3 = 2;
						goto IL_004c;
						IL_004c:
						while (true)
						{
							switch (num3)
							{
							case 6:
								defaultFormSetting = defaultForms.FormSettings.FirstOrDefault(_003C_003Ec__DisplayClass116_._003CAddFormsSettings_003Eb__0);
								num3 = 3;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
								{
									num3 = 3;
								}
								continue;
							case 8:
								defaultForms.FormSettings.Add(defaultFormSetting);
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
								{
									num3 = 1;
								}
								continue;
							case 2:
								_003C_003Ec__DisplayClass116_.formSetting = enumerator.Current;
								num3 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
								{
									num3 = 6;
								}
								continue;
							case 3:
								if (defaultFormSetting != null)
								{
									num3 = 5;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
									{
										num3 = 5;
									}
									continue;
								}
								goto case 7;
							case 9:
								goto IL_0167;
							case 7:
							{
								DefaultFormSetting defaultFormSetting2 = new DefaultFormSetting();
								UctuGJbMOlH0H3qUIPI8(defaultFormSetting2, _003C_003Ec__DisplayClass116_.formSetting.Key);
								defaultFormSetting = defaultFormSetting2;
								num3 = 7;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
								{
									num3 = 8;
								}
								continue;
							}
							case 1:
							case 5:
								zpVb6wbM2Wq2qxTG4mY2(defaultFormSetting, _003C_003Ec__DisplayClass116_.formSetting.Value);
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
								{
									num3 = 0;
								}
								continue;
							case 4:
								return;
							}
							break;
						}
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
			case 0:
				return;
			case 2:
				enumerator = ((ClassDefaultForms)aaZhMVbyewFSI3wBafF2(metadata)).FormSettingsToDictionary().GetEnumerator();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	protected static void AddForms(List<FormViewItem> forms, ClassMetadata metadata, ClassDefaultForms defaultForms)
	{
		List<FormViewItemTransformation> list = metadata.FormTransformations.ToList();
		foreach (IEntityMetadataFormTransformation extensionPoint in ComponentManager.Current.GetExtensionPoints<IEntityMetadataFormTransformation>())
		{
			extensionPoint.GetTransformations(list);
		}
		using (IEnumerator<FormViewItemTransformation> enumerator2 = list.Where((FormViewItemTransformation t) => _003C_003Ec.FRcSllCHnDoXSNqBCH77(t) == Guid.Empty).GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				_003C_003Ec__DisplayClass117_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass117_0();
				CS_0024_003C_003E8__locals0.transform = enumerator2.Current;
				FormViewItem formViewItem = forms.FirstOrDefault(delegate(FormViewItem f)
				{
					//Discarded unreachable code: IL_009e, IL_00ad
					int num = 4;
					int num2 = num;
					Guid? guid = default(Guid?);
					Guid guid2 = default(Guid);
					while (true)
					{
						switch (num2)
						{
						case 1:
							return false;
						default:
							if (!guid.HasValue)
							{
								num2 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
								{
									num2 = 1;
								}
								break;
							}
							if (guid.HasValue)
							{
								num2 = 5;
								break;
							}
							goto case 2;
						case 3:
							guid2 = CS_0024_003C_003E8__locals0.transform.Uid;
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
							{
								num2 = 0;
							}
							break;
						case 2:
							return true;
						case 5:
							return _003C_003Ec__DisplayClass117_0.lYECvfCHHxgxm4SDDIVU(guid.GetValueOrDefault(), guid2);
						case 4:
							guid = f.uid;
							num2 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
							{
								num2 = 3;
							}
							break;
						}
					}
				});
				if (formViewItem != null)
				{
					int index = forms.IndexOf(formViewItem);
					FormViewItem formViewItem3 = (forms[index] = formViewItem.Transformate(CS_0024_003C_003E8__locals0.transform));
				}
			}
		}
		forms.AddRange(metadata.Forms);
		IEnumerable<FormViewItemTransformation> enumerable = list.Where((FormViewItemTransformation t) => _003C_003Ec.Hqq0EDCHOXVgCky17LGC(t.NewFormUid, Guid.Empty));
		foreach (FormViewItemTransformation item in enumerable)
		{
			AddChildForm(forms, enumerable, item);
		}
		defaultForms.FromDictionary(metadata.DefaultForms.ToDictionary(), reset: false);
		defaultForms.FormSettingsFromDictionary(metadata.DefaultForms.FormSettingsToDictionary(), reset: false);
	}

	private static FormViewItem AddChildForm(List<FormViewItem> forms, IEnumerable<FormViewItemTransformation> childFormTransformations, object transform)
	{
		_003C_003Ec__DisplayClass123_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass123_0();
		CS_0024_003C_003E8__locals0.transform = (FormViewItemTransformation)transform;
		FormViewItem formViewItem = forms.FirstOrDefault((FormViewItem f) => _003C_003Ec__DisplayClass123_0.mbJB5ECHyE2OSgwpvTmE(_003C_003Ec__DisplayClass123_0.basPjuCHmOUWF2u1lVN6(f), CS_0024_003C_003E8__locals0.transform.NewFormUid));
		if (formViewItem != null)
		{
			return formViewItem;
		}
		FormViewItem formViewItem2 = forms.FirstOrDefault((FormViewItem f) => _003C_003Ec__DisplayClass123_0.mbJB5ECHyE2OSgwpvTmE(_003C_003Ec__DisplayClass123_0.basPjuCHmOUWF2u1lVN6(f), CS_0024_003C_003E8__locals0.transform.Uid));
		if (formViewItem2 == null)
		{
			FormViewItemTransformation formViewItemTransformation = childFormTransformations.FirstOrDefault((FormViewItemTransformation t) => _003C_003Ec__DisplayClass123_0.mbJB5ECHyE2OSgwpvTmE(_003C_003Ec__DisplayClass123_0.gmys05CHMFORrBXCBRyg(t), CS_0024_003C_003E8__locals0.transform.Uid));
			if (formViewItemTransformation == null)
			{
				return null;
			}
			formViewItem2 = AddChildForm(forms, childFormTransformations, formViewItemTransformation);
			if (formViewItem2 == null)
			{
				return null;
			}
		}
		formViewItem = formViewItem2.Transformate(CS_0024_003C_003E8__locals0.transform);
		forms.Add(formViewItem);
		return formViewItem;
	}

	internal static object Kn08mrbyKsMLJwmK2rpA(object P_0)
	{
		return (string)(SR.LocalizableString)P_0;
	}

	internal static bool ClCZlPbyRAE6e4nUamri()
	{
		return S2vmREbyiUOO08f9MM4f == null;
	}

	internal static ClassMetadata tS0MMxbyquHFWARas1iR()
	{
		return S2vmREbyiUOO08f9MM4f;
	}

	internal static object b9hhEWbyXYQdaOrkKXmN(object P_0)
	{
		return (SR.LocalizableString)(string)P_0;
	}

	internal static Guid YZA4m6byTq0IaYdXSpsU(object P_0)
	{
		return ((ClassMetadata)P_0).BaseClassUid;
	}

	internal static bool nYidoWbykXsDOoYZarOd(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static int IywOnLbynVbHaOOkjUtM(object P_0)
	{
		return ((List<PropertyMetadata>)P_0).Count;
	}

	internal static int zv3efbbyOxN8a7jWq5LT(object P_0)
	{
		return ((List<PropertiesContainer>)P_0).Count;
	}

	internal static void VMIB6Xby2I3GWoc4taf9(object P_0, object P_1)
	{
		((ClassDefaultForms)P_0).SetOwner((ClassMetadata)P_1);
	}

	internal static object aaZhMVbyewFSI3wBafF2(object P_0)
	{
		return ((ClassMetadata)P_0).DefaultForms;
	}

	internal static int lsCg6CbyPEcuYaxikCBF(object P_0)
	{
		return ((List<FormViewItem>)P_0).Count;
	}

	internal static int V2bqRoby1Nm0hWDI8urK(object P_0)
	{
		return ((List<FormView>)P_0).Count;
	}

	internal static int F2L9YjbyNNDHwyCRbaYc(object P_0)
	{
		return ((List<TableView>)P_0).Count;
	}

	internal static void mOZYeKby3YBWLnAMYKNC()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object JHYTSLbypH9feifq99H1()
	{
		return SR.LocalizableString.Empty;
	}

	internal static void pXw3FEbya0Fk09o7ZqCo(object P_0, object P_1)
	{
		((ClassMetadata)P_0).DefaultForms = (ClassDefaultForms)P_1;
	}

	internal static bool MFK1rEbyDP45nrajyx0K(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object LaN9Ugbyt4xnVB5OkKTf(object P_0)
	{
		return ((ClassMetadata)P_0).Namespace;
	}

	internal static object gXxCexbywJ9LUQCUN2yY(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object bQXGp5by49UEZfIemyAU(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object BtqGlPby6Uy5jRbNpPO8(object P_0)
	{
		return ((ClassMetadata)P_0).TypeName;
	}

	internal static object KEu49jbyHyfB5hBPCC2M(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static void FZrHIAbyAlrXmMCqL2L8(object P_0)
	{
		((AbstractMetadata)P_0).InitNew();
	}

	internal static void d8Zknoby7Huhd6BcDkFO(object P_0)
	{
		((AbstractMetadata)P_0).AfterLoad();
	}

	internal static bool mqd2Osbyx93pFPSNb9hC(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static Guid ekLavlby04OCREvTrY4K(object P_0)
	{
		return ((string)P_0).GetDeterministicGuid();
	}

	internal static Guid EISJQ3bym6JjVbLfWYPE(object P_0)
	{
		return ((UidAttribute)P_0).Uid;
	}

	internal static void yBDwiPbyyKHNYZplbMZ1(object P_0, bool value)
	{
		((AbstractMetadata)P_0).Internal = value;
	}

	internal static object UJoHyvbyMhcA9fsPluGL(object P_0)
	{
		return ((MemberInfo)P_0).Name;
	}

	internal static void SfmqAPbyJ4GGlNvKL0TY(object P_0, object P_1)
	{
		((NamedMetadata)P_0).Name = (string)P_1;
	}

	internal static void griiK2by9q0ebIRUYUDx(object P_0, object P_1)
	{
		((ClassMetadata)P_0).Namespace = (string)P_1;
	}

	internal static void cehtqDbydHDxJPxk0Z1m(object P_0, long value)
	{
		((ClassMetadata)P_0).GroupId = value;
	}

	internal static object rE4ehIbyl5D1DGP2phJG(object P_0)
	{
		return ((LocalizedStringAttribute)P_0).LocalizedString;
	}

	internal static void PyLOGQbyrB3kbuDNooe3(object P_0, object P_1)
	{
		NamedMetadata.SetDisplayName((NamedMetadata)P_0, (SR.LocalizableString)P_1);
	}

	internal static Guid JtopUwbygG0d4Ws5sm98(object P_0)
	{
		return ((BaseClassAttribute)P_0).BaseClassUid;
	}

	internal static void e3EvIeby5jB54XLBjmUt(object P_0, Guid value)
	{
		((ClassMetadata)P_0).BaseClassUid = value;
	}

	internal static bool RiM3PibyjRjTFc0jSHOS(object P_0)
	{
		return ((AllowCreateHeirsAttribute)P_0).Value;
	}

	internal static void ggpeXNbyYo4DCDxkWS3V(object P_0, bool value)
	{
		((ClassMetadata)P_0).AllowCreateHeirs = value;
	}

	internal static void zRFUiHbyL6did1mTLo8C(object P_0, bool value)
	{
		((ClassMetadata)P_0).ShowInTypeTree = value;
	}

	internal static bool MWXj1IbyUWQ115eRBQPn(object P_0)
	{
		return ((ShowInDesignerAttribute)P_0).Visible;
	}

	internal static object wN6YIhbysWPKGhIlDhd6(object P_0)
	{
		return ((ScriptModuleAttribute)P_0).TypeName;
	}

	internal static void Suv6RDbycSDoaWyDcxSD(object P_0, object P_1)
	{
		((ClassMetadata)P_0).ScriptModuleTypeName = (string)P_1;
	}

	internal static Type YP2ChHbyzZYUFnYDcocs(object P_0)
	{
		return ((FilterForAttribute)P_0).EntityType;
	}

	internal static object fLvutabMF8r0auhquvPa()
	{
		return Logger.Log;
	}

	internal static void rSgql5bMBuZtvR8lwKs9(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Debug(P_1, (Exception)P_2);
	}

	internal static Type kP6cPSbMW61ismYK9DPH(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object zK2L0vbMoIPSC44f9DH4(Type type, Type attributeType, bool inherit)
	{
		return type.GetReflectionCustomAttributes(attributeType, inherit);
	}

	internal static bool Oh29ewbMbh3pBa5wSCJf(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void FvJ0sPbMhu5GbIHDYUmd(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void H5UU5sbMGrbMuLq42iHJ(object P_0, object P_1)
	{
		((ClassMetadata)P_0).CustomCode = (string)P_1;
	}

	internal static ClassFormsScheme wctHfXbMEMwOR7XLbkU8(object P_0)
	{
		return ((ClassFormsSchemeAttribute)P_0).Scheme;
	}

	internal static void YNajXBbMfAHHjAfVpBX2(object P_0, ClassFormsScheme value)
	{
		((ClassMetadata)P_0).FormsScheme = value;
	}

	internal static object kHTFAibMQdGT8HbLOwoD(object P_0)
	{
		return ((FormTransformationAttribute)P_0).Transformation;
	}

	internal static object XcQvb4bMCytHmi7dAbOL(object P_0)
	{
		return ((FormViewAttribute)P_0).View;
	}

	internal static bool QbfrH9bMv2h1SgZ2Mylu(object P_0, Type P_1, bool P_2)
	{
		return ((MemberInfo)P_0).IsDefined(P_1, P_2);
	}

	internal static void rMYgNYbM84fJvK5BNeTv(object P_0, object P_1, object P_2)
	{
		((PropertyMetadata)P_0).LoadFromPropertyInfo((PropertyInfo)P_1, (PropertyMetadata)P_2);
	}

	internal static int tZC2KubMZV1JSNcpGHOr(object P_0)
	{
		return ((List<OverrideExtensibleClassPropertyAttribute>)P_0).Count;
	}

	internal static object tj6SYobMuIHDpy7VsLZL(object P_0)
	{
		return ((OverrideExtensibleClassPropertyAttribute)P_0).PropertyValue;
	}

	internal static bool nKWH0DbMIfJucwiyKAw0(object P_0)
	{
		return ((string)P_0).IsNullOrEmpty();
	}

	internal static object SraP6EbMVJ6NqAkXoRa9(object P_0)
	{
		return ((EntityMetadata)P_0).Filter;
	}

	internal static void t2j4XubMS8Le2no9dSpp(object P_0, object P_1)
	{
		MetadataSoftPublishHelper.CopyChanges((IMetadata)P_0, (IMetadata)P_1);
	}

	internal static PublicationType xHQqsEbMiVdIiLGIYRP1(object P_0, object P_1)
	{
		return MetadataSoftPublishHelper.IsEqualsObject(P_0, P_1);
	}

	internal static bool sFvIoPbMRJ9DGN8orLJP()
	{
		return Locator.Initialized;
	}

	internal static Guid xx9TxLbMqoIwN4LkvPlh(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static Guid Xkdkf3bMKlmJAZQ0XQX5()
	{
		return Guid.NewGuid();
	}

	internal static void s53xmqbMX5xt7NCvhAPh(object P_0, Guid value)
	{
		((TableView)P_0).Uid = value;
	}

	internal static object p8NjsLbMTuhoAu58XjQq()
	{
		return MetadataServiceContext.Service;
	}

	internal static void vYWgHCbMkm50f0OhLvh1(object P_0, object P_1)
	{
		((ClassMetadata)P_0).GetFormsSettings((ClassDefaultForms)P_1);
	}

	internal static void ephy6DbMnRng3WreyKmb(object P_0, object P_1)
	{
		AddFormsSettings((ClassMetadata)P_0, (ClassDefaultForms)P_1);
	}

	internal static void UctuGJbMOlH0H3qUIPI8(object P_0, Guid value)
	{
		((DefaultFormSetting)P_0).Uid = value;
	}

	internal static void zpVb6wbM2Wq2qxTG4mY2(object P_0, object P_1)
	{
		((DefaultFormSetting)P_0).Value = (string)P_1;
	}
}
