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

public class MoneyPropertyDescriptor : FullTextPropertyDescriptor
{
	private static MoneyPropertyDescriptor XFgFRbGZnKdskTrnhRG5;

	public MoneyPropertyDescriptor(ISerializableTypeDescriptor typeDescriptor)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		HndYWFGZeYqUFy7ARCgX();
		base._002Ector(typeDescriptor);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
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
		//Discarded unreachable code: IL_005f, IL_006e
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (reindex)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				return GetIndexField(obj, propMd);
			default:
				return GetReIndexField(obj, propMd);
			}
		}
	}

	private FieldIndexList GetIndexField(object obj, IPropertyMetadata propMd)
	{
		//Discarded unreachable code: IL_0088, IL_0097, IL_0110
		int num = 1;
		Money money = default(Money);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					if (!(obj is Money))
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
						{
							num2 = 6;
						}
						break;
					}
					goto case 3;
				case 3:
					money = (Money)obj;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
					{
						num2 = 0;
					}
					break;
				default:
					if (obj == null)
					{
						goto end_IL_0012;
					}
					goto case 5;
				case 1:
					if (propMd != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 4;
				case 7:
					return new FieldIndexList
					{
						new FieldIndexListItem(ValueFieldName(propMd), l2367PGZPX4jBPiNZBhB(money.Value), FullTextFieldType.Double)
					};
				case 4:
				case 6:
					return new FieldIndexList();
				case 2:
					if (money.HasValue)
					{
						num2 = 7;
						break;
					}
					goto case 4;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 4;
		}
	}

	private FieldIndexList GetReIndexField(object obj, IPropertyMetadata propMd)
	{
		//Discarded unreachable code: IL_0072, IL_0081, IL_00b6
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return GetIndexField(obj, propMd);
			case 3:
				if (propMd == null)
				{
					num2 = 2;
					break;
				}
				goto case 4;
			case 5:
				return new FieldIndexList
				{
					new FieldIndexListItem(ValueFieldName(propMd), null, FullTextFieldType.Double)
				};
			case 1:
			case 2:
				return new FieldIndexList();
			case 4:
				if (!(obj is Money))
				{
					if (obj != null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto case 5;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override FilterListItem GetFilterField(object value, IPropertyMetadata propMd, IEntityFilter filter)
	{
		//Discarded unreachable code: IL_00e0, IL_00ef, IL_00ff, IL_010e, IL_011d, IL_012d, IL_0140, IL_014f, IL_015f, IL_0425, IL_045d, IL_046c
		switch (1)
		{
		case 1:
		{
			FilterListItem result = default(FilterListItem);
			try
			{
				MoneyRangeWrapper moneyRangeWrapper = value as MoneyRangeWrapper;
				int num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
				{
					num = 15;
				}
				MoneyWrapper moneyWrapper = default(MoneyWrapper);
				Money money = default(Money);
				List<object> list = default(List<object>);
				while (true)
				{
					int num2;
					List<object> list3;
					double? obj2;
					List<object> list2;
					double? obj;
					switch (num)
					{
					case 23:
						moneyWrapper = value as MoneyWrapper;
						num = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
						{
							num = 11;
						}
						continue;
					case 24:
						money = ((MoneyWrapper)Wfi4IqGZ3UN12UUlQ7Mf(moneyRangeWrapper)).Value;
						num = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
						{
							num = 3;
						}
						continue;
					case 5:
						if (money.HasValue)
						{
							num = 14;
							continue;
						}
						break;
					case 4:
						money = WDGqEZGZpyse8kZaVh5w(moneyWrapper);
						num2 = 5;
						goto IL_0047;
					case 11:
						if (moneyWrapper != null)
						{
							num2 = 6;
							goto IL_0047;
						}
						break;
					case 14:
					{
						string field = ValueFieldName(propMd);
						List<object> list4 = new List<object>();
						money = WDGqEZGZpyse8kZaVh5w(moneyWrapper);
						list4.Add(money.Value);
						result = new FilterListItem(field, list4, FilterListItemType.Must, FullTextFieldType.Double);
						num = 20;
						continue;
					}
					case 15:
						if (moneyRangeWrapper != null)
						{
							num = 12;
							continue;
						}
						goto case 23;
					case 16:
						result = new FilterListItem(ValueFieldName(propMd), list, FilterListItemType.Between, FullTextFieldType.Double);
						num = 22;
						continue;
					case 1:
					case 3:
						result = null;
						num = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
						{
							num = 17;
						}
						continue;
					case 6:
						if (HVU38OGZNF0PRbQ1OVH7(moneyWrapper))
						{
							num = 4;
							continue;
						}
						break;
					case 13:
					case 18:
						if (!HVU38OGZNF0PRbQ1OVH7(Wfi4IqGZ3UN12UUlQ7Mf(moneyRangeWrapper)))
						{
							num = 3;
							continue;
						}
						goto case 24;
					case 7:
					case 21:
						list = new List<object>();
						num = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
						{
							num = 0;
						}
						continue;
					case 10:
						if (!money.HasValue)
						{
							num = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
							{
								num = 1;
							}
							continue;
						}
						goto case 7;
					case 8:
						if (money.HasValue)
						{
							num = 21;
							continue;
						}
						goto case 13;
					case 12:
						if (!HVU38OGZNF0PRbQ1OVH7(p4NyLLGZ17deMkO4o1SY(moneyRangeWrapper)))
						{
							num = 13;
							continue;
						}
						goto case 19;
					case 19:
						money = ((MoneyWrapper)p4NyLLGZ17deMkO4o1SY(moneyRangeWrapper)).Value;
						num = 8;
						continue;
					case 2:
						list3 = list;
						if (HVU38OGZNF0PRbQ1OVH7(moneyRangeWrapper.From))
						{
							money = WDGqEZGZpyse8kZaVh5w(p4NyLLGZ17deMkO4o1SY(moneyRangeWrapper));
							if (money.HasValue)
							{
								money = ((MoneyWrapper)p4NyLLGZ17deMkO4o1SY(moneyRangeWrapper)).Value;
								obj2 = money.Value;
								goto IL_037d;
							}
						}
						obj2 = null;
						goto IL_037d;
					case 9:
						list2 = list;
						if (HVU38OGZNF0PRbQ1OVH7(Wfi4IqGZ3UN12UUlQ7Mf(moneyRangeWrapper)))
						{
							money = WDGqEZGZpyse8kZaVh5w(Wfi4IqGZ3UN12UUlQ7Mf(moneyRangeWrapper));
							if (money.HasValue)
							{
								money = WDGqEZGZpyse8kZaVh5w(moneyRangeWrapper.To);
								obj = money.Value;
								goto IL_03f1;
							}
						}
						obj = null;
						goto IL_03f1;
					case 0:
						break;
					case 17:
						return result;
					case 20:
						return result;
					case 22:
						{
							return result;
						}
						IL_0047:
						num = num2;
						continue;
						IL_03f1:
						list2.Add(obj);
						num = 16;
						continue;
						IL_037d:
						list3.Add(obj2);
						num = 9;
						continue;
					}
					break;
				}
			}
			catch (Exception)
			{
				int num3 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
					{
						num3 = 0;
					}
				}
			}
			break;
		}
		}
		return null;
	}

	public override SortListItem GetSortField(IPropertyMetadata propMd)
	{
		return new SortListItem(ValueFieldName(propMd), FullTextFieldType.Double);
	}

	public override void SetIndexField(object obj, object value, IPropertyMetadata propMd)
	{
		//Discarded unreachable code: IL_013d, IL_01bd, IL_01f0, IL_0241, IL_0250, IL_0260
		int num = 10;
		int num2 = num;
		PropertyInfo propertyCached = default(PropertyInfo);
		WebDataItem webDataItem = default(WebDataItem);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 8:
				return;
			case 9:
				return;
			case 4:
				propertyCached = obj.GetType().GetPropertyCached((string)m3wbMZGZaZdh45KGeGEU(propMd));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				return;
			default:
				webDataItem = value as WebDataItem;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
				{
					num2 = 3;
				}
				break;
			case 11:
				if (!((string)oEissPGZtpf4TE60sfIY(webDataItem) != ValueFieldName(propMd)))
				{
					num2 = 5;
					break;
				}
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
				{
					num2 = 2;
				}
				break;
			case 3:
				if (DMY4QuGZDYmR2m6hBBv4(propertyCached, null))
				{
					return;
				}
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
				{
					num2 = 6;
				}
				break;
			case 6:
				if (webDataItem == null)
				{
					return;
				}
				num2 = 11;
				break;
			case 10:
				if (obj == null)
				{
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 7;
			case 7:
				if (propMd == null)
				{
					return;
				}
				num2 = 4;
				break;
			case 5:
				try
				{
					MXdZRBGZwa56UUGWgdbT(propertyCached, obj, double.TryParse(webDataItem.Value, out var result) ? new Money
					{
						Value = result
					} : new Money
					{
						HasValue = false
					}, null);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
					{
						num4 = 1;
					}
					while (true)
					{
						switch (num4)
						{
						default:
							return;
						case 0:
							return;
						case 1:
							FCuNUgGZHfWmArOou6bI(fwTRSFGZ4fQrbCkV7mrr(), t4LEmLGZ6Eb7a0iKG1pU(-2112703338 ^ -2112782722), ex);
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
							{
								num4 = 0;
							}
							break;
						}
					}
				}
			}
		}
	}

	public override void SetEmptyIndexField(object obj, IPropertyMetadata propMd, string fieldName)
	{
		//Discarded unreachable code: IL_0051, IL_0060, IL_0096, IL_00c5, IL_00d4, IL_0162, IL_0171, IL_019c, IL_01b3, IL_01c2, IL_01d1, IL_029c
		int num = 3;
		PropertyInfo propertyCached = default(PropertyInfo);
		object obj2 = default(object);
		object value = default(object);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					try
					{
						int num3;
						if (!(propMd as PropertyMetadata).Nullable)
						{
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
							{
								num3 = 1;
							}
							goto IL_009a;
						}
						goto IL_00df;
						IL_00df:
						MXdZRBGZwa56UUGWgdbT(propertyCached, obj, null, null);
						num3 = 3;
						goto IL_009a;
						IL_009a:
						while (true)
						{
							switch (num3)
							{
							default:
								return;
							case 5:
								break;
							case 2:
								MXdZRBGZwa56UUGWgdbT(propertyCached, obj, obj2, null);
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
								{
									num3 = 0;
								}
								continue;
							case 1:
							case 6:
								value = base.TypeDescriptor.SerializeSimple(null, typeof(Money));
								num3 = 4;
								continue;
							case 4:
								obj2 = base.TypeDescriptor.DeserializeSimple(value, typeof(Money));
								num3 = 2;
								continue;
							case 3:
								return;
							case 0:
								return;
							}
							break;
						}
						goto IL_00df;
					}
					catch (Exception)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
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
				case 2:
					return;
				case 8:
					return;
				case 9:
					num2 = 5;
					break;
				default:
					if (propMd != null)
					{
						num2 = 11;
						break;
					}
					return;
				case 7:
					if (!(propMd is PropertyMetadata))
					{
						return;
					}
					num2 = 9;
					break;
				case 6:
					if (DMY4QuGZDYmR2m6hBBv4(propertyCached, null))
					{
						return;
					}
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					if (LWSpH9GZAYyrVeHEGMn0(fieldName, ValueFieldName(propMd)))
					{
						return;
					}
					goto end_IL_0012;
				case 10:
					return;
				case 11:
					propertyCached = obj.GetType().GetPropertyCached((string)m3wbMZGZaZdh45KGeGEU(propMd));
					num2 = 6;
					break;
				case 3:
					if (obj == null)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto default;
				case 4:
					return;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 7;
		}
	}

	internal static void HndYWFGZeYqUFy7ARCgX()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool BTbK5rGZO2iMkQgYSHCR()
	{
		return XFgFRbGZnKdskTrnhRG5 == null;
	}

	internal static MoneyPropertyDescriptor tWBkTFGZ2Mpbg3K3GZci()
	{
		return XFgFRbGZnKdskTrnhRG5;
	}

	internal static double l2367PGZPX4jBPiNZBhB(double P_0)
	{
		return Convert.ToDouble(P_0);
	}

	internal static object p4NyLLGZ17deMkO4o1SY(object P_0)
	{
		return ((MoneyRangeWrapper)P_0).From;
	}

	internal static bool HVU38OGZNF0PRbQ1OVH7(object P_0)
	{
		return ((MoneyWrapper)P_0).HasValue;
	}

	internal static object Wfi4IqGZ3UN12UUlQ7Mf(object P_0)
	{
		return ((MoneyRangeWrapper)P_0).To;
	}

	internal static Money WDGqEZGZpyse8kZaVh5w(object P_0)
	{
		return ((MoneyWrapper)P_0).Value;
	}

	internal static object m3wbMZGZaZdh45KGeGEU(object P_0)
	{
		return ((IPropertyMetadata)P_0).Name;
	}

	internal static bool DMY4QuGZDYmR2m6hBBv4(object P_0, object P_1)
	{
		return (PropertyInfo)P_0 == (PropertyInfo)P_1;
	}

	internal static object oEissPGZtpf4TE60sfIY(object P_0)
	{
		return ((WebDataItem)P_0).Name;
	}

	internal static void MXdZRBGZwa56UUGWgdbT(object P_0, object P_1, object P_2, object P_3)
	{
		((PropertyInfo)P_0).SetValue(P_1, P_2, (object[])P_3);
	}

	internal static object fwTRSFGZ4fQrbCkV7mrr()
	{
		return Logger.Log;
	}

	internal static object t4LEmLGZ6Eb7a0iKG1pU(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void FCuNUgGZHfWmArOou6bI(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Warn(P_1, (Exception)P_2);
	}

	internal static bool LWSpH9GZAYyrVeHEGMn0(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}
}
