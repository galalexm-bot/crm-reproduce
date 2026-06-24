using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Xml;
using System.Xml.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Enums;
using EleWise.ELMA.Model.Views;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Metadata;

[Serializable]
public class EnumValueMetadata : NamedDocumentedMetadata
{
	internal static EnumValueMetadata QTt2EKbJIj4RwhfjUc8Y;

	[XmlElement("IntValue", IsNullable = true)]
	[PublicationBehaviour(PublicationType.Restart)]
	public int? IntValue { get; set; }

	[DefaultValue(Visibility.Visible)]
	[XmlElement("Visibility")]
	public Visibility Visibility
	{
		[CompilerGenerated]
		get
		{
			return _003CVisibility_003Ek__BackingField;
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
					_003CVisibility_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[XmlIgnore]
	public object EnumValue
	{
		[CompilerGenerated]
		get
		{
			return _003CEnumValue_003Ek__BackingField;
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
					_003CEnumValue_003Ek__BackingField = value;
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

	public virtual EnumMetadataAdditionalAttribute[] AdditionalAttributes
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
				case 0:
					return;
				case 1:
					_003CAdditionalAttributes_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public EnumValueMetadata()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		sIYoAcbJiCmNHOi7lHw2();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				Visibility = Visibility.Visible;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public override string ToString()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (BoEsDkbJqDRNgBIq3U34(biMFgxbJRWWAeYMcBonp(this)))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
					{
						num2 = 0;
					}
					break;
				}
				return (string)biMFgxbJRWWAeYMcBonp(this);
			default:
				return (string)e0pNi1bJKWD2JfSCtKB8(this);
			}
		}
	}

	public virtual void LoadFromValue(Type enumType, object enumValue)
	{
		int num = 2;
		int num2 = num;
		MemberInfo member = default(MemberInfo);
		while (true)
		{
			switch (num2)
			{
			case 1:
				Eu9T4hbJTwmJ3fCOQgsE(enumValue, vc3HLqbJXSB5wVi5MBlk(-1411196499 ^ -1411373115));
				num2 = 3;
				break;
			case 2:
				Eu9T4hbJTwmJ3fCOQgsE(enumType, vc3HLqbJXSB5wVi5MBlk(0x34185E55 ^ 0x341AA3BF));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				return;
			case 3:
				member = (MemberInfo)((object[])nTKD6KbJkwacNXQgAYCj(enumType, enumValue.ToString()))[0];
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
				{
					num2 = 0;
				}
				break;
			default:
				LoadFromMember(member, enumValue);
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
				{
					num2 = 4;
				}
				break;
			}
		}
	}

