using System;
using System.Collections.Generic;
using System.Reflection;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.FullTextSearch.Enum;
using EleWise.ELMA.FullTextSearch.Model;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.FullTextSearch.Descriptors;

public class DropDownPropertyDescriptor : FullTextPropertyDescriptor
{
	private Func<IPropertyMetadata, string> indexFieldName;

	internal static DropDownPropertyDescriptor rvLTCMGvpa60VW2q6Zwf;

	public DropDownPropertyDescriptor(ISerializableTypeDescriptor typeDescriptor)
	{
		//Discarded unreachable code: IL_005d, IL_0062
		vxNhRUGvtWnr6yR9hYO6();
		indexFieldName = (IPropertyMetadata propMd) => (string)_003C_003Ec.pGv0Vwvj0XWoBVqnfy7x(_003C_003Ec.RdjomNvj7gK8MEiXlj9X(-16752921 ^ -16703997), _003C_003Ec.OkDoDOvjxom9UA2v25Am(propMd).ToString(), _003C_003Ec.RdjomNvj7gK8MEiXlj9X(0x2A7797B7 ^ 0x2A765AC3));
		base._002Ector(typeDescriptor);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public override FieldIndexList GetMappingField(IPropertyMetadata propMd)
	{
		return new FieldIndexList
		{
			new FieldIndexListItem(ValueFieldName(propMd), null, FullTextFieldType.String, FullTextFieldTag.Value),
			new FieldIndexListItem(SortFieldName(propMd), null, FullTextFieldType.String, FullTextFieldTag.Sort),
			new FieldIndexListItem(indexFieldName(propMd), null, FullTextFieldType.Long, FullTextFieldTag.Value)
		};
	}

	public override FieldIndexList GetIndexField(object obj, IPropertyMetadata propMd, bool reindex)
	{
		//Discarded unreachable code: IL_0065, IL_0099, IL_00a8, IL_00bf
		int num = 4;
		int num2 = num;
		DropDownItem dropDownItem = default(DropDownItem);
		string text = default(string);
		while (true)
		{
			object obj2;
			switch (num2)
			{
			case 1:
				return new FieldIndexList();
			case 3:
				dropDownItem = obj as DropDownItem;
				num2 = 2;
				break;
			case 4:
				if (propMd != null)
				{
					num2 = 3;
					break;
				}
				goto case 1;
			case 2:
				if (dropDownItem == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 6;
			case 6:
				obj2 = dropDownItem.ToString();
				goto IL_00c5;
			default:
				obj2 = null;
				goto IL_00c5;
			case 5:
				{
					return new FieldIndexList
					{
						new FieldIndexListItem(ValueFieldName(propMd), text, FullTextFieldType.String),
						new FieldIndexListItem(SortFieldName(propMd), xSxlKuGvwBoYh3iDnwUW(obj), FullTextFieldType.String),
						new FieldIndexListItem(indexFieldName(propMd), (dropDownItem == null) ? null : new long?(abdYJIGv4uHp8qLsHNeX(text.GetHashCode())), FullTextFieldType.Long)
					};
				}
				IL_00c5:
				text = (string)obj2;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
				{
					num2 = 5;
				}
				break;
			}
		}
	}

	public override FilterListItem GetFilterField(object value, IPropertyMetadata propMd, IEntityFilter filter)
	{
		//Discarded unreachable code: IL_007d, IL_00af, IL_00e7, IL_00f6
		int num = 1;
		int num2 = num;
		FilterListItem filterListItem = default(FilterListItem);
		DropDownItem dropDownItem = default(DropDownItem);
		while (true)
		{
			switch (num2)
			{
			case 3:
				try
				{
					filterListItem = new FilterListItem(indexFieldName(propMd), new List<object> { abdYJIGv4uHp8qLsHNeX(dropDownItem.ToString().GetHashCode()) }, FilterListItemType.Must, FullTextFieldType.Long);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
					{
						num3 = 0;
					}
					return num3 switch
					{
						0 => filterListItem, 
						_ => filterListItem, 
					};
				}
				catch (Exception)
				{
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
					{
						num4 = 0;
					}
					while (true)
					{
						switch (num4)
						{
						case 1:
							return filterListItem;
						}
						filterListItem = null;
						num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
						{
							num4 = 1;
						}
					}
				}
			case 2:
				return null;
			default:
				if (dropDownItem != null)
				{
					num2 = 3;
					break;
				}
				goto case 2;
			case 1:
				dropDownItem = value as DropDownItem;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override SortListItem GetSortField(IPropertyMetadata propMd)
	{
		return new SortListItem(SortFieldName(propMd), FullTextFieldType.String);
	}

	public override void SetIndexField(object obj, object value, IPropertyMetadata propMd)
	{
		//Discarded unreachable code: IL_0080, IL_008f, IL_010f, IL_011e, IL_012e, IL_013e, IL_014d, IL_01a8, IL_01db, IL_022d, IL_023c
		int num = 10;
		WebDataItem webDataItem = default(WebDataItem);
		PropertyInfo propertyCached = default(PropertyInfo);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 7:
					if (!pOROsDGvAP76rQvJS0FE(C16g5tGvHSy4C4eCOX4v(webDataItem), ValueFieldName(propMd)))
					{
						num2 = 11;
						continue;
					}
					return;
				case 6:
					return;
				case 13:
					webDataItem = value as WebDataItem;
					num2 = 5;
					continue;
				case 5:
					if (propertyCached == null)
					{
						num2 = 6;
						continue;
					}
					goto case 2;
				case 10:
					if (obj != null)
					{
						num = 9;
						break;
					}
					return;
				case 12:
					return;
				case 1:
					propertyCached = obj.GetType().GetPropertyCached((string)yZFYqnGv6lhSRRfAZjmT(propMd));
					num2 = 13;
					continue;
				case 2:
					if (webDataItem == null)
					{
						num = 4;
						break;
					}
					goto case 7;
				case 4:
					return;
				case 3:
					return;
				case 9:
					if (propMd == null)
					{
						return;
					}
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
					{
						num2 = 0;
					}
					continue;
				case 8:
					try
					{
						propertyCached.SetValue(obj, new DropDownItem(webDataItem.Value), null);
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
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
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								return;
							}
							QHyMbTGvxPBL5j7YkuoP(Logger.Log, AwJjSjGv7ERvUjBOtDQP(0x17ADCCD8 ^ 0x17AE0630), ex);
							num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
							{
								num4 = 1;
							}
						}
					}
				case 0:
					return;
				case 11:
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
					{
						num2 = 8;
					}
					continue;
				}
				break;
			}
		}
	}

