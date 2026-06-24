using System;
using System.Collections.Generic;
using System.Reflection;
using System.Web;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.FullTextSearch.Enum;
using EleWise.ELMA.FullTextSearch.Model;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Helpers;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.FullTextSearch.Descriptors;

public class HtmlStringPropertyDescriptor : FullTextPropertyDescriptor
{
	private static HtmlStringPropertyDescriptor EjIYvwG8ktjdSXDxYJ4E;

	public override bool IsSupportedFullTextSearchInIndex => true;

	public HtmlStringPropertyDescriptor(ISerializableTypeDescriptor typeDescriptor)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(typeDescriptor);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
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
			new FieldIndexListItem(SortFieldName(propMd), null, FullTextFieldType.String, FullTextFieldTag.Sort)
		};
	}

	public override FieldIndexList GetIndexField(object obj, IPropertyMetadata propMd, bool reindex)
	{
		//Discarded unreachable code: IL_0079
		int num = 1;
		int num2 = num;
		string value = default(string);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return new FieldIndexList();
			default:
				value = (string)k6MQAOG822wqK330is5A(obj);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				if (propMd != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			case 2:
				return new FieldIndexList
				{
					new FieldIndexListItem(ValueFieldName(propMd), value, FullTextFieldType.String),
					new FieldIndexListItem(SortFieldName(propMd), value, FullTextFieldType.String)
				};
			}
		}
	}

	public override FieldListItem GetSearchField(object value, IPropertyMetadata propMd)
	{
		int num = 1;
		int num2 = num;
		HtmlStringWrapper htmlStringWrapper = default(HtmlStringWrapper);
		while (true)
		{
			switch (num2)
			{
			case 1:
				htmlStringWrapper = value as HtmlStringWrapper;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return new FieldListItem(ValueFieldName(propMd), (string)((htmlStringWrapper != null && DNvwxpG8eCZHJhiTSwn9(htmlStringWrapper) != null) ? DNvwxpG8eCZHJhiTSwn9(htmlStringWrapper) : string.Empty));
			}
		}
	}

	public override List<string> GetReturnField(IPropertyMetadata propMd)
	{
		return new List<string> { ValueFieldName(propMd) };
	}

	public override SortListItem GetSortField(IPropertyMetadata propMd)
	{
		return new SortListItem(SortFieldName(propMd), FullTextFieldType.String);
	}

	public override void SetIndexField(object obj, object value, IPropertyMetadata propMd)
	{
		//Discarded unreachable code: IL_009e, IL_00d1, IL_0128, IL_013b, IL_014a, IL_015a, IL_0169
		int num = 4;
		WebDataItem webDataItem = default(WebDataItem);
		PropertyInfo propertyCached = default(PropertyInfo);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					webDataItem = value as WebDataItem;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
					{
						num2 = 0;
					}
					continue;
				case 9:
					try
					{
						RRrtBAG83j4CbwjsaDeJ(propertyCached, obj, new HtmlString(webDataItem.Value), null);
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
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
					catch (Exception exception)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
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
							((ILogger)NAPPF4G8p6Cr8Sd97Qtf()).Warn(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-195614443 ^ -195763203), exception);
							num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
							{
								num4 = 1;
							}
						}
					}
				case 2:
					return;
				case 8:
					return;
				case 6:
					return;
				case 3:
					if (propMd != null)
					{
						propertyCached = obj.GetType().GetPropertyCached((string)LH0P7SG8PHdD2H0B1hUb(propMd));
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
						{
							num2 = 1;
						}
					}
					else
					{
						num2 = 6;
					}
					continue;
				case 4:
					if (obj == null)
					{
						return;
					}
					num2 = 3;
					continue;
				case 7:
					if (webDataItem == null)
					{
						num2 = 8;
						continue;
					}
					break;
				case 11:
					return;
				case 1:
					if (propertyCached == null)
					{
						num2 = 2;
						continue;
					}
					goto case 7;
				case 10:
					return;
				}
				if (jZpC05G8NWxLRYsoHNo9(wPIoFSG817k2Y0JW98RK(webDataItem), ValueFieldName(propMd)))
				{
					break;
				}
				num2 = 9;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
				{
					num2 = 8;
				}
			}
			num = 10;
		}
	}

	public override void SetEmptyIndexField(object obj, IPropertyMetadata propMd, string fieldName)
	{
		//Discarded unreachable code: IL_007e, IL_008d, IL_009c, IL_0140, IL_01fc, IL_0213
		int num = 3;
		int num2 = num;
		PropertyInfo propertyCached = default(PropertyInfo);
		object value2 = default(object);
		object value = default(object);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				return;
			case 9:
				if (propMd != null)
				{
					num2 = 10;
					continue;
				}
				return;
			case 4:
				if (propertyCached == null)
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
				{
					num2 = 0;
				}
				continue;
			case 7:
				try
				{
					int num3;
					if (nD2BHYG8ag838DhGtvje(propMd as PropertyMetadata))
					{
						num3 = 2;
						goto IL_0119;
					}
					goto IL_014a;
					IL_0119:
					while (true)
					{
						switch (num3)
						{
						default:
							return;
						case 0:
							return;
						case 3:
							break;
						case 1:
							propertyCached.SetValue(obj, value2, null);
							num3 = 5;
							continue;
						case 2:
							propertyCached.SetValue(obj, null, null);
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
							{
								num3 = 0;
							}
							continue;
						case 4:
							value2 = base.TypeDescriptor.DeserializeSimple(value, XmxiEGG8D131UCp7KYhF(typeof(HtmlString).TypeHandle));
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
							{
								num3 = 1;
							}
							continue;
						case 5:
							return;
						}
						break;
					}
					goto IL_014a;
					IL_014a:
					value = base.TypeDescriptor.SerializeSimple(null, XmxiEGG8D131UCp7KYhF(typeof(HtmlString).TypeHandle));
					int num4 = 4;
					num3 = num4;
					goto IL_0119;
				}
				catch (Exception)
				{
					int num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
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
			case 8:
				return;
			case 10:
				propertyCached = obj.GetType().GetPropertyCached((string)LH0P7SG8PHdD2H0B1hUb(propMd));
				num2 = 4;
				continue;
			case 5:
				if (propMd is PropertyMetadata)
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
					{
						num2 = 7;
					}
				}
				else
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
					{
						num2 = 1;
					}
				}
				continue;
			case 3:
				if (obj == null)
				{
					num2 = 2;
					continue;
				}
				goto case 9;
			case 6:
				return;
			}
			if (!jZpC05G8NWxLRYsoHNo9(fieldName, ValueFieldName(propMd)))
			{
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
				{
					num2 = 5;
				}
				continue;
			}
			return;
		}
	}

	internal static bool VKt2t3G8nVPVp24pV2Fj()
	{
		return EjIYvwG8ktjdSXDxYJ4E == null;
	}

	internal static HtmlStringPropertyDescriptor OZLhQQG8Oj9RFOHdasZ8()
	{
		return EjIYvwG8ktjdSXDxYJ4E;
	}

	internal static object k6MQAOG822wqK330is5A(object P_0)
	{
		return Convert.ToString(P_0);
	}

	internal static object DNvwxpG8eCZHJhiTSwn9(object P_0)
	{
		return ((HtmlStringWrapper)P_0).HtmlValue;
	}

	internal static object LH0P7SG8PHdD2H0B1hUb(object P_0)
	{
		return ((IPropertyMetadata)P_0).Name;
	}

	internal static object wPIoFSG817k2Y0JW98RK(object P_0)
	{
		return ((WebDataItem)P_0).Name;
	}

	internal static bool jZpC05G8NWxLRYsoHNo9(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}

	internal static void RRrtBAG83j4CbwjsaDeJ(object P_0, object P_1, object P_2, object P_3)
	{
		((PropertyInfo)P_0).SetValue(P_1, P_2, (object[])P_3);
	}

	internal static object NAPPF4G8p6Cr8Sd97Qtf()
	{
		return Logger.Log;
	}

	internal static bool nD2BHYG8ag838DhGtvje(object P_0)
	{
		return ((PropertyMetadata)P_0).Nullable;
	}

	internal static Type XmxiEGG8D131UCp7KYhF(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}
}