	public virtual void LoadFromMember(MemberInfo member, object enumValue = null)
	{
		//Discarded unreachable code: IL_00d7, IL_0141, IL_0171, IL_0180, IL_018c, IL_019b, IL_027b, IL_0332, IL_036a, IL_0379, IL_03ac, IL_046f, IL_04e4, IL_04f3
		int num = 27;
		int num2 = num;
		UidAttribute attribute5 = default(UidAttribute);
		XmlReader xmlReader = default(XmlReader);
		EnumMetadataAdditionalAttributesAttribute attribute3 = default(EnumMetadataAdditionalAttributesAttribute);
		object[] array = default(object[]);
		ViewAttribute attribute = default(ViewAttribute);
		PropertyInfo propertyInfo = default(PropertyInfo);
		IEnumerator<ImageAttribute> enumerator = default(IEnumerator<ImageAttribute>);
		ImageAttribute current = default(ImageAttribute);
		EnumBase enumValue2 = default(EnumBase);
		EleWise.ELMA.Model.Attributes.DisplayNameAttribute attribute4 = default(EleWise.ELMA.Model.Attributes.DisplayNameAttribute);
		EleWise.ELMA.Model.Attributes.DescriptionAttribute attribute2 = default(EleWise.ELMA.Model.Attributes.DescriptionAttribute);
		while (true)
		{
			switch (num2)
			{
			case 26:
				attribute5 = AttributeHelper<UidAttribute>.GetAttribute(member, inherited: false);
				num2 = 14;
				break;
			case 6:
				try
				{
					XmlSerializer xmlSerializer = new XmlSerializer(F7pU05bJ6f8Qye6wRvrB(typeof(EnumMetadataAdditionalAttribute[]).TypeHandle));
					int num6 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
					{
						num6 = 0;
					}
					while (true)
					{
						switch (num6)
						{
						default:
							eY1wLJbJATaDMyEGnxnJ(this, (EnumMetadataAdditionalAttribute[])cda07SbJHf82qe6gNLWq(xmlSerializer, xmlReader));
							num6 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
							{
								num6 = 0;
							}
							continue;
						case 1:
							break;
						}
						break;
					}
				}
				finally
				{
					int num7;
					if (xmlReader == null)
					{
						num7 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
						{
							num7 = 1;
						}
						goto IL_0145;
					}
					goto IL_015b;
					IL_015b:
					qsTeaUbJ7d8Mf8vGOdWa(xmlReader);
					num7 = 2;
					goto IL_0145;
					IL_0145:
					switch (num7)
					{
					case 1:
						goto end_IL_0120;
					case 2:
						goto end_IL_0120;
					}
					goto IL_015b;
					end_IL_0120:;
				}
				goto default;
			case 18:
				attribute3 = AttributeHelper<EnumMetadataAdditionalAttributesAttribute>.GetAttribute(member, inherited: true);
				num2 = 17;
				break;
			case 2:
				if (array.Length != 0)
				{
					num2 = 13;
					break;
				}
				return;
			case 17:
				if (attribute3 == null)
				{
					num2 = 11;
					break;
				}
				goto case 3;
			case 29:
				attribute = AttributeHelper<ViewAttribute>.GetAttribute(member, inherited: true);
				num2 = 19;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
				{
					num2 = 2;
				}
				break;
			case 5:
				if (typeof(EnumBase).IsAssignableFrom(lT5YA0bJ1sswCMv26VqU(propertyInfo)))
				{
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
					{
						num2 = 16;
					}
					break;
				}
				goto case 12;
			case 24:
				IntValue = (int)enumValue;
				num2 = 12;
				break;
			case 30:
				WFZ2MvbJe4u2tl3kAusA(this, Ko8qVsbJ2yheWWMxEMKu(member));
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
				{
					num2 = 2;
				}
				break;
			case 10:
				try
				{
					while (true)
					{
						int num4;
						if (!qew2tobJ0SslHZ93WP7M(enumerator))
						{
							int num3 = 3;
							num4 = num3;
							goto IL_0289;
						}
						goto IL_02e9;
						IL_0289:
						while (true)
						{
							switch (num4)
							{
							case 1:
								Images.Add(new MetadataImage(current));
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
								{
									num4 = 0;
								}
								continue;
							case 2:
								goto IL_02e9;
							case 3:
								return;
							}
							break;
						}
						continue;
						IL_02e9:
						current = enumerator.Current;
						num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
						{
							num4 = 1;
						}
						goto IL_0289;
					}
				}
				finally
				{
					if (enumerator != null)
					{
						int num5 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
						{
							num5 = 0;
						}
						while (true)
						{
							switch (num5)
							{
							default:
								qsTeaUbJ7d8Mf8vGOdWa(enumerator);
								num5 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
								{
									num5 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
			case 25:
				propertyInfo = member as PropertyInfo;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
				{
					num2 = 9;
				}
				break;
			case 15:
				return;
			case 9:
				if (!x3wAvCbJPBlewxi0GDC0(propertyInfo, null))
				{
					num2 = 20;
					break;
				}
				goto case 5;
			case 16:
				enumValue2 = (EnumBase)lnHBZdbJNychJ3u6LtkX(propertyInfo, null, null);
				num2 = 22;
				break;
			case 27:
				Contract.ArgumentNotNull(member, (string)vc3HLqbJXSB5wVi5MBlk(-561074844 ^ -561229030));
				num2 = 26;
				break;
			case 7:
				enumerator = array.Cast<ImageAttribute>().GetEnumerator();
				num2 = 10;
				break;
			case 12:
			case 20:
			case 28:
				attribute4 = AttributeHelper<EleWise.ELMA.Model.Attributes.DisplayNameAttribute>.GetAttribute(member, inherited: true);
				num2 = 8;
				break;
			case 13:
				Images = new List<MetadataImage>();
				num2 = 7;
				break;
			case 3:
				xmlReader = (XmlReader)lvN7w6bJ4kIvIYsrZRRn(new StringReader(attribute3.EnumAdditionalAttributes));
				num2 = 6;
				break;
			case 22:
				EnumValue = enumValue2;
				num2 = 28;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
				{
					num2 = 5;
				}
				break;
			case 21:
				EnumValue = enumValue;
				num2 = 24;
				break;
			case 4:
				if (enumValue != null)
				{
					num2 = 21;
					break;
				}
				goto case 25;
			case 23:
				attribute2 = AttributeHelper<EleWise.ELMA.Model.Attributes.DescriptionAttribute>.GetAttribute(member, inherited: true);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
				{
					num2 = 1;
				}
				break;
			default:
				array = (object[])S7n7ODbJxKc67iuvJemd(member, F7pU05bJ6f8Qye6wRvrB(typeof(ImageAttribute).TypeHandle), false);
				num2 = 2;
				break;
			case 14:
				RUjRmebJOixDQl6sYRQD(this, (attribute5 != null) ? qSeV9nbJnC71q8lBJ1Kd(attribute5) : Guid.Empty);
				num2 = 30;
				break;
			case 8:
				u3QDOUbJaWvPEiaJ4geS(this, (attribute4 != null) ? t75dZCbJpTYBKicNVUJk(attribute4) : YGwmJMbJ3v8xRVIhdWB6(e0pNi1bJKWD2JfSCtKB8(this)));
				num2 = 23;
				break;
			case 1:
				X4dQExbJtqBOPxrhMhwo(this, (attribute2 != null) ? t75dZCbJpTYBKicNVUJk(attribute2) : vRfx9FbJDOTeRbL0pCDq());
				num2 = 29;
				break;
			case 19:
				Visibility = ((attribute == null) ? Visibility.Visible : CL9drqbJwT8DhfCiMT3E(attribute));
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
				{
					num2 = 18;
				}
				break;
			}
		}
	}

	internal static void sIYoAcbJiCmNHOi7lHw2()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool Rb88EQbJVn86DjLvlM5i()
	{
		return QTt2EKbJIj4RwhfjUc8Y == null;
	}

	internal static EnumValueMetadata UQ84QkbJSsSQcsL4iBK9()
	{
		return QTt2EKbJIj4RwhfjUc8Y;
	}

	internal static object biMFgxbJRWWAeYMcBonp(object P_0)
	{
		return ((NamedMetadata)P_0).DisplayName;
	}

	internal static bool BoEsDkbJqDRNgBIq3U34(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object e0pNi1bJKWD2JfSCtKB8(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static object vc3HLqbJXSB5wVi5MBlk(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void Eu9T4hbJTwmJ3fCOQgsE(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object nTKD6KbJkwacNXQgAYCj(Type type, object P_1)
	{
		return type.GetReflectionMember((string)P_1);
	}

	internal static Guid qSeV9nbJnC71q8lBJ1Kd(object P_0)
	{
		return ((UidAttribute)P_0).Uid;
	}

	internal static void RUjRmebJOixDQl6sYRQD(object P_0, Guid value)
	{
		((AbstractMetadata)P_0).Uid = value;
	}

	internal static object Ko8qVsbJ2yheWWMxEMKu(object P_0)
	{
		return ((MemberInfo)P_0).Name;
	}

	internal static void WFZ2MvbJe4u2tl3kAusA(object P_0, object P_1)
	{
		((NamedMetadata)P_0).Name = (string)P_1;
	}

	internal static bool x3wAvCbJPBlewxi0GDC0(object P_0, object P_1)
	{
		return (PropertyInfo)P_0 != (PropertyInfo)P_1;
	}

	internal static Type lT5YA0bJ1sswCMv26VqU(object P_0)
	{
		return ((PropertyInfo)P_0).PropertyType;
	}

	internal static object lnHBZdbJNychJ3u6LtkX(object P_0, object P_1, object P_2)
	{
		return ((PropertyInfo)P_0).GetValue(P_1, (object[])P_2);
	}

	internal static object YGwmJMbJ3v8xRVIhdWB6(object P_0)
	{
		return (SR.LocalizableString)(string)P_0;
	}

	internal static object t75dZCbJpTYBKicNVUJk(object P_0)
	{
		return ((LocalizedStringAttribute)P_0).LocalizedString;
	}

	internal static void u3QDOUbJaWvPEiaJ4geS(object P_0, object P_1)
	{
		NamedMetadata.SetDisplayName((NamedMetadata)P_0, (SR.LocalizableString)P_1);
	}

	internal static object vRfx9FbJDOTeRbL0pCDq()
	{
		return SR.LocalizableString.Empty;
	}

	internal static void X4dQExbJtqBOPxrhMhwo(object P_0, object P_1)
	{
		NamedMetadata.SetDescription((NamedMetadata)P_0, (SR.LocalizableString)P_1);
	}

	internal static Visibility CL9drqbJwT8DhfCiMT3E(object P_0)
	{
		return ((ViewAttribute)P_0).Visibility;
	}

	internal static object lvN7w6bJ4kIvIYsrZRRn(object P_0)
	{
		return XmlReader.Create((TextReader)P_0);
	}

	internal static Type F7pU05bJ6f8Qye6wRvrB(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object cda07SbJHf82qe6gNLWq(object P_0, object P_1)
	{
		return ((XmlSerializer)P_0).Deserialize((XmlReader)P_1);
	}

	internal static void eY1wLJbJATaDMyEGnxnJ(object P_0, object P_1)
	{
		((EnumValueMetadata)P_0).AdditionalAttributes = (EnumMetadataAdditionalAttribute[])P_1;
	}

	internal static void qsTeaUbJ7d8Mf8vGOdWa(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object S7n7ODbJxKc67iuvJemd(object P_0, Type P_1, bool P_2)
	{
		return ((MemberInfo)P_0).GetCustomAttributes(P_1, P_2);
	}

	internal static bool qew2tobJ0SslHZ93WP7M(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}
}
