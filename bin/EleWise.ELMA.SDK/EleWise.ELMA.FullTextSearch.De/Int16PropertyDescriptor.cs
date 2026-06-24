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

public class Int16PropertyDescriptor : FullTextPropertyDescriptor
{
	internal static Int16PropertyDescriptor guG8TcGZ7ktjEq1hvIEc;

	public Int16PropertyDescriptor(ISerializableTypeDescriptor typeDescriptor)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		XGFZ3UGZmfOckq0KBuys();
		base._002Ector(typeDescriptor);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return new FieldIndexList
				{
					new FieldIndexListItem(ValueFieldName(propMd), (obj == null) ? null : new long?(Ix7VD5GZyvgm2T8JwMfh(obj)), FullTextFieldType.Long)
				};
			default:
				return new FieldIndexList();
			}
		}
	}

	public override FilterListItem GetFilterField(object value, IPropertyMetadata propMd, IEntityFilter filter)
	{
		//Discarded unreachable code: IL_003d, IL_0084, IL_0093, IL_00ca, IL_00d9, IL_00e8, IL_0255, IL_028d, IL_029c
		FilterListItem result = default(FilterListItem);
		switch (1)
		{
		default:
			return result;
		case 1:
		{
			FilterListItem result2 = default(FilterListItem);
			try
			{
				Int16RangeWrapper int16RangeWrapper = value as Int16RangeWrapper;
				int num = 2;
				List<object> list = default(List<object>);
				while (true)
				{
					switch (num)
					{
					case 1:
						return result;
					case 7:
						return result;
					case 10:
						return result2;
					case 11:
						if (Hk3aOGGZMa81LibbGfZb(int16RangeWrapper))
						{
							num = 4;
							continue;
						}
						goto case 12;
					case 4:
					case 6:
						list = new List<object>();
						num = 5;
						continue;
					case 2:
						if (int16RangeWrapper != null)
						{
							num = 9;
							continue;
						}
						break;
					case 9:
						if (!int16RangeWrapper.HasFromValue)
						{
							num = 11;
							continue;
						}
						goto case 4;
					case 8:
						result = new FilterListItem(ValueFieldName(propMd), list, FilterListItemType.Between, FullTextFieldType.Long);
						num = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
						{
							num = 1;
						}
						continue;
					case 12:
						result2 = null;
						num = 10;
						continue;
					case 5:
						list.Add(XWZHcKGZJVPIrDxuhoRu(int16RangeWrapper) ? new long?(Convert.ToInt64(Fme1uBGZ9TeVm9uokS4d(int16RangeWrapper))) : null);
						num = 3;
						continue;
					case 3:
						list.Add(Hk3aOGGZMa81LibbGfZb(int16RangeWrapper) ? new long?(dyPpUIGZlR5kbjtvxqaN(DgfYjhGZdrFNiut3AU4r(int16RangeWrapper))) : null);
						num = 8;
						continue;
					}
					result = new FilterListItem(ValueFieldName(propMd), new List<object> { (value == null) ? null : new long?(Convert.ToInt64(value)) }, FilterListItemType.Must, FullTextFieldType.Long);
					num = 7;
				}
			}
			catch (Exception)
			{
				int num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
				{
					num2 = 0;
				}
				while (true)
				{
					switch (num2)
					{
					case 1:
						return result2;
					}
					result2 = null;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
					{
						num2 = 1;
					}
				}
			}
		}
		}
	}

	public override SortListItem GetSortField(IPropertyMetadata propMd)
	{
		return new SortListItem(ValueFieldName(propMd), FullTextFieldType.Long);
	}

	public override void SetIndexField(object obj, object value, IPropertyMetadata propMd)
	{
		//Discarded unreachable code: IL_0055, IL_00b3, IL_0112, IL_0159, IL_0168, IL_01ae, IL_01ff, IL_020e, IL_0276
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
					if (webDataItem != null)
					{
						num2 = 8;
						continue;
					}
					return;
				case 4:
					return;
				case 7:
					break;
				case 6:
					return;
				case 9:
					return;
				case 1:
					propertyCached = obj.GetType().GetPropertyCached(propMd.Name);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
					{
						num2 = 11;
					}
					continue;
				case 3:
					if (An9xgNGZrawlWEHbhp6G(propertyCached, null))
					{
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
					{
						num2 = 0;
					}
					continue;
				case 10:
					if (obj == null)
					{
						num2 = 9;
						continue;
					}
					goto case 5;
				case 12:
					try
					{
						int num3;
						if (short.TryParse(webDataItem.Value, out var result))
						{
							num3 = 2;
							goto IL_0116;
						}
						goto IL_0130;
						IL_0116:
						while (true)
						{
							switch (num3)
							{
							default:
								return;
							case 1:
								break;
							case 3:
								return;
							case 2:
								goto IL_0173;
							case 0:
								return;
							}
							break;
							IL_0173:
							MkVeHXGZjHSH1onYOAGo(propertyCached, obj, result, null);
							num3 = 3;
						}
						goto IL_0130;
						IL_0130:
						MkVeHXGZjHSH1onYOAGo(propertyCached, obj, null, null);
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
						{
							num3 = 0;
						}
						goto IL_0116;
					}
					catch (Exception ex)
					{
						int num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
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
								VZktPQGZUmttt9UjHF93(hAWPlfGZYrmuuTlAk5aC(), hMWl90GZLUeEMSlCbcbC(-87337865 ^ -87515489), ex);
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
								{
									num4 = 0;
								}
								break;
							case 0:
								return;
							}
						}
					}
				case 8:
					if (PTRYXhGZ53K858ZyxUm6(v8UmDVGZg5owhqLuyuNh(webDataItem), ValueFieldName(propMd)))
					{
						return;
					}
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
					{
						num2 = 7;
					}
					continue;
				case 5:
					if (propMd == null)
					{
						return;
					}
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
					{
						num2 = 1;
					}
					continue;
				case 2:
					return;
				case 11:
					webDataItem = value as WebDataItem;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
					{
						num2 = 3;
					}
					continue;
				}
				break;
			}
			num = 12;
		}
	}

	public override void SetEmptyIndexField(object obj, IPropertyMetadata propMd, string fieldName)
	{
		//Discarded unreachable code: IL_00b1, IL_00c0, IL_00d0, IL_01c2, IL_01d1, IL_01fc, IL_0213, IL_026d
		int num = 8;
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
				default:
					return;
				case 1:
					if (propMd != null)
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
						{
							num2 = 6;
						}
						break;
					}
					return;
				case 3:
					if (PTRYXhGZ53K858ZyxUm6(fieldName, ValueFieldName(propMd)))
					{
						goto end_IL_0012;
					}
					goto case 10;
				case 12:
					if (!An9xgNGZrawlWEHbhp6G(propertyCached, null))
					{
						num2 = 3;
						break;
					}
					return;
				case 7:
					return;
				case 8:
					if (obj == null)
					{
						num2 = 7;
						break;
					}
					goto case 1;
				case 5:
					try
					{
						int num3;
						if (SFJroLGZcOHxX3RiAtys(propMd as PropertyMetadata))
						{
							num3 = 3;
							goto IL_0109;
						}
						goto IL_018b;
						IL_0109:
						while (true)
						{
							switch (num3)
							{
							default:
								return;
							case 1:
								obj2 = base.TypeDescriptor.DeserializeSimple(value, typeof(short));
								num3 = 4;
								continue;
							case 4:
								MkVeHXGZjHSH1onYOAGo(propertyCached, obj, obj2, null);
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
								{
									num3 = 0;
								}
								continue;
							case 3:
							{
								MkVeHXGZjHSH1onYOAGo(propertyCached, obj, null, null);
								int num4 = 2;
								num3 = num4;
								continue;
							}
							case 5:
								break;
							case 2:
								return;
							case 0:
								return;
							}
							break;
						}
						goto IL_018b;
						IL_018b:
						value = base.TypeDescriptor.SerializeSimple(null, n7demjGZzDotusDJkQxR(typeof(short).TypeHandle));
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
						{
							num3 = 1;
						}
						goto IL_0109;
					}
					catch (Exception)
					{
						int num5 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
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
				case 6:
					if (base.TypeDescriptor == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
						{
							num2 = 0;
						}
						break;
					}
					propertyCached = obj.GetType().GetPropertyCached((string)KBkjNrGZsLA3Xu91gSft(propMd));
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
					{
						num2 = 12;
					}
					break;
				case 2:
					return;
				case 10:
					if (propMd is PropertyMetadata)
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
						{
							num2 = 2;
						}
						break;
					}
					return;
				case 11:
					return;
				case 9:
					return;
				case 4:
					num2 = 5;
					break;
				case 0:
					return;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 11;
		}
	}

	internal static void XGFZ3UGZmfOckq0KBuys()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool y1YaSRGZxa5loxvqCGku()
	{
		return guG8TcGZ7ktjEq1hvIEc == null;
	}

	internal static Int16PropertyDescriptor oY0d4lGZ0wvxGSAEy9y5()
	{
		return guG8TcGZ7ktjEq1hvIEc;
	}

	internal static long Ix7VD5GZyvgm2T8JwMfh(object P_0)
	{
		return Convert.ToInt64(P_0);
	}

	internal static bool Hk3aOGGZMa81LibbGfZb(object P_0)
	{
		return ((Int16RangeWrapper)P_0).HasToValue;
	}

	internal static bool XWZHcKGZJVPIrDxuhoRu(object P_0)
	{
		return ((Int16RangeWrapper)P_0).HasFromValue;
	}

	internal static short Fme1uBGZ9TeVm9uokS4d(object P_0)
	{
		return ((Int16RangeWrapper)P_0).From;
	}

	internal static short DgfYjhGZdrFNiut3AU4r(object P_0)
	{
		return ((Int16RangeWrapper)P_0).To;
	}

	internal static long dyPpUIGZlR5kbjtvxqaN(short P_0)
	{
		return Convert.ToInt64(P_0);
	}

	internal static bool An9xgNGZrawlWEHbhp6G(object P_0, object P_1)
	{
		return (PropertyInfo)P_0 == (PropertyInfo)P_1;
	}

	internal static object v8UmDVGZg5owhqLuyuNh(object P_0)
	{
		return ((WebDataItem)P_0).Name;
	}

	internal static bool PTRYXhGZ53K858ZyxUm6(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}

	internal static void MkVeHXGZjHSH1onYOAGo(object P_0, object P_1, object P_2, object P_3)
	{
		((PropertyInfo)P_0).SetValue(P_1, P_2, (object[])P_3);
	}

	internal static object hAWPlfGZYrmuuTlAk5aC()
	{
		return Logger.Log;
	}

	internal static object hMWl90GZLUeEMSlCbcbC(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void VZktPQGZUmttt9UjHF93(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Warn(P_1, (Exception)P_2);
	}

	internal static object KBkjNrGZsLA3Xu91gSft(object P_0)
	{
		return ((IPropertyMetadata)P_0).Name;
	}

	internal static bool SFJroLGZcOHxX3RiAtys(object P_0)
	{
		return ((PropertyMetadata)P_0).Nullable;
	}

	internal static Type n7demjGZzDotusDJkQxR(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}
}
