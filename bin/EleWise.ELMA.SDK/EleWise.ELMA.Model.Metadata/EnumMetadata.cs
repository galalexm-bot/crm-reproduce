using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
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
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Modules.Attributes;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Metadata;

[Serializable]
[XmlRoot("Enum")]
public class EnumMetadata : NamedDocumentedMetadata, IRootMetadata, IMetadata, IXsiType, ICodeItemMetadata, IGroupedMetadata, IValidatableMetadata, IDeltaRootMetadata
{
	[Component]
	public class Info : IMetadataTypeInfo
	{
		internal static Info S3cGR1CHJE6GUQkGHTfm;

		public string Name => SR.T((string)mOrVU5CHle3CZT3G5YBb(0x12A5FAC7 ^ 0x12A77575));

		public string Description => (string)KxxFxcCHrREDPKpnsaty(mOrVU5CHle3CZT3G5YBb(0x2ACE37D ^ 0x2A94C7F));

		public Type MetadataType => eksutiCHgCIRCReR0TAX(typeof(EnumMetadata).TypeHandle);

		public Type GeneratorType => eksutiCHgCIRCReR0TAX(typeof(EnumGenerator).TypeHandle);

		public Info()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			gwu8VZCH5iHs0kduwnhr();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static object mOrVU5CHle3CZT3G5YBb(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static bool rTmCQtCH9YOqgREk2BPI()
		{
			return S3cGR1CHJE6GUQkGHTfm == null;
		}

		internal static Info Rd3ppACHdJ5auEZC4cnR()
		{
			return S3cGR1CHJE6GUQkGHTfm;
		}

		internal static object KxxFxcCHrREDPKpnsaty(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static Type eksutiCHgCIRCReR0TAX(RuntimeTypeHandle P_0)
		{
			return System.Type.GetTypeFromHandle(P_0);
		}

		internal static void gwu8VZCH5iHs0kduwnhr()
		{
			SingletonReader.JJCZtPuTvSt();
		}
	}

	private string namespaceName;

	private string fullTypeName;

	private SR.LocalizableString namespaceForDisplay;

	internal static EnumMetadata GKryuCbMexq6EOAMDi5q;

	[PublicationBehaviour(PublicationType.Restart)]
	[XmlElement("Namespace")]
	public virtual string Namespace
	{
		get
		{
			return namespaceName;
		}
		set
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 2:
					namespaceName = value;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
					{
						num2 = 1;
					}
					break;
				case 0:
					return;
				case 1:
					E1Q51xbMabb81sCAx5TB(this);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DefaultValue("")]
	[XmlElement("NamespaceForDisplay")]
	[EleWise.ELMA.Globalization.Localizable]
	public virtual string NamespaceForDisplay
	{
		get
		{
			return (string)uWlAj9bMDGGU094Q9bg8(namespaceForDisplay);
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
					namespaceForDisplay = (SR.LocalizableString)PAMl6ubMtW4rUEBFRBZ4(value);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
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
	[DefaultValue(EnumMetadataType.Enum)]
	[XmlElement("Type")]
	public virtual EnumMetadataType Type
	{
		[CompilerGenerated]
		get
		{
			return _003CType_003Ek__BackingField;
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
					_003CType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
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
	[XmlElement("BaseTypeUid")]
	public virtual Guid BaseTypeUid
	{
		[CompilerGenerated]
		get
		{
			return _003CBaseTypeUid_003Ek__BackingField;
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
					_003CBaseTypeUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DefaultValue(0L)]
	[XmlElement("GroupId")]
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DefaultValue(true)]
	[XmlElement("ShowInDesigner")]
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
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

	public string FullTypeName
	{
		get
		{
			int num = 1;
			int num2 = num;
			string text2;
			string text = default(string);
			while (true)
			{
				switch (num2)
				{
				case 1:
					text2 = fullTypeName;
					if (text2 != null)
					{
						break;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
					{
						num2 = 0;
					}
					continue;
				default:
					text = (fullTypeName = (string)Xq7EQBbMxPTrsjC0ONgo(PFJod3bMHtwvxdUniUF2(KhTDuPbM6qvomKxyFnSl(this)) ? string.Empty : (Namespace + (string)IXIn2HbMAabObAjJBl5G(0x17ADCCD8 ^ 0x17ADD61C)), llYagHbM7OJBW6gkGQo7(this)));
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
					{
						num2 = 2;
					}
					continue;
				case 2:
					text2 = text;
					break;
				}
				break;
			}
			return text2;
		}
	}

	[XmlArray("Values")]
	[PublicationBehaviour(typeof(NotRestartIfCollectionItemAddBehaviour))]
	public List<EnumValueMetadata> Values { get; set; }

	[XmlIgnore]
	[PublicationBehaviour(PublicationType.Restart)]
	public Guid? DefaultValueUid { get; set; }

	[XmlElement("DefaultValueUid")]
	[DefaultValue("")]
	public string DefaultValueUidStr
	{
		get
		{
			int num = 5;
			int num2 = num;
			Guid value = default(Guid);
			Guid? defaultValueUid = default(Guid?);
			while (true)
			{
				switch (num2)
				{
				default:
					return value.ToString();
				case 2:
					value = defaultValueUid.Value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
					{
						num2 = 0;
					}
					break;
				case 4:
					if (defaultValueUid.HasValue)
					{
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
						{
							num2 = 5;
						}
						break;
					}
					goto case 3;
				case 6:
					defaultValueUid = DefaultValueUid;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
					{
						num2 = 1;
					}
					break;
				case 5:
					defaultValueUid = DefaultValueUid;
					num2 = 4;
					break;
				case 3:
					return "";
				case 1:
					if (defaultValueUid.Value != Guid.Empty)
					{
						defaultValueUid = DefaultValueUid;
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
						{
							num2 = 2;
						}
					}
					else
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
						{
							num2 = 1;
						}
					}
					break;
				}
			}
		}
		set
		{
			//Discarded unreachable code: IL_0058, IL_008b, IL_00e2, IL_00f1
			int num = 2;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 1:
						try
						{
							DefaultValueUid = new Guid(value);
							int num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
							{
								num3 = 0;
							}
							switch (num3)
							{
							case 0:
								break;
							}
							return;
						}
						catch (Exception ex)
						{
							int num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
							{
								num4 = 1;
							}
							while (true)
							{
								switch (num4)
								{
								default:
									return;
								case 1:
									mykeHTbMMDH9a1Sc2F3t(Qg9QAybMmHdS6lZD06xx(), qicSO6bMynJPhTYHnmgL(IXIn2HbMAabObAjJBl5G(-1921202237 ^ -1921107355), value), ex);
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
									{
										num4 = 0;
									}
									break;
								case 0:
									return;
								}
							}
						}
					case 3:
						return;
					case 2:
						if (!string.IsNullOrEmpty(value))
						{
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
							{
								num2 = 1;
							}
							continue;
						}
						break;
					}
					break;
				}
				DefaultValueUid = null;
				num = 3;
			}
		}
	}

	public EnumMetadata()
	{
		//Discarded unreachable code: IL_003a, IL_003f
		SingletonReader.JJCZtPuTvSt();
		namespaceForDisplay = (SR.LocalizableString)cX7IvvbMNb3kcwwCn40y();
		base._002Ector();
		int num = 2;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
		{
			num = 2;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			case 3:
				KwtpuZbMp4K9MTveEu4E(this, true);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
				{
					num = 1;
				}
				break;
			case 2:
				Values = new List<EnumValueMetadata>();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
				{
					num = 0;
				}
				break;
			default:
				xHlT7rbM3VVAhhtDtUM6(this, true);
				num = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual bool ShouldSerializeBaseTypeUid()
	{
		return JBSo9lbM4YCaC7dKRil3(CGe5wqbMwA4vr5n5NhE3(this), Guid.Empty);
	}

	public virtual EnumValueMetadata CreateValue()
	{
		return new EnumValueMetadata
		{
			Uid = Guid.NewGuid()
		};
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual bool ShouldSerializeValues()
	{
		//Discarded unreachable code: IL_0063, IL_0072
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return uuLwZobM0Dh7cQZSdn9v(Values) > 0;
			case 1:
				return false;
			case 2:
				if (Values == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			}
		}
	}

	public virtual void LoadFromType(Type type, bool inherit = true)
	{
		//Discarded unreachable code: IL_00e5
		int num = 17;
		ShowInDesignerAttribute attribute5 = default(ShowInDesignerAttribute);
		BaseClassAttribute attribute6 = default(BaseClassAttribute);
		NamespaceForDisplayAttribute attribute = default(NamespaceForDisplayAttribute);
		EleWise.ELMA.Model.Attributes.DisplayNameAttribute attribute10 = default(EleWise.ELMA.Model.Attributes.DisplayNameAttribute);
		AssemblyModuleAttribute attribute9 = default(AssemblyModuleAttribute);
		DefaultValueUidAttribute attribute3 = default(DefaultValueUidAttribute);
		EleWise.ELMA.Model.Attributes.DescriptionAttribute attribute7 = default(EleWise.ELMA.Model.Attributes.DescriptionAttribute);
		EnumMetadataTypeAttribute attribute2 = default(EnumMetadataTypeAttribute);
		GroupIdAttribute attribute4 = default(GroupIdAttribute);
		ShowInTypeTreeAttribute attribute8 = default(ShowInTypeTreeAttribute);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 7:
					attribute5 = AttributeHelper<ShowInDesignerAttribute>.GetAttribute(type, inherited: true);
					num2 = 19;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
					{
						num2 = 22;
					}
					continue;
				case 16:
					if (!UPFx3gbM9MQhhNMtrIk6(type))
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
						{
							num2 = 11;
						}
						continue;
					}
					goto case 29;
				case 19:
					attribute6 = AttributeHelper<BaseClassAttribute>.GetAttribute(type, inherited: false);
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
					{
						num2 = 24;
					}
					continue;
				case 9:
					LoadValuesFromType(type, inherit);
					num2 = 10;
					continue;
				case 8:
					attribute = AttributeHelper<NamespaceForDisplayAttribute>.GetAttribute(type, inherited: false);
					num2 = 18;
					continue;
				case 27:
					attribute10 = AttributeHelper<EleWise.ELMA.Model.Attributes.DisplayNameAttribute>.GetAttribute(type, inherited: true);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
					{
						num2 = 3;
					}
					continue;
				case 30:
					attribute9 = AttributeHelper<AssemblyModuleAttribute>.GetAttribute(type.Assembly);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
					{
						num2 = 0;
					}
					continue;
				case 10:
					return;
				case 4:
					attribute3 = AttributeHelper<DefaultValueUidAttribute>.GetAttribute(type, inherited: true);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
					{
						num2 = 0;
					}
					continue;
				case 17:
					zknEKGbMJGtjWkDo7nQ3(type, IXIn2HbMAabObAjJBl5G(0x7EC153F ^ 0x7EC191D));
					num2 = 16;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
					{
						num2 = 3;
					}
					continue;
				case 20:
					Name = (string)haVBDbbMghZf1BmL5FxX(type);
					num2 = 21;
					continue;
				case 21:
					qyKiR2bM5wgUAOQyH3Vw(this, type.Namespace);
					num2 = 19;
					continue;
				case 23:
					attribute7 = AttributeHelper<EleWise.ELMA.Model.Attributes.DescriptionAttribute>.GetAttribute(type, inherited: true);
					num = 2;
					break;
				case 11:
				case 14:
					WypKf8bMde1xPTrMkd1Y(this, EnumDescriptor.GetSubtypeUid(type));
					num2 = 30;
					continue;
				case 5:
					attribute2 = AttributeHelper<EnumMetadataTypeAttribute>.GetAttribute(type, inherited: false);
					num2 = 25;
					continue;
				case 29:
					type = type.GetNonNullableType();
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
					{
						num2 = 14;
					}
					continue;
				case 15:
					attribute4 = AttributeHelper<GroupIdAttribute>.GetAttribute(type, inherited: false);
					num2 = 28;
					continue;
				case 12:
					Values = new List<EnumValueMetadata>();
					num2 = 9;
					continue;
				case 13:
					attribute8 = AttributeHelper<ShowInTypeTreeAttribute>.GetAttribute(type, inherited: true);
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
					{
						num2 = 6;
					}
					continue;
				case 1:
					lfCwNrbMliEHCOgcgS8w(this, attribute9?.Uid ?? Guid.Empty);
					num2 = 17;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
					{
						num2 = 26;
					}
					continue;
				case 26:
					yASeEjbMrcvBS7cvCdTZ(this, !type.IsPublic && !type.IsNestedPublic);
					num = 20;
					break;
				case 24:
					IeDVTKbMYXC24QsVKYA0(this, (attribute6 != null) ? XsyGx0bMj6aM5ncyiqjD(attribute6) : Guid.Empty);
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
					{
						num2 = 5;
					}
					continue;
				case 25:
					VKU7WdbMUJDT0gJGqqZu(this, (attribute2 != null) ? nYak2DbMLHu3vlgUCJ6A(attribute2) : EnumMetadataType.Enum);
					num2 = 15;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
					{
						num2 = 0;
					}
					continue;
				case 28:
					yNG86UbMcq5alaOORHkY(this, (attribute4 != null) ? ktrNAEbMsY6PCDXb9h2H(attribute4) : 0);
					num2 = 27;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
					{
						num2 = 13;
					}
					continue;
				case 3:
					byqZswbJFyyuraQKgTFB(this, (attribute10 != null) ? EwuSc6bMzrCw3jB1TjEw(attribute10) : PAMl6ubMtW4rUEBFRBZ4(Name));
					num2 = 16;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
					{
						num2 = 23;
					}
					continue;
				case 2:
					YfR3qYbJB7nggWf2Z2GO(this, (attribute7 != null) ? attribute7.LocalizedString : cX7IvvbMNb3kcwwCn40y());
					num2 = 13;
					continue;
				case 6:
					xHlT7rbM3VVAhhtDtUM6(this, attribute8 == null || IwHKHmbJW4X7G8KxpZZv(attribute8));
					num2 = 7;
					continue;
				case 22:
					KwtpuZbMp4K9MTveEu4E(this, attribute5 == null || QK2ygabJoKxIXRvH5T5n(attribute5));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
					{
						num2 = 4;
					}
					continue;
				default:
					DefaultValueUid = attribute3?.Uid;
					num2 = 8;
					continue;
				case 18:
					namespaceForDisplay = (SR.LocalizableString)((attribute != null) ? EwuSc6bMzrCw3jB1TjEw(attribute) : cX7IvvbMNb3kcwwCn40y());
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
					{
						num2 = 12;
					}
					continue;
				}
				break;
			}
		}
	}

