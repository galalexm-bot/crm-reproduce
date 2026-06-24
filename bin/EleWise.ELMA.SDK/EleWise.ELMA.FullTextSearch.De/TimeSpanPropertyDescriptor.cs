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

public class TimeSpanPropertyDescriptor : FullTextPropertyDescriptor
{
	internal static TimeSpanPropertyDescriptor Hne08EGIBkO27JekZA1x;

	public TimeSpanPropertyDescriptor(ISerializableTypeDescriptor typeDescriptor)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		whe80mGIb3i9qHBNdpxK();
		base._002Ector(typeDescriptor);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
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
			default:
				return GetIndexField(obj, propMd);
			case 1:
				if (reindex)
				{
					return GetReIndexField(obj, propMd);
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private FieldIndexList GetIndexField(object obj, IPropertyMetadata propMd)
	{
		//Discarded unreachable code: IL_005f, IL_00e8
		int num = 1;
		TimeSpan timeSpan = default(TimeSpan);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					timeSpan = (TimeSpan)obj;
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
					{
						num2 = 2;
					}
					continue;
				case 1:
					if (propMd == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 5;
				case 6:
					if (obj is TimeSpan)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
						{
							num2 = 2;
						}
						continue;
					}
					break;
				case 3:
					return new FieldIndexList
					{
						new FieldIndexListItem(ValueFieldName(propMd), H2CpafGIh04ZdN9xFFRV(timeSpan.Ticks), FullTextFieldType.Long)
					};
				case 5:
					if (obj == null)
					{
						goto end_IL_0012;
					}
					goto case 6;
				}
				return new FieldIndexList();
				continue;
				end_IL_0012:
				break;
			}
			num = 4;
		}
	}

	private FieldIndexList GetReIndexField(object obj, IPropertyMetadata propMd)
	{
		//Discarded unreachable code: IL_006e, IL_007d, IL_00db
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 4:
				if (propMd == null)
				{
					num2 = 3;
					break;
				}
				goto case 2;
			case 1:
				return new FieldIndexList
				{
					new FieldIndexListItem(ValueFieldName(propMd), null, FullTextFieldType.Long)
				};
			case 3:
			case 5:
				return new FieldIndexList();
			case 2:
				if (obj is TimeSpan)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
					{
						num2 = 0;
					}
					break;
				}
				if (obj != null)
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 1;
			default:
				return GetIndexField(obj, propMd);
			}
		}
	}

	public override FilterListItem GetFilterField(object value, IPropertyMetadata propMd, IEntityFilter filter)
	{
		//Discarded unreachable code: IL_007a, IL_0089, IL_0099, IL_014e, IL_0178, IL_01b0, IL_01bf
		switch (1)
		{
		case 1:
		{
			FilterListItem result = default(FilterListItem);
			try
			{
				TimeSpanWrapper timeSpanWrapper = value as TimeSpanWrapper;
				int num = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
				{
					num = 2;
				}
				TimeSpan? value2 = default(TimeSpan?);
				while (true)
				{
					switch (num)
					{
					case 2:
						break;
					case 4:
						break;
					default:
						if (!value2.HasValue)
						{
							num = 2;
							continue;
						}
						goto case 3;
					case 3:
					{
						string field = ValueFieldName(propMd);
						List<object> list = new List<object>();
						value2 = timeSpanWrapper.Value;
						list.Add(value2.Value.Ticks);
						result = new FilterListItem(field, list, FilterListItemType.Must, FullTextFieldType.Long);
						num = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
						{
							num = 1;
						}
						continue;
					}
					case 7:
						if (timeSpanWrapper == null)
						{
							int num2 = 4;
							num = num2;
							continue;
						}
						goto case 5;
					case 5:
						value2 = timeSpanWrapper.Value;
						num = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
						{
							num = 0;
						}
						continue;
					case 6:
						break;
					case 1:
						return result;
					}
					break;
				}
			}
			catch (Exception)
			{
				int num3 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
				{
					num3 = 1;
				}
				while (true)
				{
					switch (num3)
					{
					case 1:
						result = null;
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
						{
							num3 = 0;
						}
						break;
					default:
						return result;
					case 0:
						return result;
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
		return new SortListItem(ValueFieldName(propMd), FullTextFieldType.Long);
	}

	public override void SetIndexField(object obj, object value, IPropertyMetadata propMd)
	{
		//Discarded unreachable code: IL_009b, IL_00aa, IL_0170, IL_01c6, IL_01d5, IL_01f9, IL_0208, IL_0234, IL_0285, IL_0294
		int num = 5;
		int num2 = num;
		WebDataItem webDataItem = default(WebDataItem);
		PropertyInfo propertyCached = default(PropertyInfo);
		while (true)
		{
			switch (num2)
			{
			case 5:
				if (obj != null)
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
					{
						num2 = 4;
					}
					continue;
				}
				return;
			case 6:
				return;
			case 9:
				return;
			case 3:
				webDataItem = value as WebDataItem;
				num2 = 8;
				continue;
			case 1:
				return;
			case 10:
				return;
			case 4:
				if (propMd != null)
				{
					propertyCached = obj.GetType().GetPropertyCached((string)mv4JCYGIGbQXyZGrYobW(propMd));
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
					{
						num2 = 3;
					}
				}
				else
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
					{
						num2 = 1;
					}
				}
				continue;
			case 2:
				if (!ADr3xEGIf2e6dxKNi9Sg(webDataItem.Name, ValueFieldName(propMd)))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
					{
						num2 = 0;
					}
				}
				continue;
			case 8:
				if (gV7FX0GIEcrsjJ6tsRPp(propertyCached, null))
				{
					num2 = 9;
					continue;
				}
				break;
			default:
				try
				{
					int num3;
					if (!long.TryParse(webDataItem.Value, out var result))
					{
						num3 = 4;
						goto IL_0174;
					}
					goto IL_0192;
					IL_0174:
					while (true)
					{
						switch (num3)
						{
						case 1:
							return;
						case 3:
							return;
						case 2:
						case 4:
							goto IL_01e0;
						}
						break;
						IL_01e0:
						wxkrTqGIQRrYpGrcGinp(propertyCached, obj, null, null);
						num3 = 3;
					}
					goto IL_0192;
					IL_0192:
					wxkrTqGIQRrYpGrcGinp(propertyCached, obj, new TimeSpan(result), null);
					num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
					{
						num3 = 1;
					}
					goto IL_0174;
				}
				catch (Exception ex)
				{
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
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
						ExcdWPGIvbj6bAgk61bO(Logger.Log, GxFyZAGIChb6YqstuU4E(0xD3DEF7E ^ 0xD3E2596), ex);
						num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
						{
							num4 = 0;
						}
					}
				}
			case 7:
				break;
			}
			if (webDataItem == null)
			{
				break;
			}
			num2 = 2;
		}
	}

	internal static void whe80mGIb3i9qHBNdpxK()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool HcbWRiGIWHbf9ipCDbMR()
	{
		return Hne08EGIBkO27JekZA1x == null;
	}

	internal static TimeSpanPropertyDescriptor wgauRWGIo8ZmF8fidKVk()
	{
		return Hne08EGIBkO27JekZA1x;
	}

	internal static long H2CpafGIh04ZdN9xFFRV(long P_0)
	{
		return Convert.ToInt64(P_0);
	}

	internal static object mv4JCYGIGbQXyZGrYobW(object P_0)
	{
		return ((IPropertyMetadata)P_0).Name;
	}

	internal static bool gV7FX0GIEcrsjJ6tsRPp(object P_0, object P_1)
	{
		return (PropertyInfo)P_0 == (PropertyInfo)P_1;
	}

	internal static bool ADr3xEGIf2e6dxKNi9Sg(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}

	internal static void wxkrTqGIQRrYpGrcGinp(object P_0, object P_1, object P_2, object P_3)
	{
		((PropertyInfo)P_0).SetValue(P_1, P_2, (object[])P_3);
	}

	internal static object GxFyZAGIChb6YqstuU4E(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void ExcdWPGIvbj6bAgk61bO(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Warn(P_1, (Exception)P_2);
	}
}
