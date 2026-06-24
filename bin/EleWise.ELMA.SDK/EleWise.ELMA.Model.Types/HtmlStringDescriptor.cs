using System;
using System.Data;
using System.Web;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.FullTextSearch.Descriptors;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.HtmlStrings;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.MetadataInternalContainer.Containers;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Types;

[Component(Order = 300)]
public class HtmlStringDescriptor : CLRTypeDescriptor<HtmlString, HtmlStringSettings>, IMappingTypeDescriptor, IConvertableTypeDescriptor
{
	public const string UID_S = "{0AEF74A9-D37C-4731-813B-D5F0B5EC4392}";

	public static readonly Guid UID;

	private IFullTextPropertyDescriptor propertyDescriptor;

	private static HtmlStringDescriptor jmaBbCoHpaXhX0uxgUsX;

	public override Guid Uid => UID;

	public override string Name => (string)gbvoMyoHtE7dw2FMD0Ug(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x31326106 ^ 0x3130E338));

	public override IFullTextPropertyDescriptor FullTextPropertyDescriptor
	{
		get
		{
			int num = 2;
			int num2 = num;
			IFullTextPropertyDescriptor fullTextPropertyDescriptor = default(IFullTextPropertyDescriptor);
			IFullTextPropertyDescriptor fullTextPropertyDescriptor2;
			while (true)
			{
				switch (num2)
				{
				case 1:
					fullTextPropertyDescriptor = (propertyDescriptor = new HtmlStringPropertyDescriptor(this));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					fullTextPropertyDescriptor2 = propertyDescriptor;
					if (fullTextPropertyDescriptor2 == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					break;
				default:
					fullTextPropertyDescriptor2 = fullTextPropertyDescriptor;
					break;
				}
				break;
			}
			return fullTextPropertyDescriptor2;
		}
	}

	protected override void ExtendSimplePropertyMapping(INHibernatePropertyTypeMapper mapper, EntityPropertyMetadata propertyMetadata)
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
				base.ExtendSimplePropertyMapping(mapper, propertyMetadata);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				mapper.Type<HtmlStringType>();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public override bool IsEmpty(PropertyMetadata propertyMetadata, object val)
	{
		//Discarded unreachable code: IL_0035, IL_0044, IL_0084, IL_00af
		int num = 4;
		int num2 = num;
		object obj;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!(val is IHtmlString))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
					{
						num2 = 0;
					}
					continue;
				}
				obj = yYPecqoH4Oo3CUS9JC3L((IHtmlString)val);
				break;
			case 4:
				if (val == null)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
					{
						num2 = 3;
					}
					continue;
				}
				if (dbxgaloHwR61a22VcNeK(val.GetType(), typeof(string)))
				{
					num2 = 2;
					continue;
				}
				goto case 1;
			default:
				obj = null;
				break;
			case 3:
				return true;
			case 2:
				obj = (string)val;
				break;
			}
			break;
		}
		return oFGWusoH6MJiZfPMGmXy(obj);
	}

	public override ISyntaxNode GetPropertyInitExpression(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter = false)
	{
		int num = 4;
		int num2 = num;
		HtmlStringSettings htmlStringSettings = default(HtmlStringSettings);
		while (true)
		{
			switch (num2)
			{
			default:
				if (htmlStringSettings != null)
				{
					num2 = 2;
					break;
				}
				goto case 1;
			case 1:
				return null;
			case 3:
				htmlStringSettings = (HtmlStringSettings)ejsPjloH7NeQZOu78tUK(propertyMetadata);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				if (!oFGWusoH6MJiZfPMGmXy(flFObcoHxTlo0FBCDY2m(htmlStringSettings)))
				{
					return ((ISyntaxNode)j1QkvkoHmFIkjIS8Wmy1(QreBo6oH0YnChfOD8sNQ(typeof(MvcHtmlString).TypeHandle))).ObjectCreationExpression(htmlStringSettings.DefaultValue.CreateSyntaxNode());
				}
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				XFcS3ToHADMY4tQAsAhA(propertyMetadata, yZHPLtoHHwis8IZdpcEu(0x269E5FCA ^ 0x269E1698));
				num2 = 3;
				break;
			}
		}
	}

	public override IPropertyDefaultValueContainer GetDefaultContainer(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter = false)
	{
		//Discarded unreachable code: IL_004f, IL_00b0, IL_00e1, IL_00ec
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		int num = 2;
		int num2 = num;
		HtmlStringSettings htmlStringSettings = default(HtmlStringSettings);
		object value2;
		while (true)
		{
			object obj;
			object value;
			switch (num2)
			{
			case 5:
				if (htmlStringSettings == null)
				{
					num2 = 6;
					continue;
				}
				obj = htmlStringSettings.DefaultValue;
				goto IL_0123;
			case 6:
				obj = null;
				goto IL_0123;
			case 1:
				htmlStringSettings = (HtmlStringSettings)ejsPjloH7NeQZOu78tUK(propertyMetadata);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
				{
					num2 = 4;
				}
				continue;
			case 2:
				XFcS3ToHADMY4tQAsAhA(propertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x48A7E34A ^ 0x48A7AA18));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
				{
					num2 = 1;
				}
				continue;
			case 4:
				if (htmlStringSettings == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				value = htmlStringSettings.DefaultValue;
				goto IL_00f8;
			case 3:
				value2 = null;
				break;
			default:
				{
					value = null;
					goto IL_00f8;
				}
				IL_00f8:
				if (!string.IsNullOrEmpty((string)value))
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
					{
						num2 = 5;
					}
					continue;
				}
				goto case 3;
				IL_0123:
				value2 = (object)new MvcHtmlString((string)obj);
				break;
			}
			break;
		}
		return new PropertyValueContainer<HtmlString>((HtmlString)value2);
	}

	public virtual object ConvertFrom(object value, PropertyMetadata propertyMetadata)
	{
		//Discarded unreachable code: IL_009e, IL_00ad
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (!(value is HtmlString))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			case 4:
				return u7OplToHy7tVFxGInqRa((string)value);
			case 3:
				if (value != null)
				{
					num2 = 2;
					break;
				}
				goto case 1;
			case 1:
				return value;
			default:
				if (!(value.GetType() == QreBo6oH0YnChfOD8sNQ(typeof(string).TypeHandle)))
				{
					return null;
				}
				num2 = 4;
				break;
			}
		}
	}

	public override object SerializeSimple(object value, Type valueType, EntitySerializationSettings settings)
	{
		//Discarded unreachable code: IL_008b
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (value is IHtmlString)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			case 2:
				return null;
			default:
				return yYPecqoH4Oo3CUS9JC3L((IHtmlString)value);
			case 3:
				break;
			}
			if (value != null)
			{
				break;
			}
			num2 = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
			{
				num2 = 2;
			}
		}
		return value.ToString();
	}

	public override object DeserializeSimple(object value, Type deserializeToType)
	{
		return ConvertFrom(value, null);
	}

	public override TypeSettings CreateSettingsForFilterProperty(PropertyMetadata propertyMetadata)
	{
		//Discarded unreachable code: IL_0072, IL_0081
		int num = 2;
		int num2 = num;
		HtmlStringSettings htmlStringSettings = default(HtmlStringSettings);
		while (true)
		{
			switch (num2)
			{
			case 2:
				htmlStringSettings = (HtmlStringSettings)base.CreateSettingsForFilterProperty(propertyMetadata);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
				{
					num2 = 1;
				}
				break;
			case 3:
			case 4:
				return htmlStringSettings;
			default:
				omou8eoHM8BtONGDkanp(htmlStringSettings, null);
				num2 = 4;
				break;
			case 1:
				if (htmlStringSettings == null)
				{
					num2 = 3;
					break;
				}
				goto default;
			}
		}
	}

	protected override ColumnType GetDbColumnType(EntityMetadata entityMetadata, EntityPropertyMetadata propertyMetadata)
	{
		return new ColumnType(DbType.String, int.MaxValue);
	}

	public override void ApplyFilterValue(ICriteria criteria, EntityMetadata metadata, EntityPropertyMetadata propertyMetadata, object val, string alias)
	{
		//Discarded unreachable code: IL_0072, IL_00c9, IL_00d8, IL_011a, IL_0125, IL_0134, IL_0148
		int num = 8;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 4:
				if (text != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return;
			case 11:
				return;
			case 7:
				if (val is string)
				{
					num2 = 6;
					break;
				}
				goto case 3;
			default:
				if (!text.Trim().Equals(string.Empty))
				{
					num2 = 9;
					break;
				}
				return;
			case 8:
				if (val == null)
				{
					return;
				}
				num2 = 7;
				break;
			case 3:
				if (val is IHtmlString)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 5;
			case 1:
				obj = yYPecqoH4Oo3CUS9JC3L((IHtmlString)val);
				goto IL_0154;
			case 2:
				return;
			case 5:
				obj = null;
				goto IL_0154;
			case 6:
				obj = (string)val;
				goto IL_0154;
			case 10:
				return;
			case 9:
				{
					A7IwK9oHleQPy4uG5oik(criteria, LiZOuZoHdeYVGXrXgWlK(oFGWusoH6MJiZfPMGmXy(alias) ? M09UBdoH91AMvPI8XO7y(propertyMetadata) : O0iiZNoHJk7PXecVDQEL(yZHPLtoHHwis8IZdpcEu(-1979251663 ^ -1979234765), alias, propertyMetadata.Name), text, MatchMode.Anywhere));
					num2 = 2;
					break;
				}
				IL_0154:
				text = (string)obj;
				num2 = 4;
				break;
			}
		}
	}

	public HtmlStringDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		whEpjLoHrDY6oW8JHimm();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static HtmlStringDescriptor()
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
				whEpjLoHrDY6oW8JHimm();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				UID = new Guid((string)yZHPLtoHHwis8IZdpcEu(-1411196499 ^ -1411359759));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static bool vcF43SoHaiBaMaMARD7o()
	{
		return jmaBbCoHpaXhX0uxgUsX == null;
	}

	internal static HtmlStringDescriptor H35xa1oHDDI8kaLJ6Zmm()
	{
		return jmaBbCoHpaXhX0uxgUsX;
	}

	internal static object gbvoMyoHtE7dw2FMD0Ug(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool dbxgaloHwR61a22VcNeK(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static object yYPecqoH4Oo3CUS9JC3L(object P_0)
	{
		return ((IHtmlString)P_0).ToHtmlString();
	}

	internal static bool oFGWusoH6MJiZfPMGmXy(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object yZHPLtoHHwis8IZdpcEu(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void XFcS3ToHADMY4tQAsAhA(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object ejsPjloH7NeQZOu78tUK(object P_0)
	{
		return ((PropertyMetadata)P_0).Settings;
	}

	internal static object flFObcoHxTlo0FBCDY2m(object P_0)
	{
		return ((HtmlStringSettings)P_0).DefaultValue;
	}

	internal static Type QreBo6oH0YnChfOD8sNQ(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object j1QkvkoHmFIkjIS8Wmy1(Type type)
	{
		return type.CreateTypeSyntax();
	}

	internal static object u7OplToHy7tVFxGInqRa(object P_0)
	{
		return MvcHtmlString.Create((string)P_0);
	}

	internal static void omou8eoHM8BtONGDkanp(object P_0, object P_1)
	{
		((HtmlStringSettings)P_0).DefaultValue = (string)P_1;
	}

	internal static object O0iiZNoHJk7PXecVDQEL(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static object M09UBdoH91AMvPI8XO7y(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static object LiZOuZoHdeYVGXrXgWlK(object P_0, object P_1, object P_2)
	{
		return ElmaRestrictions.InsensitiveLike((string)P_0, (string)P_1, (MatchMode)P_2);
	}

	internal static object A7IwK9oHleQPy4uG5oik(object P_0, object P_1)
	{
		return ((ICriteria)P_0).Add((ICriterion)P_1);
	}

	internal static void whEpjLoHrDY6oW8JHimm()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