	public static EnumMetadata Load(Type enumType)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
			{
				EnumMetadata enumMetadata = new EnumMetadata();
				enumMetadata.LoadFromType(enumType);
				return enumMetadata;
			}
			case 1:
				zknEKGbMJGtjWkDo7nQ3(enumType, IXIn2HbMAabObAjJBl5G(0x1C9495B4 ^ 0x1C96685E));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public virtual bool IsRestartNeeded(IRootMetadata metadata)
	{
		return GgTQgTbJb1ZtJmptqL8G(this, metadata) == PublicationType.Restart;
	}

	public virtual void ApplyRestartUnrequiredChanges(bool inherit)
	{
		//Discarded unreachable code: IL_0049, IL_0058, IL_0068, IL_00c1, IL_0117
		int num = 7;
		EnumMetadata enumMetadata = default(EnumMetadata);
		MetadataItemManager metadataItemManager = default(MetadataItemManager);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 8:
					return;
				case 3:
					enumMetadata = DECMK5bJEJvMy93tukC9(metadataItemManager, IUth26bJGQQ3nbiG72eK(this)) as EnumMetadata;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
					{
						num2 = 1;
					}
					continue;
				case 9:
					return;
				default:
					goto end_IL_0012;
				case 4:
					return;
				case 2:
					if (metadataItemManager == null)
					{
						return;
					}
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
					{
						num2 = 3;
					}
					continue;
				case 7:
					if (IaZ3gobJhgmVK1myC9AL())
					{
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 5;
				case 5:
					obj = null;
					break;
				case 1:
					if (enumMetadata == null)
					{
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
					{
						num2 = 0;
					}
					continue;
				case 6:
					obj = Locator.GetService<MetadataItemManager>();
					break;
				}
				metadataItemManager = (MetadataItemManager)obj;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
				{
					num2 = 2;
				}
				continue;
				end_IL_0012:
				break;
			}
			B3rl44bJfA8E0Q6tpEIW(this, enumMetadata);
			num = 4;
		}
	}