	public override void SetEmptyIndexField(object obj, IPropertyMetadata propMd, string fieldName)
	{
		//Discarded unreachable code: IL_00cd, IL_012f, IL_013e, IL_01b0, IL_01c7, IL_01ed, IL_01fc
		int num = 9;
		PropertyInfo propertyCached = default(PropertyInfo);
		object value = default(object);
		object obj2 = default(object);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 9:
					if (obj != null)
					{
						num2 = 8;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
						{
							num2 = 2;
						}
						continue;
					}
					return;
				case 8:
					if (propMd != null)
					{
						num2 = 6;
						continue;
					}
					return;
				case 3:
					return;
				case 6:
					propertyCached = obj.GetType().GetPropertyCached((string)yZFYqnGv6lhSRRfAZjmT(propMd));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
					{
						num2 = 1;
					}
					continue;
				default:
					try
					{
						int num3;
						if ((propMd as PropertyMetadata).Nullable)
						{
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
							{
								num3 = 1;
							}
							goto IL_00d1;
						}
						goto IL_0149;
						IL_0149:
						value = base.TypeDescriptor.SerializeSimple(null, typeof(DropDownItem));
						num3 = 2;
						goto IL_00d1;
						IL_00d1:
						while (true)
						{
							switch (num3)
							{
							default:
								return;
							case 2:
								obj2 = base.TypeDescriptor.DeserializeSimple(value, typeof(DropDownItem));
								num3 = 3;
								continue;
							case 1:
								ArGMWOGvmTqwJ7cEm6hR(propertyCached, obj, null, null);
								num3 = 4;
								continue;
							case 4:
								return;
							case 5:
								break;
							case 3:
								ArGMWOGvmTqwJ7cEm6hR(propertyCached, obj, obj2, null);
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
								{
									num3 = 0;
								}
								continue;
							case 0:
								return;
							}
							break;
						}
						goto IL_0149;
					}
					catch (Exception)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
						return;
					}
				case 1:
					if (!v9aT9UGv0t3NDHgAxviv(propertyCached, null))
					{
						num2 = 5;
						continue;
					}
					return;
				case 7:
					if (!(propMd is PropertyMetadata))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
						{
							num2 = 2;
						}
					}
					else
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
						{
							num2 = 0;
						}
					}
					continue;
				case 4:
					return;
				case 2:
					return;
				case 5:
					if (pOROsDGvAP76rQvJS0FE(fieldName, ValueFieldName(propMd)))
					{
						return;
					}
					num = 7;
					break;
				}
				break;
			}
		}
	}

	internal static void vxNhRUGvtWnr6yR9hYO6()
	{
		SingletonReader.PushGlobal();
	}

	internal static bool OpyYcuGvaVhFAl1dqb4P()
	{
		return rvLTCMGvpa60VW2q6Zwf == null;
	}

	internal static DropDownPropertyDescriptor yyIIYLGvDkutD4vp6GX1()
	{
		return rvLTCMGvpa60VW2q6Zwf;
	}

	internal static object xSxlKuGvwBoYh3iDnwUW(object P_0)
	{
		return StringPropertyDescriptor.ConvertToSortable(P_0);
	}

	internal static long abdYJIGv4uHp8qLsHNeX(int P_0)
	{
		return Convert.ToInt64(P_0);
	}

	internal static object yZFYqnGv6lhSRRfAZjmT(object P_0)
	{
		return ((IPropertyMetadata)P_0).Name;
	}

	internal static object C16g5tGvHSy4C4eCOX4v(object P_0)
	{
		return ((WebDataItem)P_0).Name;
	}

	internal static bool pOROsDGvAP76rQvJS0FE(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}

	internal static object AwJjSjGv7ERvUjBOtDQP(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void QHyMbTGvxPBL5j7YkuoP(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Warn(P_1, (Exception)P_2);
	}

	internal static bool v9aT9UGv0t3NDHgAxviv(object P_0, object P_1)
	{
		return (PropertyInfo)P_0 == (PropertyInfo)P_1;
	}

	internal static void ArGMWOGvmTqwJ7cEm6hR(object P_0, object P_1, object P_2, object P_3)
	{
		((PropertyInfo)P_0).SetValue(P_1, P_2, (object[])P_3);
	}
}
