using System;
using System.Collections.Generic;
using System.Data;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.FullTextSearch.Descriptors;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.MetadataInternalContainer.Containers;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Runtime.NH.CustomTypes;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Types;

[Component(Order = 900)]
public class DropDownListDescriptor : CLRTypeDescriptor<DropDownItem, DropDownListSettings>, IMappingTypeDescriptor, ILocalizableType
{
	public const string UID_S = "{55888705-4BFA-431B-8A93-71B80EED484D}";

	public static readonly Guid UID;

	private IFullTextPropertyDescriptor propertyDescriptor;

	private static DropDownListDescriptor hrq1oPoAmU2K3MFBP7Yf;

	public override Guid Uid => UID;

	public override string Name => SR.T((string)dnOjFPoA93fF8IeXeltS(-787452571 ^ -787290009));

	public override bool IsAvailibleEditPropertyInTable => true;

	public override IFullTextPropertyDescriptor FullTextPropertyDescriptor
	{
		get
		{
			int num = 1;
			int num2 = num;
			IFullTextPropertyDescriptor fullTextPropertyDescriptor = default(IFullTextPropertyDescriptor);
			IFullTextPropertyDescriptor fullTextPropertyDescriptor2;
			while (true)
			{
				switch (num2)
				{
				default:
					fullTextPropertyDescriptor = (propertyDescriptor = new DropDownPropertyDescriptor(this));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
					{
						num2 = 2;
					}
					continue;
				case 1:
					fullTextPropertyDescriptor2 = propertyDescriptor;
					if (fullTextPropertyDescriptor2 == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				case 2:
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
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				n9htvqoAJlFBU17lYR1b(this, mapper, propertyMetadata);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
				{
					num2 = 0;
				}
				break;
			default:
				mapper.Type<DropDownItemNHType>();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			}
		}
	}

	public override bool IsEmptyOrDefault(PropertyMetadata propertyMetadata, object val)
	{
		//Discarded unreachable code: IL_0079, IL_00be, IL_00cd, IL_0113, IL_017b, IL_0209
		int num = 15;
		int num2 = num;
		DropDownItem dropDownItem = default(DropDownItem);
		DropDownListSettings dropDownListSettings = default(DropDownListSettings);
		while (true)
		{
			switch (num2)
			{
			case 3:
			case 5:
				return true;
			case 13:
				if (Ji69XUoAdCcpUecZXsDu(this, propertyMetadata, val))
				{
					num2 = 6;
					break;
				}
				if (propertyMetadata != null)
				{
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
					{
						num2 = 9;
					}
					break;
				}
				goto default;
			case 7:
				return zgJQFAoAYm4YVQPjDYh0(D34pYboArvSJPoSaUTk9(dropDownItem), D34pYboArvSJPoSaUTk9(xcojBqoAglxy3l9UrKuy(dropDownListSettings)));
			case 10:
				return false;
			case 4:
				if (D34pYboArvSJPoSaUTk9(dropDownItem) != null)
				{
					if (xcojBqoAglxy3l9UrKuy(dropDownListSettings) != null)
					{
						num2 = 12;
						break;
					}
					goto case 10;
				}
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
				{
					num2 = 0;
				}
				break;
			case 15:
				if (val == null)
				{
					num2 = 14;
					break;
				}
				goto case 13;
			case 6:
			case 14:
				return true;
			case 12:
				if (!PpUbVUoAjDCFA0WRD3SE(k5TgGToA5fqSnCntJ3mj(dropDownItem), ((DropDownItem)xcojBqoAglxy3l9UrKuy(dropDownListSettings)).Key))
				{
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
					{
						num2 = 3;
					}
					break;
				}
				goto case 7;
			case 2:
				return true;
			case 1:
				dropDownItem = val as DropDownItem;
				num2 = 11;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
				{
					num2 = 11;
				}
				break;
			default:
				return true;
			case 9:
				dropDownListSettings = (DropDownListSettings)sCBV3voAlL5RcXZma4D7(propertyMetadata);
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
				{
					num2 = 5;
				}
				break;
			case 11:
				if (dropDownItem == null)
				{
					num2 = 3;
					break;
				}
				goto case 4;
			case 8:
				if (dropDownListSettings != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	public override ISyntaxNode GetPropertyInitExpression(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter = false)
	{
		//Discarded unreachable code: IL_003d, IL_004c, IL_0145
		int num = 3;
		int num2 = num;
		DropDownListSettings dropDownListSettings = default(DropDownListSettings);
		while (true)
		{
			switch (num2)
			{
			case 4:
			case 5:
				return null;
			case 1:
				return j1Xw2toAUFJyPbs05Q9q(typeof(DropDownItem).TypeHandle).CreateTypeSyntax().ObjectCreationExpression(k5TgGToA5fqSnCntJ3mj(xcojBqoAglxy3l9UrKuy(dropDownListSettings)).CreateSyntaxNode(), (ISyntaxNode)jRSuXAoAs9c9CxXtILco(D34pYboArvSJPoSaUTk9(xcojBqoAglxy3l9UrKuy(dropDownListSettings))));
			default:
				if (dropDownListSettings == null)
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 6;
			case 6:
				if (dropDownListSettings.DefaultValue != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 4;
			case 3:
				gLUbqcoALhHks7ZSOPOb(propertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-234299632 ^ -234318270));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				dropDownListSettings = (DropDownListSettings)sCBV3voAlL5RcXZma4D7(propertyMetadata);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override IPropertyDefaultValueContainer GetDefaultContainer(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter = false)
	{
		int num = 1;
		int num2 = num;
		object value;
		while (true)
		{
			switch (num2)
			{
			case 1:
				Contract.ArgumentNotNull(propertyMetadata, (string)dnOjFPoA93fF8IeXeltS(0x6DC147B0 ^ 0x6DC10EE2));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
				{
					num2 = 0;
				}
				continue;
			default:
			{
				DropDownListSettings obj = (DropDownListSettings)sCBV3voAlL5RcXZma4D7(propertyMetadata);
				if (obj == null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
					{
						num2 = 1;
					}
					continue;
				}
				value = obj.DefaultValue;
				break;
			}
			case 2:
				value = null;
				break;
			}
			break;
		}
		return new PropertyValueContainer<DropDownItem>((DropDownItem)value);
	}

	public override void ApplyFilterValue(ICriteria criteria, EntityMetadata metadata, EntityPropertyMetadata propertyMetadata, object value, string alias)
	{
		//Discarded unreachable code: IL_0032
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				if (value is DropDownItem)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
					{
						num2 = 0;
					}
					break;
				}
				return;
			case 3:
				return;
			default:
				Ra4VD0o7BUkSyUmHbI2h(criteria, IPie0eo7FW82drgpxVNx(VKyRVEoAcGaokuO7rF7Q(alias) ? AFnAtnoAzkTSlaZUEblJ(propertyMetadata) : string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5DD55050 ^ 0x5DD51252), alias, propertyMetadata.Name), value.ToString(), MatchMode.Exact));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public override TypeSettings CreateSettingsForFilterProperty(PropertyMetadata propertyMetadata)
	{
		//Discarded unreachable code: IL_0056, IL_0065
		int num = 4;
		int num2 = num;
		DropDownListSettings dropDownListSettings = default(DropDownListSettings);
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (dropDownListSettings == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			case 4:
				dropDownListSettings = (DropDownListSettings)base.CreateSettingsForFilterProperty(propertyMetadata);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
				{
					num2 = 3;
				}
				break;
			case 1:
				BIVYhOo7Wc0Sp05SDKuV(dropDownListSettings, null);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
				{
					num2 = 2;
				}
				break;
			default:
				return dropDownListSettings;
			}
		}
	}

	public override bool IsPublicApplicationDisplayEnabled(Guid subTypeUid)
	{
		return true;
	}

	public override bool IsPublicApplicationEditorEnabled(Guid subTypeUid)
	{
		return true;
	}

	protected override ColumnType GetDbColumnType(EntityMetadata entityMetadata, EntityPropertyMetadata propertyMetadata)
	{
		return new ColumnType(DbType.String, 2000);
	}

	public IEnumerable<string> GetLocalizableStrings(PropertyMetadata propertyMetadata)
	{
		List<string> list = new List<string>();
		if (propertyMetadata == null)
		{
			return list;
		}
		if (!(propertyMetadata.Settings is DropDownListSettings dropDownListSettings))
		{
			return list;
		}
		foreach (DropDownItem item in dropDownListSettings.Items)
		{
			if (!string.IsNullOrEmpty(item.Key))
			{
				list.Add(item.Value);
			}
		}
		return list;
	}

	public DropDownListDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		zkkduTo7o02kcCrarmwv();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static DropDownListDescriptor()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				SingletonReader.JJCZtPuTvSt();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				UID = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x10E41EDB ^ 0x10E69BF3));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void n9htvqoAJlFBU17lYR1b(object P_0, object P_1, object P_2)
	{
		((SimpleTypeDescriptor<DropDownItem>)P_0).ExtendSimplePropertyMapping((INHibernatePropertyTypeMapper)P_1, (EntityPropertyMetadata)P_2);
	}

	internal static bool fAN7LVoAyd3EZ9hmt0U5()
	{
		return hrq1oPoAmU2K3MFBP7Yf == null;
	}

	internal static DropDownListDescriptor PGk2cGoAMS8DSBLY9rCp()
	{
		return hrq1oPoAmU2K3MFBP7Yf;
	}

	internal static object dnOjFPoA93fF8IeXeltS(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool Ji69XUoAdCcpUecZXsDu(object P_0, object P_1, object P_2)
	{
		return ((TypeDescriptor)P_0).IsEmpty((PropertyMetadata)P_1, P_2);
	}

	internal static object sCBV3voAlL5RcXZma4D7(object P_0)
	{
		return ((PropertyMetadata)P_0).Settings;
	}

	internal static object D34pYboArvSJPoSaUTk9(object P_0)
	{
		return ((DropDownItem)P_0).Value;
	}

	internal static object xcojBqoAglxy3l9UrKuy(object P_0)
	{
		return ((DropDownListSettings)P_0).DefaultValue;
	}

	internal static object k5TgGToA5fqSnCntJ3mj(object P_0)
	{
		return ((DropDownItem)P_0).Key;
	}

	internal static bool PpUbVUoAjDCFA0WRD3SE(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static bool zgJQFAoAYm4YVQPjDYh0(object P_0, object P_1)
	{
		return ((string)P_0).Equals((string)P_1);
	}

	internal static void gLUbqcoALhHks7ZSOPOb(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static Type j1Xw2toAUFJyPbs05Q9q(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object jRSuXAoAs9c9CxXtILco(object P_0)
	{
		return P_0.CreateSyntaxNode();
	}

	internal static bool VKyRVEoAcGaokuO7rF7Q(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object AFnAtnoAzkTSlaZUEblJ(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static object IPie0eo7FW82drgpxVNx(object P_0, object P_1, object P_2)
	{
		return ElmaRestrictions.InsensitiveLike((string)P_0, (string)P_1, (MatchMode)P_2);
	}

	internal static object Ra4VD0o7BUkSyUmHbI2h(object P_0, object P_1)
	{
		return ((ICriteria)P_0).Add((ICriterion)P_1);
	}

	internal static void BIVYhOo7Wc0Sp05SDKuV(object P_0, object P_1)
	{
		((DropDownListSettings)P_0).DefaultValue = (DropDownItem)P_1;
	}

	internal static void zkkduTo7o02kcCrarmwv()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
