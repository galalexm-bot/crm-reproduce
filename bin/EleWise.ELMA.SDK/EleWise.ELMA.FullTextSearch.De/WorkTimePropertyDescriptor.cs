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

public class WorkTimePropertyDescriptor : FullTextPropertyDescriptor
{
	internal static WorkTimePropertyDescriptor qNstEWGu990mVm4LimTQ;

	public WorkTimePropertyDescriptor(ISerializableTypeDescriptor typeDescriptor)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		aE5xiDGurGROOPHkpQyv();
		base._002Ector(typeDescriptor);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
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
		//Discarded unreachable code: IL_004d, IL_005c
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (reindex)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto default;
			default:
				return GetIndexField(obj, propMd);
			case 1:
				return GetReIndexField(obj, propMd);
			}
		}
	}

	private FieldIndexList GetIndexField(object obj, IPropertyMetadata propMd)
	{
		//Discarded unreachable code: IL_0049, IL_0058
		int num = 3;
		int num2 = num;
		WorkTime workTime = default(WorkTime);
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (obj == null)
				{
					num2 = 4;
					continue;
				}
				goto case 1;
			case 1:
				if (obj is WorkTime)
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
					{
						num2 = 5;
					}
					continue;
				}
				break;
			case 3:
				if (propMd != null)
				{
					num2 = 2;
					continue;
				}
				break;
			case 5:
				workTime = (WorkTime)obj;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
				{
					num2 = 0;
				}
				continue;
			default:
				return new FieldIndexList
				{
					new FieldIndexListItem(ValueFieldName(propMd), workTime.HasValue ? new long?(iTrtsdGugH6NwIZXudr9(workTime.Value)) : new long?(0L), FullTextFieldType.Long)
				};
			case 4:
				break;
			}
			break;
		}
		return new FieldIndexList();
	}

	private FieldIndexList GetReIndexField(object obj, IPropertyMetadata propMd)
	{
		//Discarded unreachable code: IL_0039, IL_0048, IL_0078
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (propMd != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			case 5:
				return GetIndexField(obj, propMd);
			case 3:
				if (obj != null)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
					{
						num2 = 4;
					}
					continue;
				}
				goto default;
			case 1:
				if (!(obj is WorkTime))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
					{
						num2 = 3;
					}
					continue;
				}
				goto case 5;
			default:
				return new FieldIndexList
				{
					new FieldIndexListItem(ValueFieldName(propMd), 0, FullTextFieldType.Long)
				};
			case 4:
				break;
			}
			break;
		}
		return new FieldIndexList();
	}

	public override FilterListItem GetFilterField(object value, IPropertyMetadata propMd, IEntityFilter filter)
	{
		//Discarded unreachable code: IL_0091, IL_00a0
		int num = 3;
		int num2 = num;
		WorkTimeWrapper workTimeWrapper = default(WorkTimeWrapper);
		while (true)
		{
			switch (num2)
			{
			case 3:
				workTimeWrapper = value as WorkTimeWrapper;
				num2 = 2;
				break;
			case 2:
				if (workTimeWrapper != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			case 1:
				return null;
			default:
				return new FilterListItem(ValueFieldName(propMd), new List<object> { vrWa4KGu5v6UL7gfrxVv(workTimeWrapper) }, FilterListItemType.Must, FullTextFieldType.Long);
			}
		}
	}

	public override SortListItem GetSortField(IPropertyMetadata propMd)
	{
		return new SortListItem(ValueFieldName(propMd), FullTextFieldType.Long);
	}

	public override void SetIndexField(object obj, object value, IPropertyMetadata propMd)
	{
		//Discarded unreachable code: IL_0072, IL_0081, IL_00f2, IL_0115, IL_0124, IL_019d, IL_01f4, IL_0203
		int num = 8;
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
				case 10:
					if (webDataItem == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 4;
				case 2:
					return;
				case 8:
					if (obj != null)
					{
						num2 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
						{
							num2 = 4;
						}
						continue;
					}
					return;
				case 4:
					if (!((string)ztpcHLGuL0kESnc1eNsw(webDataItem) != ValueFieldName(propMd)))
					{
						num2 = 5;
						continue;
					}
					return;
				case 9:
					try
					{
						int num3;
						if (long.TryParse((string)JBp9jYGuUXnGfPpZAKaP(webDataItem), out var result))
						{
							num3 = 3;
							goto IL_00f6;
						}
						goto IL_012f;
						IL_00f6:
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
							case 1:
								break;
							case 3:
								goto IL_015d;
							}
							break;
							IL_015d:
							propertyCached.SetValue(obj, new WorkTime(result), null);
							num3 = 2;
						}
						goto IL_012f;
						IL_012f:
						WS3uqkGusX9sCXMxruSI(propertyCached, obj, new WorkTime(0), null);
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
						{
							num3 = 0;
						}
						goto IL_00f6;
					}
					catch (Exception ex)
					{
						int num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
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
								qEOsg7GuzEyYTEp9hMBg(Logger.Log, BKHxPSGucdGMd0EXLbmm(0x4D1C1EE4 ^ 0x4D1FD40C), ex);
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
								{
									num4 = 0;
								}
								break;
							}
						}
					}
				case 0:
					return;
				case 7:
					if (propMd == null)
					{
						num2 = 6;
						continue;
					}
					propertyCached = obj.GetType().GetPropertyCached((string)QqNLwBGujqTZHlxOZw6A(propMd));
					num2 = 11;
					continue;
				case 1:
					return;
				case 5:
					break;
				case 6:
					return;
				case 3:
					if (YxoXfZGuYL2hfXxQVXVT(propertyCached, null))
					{
						return;
					}
					num2 = 10;
					continue;
				case 11:
					webDataItem = value as WebDataItem;
					num2 = 3;
					continue;
				}
				break;
			}
			num = 9;
		}
	}

	public override void SetEmptyIndexField(object obj, IPropertyMetadata propMd, string fieldName)
	{
		//Discarded unreachable code: IL_004e, IL_00a2, IL_00d4, IL_00eb, IL_00fa, IL_014b
		int num = 1;
		int num2 = num;
		PropertyInfo propertyCached = default(PropertyInfo);
		while (true)
		{
			switch (num2)
			{
			case 8:
				return;
			case 3:
				return;
			case 4:
				if (YxoXfZGuYL2hfXxQVXVT(propertyCached, null))
				{
					num2 = 3;
					continue;
				}
				goto case 6;
			case 5:
				try
				{
					WS3uqkGusX9sCXMxruSI(propertyCached, obj, default(WorkTime), null);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
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
				catch (Exception)
				{
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
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
			case 6:
				if (!qainxxGIFeonDXlN0Frf(fieldName, ValueFieldName(propMd)))
				{
					num2 = 7;
					continue;
				}
				return;
			case 1:
				if (obj != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				return;
			case 7:
				if (!(propMd is PropertyMetadata))
				{
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
					{
						num2 = 9;
					}
				}
				else
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
					{
						num2 = 2;
					}
				}
				continue;
			case 9:
				return;
			case 10:
				return;
			case 2:
				propertyCached = obj.GetType().GetPropertyCached((string)QqNLwBGujqTZHlxOZw6A(propMd));
				num2 = 4;
				continue;
			}
			if (propMd != null)
			{
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
				{
					num2 = 0;
				}
				continue;
			}
			return;
		}
	}

	internal static void aE5xiDGurGROOPHkpQyv()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool BgSiAeGudpa3mSALKvJg()
	{
		return qNstEWGu990mVm4LimTQ == null;
	}

	internal static WorkTimePropertyDescriptor UfncJIGul5tKcmEDVKiZ()
	{
		return qNstEWGu990mVm4LimTQ;
	}

	internal static long iTrtsdGugH6NwIZXudr9(long P_0)
	{
		return Convert.ToInt64(P_0);
	}

	internal static long vrWa4KGu5v6UL7gfrxVv(object P_0)
	{
		return ((WorkTimeWrapper)P_0).Value;
	}

	internal static object QqNLwBGujqTZHlxOZw6A(object P_0)
	{
		return ((IPropertyMetadata)P_0).Name;
	}

	internal static bool YxoXfZGuYL2hfXxQVXVT(object P_0, object P_1)
	{
		return (PropertyInfo)P_0 == (PropertyInfo)P_1;
	}

	internal static object ztpcHLGuL0kESnc1eNsw(object P_0)
	{
		return ((WebDataItem)P_0).Name;
	}

	internal static object JBp9jYGuUXnGfPpZAKaP(object P_0)
	{
		return ((WebDataItem)P_0).Value;
	}

	internal static void WS3uqkGusX9sCXMxruSI(object P_0, object P_1, object P_2, object P_3)
	{
		((PropertyInfo)P_0).SetValue(P_1, P_2, (object[])P_3);
	}

	internal static object BKHxPSGucdGMd0EXLbmm(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void qEOsg7GuzEyYTEp9hMBg(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Warn(P_1, (Exception)P_2);
	}

	internal static bool qainxxGIFeonDXlN0Frf(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}
}
