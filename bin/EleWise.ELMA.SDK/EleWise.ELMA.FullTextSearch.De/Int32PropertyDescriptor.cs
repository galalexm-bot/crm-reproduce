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

public class Int32PropertyDescriptor : FullTextPropertyDescriptor
{
	internal static Int32PropertyDescriptor uqqYVkGIPCMgNcHWoQ6R;

	public Int32PropertyDescriptor(ISerializableTypeDescriptor typeDescriptor)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		knsBjkGI3PH1jdq3egV4();
		base._002Ector(typeDescriptor);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return new FieldIndexList
				{
					new FieldIndexListItem(ValueFieldName(propMd), (obj == null) ? null : new long?(ufspQXGIpiKEpedun9we(obj)), FullTextFieldType.Long)
				};
			default:
				return new FieldIndexList();
			}
		}
	}

	public override FilterListItem GetFilterField(object value, IPropertyMetadata propMd, IEntityFilter filter)
	{
		//Discarded unreachable code: IL_003d, IL_0084, IL_0093, IL_00da, IL_010f, IL_0295, IL_02cd, IL_02dc
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
				Int32RangeWrapper int32RangeWrapper = value as Int32RangeWrapper;
				int num = 8;
				List<object> list = default(List<object>);
				while (true)
				{
					switch (num)
					{
					case 11:
						return result2;
					case 12:
						return result2;
					case 6:
						return result;
					case 9:
						if (HcZsX0GIaBnesKbS0ejI(int32RangeWrapper))
						{
							num = 2;
							continue;
						}
						goto case 7;
					case 2:
					case 3:
						list = new List<object>();
						num = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
						{
							num = 4;
						}
						continue;
					case 7:
						if (!YTWx3fGIDdT6saEr1xXg(int32RangeWrapper))
						{
							num = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
							{
								num = 0;
							}
							continue;
						}
						goto case 2;
					case 8:
						if (int32RangeWrapper != null)
						{
							num = 9;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
							{
								num = 9;
							}
							continue;
						}
						break;
					default:
						result = null;
						num = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
						{
							num = 6;
						}
						continue;
					case 5:
						result2 = new FilterListItem(ValueFieldName(propMd), list, FilterListItemType.Between, FullTextFieldType.Long);
						num = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
						{
							num = 12;
						}
						continue;
					case 10:
						list.Add(HcZsX0GIaBnesKbS0ejI(int32RangeWrapper) ? new long?(dBloHEGIwDU0THat8tvJ(wopHeiGItwMn8uscsyr8(int32RangeWrapper))) : null);
						num = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
						{
							num = 0;
						}
						continue;
					case 1:
						list.Add(YTWx3fGIDdT6saEr1xXg(int32RangeWrapper) ? new long?(dBloHEGIwDU0THat8tvJ(hXBG4sGI4kTDQjwSCKsb(int32RangeWrapper))) : null);
						num = 5;
						continue;
					case 4:
						break;
					}
					result2 = new FilterListItem(ValueFieldName(propMd), new List<object> { (value == null) ? null : new long?(ufspQXGIpiKEpedun9we(value)) }, FilterListItemType.Must, FullTextFieldType.Long);
					num = 11;
				}
			}
			catch (Exception)
			{
				int num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
				{
					num2 = 1;
				}
				while (true)
				{
					switch (num2)
					{
					default:
						return result;
					case 0:
						return result;
					case 1:
						result = null;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
						{
							num2 = 0;
						}
						break;
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
		//Discarded unreachable code: IL_0103, IL_0112, IL_0136, IL_0145, IL_0171, IL_01c2, IL_01d1, IL_0219, IL_0228
		int num = 9;
		WebDataItem webDataItem = default(WebDataItem);
		PropertyInfo propertyCached = default(PropertyInfo);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (webDataItem != null)
					{
						num2 = 4;
						continue;
					}
					return;
				case 4:
					if (VRw4h8GIAsb5Q8ygH6ph(i13rNZGIH6bMPXAym9lp(webDataItem), ValueFieldName(propMd)))
					{
						num2 = 3;
						continue;
					}
					goto end_IL_0012;
				case 9:
					if (obj == null)
					{
						num2 = 8;
						continue;
					}
					break;
				case 10:
					try
					{
						int num3;
						if (!int.TryParse(webDataItem.Value, out var result))
						{
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
							{
								num3 = 0;
							}
							goto IL_00c2;
						}
						goto IL_00e0;
						IL_00e0:
						FLGwN0GI7US6vbB5KYBS(propertyCached, obj, result, null);
						int num4 = 2;
						num3 = num4;
						goto IL_00c2;
						IL_00c2:
						while (true)
						{
							switch (num3)
							{
							case 3:
								break;
							default:
								goto IL_011d;
							case 2:
								return;
							case 4:
								return;
							}
							break;
							IL_011d:
							FLGwN0GI7US6vbB5KYBS(propertyCached, obj, null, null);
							num3 = 4;
						}
						goto IL_00e0;
					}
					catch (Exception ex)
					{
						int num5 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
						{
							num5 = 0;
						}
						while (true)
						{
							switch (num5)
							{
							case 1:
								return;
							}
							EdwCr4GImiInXsWj4ybn(FaWCAGGIxDVcJ7BC5l1T(), U2bbtGGI08I39uSqt7jw(-1487388570 ^ -1487172978), ex);
							num5 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
							{
								num5 = 1;
							}
						}
					}
				case 6:
					return;
				case 7:
					if (!XC58VkGI6Xe9ENT3viNY(propertyCached, null))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
						{
							num2 = 2;
						}
						continue;
					}
					return;
				case 3:
					return;
				case 8:
					return;
				case 5:
					return;
				case 1:
					webDataItem = value as WebDataItem;
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
					{
						num2 = 7;
					}
					continue;
				}
				if (propMd != null)
				{
					propertyCached = obj.GetType().GetPropertyCached(propMd.Name);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
					{
						num2 = 1;
					}
				}
				else
				{
					num2 = 5;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 10;
		}
	}

	public override void SetEmptyIndexField(object obj, IPropertyMetadata propMd, string fieldName)
	{
		//Discarded unreachable code: IL_00f2, IL_0101, IL_0126, IL_0151, IL_0219, IL_0230, IL_023f
		int num = 3;
		int num2 = num;
		PropertyInfo propertyCached = default(PropertyInfo);
		object obj2 = default(object);
		object value = default(object);
		while (true)
		{
			switch (num2)
			{
			case 8:
				if (!VRw4h8GIAsb5Q8ygH6ph(fieldName, ValueFieldName(propMd)))
				{
					num2 = 5;
					break;
				}
				return;
			case 10:
				return;
			default:
				propertyCached = obj.GetType().GetPropertyCached((string)jl8YrNGIyQb4X6sXOu1w(propMd));
				num2 = 4;
				break;
			case 3:
				if (obj == null)
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				if (propMd == null)
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				if (!(propMd is PropertyMetadata))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
					{
						num2 = 1;
					}
				}
				else
				{
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
					{
						num2 = 2;
					}
				}
				break;
			case 6:
				return;
			case 7:
				return;
			case 9:
				try
				{
					int num3;
					if (SxXvoHGIM8ZJcqOaK7q0(propMd as PropertyMetadata))
					{
						num3 = 5;
						goto IL_012a;
					}
					goto IL_0180;
					IL_012a:
					while (true)
					{
						switch (num3)
						{
						default:
							return;
						case 0:
							return;
						case 4:
							return;
						case 1:
							FLGwN0GI7US6vbB5KYBS(propertyCached, obj, obj2, null);
							num3 = 4;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
							{
								num3 = 4;
							}
							continue;
						case 3:
							break;
						case 2:
							obj2 = base.TypeDescriptor.DeserializeSimple(value, typeof(int));
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
							{
								num3 = 0;
							}
							continue;
						case 5:
							FLGwN0GI7US6vbB5KYBS(propertyCached, obj, null, null);
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
							{
								num3 = 0;
							}
							continue;
						}
						break;
					}
					goto IL_0180;
					IL_0180:
					value = base.TypeDescriptor.SerializeSimple(null, g8ZblNGIJX25BhwZ6Pp3(typeof(int).TypeHandle));
					num3 = 2;
					goto IL_012a;
				}
				catch (Exception)
				{
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
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
			case 4:
				if (propertyCached == null)
				{
					num2 = 7;
					break;
				}
				goto case 8;
			case 1:
				return;
			}
		}
	}

	internal static void knsBjkGI3PH1jdq3egV4()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool fEfjQuGI1M7l4juklTqa()
	{
		return uqqYVkGIPCMgNcHWoQ6R == null;
	}

	internal static Int32PropertyDescriptor lNFijPGIN7TqQBSH8roC()
	{
		return uqqYVkGIPCMgNcHWoQ6R;
	}

	internal static long ufspQXGIpiKEpedun9we(object P_0)
	{
		return Convert.ToInt64(P_0);
	}

	internal static bool HcZsX0GIaBnesKbS0ejI(object P_0)
	{
		return ((Int32RangeWrapper)P_0).HasFromValue;
	}

	internal static bool YTWx3fGIDdT6saEr1xXg(object P_0)
	{
		return ((Int32RangeWrapper)P_0).HasToValue;
	}

	internal static int wopHeiGItwMn8uscsyr8(object P_0)
	{
		return ((Int32RangeWrapper)P_0).From;
	}

	internal static long dBloHEGIwDU0THat8tvJ(int P_0)
	{
		return Convert.ToInt64(P_0);
	}

	internal static int hXBG4sGI4kTDQjwSCKsb(object P_0)
	{
		return ((Int32RangeWrapper)P_0).To;
	}

	internal static bool XC58VkGI6Xe9ENT3viNY(object P_0, object P_1)
	{
		return (PropertyInfo)P_0 == (PropertyInfo)P_1;
	}

	internal static object i13rNZGIH6bMPXAym9lp(object P_0)
	{
		return ((WebDataItem)P_0).Name;
	}

	internal static bool VRw4h8GIAsb5Q8ygH6ph(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}

	internal static void FLGwN0GI7US6vbB5KYBS(object P_0, object P_1, object P_2, object P_3)
	{
		((PropertyInfo)P_0).SetValue(P_1, P_2, (object[])P_3);
	}

	internal static object FaWCAGGIxDVcJ7BC5l1T()
	{
		return Logger.Log;
	}

	internal static object U2bbtGGI08I39uSqt7jw(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void EdwCr4GImiInXsWj4ybn(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Warn(P_1, (Exception)P_2);
	}

	internal static object jl8YrNGIyQb4X6sXOu1w(object P_0)
	{
		return ((IPropertyMetadata)P_0).Name;
	}

	internal static bool SxXvoHGIM8ZJcqOaK7q0(object P_0)
	{
		return ((PropertyMetadata)P_0).Nullable;
	}

	internal static Type g8ZblNGIJX25BhwZ6Pp3(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}
}
