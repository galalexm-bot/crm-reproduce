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
using EleWise.ELMA.Model.Types.Helpers;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.FullTextSearch.Descriptors;

public class DoublePropertyDescriptor : FullTextPropertyDescriptor
{
	internal static DoublePropertyDescriptor GaK2ojGI9AuwspJZqJNS;

	public DoublePropertyDescriptor(ISerializableTypeDescriptor typeDescriptor)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		udDw9pGIrPRHFnPTW0YX();
		base._002Ector(typeDescriptor);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public override FieldIndexList GetIndexField(object obj, IPropertyMetadata propMd, bool reindex)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (propMd == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
					{
						num2 = 0;
					}
					break;
				}
				return new FieldIndexList
				{
					new FieldIndexListItem(ValueFieldName(propMd), (obj == null) ? null : new double?(Convert.ToDouble(obj)), FullTextFieldType.Double)
				};
			default:
				return new FieldIndexList();
			}
		}
	}

	public override FilterListItem GetFilterField(object value, IPropertyMetadata propMd, IEntityFilter filter)
	{
		//Discarded unreachable code: IL_00d6, IL_00e5, IL_0128, IL_0137, IL_015c, IL_016b, IL_024b, IL_0283, IL_0292
		FilterListItem result2 = default(FilterListItem);
		switch (1)
		{
		default:
			return result2;
		case 1:
		{
			FilterListItem result = default(FilterListItem);
			try
			{
				DoubleRangeWrapper doubleRangeWrapper = value as DoubleRangeWrapper;
				int num = 2;
				List<object> list = default(List<object>);
				while (true)
				{
					switch (num)
					{
					case 3:
						return result2;
					case 12:
						return result2;
					case 9:
						return result;
					default:
						if (!doubleRangeWrapper.HasFromValue)
						{
							num = 4;
							break;
						}
						goto case 6;
					case 6:
						list = new List<object>();
						num = 10;
						break;
					case 1:
					case 11:
						result2 = new FilterListItem(ValueFieldName(propMd), new List<object> { value }, FilterListItemType.Must, FullTextFieldType.Double);
						num = 12;
						break;
					case 7:
						result = null;
						num = 9;
						break;
					case 4:
						if (!CK96uTGIgeZoB2FG5ttQ(doubleRangeWrapper))
						{
							num = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
							{
								num = 7;
							}
							break;
						}
						goto case 6;
					case 2:
						if (doubleRangeWrapper == null)
						{
							int num2 = 11;
							num = num2;
							break;
						}
						goto default;
					case 5:
						result2 = new FilterListItem(ValueFieldName(propMd), list, FilterListItemType.Between, FullTextFieldType.Double);
						num = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
						{
							num = 3;
						}
						break;
					case 10:
						list.Add(BGq7NXGI5yi6halnbZcT(doubleRangeWrapper) ? new double?(doubleRangeWrapper.From) : null);
						num = 8;
						break;
					case 8:
						list.Add(CK96uTGIgeZoB2FG5ttQ(doubleRangeWrapper) ? new double?(mOQ3QCGIjEZs0DPJxJN3(doubleRangeWrapper)) : null);
						num = 5;
						break;
					}
				}
			}
			catch (Exception)
			{
				int num3 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
				{
					num3 = 0;
				}
				while (true)
				{
					switch (num3)
					{
					case 1:
						return result;
					}
					result = null;
					num3 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
					{
						num3 = 1;
					}
				}
			}
		}
		}
	}

	public override SortListItem GetSortField(IPropertyMetadata propMd)
	{
		return new SortListItem(ValueFieldName(propMd), FullTextFieldType.Double);
	}

	public override void SetIndexField(object obj, object value, IPropertyMetadata propMd)
	{
		//Discarded unreachable code: IL_00db, IL_00ea, IL_0111, IL_017f, IL_01b7, IL_01de, IL_01ed, IL_023b, IL_024a, IL_0276, IL_02c7
		int num = 12;
		int num2 = num;
		WebDataItem webDataItem = default(WebDataItem);
		PropertyInfo propertyCached = default(PropertyInfo);
		while (true)
		{
			switch (num2)
			{
			case 12:
				if (obj == null)
				{
					num2 = 11;
					break;
				}
				goto case 5;
			case 2:
				return;
			case 6:
				return;
			default:
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
				{
					num2 = 1;
				}
				break;
			case 10:
				if (G1iw0QGIsPnfJ4qUWdSv(dAOFGNGIUuUC9RHOeX82(webDataItem), ValueFieldName(propMd)))
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				webDataItem = value as WebDataItem;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
				{
					num2 = 9;
				}
				break;
			case 8:
				return;
			case 9:
				if (LqGG7XGILjS6F8EZOgVI(propertyCached, null))
				{
					num2 = 2;
					break;
				}
				goto case 7;
			case 11:
				return;
			case 7:
				if (webDataItem == null)
				{
					return;
				}
				num2 = 10;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
				{
					num2 = 7;
				}
				break;
			case 3:
				return;
			case 5:
				if (propMd != null)
				{
					propertyCached = obj.GetType().GetPropertyCached((string)d6cERbGIYb9adqhCnKQb(propMd));
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
					{
						num2 = 4;
					}
				}
				else
				{
					num2 = 3;
				}
				break;
			case 1:
				try
				{
					int num3;
					if (!double.TryParse((string)p9rXcqGIcFRoo2QwsTjw(webDataItem), out var result))
					{
						num3 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
						{
							num3 = 3;
						}
						goto IL_01bb;
					}
					goto IL_021c;
					IL_021c:
					KJdc7uGIzA8EcNU72ADP(propertyCached, obj, result, null);
					num3 = 2;
					goto IL_01bb;
					IL_01bb:
					while (true)
					{
						switch (num3)
						{
						default:
							return;
						case 0:
							return;
						case 2:
							return;
						case 3:
						case 4:
							KJdc7uGIzA8EcNU72ADP(propertyCached, obj, null, null);
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
							{
								num3 = 0;
							}
							continue;
						case 1:
							break;
						}
						break;
					}
					goto IL_021c;
				}
				catch (Exception exception)
				{
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
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
						((ILogger)CQm5UJGVFTERZnUcJeOM()).Warn(bAQkYrGVBUbHmnjVHT5Q(0x3C5338FF ^ 0x3C50F217), exception);
						num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
						{
							num4 = 0;
						}
					}
				}
			}
		}
	}

	public override void SetEmptyIndexField(object obj, IPropertyMetadata propMd, string fieldName)
	{
		//Discarded unreachable code: IL_0137, IL_0146, IL_0156, IL_0165, IL_01e7, IL_01fe, IL_0219, IL_0228, IL_027a, IL_0289
		int num = 2;
		int num2 = num;
		PropertyInfo propertyCached = default(PropertyInfo);
		object obj2 = default(object);
		object value = default(object);
		while (true)
		{
			switch (num2)
			{
			case 7:
				if (propertyCached == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
					{
						num2 = 3;
					}
					break;
				}
				goto default;
			case 5:
				return;
			case 10:
				if (propMd is PropertyMetadata)
				{
					num2 = 8;
					break;
				}
				return;
			case 1:
				if (propMd != null)
				{
					propertyCached = obj.GetType().GetPropertyCached(propMd.Name);
					num2 = 7;
				}
				else
				{
					num2 = 5;
				}
				break;
			case 9:
				try
				{
					int num4;
					if (!(propMd as PropertyMetadata).Nullable)
					{
						int num3 = 2;
						num4 = num3;
						goto IL_00d5;
					}
					goto IL_00fb;
					IL_00d5:
					while (true)
					{
						switch (num4)
						{
						case 3:
							break;
						default:
							obj2 = base.TypeDescriptor.DeserializeSimple(value, jOvJ0UGVWvEechhQBGwO(typeof(double).TypeHandle));
							num4 = 6;
							continue;
						case 5:
							return;
						case 1:
						case 2:
							value = base.TypeDescriptor.SerializeSimple(null, jOvJ0UGVWvEechhQBGwO(typeof(double).TypeHandle));
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
							{
								num4 = 0;
							}
							continue;
						case 6:
							KJdc7uGIzA8EcNU72ADP(propertyCached, obj, obj2, null);
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
							{
								num4 = 4;
							}
							continue;
						case 4:
							return;
						}
						break;
					}
					goto IL_00fb;
					IL_00fb:
					propertyCached.SetValue(obj, null, null);
					num4 = 5;
					goto IL_00d5;
				}
				catch (Exception)
				{
					int num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
					{
						num5 = 0;
					}
					switch (num5)
					{
					case 0:
						break;
					}
					return;
				}
			case 3:
				return;
			case 4:
				return;
			case 8:
				num2 = 9;
				break;
			case 6:
				return;
			default:
				if (G1iw0QGIsPnfJ4qUWdSv(fieldName, ValueFieldName(propMd)))
				{
					return;
				}
				num2 = 10;
				break;
			case 2:
				if (obj == null)
				{
					return;
				}
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static void udDw9pGIrPRHFnPTW0YX()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool QMjO3jGIdU47yHjd2M1A()
	{
		return GaK2ojGI9AuwspJZqJNS == null;
	}

	internal static DoublePropertyDescriptor X61UaTGIlntO2VN4JWb0()
	{
		return GaK2ojGI9AuwspJZqJNS;
	}

	internal static bool CK96uTGIgeZoB2FG5ttQ(object P_0)
	{
		return ((DoubleRangeWrapper)P_0).HasToValue;
	}

	internal static bool BGq7NXGI5yi6halnbZcT(object P_0)
	{
		return ((DoubleRangeWrapper)P_0).HasFromValue;
	}

	internal static double mOQ3QCGIjEZs0DPJxJN3(object P_0)
	{
		return ((DoubleRangeWrapper)P_0).To;
	}

	internal static object d6cERbGIYb9adqhCnKQb(object P_0)
	{
		return ((IPropertyMetadata)P_0).Name;
	}

	internal static bool LqGG7XGILjS6F8EZOgVI(object P_0, object P_1)
	{
		return (PropertyInfo)P_0 == (PropertyInfo)P_1;
	}

	internal static object dAOFGNGIUuUC9RHOeX82(object P_0)
	{
		return ((WebDataItem)P_0).Name;
	}

	internal static bool G1iw0QGIsPnfJ4qUWdSv(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}

	internal static object p9rXcqGIcFRoo2QwsTjw(object P_0)
	{
		return ((WebDataItem)P_0).Value;
	}

	internal static void KJdc7uGIzA8EcNU72ADP(object P_0, object P_1, object P_2, object P_3)
	{
		((PropertyInfo)P_0).SetValue(P_1, P_2, (object[])P_3);
	}

	internal static object CQm5UJGVFTERZnUcJeOM()
	{
		return Logger.Log;
	}

	internal static object bAQkYrGVBUbHmnjVHT5Q(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static Type jOvJ0UGVWvEechhQBGwO(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}
}