	public virtual MetadataItemValidationError[] Validate()
	{
		//Discarded unreachable code: IL_00ac, IL_00bb, IL_00cb
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
			case 3:
			{
				MetadataItemValidationError[] array = new MetadataItemValidationError[1];
				MetadataItemValidationError obj = new MetadataItemValidationError
				{
					MetadataUid = IUth26bJGQQ3nbiG72eK(this)
				};
				HxsajubJQIZtH35jG8bh(obj, SR.T((string)IXIn2HbMAabObAjJBl5G(-1088304168 ^ -1088211418)));
				array[0] = obj;
				return array;
			}
			default:
				return null;
			case 1:
				if (Values.Count != 0)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 4:
				if (Values == null)
				{
					num2 = 3;
					break;
				}
				goto case 1;
			}
		}
	}

	protected virtual void LoadValuesFromType(Type type, bool inherit)
	{
		//Discarded unreachable code: IL_0112, IL_0121, IL_012c, IL_020d, IL_0245, IL_0272, IL_02b8, IL_02c7, IL_0346
		int num = 9;
		int num2 = num;
		EnumValueMetadata enumValueMetadata = default(EnumValueMetadata);
		int num5 = default(int);
		FieldInfo[] reflectionFields = default(FieldInfo[]);
		IEnumerator<PropertyInfo> enumerator = default(IEnumerator<PropertyInfo>);
		EnumValueMetadata enumValueMetadata2 = default(EnumValueMetadata);
		PropertyInfo current = default(PropertyInfo);
		BindingFlags bindingFlags = default(BindingFlags);
		FieldInfo fieldInfo = default(FieldInfo);
		while (true)
		{
			switch (num2)
			{
			case 18:
				if (inherit)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
					{
						num2 = 7;
					}
					break;
				}
				return;
			case 14:
				enumValueMetadata = new EnumValueMetadata();
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
				{
					num2 = 10;
				}
				break;
			case 4:
				num5++;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
				{
					num2 = 0;
				}
				break;
			case 7:
				LoadExtensionValues(this);
				num2 = 5;
				break;
			case 16:
				return;
			case 8:
				reflectionFields = type.GetReflectionFields(BindingFlags.Static | BindingFlags.Public);
				num2 = 20;
				break;
			case 15:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 5;
							goto IL_0130;
						}
						goto IL_0189;
						IL_0130:
						while (true)
						{
							switch (num3)
							{
							case 4:
								enumValueMetadata2 = new EnumValueMetadata();
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
								{
									num3 = 3;
								}
								continue;
							case 1:
								break;
							default:
								goto IL_0189;
							case 3:
								enumValueMetadata2.LoadFromMember(current);
								num3 = 2;
								continue;
							case 2:
								Values.Add(enumValueMetadata2);
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
								{
									num3 = 1;
								}
								continue;
							case 5:
								goto end_IL_0173;
							}
							break;
						}
						continue;
						IL_0189:
						current = enumerator.Current;
						num3 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
						{
							num3 = 0;
						}
						goto IL_0130;
						continue;
						end_IL_0173:
						break;
					}
				}
				finally
				{
					if (enumerator != null)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								xoklbVbJ8p5R2vN8b0QY(enumerator);
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
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
				goto case 18;
			case 3:
				bindingFlags = BindingFlags.Static | BindingFlags.Public;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				return;
			case 17:
				Values.Add(enumValueMetadata);
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
				{
					num2 = 1;
				}
				break;
			case 11:
				bindingFlags |= BindingFlags.DeclaredOnly;
				num2 = 6;
				break;
			case 19:
				fieldInfo = reflectionFields[num5];
				num2 = 14;
				break;
			case 10:
				enumValueMetadata.LoadFromMember(fieldInfo, g9V5hcbJC2buVlciki2X(fieldInfo, null));
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
				{
					num2 = 17;
				}
				break;
			default:
				if (num5 >= reflectionFields.Length)
				{
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
					{
						num2 = 16;
					}
					break;
				}
				goto case 19;
			case 5:
				return;
			case 20:
				num5 = 0;
				num2 = 13;
				break;
			case 9:
				if (!type.IsEnum)
				{
					if (!type.IsClass)
					{
						num2 = 2;
						break;
					}
					goto case 3;
				}
				num2 = 8;
				break;
			case 1:
				if (inherit)
				{
					num2 = 12;
					break;
				}
				goto case 11;
			case 6:
			case 12:
				enumerator = ((IEnumerable<PropertyInfo>)Gx7yn8bJvyPbkrEPRdlt(type, bindingFlags)).Where((PropertyInfo fi) => fi.IsDefined(typeof(UidAttribute), inherit: false)).GetEnumerator();
				num2 = 15;
				break;
			}
		}
	}

	protected override void OnNameChanged()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				base.OnNameChanged();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 1:
				fullTypeName = null;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
				{
					num2 = 0;
				}
				break;
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
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void LoadExtensionValues(EnumMetadata metadata)
	{
		//Discarded unreachable code: IL_0045, IL_0054, IL_009c, IL_00ab, IL_00b6, IL_0113, IL_0122, IL_012d, IL_0270, IL_0283, IL_02c9, IL_02e8, IL_0314, IL_0323, IL_0334
		int num = 5;
		_003C_003Ec__DisplayClass55_0 _003C_003Ec__DisplayClass55_ = default(_003C_003Ec__DisplayClass55_0);
		IMetadataRuntimeService metadataRuntimeService = default(IMetadataRuntimeService);
		IEnumerator<Guid> enumerator = default(IEnumerator<Guid>);
		List<EnumValueMetadata>.Enumerator enumerator2 = default(List<EnumValueMetadata>.Enumerator);
		_003C_003Ec__DisplayClass55_1 _003C_003Ec__DisplayClass55_2 = default(_003C_003Ec__DisplayClass55_1);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 4:
					_003C_003Ec__DisplayClass55_.metadata = metadata;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
					{
						num2 = 2;
					}
					break;
				case 3:
					if (metadataRuntimeService == null)
					{
						return;
					}
					goto end_IL_0012;
				case 7:
					try
					{
						while (true)
						{
							int num3;
							if (!UjyJJObJue5ZxXIXUTHu(enumerator))
							{
								num3 = 3;
								goto IL_00ba;
							}
							goto IL_00d4;
							IL_00ba:
							switch (num3)
							{
							case 1:
								break;
							default:
								try
								{
									while (true)
									{
										IL_01af:
										int num4;
										if (!enumerator2.MoveNext())
										{
											num4 = 6;
											goto IL_0131;
										}
										goto IL_0157;
										IL_0131:
										while (true)
										{
											switch (num4)
											{
											case 5:
												break;
											case 3:
												if (!Values.Any(_003C_003Ec__DisplayClass55_2._003CLoadExtensionValues_003Eb__2))
												{
													num4 = 1;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
													{
														num4 = 1;
													}
													continue;
												}
												goto IL_01af;
											default:
												goto IL_01af;
											case 1:
												Values.Add(_003C_003Ec__DisplayClass55_2.extValueMetadata);
												num4 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
												{
													num4 = 0;
												}
												continue;
											case 4:
												if (j6GiE7bJZPCTSTmso0vt(_003C_003Ec__DisplayClass55_2.extValueMetadata) != null)
												{
													num4 = 2;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
													{
														num4 = 3;
													}
													continue;
												}
												goto IL_01af;
											case 2:
												_003C_003Ec__DisplayClass55_2.extValueMetadata = enumerator2.Current;
												num4 = 4;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
												{
													num4 = 4;
												}
												continue;
											case 6:
												goto end_IL_01af;
											}
											break;
										}
										goto IL_0157;
										IL_0157:
										_003C_003Ec__DisplayClass55_2 = new _003C_003Ec__DisplayClass55_1();
										num4 = 2;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
										{
											num4 = 2;
										}
										goto IL_0131;
										continue;
										end_IL_01af:
										break;
									}
								}
								finally
								{
									((IDisposable)enumerator2).Dispose();
									int num5 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
									{
										num5 = 0;
									}
									switch (num5)
									{
									case 0:
										break;
									}
								}
								continue;
							case 2:
								continue;
							case 3:
								return;
							}
							goto IL_00d4;
							IL_00d4:
							enumerator2 = ((EnumMetadata)MetadataLoader.LoadMetadata(enumerator.Current)).Values.GetEnumerator();
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
							{
								num3 = 0;
							}
							goto IL_00ba;
						}
					}
					finally
					{
						int num6;
						if (enumerator == null)
						{
							num6 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
							{
								num6 = 0;
							}
							goto IL_02cd;
						}
						goto IL_02f2;
						IL_02f2:
						enumerator.Dispose();
						num6 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
						{
							num6 = 1;
						}
						goto IL_02cd;
						IL_02cd:
						switch (num6)
						{
						default:
							goto end_IL_02a8;
						case 0:
							goto end_IL_02a8;
						case 2:
							break;
						case 1:
							goto end_IL_02a8;
						}
						goto IL_02f2;
						end_IL_02a8:;
					}
				default:
					obj = null;
					goto IL_0374;
				case 5:
					_003C_003Ec__DisplayClass55_ = new _003C_003Ec__DisplayClass55_0();
					num2 = 4;
					break;
				case 1:
					return;
				case 2:
					if (IaZ3gobJhgmVK1myC9AL())
					{
						num2 = 8;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
						{
							num2 = 5;
						}
						break;
					}
					goto default;
				case 8:
					obj = Locator.GetService<IMetadataRuntimeService>();
					goto IL_0374;
				case 6:
					{
						enumerator = (from m in metadataRuntimeService.GetMetadataList().OfType<EnumMetadata>().Where(_003C_003Ec__DisplayClass55_._003CLoadExtensionValues_003Eb__0)
							select _003C_003Ec.nJKFZICHsrypAxO1VpWW(m)).GetEnumerator();
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
						{
							num2 = 7;
						}
						break;
					}
					IL_0374:
					metadataRuntimeService = (IMetadataRuntimeService)obj;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
					{
						num2 = 3;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 6;
		}
	}

	PublicationType IDeltaRootMetadata.GetPublicationTypeOnChange(IMetadata oldMetadata)
	{
		//Discarded unreachable code: IL_0052, IL_0061
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (Type == EnumMetadataType.Enum)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			default:
				return PublicationType.Restart;
			case 1:
				return GgTQgTbJb1ZtJmptqL8G(oldMetadata, this);
			}
		}
	}

	internal static object cX7IvvbMNb3kcwwCn40y()
	{
		return SR.LocalizableString.Empty;
	}

	internal static void xHlT7rbM3VVAhhtDtUM6(object P_0, bool value)
	{
		((EnumMetadata)P_0).ShowInTypeTree = value;
	}

	internal static void KwtpuZbMp4K9MTveEu4E(object P_0, bool value)
	{
		((EnumMetadata)P_0).ShowInDesigner = value;
	}

	internal static bool t42rfHbMPoyoQYR6f1lc()
	{
		return GKryuCbMexq6EOAMDi5q == null;
	}

	internal static EnumMetadata WYq0nrbM1N5cQApvHstJ()
	{
		return GKryuCbMexq6EOAMDi5q;
	}

	internal static void E1Q51xbMabb81sCAx5TB(object P_0)
	{
		((EnumMetadata)P_0).OnNamespaceChanged();
	}

	internal static object uWlAj9bMDGGU094Q9bg8(object P_0)
	{
		return (string)(SR.LocalizableString)P_0;
	}

	internal static object PAMl6ubMtW4rUEBFRBZ4(object P_0)
	{
		return (SR.LocalizableString)(string)P_0;
	}

	internal static Guid CGe5wqbMwA4vr5n5NhE3(object P_0)
	{
		return ((EnumMetadata)P_0).BaseTypeUid;
	}

	internal static bool JBSo9lbM4YCaC7dKRil3(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static object KhTDuPbM6qvomKxyFnSl(object P_0)
	{
		return ((EnumMetadata)P_0).Namespace;
	}

	internal static bool PFJod3bMHtwvxdUniUF2(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object IXIn2HbMAabObAjJBl5G(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object llYagHbM7OJBW6gkGQo7(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static object Xq7EQBbMxPTrsjC0ONgo(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static int uuLwZobM0Dh7cQZSdn9v(object P_0)
	{
		return ((List<EnumValueMetadata>)P_0).Count;
	}

	internal static object Qg9QAybMmHdS6lZD06xx()
	{
		return Logger.Log;
	}

	internal static object qicSO6bMynJPhTYHnmgL(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static void mykeHTbMMDH9a1Sc2F3t(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static void zknEKGbMJGtjWkDo7nQ3(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static bool UPFx3gbM9MQhhNMtrIk6(Type type)
	{
		return type.IsNullableType();
	}

	internal static void WypKf8bMde1xPTrMkd1Y(object P_0, Guid value)
	{
		((AbstractMetadata)P_0).Uid = value;
	}

	internal static void lfCwNrbMliEHCOgcgS8w(object P_0, Guid value)
	{
		((AbstractMetadata)P_0).ModuleUid = value;
	}

	internal static void yASeEjbMrcvBS7cvCdTZ(object P_0, bool value)
	{
		((AbstractMetadata)P_0).Internal = value;
	}

	internal static object haVBDbbMghZf1BmL5FxX(object P_0)
	{
		return ((MemberInfo)P_0).Name;
	}

	internal static void qyKiR2bM5wgUAOQyH3Vw(object P_0, object P_1)
	{
		((EnumMetadata)P_0).Namespace = (string)P_1;
	}

	internal static Guid XsyGx0bMj6aM5ncyiqjD(object P_0)
	{
		return ((BaseClassAttribute)P_0).BaseClassUid;
	}

	internal static void IeDVTKbMYXC24QsVKYA0(object P_0, Guid value)
	{
		((EnumMetadata)P_0).BaseTypeUid = value;
	}

	internal static EnumMetadataType nYak2DbMLHu3vlgUCJ6A(object P_0)
	{
		return ((EnumMetadataTypeAttribute)P_0).Type;
	}

	internal static void VKU7WdbMUJDT0gJGqqZu(object P_0, EnumMetadataType value)
	{
		((EnumMetadata)P_0).Type = value;
	}

	internal static long ktrNAEbMsY6PCDXb9h2H(object P_0)
	{
		return ((GroupIdAttribute)P_0).Id;
	}

	internal static void yNG86UbMcq5alaOORHkY(object P_0, long value)
	{
		((EnumMetadata)P_0).GroupId = value;
	}

	internal static object EwuSc6bMzrCw3jB1TjEw(object P_0)
	{
		return ((LocalizedStringAttribute)P_0).LocalizedString;
	}

	internal static void byqZswbJFyyuraQKgTFB(object P_0, object P_1)
	{
		NamedMetadata.SetDisplayName((NamedMetadata)P_0, (SR.LocalizableString)P_1);
	}

	internal static void YfR3qYbJB7nggWf2Z2GO(object P_0, object P_1)
	{
		NamedMetadata.SetDescription((NamedMetadata)P_0, (SR.LocalizableString)P_1);
	}

	internal static bool IwHKHmbJW4X7G8KxpZZv(object P_0)
	{
		return ((ShowInTypeTreeAttribute)P_0).Visible;
	}

	internal static bool QK2ygabJoKxIXRvH5T5n(object P_0)
	{
		return ((ShowInDesignerAttribute)P_0).Visible;
	}

	internal static PublicationType GgTQgTbJb1ZtJmptqL8G(object P_0, object P_1)
	{
		return MetadataSoftPublishHelper.IsEqualsObject(P_0, P_1);
	}

	internal static bool IaZ3gobJhgmVK1myC9AL()
	{
		return Locator.Initialized;
	}

	internal static Guid IUth26bJGQQ3nbiG72eK(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static object DECMK5bJEJvMy93tukC9(object P_0, Guid metadataUid)
	{
		return ((MetadataItemManager)P_0).GetSoftPublishedMetadata(metadataUid);
	}

	internal static void B3rl44bJfA8E0Q6tpEIW(object P_0, object P_1)
	{
		MetadataSoftPublishHelper.CopyChanges((IMetadata)P_0, (IMetadata)P_1);
	}

	internal static void HxsajubJQIZtH35jG8bh(object P_0, object P_1)
	{
		((MetadataItemValidationError)P_0).Message = (string)P_1;
	}

	internal static object g9V5hcbJC2buVlciki2X(object P_0, object P_1)
	{
		return ((FieldInfo)P_0).GetValue(P_1);
	}

	internal static object Gx7yn8bJvyPbkrEPRdlt(Type type, BindingFlags bindingAttr)
	{
		return type.GetReflectionProperties(bindingAttr);
	}

	internal static void xoklbVbJ8p5R2vN8b0QY(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object j6GiE7bJZPCTSTmso0vt(object P_0)
	{
		return ((EnumValueMetadata)P_0).EnumValue;
	}

	internal static bool UjyJJObJue5ZxXIXUTHu(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}
}
